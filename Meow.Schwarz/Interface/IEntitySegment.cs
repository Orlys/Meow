// Author: Viyrex(aka Yuyu)
// Contact: mailto:viyrex.aka.yuyu@gmail.com
// Github: https://github.com/0x0001F36D
namespace Meow.Schwarz.Interface
{
    using System.Collections.Generic;

    public interface Iegment : IEnumerable<ISegment>, ISegment
    {
        #region Public Properties

        string Content { get; }

        #endregion Public Properties
    }
}