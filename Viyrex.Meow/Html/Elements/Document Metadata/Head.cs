using System;

namespace Viyrex.ML.Html.Elements
{
    public sealed class Head : ElementBase
    {
        public override ElementType ElementType => ElementType.Normal;

        [Obsolete]
        public string Profile { get; set; }
    }
}
