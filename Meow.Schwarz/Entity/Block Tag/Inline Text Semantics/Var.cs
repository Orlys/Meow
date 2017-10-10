namespace Meow.Schwarz.Entity
{
    using Infrastructure; using Interface;
    using System.Collections.Generic;

    /// <summary>
    /// Var Element
    /// </summary>
    public sealed class Var : BlockTag
    {
        internal Var(StartTag startTag, EndTag endTag, IEnumerable<ISegment> children) : base(startTag, endTag, children)
        {
        }
    }
}