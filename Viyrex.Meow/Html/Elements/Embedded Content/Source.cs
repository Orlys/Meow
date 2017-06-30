namespace Meow.Html.Elements
{
    using Meow.Html.Auxiliaries;
    using Meow.Html.Infrastructure;

    /// <summary>
    /// Source Element
    /// </summary>
    public sealed class Source : EmptyElementBase
    {
        [Experimental]
        public string Media { get; set; }

        [Experimental]
        public string Sizes { get; set; }

        public string Src { get; set; }

        [Experimental]
        public string SrcSet { get; set; }

        public string Type { get; set; }
    }
}