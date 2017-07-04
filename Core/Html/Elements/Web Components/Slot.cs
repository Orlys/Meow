namespace Meow.Html.Elements
{
    using Meow.Auxiliary;
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