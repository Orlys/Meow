namespace Meow.Schwarz.Entity
{
    using Infrastructure;
    using Interface;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Label Element
    /// </summary>
    public sealed class Label : BlockTag
    {
        internal Label(StartTag startTag, EndTag endTag, IEnumerable<ISegment> children) : base(startTag, endTag, children)
        {
        }

        public string For { get => this.Attributes[nameof(For)]; set => this.Attributes[nameof(For)] = value; }

        [Obsolete]
        public string Form { get => this.Attributes[nameof(Form)]; set => this.Attributes[nameof(Form)] = value; }
    }
}