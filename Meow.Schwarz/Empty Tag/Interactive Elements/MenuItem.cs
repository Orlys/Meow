// Author: Viyrex(aka Yuyu)
// Contact: mailto:viyrex.aka.yuyu@gmail.com
// Github: https://github.com/0x0001F36D
namespace Meow.Schwarz
{
    using Infrastructure;

    /// <summary>

    /// MenuItem Element
    /// </summary>
    public sealed class MenuItem : EmptyTag
    {
        internal MenuItem(int start, int stop, string source, Attributes attributes) : base(start, stop, source, attributes)
        {
        }

        public string Check { get => this.Attributes[nameof(Check)]; set => this.Attributes[nameof(Check)] = value; }

        public string Command { get => this.Attributes[nameof(Command)]; set => this.Attributes[nameof(Command)] = value; }

        public string Default { get => this.Attributes[nameof(Default)]; set => this.Attributes[nameof(Default)] = value; }

        public string Icon { get => this.Attributes[nameof(Icon)]; set => this.Attributes[nameof(Icon)] = value; }

        public string Label { get => this.Attributes[nameof(Label)]; set => this.Attributes[nameof(Label)] = value; }

        public string RadioGroup { get => this.Attributes[nameof(RadioGroup)]; set => this.Attributes[nameof(RadioGroup)] = value; }

        public string Type { get => this.Attributes[nameof(Type)]; set => this.Attributes[nameof(Type)] = value; }
    }
}