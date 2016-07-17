#region License
//
// NS.cs
//
// Author:
//       Stefanos A. <stapostol@gmail.com>
//
// Copyright (c) 2006-2013 Stefanos Apostolopoulos
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//

#endregion

using System;
using System.Runtime.InteropServices;

namespace OpenTK.Platform.MacOS
{
    [Flags]
    enum AddImageFlags
    {
        ReturnOnError = 1,
        WithSearching = 2,
        ReturnOnlyIfLoaded = 4
    }

    [Flags]
    enum SymbolLookupFlags
    {
        Bind = 0,
        BindNow = 1,
        BindFully = 2,
        ReturnOnError = 4
    }

    internal class NS
    {
        const string Library = "libdl.dylib";

        [DllImport(Library, EntryPoint = "NSAddImage")]
        internal static extern IntPtr AddImage(string s, AddImageFlags flags);
        [DllImport(Library, EntryPoint = "NSAddressOfSymbol")]
        internal static extern IntPtr AddressOfSymbol(IntPtr symbol);
        [DllImport(Library, EntryPoint = "NSIsSymbolNameDefined")]
        internal static extern bool IsSymbolNameDefined(string s);
        [DllImport(Library, EntryPoint = "NSIsSymbolNameDefined")]
        internal static extern bool IsSymbolNameDefined(IntPtr s);
        [DllImport(Library, EntryPoint = "NSLookupAndBindSymbol")]
        internal static extern IntPtr LookupAndBindSymbol(string s);
        [DllImport(Library, EntryPoint = "NSLookupAndBindSymbol")]
        internal static extern IntPtr LookupAndBindSymbol(IntPtr s);
        [DllImport(Library, EntryPoint = "NSLookupSymbolInImage")]
        internal static extern IntPtr LookupSymbolInImage(IntPtr image, IntPtr symbolName, SymbolLookupFlags options);

        // Unfortunately, these are slower even if they are more
        // portable and simpler to use.
        [DllImport(Library)]
        internal static extern IntPtr dlopen(String fileName, int flags);
        [DllImport(Library)]
        internal static extern int dlclose(IntPtr handle);
        [DllImport (Library)]
        internal static extern IntPtr dlsym (IntPtr handle, string symbol);
        [DllImport (Library)]
        internal static extern IntPtr dlsym (IntPtr handle, IntPtr symbol);

        public static IntPtr GetAddress(string function)
        {
            // Instead of allocating and combining strings in managed memory
            // we do that directly in unmanaged memory. This way, we avoid
            // 2 string allocations every time this function is called.

            // must add a '_' prefix and null-terminate the function name,
            // hence we allocate +2 bytes
            IntPtr ptr = Marshal.AllocHGlobal(function.Length + 2);
            try
            {
                Marshal.WriteByte(ptr, (byte)'_');
                for (int i = 0; i < function.Length; i++)
                {
                    Marshal.WriteByte(ptr, i + 1, (byte)function[i]);
                }
                Marshal.WriteByte(ptr, function.Length + 1, 0); // null-terminate

                IntPtr symbol = GetAddressInternal(ptr);
                return symbol;
            }
            finally
            {
                Marshal.FreeHGlobal(ptr);
            }
        }

        public static IntPtr GetAddress(IntPtr function)
        {
            unsafe
            {
                const int max = 64;
                byte* symbol = stackalloc byte[max];
                byte* ptr = symbol;
                byte* cur = (byte*)function.ToPointer();
                int i = 0;

                *ptr++ = (byte)'_';
                while (*cur != 0 && ++i < max)
                {
                    *ptr++ = *cur++;
                }

                if (i >= max - 1)
                {
                    throw new NotSupportedException(String.Format(
                        "Function {0} is too long. Please report a bug at https://github.com/opentk/issues/issues",
                        Marshal.PtrToStringAnsi(function)));
                }

                return GetAddressInternal(new IntPtr(symbol));
            }
        }

        static IntPtr GetAddressInternal(IntPtr function)
        {
            IntPtr symbol = IntPtr.Zero;
            if (IsSymbolNameDefined(function))
            {
                symbol = LookupAndBindSymbol(function);
                if (symbol != IntPtr.Zero)
                    symbol = AddressOfSymbol(symbol);
            }
            return symbol;
        }

        public static IntPtr GetSymbol(IntPtr handle, string symbol)
        {
            return dlsym(handle, symbol);
        }

        public static IntPtr GetSymbol(IntPtr handle, IntPtr symbol)
        {
            return dlsym(handle, symbol);
        }

        public static IntPtr LoadLibrary(string fileName)
        {
            const int RTLD_NOW = 2;
            return dlopen(fileName, RTLD_NOW);
        }

        public static void FreeLibrary(IntPtr handle)
        {
            dlclose(handle);
        }
    }
}

