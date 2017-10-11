// Author: Viyrex(aka Yuyu)
// Contact: mailto:viyrex.aka.yuyu@gmail.com
// Github: https://github.com/0x0001F36D
namespace Meow.Schwarz
{
    using Auxiliary;
    using Infrastructure;
    using Interface;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// TBody Element
    /// </summary>
    public sealed class TBody : BlockTag
    {
        internal TBody(StartTag startTag, EndTag endTag, IEnumerable<ISegment> children) : base(startTag, endTag, children)
        {
        }

        [Obsolete]
        [Deprecated]
        public string Align { get => this.Attributes[nameof(Align)]; set => this.Attributes[nameof(Align)] = value; }

        [NotStandardized]
        public string BgColor { get => this.Attributes[nameof(BgColor)]; set => this.Attributes[nameof(BgColor)] = value; }

        [Obsolete]
        [Deprecated]
        public string Char { get => this.Attributes[nameof(Char)]; set => this.Attributes[nameof(Char)] = value; }

        [Obsolete]
        [Deprecated]
        public string CharOff { get => this.Attributes[nameof(CharOff)]; set => this.Attributes[nameof(CharOff)] = value; }

        public string Span { get => this.Attributes[nameof(Span)]; set => this.Attributes[nameof(Span)] = value; }

        [Obsolete]
        [Deprecated]
        public string VAlign { get => this.Attributes[nameof(VAlign)]; set => this.Attributes[nameof(VAlign)] = value; }

        [Obsolete]
        public string Width { get => this.Attributes[nameof(Width)]; set => this.Attributes[nameof(Width)] = value; }
    }
}