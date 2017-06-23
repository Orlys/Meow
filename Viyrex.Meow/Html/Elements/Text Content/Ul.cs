using Viyrex.Meow.Html.Auxiliaries;

namespace Viyrex.Meow.Html.Elements
{
    public sealed class Ul : ElementBase
    {
        public override ElementType ElementType => ElementType.Normal;

        [Deprecated]
        public string Compact { get; set; }

        [Deprecated]
        public string Type { get; set; }
    }
}
