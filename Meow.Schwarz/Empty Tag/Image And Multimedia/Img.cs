// Author: Viyrex(aka Yuyu)
// Contact: mailto:viyrex.aka.yuyu@gmail.com
// Github: https://github.com/0x0001F36D
namespace Meow.Schwarz
{
    using Infrastructure;
    using System;

    /// <summary>
    /// Img Element
    /// </summary>
    public sealed class Img : EmptyTag
    {
        internal Img(int start, int stop, string source, Attributes attributes) : base(start, stop, source, attributes)
        {
        }

        [Obsolete]
        public string Align { get => this.Attributes[nameof(Align)]; set => this.Attributes[nameof(Align)] = value; }

        public string Alt { get => this.Attributes[nameof(Alt)]; set => this.Attributes[nameof(Alt)] = value; }

        [Obsolete]
        public string Border { get => this.Attributes[nameof(Border)]; set => this.Attributes[nameof(Border)] = value; }

        public string CrossOrigin { get => this.Attributes[nameof(CrossOrigin)]; set => this.Attributes[nameof(CrossOrigin)] = value; }

        public string Height { get => this.Attributes[nameof(Height)]; set => this.Attributes[nameof(Height)] = value; }

        [Obsolete]
        public string HSpace { get => this.Attributes[nameof(HSpace)]; set => this.Attributes[nameof(HSpace)] = value; }

        public string IsMap { get => this.Attributes[nameof(IsMap)]; set => this.Attributes[nameof(IsMap)] = value; }

        public string LoangDesc { get => this.Attributes[nameof(LoangDesc)]; set => this.Attributes[nameof(LoangDesc)] = value; }

        [Obsolete]
        public string Name { get => this.Attributes[nameof(Name)]; set => this.Attributes[nameof(Name)] = value; }

        public string ReferrerPolicy { get => this.Attributes[nameof(ReferrerPolicy)]; set => this.Attributes[nameof(ReferrerPolicy)] = value; }

        public string Sizes { get => this.Attributes[nameof(Sizes)]; set => this.Attributes[nameof(Sizes)] = value; }

        public string Src { get => this.Attributes[nameof(Src)]; set => this.Attributes[nameof(Src)] = value; }

        public string SrcSet { get => this.Attributes[nameof(SrcSet)]; set => this.Attributes[nameof(SrcSet)] = value; }

        [Obsolete]
        public string VSpace { get => this.Attributes[nameof(VSpace)]; set => this.Attributes[nameof(VSpace)] = value; }

        public string Width { get => this.Attributes[nameof(Width)]; set => this.Attributes[nameof(Width)] = value; }
    }
}