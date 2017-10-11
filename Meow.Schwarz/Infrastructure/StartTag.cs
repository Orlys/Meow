// Author: Viyrex(aka Yuyu)
// Contact: mailto:viyrex.aka.yuyu@gmail.com
// Github: https://github.com/0x0001F36D
namespace Meow.Schwarz.Infrastructure
{
    using Interface;

    public sealed class StartTag : AttributeTagSegment, IAttributeSegment
    {
        #region Internal Constructors

        internal StartTag(int start, int stop, string source, string tagName) : this(start, stop, source, tagName, default(string))
        {
        }

        internal StartTag(int start, int stop, string source, string tagName, string attributesString) : this(start, stop, source, tagName, attributesString is default ? new Attributes() : Attributes.Resolve(attributesString))
        {
        }

        internal StartTag(int start, int stop, string source, string tagName, Attributes attributes) : base(start, stop, source, tagName, attributes)
        {
        }

        #endregion Internal Constructors

        #region Public Methods

        public override string TextLayout()
        {
            return $"<{this.TagName}{this.Attributes.Format()}>";
        }

        #endregion Public Methods
    }
}