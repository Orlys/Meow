namespace Meow.Schwarz.Entity
{
    using Infrastructure; using Interface;
    using System.Collections.Generic;

    /// <summary>
    /// Dialog Element
    /// </summary>
    public sealed class Dialog : BlockTag
    {
        internal Dialog(StartTag startTag, EndTag endTag, IEnumerable<ISegment> children) : base(startTag, endTag, children)
        {
        }

        public string Open { get => this.Attributes[nameof(Open)]; set => this.Attributes[nameof(Open)] = value; }
    }
}