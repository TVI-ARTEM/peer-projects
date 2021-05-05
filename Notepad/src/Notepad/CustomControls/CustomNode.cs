using System.IO;
using System.Windows.Forms;

namespace Notepad.CustomControls
{
    public partial class CustomNode : TreeNode
    {
        public string FileSource;
        public string FileName;

        /// <summary>
        /// Custom node for tree view to get file's path.
        /// </summary>
        /// <param name="fileSource">File's path.</param>
        public CustomNode(string fileSource)
        {
            FileSource = fileSource;
            FileName = Path.GetFileName(fileSource);
        }
    }
}