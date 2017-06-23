using Viyrex.Meow.Html.Auxiliaries;

namespace Viyrex.Meow.Html.Elements
{
    public sealed class Ol : ElementBase
    {
        public override ElementType ElementType => ElementType.Normal;

        [Deprecated]
        public string Compact { get; set; }

        public string Reversed { get; set; }

        public string Start { get; set; }

        public string Type { get; set; }
    }
}
