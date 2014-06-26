#region License
//
// LibInput.cs
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

#pragma warning disable 0169

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace OpenTK.Platform.Linux
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    delegate int OpenRestrictedCallback(IntPtr path, int flags, IntPtr data);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    delegate void CloseRestrictedCallback(int fd, IntPtr data);

    class LibInput
    {
        const string lib = "libinput";

        [DllImport(lib, EntryPoint = "libinput_udev_create_for_seat", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr CreateContext(InputInterface @interface,
            IntPtr user_data, IntPtr udev, string seat_id);
    }

    [StructLayout(LayoutKind.Sequential)]
    class InputInterface
    {
        IntPtr open;
        IntPtr close;

        public InputInterface(
            OpenRestrictedCallback open_restricted,
            CloseRestrictedCallback close_restricted)
        {
            if (open_restricted == null || close_restricted == null)
                throw new ArgumentNullException();

            open = Marshal.GetFunctionPointerForDelegate(open_restricted);
            close = Marshal.GetFunctionPointerForDelegate(close_restricted);
        }

        #region Default implementation

        static CloseRestrictedCallback CloseRestricted = CloseRestrictedHandler;
        static void CloseRestrictedHandler(int fd, IntPtr data)
        {
            Debug.Print("[Input] Closing fd {0}", fd);
            Libc.close(fd);
        }

        static OpenRestrictedCallback OpenRestricted = OpenRestrictedHandler;
        static int OpenRestrictedHandler(IntPtr path, int flags, IntPtr data) 
        {
            Debug.Print("[Input] Opening path '{0}'", Marshal.PtrToStringAnsi(path));
            return Libc.open(path, (OpenFlags)flags);
        }

        public static readonly InputInterface Default = new InputInterface(
            OpenRestricted, CloseRestricted);

        #endregion
    }
}

