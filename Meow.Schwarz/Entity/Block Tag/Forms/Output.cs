namespace Meow.Schwarz.Entity
{
    using Infrastructure; using Interface;
    using System.Collections.Generic;

    /// <summary>
    /// Output Element
    /// </summary>
    public sealed class Output : BlockTag
    {
        internal Output(StartTag startTag, EndTag endTag, IEnumerable<ISegment> children) : base(startTag, endTag, children)
        {
        }

        public string For { get => this.Attributes[nameof(For)]; set => this.Attributes[nameof(For)] = value; }

        public string Form { get => this.Attributes[nameof(Form)]; set => this.Attributes[nameof(Form)] = value; }

        public string Name { get => this.Attributes[nameof(Name)]; set => this.Attributes[nameof(Name)] = value; }
    }
}