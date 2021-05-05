using System;

namespace VegetableWarehouse.Classes.Exceptions
{
    /// <summary>
    /// Class for catch special box's exception.
    /// </summary>
    public class BoxException : Exception
    {
        /// <summary>
        /// Constructor for creating box exception.
        /// </summary>
        /// <param name="message">Error message.</param>
        public BoxException(string message) : base(message)
        {
        }
    }
}
