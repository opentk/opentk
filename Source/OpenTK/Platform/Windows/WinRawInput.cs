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

#region --- Using directives ---

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Windows.Forms;
using OpenTK.Input;
using System.Threading;

#endregion

namespace OpenTK.Platform.Windows
{
    // Not complete.
    sealed class WinRawInput : IInputDriver2
    {
        // Input event data.
        static RawInput data = new RawInput();
        static readonly int rawInputStructSize = API.RawInputSize;
        static readonly Thread InputThread = new Thread(ProcessEvents);

        static WinRawKeyboard keyboardDriver;
        static WinRawMouse mouseDriver;
        static readonly WinMMJoystick joystickDriver = new WinMMJoystick();

        static INativeWindow Native;
        static WinWindowInfo Parent { get { return Native.WindowInfo as WinWindowInfo; } }
        static readonly WindowProcedure WndProc = WindowProcedureImplementation;
        static IntPtr OldWndProc;
        
        static IntPtr DevNotifyHandle;
        static readonly Guid DeviceInterfaceHid = new Guid("4D1E55B2-F16F-11CF-88CB-001111000030");

        #region Constructors

        public WinRawInput()
        {
            InputThread.IsBackground = true;
            InputThread.Start();

            while (mouseDriver == null || keyboardDriver == null)
                Thread.Sleep(0);
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

        #region Private Members

        #region ConstructMessageWindow

        static INativeWindow ConstructMessageWindow()
        {
            Debug.WriteLine("Initializing windows raw input driver.");
            Debug.Indent();

            // Create a new message-only window to retrieve WM_INPUT messages.
            Native = new NativeWindow();
            Native.ProcessEvents();
            Functions.SetParent(Parent.WindowHandle, Constants.MESSAGE_ONLY);
            Native.ProcessEvents();
            RegisterForDeviceNotifications();

            // Subclass the window to retrieve the events we are interested in.
            OldWndProc = Functions.SetWindowLong(Parent.WindowHandle, WndProc);

            Debug.Print("Input window attached to parent {0}", Parent);
            keyboardDriver = new WinRawKeyboard(Parent.WindowHandle);
            mouseDriver = new WinRawMouse(Parent.WindowHandle);

            Debug.Unindent();
            return Native;
        }

        static void RegisterForDeviceNotifications()
        {
            BroadcastDeviceInterface bdi = new BroadcastDeviceInterface();
            bdi.Size = BlittableValueType.StrideOf(bdi);
            bdi.DeviceType = DeviceBroadcastType.INTERFACE;
            bdi.ClassGuid = DeviceInterfaceHid;
            unsafe
            {
                DevNotifyHandle = Functions.RegisterDeviceNotification(Parent.WindowHandle,
                    new IntPtr((void*)&bdi), DeviceNotification.WINDOW_HANDLE);
            }
            if (DevNotifyHandle == IntPtr.Zero)
                Debug.Print("[Warning] Failed to register for device notifications. Error: {0}", Marshal.GetLastWin32Error());
        }

        #endregion

        #region WindowProcedureImplementation

        // Processes the input Windows Message, routing the buffer to the correct Keyboard, Mouse or HID.
        static IntPtr WindowProcedureImplementation(IntPtr handle, WindowMessage message, IntPtr wParam, IntPtr lParam)
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
                                if (keyboardDriver.ProcessKeyboardEvent(data))
                                    return IntPtr.Zero;
                                break;

                            case RawInputDeviceType.MOUSE:
                                if (mouseDriver.ProcessMouseEvent(data))
                                    return IntPtr.Zero;
                                break;

                            case RawInputDeviceType.HID:
                                break;
                        }
                    }
                    break;

                case WindowMessage.DEVICECHANGE:
                    mouseDriver.RefreshDevices();
                    break;
            }
            return Functions.CallWindowProc(OldWndProc, handle, message, wParam, lParam);
        }

        #endregion

        #region ProcessEvents

        static void ProcessEvents()
        {
            INativeWindow native = ConstructMessageWindow();

            MSG msg = new MSG();
            while (native.Exists)
            {
                int ret = Functions.GetMessage(ref msg, Parent.WindowHandle, 0, 0);
                if (ret == -1)
                {
                    throw new PlatformException(String.Format(
                        "An error happened while processing the message queue. Windows error: {0}",
                        Marshal.GetLastWin32Error()));
                }

                Functions.TranslateMessage(ref msg);
                Functions.DispatchMessage(ref msg);
            }
        }

        #endregion

        #endregion

        #region IInputDriver2 Members

        public IMouseDriver2 MouseDriver
        {
            get { return mouseDriver; }
        }

        public IKeyboardDriver2 KeyboardDriver
        {
            get { return keyboardDriver; }
        }

        public IGamePadDriver GamePadDriver
        {
            get { return joystickDriver; }
        }

        #endregion

        #region IDisposable Members

        private bool disposed;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool manual)
        {
            if (!disposed)
            {
                if (manual)
                {
                }

                Functions.UnregisterDeviceNotification(DevNotifyHandle);
                disposed = true;
            }
        }

        ~WinRawInput()
        {
            Debug.Print("[Warning] Resource leaked: {0}.", this);
            Dispose(false);
        }

        #endregion
    }
}
