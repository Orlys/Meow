namespace Meow.Schwarz
{
    using Entity;
    using Entity.Interface;
    using Entity.Infrastructure;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Reflection;
    using System.Text;
    using System.Dynamic;
    using Entity.Auxiliary;

    public class Meow : IReadOnlyList<ISegment>
    {
        public ICollection<string> CacheKeys => this._caches.Keys;

        private readonly IDictionary<string, Invoker> _caches;

        private readonly List<ISegment> _list;

        private Meow(string html)
        {
            this._caches = new Dictionary<string, Invoker>();
            this.Raw = html;
            this._list = new List<ISegment>(this.Segmenter());
        }

        private delegate IEntitySegment Invoker(params object[] args);

        private enum QMode
        {
            List,
            Route,
        }

        public int Count => this._list.Count;

        public string Raw { get; }

        public ISegment this[int index] => this._list[index];

        public static Meow Load(string html)
            => new Meow(html?.Trim() ?? throw new ArgumentNullException(nameof(html)));

        public IEnumerator<ISegment> GetEnumerator() => ((IReadOnlyList<ISegment>)this._list).GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => ((IReadOnlyList<ISegment>)this._list).GetEnumerator();

        public IEnumerable<T> Query<T>() where T : IEntitySegment
            => this._list.OfType<T>();

        public IEnumerable<T> Query<T>(Predicate<T> predicate) where T : IEntitySegment
        {
            foreach (var item in this.Query<T>())
                if (predicate(item))
                    yield return item;
        }

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
                var delg = default(Invoker);
                var cache = default(IEntitySegment);

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
                            if (_caches.TryGetValue(et.TagName, out delg))
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
        


        public IEnumerable<ValueContent> QueryAllText()
            => this._list.OfType<IBlockTag>().SelectMany(x => x.OfType<ValueContent>());


        public string Layout()
            => this._list.Aggregate(new StringBuilder(), (sb, q) => sb.Append(q.TextLayout())).ToString();

        /*
        public IEnumerable<IEntitySegment> Route(params string[] tagName)
        {
            if (tagName is string[] s)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    this._list.First()
                }
            }
            yield break;
        }*/
    }
    
    public sealed class RuntimeTag : RuntimeAttributes, ISegment, IEntitySegment, IAttributeSegment
    {
        
        internal RuntimeTag(BlockTag blockTag):base(blockTag.Attributes)
        {
            this._segment = blockTag;
        }

        private readonly BlockTag _segment;

        public string Block => this._segment.Block;

        public string Source => this._segment.Source;

        public string TagName => this._segment.TagName;


        int IPosition.Start => ((IPosition)this._segment).Start;

        int IPosition.Stop => ((IPosition)this._segment).Stop;

        public string TextLayout() => this._segment.TextLayout();

        public string Content => ((IEntitySegment)this._segment).Content;

        public IEnumerator<ISegment> GetEnumerator() => ((IEntitySegment)this._segment).GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

        public Attributes Attributes => ((IAttributeSegment)this._segment).Attributes;

        public static implicit operator BlockTag(RuntimeTag rs)
            => rs._segment as BlockTag;

        public override string ToString() => this.Block;
    }
    public abstract class RuntimeAttributes : IDynamicMetaObjectProvider
    {
        protected RuntimeAttributes(Attributes attributes)
        {
            this._component = new DynamicComponent(attributes);
        }

        private readonly IDynamicMetaObjectProvider _component;
        private class DynamicComponent : DynamicObject
        {
            private readonly Attributes _attributes;
            public DynamicComponent(Attributes attributes)
            {
                this._attributes = attributes;
            }
            public override bool TryGetMember(GetMemberBinder binder, out object result)
            {
                result = this._attributes[binder.Name];
                return true;
            }
            public override bool TrySetMember(SetMemberBinder binder, object value)
            {
                this._attributes[binder.Name] = value?.ToString();
                return true;
            }
        }
        public DynamicMetaObject GetMetaObject(Expression parameter)
            => new DelegatingMetaObject(_component, parameter, BindingRestrictions.GetTypeRestriction(parameter, this.GetType()), this);


        private class DelegatingMetaObject : DynamicMetaObject
        {
            private readonly IDynamicMetaObjectProvider innerProvider;

            internal DelegatingMetaObject(IDynamicMetaObjectProvider innerProvider, Expression expr, BindingRestrictions restrictions)
                : base(expr, restrictions)
            {
                this.innerProvider = innerProvider;
            }

            internal DelegatingMetaObject(IDynamicMetaObjectProvider innerProvider, Expression expr, BindingRestrictions restrictions, object value)
                : base(expr, restrictions, value)
            {
                this.innerProvider = innerProvider;
            }

            public override DynamicMetaObject BindGetMember(GetMemberBinder binder)
                => innerProvider.GetMetaObject(Expression.Constant(innerProvider)).BindGetMember(binder);

            public override DynamicMetaObject BindSetMember(SetMemberBinder binder, DynamicMetaObject value)
                => innerProvider.GetMetaObject(Expression.Constant(innerProvider)).BindSetMember(binder, value);

        }
    }
}