using System;
using System.Collections.Generic;


namespace Worldreaver.LinqFaster
{
    public static partial class LightweightLinq
    {
        #region ------------------------------ Arrays ------------------------------

        /// <summary>
        ///  Adds a sequence of values.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <returns>The sum of the sequence.</returns>
        public static int SumFast(this int[] source)
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
                    sum += v;
                }
            }

            return sum;
        }

        /// <summary>
        /// Adds the transformed sequence of elements.
        /// </summary>
        /// <param name="source">The sequence of values to transform then sum.</param>
        /// <param name="selector">A transformation function.</param>
        /// <returns>The sum of the transformed elements.</returns>
        public static int SumFast<T>(this T[] source, Func<T, int> selector)
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
                    sum += selector(v);
                }
            }

            return sum;
        }

        /// <summary>
        ///  Adds a sequence of values.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <returns>The sum of the sequence.</returns>
        public static long SumFast(this long[] source)
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
                    sum += v;
                }
            }

            return sum;
        }

        /// <summary>
        /// Adds the transformed sequence of elements.
        /// </summary>
        /// <param name="source">The sequence of values to transform then sum.</param>
        /// <param name="selector">A transformation function.</param>
        /// <returns>The sum of the transformed elements.</returns>
        public static long SumFast<T>(this T[] source, Func<T, long> selector)
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
                    sum += selector(v);
                }
            }

            return sum;
        }

        /// <summary>
        ///  Adds a sequence of values.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <returns>The sum of the sequence.</returns>
        public static float SumFast(this float[] source)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            double sum = 0;

            foreach (var v in source)
            {
                sum += v;
            }

            return (float) sum;
        }

        /// <summary>
        /// Adds the transformed sequence of elements.
        /// </summary>
        /// <param name="source">The sequence of values to transform then sum.</param>
        /// <param name="selector">A transformation function.</param>
        /// <returns>The sum of the transformed elements.</returns>
        public static float SumFast<T>(this T[] source, Func<T, float> selector)
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
                sum += selector(v);
            }

            return (float) sum;
        }

        /// <summary>
        ///  Adds a sequence of values.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <returns>The sum of the sequence.</returns>
        public static double SumFast(this double[] source)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            double sum = 0;
            foreach (var v in source)
            {
                sum += v;
            }

            return sum;
        }

        /// <summary>
        /// Adds the transformed sequence of elements.
        /// </summary>
        /// <param name="source">The sequence of values to transform then sum.</param>
        /// <param name="selector">A transformation function.</param>
        /// <returns>The sum of the transformed elements.</returns>
        public static double SumFast<T>(this T[] source, Func<T, double> selector)
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
                sum += selector(v);
            }

            return sum;
        }

        /// <summary>
        ///  Adds a sequence of values.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <returns>The sum of the sequence.</returns>
        public static decimal SumFast(this decimal[] source)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            decimal sum = 0;

            foreach (var v in source)
            {
                sum += v;
            }

            return sum;
        }

        /// <summary>
        /// Adds the transformed sequence of elements.
        /// </summary>
        /// <param name="source">The sequence of values to transform then sum.</param>
        /// <param name="selector">A transformation function.</param>
        /// <returns>The sum of the transformed elements.</returns>
        public static decimal SumFast<T>(this T[] source, Func<T, decimal> selector)
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
                sum += selector(v);
            }

            return sum;
        }

        #endregion

#if LINQ_SPAN
        #region ------------------------------ Spans ------------------------------

        /// <summary>
        ///  Adds a sequence of values.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <returns>The sum of the sequence.</returns>
        public static int SumFast(this Span<int> source)
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
                    sum += v;
                }
            }

            return sum;
        }

        /// <summary>
        /// Adds the transformed sequence of elements.
        /// </summary>
        /// <param name="source">The sequence of values to transform then sum.</param>
        /// <param name="selector">A transformation function.</param>
        /// <returns>The sum of the transformed elements.</returns>
        public static int SumFast<T>(this Span<T> source, Func<T, int> selector)
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
                    sum += selector(v);
                }
            }

            return sum;
        }

        /// <summary>
        ///  Adds a sequence of values.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <returns>The sum of the sequence.</returns>
        public static long SumFast(this Span<long> source)
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
                    sum += v;
                }
            }

            return sum;
        }

        /// <summary>
        /// Adds the transformed sequence of elements.
        /// </summary>
        /// <param name="source">The sequence of values to transform then sum.</param>
        /// <param name="selector">A transformation function.</param>
        /// <returns>The sum of the transformed elements.</returns>
        public static long SumFast<T>(this Span<T> source, Func<T, long> selector)
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
                    sum += selector(v);
                }
            }

            return sum;
        }

        /// <summary>
        ///  Adds a sequence of values.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <returns>The sum of the sequence.</returns>
        public static float SumFast(this Span<float> source)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            double sum = 0;

            foreach (var v in source)
            {
                sum += v;
            }

            return (float) sum;
        }

        /// <summary>
        /// Adds the transformed sequence of elements.
        /// </summary>
        /// <param name="source">The sequence of values to transform then sum.</param>
        /// <param name="selector">A transformation function.</param>
        /// <returns>The sum of the transformed elements.</returns>
        public static float SumFast<T>(this Span<T> source, Func<T, float> selector)
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
                sum += selector(v);
            }

            return (float) sum;
        }

        /// <summary>
        ///  Adds a sequence of values.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <returns>The sum of the sequence.</returns>
        public static double SumFast(this Span<double> source)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            double sum = 0;
            foreach (var v in source)
            {
                sum += v;
            }

            return sum;
        }

        /// <summary>
        /// Adds the transformed sequence of elements.
        /// </summary>
        /// <param name="source">The sequence of values to transform then sum.</param>
        /// <param name="selector">A transformation function.</param>
        /// <returns>The sum of the transformed elements.</returns>
        public static double SumFast<T>(this Span<T> source, Func<T, double> selector)
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
                sum += selector(v);
            }

            return sum;
        }

        /// <summary>
        ///  Adds a sequence of values.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <returns>The sum of the sequence.</returns>
        public static decimal SumFast(this Span<decimal> source)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            decimal sum = 0;

            foreach (var v in source)
            {
                sum += v;
            }

            return sum;
        }

        /// <summary>
        /// Adds the transformed sequence of elements.
        /// </summary>
        /// <param name="source">The sequence of values to transform then sum.</param>
        /// <param name="selector">A transformation function.</param>
        /// <returns>The sum of the transformed elements.</returns>
        public static decimal SumFast<T>(this Span<T> source, Func<T, decimal> selector)
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
                sum += selector(v);
            }

            return sum;
        }

        #endregion
#endif

        #region ------------------------------ Lists ------------------------------

        /// <summary>
        ///  Adds a sequence of values.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <returns>The sum of the sequence.</returns>
        public static int SumFast(this List<int> source)
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
                    sum += source[i];
                }
            }

            return sum;
        }

        /// <summary>
        /// Adds the transformed sequence of elements.
        /// </summary>
        /// <param name="source">The sequence of values to transform then sum.</param>
        /// <param name="selector">A transformation function.</param>
        /// <returns>The sum of the transformed elements.</returns>
        public static int SumFast<T>(this List<T> source, Func<T, int> selector)
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
                    sum += selector(source[i]);
                }
            }

            return sum;
        }

        /// <summary>
        ///  Adds a sequence of values.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <returns>The sum of the sequence.</returns>
        public static long SumFast(this List<long> source)
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
                    sum += source[i];
                }
            }

            return sum;
        }

        /// <summary>
        /// Adds the transformed sequence of elements.
        /// </summary>
        /// <param name="source">The sequence of values to transform then sum.</param>
        /// <param name="selector">A transformation function.</param>
        /// <returns>The sum of the transformed elements.</returns>
        public static long SumFast<T>(this List<T> source, Func<T, long> selector)
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
                    sum += selector(source[i]);
                }
            }

            return sum;
        }

        /// <summary>
        ///  Adds a sequence of values.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <returns>The sum of the sequence.</returns>
        public static float SumFast(this List<float> source)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            double sum = 0;

            for (int i = 0; i < source.Count; i++)
            {
                sum += source[i];
            }

            return (float) sum;
        }

        /// <summary>
        /// Adds the transformed sequence of elements.
        /// </summary>
        /// <param name="source">The sequence of values to transform then sum.</param>
        /// <param name="selector">A transformation function.</param>
        /// <returns>The sum of the transformed elements.</returns>
        public static float SumFast<T>(this List<T> source, Func<T, float> selector)
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
                sum += selector(source[i]);
            }

            return (float) sum;
        }

        /// <summary>
        ///  Adds a sequence of values.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <returns>The sum of the sequence.</returns>
        public static double SumFast(this List<double> source)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            double sum = 0;
            for (int i = 0; i < source.Count; i++)
            {
                sum += source[i];
            }

            return sum;
        }

        /// <summary>
        /// Adds the transformed sequence of elements.
        /// </summary>
        /// <param name="source">The sequence of values to transform then sum.</param>
        /// <param name="selector">A transformation function.</param>
        /// <returns>The sum of the transformed elements.</returns>
        public static double SumFast<T>(this List<T> source, Func<T, double> selector)
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
                sum += selector(source[i]);
            }

            return sum;
        }

        /// <summary>
        ///  Adds a sequence of values.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <returns>The sum of the sequence.</returns>
        public static decimal SumFast(this List<decimal> source)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            decimal sum = 0;

            for (int i = 0; i < source.Count; i++)
            {
                sum += source[i];
            }

            return sum;
        }

        /// <summary>
        /// Adds the transformed sequence of elements.
        /// </summary>
        /// <param name="source">The sequence of values to transform then sum.</param>
        /// <param name="selector">A transformation function.</param>
        /// <returns>The sum of the transformed elements.</returns>
        public static decimal SumFast<T>(this List<T> source, Func<T, decimal> selector)
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
                sum += selector(source[i]);
            }

            return sum;
        }

        #endregion
    }
}
