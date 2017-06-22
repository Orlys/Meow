using System;
using Viyrex.ML.Html.Auxiliaries;

namespace Viyrex.ML.Html.Elements.Document_Metadata
{
    public sealed class Style : ElementBase
    {
        public override ElementType ElementType => ElementType.Normal;

        public string Type { get; set; }

        public string Media { get; set; }

        public new string Title { get; set; }

        [Obsolete]
        [NotStandardized]
        public string Scoped { get; set; }
    }
}
