namespace Meow.Html.Elements
{
    using Meow.Html.Auxiliaries;
    using Meow.Html.Infrastructure;

    /// <summary>
    /// Ol Element
    /// </summary>
    public sealed class Ol : NormalElementBase
    {
        [Deprecated]
        public string Compact { get; set; }

        public string Reversed { get; set; }

        public string Start { get; set; }

        public string Type { get; set; }
    }
}