namespace Meow.Html.Elements
{
    using Meow.Html.Auxiliaries;
    using Meow.Html.Infrastructure;

    /// <summary>
    /// Button Element
    /// </summary>
    public sealed class Button : NormalElementBase
    {
        [NotStandardized]
        public string AutoComplete { get; set; }

        public string AutoFocus { get; set; }
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