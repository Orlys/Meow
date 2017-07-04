namespace Meow.Html.Elements
{
    using Meow.Auxiliary;
    using Meow.Html.Infrastructure;
    using System;

    /// <summary>
    /// Area Element
    /// </summary>
    public sealed class Area : EmptyElementBase
    {
        [Obsolete]
        public new string AccessKey { get; set; }

        public string Alt { get; set; }

        public string Coords { get; set; }

        public string Download { get; set; }

        public string Href { get; set; }

        public string HrefLang { get; set; }

        public string Media { get; set; }

        [Obsolete]
        public string Name { get; set; }

        [Obsolete]
        public string NoHref { get; set; }

        [Experimental]
        public string RefferrerPolicy { get; set; }

        public string Rel { get; set; }

        public string Shape { get; set; }

        [Obsolete]
        public new string TabIndex { get; set; }

        public string Target { get; set; }

        [Obsolete]
        public string Type { get; set; }
    }
}