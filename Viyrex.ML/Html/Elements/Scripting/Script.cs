using Viyrex.ML.Html.Auxiliaries;

namespace Viyrex.ML.Html.Elements
{
    public sealed class Script : ElementBase
    {
        public override ElementType ElementType => ElementType.Normal;

        public string Async { get; set; }

        public string CrossOrigin { get; set; }

        public string Defer { get; set; }

        public string Integrity { get; set; }

        [Deprecated]
        public string Language { get; set; }

        [Experimental]
        public string NoModule { get; set; }

        public string Src { get; set; }

        public string Text { get; set; }

        public string Type { get; set; }
    }
}
