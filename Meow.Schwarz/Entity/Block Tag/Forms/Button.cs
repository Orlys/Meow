namespace Meow.Schwarz.Entity
{
    using Auxiliary;
    using Infrastructure; using Interface;
    using System.Collections.Generic;

    /// <summary>
    /// Button Element
    /// </summary>
    public sealed class Button : BlockTag
    {
        internal Button(StartTag startTag, EndTag endTag, IEnumerable<ISegment> children) : base(startTag, endTag, children)

        {
        }

        [NotStandardized]
        public string AutoComplete { get => this.Attributes[nameof(AutoComplete)]; set => this.Attributes[nameof(AutoComplete)] = value; }

        public string AutoFocus { get => this.Attributes[nameof(AutoFocus)]; set => this.Attributes[nameof(AutoFocus)] = value; }

        public string Disabled { get => this.Attributes[nameof(Disabled)]; set => this.Attributes[nameof(Disabled)] = value; }

        public string Form { get => this.Attributes[nameof(Form)]; set => this.Attributes[nameof(Form)] = value; }

        public string FormAction { get => this.Attributes[nameof(FormAction)]; set => this.Attributes[nameof(FormAction)] = value; }

        public string FormEncType { get => this.Attributes[nameof(FormEncType)]; set => this.Attributes[nameof(FormEncType)] = value; }

        public string FormMethod { get => this.Attributes[nameof(FormMethod)]; set => this.Attributes[nameof(FormMethod)] = value; }

        public string FormNoValidate { get => this.Attributes[nameof(FormNoValidate)]; set => this.Attributes[nameof(FormNoValidate)] = value; }

        public string FormTarget { get => this.Attributes[nameof(FormTarget)]; set => this.Attributes[nameof(FormTarget)] = value; }

        public string Name { get => this.Attributes[nameof(Name)]; set => this.Attributes[nameof(Name)] = value; }

        public string Type { get => this.Attributes[nameof(Type)]; set => this.Attributes[nameof(Type)] = value; }

        public string Value { get => this.Attributes[nameof(Value)]; set => this.Attributes[nameof(Value)] = value; }
    }
}