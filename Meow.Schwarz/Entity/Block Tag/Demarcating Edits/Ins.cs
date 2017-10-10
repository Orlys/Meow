namespace Meow.Schwarz.Entity
{
    using Infrastructure; using Interface;
    using System.Collections.Generic;

    /// <summary>
    /// Ins Element
    /// </summary>
    public sealed class Ins : BlockTag
    {
        internal Ins(StartTag startTag, EndTag endTag, IEnumerable<ISegment> children) : base(startTag, endTag, children)
        {
        }

        public string Cite { get => this.Attributes[nameof(Cite)]; set => this.Attributes[nameof(Cite)] = value; }

        public string DateTime { get => this.Attributes[nameof(DateTime)]; set => this.Attributes[nameof(DateTime)] = value; }
    }
}