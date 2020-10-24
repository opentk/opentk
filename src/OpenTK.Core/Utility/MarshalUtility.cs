using System;
using System.Runtime.InteropServices;

namespace OpenTK.Core
{
    internal static class MarshalUtility
    {
        public static unsafe IntPtr StringToCoTaskMemUTF8(string str)
        {
            return Marshal.StringToCoTaskMemUTF8(str);
        }

        /// <summary>
        ///     Converts a null-terminated UTF-8 string to a <see cref="string" />.
        /// </summary>
        /// <param name="ptr">The pointer to the null-terminated UTF-8 data.</param>
        /// <returns>The string.</returns>
        public static unsafe string PtrToStringUTF8(byte* ptr)
        {
            return Marshal.PtrToStringUTF8((IntPtr)ptr);
        }
    }
}
