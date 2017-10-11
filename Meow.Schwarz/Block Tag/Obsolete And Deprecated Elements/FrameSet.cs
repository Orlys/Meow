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
    /// FrameSet Element
    /// </summary>
    [Deprecated]
    public sealed class FrameSet : BlockTag
    {
        #region Internal Constructors

        internal FrameSet(StartTag startTag, EndTag endTag, IEnumerable<ISegment> children) : base(startTag, endTag, children)
        {
        }

        #endregion Internal Constructors

        #region Public Properties

        public string Cols { get => this.Attributes[nameof(Cols)]; set => this.Attributes[nameof(Cols)] = value; }

        public string Rows { get => this.Attributes[nameof(Rows)]; set => this.Attributes[nameof(Rows)] = value; }

        #endregion Public Properties
    }
}