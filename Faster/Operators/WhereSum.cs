using System;
using System.Collections.Generic;


namespace Worldreaver.LinqFaster
{
    public static partial class LightweightLinq
    {
        #region ------------------------------ Arrays ------------------------------

        /// <summary>
        ///  Adds the values in the sequence that match the where predicate.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <param name="predicate">A function to filter the sequence with before summing.</param>
        /// <returns>The sum of the sequence.</returns>
        public static int WhereSumFast(this int[] source, Func<int, bool> predicate)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            int sum = 0;
            checked
            {
                foreach (var v in source)
                {
                    if (predicate(v))
                    {
                        sum += v;
                    }
                }
            }

            return sum;
        }

        /// <summary>
        /// Performs a filter with the where predicate, then sums the transformed values.
        /// </summary>
        /// <param name="source">The sequence of values to transform then sum.</param>
        /// <param name="predicate">A function to filter the sequence with before summing.</param>
        /// <param name="selector">A transformation function.</param>
        /// <returns>The sum of the transformed elements.</returns>
        public static int WhereSumFast<T>(this T[] source, Func<T, bool> predicate, Func<T, int> selector)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (selector == null)
            {
                throw ArgumentNull("selector");
            }

            int sum = 0;
            checked
            {
                foreach (var v in source)
                {
                    if (predicate(v))
                    {
                        sum += selector(v);
                    }
                }
            }

            return sum;
        }

        /// <summary>
        ///  Adds the values in the sequence that match the where predicate.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <param name="predicate">A function to filter the sequence with before summing.</param>
        /// <returns>The sum of the sequence.</returns>
        public static long WhereSumFast(this long[] source, Func<long, bool> predicate)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            long sum = 0;
            checked
            {
                foreach (var v in source)
                {
                    if (predicate(v))
                    {
                        sum += v;
                    }
                }
            }

            return sum;
        }

        /// <summary>
        /// Performs a filter with the where predicate, then sums the transformed values.
        /// </summary>
        /// <param name="source">The sequence of values to transform then sum.</param>
        /// <param name="predicate">A function to filter the sequence with before summing.</param>
        /// <param name="selector">A transformation function.</param>
        /// <returns>The sum of the transformed elements.</returns>
        public static long WhereSumFast<T>(this T[] source, Func<T, bool> predicate, Func<T, long> selector)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (selector == null)
            {
                throw ArgumentNull("selector");
            }

            long sum = 0;
            checked
            {
                foreach (var v in source)
                {
                    if (predicate(v))
                    {
                        sum += selector(v);
                    }
                }
            }

            return sum;
        }

        /// <summary>
        ///  Adds the values in the sequence that match the where predicate.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <param name="predicate">A function to filter the sequence with before summing.</param>
        /// <returns>The sum of the sequence.</returns>
        public static float WhereSumFast(this float[] source, Func<float, bool> predicate)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            double sum = 0;

            foreach (var v in source)
            {
                if (predicate(v))
                {
                    sum += v;
                }
            }

            return (float) sum;
        }

        /// <summary>
        /// Performs a filter with the where predicate, then sums the transformed values.
        /// </summary>
        /// <param name="source">The sequence of values to transform then sum.</param>
        /// <param name="predicate">A function to filter the sequence with before summing.</param>
        /// <param name="selector">A transformation function.</param>
        /// <returns>The sum of the transformed elements.</returns>
        public static float WhereSumFast<T>(this T[] source, Func<T, bool> predicate, Func<T, float> selector)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (selector == null)
            {
                throw ArgumentNull("selector");
            }

            double sum = 0;
            foreach (var v in source)
            {
                if (predicate(v))
                {
                    sum += selector(v);
                }
            }

            return (float) sum;
        }

        /// <summary>
        ///  Adds the values in the sequence that match the where predicate.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <param name="predicate">A function to filter the sequence with before summing.</param>
        /// <returns>The sum of the sequence.</returns>
        public static double WhereSumFast(this double[] source, Func<double, bool> predicate)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            double sum = 0;
            foreach (var v in source)
            {
                if (predicate(v))
                {
                    sum += v;
                }
            }

            return sum;
        }

        /// <summary>
        /// Performs a filter with the where predicate, then sums the transformed values.
        /// </summary>
        /// <param name="source">The sequence of values to transform then sum.</param>
        /// <param name="predicate">A function to filter the sequence with before summing.</param>
        /// <param name="selector">A transformation function.</param>
        /// <returns>The sum of the transformed elements.</returns>
        public static double WhereSumFast<T>(this T[] source, Func<T, bool> predicate, Func<T, double> selector)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (selector == null)
            {
                throw ArgumentNull("selector");
            }

            double sum = 0;
            foreach (var v in source)
            {
                if (predicate(v))
                {
                    sum += selector(v);
                }
            }

            return sum;
        }

        /// <summary>
        ///  Adds the values in the sequence that match the where predicate.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <param name="predicate">A function to filter the sequence with before summing.</param>
        /// <returns>The sum of the sequence.</returns>
        public static decimal WhereSumFast(this decimal[] source, Func<decimal, bool> predicate)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            decimal sum = 0;

            foreach (var v in source)
            {
                if (predicate(v))
                {
                    sum += v;
                }
            }

            return sum;
        }

        /// <summary>
        /// Performs a filter with the where predicate, then sums the transformed values.
        /// </summary>
        /// <param name="source">The sequence of values to transform then sum.</param>
        /// <param name="predicate">A function to filter the sequence with before summing.</param>
        /// <param name="selector">A transformation function.</param>
        /// <returns>The sum of the transformed elements.</returns>
        public static decimal WhereSumFast<T>(this T[] source, Func<T, bool> predicate, Func<T, decimal> selector)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (selector == null)
            {
                throw ArgumentNull("selector");
            }

            decimal sum = 0;
            foreach (var v in source)
            {
                if (predicate(v))
                {
                    sum += selector(v);
                }
            }

            return sum;
        }

        #endregion

#if LINQ_SPAN
        #region ------------------------------ Spans ------------------------------

        /// <summary>
        ///  Adds the values in the sequence that match the where predicate.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <param name="predicate">A function to filter the sequence with before summing.</param>
        /// <returns>The sum of the sequence.</returns>
        public static int WhereSumFast(this Span<int> source, Func<int, bool> predicate)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            int sum = 0;
            checked
            {
                foreach (var v in source)
                {
                    if (predicate(v))
                    {
                        sum += v;
                    }
                }
            }

            return sum;
        }

        /// <summary>
        /// Performs a filter with the where predicate, then sums the transformed values.
        /// </summary>
        /// <param name="source">The sequence of values to transform then sum.</param>
        /// <param name="predicate">A function to filter the sequence with before summing.</param>
        /// <param name="selector">A transformation function.</param>
        /// <returns>The sum of the transformed elements.</returns>
        public static int WhereSumFast<T>(this Span<T> source, Func<T, bool> predicate, Func<T, int> selector)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (selector == null)
            {
                throw ArgumentNull("selector");
            }

            int sum = 0;
            checked
            {
                foreach (var v in source)
                {
                    if (predicate(v))
                    {
                        sum += selector(v);
                    }
                }
            }

            return sum;
        }

        /// <summary>
        ///  Adds the values in the sequence that match the where predicate.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <param name="predicate">A function to filter the sequence with before summing.</param>
        /// <returns>The sum of the sequence.</returns>
        public static long WhereSumFast(this Span<long> source, Func<long, bool> predicate)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            long sum = 0;
            checked
            {
                foreach (var v in source)
                {
                    if (predicate(v))
                    {
                        sum += v;
                    }
                }
            }

            return sum;
        }

        /// <summary>
        /// Performs a filter with the where predicate, then sums the transformed values.
        /// </summary>
        /// <param name="source">The sequence of values to transform then sum.</param>
        /// <param name="predicate">A function to filter the sequence with before summing.</param>
        /// <param name="selector">A transformation function.</param>
        /// <returns>The sum of the transformed elements.</returns>
        public static long WhereSumFast<T>(this Span<T> source, Func<T, bool> predicate, Func<T, long> selector)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (selector == null)
            {
                throw ArgumentNull("selector");
            }

            long sum = 0;
            checked
            {
                foreach (var v in source)
                {
                    if (predicate(v))
                    {
                        sum += selector(v);
                    }
                }
            }

            return sum;
        }

        /// <summary>
        ///  Adds the values in the sequence that match the where predicate.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <param name="predicate">A function to filter the sequence with before summing.</param>
        /// <returns>The sum of the sequence.</returns>
        public static float WhereSumFast(this Span<float> source, Func<float, bool> predicate)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            double sum = 0;

            foreach (var v in source)
            {
                if (predicate(v))
                {
                    sum += v;
                }
            }

            return (float) sum;
        }

        /// <summary>
        /// Performs a filter with the where predicate, then sums the transformed values.
        /// </summary>
        /// <param name="source">The sequence of values to transform then sum.</param>
        /// <param name="predicate">A function to filter the sequence with before summing.</param>
        /// <param name="selector">A transformation function.</param>
        /// <returns>The sum of the transformed elements.</returns>
        public static float WhereSumFast<T>(this Span<T> source, Func<T, bool> predicate, Func<T, float> selector)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (selector == null)
            {
                throw ArgumentNull("selector");
            }

            double sum = 0;
            foreach (var v in source)
            {
                if (predicate(v))
                {
                    sum += selector(v);
                }
            }

            return (float) sum;
        }

        /// <summary>
        ///  Adds the values in the sequence that match the where predicate.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <param name="predicate">A function to filter the sequence with before summing.</param>
        /// <returns>The sum of the sequence.</returns>
        public static double WhereSumFast(this Span<double> source, Func<double, bool> predicate)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            double sum = 0;
            foreach (var v in source)
            {
                if (predicate(v))
                {
                    sum += v;
                }
            }

            return sum;
        }

        /// <summary>
        /// Performs a filter with the where predicate, then sums the transformed values.
        /// </summary>
        /// <param name="source">The sequence of values to transform then sum.</param>
        /// <param name="predicate">A function to filter the sequence with before summing.</param>
        /// <param name="selector">A transformation function.</param>
        /// <returns>The sum of the transformed elements.</returns>
        public static double WhereSumFast<T>(this Span<T> source, Func<T, bool> predicate, Func<T, double> selector)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (selector == null)
            {
                throw ArgumentNull("selector");
            }

            double sum = 0;
            foreach (var v in source)
            {
                if (predicate(v))
                {
                    sum += selector(v);
                }
            }

            return sum;
        }

        /// <summary>
        ///  Adds the values in the sequence that match the where predicate.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <param name="predicate">A function to filter the sequence with before summing.</param>
        /// <returns>The sum of the sequence.</returns>
        public static decimal WhereSumFast(this Span<decimal> source, Func<decimal, bool> predicate)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            decimal sum = 0;

            foreach (var v in source)
            {
                if (predicate(v))
                {
                    sum += v;
                }
            }

            return sum;
        }

        /// <summary>
        /// Performs a filter with the where predicate, then sums the transformed values.
        /// </summary>
        /// <param name="source">The sequence of values to transform then sum.</param>
        /// <param name="predicate">A function to filter the sequence with before summing.</param>
        /// <param name="selector">A transformation function.</param>
        /// <returns>The sum of the transformed elements.</returns>
        public static decimal WhereSumFast<T>(this Span<T> source, Func<T, bool> predicate, Func<T, decimal> selector)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (selector == null)
            {
                throw ArgumentNull("selector");
            }

            decimal sum = 0;
            foreach (var v in source)
            {
                if (predicate(v))
                {
                    sum += selector(v);
                }
            }

            return sum;
        }

        #endregion
#endif

        #region ------------------------------ Lists ------------------------------

        /// <summary>
        ///  Adds the values in the sequence that match the where predicate.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <param name="predicate">A function to filter the sequence with before summing.</param>
        /// <returns>The sum of the sequence.</returns>
        public static int WhereSumFast(this List<int> source, Func<int, bool> predicate)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            int sum = 0;
            checked
            {
                for (int i = 0; i < source.Count; i++)
                {
                    var s = source[i];
                    if (predicate(s))
                    {
                        sum += s;
                    }
                }
            }

            return sum;
        }

        /// <summary>
        /// Performs a filter with the where predicate, then sums the transformed values.
        /// </summary>
        /// <param name="source">The sequence of values to transform then sum.</param>
        /// <param name="predicate">A function to filter the sequence with before summing.</param>
        /// <param name="selector">A transformation function.</param>
        /// <returns>The sum of the transformed elements.</returns>
        public static int WhereSumFast<T>(this List<T> source, Func<T, bool> predicate, Func<T, int> selector)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (selector == null)
            {
                throw ArgumentNull("selector");
            }

            int sum = 0;
            checked
            {
                for (int i = 0; i < source.Count; i++)
                {
                    var s = source[i];
                    if (predicate(s))
                    {
                        sum += selector(s);
                    }
                }
            }

            return sum;
        }

        /// <summary>
        ///  Adds the values in the sequence that match the where predicate.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <param name="predicate">A function to filter the sequence with before summing.</param>
        /// <returns>The sum of the sequence.</returns>
        public static long WhereSumFast(this List<long> source, Func<long, bool> predicate)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            long sum = 0;
            checked
            {
                for (int i = 0; i < source.Count; i++)
                {
                    var s = source[i];
                    if (predicate(s))
                    {
                        sum += s;
                    }
                }
            }

            return sum;
        }

        /// <summary>
        /// Performs a filter with the where predicate, then sums the transformed values.
        /// </summary>
        /// <param name="source">The sequence of values to transform then sum.</param>
        /// <param name="predicate">A function to filter the sequence with before summing.</param>
        /// <param name="selector">A transformation function.</param>
        /// <returns>The sum of the transformed elements.</returns>
        public static long WhereSumFast<T>(this List<T> source, Func<T, bool> predicate, Func<T, long> selector)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (selector == null)
            {
                throw ArgumentNull("selector");
            }

            long sum = 0;
            checked
            {
                for (int i = 0; i < source.Count; i++)
                {
                    var s = source[i];
                    if (predicate(s))
                    {
                        sum += selector(s);
                    }
                }
            }

            return sum;
        }

        /// <summary>
        ///  Adds the values in the sequence that match the where predicate.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <param name="predicate">A function to filter the sequence with before summing.</param>
        /// <returns>The sum of the sequence.</returns>
        public static float WhereSumFast(this List<float> source, Func<float, bool> predicate)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            double sum = 0;

            for (int i = 0; i < source.Count; i++)
            {
                var s = source[i];
                if (predicate(s))
                {
                    sum += s;
                }
            }

            return (float) sum;
        }

        /// <summary>
        /// Performs a filter with the where predicate, then sums the transformed values.
        /// </summary>
        /// <param name="source">The sequence of values to transform then sum.</param>
        /// <param name="predicate">A function to filter the sequence with before summing.</param>
        /// <param name="selector">A transformation function.</param>
        /// <returns>The sum of the transformed elements.</returns>
        public static float WhereSumFast<T>(this List<T> source, Func<T, bool> predicate, Func<T, float> selector)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (selector == null)
            {
                throw ArgumentNull("selector");
            }

            double sum = 0;
            for (int i = 0; i < source.Count; i++)
            {
                var s = source[i];
                if (predicate(s))
                {
                    sum += selector(s);
                }
            }

            return (float) sum;
        }

        /// <summary>
        ///  Adds the values in the sequence that match the where predicate.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <param name="predicate">A function to filter the sequence with before summing.</param>
        /// <returns>The sum of the sequence.</returns>
        public static double WhereSumFast(this List<double> source, Func<double, bool> predicate)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            double sum = 0;
            for (int i = 0; i < source.Count; i++)
            {
                var s = source[i];
                if (predicate(s))
                {
                    sum += s;
                }
            }

            return sum;
        }

        /// <summary>
        /// Performs a filter with the where predicate, then sums the transformed values.
        /// </summary>
        /// <param name="source">The sequence of values to transform then sum.</param>
        /// <param name="predicate">A function to filter the sequence with before summing.</param>
        /// <param name="selector">A transformation function.</param>
        /// <returns>The sum of the transformed elements.</returns>
        public static double WhereSumFast<T>(this List<T> source, Func<T, bool> predicate, Func<T, double> selector)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (selector == null)
            {
                throw ArgumentNull("selector");
            }

            double sum = 0;
            for (int i = 0; i < source.Count; i++)
            {
                var s = source[i];
                if (predicate(s))
                {
                    sum += selector(s);
                }
            }

            return sum;
        }

        /// <summary>
        ///  Adds the values in the sequence that match the where predicate.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <param name="predicate">A function to filter the sequence with before summing.</param>
        /// <returns>The sum of the sequence.</returns>
        public static decimal WhereSumFast(this List<decimal> source, Func<decimal, bool> predicate)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            decimal sum = 0;

            for (int i = 0; i < source.Count; i++)
            {
                var s = source[i];
                if (predicate(s))
                {
                    sum += s;
                }
            }

            return sum;
        }

        /// <summary>
        /// Performs a filter with the where predicate, then sums the transformed values.
        /// </summary>
        /// <param name="source">The sequence of values to transform then sum.</param>
        /// <param name="predicate">A function to filter the sequence with before summing.</param>
        /// <param name="selector">A transformation function.</param>
        /// <returns>The sum of the transformed elements.</returns>
        public static decimal WhereSumFast<T>(this List<T> source, Func<T, bool> predicate, Func<T, decimal> selector)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (selector == null)
            {
                throw ArgumentNull("selector");
            }

            decimal sum = 0;
            for (int i = 0; i < source.Count; i++)
            {
                var s = source[i];
                if (predicate(s))
                {
                    sum += selector(s);
                }
            }

            return sum;
        }

        #endregion
    }
}
