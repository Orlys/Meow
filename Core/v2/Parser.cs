using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Meow.v2
{
    public class Parser
    {
        private Parser(string html)
            => this.Source = html;
        public string Source { get; }



        public static IEnumerable<ISegment> R0(string html)
        {
            var tag_start_index = -1;
            var content_start_index = -1;
            for (int i = 0; i < html.Length; i++)
            {
                switch (html[i])
                {
                    case '<':
                        if (ProcessDoctype(html, ref i, out var doctype))
                        {
                            yield return doctype;
                            continue;
                        }
                        else if (ProcessComment(html, ref i, out var comment))
                        {
                            yield return comment;
                            continue;
                        }
                        else if (ProcessJavaScript(html, ref i, out var javascript))
                        {
                            yield return javascript;
                            continue;
                        }
                        else if (ProcessStyle(html, ref i, out var css))
                        {
                            yield return css;
                            continue;
                        }

                        tag_start_index = i;
                        if (content_start_index == -1) break;

                        if (string.IsNullOrWhiteSpace(html.Substring(content_start_index + 1, i - content_start_index - 1)))
                            yield return new WildPartital(content_start_index, i, html);
                        else
                            yield return new Content(content_start_index, i, html);

                        content_start_index = -1;
                        break;


                    case '>':
                        content_start_index = i;
                        if (tag_start_index == -1) break;

                        //var tagString = html.Substring(tag_start_index, i - tag_start_index + 1);
                        var tag = ProcessTagSegment(new Segment(tag_start_index, i, html));
                        yield return tag;

                        tag_start_index = -1;
                        break;

                }
            }
            yield break;
        }

        /// 1
        static bool ProcessEndTag(Segment segment, out EndTag end)
        {
            end = default(EndTag);
            if (segment.Block.StartsWith("</") && segment.Block.EndsWith(">"))
            {
                end = new EndTag(segment.Start, segment.Stop, segment.Source, segment.Block.TrimStart('<', '/').TrimEnd('>'));

                return true;
            }
            return false;
        }

        /// 2
        private static string[] EMPTY_TAG = { "!doctype", "area", "base", "br", "col", "embed", "hr", "img", "input", "keygen", "link", "meta", "param", "source", "track", "wbr" };

        static Segment ProcessTagSegment(Segment segment)
        {
            var sCode = segment.Block.TrimStart('<').TrimEnd('>');
            if (sCode.First() == '/')
                return new EndTag(segment.Start, segment.Stop, segment.Source, sCode.TrimStart('/'));
            else
            {
                var tagBody = sCode.TrimEnd('/').Trim();
                var isEmptyTag = EMPTY_TAG.Any(x => tagBody.ToLower().StartsWith(x));


                //Has attribute
                //todo: resolve attributes
                if (tagBody.Contains(" "))
                {

                    var nameLength = tagBody.IndexOf(' ');
                    var name = tagBody.Substring(0, nameLength);
                    tagBody = tagBody.Remove(0, nameLength);
                    // var attributes = ProcessAttributes(tagBody);
                    var attributes = Attributes.Resolve(tagBody);

                    if (isEmptyTag)
                        return new EmptyTag(segment.Start, segment.Stop, segment.Source, name, attributes);
                    else
                        return new StartTag(segment.Start, segment.Stop, segment.Source, name, attributes);

                }
                else
                {
                    if (isEmptyTag)
                        return new EmptyTag(segment.Start, segment.Stop, segment.Source, tagBody, null);
                    else
                        return new StartTag(segment.Start, segment.Stop, segment.Source, tagBody, null);
                }
            }

        }

        public class AttributeProperty : IEquatable<AttributeProperty>
        {
            public AttributeProperty(string name, string value)
            {
                this.Name = name?.ToLower() ?? throw new ArgumentNullException(nameof(name));
                this.Value = value;
            }
            public AttributeProperty(string name) : this(name, null)
            {
            }

            public string Name { get; }
            public string Value
            {
                get => this._value;
                set => this._value = value ?? string.Empty;
            }

            private string _value;

            public bool HasValue => !string.IsNullOrWhiteSpace(this.Value);

            public override string ToString()
                => this.ToString(false);

            public string ToString(bool simplify)
                => (simplify && !this.HasValue)
                ? $"{this.Name}"
                : $"{this.Name}=\"{this.Value}\"";

            public static string Concat(params AttributeProperty[] propertys)
                => propertys?.Aggregate(new StringBuilder(), (sb, p) => sb.Append(p + string.Empty)).ToString() ?? string.Empty;


            public bool Equals(AttributeProperty other)
            {
                if (other is AttributeProperty p)
                    return p.GetHashCode() == other.GetHashCode();
                return false;
            }
            public override bool Equals(object obj)
            {
                if (obj is AttributeProperty p)
                    return p.GetHashCode() == obj.GetHashCode();
                return false;
            }
            public override int GetHashCode() => this.ToString(true).GetHashCode();

            public static bool operator ==(AttributeProperty left, AttributeProperty right)
                => left.Equals(right);

            public static bool operator !=(AttributeProperty left, AttributeProperty right)
                => !left.Equals(right);

            public static implicit operator AttributeProperty(KeyValuePair<string, string> pair)
                 => new AttributeProperty(pair.Key, pair.Value);

        }

        public class Attributes : IEquatable<Attributes>, IEnumerable<AttributeProperty>
        {
            public string ToFormattableString()
            => AttributeProperty.Concat(this.ToArray());


            private readonly IDictionary<string, string> _attributes;

            internal Attributes() : this(new Dictionary<string, string>())
            {
            }
            internal Attributes(IDictionary<string, string> attributes)
            {
                this._attributes = attributes ?? throw new ArgumentNullException(nameof(attributes));
            }

            public string this[string name]
            {
                get => this._attributes.TryGetValue(name.ToLower(), out var x) ? x : string.Empty;
                set => this.Add(name, value);
            }

            public void Add(string name, string value)
                => this._attributes[name.ToLower()] = value;

            public void Delete(string name)
                => this._attributes.Remove(name.ToLower());

            public bool Equals(Attributes other)
                => other._attributes.Except(this._attributes).Count() == 0;

            internal static Attributes Resolve(string s)
            {
                var attrs = new Dictionary<string, string>();
                s = s.Trim();
                int i = 0;
                while (s.Length > 0)
                {
                    if (s[i] == '=')
                    {
                        var key = s.Substring(0, i++);

                        var token = s[i];
                        if (token == '\'' || token == '"')
                        {
                            var end = s.IndexOf(token, ++i);
                            var value = s.Substring(i, end - i);
                            attrs.Add(key, value);
                            s = s.Remove(0, key.Length + value.Length + 3);
                        }
                        i = 0;
                    }
                    else if (s[i] == ' ')
                    {
                        var key = s.Substring(0, i++);
                        s = s.Remove(0, key.Length).Trim();
                        if (!string.IsNullOrWhiteSpace(key))
                            attrs.Add(key, string.Empty);
                        i = 0;
                    }
                    else
                        i++;

                }

                return new Attributes(attrs);
            }

            public IEnumerator<AttributeProperty> GetEnumerator() => this._attributes.Cast<AttributeProperty>().GetEnumerator();

            IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
        }

        /*
        static IDictionary<string, string> ProcessAttributes(string s)
        {
            var attrs = new Dictionary<string, string>();
            s = s.Trim();
            int i = 0;
            while (s.Length > 0)
            {
                if (s[i] == '=')
                {
                    var key = s.Substring(0, i++);

                    var token = s[i];
                    if (token == '\'' || token == '"')
                    {
                        var end = s.IndexOf(token, ++i);
                        var value = s.Substring(i, end - i);
                        attrs.Add(key, value);
                        s = s.Remove(0, key.Length + value.Length + 3);
                    }
                    i = 0;
                }
                else if (s[i] == ' ')
                {
                    var key = s.Substring(0, i++);
                    s = s.Remove(0, key.Length).Trim();
                    if (!string.IsNullOrWhiteSpace(key))
                        attrs.Add(key, string.Empty);
                    i = 0;
                }
                else
                    i++;

            }

            return attrs;
        }

        */

        public class EmptyTag : Segment
        {
            public Attributes Attributes { get; }

            internal EmptyTag(int start, int stop, string source, string tagName, Attributes attributes) : base(start, stop, source)
            {
                TagName = tagName;
                this.Attributes = attributes ?? new Attributes();
            }
        }

        public class StartTag : Segment
        {
            public Attributes Attributes { get; }

            internal StartTag(int start, int stop, string source, string tagName, Attributes attributes) : base(start, stop, source)
            {
                TagName = tagName;
                this.Attributes = attributes ?? new Attributes();
            }
        }

        public class EndTag : Segment
        {
            public EndTag(int start, int stop, string source, string tagName) : base(start, stop, source)
            {
                TagName = tagName;
            }
        }

        static bool ProcessComment(string html, ref int index, out ISegment segment)
        {
            segment = default(ISegment);
            //process <!--Comment-->
            if (html[index + 1] == '!' &&
                html[index + 2] == '-' &&
                html[index + 3] == '-')
            {
                int startIndex = index;
                index += 4;
                for (; index < html.Length; index++)
                {
                    if (html[index] == '>' &&
                        html[index - 1] == '-' &&
                        html[index - 2] == '-')
                    {
                        segment = new Segment(startIndex, index, html)
                        {
                            TagName = "Comment"
                        };
                        index--;
                        break;
                    }
                }
                return true;
            }
            //
            return false;
        }
        static bool ProcessJavaScript(string html, ref int index, out ISegment segment)
        {
            const string script = "script";
            const string script_end = "</script>";
            segment = default(ISegment);

            if (html.Length > index + 7 && html.Substring(index + 1, script.Length).ToLower() == script)
            {
                int startIndex = index;
                index += 7;
                for (; index < html.Length; index++)
                    if (html.Substring(index, script_end.Length).ToLower() == script_end)
                    {
                        segment = new Segment(startIndex, index += script_end.Length - 1, html)
                        {
                            TagName = "Script"
                        };
                        index--;
                        break;
                    }
                return true;
            }
            //
            return false;
        }
        static bool ProcessStyle(string html, ref int index, out ISegment segment)
        {
            const string style = "style";
            const string style_end = "</style>";
            segment = default(ISegment);

            if (html.Length > index + 6 && html.Substring(index + 1, style.Length).ToLower() == style)
            {
                int startIndex = index;
                index += 6;
                for (; index < html.Length; index++)
                    if (html.Substring(index, style_end.Length).ToLower() == style_end)
                    {
                        segment = new Segment(startIndex, index += style_end.Length - 1, html)
                        {
                            TagName = "Style"
                        };
                        index--;
                        break;
                    }

                return true;
            }
            //
            return false;
        }
        static bool ProcessDoctype(string html, ref int index, out ISegment segment)
        {

            segment = default(ISegment);
            if (html.Length > index + 9 && html.Substring(index + 1, 8).ToLower() == "!doctype")
            {
                int startIndex = index;
                index += 9;
                for (; index < html.Length; index++)
                {
                    if (html.Substring(index, 1) == ">")
                    {
                        segment = new Segment(startIndex, index, html)
                        {
                            TagName = "Doctype"
                        };
                        index--;
                        break;
                    }
                }
                return true;
            }
            //
            return false;
        }



        public interface ISegment
        {
            int Start { get; }
            int Stop { get; }
            string Block { get; }

            string TagName { get; }
        }

        public class Content : ISegment
        {
            public string Source { get; }
            public int Start { get; }
            public int Stop { get; }

            internal Content(int start, int stop, string source)
            {
                this.Start = start;
                this.Stop = stop;
                this.Source = source;

                this.Block = source.Substring(start + 1, stop - start - 1);
            }

            public string TagName { get; set; }
            public string Block { get; }
            public override string ToString() => this.Block;
        }

        public class WildPartital : ISegment
        {
            public string Source { get; }
            public int Start { get; }
            public int Stop { get; }

            internal WildPartital(int start, int stop, string source)
            {
                this.Start = start;
                this.Stop = stop;
                this.Source = source;

                this.Block = source.Substring(start + 1, stop - start - 1);
            }


            public string TagName { get; set; }
            public string Block { get; }
            public override string ToString() => this.Block;
        }

        public class Segment : ISegment
        {
            public Segment(int start, int stop, string source)
            {
                this.Start = start;
                this.Stop = stop;
                this.Source = source;
                this.Block = source.Substring(start, stop - start + 1);
            }

            public int Start { get; }
            public int Stop { get; }
            public string Source { get; }

            public virtual string TagName { get; internal set; }
            public string Block { get; }

            public override string ToString() => this.Block;
        }
    }
}
