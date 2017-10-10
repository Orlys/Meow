namespace Meow.Schwarz.Entity
{
    using Infrastructure; using Interface;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Applet Element
    /// </summary>
    [Obsolete]
    public sealed class Applet : BlockTag
    {
        internal Applet(StartTag startTag, EndTag endTag, IEnumerable<ISegment> children) : base(startTag, endTag, children)
        {
        }

        public string Align { get => this.Attributes[nameof(Align)]; set => this.Attributes[nameof(Align)] = value; }

        public string Alt { get => this.Attributes[nameof(Alt)]; set => this.Attributes[nameof(Alt)] = value; }

        public string Archive { get => this.Attributes[nameof(Archive)]; set => this.Attributes[nameof(Archive)] = value; }

        public string Code { get => this.Attributes[nameof(Code)]; set => this.Attributes[nameof(Code)] = value; }

        public string CodeBase { get => this.Attributes[nameof(CodeBase)]; set => this.Attributes[nameof(CodeBase)] = value; }

        public string DataFld { get => this.Attributes[nameof(DataFld)]; set => this.Attributes[nameof(DataFld)] = value; }

        public string DataSrc { get => this.Attributes[nameof(DataSrc)]; set => this.Attributes[nameof(DataSrc)] = value; }

        public string Height { get => this.Attributes[nameof(Height)]; set => this.Attributes[nameof(Height)] = value; }

        public string HSpace { get => this.Attributes[nameof(HSpace)]; set => this.Attributes[nameof(HSpace)] = value; }

        public string MayScript { get => this.Attributes[nameof(MayScript)]; set => this.Attributes[nameof(MayScript)] = value; }

        public string Name { get => this.Attributes[nameof(Name)]; set => this.Attributes[nameof(Name)] = value; }

        public string Object { get => this.Attributes[nameof(Object)]; set => this.Attributes[nameof(Object)] = value; }

        public string Src { get => this.Attributes[nameof(Src)]; set => this.Attributes[nameof(Src)] = value; }

        public string VSpace { get => this.Attributes[nameof(VSpace)]; set => this.Attributes[nameof(VSpace)] = value; }

        public string Width { get => this.Attributes[nameof(Width)]; set => this.Attributes[nameof(Width)] = value; }
    }
}