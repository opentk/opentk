// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
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

