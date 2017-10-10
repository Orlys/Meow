namespace Meow.Schwarz.Entity.Auxiliary
{
    using System;

    /// <summary>
    /// This is an experimental API that should not be used in production code.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Class)]
    internal sealed class DeprecatedAttribute : Attribute
    {
    }
}