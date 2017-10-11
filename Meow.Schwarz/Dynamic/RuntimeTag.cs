// Author: Viyrex(aka Yuyu)
// Contact: mailto:viyrex.aka.yuyu@gmail.com
// Github: https://github.com/0x0001F36D
namespace Meow.Schwarz.Dynamic
{
    using Infrastructure;
    using Interface;
    using System.Collections;
    using System.Collections.Generic;

    public sealed class RuntimeTag : RuntimeAttributes, ISegment, Iegment, IAttributeSegment
    {
        #region Internal Constructors

        internal RuntimeTag(BlockTag blockTag) : base(blockTag.Attributes)
        {
            this._segment = blockTag;
        }

        #endregion Internal Constructors

        #region Private Fields

        private readonly BlockTag _segment;

        #endregion Private Fields

        #region Public Properties

        public Attributes Attributes => ((IAttributeSegment)this._segment).Attributes;

        public string Block => this._segment.Block;

        public string Content => ((Iegment)this._segment).Content;

        public dynamic DynamicAttributes => this;

        public string Source => this._segment.Source;

        int IPosition.Start => ((IPosition)this._segment).Start;

        int IPosition.Stop => ((IPosition)this._segment).Stop;

        public string TagName => this._segment.TagName;

        #endregion Public Properties

        #region Public Methods

        public static implicit operator BlockTag(RuntimeTag rs)
            => rs._segment as BlockTag;

        public IEnumerator<ISegment> GetEnumerator() => ((Iegment)this._segment).GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

        public string TextLayout() => this._segment.TextLayout();

        public override string ToString() => this.Block;

        #endregion Public Methods
    }
}