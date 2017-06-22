using System;
using System.Collections.Generic;
using System.Text;

namespace Viyrex.ML.Html.Elements
{
    public enum ElementType
    {
        Normal = 0,
        Empty = 1,
        RequireOpeningTag = 2,
        Special = 3,
        Customize = 4
    }
}
