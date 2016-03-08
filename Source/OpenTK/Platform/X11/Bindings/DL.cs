// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenTK.Platform.X11
{
    class DL
    {
        const string lib = "dl";

        [DllImport(lib, EntryPoint = "dlopen")]
        internal static extern IntPtr Open(string filename, DLOpenFlags flags);

        [DllImport(lib, EntryPoint = "dlclose")]
        internal static extern int Close(IntPtr handle);

        [DllImport(lib, EntryPoint = "dlsym")]
        internal static extern IntPtr Symbol(IntPtr handle, IntPtr name);
    }

    enum DLOpenFlags
    {
        Lazy = 0x0001,
        Now = 0x0002,
        Global = 0x0100,
        Local = 0x0000,
    }
}
