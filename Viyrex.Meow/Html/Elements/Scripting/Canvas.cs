using Viyrex.Meow.Html.Auxiliaries;

namespace Viyrex.Meow.Html.Elements
{
    public sealed class Canvas : ElementBase
    {
        public override ElementType ElementType => ElementType.Normal;

        public string Height { get; set; }

        [NotStandardized]
        public string Moz_Opaque { get; set; }

        public string Width { get; set; }
    }
}
