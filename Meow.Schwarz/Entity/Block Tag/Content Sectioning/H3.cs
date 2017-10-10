namespace Meow.Schwarz.Entity
{
    using Infrastructure; using Interface;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// H3 Element
    /// </summary>
    public sealed class H3 : BlockTag
    {
        internal H3(StartTag startTag, EndTag endTag, IEnumerable<ISegment> children) : base(startTag, endTag, children)
        {
        }

        [Obsolete]
        public string Align { get => this.Attributes[nameof(Align)]; set => this.Attributes[nameof(Align)] = value; }
    }
}