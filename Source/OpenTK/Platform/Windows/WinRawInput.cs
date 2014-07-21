#region License
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
#endregion

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using OpenTK.Input;

namespace OpenTK.Platform.Windows
{
    sealed class WinRawInput : WinInputBase
    {
        #region Fields

        // Input event data.
        static RawInput data = new RawInput();

        WinRawKeyboard keyboard_driver;
        WinRawMouse mouse_driver;
        IGamePadDriver gamepad_driver;
        IJoystickDriver2 joystick_driver;

        IntPtr DevNotifyHandle;
        static readonly Guid DeviceInterfaceHid = new Guid("4D1E55B2-F16F-11CF-88CB-001111000030");

        #endregion

        #region Constructors

        public WinRawInput()
            : base()
        {
            Debug.WriteLine("Using WinRawInput.");
        }

        #endregion

        #region Private Members

        static IntPtr RegisterForDeviceNotifications(WinWindowInfo parent)
        {
            IntPtr dev_notify_handle;
            BroadcastDeviceInterface bdi = new BroadcastDeviceInterface();
            bdi.Size = BlittableValueType.StrideOf(bdi);
            bdi.DeviceType = DeviceBroadcastType.INTERFACE;
            bdi.ClassGuid = DeviceInterfaceHid;
            unsafe
            {
                dev_notify_handle = Functions.RegisterDeviceNotification(parent.Handle,
                    new IntPtr((void*)&bdi), DeviceNotification.WINDOW_HANDLE);
            }
            if (dev_notify_handle == IntPtr.Zero)
                Debug.Print("[Warning] Failed to register for device notifications. Error: {0}", Marshal.GetLastWin32Error());

            return dev_notify_handle;
        }


        #endregion

        #region Protected Members

        #region WindowProcedure

        // Processes the input Windows Message, routing the buffer to the correct Keyboard, Mouse or HID.
        protected override IntPtr WindowProcedure(
            IntPtr handle, WindowMessage message, IntPtr wParam, IntPtr lParam)
        {
            switch (message)
            {
                case WindowMessage.INPUT:
                    int size = 0;
                    // Get the size of the input buffer
                    Functions.GetRawInputData(lParam, GetRawInputDataEnum.INPUT,
                        IntPtr.Zero, ref size, API.RawInputHeaderSize);

                    // Read the actual raw input structure
                    if (size == Functions.GetRawInputData(lParam, GetRawInputDataEnum.INPUT,
                        out data, ref size, API.RawInputHeaderSize))
                    {
                        switch (data.Header.Type)
                        {
                            case RawInputDeviceType.KEYBOARD:
                                if (((WinRawKeyboard)KeyboardDriver).ProcessKeyboardEvent(data))
                                    return IntPtr.Zero;
                                break;

                            case RawInputDeviceType.MOUSE:
                                if (((WinRawMouse)MouseDriver).ProcessMouseEvent(data))
                                    return IntPtr.Zero;
                                break;

                            case RawInputDeviceType.HID:
                                break;
                        }
                    }
                    break;

                case WindowMessage.DEVICECHANGE:
                    ((WinRawKeyboard)KeyboardDriver).RefreshDevices();
                    ((WinRawMouse)MouseDriver).RefreshDevices();
                    ((WinMMJoystick)JoystickDriver).RefreshDevices();
                    break;
            }
            return base.WindowProcedure(handle, message, wParam, lParam);
        }

        #endregion

        #region CreateDrivers

        protected override void CreateDrivers()
        {
            keyboard_driver = new WinRawKeyboard(Parent.Handle);
            mouse_driver = new WinRawMouse(Parent.Handle);
            joystick_driver = new WinMMJoystick();
            try
            {
                gamepad_driver = new XInputJoystick();
            }
            catch (Exception)
            {
                Debug.Print("[Win] XInput driver not supported, falling back to WinMM");
                gamepad_driver = new MappedGamePadDriver();
            }

            DevNotifyHandle = RegisterForDeviceNotifications(Parent);
        }

        #endregion

        protected override void Dispose(bool manual)
        {
            if (!Disposed)
            {
                Functions.UnregisterDeviceNotification(DevNotifyHandle);
                base.Dispose(manual);
            }
        }

        #endregion

        #region Public Members

        #region DeviceCount

        public static int DeviceCount
        {
            get
            {
                int deviceCount = 0;
                Functions.GetRawInputDeviceList(null, ref deviceCount, API.RawInputDeviceListSize);
                return deviceCount;
            }
        }

        #endregion

        #endregion

        #region IInputDriver2 Members

        public override IKeyboardDriver2 KeyboardDriver
        {
            get { return keyboard_driver; }
        }

        public override IMouseDriver2 MouseDriver
        {
            get { return mouse_driver; }
        }

        public override IGamePadDriver GamePadDriver
        {
            get { return gamepad_driver; }
        }

        public override IJoystickDriver2 JoystickDriver
        {
            get { return joystick_driver; }
        }

        #endregion
    }
}
