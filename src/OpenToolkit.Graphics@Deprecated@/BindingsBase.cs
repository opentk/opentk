﻿//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2009 the Open Toolkit library.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//

using System;
using System.Text;
using System.Runtime.InteropServices;

namespace OpenTK.Graphics
{
    /// <summary>
    /// Provides a common foundation for all flat API bindings and implements the extension loading interface.
    /// </summary>
    public abstract class BindingsBase
    {
        /// <summary>
        /// Constructs a new BindingsBase instance.
        /// </summary>
        public BindingsBase()
        {
        }

        /// <summary>
        /// Marshals a pointer to a null-terminated byte array to a new <c>System.String</c>.
        /// This method supports OpenTK and is not intended to be called by user code.
        /// </summary>
        /// <param name="ptr">A pointer to a null-terminated byte array.</param>
        /// <returns>
        /// A <c>System.String</c> with the data from <paramref name="ptr"/>.
        /// </returns>
        protected static string MarshalPtrToString(IntPtr ptr)
        {
            if (ptr == IntPtr.Zero)
            {
                throw new ArgumentException("ptr");
            }

            unsafe
            {
                sbyte* str = (sbyte*)ptr;
                int len = 0;
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
        /// An unmanaged pointer containing the marshalled string.
        /// This pointer must be freed with <c>FreeStringPtr</c>
        /// </returns>
        protected static IntPtr MarshalStringToPtr(string str)
        {
            if (String.IsNullOrEmpty(str))
            {
                return IntPtr.Zero;
            }

            // Allocate a buffer big enough to hold the marshalled string.
            // GetMaxByteCount() appears to allocate space for the final NUL
            // character, but allocate an extra one just in case (who knows
            // what old Mono version would do here.)
            int max_count = Encoding.UTF8.GetMaxByteCount(str.Length) + 1;
            IntPtr ptr = Marshal.AllocHGlobal(max_count);
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
                    int actual_count = Encoding.UTF8.GetBytes(pstr, str.Length, (byte*)ptr, max_count);
                    Marshal.WriteByte(ptr, actual_count, 0); // Append '\0' at the end of the string
                    return ptr;
                }
            }
        }

        /// <summary>
        /// Frees a marshalled string that allocated by <c>MarshalStringToPtr</c>.
        /// </summary>
        /// <param name="ptr">An unmanaged pointer allocated with <c>MarshalStringToPtr</c></param>
        protected static void FreeStringPtr(IntPtr ptr)
        {
            Marshal.FreeHGlobal(ptr);
        }

        /// <summary>
        /// Marshals a <c>System.String</c> array to unmanaged memory by calling
        /// Marshal.AllocHGlobal for each element.
        /// </summary>
        /// <returns>An unmanaged pointer to an array of null-terminated strings</returns>
        /// <param name="str_array">The string array to marshal.</param>
        protected static IntPtr MarshalStringArrayToPtr(string[] str_array)
        {
            IntPtr ptr = IntPtr.Zero;
            if (str_array != null && str_array.Length != 0)
            {
                ptr = Marshal.AllocHGlobal(str_array.Length * IntPtr.Size);
                if (ptr == IntPtr.Zero)
                {
                    throw new OutOfMemoryException();
                }

                int i = 0;
                try
                {
                    for (i = 0; i < str_array.Length; i++)
                    {
                        IntPtr str = MarshalStringToPtr(str_array[i]);
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
        /// Frees a marshalled string that allocated by <c>MarshalStringArrayToPtr</c>.
        /// </summary>
        /// <param name="ptr">An unmanaged pointer allocated with <c>MarshalStringArrayToPtr</c></param>
        /// <param name="length">The length of the string array.</param>
        protected static void FreeStringArrayPtr(IntPtr ptr, int length)
        {
            for (int i = 0; i < length; i++)
            {
                Marshal.FreeHGlobal(Marshal.ReadIntPtr(ptr, i * IntPtr.Size));
            }
            Marshal.FreeHGlobal(ptr);
        }

        private protected static void InitializeDummyEntryPoints(IntPtr[] entryPoints)
        {
            var ptr = Marshal.GetFunctionPointerForDelegate(UninitializedDelegate);

            for (var i = 0; i < entryPoints.Length; i++)
            {
                entryPoints[i] = ptr;
            }
        }

        private static readonly Action UninitializedDelegate = Uninitialized;

        private static void Uninitialized()
        {
            throw new InvalidOperationException("You need to initialize the OpenGL binding first by calling LoadBindings() or creating a compatible OpenGL window.");
        }
    }
}
