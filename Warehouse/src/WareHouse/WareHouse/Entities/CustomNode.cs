using System.Collections.Generic;
using System.Windows.Forms;

namespace WareHouse.Entities
{
    /// <summary>
    /// Custom node which contains data about products.
    /// </summary>
    public class CustomNode : TreeNode
    {
        /// <summary>
        /// Section name.
        /// </summary>
        public string SectionName { get; set; }
        /// <summary>
        /// Section path.
        /// </summary>
        public List<string> Path { get; set; }

        private CustomNode() { }

        public CustomNode(string sectionName, List<string> path)
        {
            Text = sectionName;
            SectionName = sectionName;
            Path = path;

        }


    }
}
