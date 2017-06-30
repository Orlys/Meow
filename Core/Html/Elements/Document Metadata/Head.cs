namespace Meow.Html.Elements
{
    using Meow.Html.Infrastructure;
    using System;

    /// <summary>
    /// Head Element
    /// </summary>
    public sealed class Head : NormalElementBase
    {
        [Obsolete]
        public string Profile { get; set; }
    }
}