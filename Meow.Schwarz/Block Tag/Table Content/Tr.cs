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
    /// Tr Element
    /// </summary>
    [RequireStart]
    public sealed class Tr : BlockTag
    {
        internal Tr(StartTag startTag, EndTag endTag, IEnumerable<ISegment> children) : base(startTag, endTag, children)
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

        [Obsolete]
        [Deprecated]
        public string VAlign { get => this.Attributes[nameof(VAlign)]; set => this.Attributes[nameof(VAlign)] = value; }
    }
}