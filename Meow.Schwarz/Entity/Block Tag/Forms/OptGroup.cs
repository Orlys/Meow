namespace Meow.Schwarz.Entity
{
    using Auxiliary;
    using Infrastructure; using Interface;
    using System.Collections.Generic;

    /// <summary>
    /// OptGroup Element
    /// </summary>

    [RequireStart]
    public sealed class OptGroup : BlockTag
    {
        internal OptGroup(StartTag startTag, EndTag endTag, IEnumerable<ISegment> children) : base(startTag, endTag, children)
        {
        }

        public string Disable { get => this.Attributes[nameof(Disable)]; set => this.Attributes[nameof(Disable)] = value; }

        public string Label { get => this.Attributes[nameof(Label)]; set => this.Attributes[nameof(Label)] = value; }
    }
}