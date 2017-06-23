using System;

namespace Viyrex.Meow.Html.Elements
{
    public sealed class Head : ElementBase
    {
        public override ElementType ElementType => ElementType.Normal;

        [Obsolete]
        public string Profile { get; set; }
    }
}
