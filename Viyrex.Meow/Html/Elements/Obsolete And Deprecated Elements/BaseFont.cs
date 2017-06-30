namespace Meow.Html.Elements
{
    using Meow.Html.Infrastructure;
    using System;

    /// <summary>
    /// BaseFont Element
    /// </summary>
    [Obsolete]
    public sealed class BaseFont : EmptyElementBase
    {
        public string Color { get; set; }

        public string Face { get; set; }

        public string Size { get; set; }
    }
}