// Author: Viyrex(aka Yuyu)
// Contact: mailto:viyrex.aka.yuyu@gmail.com
// Github: https://github.com/0x0001F36D
namespace Meow.Schwarz
{
    using Infrastructure;
    using Interface;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Font Element
    /// </summary>
    [Obsolete]
    public sealed class Font : BlockTag
    {
        #region Internal Constructors

        internal Font(StartTag startTag, EndTag endTag, IEnumerable<ISegment> children) : base(startTag, endTag, children)
        {
        }

        #endregion Internal Constructors

        #region Public Properties

        public string Color { get => this.Attributes[nameof(Color)]; set => this.Attributes[nameof(Color)] = value; }

        public string Face { get => this.Attributes[nameof(Face)]; set => this.Attributes[nameof(Face)] = value; }

        public string Size { get => this.Attributes[nameof(Size)]; set => this.Attributes[nameof(Size)] = value; }

        #endregion Public Properties
    }
}