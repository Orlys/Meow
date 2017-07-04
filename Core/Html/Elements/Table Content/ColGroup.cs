namespace Meow.Html.Elements
{
    using Meow.Auxiliary;
    using Meow.Html.Infrastructure;
    using System;

    /// <summary>
    /// ColGroup Element
    /// </summary>
    public sealed class ColGroup : NormalElementBase
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