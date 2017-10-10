namespace Meow.Schwarz.Entity
{
    using Auxiliary;
    using Infrastructure; using Interface;
    using System.Collections.Generic;

    /// <summary>
    /// FrameSet Element
    /// </summary>
    [Deprecated]
    public sealed class FrameSet : BlockTag
    {
        internal FrameSet(StartTag startTag, EndTag endTag, IEnumerable<ISegment> children) : base(startTag, endTag, children)
        {
        }

        public string Cols { get => this.Attributes[nameof(Cols)]; set => this.Attributes[nameof(Cols)] = value; }

        public string Rows { get => this.Attributes[nameof(Rows)]; set => this.Attributes[nameof(Rows)] = value; }
    }
}