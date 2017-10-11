// Author: Viyrex(aka Yuyu)
// Contact: mailto:viyrex.aka.yuyu@gmail.com
// Github: https://github.com/0x0001F36D
namespace Meow.Schwarz.Auxiliary
{
    using System;

    [AttributeUsage((AttributeTargets)12, Inherited = false, AllowMultiple = false)]
    public sealed class PreprocessAttribute : System.Attribute
    {
        #region Public Constructors

        public PreprocessAttribute(int weight)
        {
            this.Weight = weight;
        }

        #endregion Public Constructors

        #region Public Properties

        public int Weight { get; }

        #endregion Public Properties
    }
}