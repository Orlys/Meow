using System;
using Viyrex.Meow.Html.Auxiliaries;

namespace Viyrex.Meow.Html.Elements
{
    public sealed class Link : ElementBase
    {
        public override ElementType ElementType => ElementType.Empty;

        [Obsolete]
        public string CharSet { get; set; }

        public string CrossOrigin { get; set; }

        [NotStandardized]
        public string Disable { get; set; }

        public string Href { get; set; }

        public string HrefLang { get; set; }

        [Experimental]
        public string Integrity { get; set; }

        public string Media { get; set; }

        [NotStandardized]
        public string Methods { get; set; }

        [NotStandardized]
        public string Prefetch { get; set; }

        [Experimental]
        public string ReferrerPolicy { get; set; }

        public string Rel { get; set; }

        [Obsolete]
        public string Rev { get; set; }

        public string Sizes { get; set; }

        [NotStandardized]
        public string Target { get; set; }

        public new string Title { get; set; }

        public string Type { get; set; }
    }
}
