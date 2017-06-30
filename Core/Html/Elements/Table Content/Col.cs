namespace Meow.Html.Elements
{
    using Meow.Html.Auxiliaries;
    using Meow.Html.Infrastructure;
    using System;

    /// <summary>
    /// Col Element
    /// </summary>
    public sealed class Col : EmptyElementBase
    {
        [Obsolete]
        [Deprecated]
        public string Align { get; set; }

        [NotStandardized]
        public string BgColor { get; set; }

        [Obsolete]
        [Deprecated]
        public string Char { get; set; }

        [Obsolete]
        [Deprecated]
        public string CharOff { get; set; }

        public string Span { get; set; }

        [Obsolete]
        [Deprecated]
        public string VAlign { get; set; }

        [Obsolete]
        public string Width { get; set; }
    }
}