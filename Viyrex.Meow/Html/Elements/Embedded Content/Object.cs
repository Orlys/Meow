namespace Meow.Html.Elements
{
    using Meow.Html.Auxiliaries;
    using Meow.Html.Infrastructure;
    using System;

    /// <summary>
    /// Object Element
    /// </summary>
    public sealed class Object : NormalElementBase
    {
        [Obsolete]
        public string Archive { get; set; }

        [Obsolete]
        [Deprecated]
        public string Border { get; set; }

        [Obsolete]
        public string ClassId { get; set; }

        [Obsolete]
        public string CodeBase { get; set; }

        [Obsolete]
        public string CodeType { get; set; }

        public new string Data { get; set; }

        [Obsolete]
        public string Declare { get; set; }

        public string Form { get; set; }

        public string Height { get; set; }

        public string Name { get; set; }

        [Obsolete]
        public string Standby { get; set; }

        [Obsolete]
        public override string TabIndex { get; set; }

        public string Type { get; set; }

        public string TypeMustMatch { get; set; }

        public string UseMap { get; set; }

        public string Width { get; set; }
    }
}