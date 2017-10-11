// Author: Viyrex(aka Yuyu)
// Contact: mailto:viyrex.aka.yuyu@gmail.com
// Github: https://github.com/0x0001F36D
namespace Meow.Schwarz
{
    using Infrastructure;
    using System;

    /// <summary>
    /// Meta Element
    /// </summary>
    public sealed class Meta : EmptyTag
    {
        internal Meta(int start, int stop, string source, Attributes attributes) : base(start, stop, source, attributes)
        {
        }

        public string CharSet { get => this.Attributes[nameof(CharSet)]; set => this.Attributes[nameof(CharSet)] = value; }

        public string Http_Equiv { get => this.Attributes[nameof(Http_Equiv).Replace('_', '-')]; set => this.Attributes[nameof(Http_Equiv).Replace('_', '-')] = value; }

        public string Name { get => this.Attributes[nameof(Name)]; set => this.Attributes[nameof(Name)] = value; }

        [Obsolete]
        public string Scheme { get => this.Attributes[nameof(Scheme)]; set => this.Attributes[nameof(Scheme)] = value; }
    }
}