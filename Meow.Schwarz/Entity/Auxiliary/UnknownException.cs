
namespace Meow.Schwarz.Entity.Auxiliary
{
    using System;
    using System.Reflection;
    using System.Runtime.InteropServices;
    using System.Runtime.Serialization;

    [Serializable]
    internal sealed class UnknownException : Exception
    {
        static UnknownException()
        {
            Instance = new UnknownException();
        }
        public static UnknownException Instance { get; }

        private UnknownException()
        {
        }

        private UnknownException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}