namespace Meow.Html.Elements
{
    using Meow.Html.Auxiliaries;
    using Meow.Html.Infrastructure;

    /// <summary>
    /// Slot Element
    /// </summary>
    [Experimental]
    public sealed class Slot : NormalElementBase
    {
        public string Name { get; set; }
    }
}