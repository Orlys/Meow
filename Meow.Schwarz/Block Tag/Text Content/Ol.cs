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
    /// Ol Element
    /// </summary>
    public sealed class Ol : BlockTag
    {
        internal Ol(StartTag startTag, EndTag endTag, IEnumerable<ISegment> children) : base(startTag, endTag, children)
        {
        }

        [Deprecated]
        public string Compact { get => this.Attributes[nameof(Compact)]; set => this.Attributes[nameof(Compact)] = value; }

        public string Reversed { get => this.Attributes[nameof(Reversed)]; set => this.Attributes[nameof(Reversed)] = value; }

        public string Start { get => this.Attributes[nameof(Start)]; set => this.Attributes[nameof(Start)] = value; }

        public string Type { get => this.Attributes[nameof(Type)]; set => this.Attributes[nameof(Type)] = value; }
    }
}