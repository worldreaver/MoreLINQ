using System;
using System.Collections.Generic;


namespace Worldreaver.LinqFaster
{
    public static partial class LightweightLinq
    {
        #region ------------------------------ Arrays ------------------------------

        /// <summary>
        /// Combined Where and Select for optimal performance.
        /// </summary>
        /// <param name="source">The input sequence to filter then transform.</param>
        /// <param name="predicate">A function to use to filter the sequence.</param>
        /// <param name="selector">A function to transform the filtered elements.</param>
        /// <returns>A sequence of filtered and transformed elements.</returns>
        public static TResult[] WhereSelectFast<T, TResult>(this T[] source, Func<T, bool> predicate, Func<T, TResult> selector)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (predicate == null)
            {
                throw ArgumentNull("predicate");
            }

            if (selector == null)
            {
                throw ArgumentNull("predicate");
            }

            var result = new TResult[source.Length];
            int idx = 0;
            for (int i = 0; i < source.Length; i++)
            {
                if (predicate(source[i]))
                {
                    result[idx] = selector(source[i]);
                    idx++;
                }
            }

            Array.Resize(ref result, idx);
            return result;
        }

        /// <summary>
        /// Combined Where and Select for optimal performance that uses the index in the
        /// predicate and selector.
        /// </summary>
        /// <param name="source">The input sequence to filter then transform.</param>
        /// <param name="predicate">A function to use to filter the sequence.</param>
        /// <param name="selector">A function to transform the filtered elements.</param>
        /// <returns>A sequence of filtered and transformed elements.</returns>
        public static TResult[] WhereSelectFast<T, TResult>(this T[] source, Func<T, int, bool> predicate, Func<T, int, TResult> selector)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (predicate == null)
            {
                throw ArgumentNull("predicate");
            }

            if (selector == null)
            {
                throw ArgumentNull("predicate");
            }

            var result = new TResult[source.Length];
            int idx = 0;
            for (int i = 0; i < source.Length; i++)
            {
                if (predicate(source[i], i))
                {
                    result[idx] = selector(source[i], idx);
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
        /// Combined Where and Select for optimal performance.
        /// </summary>
        /// <param name="source">The input sequence to filter then transform.</param>
        /// <param name="predicate">A function to use to filter the sequence.</param>
        /// <param name="selector">A function to transform the filtered elements.</param>
        /// <returns>A sequence of filtered and transformed elements.</returns>
        public static TResult[] WhereSelectFast<T, TResult>(this Span<T> source, Func<T, bool> predicate, Func<T, TResult> selector)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (predicate == null)
            {
                throw ArgumentNull("predicate");
            }

            if (selector == null)
            {
                throw ArgumentNull("predicate");
            }

            var result = new TResult[source.Length];
            int idx = 0;
            for (int i = 0; i < source.Length; i++)
            {
                if (predicate(source[i]))
                {
                    result[idx] = selector(source[i]);
                    idx++;
                }
            }

            Array.Resize(ref result, idx);
            return result;
        }

        /// <summary>
        /// Combined Where and Select for optimal performance that uses the index in the
        /// predicate and selector.
        /// </summary>
        /// <param name="source">The input sequence to filter then transform.</param>
        /// <param name="predicate">A function to use to filter the sequence.</param>
        /// <param name="selector">A function to transform the filtered elements.</param>
        /// <returns>A sequence of filtered and transformed elements.</returns>
        public static TResult[] WhereSelectFast<T, TResult>(this Span<T> source, Func<T, int, bool> predicate, Func<T, int, TResult> selector)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (predicate == null)
            {
                throw ArgumentNull("predicate");
            }

            if (selector == null)
            {
                throw ArgumentNull("predicate");
            }

            var result = new TResult[source.Length];
            int idx = 0;
            for (int i = 0; i < source.Length; i++)
            {
                if (predicate(source[i], i))
                {
                    result[idx] = selector(source[i], idx);
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
        /// Combined Where and Select for optimal performance.
        /// </summary>
        /// <param name="source">The input sequence to filter then transform.</param>
        /// <param name="predicate">A function to use to filter the sequence.</param>
        /// <param name="selector">A function to transform the filtered elements.</param>
        /// <returns>A sequence of filtered and transformed elements.</returns>
        public static List<TResult> WhereSelectFast<T, TResult>(this List<T> source, Func<T, bool> predicate, Func<T, TResult> selector)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (predicate == null)
            {
                throw ArgumentNull("predicate");
            }

            if (selector == null)
            {
                throw ArgumentNull("predicate");
            }

            var r = new List<TResult>();
            for (int i = 0; i < source.Count; i++)
            {
                if (predicate(source[i])) r.Add(selector(source[i]));
            }

            return r;
        }

        /// <summary>
        /// Combined Where and Select for optimal performance that uses the index in the
        /// predicate and selector.
        /// </summary>
        /// <param name="source">The input sequence to filter then transform.</param>
        /// <param name="predicate">A function to use to filter the sequence.</param>
        /// <param name="selector">A function to transform the filtered elements.</param>
        /// <returns>A sequence of filtered and transformed elements.</returns>
        public static List<TResult> WhereSelectFast<T, TResult>(this List<T> source, Func<T, int, bool> predicate, Func<T, int, TResult> selector)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (predicate == null)
            {
                throw ArgumentNull("predicate");
            }

            if (selector == null)
            {
                throw ArgumentNull("predicate");
            }

            var r = new List<TResult>();
            int idx = 0;
            for (int i = 0; i < source.Count; i++)
            {
                if (predicate(source[i], i))
                {
                    r.Add(selector(source[i], idx));
                    idx++;
                }
            }


            return r;
        }

        #endregion
    }
}
