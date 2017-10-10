namespace Meow.Schwarz.Entity.Interface
{
    using System.Collections.Generic;

    public interface IEntitySegment : IEnumerable<ISegment>, ISegment
    {
        string Content { get; }
    }
}