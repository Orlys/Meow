namespace Meow.Html.Elements
{
    using Meow.Html.Infrastructure;

    /// <summary>
    /// MenuItem Element
    /// </summary>
    public sealed class MenuItem : EmptyElementBase
    {
        public string Check { get; set; }

        public string Command { get; set; }

        public string Default { get; set; }

        public string Icon { get; set; }

        public string Label { get; set; }

        public string RadioGroup { get; set; }

        public string Type { get; set; }
    }
}