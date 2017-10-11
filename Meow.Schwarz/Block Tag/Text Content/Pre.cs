// Author: Viyrex(aka Yuyu)
// Contact: mailto:viyrex.aka.yuyu@gmail.com
// Github: https://github.com/0x0001F36D
namespace Meow.Schwarz
{
    using Auxiliary;
    using Infrastructure;
    using Interface;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Pre Element
    /// </summary>
    public sealed class Pre : BlockTag
    {
        internal Pre(StartTag startTag, EndTag endTag, IEnumerable<ISegment> children) : base(startTag, endTag, children)
        {
        }

        [Obsolete]
        [NotStandardized]
        public string Cols { get => this.Attributes[nameof(Cols)]; set => this.Attributes[nameof(Cols)] = value; }

        [Obsolete]
        public string Width { get => this.Attributes[nameof(Width)]; set => this.Attributes[nameof(Width)] = value; }

        [NotStandardized]
        public string Wrap { get => this.Attributes[nameof(Wrap)]; set => this.Attributes[nameof(Wrap)] = value; }
    }
}