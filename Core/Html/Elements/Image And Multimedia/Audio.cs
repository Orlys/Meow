namespace Meow.Html.Elements
{
    using Meow.Auxiliary;
    using Meow.Html.Infrastructure;
    using System;

    /// <summary>
    /// Audio Element
    /// </summary>
    public sealed class Audio : NormalElementBase
    {
        [Obsolete]
        public string AutoBuffer { get; set; }

        public string AutoPlay { get; set; }
        public string Buffered { get; set; }

        public string Controls { get; set; }

        public string Loop { get; set; }

        [NotStandardized]
        public string MozCurrentSampleOffset { get; set; }

        public string Muted { get; set; }

        public string Played { get; set; }

        public string Preload { get; set; }

        public string Src { get; set; }

        public string Volume { get; set; }
    }
}