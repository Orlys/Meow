namespace Viyrex.Meow.Html.Elements
{
    public sealed class Embed : ElementBase
    {
        public override ElementType ElementType => ElementType.Empty;

        public string Height { get; set; }

        public string Src { get; set; }

        public string Type { get; set; }

        public string Width { get; set; }
    }
}
