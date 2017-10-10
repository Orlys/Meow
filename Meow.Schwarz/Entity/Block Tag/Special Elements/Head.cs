namespace Meow.Schwarz.Entity
{
    using Infrastructure;
    using Interface;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Head Element
    /// </summary>
    public sealed class Head : BlockTag
    {
        internal Head(StartTag startTag, EndTag endTag, IEnumerable<ISegment> children) : base(startTag, endTag, children)
        {
        }

        [Obsolete]
        public string Profile { get => this.Attributes[nameof(Profile)]; set => this.Attributes[nameof(Profile)] = value; }
    }
}