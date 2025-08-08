using System.Collections.Generic;

namespace GeneratorBase.Utility.Extensions
{
    public static class DictionaryExtensions
    {
        /// <summary>
        /// Adds the specified two keys and value to the a nested dictionary.
        /// This method allocates a nested dictionary if needed.
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

        /// <summary>
        /// Adds the specified two keys and value to the a nested dictionary.
        /// This method allocates a nested dictionary if needed.
        /// </summary>
        /// <typeparam name="TKey1">Key of the first dictionary.</typeparam>
        /// <typeparam name="TKey2">Key of the second dictionary.</typeparam>
        /// <typeparam name="TValue">The value to store.</typeparam>
        /// <param name="dict">The dictionary with a nested dictionary.</param>
        /// <param name="key1">The first key of the element to add.</param>
        /// <param name="key2">The second key of the element to add.</param>
        /// <param name="value">The value of the element to add.</param>
        public static void AddToNestedDictIfNotPresent<TKey1, TKey2, TValue>(this Dictionary<TKey1, Dictionary<TKey2, TValue>> dict, TKey1 key1, TKey2 key2, TValue value)
            where TKey1 : notnull
            where TKey2 : notnull
        {
            if (dict.TryGetValue(key1, out var nestedDict) == false)
            {
                nestedDict = new Dictionary<TKey2, TValue>();
                dict.Add(key1, nestedDict);
            }

            nestedDict.TryAdd(key2, value);
        }

        /// <summary>
        /// Adds the specified key and value to the a dictionary with a nested hashset.
        /// This method allocates a nested hashset if needed.
        /// </summary>
        /// <typeparam name="TKey">Key of the dictionary.</typeparam>
        /// <typeparam name="TValue">The value to store.</typeparam>
        /// <param name="dict">The dictionary with a nested hashset.</param>
        /// <param name="key">The key of the element to add.</param>
        /// <param name="value">The value of the element to add.</param>
        public static bool AddToNestedHashSet<TKey, TValue>(this Dictionary<TKey, HashSet<TValue>> dict, TKey key, TValue value)
            where TKey : notnull
        {
            if (dict.TryGetValue(key, out var nestedCollection) == false)
            {
                nestedCollection = new HashSet<TValue>();
                dict.Add(key, nestedCollection);
            }
            return nestedCollection.Add(value);
        }

        /// <summary>
        /// Adds the specified key and value to the a dictionary with a nested list.
        /// This method allocates a nested list if needed.
        /// </summary>
        /// <typeparam name="TKey">Key of the dictionary.</typeparam>
        /// <typeparam name="TValue">The value to store.</typeparam>
        /// <param name="dict">The dictionary with a nested list.</param>
        /// <param name="key">The key of the element to add.</param>
        /// <param name="value">The value of the element to add.</param>
        public static void AddToNestedList<TKey, TValue>(this Dictionary<TKey, List<TValue>> dict, TKey key, TValue value)
            where TKey : notnull
        {
            if (dict.TryGetValue(key, out var nestedCollection) == false)
            {
                nestedCollection = new List<TValue>();
                dict.Add(key, nestedCollection);
            }
            nestedCollection.Add(value);
        }

        /// <summary>
        /// Adds the specified key and value to the a dictionary with a nested list.
        /// This method allocates a nested list if needed.
        /// </summary>
        /// <typeparam name="TKey">Key of the dictionary.</typeparam>
        /// <typeparam name="TValue">The value to store.</typeparam>
        /// <param name="dict">The dictionary with a nested list.</param>
        /// <param name="key">The key of the element to add.</param>
        /// <param name="value">The value of the element to add.</param>
        /// <returns>If the value was added to the inner list.</returns>
        public static bool AddToNestedListIfNotPresent<TKey, TValue>(this Dictionary<TKey, List<TValue>> dict, TKey key, TValue value)
            where TKey : notnull
        {
            if (dict.TryGetValue(key, out var nestedCollection) == false)
            {
                nestedCollection = new List<TValue>();
                dict.Add(key, nestedCollection);
            }

            if (nestedCollection.Contains(value) == false)
            {
                nestedCollection.Add(value);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
