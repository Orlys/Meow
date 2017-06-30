namespace Meow.Html.Elements
{
    using Meow.Html.Infrastructure;
    using System;

    /// <summary>
    /// P Element
    /// </summary>
    public sealed class P : RequireElementBase
    {
        [Obsolete]
        public string Align { get; set; }
    }
}