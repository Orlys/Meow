namespace Viyrex.ML.Html.Elements
{
    public sealed class Ins : ElementBase
    {
        public override ElementType ElementType => ElementType.Normal;

        public string Cite { get; set; }

        public string DateTime { get; set; }
    }
}
