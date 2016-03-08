// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
using System;
using System.Runtime.InteropServices;

namespace OpenTK.Platform.Linux
{
    class Kms
    {
        const string lib = "libkms";

        [DllImport(lib, EntryPoint = "kms_bo_map", CallingConvention = CallingConvention.Cdecl)]
        public static extern int MapBuffer(IntPtr bo, out IntPtr @out);

        [DllImport(lib, EntryPoint = "kms_bo_unmap", CallingConvention = CallingConvention.Cdecl)]
        public static extern int UnmapBuffer(IntPtr bo);
    }
}

