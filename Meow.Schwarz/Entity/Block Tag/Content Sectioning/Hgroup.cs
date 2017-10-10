namespace Meow.Schwarz.Entity
{
    using Infrastructure; using Interface;
    using System.Collections.Generic;

    /// <summary>
    /// HGroup Element
    /// </summary>
    public sealed class HGroup : BlockTag
    {
        internal HGroup(StartTag startTag, EndTag endTag, IEnumerable<ISegment> children) : base(startTag, endTag, children)
        {
        }
    }
}