namespace Meow.Schwarz.Entity
{
    using Infrastructure; using Interface;/// <summary>

                         /// Embed Element
                         /// </summary>
    public sealed class Embed : EmptyTag
    {
        internal Embed(int start, int stop, string source, Attributes attributes) : base(start, stop, source, attributes)
        {
        }

        public string Height { get => this.Attributes[nameof(Height)]; set => this.Attributes[nameof(Height)] = value; }

        public string Src { get => this.Attributes[nameof(Src)]; set => this.Attributes[nameof(Src)] = value; }

        public string Type { get => this.Attributes[nameof(Type)]; set => this.Attributes[nameof(Type)] = value; }

        public string Width { get => this.Attributes[nameof(Width)]; set => this.Attributes[nameof(Width)] = value; }
    }
}