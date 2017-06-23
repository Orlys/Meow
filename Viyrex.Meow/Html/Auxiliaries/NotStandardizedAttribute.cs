using System;

namespace Viyrex.Meow.Html.Auxiliaries
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Class)]
    sealed class NotStandardizedAttribute : Attribute
    {
    }
}