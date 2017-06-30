namespace Meow.Html.Elements
{
    using Meow.Html.Infrastructure;
    using System;

    /// <summary>
    /// Label Element
    /// </summary>
    public sealed class Label : NormalElementBase
    {
        public string For { get; set; }

        [Obsolete]
        public string Form { get; set; }
    }
}