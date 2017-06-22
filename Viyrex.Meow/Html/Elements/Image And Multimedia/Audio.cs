using System;
using Viyrex.ML.Html.Auxiliaries;
namespace Viyrex.ML.Html.Elements
{
    public sealed class Audio : ElementBase
    {
        public override ElementType ElementType => ElementType.Normal;
        
        public string AutoPlay { get; set; }

        [Obsolete]
        public string AutoBuffer { get; set; }

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