// Author: Viyrex(aka Yuyu)
// Contact: mailto:viyrex.aka.yuyu@gmail.com
// Github: https://github.com/0x0001F36D
namespace Meow.Schwarz.Infrastructure
{
    public sealed class EmptyContent : DataSegment
    {
        #region Internal Constructors

        internal EmptyContent(int start, int stop, string source) : base(start < 0 ? 0 : start, stop, source)
        {
        }

        #endregion Internal Constructors

        #region Public Properties

        public override string TagName => nameof(EmptyContent);

        #endregion Public Properties

        #region Public Methods

        public static explicit operator ValueContent(EmptyContent e)
            => new ValueContent(e.Start, e.Stop, e.Source);

        #endregion Public Methods
    }
}