namespace Meow.Schwarz.Entity
{
    using Auxiliary;
    using Infrastructure; using Interface;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// P Element
    /// </summary>
    [RequireStart]
    public sealed class P : BlockTag
    {
        internal P(StartTag startTag, EndTag endTag, IEnumerable<ISegment> children) : base(startTag, endTag, children)
        {
        }

        [Obsolete]
        public string Align { get => this.Attributes[nameof(Align)]; set => this.Attributes[nameof(Align)] = value; }
    }
}