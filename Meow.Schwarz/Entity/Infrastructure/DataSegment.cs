namespace Meow.Schwarz.Entity.Infrastructure
{
    using Interface;

    public abstract class DataSegment : ISegment
    {
        protected DataSegment(int start, int stop, string source)
        {
            this.Start = start;
            this.Stop = stop;
            this.Source = source;
            var x = stop - start - 1;
            this.Block = source.Substring(start + 1, x < 0 ? 0 : x);
        }

        public string Block { get; protected set; }

        public string Source { get; }

        public int Start { get; protected set; }

        public int Stop { get; protected set; }

        public abstract string TagName { get; }

        public static DataSegment Resolve(int start, int stop, string html)
        {
            if (stop - start - 1 < 0)
                return new EmptyContent(0, 0, html);
            else
                return string.IsNullOrWhiteSpace(html.Substring(start + 1, stop - start - 1))
                    ? new EmptyContent(start, stop, html) as DataSegment
                    : new ValueContent(start, stop, html);
        }

        public string TextLayout() => this.Block;

        public override string ToString() => this.Block;
    }
}