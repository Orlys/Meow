using Viyrex.Meow.Html.Auxiliaries;

namespace Viyrex.Meow.Html.Elements
{
    public sealed class TextArea : ElementBase
    {
        public override ElementType ElementType => ElementType.Normal;

        [NotStandardized]
        public string AutoCapitalize { get; set; }

        public string AutoComplete { get; set; }

        public string AutoFocus { get; set; }

        public string Cols { get; set; }

        public string Disable { get; set; }

        public string Form { get; set; }

        public string MaxLength { get; set; }

        public string MinLength { get; set; }

        public string Name { get; set; }

        public string PlaceHolder { get; set; }

        public string ReadOnly { get; set; }

        public string Required { get; set; }

        public string Rows { get; set; }

        public string SelectionDirection { get; set; }

        public string SelectionEnd { get; set; }

        public string SelectionStart { get; set; }

        public string SpellCheck { get; set; }

        public string Warp { get; set; }
    }
}
