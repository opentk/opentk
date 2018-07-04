using System.Collections.Generic;

namespace Bind.Extensions
{
    /// <summary>
    /// Extension methods for the <see cref="KeyValuePair{TKey,TValue}"/> class.
    /// </summary>
    public static class KeyValuePairExtensions
    {
        /// <summary>
        /// Deconstructs a <see cref="KeyValuePair{TKey,TValue}"/> into a value tuple.
        /// </summary>
        /// <param name="tuple">The tuple-like key-value pair.</param>
        /// <param name="key">The key.</param>
        /// <param name="value">The value.</param>
        /// <typeparam name="TKey">The type of the key.</typeparam>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        public static void Deconstruct<TKey, TValue>(this KeyValuePair<TKey, TValue> tuple, out TKey key, out TValue value)
        {
            key = tuple.Key;
            value = tuple.Value;
        }
    }
}
