namespace Meow.Schwarz.Entity.Interface
{
    using Infrastructure; using Interface;

    public interface IAttributeSegment : ISegment
    {
        Attributes Attributes { get; }
    }
}