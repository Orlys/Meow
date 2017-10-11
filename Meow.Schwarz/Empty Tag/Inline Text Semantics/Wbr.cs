// Author: Viyrex(aka Yuyu)
// Contact: mailto:viyrex.aka.yuyu@gmail.com
// Github: https://github.com/0x0001F36D
namespace Meow.Schwarz
{
    using Infrastructure;

    /// <summary>

    /// Wbr Element
    /// </summary>
    public sealed class Wbr : EmptyTag
    {
        #region Internal Constructors

        internal Wbr(int start, int stop, string source, Attributes attributes) : base(start, stop, source, attributes)
        {
        }

        #endregion Internal Constructors
    }
}