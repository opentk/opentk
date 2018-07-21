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
using OpenTK.Core;
using OpenTK.Input;
using OpenTK.NT.Native;
using OpenTK.Input.Hid;
#if !(ANDROID || IPHONE || MINIMAL)
using Microsoft.Win32;

#endif

namespace OpenTK.Platform.Windows
{
    internal sealed class WinRawKeyboard : IKeyboardDriver2
    {
        private readonly List<KeyboardState> keyboards = new List<KeyboardState>();
        private readonly List<string> names = new List<string>();
        private readonly Dictionary<ContextHandle, int> rawids = new Dictionary<ContextHandle, int>();
        private readonly object UpdateLock = new object();
        private readonly IntPtr window;

        public WinRawKeyboard(IntPtr windowHandle)
        {
            Debug.WriteLine("Using WinRawKeyboard.");
            Debug.Indent();

            window = windowHandle;
            RefreshDevices();

            Debug.Unindent();
        }

        public KeyboardState GetState()
        {
            lock (UpdateLock)
            {
                var master = new KeyboardState();
                foreach (var ks in keyboards)
                    master.MergeBits(ks);

                return master;
            }
        }

        public KeyboardState GetState(int index)
        {
            lock (UpdateLock)
                return keyboards.Count > index ?
                    keyboards[index] :
                    new KeyboardState();
        }

        public string GetDeviceName(int index)
        {
            lock (UpdateLock)
                return names.Count > index ?
                    names[index] :
                    string.Empty;
        }

        public void RefreshDevices()
        {
            lock (UpdateLock)
            {
                for (var i = 0; i < keyboards.Count; i++)
                {
                    var state = keyboards[i];
                    state.IsConnected = false;
                    keyboards[i] = state;
                }

                uint count = WinRawInput.DeviceCount;
                var ridl = new RawInputDeviceList[count];
                for (var i = 0; i < count; i++)
                    ridl[i] = new RawInputDeviceList();

                User32.RawInput.GetRawInputDeviceList(ridl, ref count, RawInputDeviceList.SizeInBytes);

                // Discover keyboard devices:
                foreach (var dev in ridl)
                {
                    var id = new ContextHandle(dev.Device);
                    if (rawids.ContainsKey(id))
                    {
                        // Device already registered, mark as connected
                        var state = keyboards[rawids[id]];
                        state.IsConnected = true;
                        keyboards[rawids[id]] = state;
                        continue;
                    }

                    var name = GetDeviceName(dev);
                    if (name.ToLower().Contains("root"))
                    {
                        // This is a terminal services device, skip it.
                    }
                    else if (dev.Type == RawInputDeviceType.Keyboard || dev.Type == RawInputDeviceType.Hid)
                    {
                        // This is a keyboard or USB keyboard device. In the latter case, discover if it really is a
                        // keyboard device by qeurying the registry.
                        var regkey = GetRegistryKey(name);
                        if (regkey == null)
                            continue;

                        string deviceDesc = (string)regkey.GetValue("DeviceDesc");
                        string deviceClass = (string)regkey.GetValue("Class");
                        string deviceClassGUID =
                            (string)regkey.GetValue("ClassGUID"); // for windows 8 support via OpenTK issue 3198

                        // making a guess at backwards compatability. Not sure what older windows returns in these cases...
                        if (deviceClass == null || deviceClass.Equals(string.Empty))
                        {
                            var classGUIDKey =
                                Registry.LocalMachine.OpenSubKey(
                                    @"SYSTEM\CurrentControlSet\Control\Class\" + deviceClassGUID);
                            deviceClass = classGUIDKey != null ? (string)classGUIDKey.GetValue("Class") : string.Empty;
                        }

                        if (string.IsNullOrEmpty(deviceDesc))
                        {
                            Debug.Print("[Warning] Failed to retrieve device description, skipping this device.");
                            continue;
                        }

                        deviceDesc = deviceDesc.Substring(deviceDesc.LastIndexOf(';') + 1);

                        if (!string.IsNullOrEmpty(deviceClass) && deviceClass.ToLower().Equals("keyboard"))
                        {
                            // Register the keyboard:
                            var info = new RawInputDeviceInfo();
                            var devInfoSize = RawInputDeviceInfo.SizeInBytes;
                            User32.RawInput.GetRawInputDeviceInfo(
                                dev.Device,
                                GetRawInputDeviceInfoEnum.DeviceInfo,
                                ref info,
                                ref devInfoSize
                            );

                            RegisterKeyboardDevice(window, deviceDesc);
                            var state = new KeyboardState { IsConnected = true };
                            keyboards.Add(state);
                            names.Add(deviceDesc);
                            rawids.Add(new ContextHandle(dev.Device), keyboards.Count - 1);
                        }
                    }
                }
            }
        }

        public bool ProcessKeyboardEvent(IntPtr raw)
        {
            var processed = false;

            if (User32.RawInput.GetRawInputData(raw, out RawInput rin) > 0)
            {
                var pressed =
                    rin.Data.Keyboard.Message == (uint)WindowMessage.KeyDown ||
                    rin.Data.Keyboard.Message == (uint)WindowMessage.SystemKeyDown;
                short scancode = (short)rin.Data.Keyboard.MakeCode;
                var vkey = rin.Data.Keyboard.VKey;

                bool extended0 = (int)(rin.Data.Keyboard.Flags & RawKeyboardScanCodeFlags.E0) != 0;
                bool extended1 = (int)(rin.Data.Keyboard.Flags & RawKeyboardScanCodeFlags.E1) != 0;

                var handle = new ContextHandle(rin.Header.Device);
                KeyboardState keyboard;
                if (!rawids.ContainsKey(handle))
                    RefreshDevices();

                if (keyboards.Count == 0)
                    return false;

                // Note:For some reason, my Microsoft Digital 3000 keyboard reports 0
                // as rin.Header.Device for the "zoom-in/zoom-out" buttons.
                // That's problematic, because no device has a "0" id.
                // As a workaround, we'll add those buttons to the first device (if any).
                int keyboard_handle = rawids.ContainsKey(handle) ? rawids[handle] : 0;
                keyboard = keyboards[keyboard_handle];

                var key = WinKeyMap.TranslateKey(scancode, vkey, extended0, extended1, out bool is_valid);

                if (is_valid)
                {
                    keyboard.SetKeyState(key, pressed);
                    processed = true;
                }

                lock (UpdateLock)
                {
                    keyboards[keyboard_handle] = keyboard;
                    processed = true;
                }
            }

            return processed;
        }

        private static RegistryKey GetRegistryKey(string name)
        {
            if (name.Length < 4)
                return null;

            // remove the \??\
            name = name.Substring(4);

            var split = name.Split('#');
            if (split.Length < 3)
                return null;

            var id_01 = split[0]; // ACPI (Class code)
            var id_02 = split[1]; // PNP0303 (SubClass code)
            var id_03 = split[2]; // 3&13c0b0c5&0 (Protocol code)
            // The final part is the class GUID and is not needed here

            var findme = $@"System\CurrentControlSet\Enum\{id_01}\{id_02}\{id_03}";

            var regkey = Registry.LocalMachine.OpenSubKey(findme);
            return regkey;
        }

        private static string GetDeviceName(RawInputDeviceList dev)
        {
            uint size = 0;
            User32.RawInput.GetRawInputDeviceInfo(dev.Device, GetRawInputDeviceInfoEnum.DeviceName, IntPtr.Zero, ref size);
            var name_ptr = Marshal.AllocHGlobal((IntPtr)size);
            User32.RawInput.GetRawInputDeviceInfo(dev.Device, GetRawInputDeviceInfoEnum.DeviceName, name_ptr, ref size);
            var name = Marshal.PtrToStringAnsi(name_ptr);
            Marshal.FreeHGlobal(name_ptr);
            return name;
        }

        private static void RegisterKeyboardDevice(IntPtr window, string name)
        {
            var rid = new[]
            {
                new RawInputDevice(HidGenericDesktopUsage.Keyboard, RawInputDeviceFlags.InputSink, window)
            };

            if (!User32.RawInput.RegisterRawInputDevices(rid, 1, RawInputDevice.SizeInBytes))
            {
                Debug.Print("[Warning] Raw input registration failed with error: {0}. Device: {1}",
                    Marshal.GetLastWin32Error(), rid[0].ToString());
            }
            else
            {
                Debug.Print("Registered keyboard {0}", name);
            }
        }
    }
}