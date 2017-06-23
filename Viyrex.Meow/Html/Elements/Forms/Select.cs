namespace Viyrex.Meow.Html.Elements
{
    public sealed class Select : ElementBase
    {
        public override ElementType ElementType => ElementType.Normal;

        public string AutoFocus { get; set; }

        public string Disable { get; set; }

        public string Form { get; set; }

        public string Multiple { get; set; }

        public string Name { get; set; }

        public string Required { get; set; }

        public string Size { get; set; }
    }
}
