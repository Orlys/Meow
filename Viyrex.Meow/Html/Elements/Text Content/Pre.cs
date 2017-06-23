using System;
using Viyrex.Meow.Html.Auxiliaries;

namespace Viyrex.Meow.Html.Elements
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
