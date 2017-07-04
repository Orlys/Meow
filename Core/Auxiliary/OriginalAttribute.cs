namespace Meow.Auxiliary
{
    using System;

    [AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = false)]
    internal sealed class OriginalAttribute : Attribute
    {
        private readonly string original;

        public OriginalAttribute(string original)
            => this.original = original;

        public string GetOriginal()
            => this.original;
    }
}