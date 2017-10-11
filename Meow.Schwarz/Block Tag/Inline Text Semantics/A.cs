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
    /// A Element
    /// </summary>
    public sealed class A : BlockTag
    {
        internal A(StartTag startTag, EndTag endTag, IEnumerable<ISegment> children) : base(startTag, endTag, children)
        {
        }

        public string Href { get => this.Attributes[nameof(Href)]; set => this.Attributes[nameof(Href)] = value; }

        public string HrefLang { get => this.Attributes[nameof(HrefLang)]; set => this.Attributes[nameof(HrefLang)] = value; }

        [Experimental]
        public string ReferrerPolicy { get => this.Attributes[nameof(ReferrerPolicy)]; set => this.Attributes[nameof(ReferrerPolicy)] = value; }

        public string Rel { get => this.Attributes[nameof(Rel)]; set => this.Attributes[nameof(Rel)] = value; }

        public string Target { get => this.Attributes[nameof(Target)]; set => this.Attributes[nameof(Target)] = value; }

        public string Type { get => this.Attributes[nameof(Type)]; set => this.Attributes[nameof(Type)] = value; }
    }
}