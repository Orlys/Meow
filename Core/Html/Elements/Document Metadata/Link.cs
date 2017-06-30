namespace Meow.Html.Elements
{
    using Meow.Html.Auxiliaries;
    using Meow.Html.Infrastructure;
    using System;

    /// <summary>
    /// Link Element
    /// </summary>
    public sealed class Link : EmptyElementBase
    {
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