namespace Meow.Schwarz.Entity.Infrastructure
{
    public sealed class ValueContent : DataSegment
    {
        internal ValueContent(int start, int stop, string source) : base(start, stop, source)
        {
            var x = this.Stop - this.Start - 1;
        }

        public new string Block
        {
            get => base.Block;
            set => base.Block = value;
        }

        public override string TagName => nameof(ValueContent);
    }
}