using Viyrex.Meow.Html.Auxiliaries;

namespace Viyrex.Meow.Html.Elements
{
    public sealed class Li : ElementBase
    {
        public override ElementType ElementType => ElementType.RequireOpeningTag;
        
        public string Value { get; set; }

        [Deprecated]
        public string Type { get; set; }
        
        
    }
}
