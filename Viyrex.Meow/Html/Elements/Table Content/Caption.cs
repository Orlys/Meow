using System;
using Viyrex.ML.Html.Auxiliaries;

namespace Viyrex.ML.Html.Elements
{
    public sealed class Caption : ElementBase
    {
        public override ElementType ElementType => ElementType.Normal;

        [Obsolete]
        public string Align { get; set; }
    }
}
