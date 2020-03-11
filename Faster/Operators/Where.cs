using System;
using System.Collections.Generic;


namespace Worldreaver.LinqFaster
{
    public static partial class LightweightLinq
    {
        #region ------------------------------ Arrays ------------------------------

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="source">A sequence to filter.</param>
        /// <param name="predicate">A function to test each element for a condition.</param>
        /// <returns>A sequence that contains elements from the input sequence that satisfy the condition.</returns>
        public static T[] WhereFast<T>(this T[] source, Func<T, bool> predicate)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (predicate == null)
            {
                throw ArgumentNull("predicate");
            }

            T[] result = new T[source.Length];
            int idx = 0;
            for (int i = 0; i < source.Length; i++)
            {
                if (predicate(source[i]))
                {
                    result[idx] = source[i];
                    idx++;
                }
            }

            Array.Resize(ref result, idx);
            return result;
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate that includes the index in it's logic.
        /// </summary>
        /// <param name="source">A sequence to filter.</param>
        /// <param name="predicate">A function to test each element for a condition along with the element's index.</param>
        /// <returns>A sequence that contains elements from the input sequence that satisfy the condition.</returns>
        public static T[] WhereFast<T>(this T[] source, Func<T, int, bool> predicate)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (predicate == null)
            {
                throw ArgumentNull("predicate");
            }


            T[] result = new T[source.Length];
            int idx = 0;
            for (int i = 0; i < source.Length; i++)
            {
                if (predicate(source[i], i))
                {
                    result[idx] = source[i];
                    idx++;
                }
            }

            Array.Resize(ref result, idx);
            return result;
        }

        #endregion

#if LINQ_SPAN
        #region ------------------------------ Spans ------------------------------

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="source">A sequence to filter.</param>
        /// <param name="predicate">A function to test each element for a condition.</param>
        /// <returns>A sequence that contains elements from the input sequence that satisfy the condition.</returns>
        public static T[] WhereFast<T>(this Span<T> source, Func<T, bool> predicate)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (predicate == null)
            {
                throw ArgumentNull("predicate");
            }

            T[] result = new T[source.Length];
            int idx = 0;
            for (int i = 0; i < source.Length; i++)
            {
                if (predicate(source[i]))
                {
                    result[idx] = source[i];
                    idx++;
                }
            }

            Array.Resize(ref result, idx);
            return result;
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate that includes the index in it's logic.
        /// </summary>
        /// <param name="source">A sequence to filter.</param>
        /// <param name="predicate">A function to test each element for a condition along with the element's index.</param>
        /// <returns>A sequence that contains elements from the input sequence that satisfy the condition.</returns>
        public static T[] WhereFast<T>(this Span<T> source, Func<T, int, bool> predicate)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (predicate == null)
            {
                throw ArgumentNull("predicate");
            }


            T[] result = new T[source.Length];
            int idx = 0;
            for (int i = 0; i < source.Length; i++)
            {
                if (predicate(source[i], i))
                {
                    result[idx] = source[i];
                    idx++;
                }
            }

            Array.Resize(ref result, idx);
            return result;
        }

        #endregion
#endif

        #region ------------------------------ Lists ------------------------------

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="source">A sequence to filter.</param>
        /// <param name="predicate">A function to test each element for a condition.</param>
        /// <returns>A sequence that contains elements from the input sequence that satisfy the condition.</returns>
        public static List<T> WhereFast<T>(this List<T> source, Predicate<T> predicate)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (predicate == null)
            {
                throw ArgumentNull("predicate");
            }

            return source.FindAll(predicate);
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate that includes the index in it's logic.
        /// </summary>
        /// <param name="source">A sequence to filter.</param>
        /// <param name="predicate">A function to test each element for a condition along with the element's index.</param>
        /// <returns>A sequence that contains elements from the input sequence that satisfy the condition.</returns>
        public static List<T> WhereFast<T>(this List<T> source, Func<T, int, bool> predicate)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (predicate == null)
            {
                throw ArgumentNull("predicate");
            }

            List<T> r = new List<T>();
            for (int i = 0; i < source.Count; i++)
            {
                if (predicate(source[i], i)) r.Add(source[i]);
            }

            return r;
        }

        #endregion
    }
}
