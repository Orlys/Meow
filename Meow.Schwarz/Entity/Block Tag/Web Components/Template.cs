namespace Meow.Schwarz.Entity
{
    using Infrastructure;
    using Interface;
    using System.Collections.Generic;

    /// <summary>
    /// Template Element
    /// </summary>
    public sealed class Template : BlockTag
    {
        internal Template(StartTag startTag, EndTag endTag, IEnumerable<ISegment> children) : base(startTag, endTag, children)
        {
        }
    }
}