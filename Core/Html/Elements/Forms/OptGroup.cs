namespace Meow.Html.Elements
{
    using Meow.Html.Infrastructure;

    /// <summary>
    /// OptGroup Element
    /// </summary>
    public sealed class OptGroup : RequireElementBase
    {
        public string Disable { get; set; }

        public string Label { get; set; }
    }
}