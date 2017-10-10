namespace Meow.Schwarz.Entity
{
    using Infrastructure; using Interface;
    using System.Collections.Generic;

    /// <summary>
    /// Dfn Element
    /// </summary>
    public sealed class Dfn : BlockTag
    {
        internal Dfn(StartTag startTag, EndTag endTag, IEnumerable<ISegment> children) : base(startTag, endTag, children)
        {
        }

        public new string Title { get; set; }
    }
}