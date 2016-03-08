// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
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

