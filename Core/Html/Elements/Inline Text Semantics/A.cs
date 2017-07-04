namespace Meow.Html.Elements
{
    using Meow.Auxiliary;
    using Meow.Html.Infrastructure;

    /// <summary>
    /// A Element
    /// </summary>
    public sealed class A : NormalElementBase
    {
        public string Href { get; set; }

        public string HrefLang { get; set; }

        [Experimental]
        public string ReferrerPolicy { get; set; }

        public string Rel { get; set; }

        public string Target { get; set; }

        public string Type { get; set; }
    }
}