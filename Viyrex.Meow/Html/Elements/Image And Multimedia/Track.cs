using System;
using Viyrex.ML.Html.Auxiliaries;
namespace Viyrex.ML.Html.Elements
{
    public sealed class Track : ElementBase
    {
        public override ElementType ElementType => ElementType.Empty;
        
        public string Default { get; set; }
        
        public string Kind { get; set; }

        public string Label { get; set; }

        public string Src { get; set; }

        public string SrcLang { get; set; }
    }
}