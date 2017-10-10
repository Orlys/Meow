namespace Meow.Schwarz.Entity
{
    using Infrastructure; using Interface;/// <summary>

                         /// Br Element
                         /// </summary>
    public sealed class Br : EmptyTag
    {
        internal Br(int start, int stop, string source, Attributes attributes) : base(start, stop, source, attributes)
        {
        }
    }
}