using System;

namespace VegetableWarehouse.Classes.Exceptions
{
    /// <summary>
    /// Class for catch special container's exception.
    /// </summary>
    public class ContainerException : Exception
    {
        /// <summary>
        /// Constructor for creating container exception.
        /// </summary>
        /// <param name="message">Error message.</param>
        public ContainerException(string message) : base(message)
        {
        }
    }
}