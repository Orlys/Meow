using System;

namespace Viyrex.ML.Html.Elements
{
    public sealed class P : ElementBase
    {
        public override ElementType ElementType => ElementType.RequireOpeningTag;

        [Obsolete]
        public string Align { get; set; }
    }
}
