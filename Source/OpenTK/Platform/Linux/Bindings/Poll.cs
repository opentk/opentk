#region License
//
// Poll.cs
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
using System.Runtime.InteropServices;

namespace OpenTK.Platform.Linux
{
    partial class Libc
    {
        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public static extern int poll(ref PollFD fd, IntPtr fd_count, int timeout);

        public static int poll(ref PollFD fd, int fd_count, int timeout)
        {
            return poll(ref fd, (IntPtr)fd_count, timeout);
        }
    }

    [Flags]
    enum PollFlags : short
    {
        In = 0x01,
        Pri = 0x02,
        Out = 0x04,
        Error = 0x08,
        Hup = 0x10,
        Invalid = 0x20,
    }

    [StructLayout(LayoutKind.Sequential)]
    struct PollFD
    {
        public int fd;
        public PollFlags events;
        public PollFlags revents;
    }
}

