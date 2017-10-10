namespace Meow.Schwarz.Entity
{
    using Infrastructure; using Interface;
    using System.Collections.Generic;

    /// <summary>
    /// Video Element
    /// </summary>
    public sealed class Video : BlockTag
    {
        internal Video(StartTag startTag, EndTag endTag, IEnumerable<ISegment> children) : base(startTag, endTag, children)
        {
        }

        public string AutoPlay { get => this.Attributes[nameof(AutoPlay)]; set => this.Attributes[nameof(AutoPlay)] = value; }

        public string Buffered { get => this.Attributes[nameof(Buffered)]; set => this.Attributes[nameof(Buffered)] = value; }

        public string Controls { get => this.Attributes[nameof(Controls)]; set => this.Attributes[nameof(Controls)] = value; }

        public string CrossOrigin { get => this.Attributes[nameof(CrossOrigin)]; set => this.Attributes[nameof(CrossOrigin)] = value; }

        public string Height { get => this.Attributes[nameof(Height)]; set => this.Attributes[nameof(Height)] = value; }

        public string Loop { get => this.Attributes[nameof(Loop)]; set => this.Attributes[nameof(Loop)] = value; }

        public string Muted { get => this.Attributes[nameof(Muted)]; set => this.Attributes[nameof(Muted)] = value; }

        public string Played { get => this.Attributes[nameof(Played)]; set => this.Attributes[nameof(Played)] = value; }

        public string Poster { get => this.Attributes[nameof(Poster)]; set => this.Attributes[nameof(Poster)] = value; }

        public string Preload { get => this.Attributes[nameof(Preload)]; set => this.Attributes[nameof(Preload)] = value; }

        public string Src { get => this.Attributes[nameof(Src)]; set => this.Attributes[nameof(Src)] = value; }

        public string Width { get => this.Attributes[nameof(Width)]; set => this.Attributes[nameof(Width)] = value; }
    }
}