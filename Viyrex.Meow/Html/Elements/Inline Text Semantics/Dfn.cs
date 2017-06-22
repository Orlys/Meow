namespace Viyrex.ML.Html.Elements
{
    public sealed class Dfn : ElementBase
    {
        public override ElementType ElementType => ElementType.Normal;

        public new string Title { get; set; }
    }

}
