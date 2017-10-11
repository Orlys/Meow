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
    /// Th Element
    /// </summary>
    [RequireStart]
    public sealed class Th : BlockTag
    {
        internal Th(StartTag startTag, EndTag endTag, IEnumerable<ISegment> children) : base(startTag, endTag, children)
        {
        }

        [Obsolete]
        public string Abbr { get => this.Attributes[nameof(Abbr)]; set => this.Attributes[nameof(Abbr)] = value; }

        [Obsolete]
        [Deprecated]
        public string Align { get => this.Attributes[nameof(Align)]; set => this.Attributes[nameof(Align)] = value; }

        [Obsolete]
        public string Axis { get => this.Attributes[nameof(Axis)]; set => this.Attributes[nameof(Axis)] = value; }

        [NotStandardized]
        public string BgColor { get => this.Attributes[nameof(BgColor)]; set => this.Attributes[nameof(BgColor)] = value; }

        [Obsolete]
        [Deprecated]
        public string Char { get => this.Attributes[nameof(Char)]; set => this.Attributes[nameof(Char)] = value; }

        [Obsolete]
        [Deprecated]
        public string CharOff { get => this.Attributes[nameof(CharOff)]; set => this.Attributes[nameof(CharOff)] = value; }

        public string ColSpan { get => this.Attributes[nameof(ColSpan)]; set => this.Attributes[nameof(ColSpan)] = value; }

        public string Headers { get => this.Attributes[nameof(Headers)]; set => this.Attributes[nameof(Headers)] = value; }

        public string RowSpan { get => this.Attributes[nameof(RowSpan)]; set => this.Attributes[nameof(RowSpan)] = value; }

        public string Scope { get => this.Attributes[nameof(Scope)]; set => this.Attributes[nameof(Scope)] = value; }

        [Obsolete]
        [Deprecated]
        public string VAlign { get => this.Attributes[nameof(VAlign)]; set => this.Attributes[nameof(VAlign)] = value; }

        [Deprecated]
        public string Width { get => this.Attributes[nameof(Width)]; set => this.Attributes[nameof(Width)] = value; }
    }
}