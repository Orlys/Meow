namespace Meow.Schwarz.Entity.Infrastructure
{
    using Interface;
    using System.Collections;
    using System.Collections.Generic;

    public class EmptyTag : AttributeTagSegment, IAttributeSegment, IEntitySegment
    {
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

        public string Content => string.Empty;

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
    }
}