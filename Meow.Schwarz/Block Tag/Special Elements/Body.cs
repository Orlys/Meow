// Author: Viyrex(aka Yuyu)
// Contact: mailto:viyrex.aka.yuyu@gmail.com
// Github: https://github.com/0x0001F36D
namespace Meow.Schwarz
{
    using Infrastructure;
    using Interface;
    using System;
    using System.Collections.Generic;

    public sealed class Body : BlockTag
    {
        internal Body(StartTag startTag, EndTag endTag, IEnumerable<ISegment> children) : base(startTag, endTag, children)
        {
        }

        [Obsolete]
        public string ALink { get => this.Attributes[nameof(ALink)]; set => this.Attributes[nameof(ALink)] = value; }

        [Obsolete]
        public string Background { get => this.Attributes[nameof(Background)]; set => this.Attributes[nameof(Background)] = value; }

        [Obsolete]
        public string BgColor { get => this.Attributes[nameof(BgColor)]; set => this.Attributes[nameof(BgColor)] = value; }

        [Obsolete]
        public string BottomMargin { get => this.Attributes[nameof(BottomMargin)]; set => this.Attributes[nameof(BottomMargin)] = value; }

        [Obsolete]
        public string LeftMargin { get => this.Attributes[nameof(LeftMargin)]; set => this.Attributes[nameof(LeftMargin)] = value; }

        [Obsolete]
        public string Link { get => this.Attributes[nameof(Link)]; set => this.Attributes[nameof(Link)] = value; }

        [Obsolete]
        public string RightMargin { get => this.Attributes[nameof(RightMargin)]; set => this.Attributes[nameof(RightMargin)] = value; }

        [Obsolete]
        public string Text { get => this.Attributes[nameof(Text)]; set => this.Attributes[nameof(Text)] = value; }

        [Obsolete]
        public string TopMargin { get => this.Attributes[nameof(TopMargin)]; set => this.Attributes[nameof(TopMargin)] = value; }

        [Obsolete]
        public string VLink { get => this.Attributes[nameof(VLink)]; set => this.Attributes[nameof(VLink)] = value; }
    }
}