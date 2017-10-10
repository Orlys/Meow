namespace Meow.Schwarz.Entity
{
    using Auxiliary;
    using Infrastructure; using Interface;
    using System;

    /// <summary>
    /// Col Element
    /// </summary>
    public sealed class Col : EmptyTag
    {
        internal Col(int start, int stop, string source, Attributes attributes) : base(start, stop, source, attributes)
        {
        }

        [Obsolete]
        [Deprecated]
        public string Align { get => this.Attributes[nameof(Align)]; set => this.Attributes[nameof(Align)] = value; }

        [NotStandardized]
        public string BgColor { get => this.Attributes[nameof(BgColor)]; set => this.Attributes[nameof(BgColor)] = value; }

        [Obsolete]
        [Deprecated]
        public string Char { get => this.Attributes[nameof(Char)]; set => this.Attributes[nameof(Char)] = value; }

        [Obsolete]
        [Deprecated]
        public string CharOff { get => this.Attributes[nameof(CharOff)]; set => this.Attributes[nameof(CharOff)] = value; }

        public string Span { get => this.Attributes[nameof(Span)]; set => this.Attributes[nameof(Span)] = value; }

        [Obsolete]
        [Deprecated]
        public string VAlign { get => this.Attributes[nameof(VAlign)]; set => this.Attributes[nameof(VAlign)] = value; }

        [Obsolete]
        public string Width { get => this.Attributes[nameof(Width)]; set => this.Attributes[nameof(Width)] = value; }
    }
}