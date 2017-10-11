// Author: Viyrex(aka Yuyu)
// Contact: mailto:viyrex.aka.yuyu@gmail.com
// Github: https://github.com/0x0001F36D
namespace Meow.Schwarz.Interface
{
    using Infrastructure;

    public interface IAttributeSegment : ISegment
    {
        #region Public Properties

        Attributes Attributes { get; }

        #endregion Public Properties
    }
}