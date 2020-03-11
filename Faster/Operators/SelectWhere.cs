﻿using System;
using System.Collections.Generic;



namespace Worldreaver.LinqFaster
{
    public static partial class LightweightLinq
    {
        #region ------------------------------ Arrays ------------------------------

        /// <summary>
        /// Combines Select and Where into a single call for optimal
        /// performance.
        /// </summary>
        /// <param name="source">The input sequence to filter and select</param>
        /// <param name="selector">The transformation to apply before filtering.</param>
        /// <param name="predicate">The predicate with which to filter result.</param>
        /// <returns>A sequence transformed and then filtered by selector and predicate.</returns>
        public static TResult[] SelectWhereFast<T, TResult>(this T[] source, Func<T, TResult> selector, Func<TResult, bool> predicate)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (predicate == null)
            {
                throw ArgumentNull("predicate");
            }

            var result = new TResult[source.Length];
            int idx = 0;
            for (int i = 0; i < source.Length; i++)
            {
                var s = selector(source[i]);
                if (predicate(s))
                {
                    result[idx] = s;
                    idx++;
                }
            }

            Array.Resize(ref result, idx);
            return result;
        }

        /// <summary>
        /// Combines Select and Where with indexes into a single call for optimal
        /// performance.
        /// </summary>
        /// <param name="source">The input sequence to filter and select</param>
        /// <param name="selector">The transformation with index to apply before filtering.</param>
        /// <param name="predicate">The predicate with index with which to filter result.</param>
        /// <returns>A sequence transformed and then filtered by selector and predicate with indexes.</returns>
        public static TResult[] SelectWhereFast<T, TResult>(this T[] source, Func<T, int, TResult> selector, Func<TResult, int, bool> predicate)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (predicate == null)
            {
                throw ArgumentNull("predicate");
            }

            var result = new TResult[source.Length];
            int idx = 0;
            for (int i = 0; i < source.Length; i++)
            {
                var s = selector(source[i], i);
                if (predicate(s, i))
                {
                    result[idx] = s;
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
        /// Combines Select and Where into a single call for optimal
        /// performance.
        /// </summary>
        /// <param name="source">The input sequence to filter and select</param>
        /// <param name="selector">The transformation to apply before filtering.</param>
        /// <param name="predicate">The predicate with which to filter result.</param>
        /// <returns>A sequence transformed and then filtered by selector and predicate.</returns>
        public static TResult[] SelectWhereFast<T, TResult>(this Span<T> source, Func<T, TResult> selector, Func<TResult, bool> predicate)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (predicate == null)
            {
                throw ArgumentNull("predicate");
            }

            var result = new TResult[source.Length];
            int idx = 0;
            for (int i = 0; i < source.Length; i++)
            {
                var s = selector(source[i]);
                if (predicate(s))
                {
                    result[idx] = s;
                    idx++;
                }
            }

            Array.Resize(ref result, idx);
            return result;
        }

        /// <summary>
        /// Combines Select and Where with indexes into a single call for optimal
        /// performance.
        /// </summary>
        /// <param name="source">The input sequence to filter and select</param>
        /// <param name="selector">The transformation with index to apply before filtering.</param>
        /// <param name="predicate">The predicate with index with which to filter result.</param>
        /// <returns>A sequence transformed and then filtered by selector and predicate with indexes.</returns>
        public static TResult[] SelectWhereFast<T, TResult>(this Span<T> source, Func<T, int, TResult> selector, Func<TResult, int, bool> predicate)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (predicate == null)
            {
                throw ArgumentNull("predicate");
            }

            var result = new TResult[source.Length];
            int idx = 0;
            for (int i = 0; i < source.Length; i++)
            {
                var s = selector(source[i], i);
                if (predicate(s, i))
                {
                    result[idx] = s;
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
        /// Combines Select and Where into a single call for optimal
        /// performance.
        /// </summary>
        /// <param name="source">The input sequence to filter and select</param>
        /// <param name="selector">The transformation to apply before filtering.</param>
        /// <param name="predicate">The predicate with which to filter result.</param>
        /// <returns>A sequence transformed and then filtered by selector and predicate.</returns>
        public static List<TResult> SelectWhereFast<T, TResult>(this List<T> source, Func<T, TResult> selector, Func<TResult, bool> predicate)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (predicate == null)
            {
                throw ArgumentNull("predicate");
            }

            var r = new List<TResult>();
            for (int i = 0; i < source.Count; i++)
            {
                var s = selector(source[i]);
                if (predicate(s)) r.Add(s);
            }

            return r;
        }

        /// <summary>
        /// Combines Select and Where with indexes into a single call for optimal
        /// performance.
        /// </summary>
        /// <param name="source">The input sequence to filter and select</param>
        /// <param name="selector">The transformation with index to apply before filtering.</param>
        /// <param name="predicate">The predicate with index with which to filter result.</param>
        /// <returns>A sequence transformed and then filtered by selector and predicate with indexes.</returns>
        public static List<TResult> SelectWhereFast<T, TResult>(this List<T> source, Func<T, int, TResult> selector, Func<TResult, int, bool> predicate)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (predicate == null)
            {
                throw ArgumentNull("predicate");
            }

            var r = new List<TResult>();
            for (int i = 0; i < source.Count; i++)
            {
                var s = selector(source[i], i);
                if (predicate(s, i)) r.Add(s);
            }

            return r;
        }

        #endregion
    }
}
