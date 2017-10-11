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
    /// Label Element
    /// </summary>
    public sealed class Label : BlockTag
    {
        #region Internal Constructors

        internal Label(StartTag startTag, EndTag endTag, IEnumerable<ISegment> children) : base(startTag, endTag, children)
        {
        }

        #endregion Internal Constructors

        #region Public Properties

        public string For { get => this.Attributes[nameof(For)]; set => this.Attributes[nameof(For)] = value; }

        [Obsolete]
        public string Form { get => this.Attributes[nameof(Form)]; set => this.Attributes[nameof(Form)] = value; }

        #endregion Public Properties
    }
}