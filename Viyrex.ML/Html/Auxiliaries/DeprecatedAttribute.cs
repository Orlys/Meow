using System;
using System.Collections.Generic;
using System.Text;

namespace Viyrex.ML.Html.Auxiliaries
{
    /// <summary>
    /// This is an experimental API that should not be used in production code.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Class)]
    public sealed class DeprecatedAttribute : Attribute
    {
    }
}
