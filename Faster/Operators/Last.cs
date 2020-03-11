﻿using System;
using System.Collections.Generic;


namespace Worldreaver.LinqFaster
{
    public static partial class LightweightLinq
    {
        #region ------------------------------ Arrays ------------------------------

        /// <summary>
        /// Returns the last element of a sequence.
        /// </summary>
        /// <param name="source">An sequence to return the last element of.</param>
        /// <returns>The value at the last position in the source sequence.</returns>
        public static T LastFast<T>(this T[] source)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Length == 0)
            {
                throw NoElements();
            }

            return source[source.Length - 1];
        }

        /// <summary>
        /// Returns the last element of a sequence that satisfies a specified condition.
        /// </summary>
        /// <param name="source">A sequence to return an element from.</param>
        /// <param name="predicate">A function to test each element for a condition.</param>
        /// <returns></returns>
        public static T LastFast<T>(this T[] source, Predicate<T> predicate)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (predicate == null)
            {
                throw ArgumentNull("predicate");
            }

            var lastIndex = Array.FindLastIndex(source, predicate);

            if (lastIndex == -1)
                throw NoMatch();
            return source[lastIndex];
        }

        /// <summary>
        /// Returns the last element of a sequence, or a default value if the sequence contains no elements.
        /// </summary>
        /// <param name="source">An sequence to return the last element of.</param>
        /// <returns>default value if the source sequence is empty; otherwise,
        /// the last element in the sequence</returns>
        public static T LastOrDefaultFast<T>(this T[] source)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Length == 0)
            {
                return default(T);
            }

            return source[source.Length - 1];
        }

        /// <summary>
        /// Returns the last element of a sequence that satisfies a condition or a default value if no such element is found.
        /// </summary>
        /// <param name="source">A sequence to return the last element of.</param>
        /// <param name="predicate">A function to test each element for a condition.</param>
        /// <returns>default value if the sequence is empty or if no elements pass the test
        /// in the predicate function; otherwise, the last element that passes the test in the
        /// predicate function.</returns>
        public static T LastOrDefaultFast<T>(this T[] source, Predicate<T> predicate)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (predicate == null)
            {
                throw ArgumentNull("predicate");
            }

            var lastIndex = Array.FindLastIndex(source, predicate);

            if (lastIndex == -1)
                return default(T);
            return source[lastIndex];
        }

        #endregion

#if LINQ_SPAN
        #region ------------------------------ Spans ------------------------------

        /// <summary>
        /// Returns the last element of a sequence.
        /// </summary>
        /// <param name="source">An sequence to return the last element of.</param>
        /// <returns>The value at the last position in the source sequence.</returns>
        public static T LastFast<T>(this Span<T> source)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Length == 0)
            {
                throw NoElements();
            }

            return source[source.Length - 1];
        }

        /// <summary>
        /// Returns the last element of a sequence that satisfies a specified condition.
        /// </summary>
        /// <param name="source">A sequence to return an element from.</param>
        /// <param name="predicate">A function to test each element for a condition.</param>
        /// <returns></returns>
        public static T LastFast<T>(this Span<T> source, Predicate<T> predicate)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (predicate == null)
            {
                throw ArgumentNull("predicate");
            }

            for (int i = source.Length - 1; i >= 0; i--)
            {
                if (predicate(source[i])) return source[i];
            }

            throw NoMatch();
        }

        /// <summary>
        /// Returns the last element of a sequence, or a default value if the sequence contains no elements.
        /// </summary>
        /// <param name="source">An sequence to return the last element of.</param>
        /// <returns>default value if the source sequence is empty; otherwise,
        /// the last element in the sequence</returns>
        public static T LastOrDefaultFast<T>(this Span<T> source)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Length == 0)
            {
                return default(T);
            }

            return source[source.Length - 1];
        }

        /// <summary>
        /// Returns the last element of a sequence that satisfies a condition or a default value if no such element is found.
        /// </summary>
        /// <param name="source">A sequence to return the last element of.</param>
        /// <param name="predicate">A function to test each element for a condition.</param>
        /// <returns>default value if the sequence is empty or if no elements pass the test
        /// in the predicate function; otherwise, the last element that passes the test in the
        /// predicate function.</returns>
        public static T LastOrDefaultFast<T>(this Span<T> source, Predicate<T> predicate)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (predicate == null)
            {
                throw ArgumentNull("predicate");
            }

            for (int i = source.Length - 1; i >= 0; i--)
            {
                if (predicate(source[i])) return source[i];
            }


            return default(T);
        }

        #endregion
#endif

        #region ------------------------------ Lists ------------------------------

        /// <summary>
        /// Returns the last element of a sequence.
        /// </summary>
        /// <param name="source">An sequence to return the last element of.</param>
        /// <returns>The value at the last position in the source sequence.</returns>
        public static T LastFast<T>(this List<T> source)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Count == 0)
            {
                throw NoElements();
            }

            return source[source.Count - 1];
        }

        /// <summary>
        /// Returns the last element of a sequence that satisfies a specified condition.
        /// </summary>
        /// <param name="source">A sequence to return an element from.</param>
        /// <param name="predicate">A function to test each element for a condition.</param>
        /// <returns></returns>
        public static T LastFast<T>(this List<T> source, Predicate<T> predicate)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (predicate == null)
            {
                throw ArgumentNull("predicate");
            }

            var lastIndex = source.FindLastIndex(predicate);

            if (lastIndex == -1)
                throw NoMatch();
            return source[lastIndex];
        }

        /// <summary>
        /// Returns the last element of a sequence, or a default value if the sequence contains no elements.
        /// </summary>
        /// <param name="source">An sequence to return the last element of.</param>
        /// <returns>default value if the source sequence is empty; otherwise,
        /// the last element in the sequence</returns>
        public static T LastOrDefaultFast<T>(this List<T> source)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Count == 0)
            {
                return default(T);
            }

            return source[source.Count - 1];
        }

        /// <summary>
        /// Returns the last element of a sequence that satisfies a condition or a default value if no such element is found.
        /// </summary>
        /// <param name="source">A sequence to return the last element of.</param>
        /// <param name="predicate">A function to test each element for a condition.</param>
        /// <returns>default value if the sequence is empty or if no elements pass the test
        /// in the predicate function; otherwise, the last element that passes the test in the
        /// predicate function.</returns>
        public static T LastOrDefaultFast<T>(this List<T> source, Predicate<T> predicate)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (predicate == null)
            {
                throw ArgumentNull("predicate");
            }

            var lastIndex = source.FindLastIndex(predicate);

            if (lastIndex == -1)
                return default(T);
            return source[lastIndex];
        }

        #endregion
    }
}
