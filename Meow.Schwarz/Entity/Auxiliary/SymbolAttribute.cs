namespace Meow.Schwarz.Entity.Auxiliary
{
    using System;

    [AttributeUsage(AttributeTargets.Class)]
    public sealed class SymbolAttribute : Attribute
    {
        public SymbolAttribute(string symbol)
        {
            this.Symbol = symbol;
        }

        public string Symbol { get; }
    }
}