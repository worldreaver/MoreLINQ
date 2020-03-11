using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;


namespace Worldreaver.LinqFaster
{
    //Takes a comparer, and creates a reverse comparer, for Descending sorts
    internal sealed class ComparerReverser<T> : IComparer<T>
    {
        private readonly IComparer<T> _wrappedComparer;

        public ComparerReverser(IComparer<T> wrappedComparer)
        {
            _wrappedComparer = wrappedComparer;
        }
#if !(UNITY_4 || UNITY_5)
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public int Compare(T x, T y)
        {
            return _wrappedComparer.Compare(y, x);
        }
    }

    internal static class ComparerExtensions
    {
        // Lets us reverse a comparere with comparer.Reverse();
        public static IComparer<T> Reverse<T>(this IComparer<T> comparer)
        {
            return new ComparerReverser<T>(comparer);
        }
    }

    internal sealed class LambdaComparer<T, U> : IComparer<T>
    {
        private readonly IComparer<U> _comparer;
        private readonly Func<T, U> _selector;

        public LambdaComparer(Func<T, U> selector, IComparer<U> comparer)
        {
            _comparer = comparer;
            _selector = selector;
        }
#if !(UNITY_4 || UNITY_5)
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public int Compare(T x, T y)
        {
            return _comparer.Compare(_selector(x), _selector(y));
        }
    }

    internal sealed class ReverseLambdaComparer<T, U> : IComparer<T>
    {
        private readonly IComparer<U> _comparer;
        private readonly Func<T, U> _selector;

        public ReverseLambdaComparer(Func<T, U> selector, IComparer<U> comparer)
        {
            _comparer = comparer;
            _selector = selector;
        }
#if !(UNITY_4 || UNITY_5)
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public int Compare(T x, T y)
        {
            return _comparer.Compare(_selector(y), _selector(x));
        }
    }
}
