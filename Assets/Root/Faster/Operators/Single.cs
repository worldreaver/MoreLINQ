﻿using System;
using System.Collections.Generic;


namespace Worldreaver.LinqFaster
{
    public static partial class LightweightLinq
    {
        #region ------------------------------ Arrays ------------------------------

        /// <summary>
        /// Returns the only element of a sequence, and throws an exception if there is not exactly one element in the sequence.
        /// </summary>
        /// <param name="source">A sequence to return the single element of</param>
        /// <returns>The single element of the input sequence or default if no elements exist.</returns>
        public static T SingleFast<T>(this T[] source)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Length == 0)
            {
                throw NoElements();
            }

            if (source.Length > 1)
            {
                throw MoreThanOneElement();
            }

            return source[0];
        }

        /// <summary>
        /// Returns the only element of a sequence, or the default if no elements exist, and throws an exception if there is not exactly one element in the sequence.
        /// </summary>
        /// <param name="source">A sequence to return the single element of</param>
        /// <returns>The single element of the input sequence</returns>
        public static T SingleOrDefaultFast<T>(this T[] source)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Length == 0)
            {
                return default(T);
            }

            if (source.Length > 1)
            {
                throw MoreThanOneElement();
            }

            return source[0];
        }

        /// <summary>
        /// Returns the only element of a sequence that satisfies a specified condition, and throws an exception if more than one such element exists.
        /// </summary>
        /// <param name="source">A sequence to return a single element from.</param>
        /// <param name="predicate">A function to test an element for a condition.</param>
        /// <returns>The single element of the input sequence that satisfies a condition.</returns>
        public static T SingleFast<T>(this T[] source, Func<T, bool> predicate)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (predicate == null)
            {
                throw ArgumentNull("predicate");
            }

            T result = default(T);
            bool foundMatch = false;
            for (int i = 0; i < source.Length; i++)
            {
                if (predicate(source[i]))
                {
                    if (foundMatch)
                    {
                        throw MoreThanOneMatch();
                    }

                    result = source[i];
                    foundMatch = true;
                }
            }

            if (foundMatch)
            {
                return result;
            }

            throw NoMatch();
        }

        /// <summary>
        /// Returns the only element of a sequence that satisfies a specified condition, or a default value if
        /// no such element exists, and throws an exception if more than one such element exists.
        /// </summary>
        /// <param name="source">A sequence to return a single element from.</param>
        /// <param name="predicate">A function to test an element for a condition.</param>
        /// <returns>The single element of the input sequence that satisfies a condition or default value if no such element is found.</returns>
        public static T SingleOrDefaultFast<T>(this T[] source, Func<T, bool> predicate)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (predicate == null)
            {
                throw ArgumentNull("predicate");
            }


            T result = default(T);
            bool foundMatch = false;
            for (int i = 0; i < source.Length; i++)
            {
                if (predicate(source[i]))
                {
                    if (foundMatch)
                    {
                        throw MoreThanOneMatch();
                    }

                    result = source[i];
                    foundMatch = true;
                }
            }

            return result;
        }

        #endregion

#if LINQ_SPAN
        #region ------------------------------ Spans ------------------------------

        /// <summary>
        /// Returns the only element of a sequence, and throws an exception if there is not exactly one element in the sequence.
        /// </summary>
        /// <param name="source">A sequence to return the single element of</param>
        /// <returns>The single element of the input sequence or default if no elements exist.</returns>
        public static T SingleFast<T>(this Span<T> source)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Length == 0)
            {
                throw NoElements();
            }

            if (source.Length > 1)
            {
                throw MoreThanOneElement();
            }

            return source[0];
        }

        /// <summary>
        /// Returns the only element of a sequence, or the default if no elements exist, and throws an exception if there is not exactly one element in the sequence.
        /// </summary>
        /// <param name="source">A sequence to return the single element of</param>
        /// <returns>The single element of the input sequence</returns>
        public static T SingleOrDefaultFast<T>(this Span<T> source)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Length == 0)
            {
                return default(T);
            }

            if (source.Length > 1)
            {
                throw MoreThanOneElement();
            }

            return source[0];
        }

        /// <summary>
        /// Returns the only element of a sequence that satisfies a specified condition, and throws an exception if more than one such element exists.
        /// </summary>
        /// <param name="source">A sequence to return a single element from.</param>
        /// <param name="predicate">A function to test an element for a condition.</param>
        /// <returns>The single element of the input sequence that satisfies a condition.</returns>
        public static T SingleFast<T>(this Span<T> source, Func<T, bool> predicate)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (predicate == null)
            {
                throw ArgumentNull("predicate");
            }

            T result = default(T);
            bool foundMatch = false;
            for (int i = 0; i < source.Length; i++)
            {
                if (predicate(source[i]))
                {
                    if (foundMatch)
                    {
                        throw MoreThanOneMatch();
                    }

                    result = source[i];
                    foundMatch = true;
                }
            }

            if (foundMatch)
            {
                return result;
            }

            throw NoMatch();
        }

        /// <summary>
        /// Returns the only element of a sequence that satisfies a specified condition, or a default value if
        /// no such element exists, and throws an exception if more than one such element exists.
        /// </summary>
        /// <param name="source">A sequence to return a single element from.</param>
        /// <param name="predicate">A function to test an element for a condition.</param>
        /// <returns>The single element of the input sequence that satisfies a condition or default value if no such element is found.</returns>
        public static T SingleOrDefaultFast<T>(this Span<T> source, Func<T, bool> predicate)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (predicate == null)
            {
                throw ArgumentNull("predicate");
            }


            T result = default(T);
            bool foundMatch = false;
            for (int i = 0; i < source.Length; i++)
            {
                if (predicate(source[i]))
                {
                    if (foundMatch)
                    {
                        throw MoreThanOneMatch();
                    }

                    result = source[i];
                    foundMatch = true;
                }
            }

            return result;
        }

        #endregion
#endif

        #region ------------------------------ Lists ------------------------------

        /// <summary>
        /// Returns the only element of a sequence, and throws an exception if there is not exactly one element in the sequence.
        /// </summary>
        /// <param name="source">A sequence to return the single element of</param>
        /// <returns>The single element of the input sequence</returns>
        public static T SingleFast<T>(this List<T> source)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Count == 0)
            {
                throw NoElements();
            }

            if (source.Count > 1)
            {
                throw MoreThanOneElement();
            }

            return source[0];
        }

        /// <summary>
        /// Returns the only element of a sequence, or default if no elements exist, and throws an exception if there is not exactly one element in the sequence.
        /// </summary>
        /// <param name="source">A sequence to return the single element of</param>
        /// <returns>The single element of the input sequence or default if no elements exist.</returns>
        public static T SingleOrDefaultFast<T>(this List<T> source)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Count == 0)
            {
                return default(T);
            }

            if (source.Count > 1)
            {
                throw MoreThanOneElement();
            }

            return source[0];
        }

        /// <summary>
        /// Returns the only element of a sequence that satisfies a specified condition, and throws an exception if more than one such element exists.
        /// </summary>
        /// <param name="source">A sequence to return a single element from.</param>
        /// <param name="predicate">A function to test an element for a condition.</param>
        /// <returns>The single element of the input sequence that satisfies a condition.</returns>
        public static T SingleFast<T>(this List<T> source, Func<T, bool> predicate)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (predicate == null)
            {
                throw ArgumentNull("predicate");
            }

            T result = default(T);
            bool foundMatch = false;
            for (int i = 0; i < source.Count; i++)
            {
                if (predicate(source[i]))
                {
                    if (foundMatch)
                    {
                        throw MoreThanOneMatch();
                    }

                    result = source[i];
                    foundMatch = true;
                }
            }

            if (foundMatch)
            {
                return result;
            }
            else
            {
                throw NoMatch();
            }
        }

        /// <summary>
        /// Returns the only element of a sequence that satisfies a specified condition, or a default value if
        /// no such element exists, and throws an exception if more than one such element exists.
        /// </summary>
        /// <param name="source">A sequence to return a single element from.</param>
        /// <param name="predicate">A function to test an element for a condition.</param>
        /// <returns>The single element of the input sequence that satisfies a condition or default value if no such element is found.</returns>
        public static T SingleOrDefaultFast<T>(this List<T> source, Func<T, bool> predicate)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (predicate == null)
            {
                throw ArgumentNull("predicate");
            }

            T result = default(T);
            bool foundMatch = false;
            for (int i = 0; i < source.Count; i++)
            {
                if (predicate(source[i]))
                {
                    if (foundMatch)
                    {
                        throw MoreThanOneMatch();
                    }

                    result = source[i];
                    foundMatch = true;
                }
            }

            return result;
        }

        #endregion
    }
}
