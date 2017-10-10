namespace Meow.Schwarz.Entity.Interface
{
    using Infrastructure; using Interface;
    using System.Collections.Generic;

    public interface IBlockTag : IAttributeSegment, IEntitySegment
    {
        IList<ISegment> Children { get; }

        EndTag EndTag { get; }

        StartTag StartTag { get; }
    }
}