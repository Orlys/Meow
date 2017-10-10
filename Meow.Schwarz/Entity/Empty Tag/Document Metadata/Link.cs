namespace Meow.Schwarz.Entity
{
    using Auxiliary;
    using Infrastructure; using Interface;
    using System;

    /// <summary>
    /// Link Element
    /// </summary>
    public sealed class Link : EmptyTag
    {
        internal Link(int start, int stop, string source, Attributes attributes) : base(start, stop, source, attributes)
        {
        }

        [Obsolete]
        public string CharSet { get => this.Attributes[nameof(CharSet)]; set => this.Attributes[nameof(CharSet)] = value; }

        public string CrossOrigin { get => this.Attributes[nameof(CrossOrigin)]; set => this.Attributes[nameof(CrossOrigin)] = value; }

        [NotStandardized]
        public string Disable { get => this.Attributes[nameof(Disable)]; set => this.Attributes[nameof(Disable)] = value; }

        public string Href { get => this.Attributes[nameof(Href)]; set => this.Attributes[nameof(Href)] = value; }

        public string HrefLang { get => this.Attributes[nameof(HrefLang)]; set => this.Attributes[nameof(HrefLang)] = value; }

        [Experimental]
        public string Integrity { get => this.Attributes[nameof(Integrity)]; set => this.Attributes[nameof(Integrity)] = value; }

        public string Media { get => this.Attributes[nameof(Media)]; set => this.Attributes[nameof(Media)] = value; }

        [NotStandardized]
        public string Methods { get => this.Attributes[nameof(Methods)]; set => this.Attributes[nameof(Methods)] = value; }

        [NotStandardized]
        public string Prefetch { get => this.Attributes[nameof(Prefetch)]; set => this.Attributes[nameof(Prefetch)] = value; }

        [Experimental]
        public string ReferrerPolicy { get => this.Attributes[nameof(ReferrerPolicy)]; set => this.Attributes[nameof(ReferrerPolicy)] = value; }

        public string Rel { get => this.Attributes[nameof(Rel)]; set => this.Attributes[nameof(Rel)] = value; }

        [Obsolete]
        public string Rev { get => this.Attributes[nameof(Rev)]; set => this.Attributes[nameof(Rev)] = value; }

        public string Sizes { get => this.Attributes[nameof(Sizes)]; set => this.Attributes[nameof(Sizes)] = value; }

        [NotStandardized]
        public string Target { get => this.Attributes[nameof(Target)]; set => this.Attributes[nameof(Target)] = value; }

        public new string Title { get; set; }

        public string Type { get => this.Attributes[nameof(Type)]; set => this.Attributes[nameof(Type)] = value; }
    }
}