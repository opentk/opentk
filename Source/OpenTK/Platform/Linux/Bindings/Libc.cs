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
using System.Text;

#pragma warning disable 0649 // field is never assigned

namespace OpenTK.Platform.Linux
{
    partial class Libc
    {
        const string lib = "libc";

        [DllImport(lib)]
        public static extern int dup(int file);

        [DllImport(lib)]
        public static extern int dup2(int file1, int file2);

        [DllImport(lib)]
        public static extern int ioctl(int d, JoystickIoctlCode request, ref int data);

        [DllImport(lib)]
        public static extern int ioctl(int d, JoystickIoctlCode request, StringBuilder data);

        [DllImport(lib)]
        public static extern int ioctl(int d, EvdevIoctlCode request, out EvdevInputId data);

        [DllImport(lib)]
        public static extern int ioctl(int d, KeyboardIoctlCode request, ref IntPtr data);

        [DllImport(lib)]
        public static extern int ioctl(int d, KeyboardIoctlCode request, int data);

        [DllImport(lib)]
        public static extern int open([MarshalAs(UnmanagedType.LPStr)]string pathname, OpenFlags flags);

        [DllImport(lib)]
        public static extern int open(IntPtr pathname, OpenFlags flags);

        [DllImport(lib)]
        public static extern int close(int fd);

        [DllImport(lib)]
        unsafe public static extern IntPtr read(int fd, void* buffer, UIntPtr count);

        public static int read(int fd, out byte b)
        {
            unsafe
            {
                fixed (byte* pb = &b)
                {
                    return read(fd, pb, (UIntPtr)1).ToInt32();
                }
            }
        }

        public static int read(int fd, out short s)
        {
            unsafe
            {
                fixed (short* ps = &s)
                {
                    return read(fd, ps, (UIntPtr)2).ToInt32();
                }
            }
        }

        [DllImport(lib)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool isatty(int fd);
    }

    enum ErrorNumber
    {
        Interrupted = 4,
        Again = 11,
        InvalidValue = 22,
    }

    [Flags]
    enum OpenFlags
    {
        ReadOnly = 0x0000,
        WriteOnly = 0x0001,
        ReadWrite = 0x0002,
        NonBlock = 0x0800,
        CloseOnExec = 0x0080000
    }

    enum EvdevIoctlCode : uint
    {
        Id = ((byte)'E' << 8) | (0x02 << 0) //EVIOCGID, which is _IOR('E', 0x02, struct input_id)
    }

    [Flags]
    enum JoystickEventType : byte
    {
        Button = 0x01,    // button pressed/released
        Axis = 0x02,      // joystick moved
        Init = 0x80       // initial state of device
    }

    enum JoystickIoctlCode : uint
    {
        Version = 0x80046a01,
        Axes = 0x80016a11,
        Buttons = 0x80016a12,
        Name128 = (2u << 30) | (0x6A << 8) | (0x13 << 0) | (128 << 16) //JSIOCGNAME(128), which is _IOC(_IO_READ, 'j', 0x13, len)
    }

    enum KeyboardIoctlCode
    {
        GetMode = 0x4b44,
        SetMode = 0x4b45,
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

    struct EvdevInputId
    {
        public ushort BusType;
        public ushort Vendor;
        public ushort Product;
        public ushort Version;
    }

    struct JoystickEvent
    {
        public uint Time;    // (u32) event timestamp in milliseconds
        public short Value;  // (s16) value
        public JoystickEventType Type;    // (u8)  event type
        public byte Number;  // (u8)  axis/button number
    }
}

