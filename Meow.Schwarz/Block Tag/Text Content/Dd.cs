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
    /// Dd Element
    /// </summary>
    [RequireStart]
    public sealed class Dd : BlockTag
    {
        #region Internal Constructors

        internal Dd(StartTag startTag, EndTag endTag, IEnumerable<ISegment> children) : base(startTag, endTag, children)
        {
        }

        #endregion Internal Constructors

        #region Public Properties

        public string NoWrap { get => this.Attributes[nameof(NoWrap)]; set => this.Attributes[nameof(NoWrap)] = value; }

        #endregion Public Properties
    }
}