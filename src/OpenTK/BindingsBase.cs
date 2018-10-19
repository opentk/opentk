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

namespace OpenTK
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
        /// Gets or sets a <see cref="System.Boolean"/> that indicates whether the list of supported extensions may have changed.
        /// </summary>
        protected bool RebuildExtensionList { get; set; } = true;

        /// <summary>
        /// Retrieves an unmanaged function pointer to the specified function.
        /// </summary>
        /// <param name="funcname">
        /// A <see cref="System.String"/> that defines the name of the function.
        /// </param>
        /// <returns>
        /// A <see cref="IntPtr"/> that contains the address of funcname or IntPtr.Zero,
        /// if the function is not supported by the drivers.
        /// </returns>
        /// <remarks>
        /// Note: some drivers are known to return non-zero values for unsupported functions.
        /// Typical values include 1 and 2 - inheritors are advised to check for and ignore these
        /// values.
        /// </remarks>
        protected abstract IntPtr GetAddress(string funcname);

        /// <summary>
        /// Gets an object that can be used to synchronize access to the bindings implementation.
        /// </summary>
        /// <remarks>This object should be unique across bindings but consistent between bindings
        /// of the same type. For example, ES10.GL, OpenGL.GL and CL10.CL should all return
        /// unique objects, but all instances of ES10.GL should return the same object.</remarks>
        protected abstract object SyncRoot { get; }

        /// <summary>
        /// Marshals a pointer to a null-terminated byte array to a new <see cref="System.String"/>.
        /// This method supports OpenTK and is not intended to be called by user code.
        /// </summary>
        /// <param name="ptr">A pointer to a null-terminated byte array.</param>
        /// <returns>
        /// A <see cref="System.String"/> with the data from <paramref name="ptr"/>.
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
        /// Marshal a <see cref="System.String"/> to unmanaged memory.
        /// The resulting string is encoded in UTF8 and must be freed
        /// with <see cref="FreeStringPtr"/>.
        /// </summary>
        /// <param name="str">The <see cref="System.String"/> to marshal.</param>
        /// <returns>
        /// An unmanaged pointer containing the marshalled string.
        /// This pointer must be freed with <see cref="FreeStringPtr"/>
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
        /// Frees a marshalled string that allocated by <see cref="MarshalStringToPtr"/>.
        /// </summary>
        /// <param name="ptr">An unmanaged pointer allocated with <see cref="MarshalStringToPtr"/></param>
        protected static void FreeStringPtr(IntPtr ptr)
        {
            Marshal.FreeHGlobal(ptr);
        }

        /// <summary>
        /// Marshals a <see cref="System.String"/> array to unmanaged memory by calling
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
        /// Frees a marshalled string that allocated by <see cref="MarshalStringArrayToPtr"/>.
        /// </summary>
        /// <param name="ptr">An unmanaged pointer allocated with <see cref="MarshalStringArrayToPtr"/></param>
        /// <param name="length">The length of the string array.</param>
        protected static void FreeStringArrayPtr(IntPtr ptr, int length)
        {
            for (int i = 0; i < length; i++)
            {
                Marshal.FreeHGlobal(Marshal.ReadIntPtr(ptr, i * IntPtr.Size));
            }
            Marshal.FreeHGlobal(ptr);
        }

        internal abstract void LoadEntryPoints();
    }
}
