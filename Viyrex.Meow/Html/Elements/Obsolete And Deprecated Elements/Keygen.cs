using Viyrex.ML.Html.Auxiliaries;

namespace Viyrex.ML.Html.Elements
{
    [Deprecated]
    public sealed class Keygen : ElementBase
    {
        public override ElementType ElementType => ElementType.Empty;

        public string AutoFocus { get; set; }

        public string Challenge { get; set; }

        public string Disabled { get; set; }

        public string Form { get; set; }

        public string KeyType { get; set; }

        public string Name { get; set; }

    }
}
