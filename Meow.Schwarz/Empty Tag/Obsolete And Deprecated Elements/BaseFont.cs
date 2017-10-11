// Author: Viyrex(aka Yuyu)
// Contact: mailto:viyrex.aka.yuyu@gmail.com
// Github: https://github.com/0x0001F36D
namespace Meow.Schwarz
{
    using Infrastructure;
    using System;

    /// <summary>
    /// BaseFont Element
    /// </summary>
    [Obsolete]
    public sealed class BaseFont : EmptyTag
    {
        internal BaseFont(int start, int stop, string source, Attributes attributes) : base(start, stop, source, attributes)
        {
        }

        public string Color { get => this.Attributes[nameof(Color)]; set => this.Attributes[nameof(Color)] = value; }

        public string Face { get => this.Attributes[nameof(Face)]; set => this.Attributes[nameof(Face)] = value; }

        public string Size { get => this.Attributes[nameof(Size)]; set => this.Attributes[nameof(Size)] = value; }
    }
}