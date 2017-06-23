using System;

namespace Viyrex.Meow.Html.Elements
{
    public sealed class H1 : ElementBase
    {
        public override ElementType ElementType => ElementType.Normal;

        [Obsolete]
        public string Align { get; set; }
    }
}
