namespace Meow.Schwarz.Entity
{
    using Infrastructure; using Interface;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Html Element
    /// </summary>
    public sealed class Html : BlockTag
    {
        internal Html(StartTag startTag, EndTag endTag, IEnumerable<ISegment> children) : base(startTag, endTag, children)
        {
        }

        [Obsolete]
        public string Manifest { get => this.Attributes[nameof(Manifest)]; set => this.Attributes[nameof(Manifest)] = value; }

        [Obsolete]
        public string Version { get => this.Attributes[nameof(Version)]; set => this.Attributes[nameof(Version)] = value; }

        public string Xmlns { get => this.Attributes[nameof(Xmlns)]; set => this.Attributes[nameof(Xmlns)] = value; }
    }
}