// Author: Viyrex(aka Yuyu)
// Contact: mailto:viyrex.aka.yuyu@gmail.com
// Github: https://github.com/0x0001F36D
namespace Meow.Schwarz
{
    using Auxiliary;
    using Infrastructure;

    /// <summary>
    /// Keygen Element
    /// </summary>
    [Deprecated]
    public sealed class Keygen : EmptyTag
    {
        internal Keygen(int start, int stop, string source, Attributes attributes) : base(start, stop, source, attributes)
        {
        }

        public string AutoFocus { get => this.Attributes[nameof(AutoFocus)]; set => this.Attributes[nameof(AutoFocus)] = value; }

        public string Challenge { get => this.Attributes[nameof(Challenge)]; set => this.Attributes[nameof(Challenge)] = value; }

        public string Disabled { get => this.Attributes[nameof(Disabled)]; set => this.Attributes[nameof(Disabled)] = value; }

        public string Form { get => this.Attributes[nameof(Form)]; set => this.Attributes[nameof(Form)] = value; }

        public string KeyType { get => this.Attributes[nameof(KeyType)]; set => this.Attributes[nameof(KeyType)] = value; }

        public string Name { get => this.Attributes[nameof(Name)]; set => this.Attributes[nameof(Name)] = value; }
    }
}