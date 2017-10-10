namespace Meow.Schwarz.Entity
{
    using Infrastructure; using Interface;
    using System.Collections.Generic;

    /// <summary>
    /// FieldSet Element
    /// </summary>
    public sealed class FieldSet : BlockTag
    {
        internal FieldSet(StartTag startTag, EndTag endTag, IEnumerable<ISegment> children) : base(startTag, endTag, children)
        {
        }

        public string Disabled { get => this.Attributes[nameof(Disabled)]; set => this.Attributes[nameof(Disabled)] = value; }

        public string Form { get => this.Attributes[nameof(Form)]; set => this.Attributes[nameof(Form)] = value; }

        public string Name { get => this.Attributes[nameof(Name)]; set => this.Attributes[nameof(Name)] = value; }
    }
}