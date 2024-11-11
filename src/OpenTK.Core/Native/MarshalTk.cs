using System;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenTK.Core.Native
{
    /// <summary>
    /// Contains extra marshalling utilities that aren't available in the normal Marshal class.
    /// </summary>
    public static class MarshalTk
    {
        /// <summary>
        /// Marshals a pointer to a null-terminated byte array to a new <c>System.String</c>.
        /// This method supports OpenTK and is not intended to be called by user code.
        /// </summary>
        /// <param name="ptr">A pointer to a null-terminated byte array.</param>
        /// <returns>
        /// A <c>System.String</c> with the data from <paramref name="ptr" />.
        /// </returns>
        public static string MarshalPtrToString(IntPtr ptr)
        {
            if (ptr == IntPtr.Zero)
            {
                throw new ArgumentException("ptr");
            }

            unsafe
            {
                var str = (sbyte*)ptr;
                var len = 0;
                while (*str != 0)
                {
                    ++len;
                    ++str;
                }

                return new string((sbyte*)ptr, 0, len, Encoding.UTF8);
            }
        }

        /// <summary>
        /// Marshal a <c>System.String</c> to unmanaged memory.
        /// The resulting string is encoded in UTF8 and must be freed
        /// with <c>FreeStringPtr</c>.
        /// </summary>
        /// <param name="str">The <c>System.String</c> to marshal.</param>
        /// <returns>
        /// An unmanaged pointer containing the marshaled string.
        /// This pointer must be freed with <c>FreeStringPtr</c>.
        /// </returns>
        public static IntPtr MarshalStringToPtr(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return IntPtr.Zero;
            }

            // Allocate a buffer big enough to hold the marshaled string.
            // GetMaxByteCount() appears to allocate space for the final NUL
            // character, but allocate an extra one just in case (who knows
            // what old Mono version would do here.)
            var maxCount = Encoding.UTF8.GetMaxByteCount(str.Length) + 1;
            var ptr = Marshal.AllocHGlobal(maxCount);
            if (ptr == IntPtr.Zero)
            {
                throw new OutOfMemoryException();
            }

            // Pin the managed string and convert it to UTF8 using
            // the pointer overload of System.Encoding.UTF8.GetBytes().
            unsafe
            {
                fixed (char* pstr = str)
                {
                    var actualCount = Encoding.UTF8.GetBytes(pstr, str.Length, (byte*)ptr, maxCount);
                    Marshal.WriteByte(ptr, actualCount, 0); // Append '\0' at the end of the string
                    return ptr;
                }
            }
        }

        /// <summary>
        /// Frees a marshaled string that allocated by <c>MarshalStringToPtr</c>.
        /// </summary>
        /// <param name="ptr">An unmanaged pointer allocated with <c>MarshalStringToPtr</c>.</param>
        public static void FreeStringPtr(IntPtr ptr)
        {
            Marshal.FreeHGlobal(ptr);
        }

        /// <summary>
        /// Marshals a <c>System.String</c> array to unmanaged memory by calling
        /// Marshal.AllocHGlobal for each element.
        /// </summary>
        /// <returns>An unmanaged pointer to an array of null-terminated strings.</returns>
        /// <param name="strArray">The string array to marshal.</param>
        public static IntPtr MarshalStringArrayToPtr(string[] strArray)
        {
            var ptr = IntPtr.Zero;
            if (strArray != null && strArray.Length != 0)
            {
                ptr = Marshal.AllocHGlobal(strArray.Length * IntPtr.Size);
                if (ptr == IntPtr.Zero)
                {
                    throw new OutOfMemoryException();
                }

                var i = 0;
                try
                {
                    for (i = 0; i < strArray.Length; i++)
                    {
                        var str = MarshalStringToPtr(strArray[i]);
                        Marshal.WriteIntPtr(ptr, i * IntPtr.Size, str);
                    }
                }
                catch (OutOfMemoryException)
                {
                    for (i = i - 1; i >= 0; --i)
                    {
                        Marshal.FreeHGlobal(Marshal.ReadIntPtr(ptr, i * IntPtr.Size));
                    }

                    Marshal.FreeHGlobal(ptr);

                    throw;
                }
            }

            return ptr;
        }

        /// <summary>
        /// Frees a marshaled string that allocated by <c>MarshalStringArrayToPtr</c>.
        /// </summary>
        /// <param name="ptr">An unmanaged pointer allocated with <c>MarshalStringArrayToPtr</c>.</param>
        /// <param name="length">The length of the string array.</param>
        public static void FreeStringArrayPtr(IntPtr ptr, int length)
        {
            for (var i = 0; i < length; i++)
            {
                Marshal.FreeHGlobal(Marshal.ReadIntPtr(ptr, i * IntPtr.Size));
            }

            Marshal.FreeHGlobal(ptr);
        }

        /// <summary>
        /// Marshals a <see cref="T:byte**"/> ansi string array into a <see cref="T:string[]"/>.
        /// </summary>
        /// <param name="strArrayPtr">The ansi string array pointer.</param>
        /// <param name="length">The number of strings in the array.</param>
        /// <returns>The managed string array.</returns>
        public static unsafe string[] MarshalAnsiStringArrayPtrToStringArray(byte** strArrayPtr, uint length)
        {
            string[] arr = new string[length];
            for (int i = 0; i < length; i++)
            {
                byte* strPtr = strArrayPtr[i];
                arr[i] = Marshal.PtrToStringAnsi((IntPtr)strPtr);
            }
            return arr;
        }

        /// <summary>
        /// Converts a span of strings into an unmanged ansi string array.
        /// Use <see cref="FreeAnsiStringArrayPtr(byte**, uint)"/> to free the array.
        /// </summary>
        /// <param name="stringArray">The span of strings to marshal.</param>
        /// <param name="count">The number of strings in the unmanged array. The same as the length of the array.</param>
        /// <returns>The unmanaged ansi string array.</returns>
        public static unsafe byte** MarshalStringArrayToAnsiStringArrayPtr(ReadOnlySpan<string> stringArray, out uint count)
        {
            byte** stringArrayPtr = (byte**)NativeMemory.Alloc((nuint)stringArray.Length, (nuint)sizeof(byte*));
            for (int i = 0; i < stringArray.Length; i++)
            {
                stringArrayPtr[i] = (byte*)Marshal.StringToCoTaskMemAnsi(stringArray[i]);
            }
            count = (uint)stringArray.Length;
            return stringArrayPtr;
        }

        /// <summary>
        /// Frees unmanaged ansi string arrays allocated by <see cref="MarshalStringArrayToAnsiStringArrayPtr(ReadOnlySpan{string}, out uint)"/>.
        /// </summary>
        /// <param name="strArrayPtr">The unmanaged ansi string array.</param>
        /// <param name="count">The number of strings in the array.</param>
        public static unsafe void FreeAnsiStringArrayPtr(byte** strArrayPtr, uint count)
        {
            for (int i = 0; i < count; i++)
            {
                Marshal.FreeCoTaskMem((IntPtr)strArrayPtr[i]);
            }
            Marshal.FreeCoTaskMem((IntPtr)strArrayPtr);
        }
    }
}
