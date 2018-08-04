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
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using OpenTK.Core;
using OpenTK.Input.Hid;
using OpenTK.Input;
using OpenTK.NT.Native;

namespace OpenTK.Platform.Windows
{
    /// \internal
    /// <summary>
    /// Contains methods to register for and process mouse WM_INPUT messages.
    /// </summary>
    internal sealed class WinRawMouse : IMouseDriver2
    {
        private readonly List<MouseState> mice = new List<MouseState>();
        private readonly List<string> names = new List<string>();
        private readonly Dictionary<ContextHandle, int> rawids = new Dictionary<ContextHandle, int>();
        private readonly object UpdateLock = new object();
        private readonly IntPtr Window;

        public WinRawMouse(IntPtr window)
        {
            Debug.WriteLine("Using WinRawMouse.");
            Debug.Indent();

            if (window == IntPtr.Zero)
            {
                throw new ArgumentNullException(nameof(window));
            }

            Window = window;
            RefreshDevices();

            Debug.Unindent();
        }

        public MouseState GetState()
        {
            lock (UpdateLock)
            {
                var master = new MouseState();
                foreach (var ms in mice)
                {
                    master.MergeBits(ms);
                }

                return master;
            }
        }

        public MouseState GetState(int index)
        {
            lock (UpdateLock)
            {
                if (mice.Count > index)
                {
                    return mice[index];
                }

                return new MouseState();
            }
        }

        public void SetPosition(double x, double y)
            => User32.Cursor.SetCursorPos((int)x, (int)y);

        public MouseState GetCursorState()
        {
            // For simplicity, get hardware state
            // and simply overwrite its x and y location
            User32.Cursor.GetCursorPos(out Point p);

            var state = GetState();
            state.X = p.X;
            state.Y = p.Y;
            return state;
        }

        public void RefreshDevices()
        {
            lock (UpdateLock)
            {
                // Mark all devices as disconnected. We will check which of those
                // are connected later on.
                for (var i = 0; i < mice.Count; i++)
                {
                    var state = mice[i];
                    state.IsConnected = false;
                    mice[i] = state;
                }

                // Discover mouse devices
                foreach (var dev in WinRawInput.GetDeviceList())
                {
                    var id = new ContextHandle(dev.Device);
                    if (rawids.ContainsKey(id))
                    {
                        // Device already registered, mark as connected
                        var state = mice[rawids[id]];
                        state.IsConnected = true;
                        mice[rawids[id]] = state;
                        continue;
                    }

                    // Unregistered device, find what it is
                    var name = GetDeviceName(dev);
                    if (name.ToLower().Contains("root"))
                    {
                        // This is a terminal services device, skip it.
                    }
                    else if (dev.Type == RawInputDeviceType.Mouse || dev.Type == RawInputDeviceType.Hid)
                    {
                        // This is a mouse or a USB mouse device. In the latter case, discover if it really is a
                        // mouse device by qeurying the registry.
                        var regkey = FindRegistryKey(name);
                        if (regkey == null)
                        {
                            continue;
                        }

                        var deviceDesc = (string)regkey.GetValue("DeviceDesc");
                        var deviceClass = (string)regkey.GetValue("Class");
                        if (deviceClass == null)
                        {
                            // Added to address OpenTK issue 3198 with mouse on Windows 8
                            var deviceClassGUID = (string)regkey.GetValue("ClassGUID");
                            var classGUIDKey =
                                Registry.LocalMachine.OpenSubKey(
                                    @"SYSTEM\CurrentControlSet\Control\Class\" + deviceClassGUID);
                            deviceClass = classGUIDKey != null ? (string)classGUIDKey.GetValue("Class") : string.Empty;
                        }

                        // deviceDesc remained null on a new Win7 system - not sure why.
                        // Since the description is not vital information, use a dummy description
                        // when that happens.
                        if (string.IsNullOrEmpty(deviceDesc))
                        {
                            deviceDesc = "Windows Mouse " + mice.Count;
                        }
                        else
                        {
                            deviceDesc = deviceDesc.Substring(deviceDesc.LastIndexOf(';') + 1);
                        }

                        if (!string.IsNullOrEmpty(deviceClass) && deviceClass.ToLower().Equals("mouse"))
                        {
                            if (!rawids.ContainsKey(new ContextHandle(dev.Device)))
                            {
                                // Register the device:
                                var info = new RawInputDeviceInfo();
                                var devInfoSize = RawInputDeviceInfo.SizeInBytes;
                                User32.RawInput.GetRawInputDeviceInfo(dev.Device, GetRawInputDeviceInfoEnum.DeviceInfo,
                                    ref info, ref devInfoSize);

                                RegisterRawDevice(Window, deviceDesc);
                                var state = new MouseState();
                                state.IsConnected = true;
                                mice.Add(state);
                                names.Add(deviceDesc);
                                rawids.Add(new ContextHandle(dev.Device), mice.Count - 1);
                            }
                        }
                    }
                }
            }
        }

        public bool ProcessMouseEvent(IntPtr raw_buffer)
        {
            var processed = false;

            RawInput rin;
            if (User32.RawInput.GetRawInputData(raw_buffer, out rin) > 0)
            {
                var raw = rin.Data.Mouse;
                var handle = new ContextHandle(rin.Header.Device);

                MouseState mouse;
                if (!rawids.ContainsKey(handle))
                {
                    RefreshDevices();
                }

                if (mice.Count == 0)
                {
                    return false;
                }

                // Note:For some reason, my Microsoft Digital 3000 keyboard reports 0
                // as rin.Header.Device for the "zoom-in/zoom-out" buttons.
                // That's problematic, because no device has a "0" id.
                // As a workaround, we'll add those buttons to the first device (if any).
                var mouse_handle = rawids.ContainsKey(handle) ? rawids[handle] : 0;
                mouse = mice[mouse_handle];

                // Set and release capture of the mouse to fix http://www.opentk.com/node/2133, Patch by Artfunkel
                if ((raw.ButtonFlags & RawMouseButtonFlags.LeftButtonDown) != 0)
                {
                    mouse.EnableBit((int)MouseButton.Left);
                    User32.Mouse.SetCapture(Window);
                }

                if ((raw.ButtonFlags & RawMouseButtonFlags.LeftButtonUp) != 0)
                {
                    mouse.DisableBit((int)MouseButton.Left);
                    User32.Mouse.ReleaseCapture();
                }

                if ((raw.ButtonFlags & RawMouseButtonFlags.RightButtonDown) != 0)
                {
                    mouse.EnableBit((int)MouseButton.Right);
                    User32.Mouse.SetCapture(Window);
                }

                if ((raw.ButtonFlags & RawMouseButtonFlags.RightButtonUp) != 0)
                {
                    mouse.DisableBit((int)MouseButton.Right);
                    User32.Mouse.ReleaseCapture();
                }

                if ((raw.ButtonFlags & RawMouseButtonFlags.MiddleButtonDown) != 0)
                {
                    mouse.EnableBit((int)MouseButton.Middle);
                    User32.Mouse.SetCapture(Window);
                }

                if ((raw.ButtonFlags & RawMouseButtonFlags.MiddleButtonUp) != 0)
                {
                    mouse.DisableBit((int)MouseButton.Middle);
                    User32.Mouse.ReleaseCapture();
                }

                if ((raw.ButtonFlags & RawMouseButtonFlags.Button4Down) != 0)
                {
                    mouse.EnableBit((int)MouseButton.Button1);
                    User32.Mouse.SetCapture(Window);
                }

                if ((raw.ButtonFlags & RawMouseButtonFlags.Button4Up) != 0)
                {
                    mouse.DisableBit((int)MouseButton.Button1);
                    User32.Mouse.ReleaseCapture();
                }

                if ((raw.ButtonFlags & RawMouseButtonFlags.Button5Down) != 0)
                {
                    mouse.EnableBit((int)MouseButton.Button2);
                    User32.Mouse.SetCapture(Window);
                }

                if ((raw.ButtonFlags & RawMouseButtonFlags.Button5Up) != 0)
                {
                    mouse.DisableBit((int)MouseButton.Button2);
                    User32.Mouse.ReleaseCapture();
                }

                if ((raw.ButtonFlags & RawMouseButtonFlags.Wheel) != 0)
                {
                    mouse.SetScrollRelative(0, (short)raw.ButtonData / 120.0f);
                }

                if ((raw.ButtonFlags & RawMouseButtonFlags.HWheel) != 0)
                {
                    mouse.SetScrollRelative((short)raw.ButtonData / 120.0f, 0);
                }

                if ((raw.Flags & RawMouseFlags.MouseMoveAbsolute) != 0)
                {
                    mouse.X = raw.LastX;
                    mouse.Y = raw.LastY;
                }
                else
                {
                    // Seems like MOUSE_MOVE_RELATIVE is the default, unless otherwise noted.
                    mouse.X += raw.LastX;
                    mouse.Y += raw.LastY;
                }

                lock (UpdateLock)
                {
                    mice[mouse_handle] = mouse;
                    processed = true;
                }
            }

            return processed;
        }

        private static string GetDeviceName(RawInputDeviceList dev)
        {
            // get name size
            uint size = 0;
            User32.RawInput.GetRawInputDeviceInfo(dev.Device, GetRawInputDeviceInfoEnum.DeviceName, IntPtr.Zero, ref size);

            // get actual name
            var name_ptr = Marshal.AllocHGlobal((IntPtr)size);
            User32.RawInput.GetRawInputDeviceInfo(dev.Device, GetRawInputDeviceInfoEnum.DeviceName, name_ptr, ref size);
            string name = Marshal.PtrToStringAnsi(name_ptr);
            Marshal.FreeHGlobal(name_ptr);

            return name;
        }

        private static RegistryKey FindRegistryKey(string name)
        {
            if (name.Length < 4)
                return null;

            // remove the \??\
            name = name.Substring(4);

            var split = name.Split('#');
            if (split.Length < 3)
            {
                return null;
            }

            var id_01 = split[0]; // ACPI (Class code)
            var id_02 = split[1]; // PNP0303 (SubClass code)
            var id_03 = split[2]; // 3&13c0b0c5&0 (Protocol code)
            // The final part is the class GUID and is not needed here

            var findme = $@"System\CurrentControlSet\Enum\{id_01}\{id_02}\{id_03}";

            var regkey = Registry.LocalMachine.OpenSubKey(findme);
            return regkey;
        }

        private static void RegisterRawDevice(IntPtr window, string device)
        {
            var rid = new[]
            {
                new RawInputDevice(HidGenericDesktopUsage.Mouse, RawInputDeviceFlags.InputSink, window)
            };

            if (!User32.RawInput.RegisterRawInputDevices(rid, 1, RawInputDevice.SizeInBytes))
            {
                Debug.Print("[Warning] Raw input registration failed with error: {0}. Device: {1}",
                    Marshal.GetLastWin32Error(), rid[0].ToString());
            }
            else
            {
                Debug.Print("Registered mouse {0}", device);
            }
        }
    }
}
