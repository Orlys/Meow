using System;
using Viyrex.ML.Html.Auxiliaries;

namespace Viyrex.ML.Html.Elements
{
    public sealed class TBody : ElementBase
    {
        public override ElementType ElementType => ElementType.Normal;

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
