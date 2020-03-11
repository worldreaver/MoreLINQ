using System;
using System.Collections.Generic;


namespace Worldreaver.LinqFaster
{
    public static partial class LightweightLinq
    {
        #region ------------------------------ Arrays ------------------------------

        /// <summary>
        /// Inverts the order of the elements in a sequence.
        /// </summary>
        /// <param name="source">A sequence of values to reverse.</param>
        /// <returns>A sequence whose elements correspond to those of the input sequence in reverse order.</returns>
        public static T[] ReverseFast<T>(this T[] source)
        {
            var result = new T[source.Length];
            int lenLessOne = source.Length - 1;
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = source[lenLessOne - i];
            }

            return result;
        }


        /// <summary>
        /// Inverts the order of the elements in a sequence in place.
        /// </summary>
        /// <param name="source">A sequence of values to reverse.</param>
        public static void ReverseInPlaceFast<T>(this T[] source)
        {
            Array.Reverse(source);
        }

        #endregion

#if LINQ_SPAN
        #region ------------------------------ Spans ------------------------------

        /// <summary>
        /// Inverts the order of the elements in a sequence.
        /// </summary>
        /// <param name="source">A sequence of values to reverse.</param>
        /// <returns>A sequence whose elements correspond to those of the input sequence in reverse order.</returns>
        public static T[] ReverseFast<T>(this Span<T> source)
        {
            var result = new T[source.Length];
            int lenLessOne = source.Length - 1;
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = source[lenLessOne - i];
            }

            return result;
        }

        /// <summary>
        /// Inverts the order of the elements in a sequence in place.
        /// </summary>
        /// <param name="source">A sequence of values to reverse.</param>
        public static void ReverseInPlaceFast<T>(this Span<T> source)
        {
            source.Reverse();
        }

        #endregion
#endif

        #region ------------------------------ Lists ------------------------------

        /// <summary>
        /// Inverts the order of the elements in a sequence.
        /// </summary>
        /// <param name="source">A sequence of values to reverse.</param>
        /// <returns>A sequence whose elements correspond to those of the input sequence in reverse order.</returns>
        public static List<T> ReverseFast<T>(this List<T> source)
        {
            var result = new List<T>(source.Count);
            for (int i = source.Count - 1; i >= 0; i--)
            {
                result.Add(source[i]);
            }

            return result;
        }

        /// <summary>
        /// Inverts the order of the elements in a sequence in place.
        /// </summary>
        /// <param name="source">A sequence of values to reverse.</param>
        public static void ReverseInPlaceFast<T>(this List<T> source)
        {
            source.Reverse();
        }

        #endregion
    }
}
