// Author: Viyrex(aka Yuyu)
// Contact: mailto:viyrex.aka.yuyu@gmail.com
// Github: https://github.com/0x0001F36D
namespace Meow.Schwarz.Infrastructure
{
    public sealed class ValueContent : DataSegment
    {
        #region Internal Constructors

        internal ValueContent(int start, int stop, string source) : base(start, stop, source)
        {
            var x = this.Stop - this.Start - 1;
        }

        #endregion Internal Constructors

        #region Public Properties

        public new string Block
        {
            get => base.Block;
            set => base.Block = value;
        }

        public override string TagName => nameof(ValueContent);

        #endregion Public Properties
    }
}