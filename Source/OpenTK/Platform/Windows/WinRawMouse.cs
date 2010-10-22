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
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using OpenTK.Input;

namespace OpenTK.Platform.Windows
{
    /// \internal
    /// <summary>
    /// Contains methods to register for and process mouse WM_INPUT messages.
    /// </summary>
    internal class WinRawMouse : IMouseDriver
    {
        List<MouseState> mice;
        Dictionary<ContextHandle, int> rawids; // ContextHandle instead of IntPtr for fast dictionary access
        readonly IntPtr Window;

        public WinRawMouse(IntPtr window)
        {
            Debug.WriteLine("Initializing mouse driver (WinRawMouse).");
            Debug.Indent();

            if (window == IntPtr.Zero)
                throw new ArgumentNullException("window");

            Window = window;
            RegisterDevices(window, out mice, out rawids);

            Debug.Unindent();
        }

        #region IMouseDriver Members

        public IList<MouseDevice> Mouse { get { throw new NotImplementedException(); } }

        public MouseState GetState()
        {
            if (mice.Count > 0)
                return mice[0];
            else
                return new MouseState();
        }

        public MouseState GetState(int index)
        {
            if (index < mice.Count)
                return mice[index];
            else
                return new MouseState();
        }

        #endregion

        static int RegisterDevices(IntPtr window, out List<MouseState> mice, out Dictionary<ContextHandle, int> rawids)
        {
            int count = WinRawInput.DeviceCount;
            mice = new List<MouseState>();
            rawids = new Dictionary<ContextHandle, int>();

            RawInputDeviceList[] ridl = new RawInputDeviceList[count];
            for (int i = 0; i < count; i++)
                ridl[i] = new RawInputDeviceList();
            Functions.GetRawInputDeviceList(ridl, ref count, API.RawInputDeviceListSize);

            // Discover mouse devices:
            for (int i = 0; i < count; i++)
            {
                uint size = 0;
                Functions.GetRawInputDeviceInfo(ridl[i].Device, RawInputDeviceInfoEnum.DEVICENAME, IntPtr.Zero, ref size);
                IntPtr name_ptr = Marshal.AllocHGlobal((IntPtr)size);
                Functions.GetRawInputDeviceInfo(ridl[i].Device, RawInputDeviceInfoEnum.DEVICENAME, name_ptr, ref size);
                string name = Marshal.PtrToStringAnsi(name_ptr);
                Marshal.FreeHGlobal(name_ptr);

                if (name.ToLower().Contains("root"))
                {
                    // This is a terminal services device, skip it.
                    continue;
                }
                else if (ridl[i].Type == RawInputDeviceType.MOUSE || ridl[i].Type == RawInputDeviceType.HID)
                {
                    // This is a mouse or a USB mouse device. In the latter case, discover if it really is a
                    // mouse device by qeurying the registry.

                    // remove the \??\
                    name = name.Substring(4);

                    string[] split = name.Split('#');

                    string id_01 = split[0];    // ACPI (Class code)
                    string id_02 = split[1];    // PNP0303 (SubClass code)
                    string id_03 = split[2];    // 3&13c0b0c5&0 (Protocol code)
                    // The final part is the class GUID and is not needed here

                    string findme = string.Format(
                        @"System\CurrentControlSet\Enum\{0}\{1}\{2}",
                        id_01, id_02, id_03);

                    RegistryKey regkey = Registry.LocalMachine.OpenSubKey(findme);

                    string deviceDesc = (string)regkey.GetValue("DeviceDesc");
                    deviceDesc = deviceDesc.Substring(deviceDesc.LastIndexOf(';') + 1);
                    string deviceClass = (string)regkey.GetValue("Class");

                    if (!String.IsNullOrEmpty(deviceClass) && deviceClass.ToLower().Equals("mouse"))
                    {
                        // Register the device:
                        RawInputDeviceInfo info = new RawInputDeviceInfo();
                        int devInfoSize = API.RawInputDeviceInfoSize;
                        Functions.GetRawInputDeviceInfo(ridl[i].Device, RawInputDeviceInfoEnum.DEVICEINFO,
                                info, ref devInfoSize);

                        mice.Add(RegisterRawDevice(deviceDesc, window));
                        rawids.Add(new ContextHandle(ridl[i].Device), mice.Count - 1);
                    }
                }
            }

            return count;
        }

        static MouseState RegisterRawDevice(string device, IntPtr window)
        {
            MouseState state = new MouseState();
            RawInputDevice[] rid = new RawInputDevice[1];
            // Mouse is 1/2 (page/id). See http://www.microsoft.com/whdc/device/input/HID_HWID.mspx
            rid[0] = new RawInputDevice();
            rid[0].UsagePage = 1;
            rid[0].Usage = 2;
            rid[0].Flags = RawInputDeviceFlags.INPUTSINK;
            rid[0].Target = window;

            if (!Functions.RegisterRawInputDevices(rid, 1, API.RawInputDeviceSize))
            {
                throw new ApplicationException(
                    String.Format(
                        "Raw input registration failed with error: {0}. Device: {1}",
                        Marshal.GetLastWin32Error(),
                        rid[0].ToString())
                );
            }
            else
            {
                Debug.Print("Registered mouse {0}", device);
                Point p = new Point();
                if (Functions.GetCursorPos(ref p))
                {
                    state.X = p.X;
                    state.Y = p.Y;
                }
            }

            return state;
        }

        public bool ProcessMouseEvent(RawInput rin)
        {
            if (mice.Count == 0)
                return false;

            RawMouse raw = rin.Data.Mouse;
            ContextHandle handle = new ContextHandle(rin.Header.Device);

            MouseState mouse;
            if (rawids.ContainsKey(handle))
                mouse = mice[rawids[handle]];
            else
                return false;

            if ((raw.ButtonFlags & RawInputMouseState.LEFT_BUTTON_DOWN) != 0) mouse.EnableBit((int)MouseButton.Left);
            if ((raw.ButtonFlags & RawInputMouseState.LEFT_BUTTON_UP) != 0) mouse.DisableBit((int)MouseButton.Left);
            if ((raw.ButtonFlags & RawInputMouseState.RIGHT_BUTTON_DOWN) != 0) mouse.EnableBit((int)MouseButton.Right);
            if ((raw.ButtonFlags & RawInputMouseState.RIGHT_BUTTON_UP) != 0) mouse.DisableBit((int)MouseButton.Right);
            if ((raw.ButtonFlags & RawInputMouseState.MIDDLE_BUTTON_DOWN) != 0) mouse.EnableBit((int)MouseButton.Middle);
            if ((raw.ButtonFlags & RawInputMouseState.MIDDLE_BUTTON_UP) != 0) mouse.DisableBit((int)MouseButton.Middle);
            if ((raw.ButtonFlags & RawInputMouseState.BUTTON_4_DOWN) != 0) mouse.EnableBit((int)MouseButton.Button1);
            if ((raw.ButtonFlags & RawInputMouseState.BUTTON_4_UP) != 0) mouse.DisableBit((int)MouseButton.Button1);
            if ((raw.ButtonFlags & RawInputMouseState.BUTTON_5_DOWN) != 0) mouse.EnableBit((int)MouseButton.Button2);
            if ((raw.ButtonFlags & RawInputMouseState.BUTTON_5_UP) != 0) mouse.DisableBit((int)MouseButton.Button2);

            if ((raw.ButtonFlags & RawInputMouseState.WHEEL) != 0)
                mouse.WheelPrecise += (short)raw.ButtonData / 120.0f;

            if ((raw.Flags & RawMouseFlags.MOUSE_MOVE_ABSOLUTE) != 0)
            {
                mouse.X = raw.LastX;
                mouse.Y = raw.LastY;
            }
            else
            {   // Seems like MOUSE_MOVE_RELATIVE is the default, unless otherwise noted.
                mouse.X += raw.LastX;
                mouse.Y += raw.LastY;
            }

            mice[rawids[handle]] = mouse;
            return true;
        }
    }
}
