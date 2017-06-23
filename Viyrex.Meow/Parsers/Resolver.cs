#define DEBUG
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Viyrex.Meow.Html.Elements;

namespace Viyrex.Meow.Parsers
{

    internal static class ResolveCore
    {
        internal const RegexOptions option = RegexOptions.ExplicitCapture | RegexOptions.IgnoreCase;
        internal const string attribute_regular = @"(?<key>[\w\-]+)(\s*\=\s*(?<_>['""]?)(?<value>.*?)\k<_>)?";
        internal const string doctype_regular = @"<!DOCTYPE\s?(?<info>[^>]*)>";
        internal const string xml_regular = @"<?xml\s?(?<info>[^>]*)>";
        internal const string split_regular = "(<[^>]+>)";
        internal const char Token = char.MinValue;

        internal static bool IsMatch(this string substring, string pattern, out Match match)
            => (match = Regex.Match(substring, pattern, option)).Success;

        internal static string GetTokenizedString(this string originString, int startIndex, int count)
            => originString.Remove(startIndex, count)
                            .Insert(startIndex, new string(Enumerable.Repeat(Token, count).ToArray()));

        internal static IEnumerable<string> SplitElement(this string htmlCode)
            => Regex.Split(htmlCode, split_regular);

        internal static string RemoveToken(this string tokenizedString)
            => tokenizedString.Replace(Token.ToString(), null);

        internal static IList<(string key, string value)> ResolveAttributes(this string opening)
            => Regex.Matches(opening, attribute_regular, option)
                    .Cast<Match>()
                    .Select(k => (k.Groups["key"].Value, k.Groups["value"].Value))
                    .ToList(); 

        internal static string ResolveDoctype(this string htmlCode)
            => htmlCode.IsMatch(doctype_regular, out var m) ? m.Groups["info"].Value : string.Empty;


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
    public class Resolver
    {
        static Resolver()
            => Regex.CacheSize = 30;
        

        public static Resolver Load(string htmlCode)
            => new Resolver(htmlCode ?? throw new ArgumentNullException(nameof(htmlCode)));
        private readonly List<string> Elements;
        private Resolver(string htmlCode)
        { 
            this.HtmlCode = htmlCode;
            this.Elements = new List<string>(this.HtmlCode.SplitElement());
            
            
        }


        private T AttachInfo<T>(IList<(string key, string value)> attributes, string content) where T : ElementBase, new()
            => attributes.Aggregate(new T { ElementContent = content }, (tag, attribute) =>
            {
                tag[attribute.key] = attribute.value;
                return tag;
            });

        private IEnumerable<(IList<(string key, string value)> attributes, string content)> ResolveEmpty(string tagName)
        {
            var empty = @"<\s*" + tagName + @"(?<attribute>[^>]+)/?\s*>";
            foreach (var subStr in this.Elements)
                if (subStr.IsMatch(empty, out var m))
                    yield return (m.Value.ResolveAttributes(), string.Empty);
        }

        private IEnumerable<(IList<(string key, string value)> attributes, string content)> ResolveNormal(string tagName)
        {
            var html = this.HtmlCode;
            var opening = @"<\s*" + tagName + @"(?<attribute>[^>]+?)>";
            var closing = @"<\s*\/\s*" + tagName + @"\s*>";
            var stack = new Stack<(int contentStartIndex, string attributeString)>();
            foreach (var subStr in this.Elements)
            {
                if (subStr.IsMatch(opening, out var m))
                {
                    var st = html.IndexOf(subStr);
                    stack.Push((st + subStr.Length, m.Groups["attribute"].Value));

                    html = html.GetTokenizedString(st, subStr.Length);
                }
                else if (subStr.IsMatch(closing, out _))
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


        public IEnumerable<T> Resolve<T>() where T : ElementBase, new()
        {
            var t = new T();
            switch (t.ElementType)
            {
                case ElementType.RequireOpeningTag:
                /* return this.HtmlCode.ResolveRequireOpeningTag( t.ElementName)
                         .Select(e => AttachInfo<T>(e.attributes, e.content));*/

                case ElementType.Normal:
                    return this.ResolveNormal(t.ElementName)
                            .Select(e => AttachInfo<T>(e.attributes, e.content));

                case ElementType.Empty:
                    return this.ResolveEmpty(t.ElementName)
                            .Select(e => AttachInfo<T>(e.attributes, e.content));


                case ElementType.Special:
                    break;

                case ElementType.Customize:
                    break;
                default:
                    break;
            }
            return null;
        }

        public string HtmlCode { get; private set; }
    }
    
}
