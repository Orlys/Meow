namespace Meow.Html.Elements
{
    using Meow.Html.Infrastructure;

    /// <summary>
    /// Track Element
    /// </summary>
    public sealed class Track : EmptyElementBase
    {
        public string Default { get; set; }

        public string Kind { get; set; }

        public string Label { get; set; }

        public string Src { get; set; }

        public string SrcLang { get; set; }
    }
}