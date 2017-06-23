using System;
using Viyrex.Meow.Html.Auxiliaries;

namespace Viyrex.Meow.Html.Elements.Document_Metadata
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
