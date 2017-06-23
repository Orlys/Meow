using System;

namespace Viyrex.Meow.Html.Elements
{
    public sealed class Html : ElementBase
    {
        public override ElementType ElementType => ElementType.Normal;

        [Obsolete]
        public string Manifest { get; set; }

        [Obsolete]
        public string Version { get; set; }

        public string Xmlns { get; set; } = "http://www.w3.org/1999/xhtml";
    }
}
