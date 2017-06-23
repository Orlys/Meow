using Viyrex.Meow.Html.Auxiliaries;

namespace Viyrex.Meow.Html.Elements
{
    public sealed class Hr : ElementBase
    {
        public override ElementType ElementType => ElementType.Empty;

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
