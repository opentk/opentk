using System;
using System.Runtime.CompilerServices;

namespace OpenTK.Core
{
    public static class Utils
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        public static unsafe string FromTszString(char* ptr, int max_length)
        {
            ReadOnlySpan<char> span = new ReadOnlySpan<char>(ptr, max_length);
            int index = span.IndexOf('\0');
            if (index == -1)
            {
                return new string(ptr, 0, max_length);
            }
            else
            {
                return new string(ptr, 0, index);
            }
        }
    }
}
