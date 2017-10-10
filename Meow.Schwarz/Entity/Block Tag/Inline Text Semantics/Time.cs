namespace Meow.Schwarz.Entity
{
    using Infrastructure; using Interface;
    using System.Collections.Generic;

    /// <summary>
    /// Time Element
    /// </summary>
    public sealed class Time : BlockTag
    {
        internal Time(StartTag startTag, EndTag endTag, IEnumerable<ISegment> children) : base(startTag, endTag, children)
        {
        }

        public string DateTime { get => this.Attributes[nameof(DateTime)]; set => this.Attributes[nameof(DateTime)] = value; }
    }
}