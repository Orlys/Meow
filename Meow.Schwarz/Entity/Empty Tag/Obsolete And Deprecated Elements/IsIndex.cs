namespace Meow.Schwarz.Entity
{
    using Auxiliary;
    using Infrastructure; using Interface;

    /// <summary>
    /// IsIndex Element
    /// </summary>
    [Deprecated]
    public sealed class IsIndex : EmptyTag
    {
        internal IsIndex(int start, int stop, string source, Attributes attributes) : base(start, stop, source, attributes)
        {
        }

        public string Action { get => this.Attributes[nameof(Action)]; set => this.Attributes[nameof(Action)] = value; }

        public string Propmt { get => this.Attributes[nameof(Propmt)]; set => this.Attributes[nameof(Propmt)] = value; }
    }
}