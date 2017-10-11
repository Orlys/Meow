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
    /// Dl Element
    /// </summary>
    public sealed class Dl : BlockTag
    {
        #region Internal Constructors

        internal Dl(StartTag startTag, EndTag endTag, IEnumerable<ISegment> children) : base(startTag, endTag, children)
        {
        }

        #endregion Internal Constructors

        #region Public Properties

        [NotStandardized]
        public string Compact { get => this.Attributes[nameof(Compact)]; set => this.Attributes[nameof(Compact)] = value; }

        #endregion Public Properties
    }
}