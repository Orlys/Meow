namespace Meow.Schwarz.Entity.Auxiliary
{
    using System;

    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Class)]
    internal sealed class NotStandardizedAttribute : Attribute
    {
    }
}