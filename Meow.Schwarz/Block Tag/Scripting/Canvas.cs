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
    /// Canvas Element
    /// </summary>
    public sealed class Canvas : BlockTag
    {
        #region Internal Constructors

        internal Canvas(StartTag startTag, EndTag endTag, IEnumerable<ISegment> children) : base(startTag, endTag, children)
        {
        }

        #endregion Internal Constructors

        #region Public Properties

        public string Height { get => this.Attributes[nameof(Height)]; set => this.Attributes[nameof(Height)] = value; }

        [NotStandardized]
        public string Moz_Opaque { get => this.Attributes[nameof(Moz_Opaque).Replace('_', '-')]; set => this.Attributes[nameof(Moz_Opaque).Replace('_', '-')] = value; }

        public string Width { get => this.Attributes[nameof(Width)]; set => this.Attributes[nameof(Width)] = value; }

        #endregion Public Properties
    }
}