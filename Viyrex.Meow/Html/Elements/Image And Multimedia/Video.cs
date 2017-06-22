namespace Viyrex.ML.Html.Elements
{
    public sealed class Video : ElementBase
    {
        public override ElementType ElementType => ElementType.Normal;

        public string AutoPlay { get; set; }

        public string Buffered { get; set; }

        public string Controls { get; set; }
        
        public string CrossOrigin { get; set; }

        public string Height { get; set; }

        public string Loop { get; set; }

        public string Muted { get; set; }

        public string Played { get; set; }

        public string Preload { get; set; }

        public string Poster { get; set; }

        public string Src { get; set; }

        public string Width { get; set; }

    }
}
