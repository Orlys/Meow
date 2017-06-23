using Viyrex.Meow.Html.Auxiliaries;

namespace Viyrex.Meow.Html.Elements
{
    [Deprecated]
    public sealed class IsIndex : ElementBase
    {
        public override ElementType ElementType => ElementType.Empty;

        public string Propmt { get; set; }

        public string Action { get; set; }
        
    }
}
