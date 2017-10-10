namespace Meow.Schwarz.Entity.Infrastructure
{
    public sealed class EmptyContent : DataSegment
    {
        internal EmptyContent(int start, int stop, string source) : base(start < 0 ? 0 : start, stop, source)
        {
        }

        public override string TagName => nameof(EmptyContent);

        public static explicit operator ValueContent(EmptyContent e)
            => new ValueContent(e.Start, e.Stop, e.Source);
    }
}