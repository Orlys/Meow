using Viyrex.Meow.Html.Auxiliaries;

namespace Viyrex.Meow.Html.Elements
{
    [Deprecated]
    public sealed class Frame : ElementBase
    {
        public override ElementType ElementType => ElementType.Empty;

        public string Src { get; set; }

        public string Name { get; set; }

        public string NoResize { get; set; }

        public string Scrolling { get; set; }

        public string MarginHeight { get; set; }

        public string MarginWidth { get; set; }

        public string FrameBorder { get; set; }
    }
}
