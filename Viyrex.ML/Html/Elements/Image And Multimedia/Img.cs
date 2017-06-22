using System;
using Viyrex.ML.Html.Auxiliaries;
namespace Viyrex.ML.Html.Elements
{
    public sealed class Img : ElementBase
    {
        public override ElementType ElementType => ElementType.Empty;
        
        [Obsolete]
        public string Align { get; set; }
        
        public string Alt { get; set; }

        [Obsolete]
        public string Border { get; set; }

        public string CrossOrigin { get; set; }

        public string Height { get; set; }

        [Obsolete]
        public string HSpace { get; set; }
        
        public string IsMap { get; set; }

        public string LoangDesc { get; set; }
        
        [Obsolete]
        public string Name { get; set; }

        public string ReferrerPolicy { get; set; }

        public string Sizes { get; set; }

        public string Src { get; set; }

        public string SrcSet { get; set; }

        public string Width { get; set; }

        [Obsolete]
        public string VSpace { get; set; }

    }
}