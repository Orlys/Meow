namespace Meow.Schwarz.Entity
{
    using Auxiliary;
    using Infrastructure; using Interface;
    using System;

    /// <summary>
    /// Area Element
    /// </summary>
    public sealed class Area : EmptyTag
    {
        internal Area(int start, int stop, string source, Attributes attributes) : base(start, stop, source, attributes)
        {
        }

        public string Alt { get => this.Attributes[nameof(Alt)]; set => this.Attributes[nameof(Alt)] = value; }

        public string Coords { get => this.Attributes[nameof(Coords)]; set => this.Attributes[nameof(Coords)] = value; }

        public string Download { get => this.Attributes[nameof(Download)]; set => this.Attributes[nameof(Download)] = value; }

        public string Href { get => this.Attributes[nameof(Href)]; set => this.Attributes[nameof(Href)] = value; }

        public string HrefLang { get => this.Attributes[nameof(HrefLang)]; set => this.Attributes[nameof(HrefLang)] = value; }

        public string Media { get => this.Attributes[nameof(Media)]; set => this.Attributes[nameof(Media)] = value; }

        [Obsolete]
        public string Name { get => this.Attributes[nameof(Name)]; set => this.Attributes[nameof(Name)] = value; }

        [Obsolete]
        public string NoHref { get => this.Attributes[nameof(NoHref)]; set => this.Attributes[nameof(NoHref)] = value; }

        [Experimental]
        public string RefferrerPolicy { get => this.Attributes[nameof(RefferrerPolicy)]; set => this.Attributes[nameof(RefferrerPolicy)] = value; }

        public string Rel { get => this.Attributes[nameof(Rel)]; set => this.Attributes[nameof(Rel)] = value; }

        public string Shape { get => this.Attributes[nameof(Shape)]; set => this.Attributes[nameof(Shape)] = value; }

        public string Target { get => this.Attributes[nameof(Target)]; set => this.Attributes[nameof(Target)] = value; }

        [Obsolete]
        public string Type { get => this.Attributes[nameof(Type)]; set => this.Attributes[nameof(Type)] = value; }
    }
}