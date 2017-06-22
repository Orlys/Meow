using System;
using System.Collections.Generic;
using System.Text;

namespace Viyrex.ML.Html.Elements
{
    public sealed class Base : ElementBase
    {
        public override ElementType ElementType => ElementType.Empty;

        public string Href { get; set; }

        public string Target { get; set; } = "_self";
    }
}
