using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WareHouse.Helpers
{
    /// <summary>
    /// Class which allow to get nodes from treeView in list.
    /// </summary>
    public class NodeHelper
    {
        /// <summary>
        /// Convert iEnumerable to list.
        /// </summary>
        /// <param name="nodes"></param>
        /// <returns></returns>
        public static List<TreeNode> ToList(TreeNodeCollection nodes)
        {
            return ToIEnumerable(nodes).ToList();
        }

        /// <summary>
        /// Get nodes from treeNodeCollection.
        /// </summary>
        /// <param name="nodes">Nodes.</param>
        /// <returns>Converted nodes.</returns>
        public static IEnumerable<TreeNode> ToIEnumerable(TreeNodeCollection nodes)
        {
            foreach (TreeNode c1 in nodes)
            {
                yield return c1;
                foreach (var c2 in ToIEnumerable(c1.Nodes))
                {
                    yield return c2;
                }
            }
        }
    }
}
