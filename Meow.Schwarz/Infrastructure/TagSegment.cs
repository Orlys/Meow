// Author: Viyrex(aka Yuyu)
// Contact: mailto:viyrex.aka.yuyu@gmail.com
// Github: https://github.com/0x0001F36D
namespace Meow.Schwarz.Infrastructure
{
    using Auxiliary;
    using Interface;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    public abstract class TagSegment : ISegment
    {
        #region Public Constructors

        static TagSegment()
        {
            EMPTY_TAG_SYMBOLS = new HashSet<string>(AppDomain.CurrentDomain
                            .GetAssemblies()
                            .SelectMany(a => a.GetTypes())
                            .Where(t => t.IsSubclassOf(typeof(EmptyTag))
                                || t.IsSubclassOf(typeof(ParticularTagSegment)))
                            .Select(t => t.GetCustomAttribute<SymbolAttribute>() is SymbolAttribute sa
                                ? sa.Symbol.ToLower()
                                : t.Name.ToLower()));
        }

        #endregion Public Constructors

        #region Internal Constructors

        internal TagSegment(int start, int stop, string source, string tagName)
        {
            this._start = start;
            this._stop = stop;
            this.Source = source;
            this.TagName = (tagName ?? this.GetType().Name).ToLower();
        }

        internal TagSegment(int start, int stop, string source) : this(start, stop, source, null)
        {
        }

        #endregion Internal Constructors

        #region Protected Fields

        protected int _start;
        protected int _stop;

        #endregion Protected Fields

        #region Private Fields

        private readonly static HashSet<string> EMPTY_TAG_SYMBOLS;

        #endregion Private Fields

        /*
        private static HashSet<string> EMPTY_TAG_SYMBOLS;
        static TagSegment()   => EMPTY_TAG_SYMBOLS = new HashSet<string>();
        protected static void Register(EmptyTag emptyTag)
        {
            Debug.WriteLine("Register: "+emptyTag.TagName);
            var t = emptyTag.GetType();
            if (t.GetCustomAttribute<SymbolAttribute>() is SymbolAttribute sa)
                EMPTY_TAG_SYMBOLS.Add(sa.Symbol.ToLower());
            else
                EMPTY_TAG_SYMBOLS.Add(t.Name.ToLower());
        }*/

        /*
        private readonly static string[] EMPTY_TAG_SYMBOLS =
        {
            "!doctype",
            "area",
            "base",
            "br",
            "col",
            "embed",
            "hr",
            "img",
            "input",
            "keygen",
            "link",
            "meta",
            "param",
            "source",
            "track",
            "wbr"
        };*/

        #region Public Properties

        public virtual string Block
            => this.Source.Substring(this._start, this._stop - this._start + 1);

        //public int Start { get; protected set; }
        //public int Stop { get; protected set; }
        public string Source { get; }

        int IPosition.Start => this._start;

        int IPosition.Stop => this._stop;

        public virtual string TagName { get; protected set; }

        #endregion Public Properties

        #region Public Methods

        public static TagSegment Resolve(TagSegment segment)
        {
            var sCode = segment.Block.TrimStart('<').TrimEnd('>');
            if (sCode.First() == '/')
                return new EndTag(segment._start, segment._stop, segment.Source, sCode.TrimStart('/'));
            else
            {
                var tagBody = sCode.TrimEnd('/');//.TrimStart('!','?');//handles <!doctype ...> or <?xml ...>
                var isEmptyTag = EMPTY_TAG_SYMBOLS.Any(x => tagBody.ToLower().StartsWith(x));
                if (tagBody.Contains(" "))
                {
                    var nameLength = tagBody.IndexOf(' ');
                    var name = tagBody.Substring(0, nameLength);
                    tagBody = tagBody.Remove(0, nameLength);
                    return isEmptyTag
                        ? new EmptyTag(segment._start, segment._stop, segment.Source, name, tagBody) as TagSegment
                        : new StartTag(segment._start, segment._stop, segment.Source, name, tagBody);
                }
                else
                    return isEmptyTag
                        ? new EmptyTag(segment._start, segment._stop, segment.Source, tagBody) as TagSegment
                        : new StartTag(segment._start, segment._stop, segment.Source, tagBody);
            }
        }

        public virtual string TextLayout()
            => this.Block;

        public override string ToString()
                            => this.Block;

        #endregion Public Methods
    }
}