namespace Meow.Schwarz.Entity
{
    using Infrastructure; using Interface;
    using System.Collections.Generic;

    /// <summary>
    /// Progress Element
    /// </summary>
    public sealed class Progress : BlockTag
    {
        internal Progress(StartTag startTag, EndTag endTag, IEnumerable<ISegment> children) : base(startTag, endTag, children)
        {
        }

        public string Max { get => this.Attributes[nameof(Max)]; set => this.Attributes[nameof(Max)] = value; }

        public string Value { get => this.Attributes[nameof(Value)]; set => this.Attributes[nameof(Value)] = value; }
    }
}