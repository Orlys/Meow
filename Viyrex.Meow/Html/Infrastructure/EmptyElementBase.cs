namespace Meow.Html.Infrastructure
{
    using Meow.Parsers;
    using System.Collections.Generic;

    public class EmptyElementBase : ElementBase
    {
        protected const string AttributeRegex = "attribute";

        protected EmptyElementBase()
        {
        }

        protected virtual string EmptyTagRegex => @"<\s*" + this.ElementName + @"(?<" + AttributeRegex + @">[^>]+)/?\s*>";

        internal override IEnumerable<(IList<(string key, string value)> attributes, string content)> Evaluate(string source)
        {
            foreach (var subStr in source.SplitElement())
                if (subStr.IsMatch(this.EmptyTagRegex, out var m))
                    yield return (m.Value.ResolveAttributes(), string.Empty);
        }
    }
}