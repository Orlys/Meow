using Viyrex.Meow.Html.Auxiliaries;

namespace Viyrex.Meow.Html.Elements
{
    public sealed class Dl : ElementBase
    {
        public override ElementType ElementType => ElementType.Normal;

        [NotStandardized]
        public string Compact { get; set; }
    }
}
