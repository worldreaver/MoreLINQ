using System;
using System.Collections.Generic;


namespace Worldreaver.LinqFaster
{
    public static partial class LightweightLinq
    {
        #region ------------------------------ Arrays ------------------------------

        /// <summary>
        /// Determines whether an array contains any elements
        /// </summary>
        /// <param name="source">The array to check for emptiness</param>
        /// <returns>true if the source array contains any elements, otherwise, false/</returns>
        public static bool AnyFast<T>(this T[] source)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            return source.Length > 0;
        }


        /// <summary>
        /// Determines whether any element of an array satisfies a condition.
        /// </summary>
        /// <param name="source">An array whose elements to apply the predicate to.</param>
        /// <param name="predicate">A function to test each element for a condition.</param>
        /// <returns>true if any elements in the source array pass the test in the specified predicate; otherwise, false.</returns>
        public static bool AnyFast<TSource>(this TSource[] source, Predicate<TSource> predicate)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (predicate == null)
            {
                throw ArgumentNull("predicate");
            }

            return Array.Exists(source, predicate);
        }


        /// <summary>
        /// Determines whether all elements of an array satisfy a condition.
        /// </summary>
        /// <param name="source">An array that contains the elements to apply the predicate to.</param>
        /// <param name="predicate">A function to test each element for a condition.</param>
        /// <returns>true if every element of the source array passes the test in the specified
        /// predicate, or if the array is empty; otherwise, false</returns>
        public static bool AllFast<TSource>(this TSource[] source, Predicate<TSource> predicate)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (predicate == null)
            {
                throw ArgumentNull("predicate");
            }

            return Array.TrueForAll(source, predicate);
        }

        #endregion

#if LINQ_SPAN
        #region ------------------------------ Spans ------------------------------

        /// <summary>
        /// Determines whether an array contains any elements
        /// </summary>
        /// <param name="source">The array to check for emptiness</param>
        /// <returns>true if the source array contains any elements, otherwise, false/</returns>
        public static bool AnyFast<T>(this Span<T> source)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            return source.Length > 0;
        }


        /// <summary>
        /// Determines whether any element of an array satisfies a condition.
        /// </summary>
        /// <param name="source">An array whose elements to apply the predicate to.</param>
        /// <param name="predicate">A function to test each element for a condition.</param>
        /// <returns>true if any elements in the source array pass the test in the specified predicate; otherwise, false.</returns>
        public static bool AnyFast<TSource>(this Span<TSource> source, Predicate<TSource> predicate)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (predicate == null)
            {
                throw ArgumentNull("predicate");
            }

            for (int i = 0; i < source.Length; i++)
            {
                if (predicate(source[i])) return true;
            }

            return false;
        }


        /// <summary>
        /// Determines whether all elements of an array satisfy a condition.
        /// </summary>
        /// <param name="source">An array that contains the elements to apply the predicate to.</param>
        /// <param name="predicate">A function to test each element for a condition.</param>
        /// <returns>true if every element of the source array passes the test in the specified
        /// predicate, or if the array is empty; otherwise, false</returns>
        public static bool AllFast<TSource>(this Span<TSource> source, Predicate<TSource> predicate)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (predicate == null)
            {
                throw ArgumentNull("predicate");
            }

            for (int i = 0; i < source.Length; i++)
            {
                if (!predicate(source[i])) return false;
            }

            return true;
        }

        #endregion
#endif

        #region ------------------------------ Lists ------------------------------

        /// <summary>
        /// Determines whether a list contains any elements
        /// </summary>
        /// <param name="source">The list to check for emptiness</param>
        /// <returns>true if the source list contains any elements, otherwise, false/</returns>
        public static bool AnyFast<T>(this List<T> source)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            return source.Count > 0;
        }

        /// <summary>
        /// Determines whether any element of an array satisfies a condition.
        /// </summary>
        /// <param name="source">An array whose elements to apply the predicate to.</param>
        /// <param name="predicate">A function to test each element for a condition.</param>
        /// <returns>true if any elements in the source array pass the test in the specified predicate; otherwise, false.</returns>
        public static bool AnyFast<TSource>(this List<TSource> source, Predicate<TSource> predicate)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (predicate == null)
            {
                throw ArgumentNull("predicate");
            }

            return source.Exists(predicate);
        }

        /// <summary>
        /// Determines whether all elements of a list satisfy a condition.
        /// </summary>
        /// <param name="source">A list that contains the elements to apply the predicate to.</param>
        /// <param name="predicate">A function to test each element for a condition.</param>
        /// <returns>true if every element of the source array passes the test in the specified
        /// predicate, or if the list is empty; otherwise, false</returns>
        public static bool AllFast<TSource>(this List<TSource> source, Predicate<TSource> predicate)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (predicate == null)
            {
                throw ArgumentNull("predicate");
            }

            return source.TrueForAll(predicate);
        }

        #endregion
    }
}
