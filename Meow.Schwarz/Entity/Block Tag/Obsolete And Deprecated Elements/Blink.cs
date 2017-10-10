namespace Meow.Schwarz.Entity
{
    using Auxiliary;
    using Infrastructure; using Interface;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Blink Element
    /// </summary>
    [Obsolete]
    [Deprecated]
    public sealed class Blink : BlockTag
    {
        internal Blink(StartTag startTag, EndTag endTag, IEnumerable<ISegment> children) : base(startTag, endTag, children)
        {
        }
    }
}