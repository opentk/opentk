using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorV2
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
