// Author: Viyrex(aka Yuyu)
// Contact: mailto:viyrex.aka.yuyu@gmail.com
// Github: https://github.com/0x0001F36D
namespace Meow.Schwarz
{
    using Auxiliary;
    using Infrastructure;
    using Interface;
    using System.Collections.Generic;

    /// <summary>
    /// Script Element
    /// </summary>
    [Preprocess(int.MaxValue - 2)]
    public sealed class Script : BlockTag
    {
        internal Script(StartTag startTag, EndTag endTag, IEnumerable<ISegment> children) : base(startTag, endTag, children)
        {
        }

        public string Async { get => this.Attributes[nameof(Async)]; set => this.Attributes[nameof(Async)] = value; }

        public string CrossOrigin { get => this.Attributes[nameof(CrossOrigin)]; set => this.Attributes[nameof(CrossOrigin)] = value; }

        public string Defer { get => this.Attributes[nameof(Defer)]; set => this.Attributes[nameof(Defer)] = value; }

        public string Integrity { get => this.Attributes[nameof(Integrity)]; set => this.Attributes[nameof(Integrity)] = value; }

        [Deprecated]
        public string Language { get => this.Attributes[nameof(Language)]; set => this.Attributes[nameof(Language)] = value; }

        [Experimental]
        public string NoModule { get => this.Attributes[nameof(NoModule)]; set => this.Attributes[nameof(NoModule)] = value; }

        public string Src { get => this.Attributes[nameof(Src)]; set => this.Attributes[nameof(Src)] = value; }

        public string Text { get => this.Attributes[nameof(Text)]; set => this.Attributes[nameof(Text)] = value; }

        public string Type { get => this.Attributes[nameof(Type)]; set => this.Attributes[nameof(Type)] = value; }

        public static bool Preprocess(string html, ref int index, out ISegment segment)
        {
            const string script = "script";
            const string script_end = "</script>";
            segment = default(ISegment);

            if (html.Length > index + 7 && html.Substring(index + 1, script.Length).ToLower() == script)
            {
                int startIndex = index;
                var start = new StartTag(startIndex, html.IndexOf('>', index), html, script, default(Attributes));
                var attr = start.Block.TrimStart("<script".ToCharArray()).TrimEnd('>');
                start.Attributes = Attributes.Resolve(attr);

                index += 7;
                for (; index < html.Length; index++)
                    if (html.Substring(index, script_end.Length).ToLower() == script_end)
                    {
                        var last = index += script_end.Length - 1;
                        var end = new EndTag(last - 8, last, html, script);
                        var content = DataSegment.Resolve(((IPosition)start).Stop, ((IPosition)end).Start, html);
                        segment = new Script(start, end, new[] { content });
                        break;
                    }
                return true;
            }
            else
            {
                //
                return false;
            }
        }

        /*

        // Obsolete CODE
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
                        segment = new TagSegment(startIndex, index += script_end.Length - 1, html, "Script");
                        index--;
                        break;
                    }
                return true;
            }

            //
            return false;
        }
         */
    }
}