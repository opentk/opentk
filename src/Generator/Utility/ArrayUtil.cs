using System;

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
    }
}
