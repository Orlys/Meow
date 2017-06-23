using Viyrex.Meow.Html.Auxiliaries;

namespace Viyrex.Meow.Html.Elements
{
    public sealed class Button : ElementBase
    {
        public override ElementType ElementType => ElementType.Normal;

        public string AutoFocus { get; set; }

        [NotStandardized]
        public string AutoComplete { get; set; }

        public string Disabled { get; set; }

        public string Form { get; set; }

        public string FormAction { get; set; }

        public string FormEncType { get; set; }

        public string FormMethod { get; set; }

        public string FormNoValidate { get; set; }

        public string FormTarget { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public string Value { get; set; }
    }
}
