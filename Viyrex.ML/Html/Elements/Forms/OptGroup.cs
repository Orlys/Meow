namespace Viyrex.ML.Html.Elements
{
    public sealed class OptGroup : ElementBase
    {
        public override ElementType ElementType => ElementType.RequireOpeningTag;

        public string Disable { get; set; }

        public string Label { get; set; }
    }
}
