//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2010 the Open Toolkit library.
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

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using OpenTK.Core;
using OpenTK.Input;
using OpenTK.NT.Native;

namespace OpenTK.Platform.Windows
{
    internal sealed class WinRawInput : WinInputBase
    {
        private static readonly Guid DeviceInterfaceHid = new Guid("4D1E55B2-F16F-11CF-88CB-001111000030");

        private IntPtr DevNotifyHandle;

        private WinRawJoystick joystick_driver;
        // Input event data.

        private WinRawKeyboard keyboard_driver;
        private WinRawMouse mouse_driver;

        public WinRawInput()
        {
            Debug.WriteLine("Using WinRawInput.");
        }

        public static uint DeviceCount
        {
            get
            {
                uint deviceCount = 0;
                User32.RawInput.GetRawInputDeviceList((RawInputDeviceList[])null, ref deviceCount, RawInputDeviceList.SizeInBytes);
                return deviceCount;
            }
        }

        public override IKeyboardDriver2 KeyboardDriver => keyboard_driver;

        public override IMouseDriver2 MouseDriver => mouse_driver;

        public override IJoystickDriver2 JoystickDriver => joystick_driver;

        private static IntPtr RegisterForDeviceNotifications(WinWindowInfo parent)
        {
            IntPtr dev_notify_handle;
            var bdi = new BroadcastDeviceInterface
            {
                Size = BroadcastDeviceInterface.SizeInBytes,
                DeviceType = DeviceBroadcastType.DeviceInterface,
                ClassGuid = DeviceInterfaceHid
            };

            unsafe
            {
                dev_notify_handle = User32.Device.RegisterDeviceNotification(parent.Handle,
                    new IntPtr(&bdi), DeviceNotificationEnum.WindowHandle);
            }

            if (dev_notify_handle == IntPtr.Zero)
            {
                Debug.Print("[Warning] Failed to register for device notifications. Error: {0}",
                    Marshal.GetLastWin32Error());
            }

            return dev_notify_handle;
        }


        // Processes the input Windows Message, routing the buffer to the correct Keyboard, Mouse or HID.
        protected override IntPtr WindowProcedure(
            IntPtr handle, WindowMessage message, IntPtr wParam, IntPtr lParam)
        {
            try
            {
                switch (message)
                {
                    case WindowMessage.Input:
                    {
                        // Retrieve the raw input data buffer
                        RawInputHeader header;
                        if (User32.RawInput.GetRawInputData(lParam, out header) == RawInputHeader.SizeInBytes)
                        {
                            switch (header.Type)
                            {
                                case RawInputDeviceType.Keyboard:
                                    if (((WinRawKeyboard)KeyboardDriver).ProcessKeyboardEvent(lParam))
                                    {
                                        return IntPtr.Zero;
                                    }

                                    break;

                                case RawInputDeviceType.Mouse:
                                    if (((WinRawMouse)MouseDriver).ProcessMouseEvent(lParam))
                                    {
                                        return IntPtr.Zero;
                                    }

                                    break;

                                case RawInputDeviceType.Hid:
                                    if (((WinRawJoystick)JoystickDriver).ProcessEvent(lParam))
                                    {
                                        return IntPtr.Zero;
                                    }

                                    break;
                            }
                        }

                        break;
                    }
                    case WindowMessage.DeviceChange:
                    {
                        ((WinRawKeyboard)KeyboardDriver).RefreshDevices();
                        ((WinRawMouse)MouseDriver).RefreshDevices();
                        ((WinRawJoystick)JoystickDriver).RefreshDevices();
                        break;
                    }
                }

                return base.WindowProcedure(handle, message, wParam, lParam);
            }
            catch (Exception e)
            {
                Debug.Print("[WinRawInput] Caught unhandled exception {0}", e);
                return IntPtr.Zero;
            }
        }

        protected override void CreateDrivers()
        {
            keyboard_driver = new WinRawKeyboard(Parent.Handle);
            mouse_driver = new WinRawMouse(Parent.Handle);
            joystick_driver = new WinRawJoystick(Parent.Handle);
            DevNotifyHandle = RegisterForDeviceNotifications(Parent);
        }

        protected override void Dispose(bool manual)
        {
            if (!Disposed)
            {
                User32.Device.UnregisterDeviceNotification(DevNotifyHandle);
                base.Dispose(manual);
            }
        }

        public static RawInputDeviceList[] GetDeviceList()
        {
            uint count = DeviceCount;
            var ridl = new RawInputDeviceList[count];
            for (var i = 0; i < count; i++)
            {
                ridl[i] = new RawInputDeviceList();
            }

            User32.RawInput.GetRawInputDeviceList(ridl, ref count, RawInputDeviceList.SizeInBytes);
            return ridl;
        }
    }
}