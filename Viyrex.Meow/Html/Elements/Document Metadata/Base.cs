namespace Meow.Html.Elements
{
    using Meow.Html.Infrastructure;

    /// <summary>
    /// Base Element
    /// </summary>
    public sealed class Base : EmptyElementBase
    {
        public string Href { get; set; }

        public string Target { get; set; }
    }
}