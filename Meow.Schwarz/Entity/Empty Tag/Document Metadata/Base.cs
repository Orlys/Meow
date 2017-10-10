namespace Meow.Schwarz.Entity
{
    using Infrastructure; using Interface;/// <summary>

                         /// Base Element
                         /// </summary>
    public sealed class Base : EmptyTag
    {
        internal Base(int start, int stop, string source, Attributes attributes) : base(start, stop, source, attributes)
        {
        }

        public string Href { get => this.Attributes[nameof(Href)]; set => this.Attributes[nameof(Href)] = value; }

        public string Target { get => this.Attributes[nameof(Target)]; set => this.Attributes[nameof(Target)] = value; }
    }
}