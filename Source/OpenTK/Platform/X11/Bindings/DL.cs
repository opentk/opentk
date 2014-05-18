#region License
//
// DL.cs
//
// Author:
//       Stefanos A. <stapostol@gmail.com>
//
// Copyright (c) 2006-2014 Stefanos Apostolopoulos
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
