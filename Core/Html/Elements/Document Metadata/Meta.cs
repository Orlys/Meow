namespace Meow.Html.Elements
{
    using Meow.Html.Infrastructure;
    using System;

    /// <summary>
    /// Meta Element
    /// </summary>
    public sealed class Meta : EmptyElementBase
    {
        public string CharSet { get; set; }
        public string Content { get; set; }

        public string Http_Equiv { get; set; }

        public string Name { get; set; }

        [Obsolete]
        public string Scheme { get; set; }
    }
}