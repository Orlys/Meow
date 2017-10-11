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
    /// Audio Element
    /// </summary>
    public sealed class Audio : BlockTag
    {
        internal Audio(StartTag startTag, EndTag endTag, IEnumerable<ISegment> children) : base(startTag, endTag, children)
        {
        }

        [Obsolete]
        public string AutoBuffer { get => this.Attributes[nameof(AutoBuffer)]; set => this.Attributes[nameof(AutoBuffer)] = value; }

        public string AutoPlay { get => this.Attributes[nameof(AutoPlay)]; set => this.Attributes[nameof(AutoPlay)] = value; }

        public string Buffered { get => this.Attributes[nameof(Buffered)]; set => this.Attributes[nameof(Buffered)] = value; }

        public string Controls { get => this.Attributes[nameof(Controls)]; set => this.Attributes[nameof(Controls)] = value; }

        public string Loop { get => this.Attributes[nameof(Loop)]; set => this.Attributes[nameof(Loop)] = value; }

        [NotStandardized]
        public string MozCurrentSampleOffset { get => this.Attributes[nameof(MozCurrentSampleOffset)]; set => this.Attributes[nameof(MozCurrentSampleOffset)] = value; }

        public string Muted { get => this.Attributes[nameof(Muted)]; set => this.Attributes[nameof(Muted)] = value; }

        public string Played { get => this.Attributes[nameof(Played)]; set => this.Attributes[nameof(Played)] = value; }

        public string Preload { get => this.Attributes[nameof(Preload)]; set => this.Attributes[nameof(Preload)] = value; }

        public string Src { get => this.Attributes[nameof(Src)]; set => this.Attributes[nameof(Src)] = value; }

        public string Volume { get => this.Attributes[nameof(Volume)]; set => this.Attributes[nameof(Volume)] = value; }
    }
}