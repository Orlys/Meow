namespace Meow.Html.Elements
{
    using Meow.Html.Auxiliaries;
    using Meow.Html.Infrastructure;

    /// <summary>
    /// Frame Element
    /// </summary>
    [Deprecated]
    public sealed class Frame : EmptyElementBase
    {
        public string FrameBorder { get; set; }
        public string MarginHeight { get; set; }
        public string MarginWidth { get; set; }
        public string Name { get; set; }
        public string NoResize { get; set; }
        public string Scrolling { get; set; }
        public string Src { get; set; }
    }
}