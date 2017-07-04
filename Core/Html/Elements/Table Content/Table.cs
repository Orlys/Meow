namespace Meow.Html.Elements
{
    using Meow.Auxiliary;
    using Meow.Html.Infrastructure;

    /// <summary>
    /// Table Element
    /// </summary>
    public sealed class Table : NormalElementBase
    {
        [Deprecated]
        public string Align { get; set; }

        [Deprecated]
        public string BgColor { get; set; }

        [Deprecated]
        public string Border { get; set; }

        [Deprecated]
        public string CellPadding { get; set; }

        [Deprecated]
        public string CellSpacing { get; set; }

        [Deprecated]
        public string Frame { get; set; }

        [Deprecated]
        public string Rules { get; set; }

        [Deprecated]
        public string Summary { get; set; }

        [Deprecated]
        public string Width { get; set; }
    }
}