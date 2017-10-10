namespace Meow.Schwarz.Entity
{
    using Infrastructure; using Interface;/// <summary>

                         /// Wbr Element
                         /// </summary>
    public sealed class Wbr : EmptyTag
    {
        internal Wbr(int start, int stop, string source, Attributes attributes) : base(start, stop, source, attributes)
        {
        }
    }
}