namespace Viyrex.ML.Html.Elements
{
    public sealed class Data : ElementBase
    {
        public override ElementType ElementType => ElementType.Normal;

        public string Value { get; set; }
    }

}
