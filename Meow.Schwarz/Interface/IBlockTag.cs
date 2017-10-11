// Author: Viyrex(aka Yuyu)
// Contact: mailto:viyrex.aka.yuyu@gmail.com
// Github: https://github.com/0x0001F36D
namespace Meow.Schwarz.Interface
{
    using Infrastructure;
    using System.Collections.Generic;

    public interface IBlockTag : IAttributeSegment, Iegment
    {
        #region Public Properties

        IList<ISegment> Children { get; }

        EndTag EndTag { get; }

        StartTag StartTag { get; }

        #endregion Public Properties
    }
}