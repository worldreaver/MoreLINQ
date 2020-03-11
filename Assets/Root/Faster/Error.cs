using System;

namespace Worldreaver.LinqFaster
{
    public static partial class LightweightLinq
    {
        /// <summary>
        /// argument null exception
        /// </summary>
        /// <param name="argumentName"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        internal static Exception ArgumentNull(string argumentName, string message = "")
        {
            return new ArgumentNullException(argumentName, message);
        }

        /// <summary>
        /// agument out of range exception
        /// </summary>
        /// <param name="argumentName"></param>
        /// <returns></returns>
        internal static Exception ArgumentOutOfRange(string argumentName)
        {
            return new ArgumentOutOfRangeException(argumentName);
        }

        /// <summary>
        /// sequence contains more than one element exception
        /// </summary>
        /// <returns></returns>
        internal static Exception MoreThanOneElement()
        {
            return new InvalidOperationException("Sequence contains more than one element");
        }

        /// <summary>
        /// sequence contains more than one matching element exception
        /// </summary>
        /// <returns></returns>
        internal static Exception MoreThanOneMatch()
        {
            return new InvalidOperationException("Sequence contains more than one matching element");
        }

        /// <summary>
        /// sequence contains no elements exception
        /// </summary>
        /// <returns></returns>
        internal static Exception NoElements()
        {
            return new InvalidOperationException("Sequence contains no elements");
        }

        /// <summary>
        /// sequence contains no matching element exception
        /// </summary>
        /// <returns></returns>
        internal static Exception NoMatch()
        {
            return new InvalidOperationException("Sequence contains no matching element");
        }

        /// <summary>
        /// not support exception
        /// </summary>
        /// <returns></returns>
        internal static Exception NotSupported()
        {
            return new NotSupportedException();
        }
    }
}
