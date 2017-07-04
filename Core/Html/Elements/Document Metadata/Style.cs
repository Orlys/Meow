namespace Meow.Html.Elements
{
    using Meow.Auxiliary;
    using Meow.Html.Infrastructure;
    using System;

    /// <summary>
    /// Style Element
    /// </summary>
    public sealed class Style : NormalElementBase
    {
        public string Media { get; set; }

        [Obsolete]
        [NotStandardized]
        public string Scoped { get; set; }

        public new string Title { get; set; }
        public string Type { get; set; }
    }
}