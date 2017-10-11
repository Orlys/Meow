// Author: Viyrex(aka Yuyu)
// Contact: mailto:viyrex.aka.yuyu@gmail.com
// Github: https://github.com/0x0001F36D
namespace Meow.Schwarz
{
    using Infrastructure;
    using Interface;
    using System.Collections.Generic;

    /// <summary>
    /// Del Element
    /// </summary>
    public sealed class Del : BlockTag
    {
        #region Internal Constructors

        internal Del(StartTag startTag, EndTag endTag, IEnumerable<ISegment> children) : base(startTag, endTag, children)
        {
        }

        #endregion Internal Constructors

        #region Public Properties

        public string Cite { get => this.Attributes[nameof(Cite)]; set => this.Attributes[nameof(Cite)] = value; }

        public string DateTime { get => this.Attributes[nameof(DateTime)]; set => this.Attributes[nameof(DateTime)] = value; }

        #endregion Public Properties
    }
}