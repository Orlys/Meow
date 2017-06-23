using System;
using Viyrex.Meow.Html.Auxiliaries;

namespace Viyrex.Meow.Html.Elements
{
    public sealed class Form : ElementBase
    {
        public override ElementType ElementType => ElementType.Normal;

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
