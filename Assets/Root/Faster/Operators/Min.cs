using System;
using System.Collections.Generic;


namespace Worldreaver.LinqFaster
{
    //int, long, float,double, decimal
    public static partial class LightweightLinq
    {
        #region ------------------------------ Arrays ------------------------------

        /// <summary>
        /// Returns the minimum value in a sequence of values.
        /// </summary>
        /// <param name="source">A sequence of values to determine the minimum of.</param>
        /// <returns>The minimum value in the sequence</returns>
        public static T MinFast<T>(this T[] source)
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
                    if (source[i] != null && comparer.Compare(source[i], r) < 0) r = source[i];
                }
            }
            else
            {
                r = source[0];
                for (int i = 1; i < source.Length; i++)
                {
                    if (comparer.Compare(source[i], r) < 0) r = source[i];
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
        public static TResult MinFast<T, TResult>(this T[] source, Func<T, TResult> selector)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (selector == null)
            {
                throw ArgumentNull("selector");
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
                    if (v != null && comparer.Compare(v, r) < 0) r = v;
                }
            }
            else
            {
                r = selector(source[0]);
                for (int i = 1; i < source.Length; i++)
                {
                    var v = selector(source[i]);
                    if (comparer.Compare(v, r) < 0) r = v;
                }
            }

            return r;
        }

        /// <summary>
        /// Returns the minimum value in a sequence of values.
        /// </summary>
        /// <param name="source">A sequence of values to determine the minimum of.</param>
        /// <returns>The minimum value in the sequence</returns>
        public static int MinFast(this int[] source)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Length == 0)
            {
                throw NoElements();
            }

            int r = int.MaxValue;
            for (int i = 0; i < source.Length; i++)
            {
                if (source[i] < r) r = source[i];
            }

            return r;
        }

        /// <summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum value.
        /// </summary>
        /// <param name="source">A sequence of values to determine the maximum value of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The maximum value in the transform of the sequence.</returns>
        public static int MinFast<T>(this T[] source, Func<T, int> selector)
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

            int r = int.MaxValue;
            for (int i = 0; i < source.Length; i++)
            {
                var v = selector(source[i]);
                if (v < r) r = v;
            }

            return r;
        }

        /// <summary>
        /// Returns the minimum value in a sequence of values.
        /// </summary>
        /// <param name="source">A sequence of values to determine the minimum of.</param>
        /// <returns>The minimum value in the sequence</returns>
        public static long MinFast(this long[] source)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Length == 0)
            {
                throw NoElements();
            }

            long r = long.MaxValue;
            for (int i = 0; i < source.Length; i++)
            {
                if (source[i] < r) r = source[i];
            }

            return r;
        }

        /// <summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum value.
        /// </summary>
        /// <param name="source">A sequence of values to determine the maximum value of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The maximum value in the transform of the sequence.</returns>
        public static long MinFast<T>(this T[] source, Func<T, long> selector)
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

            long r = long.MaxValue;
            for (int i = 0; i < source.Length; i++)
            {
                var v = selector(source[i]);
                if (v < r) r = v;
            }

            return r;
        }

        /// <summary>
        /// Returns the minimum value in a sequence of values.
        /// </summary>
        /// <param name="source">A sequence of values to determine the minimum of.</param>
        /// <returns>The minimum value in the sequence</returns>
        public static float MinFast(this float[] source)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Length == 0)
            {
                throw NoElements();
            }

            float r = float.MaxValue;
            for (int i = 0; i < source.Length; i++)
            {
                if (source[i] < r) r = source[i];
                else if (float.IsNaN(source[i])) return source[i];
            }

            return r;
        }

        /// <summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum value.
        /// </summary>
        /// <param name="source">A sequence of values to determine the maximum value of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The maximum value in the transform of the sequence.</returns>
        public static float MinFast<T>(this T[] source, Func<T, float> selector)
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

            float r = float.MaxValue;
            for (int i = 0; i < source.Length; i++)
            {
                var v = selector(source[i]);
                if (v < r) r = v;
                else if (float.IsNaN(v)) return v;
            }

            return r;
        }

        /// <summary>
        /// Returns the minimum value in a sequence of values.
        /// </summary>
        /// <param name="source">A sequence of values to determine the minimum of.</param>
        /// <returns>The minimum value in the sequence</returns>
        public static double MinFast(this double[] source)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Length == 0)
            {
                throw NoElements();
            }

            double r = double.MaxValue;
            for (int i = 0; i < source.Length; i++)
            {
                if (source[i] < r) r = source[i];
                else if (double.IsNaN(source[i])) return source[i];
            }

            return r;
        }

        /// <summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum value.
        /// </summary>
        /// <param name="source">A sequence of values to determine the maximum value of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The maximum value in the transform of the sequence.</returns>
        public static double MinFast<T>(this T[] source, Func<T, double> selector)
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

            double r = double.MaxValue;
            for (int i = 0; i < source.Length; i++)
            {
                var v = selector(source[i]);
                if (v < r) r = v;
                else if (double.IsNaN(v)) return v;
            }

            return r;
        }

        /// <summary>
        /// Returns the minimum value in a sequence of values.
        /// </summary>
        /// <param name="source">A sequence of values to determine the minimum of.</param>
        /// <returns>The minimum value in the sequence</returns>
        public static decimal MinFast(this decimal[] source)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Length == 0)
            {
                throw NoElements();
            }

            decimal r = decimal.MaxValue;
            for (int i = 0; i < source.Length; i++)
            {
                if (source[i] < r) r = source[i];
            }

            return r;
        }

        /// <summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum value.
        /// </summary>
        /// <param name="source">A sequence of values to determine the maximum value of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The maximum value in the transform of the sequence.</returns>
        public static decimal MinFast<T>(this T[] source, Func<T, decimal> selector)
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

            decimal r = decimal.MaxValue;
            for (int i = 0; i < source.Length; i++)
            {
                var v = selector(source[i]);
                if (v < r) r = v;
            }

            return r;
        }

        #endregion

#if LINQ_SPAN
        #region ------------------------------ Spans ------------------------------

        /// <summary>
        /// Returns the minimum value in a sequence of values.
        /// </summary>
        /// <param name="source">A sequence of values to determine the minimum of.</param>
        /// <returns>The minimum value in the sequence</returns>
        public static T MinFast<T>(this Span<T> source)
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
                    if (source[i] != null && comparer.Compare(source[i], r) < 0) r = source[i];
                }
            }
            else
            {
                r = source[0];
                for (int i = 1; i < source.Length; i++)
                {
                    if (comparer.Compare(source[i], r) < 0) r = source[i];
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
        public static TResult MinFast<T, TResult>(this Span<T> source, Func<T, TResult> selector)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (selector == null)
            {
                throw ArgumentNull("selector");
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
                    if (v != null && comparer.Compare(v, r) < 0) r = v;
                }
            }
            else
            {
                r = selector(source[0]);
                for (int i = 1; i < source.Length; i++)
                {
                    var v = selector(source[i]);
                    if (comparer.Compare(v, r) < 0) r = v;
                }
            }

            return r;
        }

        /// <summary>
        /// Returns the minimum value in a sequence of values.
        /// </summary>
        /// <param name="source">A sequence of values to determine the minimum of.</param>
        /// <returns>The minimum value in the sequence</returns>
        public static int MinFast(this Span<int> source)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Length == 0)
            {
                throw NoElements();
            }

            int r = int.MaxValue;
            for (int i = 0; i < source.Length; i++)
            {
                if (source[i] < r) r = source[i];
            }

            return r;
        }

        /// <summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum value.
        /// </summary>
        /// <param name="source">A sequence of values to determine the maximum value of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The maximum value in the transform of the sequence.</returns>
        public static int MinFast<T>(this Span<T> source, Func<T, int> selector)
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

            int r = int.MaxValue;
            for (int i = 0; i < source.Length; i++)
            {
                var v = selector(source[i]);
                if (v < r) r = v;
            }

            return r;
        }

        /// <summary>
        /// Returns the minimum value in a sequence of values.
        /// </summary>
        /// <param name="source">A sequence of values to determine the minimum of.</param>
        /// <returns>The minimum value in the sequence</returns>
        public static long MinFast(this Span<long> source)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Length == 0)
            {
                throw NoElements();
            }

            long r = long.MaxValue;
            for (int i = 0; i < source.Length; i++)
            {
                if (source[i] < r) r = source[i];
            }

            return r;
        }

        /// <summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum value.
        /// </summary>
        /// <param name="source">A sequence of values to determine the maximum value of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The maximum value in the transform of the sequence.</returns>
        public static long MinFast<T>(this Span<T> source, Func<T, long> selector)
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

            long r = long.MaxValue;
            for (int i = 0; i < source.Length; i++)
            {
                var v = selector(source[i]);
                if (v < r) r = v;
            }

            return r;
        }

        /// <summary>
        /// Returns the minimum value in a sequence of values.
        /// </summary>
        /// <param name="source">A sequence of values to determine the minimum of.</param>
        /// <returns>The minimum value in the sequence</returns>
        public static float MinFast(this Span<float> source)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Length == 0)
            {
                throw NoElements();
            }

            float r = float.MaxValue;
            for (int i = 0; i < source.Length; i++)
            {
                if (source[i] < r) r = source[i];
                else if (float.IsNaN(source[i])) return source[i];
            }

            return r;
        }

        /// <summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum value.
        /// </summary>
        /// <param name="source">A sequence of values to determine the maximum value of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The maximum value in the transform of the sequence.</returns>
        public static float MinFast<T>(this Span<T> source, Func<T, float> selector)
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

            float r = float.MaxValue;
            for (int i = 0; i < source.Length; i++)
            {
                var v = selector(source[i]);
                if (v < r) r = v;
                else if (float.IsNaN(v)) return v;
            }

            return r;
        }

        /// <summary>
        /// Returns the minimum value in a sequence of values.
        /// </summary>
        /// <param name="source">A sequence of values to determine the minimum of.</param>
        /// <returns>The minimum value in the sequence</returns>
        public static double MinFast(this Span<double> source)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Length == 0)
            {
                throw NoElements();
            }

            double r = double.MaxValue;
            for (int i = 0; i < source.Length; i++)
            {
                if (source[i] < r) r = source[i];
                else if (double.IsNaN(source[i])) return source[i];
            }

            return r;
        }

        /// <summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum value.
        /// </summary>
        /// <param name="source">A sequence of values to determine the maximum value of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The maximum value in the transform of the sequence.</returns>
        public static double MinFast<T>(this Span<T> source, Func<T, double> selector)
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

            double r = double.MaxValue;
            for (int i = 0; i < source.Length; i++)
            {
                var v = selector(source[i]);
                if (v < r) r = v;
                else if (double.IsNaN(v)) return v;
            }

            return r;
        }

        /// <summary>
        /// Returns the minimum value in a sequence of values.
        /// </summary>
        /// <param name="source">A sequence of values to determine the minimum of.</param>
        /// <returns>The minimum value in the sequence</returns>
        public static decimal MinFast(this Span<decimal> source)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Length == 0)
            {
                throw NoElements();
            }

            decimal r = decimal.MaxValue;
            for (int i = 0; i < source.Length; i++)
            {
                if (source[i] < r) r = source[i];
            }

            return r;
        }

        /// <summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum value.
        /// </summary>
        /// <param name="source">A sequence of values to determine the maximum value of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The maximum value in the transform of the sequence.</returns>
        public static decimal MinFast<T>(this Span<T> source, Func<T, decimal> selector)
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

            decimal r = decimal.MaxValue;
            for (int i = 0; i < source.Length; i++)
            {
                var v = selector(source[i]);
                if (v < r) r = v;
            }

            return r;
        }

        #endregion
#endif

        #region ------------------------------ Lists ------------------------------

        /// <summary>
        /// Returns the minimum value in a sequence of values.
        /// </summary>
        /// <param name="source">A sequence of values to determine the minimum of.</param>
        /// <returns>The minimum value in the sequence</returns>
        public static T MinFast<T>(this List<T> source)
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
                    if (source[i] != null && comparer.Compare(source[i], r) < 0) r = source[i];
                }
            }
            else
            {
                r = source[0];
                for (int i = 1; i < source.Count; i++)
                {
                    if (comparer.Compare(source[i], r) < 0) r = source[i];
                }
            }

            return r;
        }

        /// <summary>
        /// Returns the minimum value in a sequence of values.
        /// </summary>
        /// <param name="source">A sequence of values to determine the minimum of.</param>
        /// <returns>The minimum value in the sequence</returns>
        public static int MinFast(this List<int> source)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Count == 0)
            {
                throw NoElements();
            }

            int r = int.MaxValue;
            for (int i = 0; i < source.Count; i++)
            {
                if (source[i] < r) r = source[i];
            }

            return r;
        }

        /// <summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum value.
        /// </summary>
        /// <param name="source">A sequence of values to determine the maximum value of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The maximum value in the transform of the sequence.</returns>
        public static int MinFast<T>(this List<T> source, Func<T, int> selector)
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

            int r = int.MaxValue;
            for (int i = 0; i < source.Count; i++)
            {
                var v = selector(source[i]);
                if (v < r) r = v;
            }

            return r;
        }

        /// <summary>
        /// Returns the minimum value in a sequence of values.
        /// </summary>
        /// <param name="source">A sequence of values to determine the minimum of.</param>
        /// <returns>The minimum value in the sequence</returns>
        public static long MinFast(this List<long> source)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Count == 0)
            {
                throw NoElements();
            }

            long r = long.MaxValue;
            for (int i = 0; i < source.Count; i++)
            {
                if (source[i] < r) r = source[i];
            }

            return r;
        }

        /// <summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum value.
        /// </summary>
        /// <param name="source">A sequence of values to determine the maximum value of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The maximum value in the transform of the sequence.</returns>
        public static long MinFast<T>(this List<T> source, Func<T, long> selector)
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

            long r = long.MaxValue;
            for (int i = 0; i < source.Count; i++)
            {
                var v = selector(source[i]);
                if (v < r) r = v;
            }

            return r;
        }

        /// <summary>
        /// Returns the minimum value in a sequence of values.
        /// </summary>
        /// <param name="source">A sequence of values to determine the minimum of.</param>
        /// <returns>The minimum value in the sequence</returns>
        public static float MinFast(this List<float> source)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Count == 0)
            {
                throw NoElements();
            }

            float r = float.MaxValue;
            for (int i = 0; i < source.Count; i++)
            {
                if (source[i] < r) r = source[i];
                else if (float.IsNaN(source[i])) return source[i];
            }

            return r;
        }

        /// <summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum value.
        /// </summary>
        /// <param name="source">A sequence of values to determine the maximum value of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The maximum value in the transform of the sequence.</returns>
        public static float MinFast<T>(this List<T> source, Func<T, float> selector)
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

            float r = float.MaxValue;
            for (int i = 0; i < source.Count; i++)
            {
                var v = selector(source[i]);
                if (v < r) r = v;
                else if (float.IsNaN(v)) return v;
            }

            return r;
        }

        /// <summary>
        /// Returns the minimum value in a sequence of values.
        /// </summary>
        /// <param name="source">A sequence of values to determine the minimum of.</param>
        /// <returns>The minimum value in the sequence</returns>
        public static double MinFast(this List<double> source)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Count == 0)
            {
                throw NoElements();
            }

            double r = double.MaxValue;
            for (int i = 0; i < source.Count; i++)
            {
                if (source[i] < r) r = source[i];
                else if (double.IsNaN(source[i])) return source[i];
            }

            return r;
        }

        /// <summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum value.
        /// </summary>
        /// <param name="source">A sequence of values to determine the maximum value of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The maximum value in the transform of the sequence.</returns>
        public static double MinFast<T>(this List<T> source, Func<T, double> selector)
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

            double r = double.MaxValue;
            for (int i = 0; i < source.Count; i++)
            {
                var v = selector(source[i]);
                if (v < r) r = v;
                else if (double.IsNaN(v)) return v;
            }

            return r;
        }

        /// <summary>
        /// Returns the minimum value in a sequence of values.
        /// </summary>
        /// <param name="source">A sequence of values to determine the minimum of.</param>
        /// <returns>The minimum value in the sequence</returns>
        public static decimal MinFast(this List<decimal> source)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Count == 0)
            {
                throw NoElements();
            }

            decimal r = decimal.MaxValue;
            for (int i = 0; i < source.Count; i++)
            {
                if (source[i] < r) r = source[i];
            }

            return r;
        }

        /// <summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum value.
        /// </summary>
        /// <param name="source">A sequence of values to determine the maximum value of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The maximum value in the transform of the sequence.</returns>
        public static decimal MinFast<T>(this List<T> source, Func<T, decimal> selector)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Count == 0)
            {
                throw NoElements();
            }

            decimal r = decimal.MaxValue;
            for (int i = 0; i < source.Count; i++)
            {
                var v = selector(source[i]);
                if (v < r) r = v;
            }

            return r;
        }

        /// <summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum value.
        /// </summary>
        /// <param name="source">A sequence of values to determine the maximum value of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The maximum value in the transform of the sequence.</returns>
        public static TResult MinFast<T, TResult>(this List<T> source, Func<T, TResult> selector)
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
                    if (v != null && comparer.Compare(v, r) < 0) r = v;
                }
            }
            else
            {
                r = selector(source[0]);
                for (int i = 1; i < source.Count; i++)
                {
                    var v = selector(source[i]);
                    if (comparer.Compare(v, r) < 0) r = v;
                }
            }

            return r;
        }

        #endregion
    }
}
