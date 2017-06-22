using Viyrex.ML.Html.Auxiliaries;

namespace Viyrex.ML.Html.Elements
{
    [Deprecated]
    public sealed class FrameSet : ElementBase
    {
        public override ElementType ElementType => ElementType.Normal;

        public string Cols { get; set; }

        public string Rows { get; set; }
        
    }
}
