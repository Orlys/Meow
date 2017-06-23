#pragma warning disable 809
using System;
using Viyrex.Meow.Html.Auxiliaries;

namespace Viyrex.Meow.Html.Elements
{
    public sealed class Object : ElementBase
    {
        public override ElementType ElementType => ElementType.Normal;

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
#pragma warning restore
