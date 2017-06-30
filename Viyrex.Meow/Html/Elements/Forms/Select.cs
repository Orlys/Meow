namespace Meow.Html.Elements
{
    using Meow.Html.Infrastructure;

    /// <summary>
    /// Select Element
    /// </summary>
    public sealed class Select : NormalElementBase
    {
        public string AutoFocus { get; set; }

        public string Disable { get; set; }

        public string Form { get; set; }

        public string Multiple { get; set; }

        public string Name { get; set; }

        public string Required { get; set; }

        public string Size { get; set; }
    }
}