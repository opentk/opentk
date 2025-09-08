using System;
using System.Collections.Generic;

namespace GeneratorBase.Utility
{
    public static class ArrayUtil
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

        public static T[] Merge<T>(T[] array1, T[] array2)
        {
            T[] newArray = new T[array1.Length + array2.Length];

            Array.Copy(array1, newArray, array1.Length);
            Array.Copy(array2, 0, newArray, array1.Length, array2.Length);

            return newArray;
        }

        public static T[] MergeDeduplicate<T>(T[] array1, T[] array2) where T : IEquatable<T>
        {
            List<T> newArray = new List<T>();

            newArray.AddRange(array1);

            foreach (T t in array2)
            {
                if (newArray.Contains(t) == false)
                {
                    newArray.Add(t);
                }
            }

            return newArray.ToArray();
        }
    }
}
