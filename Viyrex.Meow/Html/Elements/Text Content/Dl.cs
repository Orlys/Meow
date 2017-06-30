namespace Meow.Html.Elements
{
    using Meow.Html.Auxiliaries;
    using Meow.Html.Infrastructure;

    /// <summary>
    /// Dl Element
    /// </summary>
    public sealed class Dl : NormalElementBase
    {
        [NotStandardized]
        public string Compact { get; set; }
    }
}