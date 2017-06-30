namespace Meow.Html.Elements
{
    using Meow.Html.Infrastructure;
    using System;

    /// <summary>
    /// Font Element
    /// </summary>
    [Obsolete]
    public sealed class Font : NormalElementBase
    {
        public string Color { get; set; }

        public string Face { get; set; }

        public string Size { get; set; }
    }
}