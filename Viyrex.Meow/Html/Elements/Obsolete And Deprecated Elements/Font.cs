using System;

namespace Viyrex.Meow.Html.Elements
{
    [Obsolete]
    public sealed class Font : ElementBase
    {
        public override ElementType ElementType => ElementType.Normal;

        public string Color { get; set; }

        public string Face { get; set; }

        public string Size { get; set; }
    }
}
