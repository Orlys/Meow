// Author: Viyrex(aka Yuyu)
// Contact: mailto:viyrex.aka.yuyu@gmail.com
// Github: https://github.com/0x0001F36D
namespace Meow.Schwarz.Auxiliary
{
    using System;

    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Class)]
    internal sealed class NotStandardizedAttribute : Attribute
    {
    }
}