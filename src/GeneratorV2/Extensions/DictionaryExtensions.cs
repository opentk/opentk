using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorV2.Extensions
{
    static class DictionaryExtensions
    {
        /// <summary>
        /// Adds the specified two keys and value to the a nested dictionary.
        /// This method allocates a nested array if needed.
        /// </summary>
        /// <typeparam name="TKey1">Key of the first dictionary.</typeparam>
        /// <typeparam name="TKey2">Key of the second dictionary.</typeparam>
        /// <typeparam name="TValue">The value to store.</typeparam>
        /// <param name="dict">The dictionary with a nested dictionary.</param>
        /// <param name="key1">The first key of the element to add.</param>
        /// <param name="key2">The second key of the element to add.</param>
        /// <param name="value">The value of the element to add.</param>
        public static void AddToNestedDict<TKey1, TKey2, TValue>(this Dictionary<TKey1, Dictionary<TKey2, TValue>> dict, TKey1 key1, TKey2 key2, TValue value)
            where TKey1 : notnull
            where TKey2 : notnull
        {
            if (dict.TryGetValue(key1, out var nestedDict) == false)
            {
                nestedDict = new Dictionary<TKey2, TValue>();
                dict.Add(key1, nestedDict);
            }

            nestedDict.Add(key2, value);
        }
    }
}
