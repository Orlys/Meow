namespace Meow.Html.Elements
{
    using Meow.Html.Auxiliaries;
    using Meow.Html.Infrastructure;

    /// <summary>
    /// Hr Element
    /// </summary>
    public sealed class Hr : EmptyElementBase
    {
        [Deprecated]
        public string Align { get; set; }

        [NotStandardized]
        public string Color { get; set; }

        [Deprecated]
        public string NoShade { get; set; }

        [Deprecated]
        public string Size { get; set; }

        [Deprecated]
        public string Width { get; set; }
    }
}