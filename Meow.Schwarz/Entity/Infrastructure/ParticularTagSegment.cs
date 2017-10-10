namespace Meow.Schwarz.Entity.Infrastructure
{
    public class ParticularTagSegment : TagSegment
    {
        internal ParticularTagSegment(int start, int stop, string source) : base(start, stop, source)
        {
        }

        public override string Block => this.BlockEvaluate(base.Block);

        protected virtual string BlockEvaluate(string block)
            => block;
    }
}