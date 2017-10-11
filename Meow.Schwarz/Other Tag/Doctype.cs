// Author: Viyrex(aka Yuyu)
// Contact: mailto:viyrex.aka.yuyu@gmail.com
// Github: https://github.com/0x0001F36D
namespace Meow.Schwarz
{
    using Auxiliary;
    using Infrastructure;
    using Interface;

    [Symbol("!doctype")]
    [Preprocess(int.MaxValue)]
    public sealed class Doctype : ParticularTagSegment
    {
        private const string TOKEN = "!doctype html";

        internal Doctype(int start, int stop, string source) : base(start, stop, source)
        {
        }

        public override string TagName => nameof(Doctype);

        //public int Version => string.IsNullOrWhiteSpace(this.Block) ? 5 : 4;
        public static bool Preprocess(string html, ref int index, out ISegment segment)
        {
            segment = default(ISegment);
            if (html.Length > index + 14 && html.Substring(index + 1, 13).ToLower() == TOKEN)
            {
                int startIndex = index;
                index += 14;
                for (; index < html.Length; index++)
                    if (html.Substring(index, 1) == ">")
                    {
                        segment = new Doctype(startIndex, index, html);
                        return true;
                    }
            }

            //
            return false;
        }

        protected override string BlockEvaluate(string block) => block.Substring(14).TrimEnd('>');
    }
}