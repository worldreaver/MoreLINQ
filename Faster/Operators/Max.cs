using System;
using System.Collections.Generic;


namespace Worldreaver.LinqFaster
{
    //int, long, float,double, decimal
    public static partial class LightweightLinq
    {
        #region ------------------------------ Arrays ------------------------------

        /// <summary>
        /// Returns the maximum value in a sequence of values.
        /// </summary>
        /// <param name="source">A sequence of values to determine the maximum of.</param>
        /// <returns>The maximum value in the sequence</returns>
        public static T MaxFast<T>(this T[] source)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Length == 0)
            {
                throw NoElements();
            }

            Comparer<T> comparer = Comparer<T>.Default;
            T r = default(T);
            if (r == null)
            {
                r = source[0];
                for (int i = 1; i < source.Length; i++)
                {
                    if (source[i] != null && comparer.Compare(source[i], r) > 0) r = source[i];
                }
            }
            else
            {
                r = source[0];
                for (int i = 1; i < source.Length; i++)
                {
                    if (comparer.Compare(source[i], r) > 0) r = source[i];
                }
            }

            return r;
        }

        /// <summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum value.
        /// </summary>
        /// <param name="source">A sequence of values to determine the maximum value of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The maximum value in the transform of the sequence.</returns>
        public static TResult MaxFast<T, TResult>(this T[] source, Func<T, TResult> selector)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (selector == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Length == 0)
            {
                throw NoElements();
            }

            Comparer<TResult> comparer = Comparer<TResult>.Default;
            TResult r = default(TResult);
            if (r == null)
            {
                r = selector(source[0]);
                for (int i = 1; i < source.Length; i++)
                {
                    var v = selector(source[i]);
                    if (v != null && comparer.Compare(v, r) > 0) r = v;
                }
            }
            else
            {
                r = selector(source[0]);
                for (int i = 1; i < source.Length; i++)
                {
                    var v = selector(source[i]);
                    if (comparer.Compare(v, r) > 0) r = v;
                }
            }

            return r;
        }

        /// <summary>
        /// Returns the maximum value in a sequence of values.
        /// </summary>
        /// <param name="source">A sequence of values to determine the maximum of.</param>
        /// <returns>The maximum value in the sequence</returns>
        public static int MaxFast(this int[] source)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Length == 0)
            {
                throw NoElements();
            }

            int r = int.MinValue;
            for (int i = 0; i < source.Length; i++)
            {
                if (source[i] > r) r = source[i];
            }

            return r;
        }

        /// <summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum value.
        /// </summary>
        /// <param name="source">A sequence of values to determine the maximum value of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The maximum value in the transform of the sequence.</returns>
        public static int MaxFast<T>(this T[] source, Func<T, int> selector)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Length == 0)
            {
                throw NoElements();
            }

            if (selector == null)
            {
                throw ArgumentNull("selector");
            }

            int r = int.MinValue;
            for (int i = 0; i < source.Length; i++)
            {
                var v = selector(source[i]);
                if (v > r) r = v;
            }

            return r;
        }

        /// <summary>
        /// Returns the maximum value in a sequence of values.
        /// </summary>
        /// <param name="source">A sequence of values to determine the maximum of.</param>
        /// <returns>The maximum value in the sequence</returns>
        public static long MaxFast(this long[] source)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Length == 0)
            {
                throw NoElements();
            }

            long r = long.MinValue;
            for (int i = 0; i < source.Length; i++)
            {
                if (source[i] > r) r = source[i];
            }

            return r;
        }

        /// <summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum value.
        /// </summary>
        /// <param name="source">A sequence of values to determine the maximum value of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The maximum value in the transform of the sequence.</returns>
        public static long MaxFast<T>(this T[] source, Func<T, long> selector)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Length == 0)
            {
                throw NoElements();
            }

            if (selector == null)
            {
                throw ArgumentNull("selector");
            }

            long r = long.MinValue;
            for (int i = 0; i < source.Length; i++)
            {
                var v = selector(source[i]);
                if (v > r) r = v;
            }

            return r;
        }

        /// <summary>
        /// Returns the maximum value in a sequence of values.
        /// </summary>
        /// <param name="source">A sequence of values to determine the maximum of.</param>
        /// <returns>The maximum value in the sequence</returns>
        public static float MaxFast(this float[] source)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Length == 0)
            {
                throw NoElements();
            }

            float r = source[0];
            int startIndex = 0;
            for (; startIndex < source.Length; startIndex++)
            {
                if (!float.IsNaN(source[startIndex]))
                {
                    r = source[startIndex];
                    break;
                }
            }

            for (int i = startIndex; i < source.Length; i++)
            {
                if (source[i] > r) r = source[i];
            }

            return r;
        }

        /// <summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum value.
        /// </summary>
        /// <param name="source">A sequence of values to determine the maximum value of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The maximum value in the transform of the sequence.</returns>
        public static float MaxFast<T>(this T[] source, Func<T, float> selector)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Length == 0)
            {
                throw NoElements();
            }

            if (selector == null)
            {
                throw ArgumentNull("selector");
            }

            float r = selector(source[0]);
            int startIndex = 0;
            for (; startIndex < source.Length; startIndex++)
            {
                var v = selector(source[startIndex]);
                if (!float.IsNaN(v))
                {
                    r = v;
                    break;
                }
            }

            for (int i = startIndex; i < source.Length; i++)
            {
                var v = selector(source[i]);
                if (v > r) r = v;
            }

            return r;
        }

        /// <summary>
        /// Returns the maximum value in a sequence of values.
        /// </summary>
        /// <param name="source">A sequence of values to determine the maximum of.</param>
        /// <returns>The maximum value in the sequence</returns>
        public static double MaxFast(this double[] source)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Length == 0)
            {
                throw NoElements();
            }

            double r = source[0];
            int startIndex = 0;
            for (; startIndex < source.Length; startIndex++)
            {
                if (!double.IsNaN(source[startIndex]))
                {
                    r = source[startIndex];
                    break;
                }
            }

            for (int i = startIndex; i < source.Length; i++)
            {
                if (source[i] > r) r = source[i];
            }

            return r;
        }

        /// <summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum value.
        /// </summary>
        /// <param name="source">A sequence of values to determine the maximum value of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The maximum value in the transform of the sequence.</returns>
        public static double MaxFast<T>(this T[] source, Func<T, double> selector)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Length == 0)
            {
                throw NoElements();
            }

            if (selector == null)
            {
                throw ArgumentNull("selector");
            }

            double r = selector(source[0]);
            int startIndex = 0;
            for (; startIndex < source.Length; startIndex++)
            {
                var v = selector(source[startIndex]);
                if (!double.IsNaN(v))
                {
                    r = v;
                    break;
                }
            }

            for (int i = startIndex; i < source.Length; i++)
            {
                var v = selector(source[i]);
                if (v > r) r = v;
            }

            return r;
        }

        /// <summary>
        /// Returns the maximum value in a sequence of values.
        /// </summary>
        /// <param name="source">A sequence of values to determine the maximum of.</param>
        /// <returns>The maximum value in the sequence</returns>
        public static decimal MaxFast(this decimal[] source)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Length == 0)
            {
                throw NoElements();
            }

            decimal r = decimal.MinValue;
            for (int i = 0; i < source.Length; i++)
            {
                if (source[i] > r) r = source[i];
            }

            return r;
        }

        /// <summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum value.
        /// </summary>
        /// <param name="source">A sequence of values to determine the maximum value of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The maximum value in the transform of the sequence.</returns>
        public static decimal MaxFast<T>(this T[] source, Func<T, decimal> selector)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Length == 0)
            {
                throw NoElements();
            }

            if (selector == null)
            {
                throw ArgumentNull("selector");
            }

            decimal r = decimal.MinValue;
            for (int i = 0; i < source.Length; i++)
            {
                var v = selector(source[i]);
                if (v > r) r = v;
            }

            return r;
        }

        #endregion

#if LINQ_SPAN
        #region ------------------------------ Spans ------------------------------

        /// <summary>
        /// Returns the maximum value in a sequence of values.
        /// </summary>
        /// <param name="source">A sequence of values to determine the maximum of.</param>
        /// <returns>The maximum value in the sequence</returns>
        public static T MaxFast<T>(this Span<T> source)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Length == 0)
            {
                throw NoElements();
            }

            Comparer<T> comparer = Comparer<T>.Default;
            T r = default(T);
            if (r == null)
            {
                r = source[0];
                for (int i = 1; i < source.Length; i++)
                {
                    if (source[i] != null && comparer.Compare(source[i], r) > 0) r = source[i];
                }
            }
            else
            {
                r = source[0];
                for (int i = 1; i < source.Length; i++)
                {
                    if (comparer.Compare(source[i], r) > 0) r = source[i];
                }
            }

            return r;
        }

        /// <summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum value.
        /// </summary>
        /// <param name="source">A sequence of values to determine the maximum value of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The maximum value in the transform of the sequence.</returns>
        public static TResult MaxFast<T, TResult>(this Span<T> source, Func<T, TResult> selector)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (selector == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Length == 0)
            {
                throw NoElements();
            }

            Comparer<TResult> comparer = Comparer<TResult>.Default;
            TResult r = default(TResult);
            if (r == null)
            {
                r = selector(source[0]);
                for (int i = 1; i < source.Length; i++)
                {
                    var v = selector(source[i]);
                    if (v != null && comparer.Compare(v, r) > 0) r = v;
                }
            }
            else
            {
                r = selector(source[0]);
                for (int i = 1; i < source.Length; i++)
                {
                    var v = selector(source[i]);
                    if (comparer.Compare(v, r) > 0) r = v;
                }
            }

            return r;
        }

        /// <summary>
        /// Returns the maximum value in a sequence of values.
        /// </summary>
        /// <param name="source">A sequence of values to determine the maximum of.</param>
        /// <returns>The maximum value in the sequence</returns>
        public static int MaxFast(this Span<int> source)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Length == 0)
            {
                throw NoElements();
            }

            int r = int.MinValue;
            for (int i = 0; i < source.Length; i++)
            {
                if (source[i] > r) r = source[i];
            }

            return r;
        }

        /// <summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum value.
        /// </summary>
        /// <param name="source">A sequence of values to determine the maximum value of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The maximum value in the transform of the sequence.</returns>
        public static int MaxFast<T>(this Span<T> source, Func<T, int> selector)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Length == 0)
            {
                throw NoElements();
            }

            if (selector == null)
            {
                throw ArgumentNull("selector");
            }

            int r = int.MinValue;
            for (int i = 0; i < source.Length; i++)
            {
                var v = selector(source[i]);
                if (v > r) r = v;
            }

            return r;
        }

        /// <summary>
        /// Returns the maximum value in a sequence of values.
        /// </summary>
        /// <param name="source">A sequence of values to determine the maximum of.</param>
        /// <returns>The maximum value in the sequence</returns>
        public static long MaxFast(this Span<long> source)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Length == 0)
            {
                throw NoElements();
            }

            long r = long.MinValue;
            for (int i = 0; i < source.Length; i++)
            {
                if (source[i] > r) r = source[i];
            }

            return r;
        }

        /// <summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum value.
        /// </summary>
        /// <param name="source">A sequence of values to determine the maximum value of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The maximum value in the transform of the sequence.</returns>
        public static long MaxFast<T>(this Span<T> source, Func<T, long> selector)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Length == 0)
            {
                throw NoElements();
            }

            if (selector == null)
            {
                throw ArgumentNull("selector");
            }

            long r = long.MinValue;
            for (int i = 0; i < source.Length; i++)
            {
                var v = selector(source[i]);
                if (v > r) r = v;
            }

            return r;
        }

        /// <summary>
        /// Returns the maximum value in a sequence of values.
        /// </summary>
        /// <param name="source">A sequence of values to determine the maximum of.</param>
        /// <returns>The maximum value in the sequence</returns>
        public static float MaxFast(this Span<float> source)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Length == 0)
            {
                throw NoElements();
            }

            float r = source[0];
            int startIndex = 0;
            for (; startIndex < source.Length; startIndex++)
            {
                if (!float.IsNaN(source[startIndex]))
                {
                    r = source[startIndex];
                    break;
                }
            }

            for (int i = startIndex; i < source.Length; i++)
            {
                if (source[i] > r) r = source[i];
            }

            return r;
        }

        /// <summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum value.
        /// </summary>
        /// <param name="source">A sequence of values to determine the maximum value of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The maximum value in the transform of the sequence.</returns>
        public static float MaxFast<T>(this Span<T> source, Func<T, float> selector)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Length == 0)
            {
                throw NoElements();
            }

            if (selector == null)
            {
                throw ArgumentNull("selector");
            }

            float r = selector(source[0]);
            int startIndex = 0;
            for (; startIndex < source.Length; startIndex++)
            {
                var v = selector(source[startIndex]);
                if (!float.IsNaN(v))
                {
                    r = v;
                    break;
                }
            }

            for (int i = startIndex; i < source.Length; i++)
            {
                var v = selector(source[i]);
                if (v > r) r = v;
            }

            return r;
        }

        /// <summary>
        /// Returns the maximum value in a sequence of values.
        /// </summary>
        /// <param name="source">A sequence of values to determine the maximum of.</param>
        /// <returns>The maximum value in the sequence</returns>
        public static double MaxFast(this Span<double> source)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Length == 0)
            {
                throw NoElements();
            }

            double r = source[0];
            int startIndex = 0;
            for (; startIndex < source.Length; startIndex++)
            {
                if (!double.IsNaN(source[startIndex]))
                {
                    r = source[startIndex];
                    break;
                }
            }

            for (int i = startIndex; i < source.Length; i++)
            {
                if (source[i] > r) r = source[i];
            }

            return r;
        }

        /// <summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum value.
        /// </summary>
        /// <param name="source">A sequence of values to determine the maximum value of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The maximum value in the transform of the sequence.</returns>
        public static double MaxFast<T>(this Span<T> source, Func<T, double> selector)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Length == 0)
            {
                throw NoElements();
            }

            if (selector == null)
            {
                throw ArgumentNull("selector");
            }

            double r = selector(source[0]);
            int startIndex = 0;
            for (; startIndex < source.Length; startIndex++)
            {
                var v = selector(source[startIndex]);
                if (!double.IsNaN(v))
                {
                    r = v;
                    break;
                }
            }

            for (int i = startIndex; i < source.Length; i++)
            {
                var v = selector(source[i]);
                if (v > r) r = v;
            }

            return r;
        }

        /// <summary>
        /// Returns the maximum value in a sequence of values.
        /// </summary>
        /// <param name="source">A sequence of values to determine the maximum of.</param>
        /// <returns>The maximum value in the sequence</returns>
        public static decimal MaxFast(this Span<decimal> source)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Length == 0)
            {
                throw NoElements();
            }

            decimal r = decimal.MinValue;
            for (int i = 0; i < source.Length; i++)
            {
                if (source[i] > r) r = source[i];
            }

            return r;
        }

        /// <summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum value.
        /// </summary>
        /// <param name="source">A sequence of values to determine the maximum value of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The maximum value in the transform of the sequence.</returns>
        public static decimal MaxFast<T>(this Span<T> source, Func<T, decimal> selector)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Length == 0)
            {
                throw NoElements();
            }

            if (selector == null)
            {
                throw ArgumentNull("selector");
            }

            decimal r = decimal.MinValue;
            for (int i = 0; i < source.Length; i++)
            {
                var v = selector(source[i]);
                if (v > r) r = v;
            }

            return r;
        }

        #endregion
#endif

        #region ------------------------------ Lists ------------------------------

        /// <summary>
        /// Returns the maximum value in a sequence of values.
        /// </summary>
        /// <param name="source">A sequence of values to determine the maximum of.</param>
        /// <returns>The maximum value in the sequence</returns>
        public static T MaxFast<T>(this List<T> source)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Count == 0)
            {
                throw NoElements();
            }

            Comparer<T> comparer = Comparer<T>.Default;
            T r = default(T);
            if (r == null)
            {
                r = source[0];
                for (int i = 1; i < source.Count; i++)
                {
                    if (source[i] != null && comparer.Compare(source[i], r) > 0) r = source[i];
                }
            }
            else
            {
                r = source[0];
                for (int i = 1; i < source.Count; i++)
                {
                    if (comparer.Compare(source[i], r) > 0) r = source[i];
                }
            }

            return r;
        }

        /// <summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum value.
        /// </summary>
        /// <param name="source">A sequence of values to determine the maximum value of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The maximum value in the transform of the sequence.</returns>
        public static TResult MaxFast<T, TResult>(this List<T> source, Func<T, TResult> selector)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (selector == null)
            {
                throw ArgumentNull("selector");
            }

            if (source.Count == 0)
            {
                throw NoElements();
            }

            Comparer<TResult> comparer = Comparer<TResult>.Default;
            TResult r = default(TResult);
            if (r == null)
            {
                r = selector(source[0]);
                for (int i = 1; i < source.Count; i++)
                {
                    var v = selector(source[i]);
                    if (v != null && comparer.Compare(v, r) > 0) r = v;
                }
            }
            else
            {
                r = selector(source[0]);
                for (int i = 1; i < source.Count; i++)
                {
                    var v = selector(source[i]);
                    if (comparer.Compare(v, r) > 0) r = v;
                }
            }

            return r;
        }

        /// <summary>
        /// Returns the maximum value in a sequence of values.
        /// </summary>
        /// <param name="source">A sequence of values to determine the maximum of.</param>
        /// <returns>The maximum value in the sequence</returns>
        public static int MaxFast(this List<int> source)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Count == 0)
            {
                throw NoElements();
            }

            int r = int.MinValue;
            for (int i = 0; i < source.Count; i++)
            {
                if (source[i] > r) r = source[i];
            }

            return r;
        }

        /// <summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum value.
        /// </summary>
        /// <param name="source">A sequence of values to determine the maximum value of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The maximum value in the transform of the sequence.</returns>
        public static int MaxFast<T>(this List<T> source, Func<T, int> selector)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Count == 0)
            {
                throw NoElements();
            }

            if (selector == null)
            {
                throw ArgumentNull("selector");
            }

            int r = int.MinValue;
            for (int i = 0; i < source.Count; i++)
            {
                var v = selector(source[i]);
                if (v > r) r = v;
            }

            return r;
        }

        /// <summary>
        /// Returns the maximum value in a sequence of values.
        /// </summary>
        /// <param name="source">A sequence of values to determine the maximum of.</param>
        /// <returns>The maximum value in the sequence</returns>
        public static long MaxFast(this List<long> source)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Count == 0)
            {
                throw NoElements();
            }

            long r = long.MinValue;
            for (int i = 0; i < source.Count; i++)
            {
                if (source[i] > r) r = source[i];
            }

            return r;
        }

        /// <summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum value.
        /// </summary>
        /// <param name="source">A sequence of values to determine the maximum value of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The maximum value in the transform of the sequence.</returns>
        public static long MaxFast<T>(this List<T> source, Func<T, long> selector)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Count == 0)
            {
                throw NoElements();
            }

            if (selector == null)
            {
                throw ArgumentNull("source");
            }

            long r = long.MinValue;
            for (int i = 0; i < source.Count; i++)
            {
                var v = selector(source[i]);
                if (v > r) r = v;
            }

            return r;
        }

        /// <summary>
        /// Returns the maximum value in a sequence of values.
        /// </summary>
        /// <param name="source">A sequence of values to determine the maximum of.</param>
        /// <returns>The maximum value in the sequence</returns>
        public static float MaxFast(this List<float> source)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Count == 0)
            {
                throw NoElements();
            }

            float r = source[0];
            int startIndex = 0;
            for (; startIndex < source.Count; startIndex++)
            {
                if (!float.IsNaN(source[startIndex]))
                {
                    r = source[startIndex];
                    break;
                }
            }

            for (int i = startIndex; i < source.Count; i++)
            {
                if (source[i] > r) r = source[i];
            }

            return r;
        }

        /// <summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum value.
        /// </summary>
        /// <param name="source">A sequence of values to determine the maximum value of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The maximum value in the transform of the sequence.</returns>
        public static float MaxFast<T>(this List<T> source, Func<T, float> selector)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Count == 0)
            {
                throw NoElements();
            }

            if (selector == null)
            {
                throw ArgumentNull("selector");
            }

            float r = selector(source[0]);
            int startIndex = 0;
            for (; startIndex < source.Count; startIndex++)
            {
                var v = selector(source[startIndex]);
                if (!float.IsNaN(v))
                {
                    r = v;
                    break;
                }
            }

            for (int i = startIndex; i < source.Count; i++)
            {
                var v = selector(source[i]);
                if (v > r) r = v;
            }

            return r;
        }

        /// <summary>
        /// Returns the maximum value in a sequence of values.
        /// </summary>
        /// <param name="source">A sequence of values to determine the maximum of.</param>
        /// <returns>The maximum value in the sequence</returns>
        public static double MaxFast(this List<double> source)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Count == 0)
            {
                throw NoElements();
            }

            double r = source[0];
            int startIndex = 0;
            for (; startIndex < source.Count; startIndex++)
            {
                if (!double.IsNaN(source[startIndex]))
                {
                    r = source[startIndex];
                    break;
                }
            }

            for (int i = startIndex; i < source.Count; i++)
            {
                if (source[i] > r) r = source[i];
            }

            return r;
        }

        /// <summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum value.
        /// </summary>
        /// <param name="source">A sequence of values to determine the maximum value of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The maximum value in the transform of the sequence.</returns>
        public static double MaxFast<T>(this List<T> source, Func<T, double> selector)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Count == 0)
            {
                throw NoElements();
            }

            if (selector == null)
            {
                throw ArgumentNull("selector");
            }

            double r = selector(source[0]);
            int startIndex = 0;
            for (; startIndex < source.Count; startIndex++)
            {
                var v = selector(source[startIndex]);
                if (!double.IsNaN(v))
                {
                    r = v;
                    break;
                }
            }

            for (int i = startIndex; i < source.Count; i++)
            {
                var v = selector(source[i]);
                if (v > r) r = v;
            }

            return r;
        }

        /// <summary>
        /// Returns the maximum value in a sequence of values.
        /// </summary>
        /// <param name="source">A sequence of values to determine the maximum of.</param>
        /// <returns>The maximum value in the sequence</returns>
        public static decimal MaxFast(this List<decimal> source)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Count == 0)
            {
                throw NoElements();
            }

            decimal r = decimal.MinValue;
            for (int i = 0; i < source.Count; i++)
            {
                if (source[i] > r) r = source[i];
            }

            return r;
        }

        /// <summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum value.
        /// </summary>
        /// <param name="source">A sequence of values to determine the maximum value of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The maximum value in the transform of the sequence.</returns>
        public static decimal MaxFast<T>(this List<T> source, Func<T, decimal> selector)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Count == 0)
            {
                throw NoElements();
            }

            decimal r = decimal.MinValue;
            for (int i = 0; i < source.Count; i++)
            {
                var v = selector(source[i]);
                if (v > r) r = v;
            }

            return r;
        }

        #endregion
    }
}
