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
    /// Head Element
    /// </summary>
    public sealed class Head : BlockTag
    {
        #region Internal Constructors

        internal Head(StartTag startTag, EndTag endTag, IEnumerable<ISegment> children) : base(startTag, endTag, children)
        {
        }

        #endregion Internal Constructors

        #region Public Properties

        [Obsolete]
        public string Profile { get => this.Attributes[nameof(Profile)]; set => this.Attributes[nameof(Profile)] = value; }

        #endregion Public Properties
    }
}