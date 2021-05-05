using System;

namespace VegetableWarehouse.Classes.Exceptions
{
    /// <summary>
    /// Constructor for catch special warehouse's exception.
    /// </summary>
    public class WarehouseException : Exception
    {
        /// <summary>
        /// Constructor for creating warehouse exception.
        /// </summary>
        /// <param name="message">Error message.</param>
        public WarehouseException(string message) : base(message)
        {
        }
    }
}
