// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
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

        WinRawKeyboard keyboard_driver;
        WinRawMouse mouse_driver;
        WinRawJoystick joystick_driver;

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
        protected unsafe override IntPtr WindowProcedure(
            IntPtr handle, WindowMessage message, IntPtr wParam, IntPtr lParam)
        {
            try
            {
                switch (message)
                {
                    case WindowMessage.INPUT:
                        {
                            // Retrieve the raw input data buffer
                            RawInputHeader header;
                            if (Functions.GetRawInputData(lParam, out header) == RawInputHeader.SizeInBytes)
                            {
                                switch (header.Type)
                                {
                                    case RawInputDeviceType.KEYBOARD:
                                        if (((WinRawKeyboard)KeyboardDriver).ProcessKeyboardEvent(lParam))
                                            return IntPtr.Zero;
                                        break;

                                    case RawInputDeviceType.MOUSE:
                                        if (((WinRawMouse)MouseDriver).ProcessMouseEvent(lParam))
                                            return IntPtr.Zero;
                                        break;

                                    case RawInputDeviceType.HID:
                                        if (((WinRawJoystick)JoystickDriver).ProcessEvent(lParam))
                                            return IntPtr.Zero;
                                        break;
                                }
                            }
                        }
                        break;

                    case WindowMessage.DEVICECHANGE:
                        ((WinRawKeyboard)KeyboardDriver).RefreshDevices();
                        ((WinRawMouse)MouseDriver).RefreshDevices();
                        ((WinRawJoystick)JoystickDriver).RefreshDevices();
                        break;
                }
                return base.WindowProcedure(handle, message, wParam, lParam);
            }
            catch (Exception e)
            {
                Debug.Print("[WinRawInput] Caught unhandled exception {0}", e);
                return IntPtr.Zero;
            }
        }

        #endregion

        #region CreateDrivers

        protected override void CreateDrivers()
        {
            keyboard_driver = new WinRawKeyboard(Parent.Handle);
            mouse_driver = new WinRawMouse(Parent.Handle);
            joystick_driver = new WinRawJoystick(Parent.Handle);
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

        #region GetDeviceList

        public static RawInputDeviceList[] GetDeviceList()
        {
            int count = WinRawInput.DeviceCount;
            RawInputDeviceList[] ridl = new RawInputDeviceList[count];
            for (int i = 0; i < count; i++)
                ridl[i] = new RawInputDeviceList();
            Functions.GetRawInputDeviceList(ridl, ref count, API.RawInputDeviceListSize);
            return ridl;
        }

        #endregion

        public override IKeyboardDriver2 KeyboardDriver
        {
            get { return keyboard_driver; }
        }

        public override IMouseDriver2 MouseDriver
        {
            get { return mouse_driver; }
        }

        public override IJoystickDriver2 JoystickDriver
        {
            get { return joystick_driver; }
        }

        #endregion
    }
}
