#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2008 the Open Toolkit library, except where noted.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to 
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//
#endregion

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using OpenTK.Input;

namespace OpenTK.Platform.X11
{
    struct X11JoyDetails { }

    sealed class X11Joystick : IJoystickDriver
    {
        #region Fields

        List<JoystickDevice> sticks = new List<JoystickDevice>();
        IList<JoystickDevice> sticks_readonly;

        bool disposed;

        #endregion

        #region Constructors

        public X11Joystick()
        {
            sticks_readonly = sticks.AsReadOnly();

            int number = 0, max_sticks = 25;
            while (number < max_sticks)
            {
                JoystickDevice stick = OpenJoystick(JoystickPath, number++);
                if (stick != null)
                {
                    stick.Description = String.Format("USB Joystick {0} ({1} axes, {2} buttons, {3}{0})",
                        number, stick.Axis.Count, stick.Button.Count, JoystickPath);
                    sticks.Add(stick);
                }
            }

            number = 0;
            while (number < max_sticks)
            {
                JoystickDevice stick = OpenJoystick(JoystickPathLegacy, number++);
                if (stick != null)
                {
                    stick.Description = String.Format("USB Joystick {0} ({1} axes, {2} buttons, {3}{0})",
                        number, stick.Axis.Count, stick.Button.Count, JoystickPathLegacy);
                    sticks.Add(stick);
                }
            }
        }

        #endregion

        #region IJoystickDriver

        public int DeviceCount
        {
            get { return sticks.Count; }
        }

        public IList<JoystickDevice> Joysticks
        {
            get { return sticks_readonly; }
        }

        public void Poll()
        {
            JoystickEvent e;

            foreach (JoystickDevice js in sticks)
            {
                unsafe
                {
                    while ((long)UnsafeNativeMethods.read(js.Id, (void*)&e, (UIntPtr)sizeof(JoystickEvent)) > 0)
                    {
                        e.Type &= ~JoystickEventType.Init;

                        switch (e.Type)
                        {
                            case JoystickEventType.Axis:
                                // Flip vertical axes so that +1 point up.
                                if (e.Number % 2 == 0)
                                    js.SetAxis((JoystickAxis)e.Number, e.Value / 32767.0f);
                                else
                                    js.SetAxis((JoystickAxis)e.Number, -e.Value / 32767.0f);
                                break;

                            case JoystickEventType.Button:
                                js.SetButton((JoystickButton)e.Number, e.Value != 0);
                                break;
                        }
                    }
                }
            }
        }

        #endregion

        #region Private Members

        JoystickDevice<X11JoyDetails> OpenJoystick(string base_path, int number)
        {
            string path = base_path + number.ToString();
            JoystickDevice<X11JoyDetails> stick = null;

            int fd = -1;
            try
            {
                fd = UnsafeNativeMethods.open(path, OpenFlags.NonBlock);
                if (fd == -1)
                    return null;

                // Check joystick driver version (must be 1.0+)
                int driver_version = 0x00000800;
                UnsafeNativeMethods.ioctl(fd, JoystickIoctlCode.Version, ref driver_version);
                if (driver_version < 0x00010000)
                    return null;

                // Get number of joystick axes
                int axes = 0;
                UnsafeNativeMethods.ioctl(fd, JoystickIoctlCode.Axes, ref axes);

                // Get number of joystick buttons
                int buttons = 0;
                UnsafeNativeMethods.ioctl(fd, JoystickIoctlCode.Buttons, ref buttons);

                stick = new JoystickDevice<X11JoyDetails>(fd, axes, buttons);
                Debug.Print("Found joystick on path {0}", path);
            }
            finally
            {
                if (stick == null && fd != -1)
                    UnsafeNativeMethods.close(fd);
            }

            return stick;
        }

        #region UnsafeNativeMethods

        struct JoystickEvent
        {
            public uint Time;    // (u32) event timestamp in milliseconds
            public short Value;  // (s16) value
            public JoystickEventType Type;    // (u8)  event type
            public byte Number;  // (u8)  axis/button number
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
            Buttons = 0x80016a12
        }

        static readonly string JoystickPath = "/dev/input/js";
        static readonly string JoystickPathLegacy = "/dev/js";

        [Flags]
        enum OpenFlags
        {
            NonBlock = 0x00000800
        }

        static class UnsafeNativeMethods
        {
            [DllImport("libc", SetLastError = true)]
            public static extern int ioctl(int d, JoystickIoctlCode request, ref int data);

            [DllImport("libc", SetLastError = true)]
            public static extern int open([MarshalAs(UnmanagedType.LPStr)]string pathname, OpenFlags flags);

            [DllImport("libc", SetLastError = true)]
            public static extern int close(int fd);

            [DllImport("libc", SetLastError = true)]
            unsafe public static extern IntPtr read(int fd, void* buffer, UIntPtr count);
        }

        #endregion

        #endregion

        #region IDisposable Members

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        void Dispose(bool manual)
        {
            if (!disposed)
            {
                if (manual)
                {
                }

                foreach (JoystickDevice js in sticks)
                {
                    UnsafeNativeMethods.close(js.Id);
                }

                disposed = true;
            }
        }

        ~X11Joystick()
        {
            Dispose(false);
        }

        #endregion
    }
}
