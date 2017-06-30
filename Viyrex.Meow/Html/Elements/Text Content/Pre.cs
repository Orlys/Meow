namespace Meow.Html.Elements
{
    using Meow.Html.Auxiliaries;
    using Meow.Html.Infrastructure;
    using System;

    /// <summary>
    /// Pre Element
    /// </summary>
    public sealed class Pre : NormalElementBase
    {
        [Obsolete]
        [NotStandardized]
        public string Cols { get; set; }

        [Obsolete]
        public string Width { get; set; }

        [NotStandardized]
        public string Wrap { get; set; }
    }
}