namespace Meow.Html.Auxiliaries
{
    using System;

    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Class)]
    internal sealed class NotStandardizedAttribute : Attribute
    {
    }
}