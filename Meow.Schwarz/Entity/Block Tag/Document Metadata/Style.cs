namespace Meow.Schwarz.Entity
{
    using Auxiliary;
    using Infrastructure;
    using Interface;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Style Element
    /// </summary>
    [Preprocess(int.MaxValue - 3)]
    public sealed class Style : BlockTag
    {
        internal Style(StartTag startTag, EndTag endTag, IEnumerable<ISegment> children) : base(startTag, endTag, children)
        {
        }

        public string Media { get => this.Attributes[nameof(Media)]; set => this.Attributes[nameof(Media)] = value; }

        [Obsolete]
        [NotStandardized]
        public string Scoped { get => this.Attributes[nameof(Scoped)]; set => this.Attributes[nameof(Scoped)] = value; }

        public string Type { get => this.Attributes[nameof(Type)]; set => this.Attributes[nameof(Type)] = value; }

        public static bool Preprocess(string html, ref int index, out ISegment segment)
        {
            const string style = "style";
            const string style_end = "</style>";
            segment = default(ISegment);

            if (html.Length > index + 6 && html.Substring(index + 1, style.Length).ToLower() == style)
            {
                int startIndex = index;
                var start = new StartTag(startIndex, html.IndexOf('>', index), html, style, default(Attributes));
                var attr = start.Block.TrimStart("<style".ToCharArray()).TrimEnd('>');
                start.Attributes = Attributes.Resolve(attr);

                index += 6;
                for (; index < html.Length; index++)
                    if (html.Substring(index, style_end.Length).ToLower() == style_end)
                    {
                        var last = index += style_end.Length - 1;
                        var end = new EndTag(last - 7, last, html, style);
                        var content = DataSegment.Resolve(((IPosition)start).Stop, ((IPosition)end).Start, html);
                        segment = new Style(start, end, new[] { content });
                        break;
                    }

                return true;
            }

            //
            return false;
        }
    }
}