namespace Meow.Schwarz.Entity
{
    using Infrastructure;
    using Interface;
    using System.Collections.Generic;

    /// <summary>
    /// Article Element
    /// </summary>
    public sealed class Article : BlockTag
    {
        internal Article(StartTag startTag, EndTag endTag, IEnumerable<ISegment> children) : base(startTag, endTag, children)
        {
        }
    }
}