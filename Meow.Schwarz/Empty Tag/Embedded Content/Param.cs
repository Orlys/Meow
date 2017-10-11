// Author: Viyrex(aka Yuyu)
// Contact: mailto:viyrex.aka.yuyu@gmail.com
// Github: https://github.com/0x0001F36D
namespace Meow.Schwarz
{
    using Infrastructure;
    using System;

    /// <summary>
    /// Param Element
    /// </summary>
    public sealed class Param : EmptyTag
    {
        internal Param(int start, int stop, string source, Attributes attributes) : base(start, stop, source, attributes)
        {
        }

        public string Name { get => this.Attributes[nameof(Name)]; set => this.Attributes[nameof(Name)] = value; }

        [Obsolete]
        public string Type { get => this.Attributes[nameof(Type)]; set => this.Attributes[nameof(Type)] = value; }

        public string Value { get => this.Attributes[nameof(Value)]; set => this.Attributes[nameof(Value)] = value; }

        [Obsolete]
        public string ValueType { get => this.Attributes[nameof(ValueType)]; set => this.Attributes[nameof(ValueType)] = value; }
    }
}