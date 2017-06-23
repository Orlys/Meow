namespace Viyrex.Meow.Html.Elements
{
    public sealed class MenuItem : ElementBase
    {
        public override ElementType ElementType => ElementType.Empty;

        public string Check { get; set; }

        public string Command { get; set; }

        public string Default { get; set; }

        public string Icon { get; set; }

        public string Label { get; set; }

        public string RadioGroup { get; set; }

        public string Type { get; set; }

    }
}
