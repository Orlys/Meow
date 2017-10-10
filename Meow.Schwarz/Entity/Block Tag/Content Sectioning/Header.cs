namespace Meow.Schwarz.Entity
{
    using Infrastructure; using Interface;
    using System.Collections.Generic;

    /// <summary>
    /// Header Element
    /// </summary>
    public sealed class Header : BlockTag
    {
        internal Header(StartTag startTag, EndTag endTag, IEnumerable<ISegment> children) : base(startTag, endTag, children)
        {
        }
    }
}