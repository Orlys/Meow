using Viyrex.ML.Html.Auxiliaries;

namespace Viyrex.ML.Html.Elements
{
    [Deprecated]
    public sealed class IsIndex : ElementBase
    {
        public override ElementType ElementType => ElementType.Empty;

        public string Propmt { get; set; }

        public string Action { get; set; }
        
    }
}
