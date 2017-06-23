namespace Viyrex.Meow.Html.Elements
{
    public sealed class Meter : ElementBase
    {
        public override ElementType ElementType => ElementType.Normal;

        public string Value { get; set; }

        public string Min { get; set; }

        public string Max { get; set; }

        public string Low { get; set; }

        public string High { get; set; }

        public string Optimum { get; set; }

        public string Form { get; set; }
    }
}
