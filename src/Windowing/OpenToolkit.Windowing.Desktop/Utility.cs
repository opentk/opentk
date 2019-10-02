using System;
using System.Text;

namespace OpenToolkit.Windowing.Desktop
{
    /// <summary>
    ///     Internal helper utilities.
    /// </summary>
    internal static class Utility
    {
        // This method can be replaced with Marshal.PtrToStringUTF8,
        // if we ever target .NET Core > 1.1 or .NET Standard > 2.1 explicitly.

        /// <summary>
        ///     Converts a null-terminated UTF-8 string to a <see cref="string" />.
        /// </summary>
        /// <param name="ptr">The pointer to the null-terminated UTF-8 data.</param>
        /// <returns>The string.</returns>
        public static unsafe string PtrToStringUTF8(byte* ptr)
        {
            if (ptr == null)
            {
                return null;
            }

            var length = FindNullTerminator(ptr);

            return Encoding.UTF8.GetString(ptr, length);
        }

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
    }
}
