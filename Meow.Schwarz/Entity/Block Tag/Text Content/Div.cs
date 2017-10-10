namespace Meow.Schwarz.Entity
{
    using Infrastructure; using Interface;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Div Element
    /// </summary>
    public sealed class Div : BlockTag
    {
        internal Div(StartTag startTag, EndTag endTag, IEnumerable<ISegment> children) : base(startTag, endTag, children)
        {
        }

        [Obsolete]
        public string Align { get => this.Attributes[nameof(Align)]; set => this.Attributes[nameof(Align)] = value; }
    }
}