using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Notepad.CustomControls
{
    public partial class CustomRichTextBox : RichTextBox
    {
        public string FileSource;
        public string FileName;
        public string FileExtension;

        public DateTime TimeCreation;
        public DateTime TimeLastChange;

        public bool IsSaved;

        /// <summary>
        /// Custom RichTextBox to get file's data.
        /// </summary>
        /// <param name="fileSource">File's path.</param>
        /// <param name="isNew">Define if it's a new file.</param>
        public CustomRichTextBox(string fileSource, bool isNew)
        {
            // Set file's settings.
            if (isNew)
            {
                FileSource = string.Empty;
                FileName = Path.GetFileNameWithoutExtension(fileSource);
                FileExtension = Path.GetExtension(fileSource);


                TimeCreation = DateTime.Now;
                TimeLastChange = DateTime.Now;

                IsSaved = false;
            }
            else
            {
                FileSource = fileSource;
                FileName = Path.GetFileNameWithoutExtension(FileSource);
                FileExtension = Path.GetExtension(FileSource);

                TimeCreation = new FileInfo(fileSource).CreationTimeUtc;
                TimeLastChange = DateTime.Now;

                IsSaved = true;
            }
        }

        /// <summary>
        /// Get time last changed in certain format.
        /// </summary>
        public string GetTimeLastChanged => TimeLastChange.ToString("ddMMyyyyTHHmmss");
    }
}