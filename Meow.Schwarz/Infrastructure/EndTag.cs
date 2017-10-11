// Author: Viyrex(aka Yuyu)
// Contact: mailto:viyrex.aka.yuyu@gmail.com
// Github: https://github.com/0x0001F36D
namespace Meow.Schwarz.Infrastructure
{
    public sealed class EndTag : TagSegment
    {
        #region Internal Constructors

        internal EndTag(int start, int stop, string source, string tagName) : base(start, stop, source, tagName)
        {
        }

        #endregion Internal Constructors
    }
}