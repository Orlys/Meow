using System;
using Viyrex.Meow.Html.Auxiliaries;

namespace Viyrex.Meow.Html.Elements
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
