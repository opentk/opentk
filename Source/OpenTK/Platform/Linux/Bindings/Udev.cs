// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
using System;
using System.Runtime.InteropServices;

namespace OpenTK.Platform.Linux
{
    class Udev
    {
        const string lib = "libudev";

        [DllImport(lib, EntryPoint = "udev_new", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr New();

        [DllImport(lib, EntryPoint = "udev_destroy", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Destroy(IntPtr Udev);
    }
}

