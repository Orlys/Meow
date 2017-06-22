namespace Viyrex.ML.Html.Elements
{
    public sealed class Menu : ElementBase
    {
        public override ElementType ElementType => ElementType.Normal;

        public string Label { get; set; }

        public string Type { get; set; }

    }
}
