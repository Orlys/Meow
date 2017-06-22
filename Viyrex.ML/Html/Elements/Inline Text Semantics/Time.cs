namespace Viyrex.ML.Html.Elements
{
    public sealed class Time : ElementBase
    {
        public override ElementType ElementType => ElementType.Normal;

        public string DateTime { get; set; }
    }

}
