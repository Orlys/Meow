using Viyrex.ML.Html.Auxiliaries;

namespace Viyrex.ML.Html.Elements
{
    public sealed class A : ElementBase
    {
        public override ElementType ElementType => ElementType.Normal;

        public string Href { get; set; }

        public string HrefLang { get; set; }

        [Experimental]
        public string ReferrerPolicy { get; set; }

        public string Rel { get; set; }

        public string Target { get; set; }

        public string Type { get; set; }
    }

}
