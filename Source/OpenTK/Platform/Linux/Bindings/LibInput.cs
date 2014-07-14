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

#pragma warning disable 0169, 0219

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

        [DllImport(lib, EntryPoint = "libinput_destroy", CallingConvention = CallingConvention.Cdecl)]
        public static extern void DestroyContext(IntPtr libinput);

        [DllImport(lib, EntryPoint = "libinput_event_destroy", CallingConvention = CallingConvention.Cdecl)]
        public static extern void DestroyEvent(IntPtr @event);

        [DllImport(lib, EntryPoint = "libinput_dispatch", CallingConvention = CallingConvention.Cdecl)]
        public static extern int Dispatch(IntPtr libinput);

        [DllImport(lib, EntryPoint = "libinput_get_event", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr GetEvent(IntPtr libinput);

        [DllImport(lib, EntryPoint = "libinput_event_get_type", CallingConvention = CallingConvention.Cdecl)]
        public static extern InputEventType GetEventType(IntPtr @event);

        [DllImport(lib, EntryPoint = "libinput_get_fd", CallingConvention = CallingConvention.Cdecl)]
        public static extern int GetFD(IntPtr libinput);

        [DllImport(lib, EntryPoint = "libinput_next_event_type", CallingConvention = CallingConvention.Cdecl)]
        public static extern InputEventType NextEventType(IntPtr libinput);

        [DllImport(lib, EntryPoint = "libinput_resume", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Resume(IntPtr libinput);

        [DllImport(lib, EntryPoint = "libinput_suspend", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Suspend(IntPtr libinput);
    }

    enum InputEventType
    {
        None = 0,

        DeviceAdded,
        DeviceRemoved,

        KeyboardKey = 300,

        PointerMotion = 400,
        PointerMotionAbsolute,
        PointerButton,
        PointerAxis,

        TouchDown = 500,
        TouchUP,
        TouchMotion,
        TouchCancel,

        /// \internal
        /// <summary>
        /// Signals the end of a set of touchpoints at one device sample
        /// time. This event has no coordinate information attached.
        /// </summary>
        TouchFrame
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
    }
}

