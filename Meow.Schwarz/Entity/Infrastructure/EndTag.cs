namespace Meow.Schwarz.Entity.Infrastructure
{
    public sealed class EndTag : TagSegment
    {
        internal EndTag(int start, int stop, string source, string tagName) : base(start, stop, source, tagName)
        {
        }
    }
}