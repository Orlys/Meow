// Author: Viyrex(aka Yuyu)
// Contact: mailto:viyrex.aka.yuyu@gmail.com
// Github: https://github.com/0x0001F36D
namespace Meow.Schwarz.Auxiliary
{
    using System;

    [AttributeUsage(AttributeTargets.Class)]
    public sealed class SymbolAttribute : Attribute
    {
        #region Public Constructors

        public SymbolAttribute(string symbol)
        {
            this.Symbol = symbol;
        }

        #endregion Public Constructors

        #region Public Properties

        public string Symbol { get; }

        #endregion Public Properties
    }
}