using System;
using System.Runtime.InteropServices;

namespace OpenToolkit.Core
{
    internal static class MarshalUtility
    {
        public static unsafe IntPtr StringToCoTaskMemUTF8(string str)
        {
#if NETSTANDARD2_0
            if (str == null)
            {
                return IntPtr.Zero;
            }

            var maxByteLength = System.Text.Encoding.UTF8.GetMaxByteCount(str.Length);

            var ptr = (byte*)Marshal.AllocCoTaskMem(maxByteLength + 1);

            int actualLen;
            fixed (char* pChar = str)
            {
                actualLen = System.Text.Encoding.UTF8.GetBytes(pChar, str.Length, ptr, maxByteLength);
            }
            ptr[actualLen] = 0;

            return (IntPtr)ptr;
#else
            return Marshal.StringToCoTaskMemUTF8(str);
#endif
        }

        /// <summary>
        ///     Converts a null-terminated UTF-8 string to a <see cref="string" />.
        /// </summary>
        /// <param name="ptr">The pointer to the null-terminated UTF-8 data.</param>
        /// <returns>The string.</returns>
        public static unsafe string PtrToStringUTF8(byte* ptr)
        {
#if NETSTANDARD2_0

            if (ptr == null)
            {
                return null;
            }

            var length = FindNullTerminator(ptr);

            return System.Text.Encoding.UTF8.GetString(ptr, length);
#else
            return Marshal.PtrToStringUTF8((IntPtr)ptr);
#endif
        }

#if NETSTANDARD2_0
        private static unsafe int FindNullTerminator(byte* ptr)
        {
            if (ptr == null)
            {
                throw new ArgumentNullException(nameof(ptr));
            }

            var i = 0;
            while (ptr[i] != 0)
            {
                i++;
            }

            return i;
        }
#endif
    }
}
