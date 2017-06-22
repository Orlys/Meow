using Viyrex.ML.Html.Auxiliaries;

namespace Viyrex.ML.Html.Elements
{
    public sealed class FieldSet : ElementBase
    {
        public override ElementType ElementType => ElementType.Normal;
        
        public string Disabled { get; set; }

        public string Form { get; set; }

        public string Name { get; set; }
    }
}
