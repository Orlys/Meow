namespace Meow.Schwarz.Entity
{
    using Infrastructure; using Interface;
    using System.Collections.Generic;

    /// <summary>
    /// Meter Element
    /// </summary>
    public sealed class Meter : BlockTag
    {
        internal Meter(StartTag startTag, EndTag endTag, IEnumerable<ISegment> children) : base(startTag, endTag, children)
        {
        }

        public string Form { get => this.Attributes[nameof(Form)]; set => this.Attributes[nameof(Form)] = value; }

        public string High { get => this.Attributes[nameof(High)]; set => this.Attributes[nameof(High)] = value; }

        public string Low { get => this.Attributes[nameof(Low)]; set => this.Attributes[nameof(Low)] = value; }

        public string Max { get => this.Attributes[nameof(Max)]; set => this.Attributes[nameof(Max)] = value; }

        public string Min { get => this.Attributes[nameof(Min)]; set => this.Attributes[nameof(Min)] = value; }

        public string Optimum { get => this.Attributes[nameof(Optimum)]; set => this.Attributes[nameof(Optimum)] = value; }

        public string Value { get => this.Attributes[nameof(Value)]; set => this.Attributes[nameof(Value)] = value; }
    }
}