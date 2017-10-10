namespace Meow.Schwarz.Entity
{
    using Infrastructure; using Interface;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// H2 Element
    /// </summary>
    public sealed class H2 : BlockTag
    {
        internal H2(StartTag startTag, EndTag endTag, IEnumerable<ISegment> children) : base(startTag, endTag, children)
        {
        }

        [Obsolete]
        public string Align { get => this.Attributes[nameof(Align)]; set => this.Attributes[nameof(Align)] = value; }
    }
}