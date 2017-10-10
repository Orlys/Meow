namespace Meow.Schwarz.Entity
{
    using Auxiliary;
    using Infrastructure; using Interface;
    using System.Collections.Generic;

    /// <summary>
    /// Dl Element
    /// </summary>
    public sealed class Dl : BlockTag
    {
        internal Dl(StartTag startTag, EndTag endTag, IEnumerable<ISegment> children) : base(startTag, endTag, children)
        {
        }

        [NotStandardized]
        public string Compact { get => this.Attributes[nameof(Compact)]; set => this.Attributes[nameof(Compact)] = value; }
    }
}