// Author: Viyrex(aka Yuyu)
// Contact: mailto:viyrex.aka.yuyu@gmail.com
// Github: https://github.com/0x0001F36D
namespace Meow.Schwarz.Infrastructure
{
    using Interface;
    using System.Collections;
    using System.Collections.Generic;

    public class EmptyTag : AttributeTagSegment, IAttributeSegment, Iegment
    {
        #region Internal Constructors

        internal EmptyTag(int start, int stop, string source) : this(start, stop, source, default(string))
        {
        }

        internal EmptyTag(int start, int stop, string source, Attributes attributes) : this(start, stop, source, default, attributes)
        {
        }

        internal EmptyTag(int start, int stop, string source, string tagName) : this(start, stop, source, tagName, default(string))
        {
        }

        internal EmptyTag(int start, int stop, string source, string tagName, string attributesString) : this(start, stop, source, tagName, attributesString is default ? new Attributes() : Attributes.Resolve(attributesString))
        {
        }

        internal EmptyTag(int start, int stop, string source, string tagName, Attributes attributes) : base(start, stop, source, tagName, attributes)
        {
        }

        #endregion Internal Constructors

        #region Public Properties

        public string Content => string.Empty;

        #endregion Public Properties

        #region Public Methods

        public IEnumerator<ISegment> GetEnumerator()
        {
            return _().GetEnumerator();
            IEnumerable<ISegment> _()
            {
                yield break;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

        public override string TextLayout() => $"<{this.TagName}{this.Attributes.Format()}>";

        #endregion Public Methods
    }
}