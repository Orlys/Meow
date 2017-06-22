using Viyrex.ML.Html.Auxiliaries;

namespace Viyrex.ML.Html.Elements
{
    public sealed class Dl : ElementBase
    {
        public override ElementType ElementType => ElementType.Normal;

        [NotStandardized]
        public string Compact { get; set; }
    }
}
