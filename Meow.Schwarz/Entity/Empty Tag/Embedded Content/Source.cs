namespace Meow.Schwarz.Entity
{
    using Auxiliary;
    using Infrastructure; using Interface;

    /// <summary>
    /// Source Element
    /// </summary>
    public sealed class Source : EmptyTag
    {
        internal Source(int start, int stop, string source, Attributes attributes) : base(start, stop, source, attributes)
        {
        }

        [Experimental]
        public string Media { get => this.Attributes[nameof(Media)]; set => this.Attributes[nameof(Media)] = value; }

        [Experimental]
        public string Sizes { get => this.Attributes[nameof(Sizes)]; set => this.Attributes[nameof(Sizes)] = value; }

        public string Src { get => this.Attributes[nameof(Src)]; set => this.Attributes[nameof(Src)] = value; }

        [Experimental]
        public string SrcSet { get => this.Attributes[nameof(SrcSet)]; set => this.Attributes[nameof(SrcSet)] = value; }

        public string Type { get => this.Attributes[nameof(Type)]; set => this.Attributes[nameof(Type)] = value; }
    }
}