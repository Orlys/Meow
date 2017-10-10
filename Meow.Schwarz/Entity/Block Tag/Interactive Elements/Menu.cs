namespace Meow.Schwarz.Entity
{
    using Infrastructure; using Interface;
    using System.Collections.Generic;

    /// <summary>
    /// Menu Element
    /// </summary>
    public sealed class Menu : BlockTag
    {
        internal Menu(StartTag startTag, EndTag endTag, IEnumerable<ISegment> children) : base(startTag, endTag, children)
        {
        }

        public string Label { get => this.Attributes[nameof(Label)]; set => this.Attributes[nameof(Label)] = value; }

        public string Type { get => this.Attributes[nameof(Type)]; set => this.Attributes[nameof(Type)] = value; }
    }
}