using System;

namespace Viyrex.Meow.Html.Elements
{
    public sealed class H6 : ElementBase
    {
        public override ElementType ElementType => ElementType.Normal;

        [Obsolete]
        public string Align { get; set; }
    }
}
