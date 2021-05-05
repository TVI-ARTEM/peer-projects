using System;
using System.Drawing;
using System.IO;
using WareHouse.AppResources;
using WareHouse.Exceptions;

namespace WareHouse.Helpers
{
    /// <summary>
    /// Class to convert image. 
    /// </summary>
    public class ImgConverter
    {
        /// <summary>
        /// Convert image to base64 format.
        /// </summary>
        /// <param name="bitmap">Converting image.</param>
        /// <returns>Image in base64.</returns>
        public static string ConvertImgToString(Bitmap bitmap)
        {
            try
            {
                using (var image = (Image) bitmap.Clone())
                {
                    using (var m = new MemoryStream())
                    {
                        image.Save(m, image.RawFormat);
                        var imageBytes = m.ToArray();

                        // Convert byte[] to Base64 String.
                        var base64String = Convert.ToBase64String(imageBytes);
                        return base64String;
                    }
                }
            }
            catch
            {
                throw new ImageConvertException(ApplicationStrings.ImgToStringException);
            }
        }

        /// <summary>
        /// Convert image in base64 format to standard form. 
        /// </summary>
        /// <param name="bitmap">Image in base64.</param>
        /// <returns>Image.</returns>
        public static Bitmap ConvertStringToImg(string bitmap)
        {
            try
            {
                return (Bitmap) Image.FromStream(new MemoryStream(Convert.FromBase64String(bitmap)));
            }
            catch
            {
                throw new ImageConvertException(ApplicationStrings.StringToImgException);
            }
        }
    }
}