// Author: Viyrex(aka Yuyu)
// Contact: mailto:viyrex.aka.yuyu@gmail.com
// Github: https://github.com/0x0001F36D

namespace Meow.Schwarz.Auxiliary
{
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    internal sealed class UnknownException : Exception
    {
        #region Public Constructors

        static UnknownException()
        {
            Instance = new UnknownException();
        }

        #endregion Public Constructors

        #region Private Constructors

        private UnknownException()
        {
        }

        private UnknownException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        #endregion Private Constructors

        #region Public Properties

        public static UnknownException Instance { get; }

        #endregion Public Properties
    }
}