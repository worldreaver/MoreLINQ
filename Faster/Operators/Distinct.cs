﻿using System.Collections.Generic;


namespace Worldreaver.LinqFaster
{
    public static partial class LightweightLinq
    {
        #region ------------------------------ Lists ------------------------------

        /// <summary>
        /// Removes duplicate elements from source, does not maintain order. Elements will be
        /// sorted in ascending order.
        /// </summary>
        /// <param name="source">The list to remove duplicate elements from.</param>
        /// <param name="eqComparer">Optional IEqualityComparer to compare values.</param>
        /// <param name="comparer">Optional IComparer to compare values.</param>
        public static void DistinctInPlaceFast<TSource>(this List<TSource> source, IEqualityComparer<TSource> eqComparer = null, IComparer<TSource> comparer = null)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (comparer == null)
            {
                comparer = Comparer<TSource>.Default;
            }

            if (eqComparer == null)
            {
                eqComparer = EqualityComparer<TSource>.Default;
            }

            source.Sort(comparer);

            TSource oldV = source[0];
            int pos = 1;
            for (int i = 1; i < source.Count; i++)
            {
                var newV = source[i];
                source[pos] = newV;
                if (!eqComparer.Equals(newV, oldV))
                {
                    pos++;
                }

                oldV = newV;
            }

            source.RemoveRange(pos, source.Count - pos);
        }

        #endregion
    }
}
