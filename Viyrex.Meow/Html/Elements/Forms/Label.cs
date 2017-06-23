using System;

namespace Viyrex.Meow.Html.Elements
{
    public sealed class Label : ElementBase
    {
        public override ElementType ElementType => ElementType.Normal;

        public string For { get; set; }

        [Obsolete]
        public string Form { get; set; }
    }
}
