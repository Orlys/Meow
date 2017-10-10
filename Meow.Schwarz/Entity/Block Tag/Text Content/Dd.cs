namespace Meow.Schwarz.Entity
{
    using Auxiliary;
    using Infrastructure; using Interface;
    using System.Collections.Generic;

    /// <summary>
    /// Dd Element
    /// </summary>
    [RequireStart]
    public sealed class Dd : BlockTag
    {
        internal Dd(StartTag startTag, EndTag endTag, IEnumerable<ISegment> children) : base(startTag, endTag, children)
        {
        }

        public string NoWrap { get => this.Attributes[nameof(NoWrap)]; set => this.Attributes[nameof(NoWrap)] = value; }
    }
}