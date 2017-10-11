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
    /// Ul Element
    /// </summary>
    public sealed class Ul : BlockTag
    {
        #region Internal Constructors

        internal Ul(StartTag startTag, EndTag endTag, IEnumerable<ISegment> children) : base(startTag, endTag, children)
        {
        }

        #endregion Internal Constructors

        #region Public Properties

        [Deprecated]
        public string Compact { get => this.Attributes[nameof(Compact)]; set => this.Attributes[nameof(Compact)] = value; }

        [Deprecated]
        public string Type { get => this.Attributes[nameof(Type)]; set => this.Attributes[nameof(Type)] = value; }

        #endregion Public Properties
    }
}