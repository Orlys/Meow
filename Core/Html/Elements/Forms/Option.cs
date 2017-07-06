namespace Meow.Html.Elements
{
    using Meow.Html.Infrastructure;

    /// <summary>
    /// Option Element
    /// </summary>
    public sealed class Option : RequireStartElementBase
    {
        public string Disable { get; set; }

        public string Label { get; set; }

        public string Selected { get; set; }

        public string Value { get; set; }
    }
}