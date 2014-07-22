#region License
//
// Terminal.cs
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
    class Terminal
    {
        const string lib = "libc";

        [DllImport(lib, EntryPoint = "isatty", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern bool IsTerminal(int fd);

        [DllImport(lib, EntryPoint = "tcgetattr", CallingConvention = CallingConvention.Cdecl)]
        public static extern int GetAttributes(int fd, out TerminalState state);

        [DllImport(lib, EntryPoint = "tcsetattr", CallingConvention = CallingConvention.Cdecl)]
        public static extern int SetAttributes(int fd, OptionalActions actions, ref TerminalState state);
    }

    [Flags]
    enum InputFlags
    {
        IGNBRK = 1 << 0,
        BRKINT = 1 << 1,
        IGNPAR = 1 << 2,
        PARMRK = 1 << 3,
        INPCK  = 1 << 4,
        ISTRIP = 1 << 5,
        INLCR  = 1 << 6,
        IGNCR  = 1 << 7,
        ICRNL  = 1 << 8,
        IUCLC  = 1 << 9,
        IXON   = 1 << 10,
        IXANY  = 1 << 11,
        IXOFF  = 1 << 12,
        IMAXBEL = 1 << 13,
        IUTF8  = 1 << 14,
    }

    [Flags]
    enum OutputFlags
    {
        OPOST  = 1 << 1,
        OLCUC  = 1 << 2,
        ONLCR  = 1 << 3,
        OCRNL  = 1 << 4,
        ONOCR  = 1 << 5,
        ONLRET = 1 << 6,
        OFILL  = 1 << 7,
        OFDEL  = 1 << 8,
    }

    [Flags]
    enum ControlFlags
    {
        B0 = 0, // hang up
        B50,
        B75,
        B110,
        B134,
        B150,
        B200,
        B300,
        B600,
        B1200,
        B1800,
        B2400,
        B4800,
        B9600,
        B19200,
        B38400,
    }

    [Flags]
    enum LocalFlags
    {
        ISIG = 0x01,
        ICANON = 0x02,
        ECHO = 0x08,
    }

    enum OptionalActions
    {
        NOW = 0,
        DRAIN = 1,
        FLUSH = 2
    }

    [StructLayout(LayoutKind.Sequential)]
    struct TerminalState
    {
        public InputFlags InputMode;
        public OutputFlags OutputMode;
        public ControlFlags ControlMode;
        public LocalFlags LocalMode;
        public byte LineDiscipline;
        public ControlCharacters ControlCharacters;
        public int InputSpeed;
        public int OutputSpeed;
    }

    [StructLayout(LayoutKind.Sequential)]
    struct ControlCharacters
    {
        public byte VINTR;
        public byte VQUIT;
        public byte VERASE;
        public byte VKILL;
        public byte VEOF;
        public byte VTIME;
        public byte VMIN;
        public byte VSWTC;
        public byte VSTART;
        public byte VSTOP;
        public byte VSUSP;
        public byte VEOL;
        public byte VREPRINT;
        public byte VDISCARD;
        public byte VWERASE;
        public byte VLNEXT;
        public byte VEOL2;
        public byte C17;
        public byte C18;
        public byte C19;
        public byte C20;
        public byte C21;
        public byte C22;
        public byte C23;
        public byte C24;
        public byte C25;
        public byte C26;
        public byte C27;
        public byte C28;
        public byte C29;
        public byte C30;
        public byte C31;

    }
}

