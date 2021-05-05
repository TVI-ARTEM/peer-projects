using System;
using System.Collections;
using WareHouse.Entities;
using WareHouse.Managers;

namespace WareHouse.Helpers
{
    /// <summary>
    /// Class which allow to compare nodes bu products total price.
    /// </summary>
    public class NodePriceSorter : IComparer
    {
        /// <summary>
        /// Compare two nodes.
        /// </summary>
        /// <param name="x">First node.</param>
        /// <param name="y">Second node.</param>
        /// <returns>Result of compare.</returns>
        public int Compare(object x, object y)
        {
            var nodeX = (CustomNode)x;
            var nodeY = (CustomNode)y;
            var nodeSectionX = SectionManager.Get(nodeX.SectionName, nodeX.Path).GetTotalPrice();
            var nodeSectionY = SectionManager.Get(nodeY.SectionName, nodeY.Path).GetTotalPrice();

            if (nodeSectionX > nodeSectionY)
            {
                return 1;
            }

            if (Math.Abs(nodeSectionX - nodeSectionY) < double.Epsilon)
            {
                return string.Compare(nodeX.SectionName, nodeY.SectionName, StringComparison.Ordinal);
            }

            return -1;

        }
    }
}
