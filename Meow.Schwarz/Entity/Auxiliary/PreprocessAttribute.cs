namespace Meow.Schwarz.Entity.Auxiliary
{
    using System;

    [AttributeUsage((AttributeTargets)12, Inherited = false, AllowMultiple = false)]
    public sealed class PreprocessAttribute : System.Attribute
    {
        public PreprocessAttribute(int weight)
        {
            this.Weight = weight;
        }

        public int Weight { get; }
    }
}