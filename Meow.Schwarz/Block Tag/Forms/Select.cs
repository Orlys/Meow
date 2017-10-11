// Author: Viyrex(aka Yuyu)
// Contact: mailto:viyrex.aka.yuyu@gmail.com
// Github: https://github.com/0x0001F36D
namespace Meow.Schwarz
{
    using Infrastructure;
    using Interface;
    using System.Collections.Generic;

    /// <summary>
    /// Select Element
    /// </summary>
    public sealed class Select : BlockTag
    {
        internal Select(StartTag startTag, EndTag endTag, IEnumerable<ISegment> children) : base(startTag, endTag, children)
        {
        }

        public string AutoFocus { get => this.Attributes[nameof(AutoFocus)]; set => this.Attributes[nameof(AutoFocus)] = value; }

        public string Disable { get => this.Attributes[nameof(Disable)]; set => this.Attributes[nameof(Disable)] = value; }

        public string Form { get => this.Attributes[nameof(Form)]; set => this.Attributes[nameof(Form)] = value; }

        public string Multiple { get => this.Attributes[nameof(Multiple)]; set => this.Attributes[nameof(Multiple)] = value; }

        public string Name { get => this.Attributes[nameof(Name)]; set => this.Attributes[nameof(Name)] = value; }

        public string Required { get => this.Attributes[nameof(Required)]; set => this.Attributes[nameof(Required)] = value; }

        public string Size { get => this.Attributes[nameof(Size)]; set => this.Attributes[nameof(Size)] = value; }
    }
}