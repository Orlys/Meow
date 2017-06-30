namespace Meow.Html.Elements
{
    using Meow.Html.Auxiliaries;
    using Meow.Html.Infrastructure;
    using System;

    /// <summary>
    /// Input Element
    /// </summary>
    public sealed class Input : EmptyElementBase
    {
        public string Accept { get; set; }

        [Obsolete]
        public new string AccessKey { get; set; }

        public string AutoCapitalize { get; set; }
        public string AutoComplete { get; set; }

        [NotStandardized]
        public string AutoCorrect { get; set; }

        public string AutoFocus { get; set; }
        public string Capture { get; set; }
        public string Check { get; set; }
        public string Disable { get; set; }

        public string Form { get; set; }
        public string FormAction { get; set; }
        public string FormEncType { get; set; }
        public string FormMethod { get; set; }
        public string FormNoValidate { get; set; }
        public string FOrmTarget { get; set; }
        public string Height { get; set; }

        [NotStandardized]
        public string Incremental { get; set; }

        public string InputMode { get; set; }
        public string List { get; set; }
        public string Max { get; set; }
        public string MaxLength { get; set; }
        public string Min { get; set; }
        public string MinLength { get; set; }

        [NotStandardized]
        public string MozActionHint { get; set; }

        public string Multiple { get; set; }
        public string Name { get; set; }
        public string Pattern { get; set; }
        public string PlaceHolder { get; set; }
        public string ReadOnly { get; set; }
        public string Required { get; set; }

        [NotStandardized]
        public string Results { get; set; }

        public string SelectionDirection { get; set; }
        public string SelectionEnd { get; set; }
        public string SelectionStart { get; set; }
        public string Size { get; set; }
        public string SpellCheck { get; set; }
        public string Src { get; set; }
        public string Step { get; set; }
        public string Type { get; set; }

        [Obsolete]
        public string UseMap { get; set; }

        public string Value { get; set; }

        [NotStandardized]
        public string WebKitDirectory { get; set; }

        public string Width { get; set; }

        [NotStandardized]
        public string X_Moz_ErrorMessage { get; set; }
    }
}