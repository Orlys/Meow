using System;
using System.Collections.Generic;
using System.Text;

namespace Viyrex.Meow.Html.Auxiliaries
{
    /// <summary>
    /// This is an experimental API that should not be used in production code.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Class)]
    public sealed class ExperimentalAttribute : Attribute
    {
    }
}
