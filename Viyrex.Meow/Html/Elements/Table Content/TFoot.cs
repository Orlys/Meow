using System;
using Viyrex.ML.Html.Auxiliaries;

namespace Viyrex.ML.Html.Elements
{
    public sealed class TFoot : ElementBase
    {
        public override ElementType ElementType => ElementType.RequireOpeningTag;

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

        [Obsolete]
        [Deprecated]
        public string VAlign { get; set; }
    }
}
