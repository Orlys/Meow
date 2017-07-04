namespace Meow.Html.Elements
{
    using Meow.Auxiliary;
    using Meow.Html.Infrastructure;

    /// <summary>
    /// Ul Element
    /// </summary>
    public sealed class Ul : NormalElementBase
    {
        [Deprecated]
        public string Compact { get; set; }

        [Deprecated]
        public string Type { get; set; }
    }
}