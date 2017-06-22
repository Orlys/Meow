using Viyrex.ML.Html.Auxiliaries;

namespace Viyrex.ML.Html.Elements
{
    [Experimental]
    public sealed class Slot : ElementBase
    {
        public override ElementType ElementType => ElementType.Normal;

        public string Name { get; set; }
    }
}
