namespace Meow.Html.Infrastructure
{
    using Meow.Parsers;
    using System.Collections.Generic;

    public class NormalElementBase : ElementBase
    {
        protected const string AttributeRegex = "attribute";

        protected NormalElementBase()
        {
        }

        protected virtual string ClosingRegex => @"<\s*\/\s*" + this.ElementName + @"\s*>";
        protected virtual string OpeningRegex => @"<\s*" + this.ElementName + @"(?<" + AttributeRegex + ">[^>]+?)>";

        internal override IEnumerable<(IList<(string key, string value)> attributes, string content)> Evaluate(string source)
        {
            var html = source;
            var stack = new Stack<(int contentStartIndex, string attributeString)>();
            foreach (var subStr in source.SplitElement())
            {
                if (subStr.IsMatch(this.OpeningRegex, out var m))
                {
                    var st = html.IndexOf(subStr);
                    stack.Push((st + subStr.Length, m.Groups[AttributeRegex].Value));

                    html = html.GetTokenizedString(st, subStr.Length);
                }
                else if (subStr.IsMatch(this.ClosingRegex, out _))
                {
                    var tmp = stack.Pop();
                    var st = tmp.contentStartIndex;
                    var ed = html.IndexOf(subStr);
                    var content = html.Substring(st, ed - st).RemoveToken();

                    yield return (tmp.attributeString.ResolveAttributes(), content);
                    html = html.GetTokenizedString(st, (ed + subStr.Length) - st);
                }
            }
        }
    }
}