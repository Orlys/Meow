// Author: Viyrex(aka Yuyu)
// Contact: mailto:viyrex.aka.yuyu@gmail.com
// Github: https://github.com/0x0001F36D
namespace Meow.Schwarz
{
    using Auxiliary;
    using Infrastructure;
    using Interface;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Object Element
    /// </summary>
    public sealed class Object : BlockTag
    {
        #region Internal Constructors

        internal Object(StartTag startTag, EndTag endTag, IEnumerable<ISegment> children) : base(startTag, endTag, children)

        {
        }

        #endregion Internal Constructors

        #region Public Properties

        [Obsolete]
        public string Archive { get => this.Attributes[nameof(Archive)]; set => this.Attributes[nameof(Archive)] = value; }

        [Obsolete]
        [Deprecated]
        public string Border { get => this.Attributes[nameof(Border)]; set => this.Attributes[nameof(Border)] = value; }

        [Obsolete]
        public string ClassId { get => this.Attributes[nameof(ClassId)]; set => this.Attributes[nameof(ClassId)] = value; }

        [Obsolete]
        public string CodeBase { get => this.Attributes[nameof(CodeBase)]; set => this.Attributes[nameof(CodeBase)] = value; }

        [Obsolete]
        public string CodeType { get => this.Attributes[nameof(CodeType)]; set => this.Attributes[nameof(CodeType)] = value; }

        public new string Data { get; set; }

        [Obsolete]
        public string Declare { get => this.Attributes[nameof(Declare)]; set => this.Attributes[nameof(Declare)] = value; }

        public string Form { get => this.Attributes[nameof(Form)]; set => this.Attributes[nameof(Form)] = value; }

        public string Height { get => this.Attributes[nameof(Height)]; set => this.Attributes[nameof(Height)] = value; }

        public string Name { get => this.Attributes[nameof(Name)]; set => this.Attributes[nameof(Name)] = value; }

        [Obsolete]
        public string Standby { get => this.Attributes[nameof(Standby)]; set => this.Attributes[nameof(Standby)] = value; }

        [Obsolete]
        public new string TabIndex { get; set; }

        public string Type { get => this.Attributes[nameof(Type)]; set => this.Attributes[nameof(Type)] = value; }

        public string TypeMustMatch { get => this.Attributes[nameof(TypeMustMatch)]; set => this.Attributes[nameof(TypeMustMatch)] = value; }

        public string UseMap { get => this.Attributes[nameof(UseMap)]; set => this.Attributes[nameof(UseMap)] = value; }

        public string Width { get => this.Attributes[nameof(Width)]; set => this.Attributes[nameof(Width)] = value; }

        #endregion Public Properties
    }
}