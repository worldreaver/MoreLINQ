﻿using System;
using System.Collections.Generic;


namespace Worldreaver.LinqFaster
{
    public static partial class LightweightLinq
    {
        #region ------------------------------ Arrays ------------------------------

        /// <summary>
        /// Projects each element of a sequence to another sequence and flattens the resulting sequences into one sequence.
        /// Yo dawg, I heard you like sequences.
        /// </summary>
        /// <param name="source">A sequence of values to project.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>A sequence whose elements are the result of invoking the one-to-many transform function on each element of the input sequence.</returns>
        public static TResult[] SelectManyFast<TSource, TResult>(this TSource[] source, Func<TSource, TResult[]> selector)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (selector == null)
            {
                throw ArgumentNull("selector");
            }

            var result = new List<TResult>(source.Length);
            for (int i = 0; i < source.Length; i++)
            {
                var va = selector(source[i]);
                for (int j = 0; j < va.Length; j++)
                {
                    result.Add(va[j]);
                }
            }

            return result.ToArray();
        }

        /// <summary>
        /// Projects each element of a sequence to another sequence and flattens the resulting sequences into one sequence
        /// utilizing the index of each element.
        /// </summary>
        /// <param name="source">A sequence of values to project.</param>
        /// <param name="selector">A transform function to apply to each element and it's index.</param>
        /// <returns>A sequence whose elements are the result of invoking the one-to-many transform function on each element and index of the input sequence.</returns>
        public static TResult[] SelectManyFast<TSource, TResult>(this TSource[] source, Func<TSource, int, TResult[]> selector)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (selector == null)
            {
                throw ArgumentNull("selector");
            }

            var result = new List<TResult>(source.Length);
            for (int i = 0; i < source.Length; i++)
            {
                var va = selector(source[i], i);
                for (int j = 0; j < va.Length; j++)
                {
                    result.Add(va[j]);
                }
            }

            return result.ToArray();
        }

        #endregion

#if LINQ_SPAN
        #region ------------------------------ Spans ------------------------------

        /// <summary>
        /// Projects each element of a sequence to another sequence and flattens the resulting sequences into one sequence.
        /// Yo dawg, I heard you like sequences.
        /// </summary>
        /// <param name="source">A sequence of values to project.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>A sequence whose elements are the result of invoking the one-to-many transform function on each element of the input sequence.</returns>
        public static TResult[] SelectManyFast<TSource, TResult>(this Span<TSource> source, Func<TSource, TResult[]> selector)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (selector == null)
            {
                throw ArgumentNull("selector");
            }

            var result = new List<TResult>(source.Length);
            for (int i = 0; i < source.Length; i++)
            {
                var va = selector(source[i]);
                for (int j = 0; j < va.Length; j++)
                {
                    result.Add(va[j]);
                }
            }

            return result.ToArray();
        }

        /// <summary>
        /// Projects each element of a sequence to another sequence and flattens the resulting sequences into one sequence
        /// utilizing the index of each element.
        /// </summary>
        /// <param name="source">A sequence of values to project.</param>
        /// <param name="selector">A transform function to apply to each element and it's index.</param>
        /// <returns>A sequence whose elements are the result of invoking the one-to-many transform function on each element and index of the input sequence.</returns>
        public static TResult[] SelectManyFast<TSource, TResult>(this Span<TSource> source, Func<TSource, int, TResult[]> selector)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (selector == null)
            {
                throw ArgumentNull("selector");
            }

            var result = new List<TResult>(source.Length);
            for (int i = 0; i < source.Length; i++)
            {
                var va = selector(source[i], i);
                for (int j = 0; j < va.Length; j++)
                {
                    result.Add(va[j]);
                }
            }

            return result.ToArray();
        }

        #endregion
#endif

        #region ------------------------------ Lists ------------------------------

        /// <summary>
        /// Projects each element of a sequence to another sequence and flattens the resulting sequences into one sequence.
        /// Yo dawg, I heard you like sequences.
        /// </summary>
        /// <param name="source">A sequence of values to project.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>A sequence whose elements are the result of invoking the one-to-many transform function on each element of the input sequence.</returns>
        public static List<TResult> SelectManyFast<TSource, TResult>(this List<TSource> source, Func<TSource, List<TResult>> selector)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (selector == null)
            {
                throw ArgumentNull("selector");
            }

            var result = new List<TResult>(source.Count);
            for (int i = 0; i < source.Count; i++)
            {
                var va = selector(source[i]);
                for (int j = 0; j < va.Count; j++)
                {
                    result.Add(va[j]);
                }
            }

            return result;
        }

        /// <summary>
        /// Projects each element of a sequence to another sequence and flattens the resulting sequences into one sequence
        /// utilizing the index of each element.
        /// </summary>
        /// <param name="source">A sequence of values to project.</param>
        /// <param name="selector">A transform function to apply to each element and it's index.</param>
        /// <returns>A sequence whose elements are the result of invoking the one-to-many transform function on each element and index of the input sequence.</returns>
        public static List<TResult> SelectManyFast<TSource, TResult>(this List<TSource> source, Func<TSource, int, List<TResult>> selector)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (selector == null)
            {
                throw ArgumentNull("selector");
            }

            var result = new List<TResult>(source.Count);
            for (int i = 0; i < source.Count; i++)
            {
                var va = selector(source[i], i);
                for (int j = 0; j < va.Count; j++)
                {
                    result.Add(va[j]);
                }
            }

            return result;
        }

        #endregion
    }
}
