using System;

namespace ChatAPI.Exceptions
{
    /// <summary>
    /// Custom exception.
    /// </summary>
    public class CustomException : Exception
    {
        public CustomException(string message) : base(message)
        {
        }
    }
}
