namespace Meow.Schwarz.Entity.Infrastructure
{
    using Interface;

    public sealed class StartTag : AttributeTagSegment, IAttributeSegment
    {
        internal StartTag(int start, int stop, string source, string tagName) : this(start, stop, source, tagName, default(string))
        {
        }

        internal StartTag(int start, int stop, string source, string tagName, string attributesString) : this(start, stop, source, tagName, attributesString is default ? new Attributes() : Attributes.Resolve(attributesString))
        {
        }

        internal StartTag(int start, int stop, string source, string tagName, Attributes attributes) : base(start, stop, source, tagName, attributes)
        {
        }

        public override string TextLayout()
        {
            return $"<{this.TagName}{this.Attributes.Format()}>";
        }
    }
}