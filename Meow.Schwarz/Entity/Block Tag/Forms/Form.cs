namespace Meow.Schwarz.Entity
{
    using Auxiliary;
    using Infrastructure; using Interface;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Form Element
    /// </summary>
    public sealed class Form : BlockTag
    {
        internal Form(StartTag startTag, EndTag endTag, IEnumerable<ISegment> children) : base(startTag, endTag, children)
        {
        }

        [Obsolete]
        public string Accept { get => this.Attributes[nameof(Accept)]; set => this.Attributes[nameof(Accept)] = value; }

        public string Accept_Charset { get => this.Attributes[nameof(Accept_Charset).Replace('_', '-')]; set => this.Attributes[nameof(Accept_Charset).Replace('_', '-')] = value; }

        public string Action { get => this.Attributes[nameof(Action)]; set => this.Attributes[nameof(Action)] = value; }

        [NotStandardized]
        public string AutoCapitalize { get => this.Attributes[nameof(AutoCapitalize)]; set => this.Attributes[nameof(AutoCapitalize)] = value; }

        public string AutoComplete { get => this.Attributes[nameof(AutoComplete)]; set => this.Attributes[nameof(AutoComplete)] = value; }

        public string EncType { get => this.Attributes[nameof(EncType)]; set => this.Attributes[nameof(EncType)] = value; }

        public string Method { get => this.Attributes[nameof(Method)]; set => this.Attributes[nameof(Method)] = value; }

        public string Name { get => this.Attributes[nameof(Name)]; set => this.Attributes[nameof(Name)] = value; }

        public string NoValidate { get => this.Attributes[nameof(NoValidate)]; set => this.Attributes[nameof(NoValidate)] = value; }

        public string Target { get => this.Attributes[nameof(Target)]; set => this.Attributes[nameof(Target)] = value; }
    }
}