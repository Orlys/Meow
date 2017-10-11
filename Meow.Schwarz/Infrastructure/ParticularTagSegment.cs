// Author: Viyrex(aka Yuyu)
// Contact: mailto:viyrex.aka.yuyu@gmail.com
// Github: https://github.com/0x0001F36D
namespace Meow.Schwarz.Infrastructure
{
    public class ParticularTagSegment : TagSegment
    {
        #region Internal Constructors

        internal ParticularTagSegment(int start, int stop, string source) : base(start, stop, source)
        {
        }

        #endregion Internal Constructors

        #region Public Properties

        public override string Block => this.BlockEvaluate(base.Block);

        #endregion Public Properties

        #region Protected Methods

        protected virtual string BlockEvaluate(string block)
            => block;

        #endregion Protected Methods
    }
}