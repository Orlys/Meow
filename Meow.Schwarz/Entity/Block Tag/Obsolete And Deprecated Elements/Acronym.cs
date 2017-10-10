namespace Meow.Schwarz.Entity
{
    using Infrastructure; using Interface;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Acronym Element
    /// </summary>
    [Obsolete]
    public sealed class Acronym : BlockTag
    {
        internal Acronym(StartTag startTag, EndTag endTag, IEnumerable<ISegment> children) : base(startTag, endTag, children)
        {
        }
    }
}