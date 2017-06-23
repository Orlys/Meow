using Viyrex.Meow.Html.Auxiliaries;

namespace Viyrex.Meow.Html.Elements
{
    [Experimental]
    public sealed class Slot : ElementBase
    {
        public override ElementType ElementType => ElementType.Normal;

        public string Name { get; set; }
    }
}
