namespace Meow.Html.Elements
{
    using Meow.Html.Infrastructure;

    /// <summary>
    /// Embed Element
    /// </summary>
    public sealed class Embed : EmptyElementBase
    {
        public string Height { get; set; }

        public string Src { get; set; }

        public string Type { get; set; }

        public string Width { get; set; }
    }
}