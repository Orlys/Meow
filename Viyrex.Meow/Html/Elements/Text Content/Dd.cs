namespace Viyrex.Meow.Html.Elements
{
    public sealed class Dd : ElementBase
    {
        public override ElementType ElementType => ElementType.RequireOpeningTag;

        public string NoWrap { get; set; }
    }
}
