namespace Meow.Parsers
{
    using Meow.Html.Infrastructure;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    internal static class ParserExtension
    {
        private const string split_regular = "(<[^>]+>)";

        private const string attribute_regular = @"(?<key>[\w\-]+)(\s*\=\s*(?<_>['""]?)(?<value>.*?)\k<_>)?";

        private const RegexOptions option = RegexOptions.ExplicitCapture | RegexOptions.IgnoreCase;
        
        internal const char Token = char.MinValue;

        internal static string GetTokenizedString(this string originString, int startIndex, int count)
            => originString.Remove(startIndex, count)
                            .Insert(startIndex, new string(Enumerable.Repeat(Token, count).ToArray()));

        internal static bool IsMatch(this string substring, string pattern, out Match match)
            => (match = Regex.Match(substring, pattern, option)).Success;

        internal static string RemoveToken(this string tokenizedString)
            => tokenizedString.Replace(Token.ToString(), null);

        internal static IList<(string key, string value)> ResolveAttributes(this string opening)
            => Regex.Matches(opening, attribute_regular, option)
                    .Cast<Match>()
                    .Select(k => (k.Groups["key"].Value, k.Groups["value"].Value))
                    .ToList();

        internal static IEnumerable<string> SplitElement(this string htmlCode)
            => Regex.Split(htmlCode, split_regular);

        

        /*
        private static IEnumerable<(IList<(string key, string value)> attributes, string content)> ResolveRequireOpeningTag(string htmlCode, string tagName)
        {
            var html = htmlCode;
            var opening = @"<\s*" + tagName + @"(?<attribute>\s[^>]+?)>";
            var closing = @"<\s*\/\s*" + tagName + @"\s*>";
            var stack = new Stack<(int contentStartIndex, string attributeString)>();
            var between = default(bool);
            foreach (var subStr in html.SplitElement())
            {
                if (subStr.IsMatch(opening, out var m))
                {
                    if (between & stack.Count > 0)
                    {
                        var tmp = stack.Pop();
                        var sts = tmp.contentStartIndex;
                        var ed = html.IndexOf(subStr);
                        Debug.WriteLine($"{sts} - {ed}");
                        var content = html.Substring(sts, ed - sts).RemoveToken();
                        yield return (tmp.attributeString.ResolveAttributes(), content);
                    }

                    var st = html.IndexOf(subStr);
                    stack.Push((st + subStr.Length, m.Groups["attribute"].Value));
                    html = html.GetTokenizedString(st, subStr.Length);
                    between = true;
                }
                else if (subStr.IsMatch(closing, out _) & between & stack.Count > 0)
                {
                    var tmp = stack.Pop();
                    var st = tmp.contentStartIndex;
                    var ed = html.IndexOf(subStr);
                    if (st > ed)
                        continue;
                    var content = html.Substring(st, ed - st).RemoveToken();
                    yield return (tmp.attributeString.ResolveAttributes(), content);

                    Debug.WriteLine($"{st} - {ed}");
                    html = html.GetTokenizedString(st, (ed + subStr.Length) - st);
                    between = false;
                }
            }
        }

        */
    }
}