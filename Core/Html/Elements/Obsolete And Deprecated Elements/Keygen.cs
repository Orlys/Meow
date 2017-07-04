namespace Meow.Html.Elements
{
    using Meow.Auxiliary;
    using Meow.Html.Infrastructure;

    /// <summary>
    /// Keygen Element
    /// </summary>
    [Deprecated]
    public sealed class Keygen : EmptyElementBase
    {
        public string AutoFocus { get; set; }

        public string Challenge { get; set; }

        public string Disabled { get; set; }

        public string Form { get; set; }

        public string KeyType { get; set; }

        public string Name { get; set; }
    }
}