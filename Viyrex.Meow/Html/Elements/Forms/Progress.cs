namespace Viyrex.Meow.Html.Elements
{
    public sealed class Progress : ElementBase
    {
        public override ElementType ElementType => ElementType.Normal;

        public string Max { get; set; }

        public string Value { get; set; }
    }
}
