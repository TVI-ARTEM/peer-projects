using System;

namespace WareHouse.Exceptions
{
    /// <summary>
    /// Custom exception.
    /// </summary>
    public class CustomDataException : Exception
    {
        /// <summary>
        /// Code exception define by user.
        /// </summary>
        public uint CodeException { get; set; }

        public CustomDataException()
        {
        }

        public CustomDataException(string message) : base(message)
        {
        }

        public CustomDataException(string message, uint codeException) : base(message)
        {
            CodeException = codeException;
        }
    }
}