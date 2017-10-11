// Author: Viyrex(aka Yuyu)
// Contact: mailto:viyrex.aka.yuyu@gmail.com
// Github: https://github.com/0x0001F36D
namespace Meow.Schwarz
{
    using Auxiliary;
    using Infrastructure;
    using Interface;
    using System.Collections.Generic;

    /// <summary>
    /// Table Element
    /// </summary>
    public sealed class Table : BlockTag
    {
        internal Table(StartTag startTag, EndTag endTag, IEnumerable<ISegment> children) : base(startTag, endTag, children)
        {
        }

        [Deprecated]
        public string Align { get => this.Attributes[nameof(Align)]; set => this.Attributes[nameof(Align)] = value; }

        [Deprecated]
        public string BgColor { get => this.Attributes[nameof(BgColor)]; set => this.Attributes[nameof(BgColor)] = value; }

        [Deprecated]
        public string Border { get => this.Attributes[nameof(Border)]; set => this.Attributes[nameof(Border)] = value; }

        [Deprecated]
        public string CellPadding { get => this.Attributes[nameof(CellPadding)]; set => this.Attributes[nameof(CellPadding)] = value; }

        [Deprecated]
        public string CellSpacing { get => this.Attributes[nameof(CellSpacing)]; set => this.Attributes[nameof(CellSpacing)] = value; }

        [Deprecated]
        public string Frame { get => this.Attributes[nameof(Frame)]; set => this.Attributes[nameof(Frame)] = value; }

        [Deprecated]
        public string Rules { get => this.Attributes[nameof(Rules)]; set => this.Attributes[nameof(Rules)] = value; }

        [Deprecated]
        public string Summary { get => this.Attributes[nameof(Summary)]; set => this.Attributes[nameof(Summary)] = value; }

        [Deprecated]
        public string Width { get => this.Attributes[nameof(Width)]; set => this.Attributes[nameof(Width)] = value; }
    }
}