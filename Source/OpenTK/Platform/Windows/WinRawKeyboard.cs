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
using System.Runtime.InteropServices;
using Microsoft.Win32;
using OpenTK.Input;

namespace OpenTK.Platform.Windows
{
    sealed class WinRawKeyboard : IKeyboardDriver2
    {
        static readonly WinKeyMap KeyMap = new WinKeyMap();
        readonly List<KeyboardState> keyboards = new List<KeyboardState>();
        readonly List<string> names = new List<string>();
        readonly Dictionary<ContextHandle, int> rawids = new Dictionary<ContextHandle, int>();
        readonly IntPtr window;
        readonly object UpdateLock = new object();

        #region Constructors

        public WinRawKeyboard(IntPtr windowHandle)
        {
            Debug.WriteLine("Using WinRawKeyboard.");
            Debug.Indent();

            this.window = windowHandle;
            RefreshDevices();

            Debug.Unindent();
        }

        #endregion

        #region Public Members

        public void RefreshDevices()
        {
            lock (UpdateLock)
            {
                for (int i = 0; i < keyboards.Count; i++)
                {
                    KeyboardState state = keyboards[i];
                    state.IsConnected = false;
                    keyboards[i] = state;
                }

                int count = WinRawInput.DeviceCount;
                RawInputDeviceList[] ridl = new RawInputDeviceList[count];
                for (int i = 0; i < count; i++)
                    ridl[i] = new RawInputDeviceList();
                Functions.GetRawInputDeviceList(ridl, ref count, API.RawInputDeviceListSize);

                // Discover keyboard devices:
                foreach (RawInputDeviceList dev in ridl)
                {
                    ContextHandle id = new ContextHandle(dev.Device);
                    if (rawids.ContainsKey(id))
                    {
                        // Device already registered, mark as connected
                        KeyboardState state = keyboards[rawids[id]];
                        state.IsConnected = true;
                        keyboards[rawids[id]] = state;
                        continue;
                    }

                    string name = GetDeviceName(dev);
                    if (name.ToLower().Contains("root"))
                    {
                        // This is a terminal services device, skip it.
                        continue;
                    }
                    else if (dev.Type == RawInputDeviceType.KEYBOARD || dev.Type == RawInputDeviceType.HID)
                    {
                        // This is a keyboard or USB keyboard device. In the latter case, discover if it really is a
                        // keyboard device by qeurying the registry.
                        RegistryKey regkey = GetRegistryKey(name);
                        string deviceDesc = (string)regkey.GetValue("DeviceDesc");
                        string deviceClass = (string)regkey.GetValue("Class");

                        if (String.IsNullOrEmpty(deviceDesc))
                        {
                            Debug.Print("[Warning] Failed to retrieve device description, skipping this device.");
                            continue;
                        }
                        else
                        {
                            deviceDesc = deviceDesc.Substring(deviceDesc.LastIndexOf(';') + 1);
                        }

                        if (!String.IsNullOrEmpty(deviceClass) && deviceClass.ToLower().Equals("keyboard"))
                        {
                            // Register the keyboard:
                            RawInputDeviceInfo info = new RawInputDeviceInfo();
                            int devInfoSize = API.RawInputDeviceInfoSize;
                            Functions.GetRawInputDeviceInfo(dev.Device, RawInputDeviceInfoEnum.DEVICEINFO,
                                    info, ref devInfoSize);

                            //KeyboardDevice kb = new KeyboardDevice();
                            //kb.Description = deviceDesc;
                            //kb.NumberOfLeds = info.Device.Keyboard.NumberOfIndicators;
                            //kb.NumberOfFunctionKeys = info.Device.Keyboard.NumberOfFunctionKeys;
                            //kb.NumberOfKeys = info.Device.Keyboard.NumberOfKeysTotal;
                            //kb.DeviceID = dev.Device;

                            RegisterKeyboardDevice(window, deviceDesc);
                            KeyboardState state = new KeyboardState();
                            state.IsConnected = true;
                            keyboards.Add(state);
                            names.Add(deviceDesc);
                            rawids.Add(new ContextHandle(dev.Device), keyboards.Count - 1);
                        }
                    }
                }
            }
        }

        public bool ProcessKeyboardEvent(RawInput rin)
        {
            bool processed = false;

            bool pressed =
                rin.Data.Keyboard.Message == (int)WindowMessage.KEYDOWN ||
                rin.Data.Keyboard.Message == (int)WindowMessage.SYSKEYDOWN;

            ContextHandle handle = new ContextHandle(rin.Header.Device);
            KeyboardState keyboard;
            if (!rawids.ContainsKey(handle))
            {
                RefreshDevices();
            }

            if (keyboards.Count == 0)
                return false;

            // Note:For some reason, my Microsoft Digital 3000 keyboard reports 0
            // as rin.Header.Device for the "zoom-in/zoom-out" buttons.
            // That's problematic, because no device has a "0" id.
            // As a workaround, we'll add those buttons to the first device (if any).
            int keyboard_handle = rawids.ContainsKey(handle) ? rawids[handle] : 0;
            keyboard = keyboards[keyboard_handle];

            // Generic control, shift, alt keys may be sent instead of left/right.
            // It seems you have to explicitly register left/right events.
            switch (rin.Data.Keyboard.VKey)
            {
                case VirtualKeys.SHIFT:
                    keyboard[Input.Key.ShiftLeft] = keyboard[Input.Key.ShiftRight] = pressed;
                    processed = true;
                    break;

                case VirtualKeys.CONTROL:
                    keyboard[Input.Key.ControlLeft] = keyboard[Input.Key.ControlRight] = pressed;
                    processed = true;
                    break;

                case VirtualKeys.MENU:
                    keyboard[Input.Key.AltLeft] = keyboard[Input.Key.AltRight] = pressed;
                    processed = true;
                    break;

                default:
                    if (!KeyMap.ContainsKey(rin.Data.Keyboard.VKey))
                    {
                        Debug.Print("Virtual key {0} ({1}) not mapped.",
                                    rin.Data.Keyboard.VKey, (int)rin.Data.Keyboard.VKey);
                    }
                    else
                    {
                        keyboard[KeyMap[rin.Data.Keyboard.VKey]] = pressed;
                        processed = true;
                    }
                    break;
            }

            lock (UpdateLock)
            {
                keyboards[keyboard_handle] = keyboard;
                return processed;
            }
        }

        #endregion

        #region Private Members

        static RegistryKey GetRegistryKey(string name)
        {
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
            return regkey;
        }

        static string GetDeviceName(RawInputDeviceList dev)
        {
            uint size = 0;
            Functions.GetRawInputDeviceInfo(dev.Device, RawInputDeviceInfoEnum.DEVICENAME, IntPtr.Zero, ref size);
            IntPtr name_ptr = Marshal.AllocHGlobal((IntPtr)size);
            Functions.GetRawInputDeviceInfo(dev.Device, RawInputDeviceInfoEnum.DEVICENAME, name_ptr, ref size);
            string name = Marshal.PtrToStringAnsi(name_ptr);
            Marshal.FreeHGlobal(name_ptr);
            return name;
        }

        static void RegisterKeyboardDevice(IntPtr window, string name)
        {
            RawInputDevice[] rid = new RawInputDevice[1];
            // Keyboard is 1/6 (page/id). See http://www.microsoft.com/whdc/device/input/HID_HWID.mspx
            rid[0] = new RawInputDevice();
            rid[0].UsagePage = 1;
            rid[0].Usage = 6;
            rid[0].Flags = RawInputDeviceFlags.INPUTSINK;
            rid[0].Target = window;

            if (!Functions.RegisterRawInputDevices(rid, 1, API.RawInputDeviceSize))
            {
                Debug.Print("[Warning] Raw input registration failed with error: {0}. Device: {1}",
                    Marshal.GetLastWin32Error(), rid[0].ToString());
            }
            else
            {
                Debug.Print("Registered keyboard {0}", name);
            }
        }

        #endregion

        #region IKeyboardDriver2 Members

        public KeyboardState GetState()
        {
            lock (UpdateLock)
            {
                KeyboardState master = new KeyboardState();
                foreach (KeyboardState ks in keyboards)
                {
                    master.MergeBits(ks);
                }
                return master;
            }
        }

        public KeyboardState GetState(int index)
        {
            lock (UpdateLock)
            {
                if (keyboards.Count > index)
                    return keyboards[index];
                else
                    return new KeyboardState();
            }
        }

        public string GetDeviceName(int index)
        {
            lock (UpdateLock)
            {
                if (names.Count > index)
                    return names[index];
                else
                    return String.Empty;
            }
        }

        #endregion
    }
}
