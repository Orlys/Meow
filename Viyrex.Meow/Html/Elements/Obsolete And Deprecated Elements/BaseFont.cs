using System;

namespace Viyrex.ML.Html.Elements
{
    [Obsolete]
    public sealed class BaseFont : ElementBase
    {
        public override ElementType ElementType => ElementType.Empty;
        
        public string Color { get; set; }

        public string Face { get; set; }

        public string Size { get; set; }
    }
}
