namespace Meow.Schwarz.Entity
{
    using Auxiliary;
    using Infrastructure; using Interface;
    using System.Collections.Generic;

    /// <summary>
    /// Li Element
    /// </summary>
    [RequireStart]
    public sealed class Li : BlockTag
    {
        internal Li(StartTag startTag, EndTag endTag, IEnumerable<ISegment> children) : base(startTag, endTag, children)
        {
        }

        [Deprecated]
        public string Type { get => this.Attributes[nameof(Type)]; set => this.Attributes[nameof(Type)] = value; }

        public string Value { get => this.Attributes[nameof(Value)]; set => this.Attributes[nameof(Value)] = value; }
    }
}