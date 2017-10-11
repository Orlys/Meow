// Author: Viyrex(aka Yuyu)
// Contact: mailto:viyrex.aka.yuyu@gmail.com
// Github: https://github.com/0x0001F36D
namespace Meow.Schwarz.Interface
{
    public interface ISegment : IPosition, ILayout
    {
        #region Public Properties

        string Block { get; }

        string Source { get; }

        string TagName { get; }

        #endregion Public Properties
    }
}