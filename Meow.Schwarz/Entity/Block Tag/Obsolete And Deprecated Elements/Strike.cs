namespace Meow.Schwarz.Entity
{
    using Infrastructure; using Interface;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Strike Element
    /// </summary>
    [Obsolete]
    public sealed class Strike : BlockTag
    {
        internal Strike(StartTag startTag, EndTag endTag, IEnumerable<ISegment> children) : base(startTag, endTag, children)
        {
        }
    }
}