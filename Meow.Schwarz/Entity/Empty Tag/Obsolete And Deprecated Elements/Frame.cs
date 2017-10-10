namespace Meow.Schwarz.Entity
{
    using Auxiliary;
    using Infrastructure; using Interface;

    /// <summary>
    /// Frame Element
    /// </summary>
    [Deprecated]
    public sealed class Frame : EmptyTag
    {
        internal Frame(int start, int stop, string source, Attributes attributes) : base(start, stop, source, attributes)
        {
        }

        public string FrameBorder { get => this.Attributes[nameof(FrameBorder)]; set => this.Attributes[nameof(FrameBorder)] = value; }

        public string MarginHeight { get => this.Attributes[nameof(MarginHeight)]; set => this.Attributes[nameof(MarginHeight)] = value; }

        public string MarginWidth { get => this.Attributes[nameof(MarginWidth)]; set => this.Attributes[nameof(MarginWidth)] = value; }

        public string Name { get => this.Attributes[nameof(Name)]; set => this.Attributes[nameof(Name)] = value; }

        public string NoResize { get => this.Attributes[nameof(NoResize)]; set => this.Attributes[nameof(NoResize)] = value; }

        public string Scrolling { get => this.Attributes[nameof(Scrolling)]; set => this.Attributes[nameof(Scrolling)] = value; }

        public string Src { get => this.Attributes[nameof(Src)]; set => this.Attributes[nameof(Src)] = value; }
    }
}