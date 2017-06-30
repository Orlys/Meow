namespace Meow.Html.Elements
{
    using Meow.Html.Auxiliaries;
    using Meow.Html.Infrastructure;

    /// <summary>
    /// Canvas Element
    /// </summary>
    public sealed class Canvas : NormalElementBase
    {
        public string Height { get; set; }

        [NotStandardized]
        public string Moz_Opaque { get; set; }

        public string Width { get; set; }
    }
}