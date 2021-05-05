using System;

namespace WareHouse.Exceptions
{
    /// <summary>
    /// Custom exception while converting image. 
    /// </summary>
    public class ImageConvertException : Exception
    {
        public ImageConvertException() { }
        public ImageConvertException(string message) : base(message) { }
    }
}
