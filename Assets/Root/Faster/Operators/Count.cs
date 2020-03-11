using System;
using System.Collections.Generic;


namespace Worldreaver.LinqFaster
{
    public static partial class LightweightLinq
    {
        #region ------------------------------ Arrays ------------------------------

        /// <summary>
        /// Returns a number that represents how many elements in the specified
        /// array satisfy a condition.
        /// </summary>
        /// <param name="source">An array that contains elements to be tested and counted.</param>
        /// <param name="predicate">A function to test each element for a condition.</param>
        /// <returns>A number that represents how many elements in the array satisfy the condition
        /// in the predicate function.</returns>
        public static int CountFast<T>(this T[] source, Func<T, bool> predicate)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (predicate == null)
            {
                throw ArgumentNull("predicate");
            }

            int count = 0;
            for (int i = 0; i < source.Length; i++)
            {
                checked
                {
                    if (predicate(source[i]))
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        #endregion

#if LINQ_SPAN
        #region ------------------------------ Spans ------------------------------

        /// <summary>
        /// Returns a number that represents how many elements in the specified
        /// array satisfy a condition.
        /// </summary>
        /// <param name="source">An array that contains elements to be tested and counted.</param>
        /// <param name="predicate">A function to test each element for a condition.</param>
        /// <returns>A number that represents how many elements in the array satisfy the condition
        /// in the predicate function.</returns>
        public static int CountFast<T>(this Span<T> source, Func<T, bool> predicate)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (predicate == null)
            {
                throw ArgumentNull("predicate");
            }

            int count = 0;
            for (int i = 0; i < source.Length; i++)
            {
                checked
                {
                    if (predicate(source[i]))
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        #endregion
#endif

        #region ------------------------------ Lists ------------------------------

        /// <summary>
        /// Returns a number that represents how many elements in the specified
        /// list satisfy a condition.
        /// </summary>
        /// <param name="source">A list that contains elements to be tested and counted.</param>
        /// <param name="predicate">A function to test each element for a condition.</param>
        /// <returns>A number that represents how many elements in the list satisfy the condition
        /// in the predicate function.</returns>
        public static int CountFast<T>(this List<T> source, Func<T, bool> predicate)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (predicate == null)
            {
                throw ArgumentNull("predicate");
            }

            int count = 0;
            for (int i = 0; i < source.Count; i++)
            {
                checked
                {
                    if (predicate(source[i]))
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        #endregion
    }
}
