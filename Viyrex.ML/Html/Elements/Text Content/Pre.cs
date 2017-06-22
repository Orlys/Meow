using System;
using Viyrex.ML.Html.Auxiliaries;

namespace Viyrex.ML.Html.Elements
{
    public sealed class Pre : ElementBase
    {
        public override ElementType ElementType => ElementType.Normal;

        [Obsolete]
        [NotStandardized]
        public string Cols { get; set; }

        [Obsolete]
        public string Width { get; set; }
        
        [NotStandardized]
        public string Wrap { get; set; }
    }
}
