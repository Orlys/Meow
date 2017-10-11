// Author: Viyrex(aka Yuyu)
// Contact: mailto:viyrex.aka.yuyu@gmail.com
// Github: https://github.com/0x0001F36D
namespace Meow.Schwarz
{
    using Auxiliary;
    using Infrastructure;
    using Interface;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Reflection;
    using System.Text;

    public sealed class Meow
    {
        #region Private Enums

        private enum QMode
        {
            List,
            Route,
        }

        #endregion Private Enums

        #region Private Delegates

        private delegate Iegment Invoker(params object[] args);

        #endregion Private Delegates

        #region Private Constructors

        private Meow(string html)
        {
            this._caches = new Dictionary<string, Invoker>();
            this.Raw = html;
            this._list = new List<ISegment>(this.Segmenter());
        }

        #endregion Private Constructors

        #region Private Fields

        private readonly IDictionary<string, Invoker> _caches;

        private readonly List<ISegment> _list;

        #endregion Private Fields

        #region Public Properties

        public ICollection<string> CacheKeys => this._caches.Keys;

        public int Count => this._list.Count;

        public IReadOnlyList<ISegment> Entities => this._list;

        public string Raw { get; }

        #endregion Public Properties

        #region Public Indexers

        public ISegment this[int index] => this._list[index];

        #endregion Public Indexers

        #region Public Methods

        public static Meow Load(string html)
            => new Meow(html?.Trim() ?? throw new ArgumentNullException(nameof(html)));

        public string Layout()
            => this._list.Aggregate(new StringBuilder(), (sb, q) => sb.Append(q.TextLayout())).ToString();

        public IEnumerable<T> Resolve<T>() where T : Iegment
                    => this._list.OfType<T>();

        public IEnumerable<T> Resolve<T>(Predicate<T> predicate) where T : Iegment
        {
            foreach (var item in this.Resolve<T>())
                if (predicate(item))
                    yield return item;
        }

        public IEnumerable<ValueContent> ResolveAllText()
            => this._list.OfType<IBlockTag>().SelectMany(x => x.OfType<ValueContent>());

        #endregion Public Methods

        #region Private Methods

        private Invoker BuildInvoker(ConstructorInfo ctor)
        {
            var param = Expression.Parameter(typeof(object[]));
            var lambda =
                Expression.Lambda<Invoker>(Expression.New(ctor, ctor.GetParameters()
                    .Aggregate(new List<Expression>(), (l, p) =>
                    {
                        l.Add(Expression.Convert(Expression.ArrayIndex(param, Expression.Constant(l.Count)), p.ParameterType));
                        return l;
                    })), param).Compile();

            return lambda;
        }

        private IEnumerable<ISegment> Deconstruct()
        {
            var tag_start_index = 0;
            var content_start_index = 0;
            for (int i = 0; i < this.Raw.Length; i++)
            {
                switch (this.Raw[i])
                {
                    case '<':

                        if (Doctype.Preprocess(this.Raw, ref i, out var block) ||
                            Comment.Preprocess(this.Raw, ref i, out block) ||
                            Script.Preprocess(this.Raw, ref i, out block) ||
                            Style.Preprocess(this.Raw, ref i, out block))
                        {
                            yield return DataSegment.Resolve(content_start_index, block.Start, this.Raw);
                            if (block is IBlockTag tb)
                            {
                                yield return tb.StartTag;
                                foreach (var item in tb.Children)
                                    yield return item;
                                yield return tb.EndTag;
                            }
                            else
                                yield return block;
                            content_start_index = i;
                            continue;
                        }
                        tag_start_index = i;
                        if (content_start_index == -1)
                            break;
                        yield return DataSegment.Resolve(content_start_index, i, this.Raw);
                        content_start_index = -1;
                        break;

                    case '>':
                        content_start_index = i;
                        if (tag_start_index == -1)
                            break;
                        var tag = TagSegment.Resolve(new ParticularTagSegment(tag_start_index, i, this.Raw));
                        yield return tag;
                        tag_start_index = -1;
                        break;
                }
            }

            yield break;
        }

        private IEnumerable<ISegment> Segmenter(bool captureEmptyContent = false, QMode qMode = default)
        {
            return r1(Deconstruct());
            IEnumerable<ISegment> r1(IEnumerable<ISegment> segments)
            {
                var q = new Stack<ISegment>();
                var cache = default(Iegment);

                foreach (var seg in segments)
                {
                    switch (seg)
                    {
                        case EmptyContent _:
                            if (captureEmptyContent)
                            {
                                if (qMode == QMode.List)
                                    yield return seg;
                                q.Push(seg);
                            }
                            break;

                        case StartTag _:
                            q.Push(seg);
                            break;

                        case EmptyTag et:
                            if (_caches.TryGetValue(et.TagName, out var delg))
                                cache = _caches[et.TagName](((IPosition)et).Start, ((IPosition)et).Stop, et.Source, et.Attributes);

                            // not found
                            else if (AppDomain.CurrentDomain
                                     .GetAssemblies()
                                     .SelectMany(t => t.GetTypes())
                                     .FirstOrDefault(x => x.IsSubclassOf(typeof(EmptyTag)) && string.Equals(x.Name, et.TagName, StringComparison.CurrentCultureIgnoreCase))
                                     ?.GetConstructor(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.InvokeMethod, null,
                                     new[]
                                     {
                                        typeof(int),
                                        typeof(int),
                                        typeof(string),
                                        typeof(Attributes)
                                     }, null) is ConstructorInfo ci)
                                cache = (_caches[et.TagName] = this.BuildInvoker(ci))(((IPosition)et).Start, ((IPosition)et).Stop, et.Source, et.Attributes);
                            else
                            {
                                throw UnknownException.Instance;
                            }
                            if (qMode == QMode.List)
                                yield return cache;

                            q.Push(cache);
                            break;

                        case BlockTag _:
                        case ParticularTagSegment _:
                        case ValueContent _:
                            if (qMode == QMode.List)
                                yield return seg;
                            q.Push(seg);
                            break;

                        case EndTag end:
                            var l = new List<ISegment>();
                            Repeat:
                            if (q.Count == 0)
                                break;

                            var p = q.Pop();
                            if (p is StartTag st && st.TagName == end.TagName)
                            {
                                var tb = new BlockTag(st, end, r1(l).Reverse().ToList());
                                if (_caches.TryGetValue(tb.TagName, out delg))
                                    cache = _caches[tb.TagName](tb.StartTag, tb.EndTag, tb.Children);

                                // not found
                                else if (AppDomain.CurrentDomain
                                         .GetAssemblies()
                                         .SelectMany(t => t.GetTypes())
                                         .FirstOrDefault(x => x.IsSubclassOf(typeof(BlockTag)) && string.Equals(x.Name, tb.TagName, StringComparison.CurrentCultureIgnoreCase))
                                         ?.GetConstructor(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.InvokeMethod, null,
                                         new[]
                                         {
                                            typeof(StartTag),
                                            typeof(EndTag),
                                            typeof(IEnumerable<ISegment>)
                                         }, null) is ConstructorInfo ci)
                                    cache = (_caches[tb.TagName] = this.BuildInvoker(ci))(tb.StartTag, tb.EndTag, tb.Children);

                                // constructor missing
                                else
                                {
                                    cache = new RuntimeTag(tb);
                                }
                                if (qMode == QMode.List)
                                    yield return cache;
                                q.Push(cache);
                                break;
                            }
                            else
                            {
                                l.Add(p);
                                goto Repeat;
                            }
                    }
                }
                if (qMode == QMode.Route)
                    foreach (var item in q.Reverse())
                        yield return item;
            }
        }

        #endregion Private Methods
    }
}