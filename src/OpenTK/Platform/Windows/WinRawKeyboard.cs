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
#if !(ANDROID || IPHONE || MINIMAL)
using Microsoft.Win32;
#endif
using OpenTK.Input;
using OpenTK.Platform.Common;

namespace OpenTK.Platform.Windows
{
    internal sealed class WinRawKeyboard : IKeyboardDriver2
    {
        private readonly List<KeyboardState> keyboards = new List<KeyboardState>();
        private readonly List<string> names = new List<string>();
        private readonly Dictionary<ContextHandle, int> rawids = new Dictionary<ContextHandle, int>();
        private readonly IntPtr window;
        private readonly object UpdateLock = new object();
        
        public bool UseVirtualKeys { private get; set; }

        public WinRawKeyboard(IntPtr windowHandle)
        {
            Debug.WriteLine("Using WinRawKeyboard.");
            Debug.Indent();

            this.window = windowHandle;
            RefreshDevices();
            //Hook into the session switch event
            SystemEvents.SessionSwitch += (SessionSwitch);
            Debug.Unindent();
        }

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
                {
                    ridl[i] = new RawInputDeviceList();
                }
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
                        if (regkey == null)
                        {
                            continue;
                        }

                        string deviceDesc = (string)regkey.GetValue("DeviceDesc");
                        string deviceClass = (string)regkey.GetValue("Class");
                        string deviceClassGUID = (string)regkey.GetValue("ClassGUID"); // for windows 8 support via OpenTK issue 3198

                        // making a guess at backwards compatability. Not sure what older windows returns in these cases...
                        if (deviceClass == null || deviceClass.Equals(string.Empty)){
                            RegistryKey classGUIDKey = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Control\Class\" + deviceClassGUID);
                            deviceClass = classGUIDKey != null ? (string)classGUIDKey.GetValue("Class") : string.Empty;
                        }

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

        public bool ProcessKeyboardEvent(IntPtr raw)
        {
            bool processed = false;

            RawInput rin;
            if (Functions.GetRawInputData(raw, out rin) > 0)
            {
                bool pressed =
                    rin.Data.Keyboard.Message == (int)WindowMessage.KEYDOWN ||
                    rin.Data.Keyboard.Message == (int)WindowMessage.SYSKEYDOWN;
                var scancode = rin.Data.Keyboard.MakeCode;
                var vkey = rin.Data.Keyboard.VKey;

                bool extended0 = (int)(rin.Data.Keyboard.Flags & RawInputKeyboardDataFlags.E0) != 0;
                bool extended1 = (int)(rin.Data.Keyboard.Flags & RawInputKeyboardDataFlags.E1) != 0;

                bool is_valid = true;

                ContextHandle handle = new ContextHandle(rin.Header.Device);
                KeyboardState keyboard;
                if (!rawids.ContainsKey(handle))
                {
                    RefreshDevices();
                }

                if (keyboards.Count == 0)
                {
                    return false;
                }

                // Note:For some reason, my Microsoft Digital 3000 keyboard reports 0
                // as rin.Header.Device for the "zoom-in/zoom-out" buttons.
                // That's problematic, because no device has a "0" id.
                // As a workaround, we'll add those buttons to the first device (if any).
                int keyboard_handle = rawids.ContainsKey(handle) ? rawids[handle] : 0;
                keyboard = keyboards[keyboard_handle];

                Key key = UseVirtualKeys ?
                    WinKeyMap.TranslateVKey(scancode, vkey, extended0, out is_valid) :
                    WinKeyMap.TranslateKey(scancode, vkey, extended0, extended1, out is_valid);

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
            {
                return null;
            }

            // remove the \??\
            name = name.Substring(4);

            string[] split = name.Split('#');
            if (split.Length < 3)
            {
                return null;
            }

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

        private static string GetDeviceName(RawInputDeviceList dev)
        {
            int size = 0;
            Functions.GetRawInputDeviceInfo(dev.Device, RawInputDeviceInfoEnum.DEVICENAME, IntPtr.Zero, ref size);
            IntPtr name_ptr = Marshal.AllocHGlobal((IntPtr)size);
            Functions.GetRawInputDeviceInfo(dev.Device, RawInputDeviceInfoEnum.DEVICENAME, name_ptr, ref size);
            string name = Marshal.PtrToStringAnsi(name_ptr);
            Marshal.FreeHGlobal(name_ptr);
            return name;
        }

        private static void RegisterKeyboardDevice(IntPtr window, string name)
        {
            RawInputDevice[] rid = new RawInputDevice[]
            {
                new RawInputDevice(HIDUsageGD.Keyboard, RawInputDeviceFlags.INPUTSINK, window)
            };

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
                {
                    return keyboards[index];
                }
                else
                {
                    return new KeyboardState();
                }
            }
        }

        public string GetDeviceName(int index)
        {
            lock (UpdateLock)
            {
                if (names.Count > index)
                {
                    return names[index];
                }
                else
                {
                    return String.Empty;
                }
            }
        }

        private void SessionSwitch(object sender, SessionSwitchEventArgs e)
        {
            /*
             * When locking or unlocking the computer, reset all keyboard states
             * Otherwise, a key which is pressed when the session switch is initiated
             * will remain pressed regardless until it is pressed and released again
             */
            for (int i = 0; i < keyboards.Count; i++)
            {
                keyboards[i] = new KeyboardState();
            }
        }
    }
}
