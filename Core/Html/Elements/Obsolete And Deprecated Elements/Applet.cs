﻿namespace Meow.Html.Elements
{
    using Meow.Html.Infrastructure;
    using System;

    /// <summary>
    /// Applet Element
    /// </summary>
    [Obsolete]
    public sealed class Applet : NormalElementBase
    {
        public string Align { get; set; }

        public string Alt { get; set; }

        public string Archive { get; set; }

        public string Code { get; set; }

        public string CodeBase { get; set; }

        public string DataFld { get; set; }

        public string DataSrc { get; set; }

        public string Height { get; set; }

        public string HSpace { get; set; }

        public string MayScript { get; set; }

        public string Name { get; set; }

        public string Object { get; set; }

        public string Src { get; set; }

        public string VSpace { get; set; }

        public string Width { get; set; }
    }
}