using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace OpenTK.Platform.OSX
{
    public static partial class Functions
    {
        internal const string Library = "libdl.dylib";

        #region OSX GetProcAddress

        [DllImport(Library, EntryPoint = "NSIsSymbolNameDefined")]
        internal static extern bool NSIsSymbolNameDefined(string s);
        [DllImport(Library, EntryPoint = "NSLookupAndBindSymbol")]
        internal static extern IntPtr NSLookupAndBindSymbol(string s);
        [DllImport(Library, EntryPoint = "NSAddressOfSymbol")]
        internal static extern IntPtr NSAddressOfSymbol(IntPtr symbol);

        #endregion
    }
}
