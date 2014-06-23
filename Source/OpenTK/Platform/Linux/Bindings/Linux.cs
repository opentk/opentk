#region License
//
// Linux.cs
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
    class Linux
    {
        [DllImport("glib", EntryPoint = "open", CallingConvention = CallingConvention.Cdecl)]
        public static extern int Open(string pathname, OpenFlags flags);
    }

    [Flags]
    enum OpenFlags
    {
        ReadOnly = 0,
        WriteOnly = 1,
        ReadWrite = 2,
        CloseOnExec = 4096
    }

    [StructLayout(LayoutKind.Sequential)]
    struct Stat
    {
        public IntPtr dev;     /* ID of device containing file */
        public IntPtr ino;     /* inode number */
        public IntPtr mode;    /* protection */
        public IntPtr nlink;   /* number of hard links */
        public IntPtr uid;     /* user ID of owner */
        public IntPtr gid;     /* group ID of owner */
        public IntPtr rdev;    /* device ID (if special file) */
        public IntPtr size;    /* total size, in bytes */
        public IntPtr blksize; /* blocksize for file system I/O */
        public IntPtr blocks;  /* number of 512B blocks allocated */
        public IntPtr atime;   /* time of last access */
        public IntPtr mtime;   /* time of last modification */
        public IntPtr ctime;   /* time of last status change */
    }
}

