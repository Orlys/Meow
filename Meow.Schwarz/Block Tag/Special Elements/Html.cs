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
    /// Html Element
    /// </summary>
    public sealed class Html : BlockTag
    {
        internal Html(StartTag startTag, EndTag endTag, IEnumerable<ISegment> children) : base(startTag, endTag, children)
        {
        }

        [Obsolete]
        public string Manifest { get => this.Attributes[nameof(Manifest)]; set => this.Attributes[nameof(Manifest)] = value; }

        [Obsolete]
        public string Version { get => this.Attributes[nameof(Version)]; set => this.Attributes[nameof(Version)] = value; }

        public string Xmlns { get => this.Attributes[nameof(Xmlns)]; set => this.Attributes[nameof(Xmlns)] = value; }
    }
}