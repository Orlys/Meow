namespace Meow.Html.Elements
{
    using Meow.Html.Auxiliaries;
    using Meow.Html.Infrastructure;

    /// <summary>
    /// IsIndex Element
    /// </summary>
    [Deprecated]
    public sealed class IsIndex : EmptyElementBase
    {
        public string Action { get; set; }

        public string Propmt { get; set; }
    }
}