// Author: Viyrex(aka Yuyu)
// Contact: mailto:viyrex.aka.yuyu@gmail.com
// Github: https://github.com/0x0001F36D
namespace Meow.Schwarz
{
    using Auxiliary;
    using Infrastructure;

    /// <summary>
    /// IsIndex Element
    /// </summary>
    [Deprecated]
    public sealed class IsIndex : EmptyTag
    {
        #region Internal Constructors

        internal IsIndex(int start, int stop, string source, Attributes attributes) : base(start, stop, source, attributes)
        {
        }

        #endregion Internal Constructors

        #region Public Properties

        public string Action { get => this.Attributes[nameof(Action)]; set => this.Attributes[nameof(Action)] = value; }

        public string Propmt { get => this.Attributes[nameof(Propmt)]; set => this.Attributes[nameof(Propmt)] = value; }

        #endregion Public Properties
    }
}