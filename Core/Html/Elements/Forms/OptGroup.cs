namespace Meow.Html.Elements
{
    using Meow.Html.Infrastructure;

    /// <summary>
    /// OptGroup Element
    /// </summary>
    public sealed class OptGroup : RequireStartElementBase
    {
        public string Disable { get; set; }

        public string Label { get; set; }
    }
}