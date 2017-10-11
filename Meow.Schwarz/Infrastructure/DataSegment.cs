// Author: Viyrex(aka Yuyu)
// Contact: mailto:viyrex.aka.yuyu@gmail.com
// Github: https://github.com/0x0001F36D
namespace Meow.Schwarz.Infrastructure
{
    using Interface;

    public abstract class DataSegment : ISegment
    {
        #region Protected Constructors

        protected DataSegment(int start, int stop, string source)
        {
            this.Start = start;
            this.Stop = stop;
            this.Source = source;
            var x = stop - start - 1;
            this.Block = source.Substring(start + 1, x < 0 ? 0 : x);
        }

        #endregion Protected Constructors

        #region Public Properties

        public string Block { get; protected set; }

        public string Source { get; }

        public int Start { get; protected set; }

        public int Stop { get; protected set; }

        public abstract string TagName { get; }

        #endregion Public Properties

        #region Public Methods

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

        #endregion Public Methods
    }
}