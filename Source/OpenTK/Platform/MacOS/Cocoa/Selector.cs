// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
using System;
using System.Runtime.InteropServices;

namespace OpenTK.Platform.MacOS
{
    static class Selector
    {
        // Frequently used selectors
        public static readonly IntPtr Init = Selector.Get("init");
        public static readonly IntPtr InitWithCoder = Selector.Get("initWithCoder:");
        public static readonly IntPtr Alloc = Selector.Get("alloc");
        public static readonly IntPtr Retain = Selector.Get("retain");
        public static readonly IntPtr Release = Selector.Get("release");
        public static readonly IntPtr Autorelease = Selector.Get("autorelease");

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint="sel_registerName")]
		public extern static IntPtr Get(string name);
	}
}
