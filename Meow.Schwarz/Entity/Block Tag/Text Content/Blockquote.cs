namespace Meow.Schwarz.Entity
{
    using Infrastructure; using Interface;
    using System.Collections.Generic;

    /// <summary>
    /// Blockquote Element
    /// </summary>
    public sealed class Blockquote : BlockTag
    {
        internal Blockquote(StartTag startTag, EndTag endTag, IEnumerable<ISegment> children) : base(startTag, endTag, children)
        {
        }

        public string Cite { get => this.Attributes[nameof(Cite)]; set => this.Attributes[nameof(Cite)] = value; }
    }
}