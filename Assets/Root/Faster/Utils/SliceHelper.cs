#if LINQ_SPAN
using System;

namespace Worldreaver.LinqFaster
{
    public static class SliceHelper
    {
        public static Span<T> Slice<T>(this T[] array, int start, int len)
        {
            return array.AsSpan().Slice(start, len);
        }
    }
}

#endif
