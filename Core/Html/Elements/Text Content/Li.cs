namespace Meow.Html.Elements
{
    using Meow.Html.Auxiliaries;
    using Meow.Html.Infrastructure;

    /// <summary>
    /// Li Element
    /// </summary>
    public sealed class Li : RequireElementBase
    {
        [Deprecated]
        public string Type { get; set; }

        public string Value { get; set; }
    }
}