using System;

namespace Viyrex.ML.Html.Elements
{
    public sealed class Meta : ElementBase
    {
        public override ElementType ElementType => ElementType.Empty;

        public string CharSet { get; set; }

        public string Content { get; set; }

        public string Http_Equiv { get; set; }

        public string Name { get; set; }

        [Obsolete]
        public string Scheme { get; set; }
    }
}
