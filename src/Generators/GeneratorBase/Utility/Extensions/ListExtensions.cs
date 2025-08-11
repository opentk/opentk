using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorBase.Utility.Extensions
{
    public static class ListExtensions
    {
        /// <summary>
        /// Tries to find an element in the list matching the predicate.
        /// </summary>
        /// <remarks>
        /// This function will not work if the predicate tries to find a <see langword="null"/> element.
        /// </remarks>
        /// <typeparam name="T">The generic type of the list.</typeparam>
        /// <param name="list">The list to find the element in.</param>
        /// <param name="match">The predicate for the match.</param>
        /// <param name="result">The found or not found element.</param>
        /// <returns>If the element was found or not.</returns>
        public static bool TryFind<T>(this List<T> list, Predicate<T> match, [NotNullWhen(true)] out T? result)
        {
            result = list.Find(match);
            return result != null;
        }

        public static int CountTrue(params ReadOnlySpan<bool> bools)
        {
            int count = 0;
            foreach (bool b in bools)
            {
                if (b)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
