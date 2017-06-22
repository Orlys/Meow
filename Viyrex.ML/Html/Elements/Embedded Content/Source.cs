using System;
using Viyrex.ML.Html.Auxiliaries;

namespace Viyrex.ML.Html.Elements
{
    public sealed class Source : ElementBase
    {
        public override ElementType ElementType => ElementType.Empty;

        [Experimental]
        public string Sizes { get; set; }
        
        public string Src { get; set; }

        [Experimental]
        public string SrcSet { get; set; }

        public string Type { get; set; }

        [Experimental]
        public string Media { get; set; }
    }
}
