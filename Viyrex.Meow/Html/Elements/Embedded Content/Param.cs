using System;

namespace Viyrex.Meow.Html.Elements
{
    public sealed class Param : ElementBase
    {
        public override ElementType ElementType => ElementType.Empty;

        public string Name { get; set; }

        [Obsolete]
        public string Type { get; set; }

        public string Value { get; set; }

        [Obsolete]
        public string ValueType { get; set; }
    }
}
