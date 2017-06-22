using System;

namespace Viyrex.ML.Html.Auxiliaries
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Class)]
    sealed class NotStandardizedAttribute : Attribute
    {
    }
}