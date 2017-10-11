// Author: Viyrex(aka Yuyu)
// Contact: mailto:viyrex.aka.yuyu@gmail.com
// Github: https://github.com/0x0001F36D
namespace Meow.Schwarz
{
    using Auxiliary;
    using Infrastructure;

    /// <summary>
    /// Hr Element
    /// </summary>
    public sealed class Hr : EmptyTag
    {
        internal Hr(int start, int stop, string source, Attributes attributes) : base(start, stop, source, attributes)
        {
        }

        [Deprecated]
        public string Align { get => this.Attributes[nameof(Align)]; set => this.Attributes[nameof(Align)] = value; }

        [NotStandardized]
        public string Color { get => this.Attributes[nameof(Color)]; set => this.Attributes[nameof(Color)] = value; }

        [Deprecated]
        public string NoShade { get => this.Attributes[nameof(NoShade)]; set => this.Attributes[nameof(NoShade)] = value; }

        [Deprecated]
        public string Size { get => this.Attributes[nameof(Size)]; set => this.Attributes[nameof(Size)] = value; }

        [Deprecated]
        public string Width { get => this.Attributes[nameof(Width)]; set => this.Attributes[nameof(Width)] = value; }
    }
}