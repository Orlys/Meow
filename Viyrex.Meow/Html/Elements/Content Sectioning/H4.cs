using System;

namespace Viyrex.Meow.Html.Elements
{
    public sealed class H4: ElementBase
    {
        public override ElementType ElementType => ElementType.Normal;

        [Obsolete]
        public string Align { get; set; }
    }
}
