using System;
using System.Collections.Generic;
using System.Linq;

namespace WareHouse.Helpers
{

    public static class Extensions
    {
        /// <summary>
        /// Clone list.
        /// </summary>
        /// <typeparam name="T">type of collection.</typeparam>
        /// <param name="source">Collection to copy.</param>
        /// <returns>Cloned list.</returns>
        public static IList<T> Clone<T>(this IList<T> source) where T : ICloneable
            => source.Select(item => (T)item.Clone()).ToList();
    }
}
