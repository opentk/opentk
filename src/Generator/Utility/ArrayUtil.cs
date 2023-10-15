using System;
using System.Collections.Generic;

namespace Generator.Utility
{
    static class ArrayUtil
    {
        public static T[] MakeCopyAndGrow<T>(this T[] array, int additionalElements)
        {
            T[] newArray = new T[array.Length + additionalElements];
            Array.Copy(array, newArray, array.Length);
            return newArray;
        }

        public static string? GetMatching(this string[] array, HashSet<string> strings)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (strings.Contains(array[i]))
                {
                    return array[i];
                }
            }
            return null;
        }
    }
}
