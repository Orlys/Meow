namespace Meow.Schwarz.Entity
{
    using Auxiliary;
    using Infrastructure; using Interface;
    using System.Collections.Generic;

    /// <summary>
    /// Ul Element
    /// </summary>
    public sealed class Ul : BlockTag
    {
        internal Ul(StartTag startTag, EndTag endTag, IEnumerable<ISegment> children) : base(startTag, endTag, children)
        {
        }

        [Deprecated]
        public string Compact { get => this.Attributes[nameof(Compact)]; set => this.Attributes[nameof(Compact)] = value; }

        [Deprecated]
        public string Type { get => this.Attributes[nameof(Type)]; set => this.Attributes[nameof(Type)] = value; }
    }
}