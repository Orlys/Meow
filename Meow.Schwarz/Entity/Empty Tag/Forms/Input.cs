namespace Meow.Schwarz.Entity
{
    using Auxiliary;
    using Infrastructure; using Interface;
    using System;

    /// <summary>
    /// Input Element
    /// </summary>
    public sealed class Input : EmptyTag
    {
        internal Input(int start, int stop, string source, Attributes attributes) : base(start, stop, source, attributes)
        {
        }

        public string Accept { get => this.Attributes[nameof(Accept)]; set => this.Attributes[nameof(Accept)] = value; }

        public string AutoCapitalize { get => this.Attributes[nameof(AutoCapitalize)]; set => this.Attributes[nameof(AutoCapitalize)] = value; }

        public string AutoComplete { get => this.Attributes[nameof(AutoComplete)]; set => this.Attributes[nameof(AutoComplete)] = value; }

        [NotStandardized]
        public string AutoCorrect { get => this.Attributes[nameof(AutoCorrect)]; set => this.Attributes[nameof(AutoCorrect)] = value; }

        public string AutoFocus { get => this.Attributes[nameof(AutoFocus)]; set => this.Attributes[nameof(AutoFocus)] = value; }

        public string Capture { get => this.Attributes[nameof(Capture)]; set => this.Attributes[nameof(Capture)] = value; }

        public string Check { get => this.Attributes[nameof(Check)]; set => this.Attributes[nameof(Check)] = value; }

        public string Disable { get => this.Attributes[nameof(Disable)]; set => this.Attributes[nameof(Disable)] = value; }

        public string Form { get => this.Attributes[nameof(Form)]; set => this.Attributes[nameof(Form)] = value; }

        public string FormAction { get => this.Attributes[nameof(FormAction)]; set => this.Attributes[nameof(FormAction)] = value; }

        public string FormEncType { get => this.Attributes[nameof(FormEncType)]; set => this.Attributes[nameof(FormEncType)] = value; }

        public string FormMethod { get => this.Attributes[nameof(FormMethod)]; set => this.Attributes[nameof(FormMethod)] = value; }

        public string FormNoValidate { get => this.Attributes[nameof(FormNoValidate)]; set => this.Attributes[nameof(FormNoValidate)] = value; }

        public string FOrmTarget { get => this.Attributes[nameof(FOrmTarget)]; set => this.Attributes[nameof(FOrmTarget)] = value; }

        public string Height { get => this.Attributes[nameof(Height)]; set => this.Attributes[nameof(Height)] = value; }

        [NotStandardized]
        public string Incremental { get => this.Attributes[nameof(Incremental)]; set => this.Attributes[nameof(Incremental)] = value; }

        public string InputMode { get => this.Attributes[nameof(InputMode)]; set => this.Attributes[nameof(InputMode)] = value; }

        public string List { get => this.Attributes[nameof(List)]; set => this.Attributes[nameof(List)] = value; }

        public string Max { get => this.Attributes[nameof(Max)]; set => this.Attributes[nameof(Max)] = value; }

        public string MaxLength { get => this.Attributes[nameof(MaxLength)]; set => this.Attributes[nameof(MaxLength)] = value; }

        public string Min { get => this.Attributes[nameof(Min)]; set => this.Attributes[nameof(Min)] = value; }

        public string MinLength { get => this.Attributes[nameof(MinLength)]; set => this.Attributes[nameof(MinLength)] = value; }

        [NotStandardized]
        public string MozActionHint { get => this.Attributes[nameof(MozActionHint)]; set => this.Attributes[nameof(MozActionHint)] = value; }

        public string Multiple { get => this.Attributes[nameof(Multiple)]; set => this.Attributes[nameof(Multiple)] = value; }

        public string Name { get => this.Attributes[nameof(Name)]; set => this.Attributes[nameof(Name)] = value; }

        public string Pattern { get => this.Attributes[nameof(Pattern)]; set => this.Attributes[nameof(Pattern)] = value; }

        public string PlaceHolder { get => this.Attributes[nameof(PlaceHolder)]; set => this.Attributes[nameof(PlaceHolder)] = value; }

        public string ReadOnly { get => this.Attributes[nameof(ReadOnly)]; set => this.Attributes[nameof(ReadOnly)] = value; }

        public string Required { get => this.Attributes[nameof(Required)]; set => this.Attributes[nameof(Required)] = value; }

        [NotStandardized]
        public string Results { get => this.Attributes[nameof(Results)]; set => this.Attributes[nameof(Results)] = value; }

        public string SelectionDirection { get => this.Attributes[nameof(SelectionDirection)]; set => this.Attributes[nameof(SelectionDirection)] = value; }

        public string SelectionEnd { get => this.Attributes[nameof(SelectionEnd)]; set => this.Attributes[nameof(SelectionEnd)] = value; }

        public string SelectionStart { get => this.Attributes[nameof(SelectionStart)]; set => this.Attributes[nameof(SelectionStart)] = value; }

        public string Size { get => this.Attributes[nameof(Size)]; set => this.Attributes[nameof(Size)] = value; }

        public string SpellCheck { get => this.Attributes[nameof(SpellCheck)]; set => this.Attributes[nameof(SpellCheck)] = value; }

        public string Src { get => this.Attributes[nameof(Src)]; set => this.Attributes[nameof(Src)] = value; }

        public string Step { get => this.Attributes[nameof(Step)]; set => this.Attributes[nameof(Step)] = value; }

        public string Type { get => this.Attributes[nameof(Type)]; set => this.Attributes[nameof(Type)] = value; }

        [Obsolete]
        public string UseMap { get => this.Attributes[nameof(UseMap)]; set => this.Attributes[nameof(UseMap)] = value; }

        public string Value { get => this.Attributes[nameof(Value)]; set => this.Attributes[nameof(Value)] = value; }

        [NotStandardized]
        public string WebKitDirectory { get => this.Attributes[nameof(WebKitDirectory)]; set => this.Attributes[nameof(WebKitDirectory)] = value; }

        public string Width { get => this.Attributes[nameof(Width)]; set => this.Attributes[nameof(Width)] = value; }

        [NotStandardized]
        public string X_Moz_ErrorMessage { get => this.Attributes[nameof(X_Moz_ErrorMessage).Replace('_', '-')]; set => this.Attributes[nameof(X_Moz_ErrorMessage).Replace('_', '-')] = value; }
    }
}