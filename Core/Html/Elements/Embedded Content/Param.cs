namespace Meow.Html.Elements
{
    using Meow.Html.Infrastructure;
    using System;

    /// <summary>
    /// Param Element
    /// </summary>
    public sealed class Param : EmptyElementBase
    {
        public string Name { get; set; }

        [Obsolete]
        public string Type { get; set; }

        public string Value { get; set; }

        [Obsolete]
        public string ValueType { get; set; }
    }
}