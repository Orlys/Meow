// Author: Viyrex(aka Yuyu)
// Contact: mailto:viyrex.aka.yuyu@gmail.com
// Github: https://github.com/0x0001F36D
namespace Meow.Schwarz
{
    using Infrastructure;

    /// <summary>

    /// Track Element
    /// </summary>
    public sealed class Track : EmptyTag
    {
        internal Track(int start, int stop, string source, Attributes attributes) : base(start, stop, source, attributes)
        {
        }

        public string Default { get => this.Attributes[nameof(Default)]; set => this.Attributes[nameof(Default)] = value; }

        public string Kind { get => this.Attributes[nameof(Kind)]; set => this.Attributes[nameof(Kind)] = value; }

        public string Label { get => this.Attributes[nameof(Label)]; set => this.Attributes[nameof(Label)] = value; }

        public string Src { get => this.Attributes[nameof(Src)]; set => this.Attributes[nameof(Src)] = value; }

        public string SrcLang { get => this.Attributes[nameof(SrcLang)]; set => this.Attributes[nameof(SrcLang)] = value; }
    }
}