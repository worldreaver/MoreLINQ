using System;
using System.Collections.Generic;


namespace Worldreaver.LinqFaster
{
    public static partial class LightweightLinq
    {
        #region ------------------------------ Arrays ------------------------------

        /// <summary>
        /// Computes the average of an array
        /// </summary>
        /// <param name="source">The array to calculate the average of.</param>
        /// <returns>The average of the array.</returns>
        public static double AverageFast(this int[] source)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Length == 0)
            {
                throw NoElements();
            }

            long sum = 0;
            checked
            {
                for (int i = 0; i < source.Length; i++)
                {
                    sum += source[i];
                }
            }

            return (double) sum / source.Length;
        }

        /// <summary>
        /// Computes the average of values obtained by invoking a transform function on
        /// each element of the input array.
        /// </summary>
        /// <param name="source">The array to calculate the transformed average of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The average of the array.</returns>
        public static double AverageFast<T>(this T[] source, Func<T, int> selector)
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

            long sum = 0;
            checked
            {
                for (int i = 0; i < source.Length; i++)
                {
                    sum += selector(source[i]);
                }
            }

            return (double) sum / source.Length;
        }

        /// <summary>
        /// Computes the average of an array
        /// </summary>
        /// <param name="source">The array to calculate the average of.</param>
        /// <returns>The average of the array.</returns>
        public static double AverageFast(this long[] source)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Length == 0)
            {
                throw NoElements();
            }

            long sum = 0;
            checked
            {
                for (int i = 0; i < source.Length; i++)
                {
                    sum += source[i];
                }
            }

            return (double) sum / source.Length;
        }

        /// <summary>
        /// Computes the average of values obtained by invoking a transform function on
        /// each element of the input array.
        /// </summary>
        /// <param name="source">The array to calculate the transformed average of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The average of the array.</returns>
        public static double AverageFast<T>(this T[] source, Func<T, long> selector)
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

            long sum = 0;
            checked
            {
                for (int i = 0; i < source.Length; i++)
                {
                    sum += selector(source[i]);
                }
            }

            return (double) sum / source.Length;
        }

        /// <summary>
        /// Computes the average of an array
        /// </summary>
        /// <param name="source">The array to calculate the average of.</param>
        /// <returns>The average of the array.</returns>
        public static float AverageFast(this float[] source)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Length == 0)
            {
                throw NoElements();
            }

            double sum = 0;

            for (int i = 0; i < source.Length; i++)
            {
                sum += source[i];
            }

            return (float) (sum / source.Length);
        }

        /// <summary>
        /// Computes the average of values obtained by invoking a transform function on
        /// each element of the input array.
        /// </summary>
        /// <param name="source">The array to calculate the transformed average of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The average of the array.</returns>
        public static float AverageFast<T>(this T[] source, Func<T, float> selector)
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

            double sum = 0;

            for (int i = 0; i < source.Length; i++)
            {
                sum += selector(source[i]);
            }

            return (float) (sum / source.Length);
        }

        /// <summary>
        /// Computes the average of an array
        /// </summary>
        /// <param name="source">The array to calculate the average of.</param>
        /// <returns>The average of the array.</returns>
        public static double AverageFast(this double[] source)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Length == 0)
            {
                throw NoElements();
            }

            double sum = 0;

            for (int i = 0; i < source.Length; i++)
            {
                sum += source[i];
            }

            return sum / source.Length;
        }

        /// <summary>
        /// Computes the average of values obtained by invoking a transform function on
        /// each element of the input array.
        /// </summary>
        /// <param name="source">The array to calculate the transformed average of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The average of the array.</returns>
        public static double AverageFast<T>(this T[] source, Func<T, double> selector)
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

            double sum = 0;

            for (int i = 0; i < source.Length; i++)
            {
                sum += selector(source[i]);
            }

            return sum / source.Length;
        }

        /// <summary>
        /// Computes the average of an array
        /// </summary>
        /// <param name="source">The array to calculate the average of.</param>
        /// <returns>The average of the array.</returns>
        public static decimal AverageFast(this decimal[] source)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Length == 0)
            {
                throw NoElements();
            }

            decimal sum = 0;

            for (int i = 0; i < source.Length; i++)
            {
                sum += source[i];
            }

            return sum / source.Length;
        }

        /// <summary>
        /// Computes the average of values obtained by invoking a transform function on
        /// each element of the input array.
        /// </summary>
        /// <param name="source">The array to calculate the transformed average of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The average of the array.</returns>
        public static decimal AverageFast<T>(this T[] source, Func<T, decimal> selector)
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


            decimal sum = 0;

            for (int i = 0; i < source.Length; i++)
            {
                sum += selector(source[i]);
            }

            return sum / source.Length;
        }

        #endregion

#if LINQ_SPAN
        #region ------------------------------ Spans ------------------------------

        /// <summary>
        /// Computes the average of an array
        /// </summary>
        /// <param name="source">The array to calculate the average of.</param>
        /// <returns>The average of the array.</returns>
        public static double AverageFast(this Span<int> source)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Length == 0)
            {
                throw NoElements();
            }

            long sum = 0;
            checked
            {
                for (int i = 0; i < source.Length; i++)
                {
                    sum += source[i];
                }
            }

            return (double) sum / source.Length;
        }

        /// <summary>
        /// Computes the average of values obtained by invoking a transform function on
        /// each element of the input array.
        /// </summary>
        /// <param name="source">The array to calculate the transformed average of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The average of the array.</returns>
        public static double AverageFast<T>(this Span<T> source, Func<T, int> selector)
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

            long sum = 0;
            checked
            {
                for (int i = 0; i < source.Length; i++)
                {
                    sum += selector(source[i]);
                }
            }

            return (double) sum / source.Length;
        }

        /// <summary>
        /// Computes the average of an array
        /// </summary>
        /// <param name="source">The array to calculate the average of.</param>
        /// <returns>The average of the array.</returns>
        public static double AverageFast(this Span<long> source)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Length == 0)
            {
                throw NoElements();
            }

            long sum = 0;
            checked
            {
                for (int i = 0; i < source.Length; i++)
                {
                    sum += source[i];
                }
            }

            return (double) sum / source.Length;
        }

        /// <summary>
        /// Computes the average of values obtained by invoking a transform function on
        /// each element of the input array.
        /// </summary>
        /// <param name="source">The array to calculate the transformed average of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The average of the array.</returns>
        public static double AverageFast<T>(this Span<T> source, Func<T, long> selector)
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

            long sum = 0;
            checked
            {
                for (int i = 0; i < source.Length; i++)
                {
                    sum += selector(source[i]);
                }
            }

            return (double) sum / source.Length;
        }

        /// <summary>
        /// Computes the average of an array
        /// </summary>
        /// <param name="source">The array to calculate the average of.</param>
        /// <returns>The average of the array.</returns>
        public static float AverageFast(this Span<float> source)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Length == 0)
            {
                throw NoElements();
            }

            double sum = 0;

            for (int i = 0; i < source.Length; i++)
            {
                sum += source[i];
            }

            return (float) (sum / source.Length);
        }

        /// <summary>
        /// Computes the average of values obtained by invoking a transform function on
        /// each element of the input array.
        /// </summary>
        /// <param name="source">The array to calculate the transformed average of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The average of the array.</returns>
        public static float AverageFast<T>(this Span<T> source, Func<T, float> selector)
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

            double sum = 0;

            for (int i = 0; i < source.Length; i++)
            {
                sum += selector(source[i]);
            }

            return (float) (sum / source.Length);
        }

        /// <summary>
        /// Computes the average of an array
        /// </summary>
        /// <param name="source">The array to calculate the average of.</param>
        /// <returns>The average of the array.</returns>
        public static double AverageFast(this Span<double> source)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Length == 0)
            {
                throw NoElements();
            }

            double sum = 0;

            for (int i = 0; i < source.Length; i++)
            {
                sum += source[i];
            }

            return sum / source.Length;
        }

        /// <summary>
        /// Computes the average of values obtained by invoking a transform function on
        /// each element of the input array.
        /// </summary>
        /// <param name="source">The array to calculate the transformed average of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The average of the array.</returns>
        public static double AverageFast<T>(this Span<T> source, Func<T, double> selector)
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

            double sum = 0;

            for (int i = 0; i < source.Length; i++)
            {
                sum += selector(source[i]);
            }

            return sum / source.Length;
        }

        /// <summary>
        /// Computes the average of an array
        /// </summary>
        /// <param name="source">The array to calculate the average of.</param>
        /// <returns>The average of the array.</returns>
        public static decimal AverageFast(this Span<decimal> source)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Length == 0)
            {
                throw NoElements();
            }

            decimal sum = 0;

            for (int i = 0; i < source.Length; i++)
            {
                sum += source[i];
            }

            return sum / source.Length;
        }

        /// <summary>
        /// Computes the average of values obtained by invoking a transform function on
        /// each element of the input array.
        /// </summary>
        /// <param name="source">The array to calculate the transformed average of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The average of the array.</returns>
        public static decimal AverageFast<T>(this Span<T> source, Func<T, decimal> selector)
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


            decimal sum = 0;

            for (int i = 0; i < source.Length; i++)
            {
                sum += selector(source[i]);
            }

            return sum / source.Length;
        }

        #endregion
#endif

        #region ------------------------------ Lists ------------------------------

        /// <summary>
        /// Computes the average of a list.
        /// </summary>
        /// <param name="source">The list to calculate the average of.</param>
        /// <returns>The average of the list.</returns>
        public static double AverageFast(this List<int> source)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Count == 0)
            {
                throw NoElements();
            }

            long sum = 0;
            checked
            {
                for (int i = 0; i < source.Count; i++)
                {
                    sum += source[i];
                }
            }

            return (double) sum / source.Count;
        }

        /// <summary>
        /// Computes the average of values obtained by invoking a transform function on
        /// each element of the input array.
        /// </summary>
        /// <param name="source">The array to calculate the transformed average of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The average of the array.</returns>
        public static double AverageFast<T>(this List<T> source, Func<T, int> selector)
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

            long sum = 0;
            checked
            {
                for (int i = 0; i < source.Count; i++)
                {
                    sum += selector(source[i]);
                }
            }

            return (double) sum / source.Count;
        }

        /// <summary>
        /// Computes the average of a list.
        /// </summary>
        /// <param name="source">The list to calculate the average of.</param>
        /// <returns>The average of the list.</returns>
        public static double AverageFast(this List<long> source)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Count == 0)
            {
                throw NoElements();
            }

            long sum = 0;
            checked
            {
                for (int i = 0; i < source.Count; i++)
                {
                    sum += source[i];
                }
            }

            return (double) sum / source.Count;
        }

        /// <summary>
        /// Computes the average of values obtained by invoking a transform function on
        /// each element of the input array.
        /// </summary>
        /// <param name="source">The array to calculate the transformed average of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The average of the array.</returns>
        public static double AverageFast<T>(this List<T> source, Func<T, long> selector)
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

            long sum = 0;
            checked
            {
                for (int i = 0; i < source.Count; i++)
                {
                    sum += selector(source[i]);
                }
            }

            return (double) sum / source.Count;
        }

        /// <summary>
        /// Computes the average of a list.
        /// </summary>
        /// <param name="source">The list to calculate the average of.</param>
        /// <returns>The average of the list.</returns>
        public static float AverageFast(this List<float> source)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Count == 0)
            {
                throw NoElements();
            }

            double sum = 0;

            for (int i = 0; i < source.Count; i++)
            {
                sum += source[i];
            }

            return (float) (sum / source.Count);
        }

        /// <summary>
        /// Computes the average of values obtained by invoking a transform function on
        /// each element of the input array.
        /// </summary>
        /// <param name="source">The array to calculate the transformed average of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The average of the array.</returns>
        public static float AverageFast<T>(this List<T> source, Func<T, float> selector)
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

            double sum = 0;

            for (int i = 0; i < source.Count; i++)
            {
                sum += selector(source[i]);
            }

            return (float) (sum / source.Count);
        }

        /// <summary>
        /// Computes the average of a list.
        /// </summary>
        /// <param name="source">The list to calculate the average of.</param>
        /// <returns>The average of the list.</returns>
        public static double AverageFast(this List<double> source)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Count == 0)
            {
                throw NoElements();
            }

            double sum = 0;

            for (int i = 0; i < source.Count; i++)
            {
                sum += source[i];
            }

            return sum / source.Count;
        }

        /// <summary>
        /// Computes the average of values obtained by invoking a transform function on
        /// each element of the input array.
        /// </summary>
        /// <param name="source">The array to calculate the transformed average of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The average of the array.</returns>
        public static double AverageFast<T>(this List<T> source, Func<T, double> selector)
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

            double sum = 0;

            for (int i = 0; i < source.Count; i++)
            {
                sum += selector(source[i]);
            }

            return sum / source.Count;
        }

        /// <summary>
        /// Computes the average of a list.
        /// </summary>
        /// <param name="source">The list to calculate the average of.</param>
        /// <returns>The average of the list.</returns>
        public static decimal AverageFast(this List<decimal> source)
        {
            if (source == null)
            {
                throw ArgumentNull("source");
            }

            if (source.Count == 0)
            {
                throw NoElements();
            }

            decimal sum = 0;

            for (int i = 0; i < source.Count; i++)
            {
                sum += source[i];
            }

            return sum / source.Count;
        }

        /// <summary>
        /// Computes the average of values obtained by invoking a transform function on
        /// each element of the input array.
        /// </summary>
        /// <param name="source">The array to calculate the transformed average of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The average of the array.</returns>
        public static decimal AverageFast<T>(this List<T> source, Func<T, decimal> selector)
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


            decimal sum = 0;

            for (int i = 0; i < source.Count; i++)
            {
                sum += selector(source[i]);
            }

            return sum / source.Count;
        }

        #endregion
    }
}
