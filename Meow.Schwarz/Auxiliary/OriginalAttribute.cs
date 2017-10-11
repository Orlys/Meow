// Author: Viyrex(aka Yuyu)
// Contact: mailto:viyrex.aka.yuyu@gmail.com
// Github: https://github.com/0x0001F36D
namespace Meow.Schwarz.Auxiliary
{
    using System;

    [AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = false)]
    internal sealed class OriginalAttribute : Attribute
    {
        #region Public Constructors

        public OriginalAttribute(string original)
            => this.original = original;

        #endregion Public Constructors

        #region Private Fields

        private readonly string original;

        #endregion Private Fields

        #region Public Methods

        public string GetOriginal()
            => this.original;

        #endregion Public Methods
    }
}