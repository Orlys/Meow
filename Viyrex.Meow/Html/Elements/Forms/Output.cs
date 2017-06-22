namespace Viyrex.ML.Html.Elements
{
    public sealed class Output : ElementBase
    {
        public override ElementType ElementType => ElementType.Normal;

        public string For { get; set; }

        public string Form { get; set; }

        public string Name { get; set; }
    }
}
