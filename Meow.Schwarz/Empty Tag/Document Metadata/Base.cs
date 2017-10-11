// Author: Viyrex(aka Yuyu)
// Contact: mailto:viyrex.aka.yuyu@gmail.com
// Github: https://github.com/0x0001F36D
namespace Meow.Schwarz
{
    using Infrastructure;

    /// <summary>

    /// Base Element
    /// </summary>
    public sealed class Base : EmptyTag
    {
        #region Internal Constructors

        internal Base(int start, int stop, string source, Attributes attributes) : base(start, stop, source, attributes)
        {
        }

        #endregion Internal Constructors

        #region Public Properties

        public string Href { get => this.Attributes[nameof(Href)]; set => this.Attributes[nameof(Href)] = value; }

        public string Target { get => this.Attributes[nameof(Target)]; set => this.Attributes[nameof(Target)] = value; }

        #endregion Public Properties
    }
}