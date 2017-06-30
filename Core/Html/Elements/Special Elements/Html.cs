namespace Meow.Html.Elements
{
    using Meow.Html.Infrastructure;
    using System;

    /// <summary>
    /// Html Element
    /// </summary>
    public sealed class Html : NormalElementBase
    {
        [Obsolete]
        public string Manifest { get; set; }

        [Obsolete]
        public string Version { get; set; }

        public string Xmlns { get; set; }
    }
}