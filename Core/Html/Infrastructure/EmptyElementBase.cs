namespace Meow.Html.Infrastructure
{
    using Meow.Auxiliary;
    using Meow.Parsers;
    using System.Collections.Generic;

    public class EmptyElementBase : HtmlElementBase
    {
        protected EmptyElementBase()
        {
        }

        [NotAttribute]
        protected virtual string EmptyRegex => @"<" + this.ElementName + @"(?<" + AttributeToken + @">[^>]+)/?\s*>";

        internal override IEnumerable<(IList<(string key, string value)> attributes, string content)> Evaluate(string source)
        {
            foreach (var subStr in source.SplitElement())
                if (subStr.IsMatch(this.EmptyRegex, out var m))
                    yield return (this.ResolveAttributes(m.Value), string.Empty);
        }
    }
}