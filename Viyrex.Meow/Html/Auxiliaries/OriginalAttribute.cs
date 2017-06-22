using System;

namespace Viyrex.ML.Html.Auxiliaries
{
    [AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = false)]
    sealed class OriginalAttribute : Attribute
    {
        private readonly string original;

        public OriginalAttribute(string original)
            => this.original = original;

        public string GetOriginal()
            => this.original;
    }
}
