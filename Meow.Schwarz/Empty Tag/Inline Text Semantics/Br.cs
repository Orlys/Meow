// Author: Viyrex(aka Yuyu)
// Contact: mailto:viyrex.aka.yuyu@gmail.com
// Github: https://github.com/0x0001F36D
namespace Meow.Schwarz
{
    using Infrastructure;

    /// <summary>

    /// Br Element
    /// </summary>
    public sealed class Br : EmptyTag
    {
        #region Internal Constructors

        internal Br(int start, int stop, string source, Attributes attributes) : base(start, stop, source, attributes)
        {
        }

        #endregion Internal Constructors
    }
}