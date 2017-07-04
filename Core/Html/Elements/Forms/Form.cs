namespace Meow.Html.Elements
{
    using Meow.Auxiliary;
    using Meow.Html.Infrastructure;
    using System;

    /// <summary>
    /// Form Element
    /// </summary>
    public sealed class Form : NormalElementBase
    {
        [Obsolete]
        public string Accept { get; set; }

        public string Accept_Charset { get; set; }

        public string Action { get; set; }

        [NotStandardized]
        public string AutoCapitalize { get; set; }

        public string AutoComplete { get; set; }

        public string EncType { get; set; }

        public string Method { get; set; }

        public string Name { get; set; }

        public string NoValidate { get; set; }

        public string Target { get; set; }
    }
}