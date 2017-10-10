namespace Meow.Schwarz.Entity
{
    using Auxiliary;
    using Infrastructure; using Interface;
    using System.Collections.Generic;

    /// <summary>
    /// TextArea Element
    /// </summary>
    public sealed class TextArea : BlockTag
    {
        internal TextArea(StartTag startTag, EndTag endTag, IEnumerable<ISegment> children) : base(startTag, endTag, children)
        {
        }

        [NotStandardized]
        public string AutoCapitalize { get => this.Attributes[nameof(AutoCapitalize)]; set => this.Attributes[nameof(AutoCapitalize)] = value; }

        public string AutoComplete { get => this.Attributes[nameof(AutoComplete)]; set => this.Attributes[nameof(AutoComplete)] = value; }

        public string AutoFocus { get => this.Attributes[nameof(AutoFocus)]; set => this.Attributes[nameof(AutoFocus)] = value; }

        public string Cols { get => this.Attributes[nameof(Cols)]; set => this.Attributes[nameof(Cols)] = value; }

        public string Disable { get => this.Attributes[nameof(Disable)]; set => this.Attributes[nameof(Disable)] = value; }

        public string Form { get => this.Attributes[nameof(Form)]; set => this.Attributes[nameof(Form)] = value; }

        public string MaxLength { get => this.Attributes[nameof(MaxLength)]; set => this.Attributes[nameof(MaxLength)] = value; }

        public string MinLength { get => this.Attributes[nameof(MinLength)]; set => this.Attributes[nameof(MinLength)] = value; }

        public string Name { get => this.Attributes[nameof(Name)]; set => this.Attributes[nameof(Name)] = value; }

        public string PlaceHolder { get => this.Attributes[nameof(PlaceHolder)]; set => this.Attributes[nameof(PlaceHolder)] = value; }

        public string ReadOnly { get => this.Attributes[nameof(ReadOnly)]; set => this.Attributes[nameof(ReadOnly)] = value; }

        public string Required { get => this.Attributes[nameof(Required)]; set => this.Attributes[nameof(Required)] = value; }

        public string Rows { get => this.Attributes[nameof(Rows)]; set => this.Attributes[nameof(Rows)] = value; }

        public string SelectionDirection { get => this.Attributes[nameof(SelectionDirection)]; set => this.Attributes[nameof(SelectionDirection)] = value; }

        public string SelectionEnd { get => this.Attributes[nameof(SelectionEnd)]; set => this.Attributes[nameof(SelectionEnd)] = value; }

        public string SelectionStart { get => this.Attributes[nameof(SelectionStart)]; set => this.Attributes[nameof(SelectionStart)] = value; }

        public string SpellCheck { get => this.Attributes[nameof(SpellCheck)]; set => this.Attributes[nameof(SpellCheck)] = value; }

        public string Warp { get => this.Attributes[nameof(Warp)]; set => this.Attributes[nameof(Warp)] = value; }
    }
}