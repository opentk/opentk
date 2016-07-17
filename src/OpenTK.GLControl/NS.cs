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
    internal class NS
    {
        const string Library = "libdl.dylib";

        [DllImport(Library, EntryPoint = "NSIsSymbolNameDefined")]
        static extern bool NSIsSymbolNameDefined(string s);
        [DllImport(Library, EntryPoint = "NSIsSymbolNameDefined")]
        static extern bool NSIsSymbolNameDefined(IntPtr s);
        [DllImport(Library, EntryPoint = "NSLookupAndBindSymbol")]
        static extern IntPtr NSLookupAndBindSymbol(string s);
        [DllImport(Library, EntryPoint = "NSLookupAndBindSymbol")]
        static extern IntPtr NSLookupAndBindSymbol(IntPtr s);
        [DllImport(Library, EntryPoint = "NSAddressOfSymbol")]
        static extern IntPtr NSAddressOfSymbol(IntPtr symbol);
        [DllImport(Library)]
        private static extern IntPtr dlopen(String fileName, int flags);
        [DllImport(Library)]
        private static extern int dlclose(IntPtr handle);
        [DllImport (Library)]
        private static extern IntPtr dlsym (IntPtr handle, string symbol);

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

                IntPtr symbol = GetAddress(ptr);
                return symbol;
            }
            finally
            {
                Marshal.FreeHGlobal(ptr);
            }
        }

        public static IntPtr GetAddress(IntPtr function)
        {
            IntPtr symbol = IntPtr.Zero;
            if (NSIsSymbolNameDefined(function))
            {
                symbol = NSLookupAndBindSymbol(function);
                if (symbol != IntPtr.Zero)
                    symbol = NSAddressOfSymbol(symbol);
            }
            return symbol;
        }

        public static IntPtr GetSymbol(IntPtr handle, string symbol)
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

