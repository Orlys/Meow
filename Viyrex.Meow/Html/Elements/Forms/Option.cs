namespace Viyrex.Meow.Html.Elements
{
    public sealed class Option : ElementBase
    {
        public override ElementType ElementType => ElementType.RequireOpeningTag;

        public string Disable { get; set; }

        public string Label { get; set; }

        public string Selected { get; set; }

        public string Value { get; set; }
    }
}
