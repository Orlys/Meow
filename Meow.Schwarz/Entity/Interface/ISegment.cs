namespace Meow.Schwarz.Entity.Interface
{
    public interface ISegment : IPosition, ILayout
    {
        string Block { get; }

        string Source { get; }

        string TagName { get; }
    }
}