#region --- License ---
/* Copyright (c) 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

#region --- Using directives ---

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Diagnostics;
using Microsoft.Win32;
using OpenTK.Input;

#endregion

namespace OpenTK.Platform.Windows
{
    internal class WinRawKeyboard : IKeyboardDriver, IDisposable
    {
        private List<KeyboardDevice> keyboards = new List<KeyboardDevice>();
        private IntPtr window;

        #region --- Constructors ---

        internal WinRawKeyboard()
            : this(IntPtr.Zero)
        {
        }

        internal WinRawKeyboard(IntPtr windowHandle)
        {
            Debug.WriteLine("Initializing keyboard driver (WinRawKeyboard).");
            Debug.Indent();

            this.window = windowHandle;

            UpdateKeyboardList();

            Debug.Unindent();
        }

        #endregion

        #region internal static void UpdateKeyboardList()

        internal void UpdateKeyboardList()
        {
            int count = WinRawInput.DeviceCount;
            RawInputDeviceList[] ridl = new RawInputDeviceList[count];
            for (int i = 0; i < count; i++)
                ridl[i] = new RawInputDeviceList();
            Functions.GetRawInputDeviceList(ridl, ref count, API.RawInputDeviceListSize);

            // Discover keyboard devices:
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
                else if (ridl[i].Type == RawInputDeviceType.KEYBOARD || ridl[i].Type == RawInputDeviceType.HID)
                {
                    // This is a keyboard or USB keyboard device. In the latter case, discover if it really is a
                    // keyboard device by qeurying the registry.

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

                    string deviceDesc =
                        (string)regkey.GetValue("DeviceDesc");
                    string deviceClass =
                        (string)regkey.GetValue("Class");
                    if (!String.IsNullOrEmpty(deviceClass) && deviceClass.ToLower().Equals("keyboard"))
                    {
                        KeyboardDevice kb = new KeyboardDevice();
                        kb.Description = deviceDesc;

                        // Register the keyboard:
                        RawInputDeviceInfo info = new RawInputDeviceInfo();
                        int devInfoSize = API.RawInputDeviceInfoSize;
                        Functions.GetRawInputDeviceInfo(ridl[i].Device, RawInputDeviceInfoEnum.DEVICEINFO,
                                info, ref devInfoSize);

                        kb.NumberOfLeds = info.Device.Keyboard.NumberOfIndicators;
                        kb.NumberOfFunctionKeys = info.Device.Keyboard.NumberOfFunctionKeys;
                        kb.NumberOfKeys = info.Device.Keyboard.NumberOfKeysTotal;
                        //kb.DeviceID = (info.Device.Keyboard.Type << 32) + info.Device.Keyboard.SubType;
                        kb.DeviceID = ridl[i].Device;

                        //if (!keyboards.Contains(kb))
                        //{
                            this.RegisterKeyboardDevice(kb);
                            keyboards.Add(kb);
                        //}
                    }
                }
            }
        }

        #endregion

        #region internal void RegisterKeyboardDevice(Keyboard kb)

        internal void RegisterKeyboardDevice(KeyboardDevice kb)
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
                throw new ApplicationException(
                    String.Format(
                        "Raw input registration failed with error: {0}. Device: {1}",
                        Marshal.GetLastWin32Error(),
                        rid[0].ToString())
                );
            }
            else
            {
                Debug.Print("Registered keyboard {0}", kb.ToString());
            }
        }

        #endregion

        #region internal bool ProcessKeyboardEvent(API.RawInput rin)

        /// <summary>
        /// Processes raw input events.
        /// </summary>
        /// <param name="rin"></param>
        /// <returns></returns>
        internal bool ProcessKeyboardEvent(RawInput rin)
        {
            //Keyboard key = keyboards[0];
            //rin.Header.Device;
            switch (rin.Header.Type)
            {
                case RawInputDeviceType.KEYBOARD:
                    bool pressed =
                        rin.Data.Keyboard.Message == (int)WindowMessage.KEYDOWN ||
                        rin.Data.Keyboard.Message == (int)WindowMessage.SYSKEYDOWN;
                    
                    // Find the device where the button was pressed. It can be that the input notification
                    // came not from a physical keyboard device but from a code-generated input message - in
                    // that case, the event goes to the default (first) keyboard.
                    // TODO: Send the event to all keyboards instead of the default one.
                    // TODO: Optimize this! The predicate allocates way to much memory.
                    //int index = keyboards.FindIndex(delegate(KeyboardDevice kb)
                    //{
                    //    return kb.DeviceID == rin.Header.Device;
                    //});
                    //if (index == -1) index = 0;
                    int index;
                    if (keyboards.Count > 0) index = 0;
                    else return false;

                    // Generic control, shift, alt keys may be sent instead of left/right.
                    // It seems you have to explicitly register left/right events.
                    switch (rin.Data.Keyboard.VKey)
                    {
                        case VirtualKeys.SHIFT:
                            keyboards[index][Input.Key.ShiftLeft] = keyboards[index][Input.Key.ShiftRight] = pressed;
                            return true;

                        case VirtualKeys.CONTROL:
                            keyboards[index][Input.Key.ControlLeft] = keyboards[index][Input.Key.ControlRight] = pressed;
                            return true;

                        case VirtualKeys.MENU:
                            keyboards[index][Input.Key.AltLeft] = keyboards[index][Input.Key.AltRight] = pressed;
                            return true;

                        default:
                            if (!WMInput.KeyMap.ContainsKey(rin.Data.Keyboard.VKey))
                                Debug.Print("Virtual key {0} ({1}) not mapped.",
                                            rin.Data.Keyboard.VKey, (int)rin.Data.Keyboard.VKey);
                            else
                                keyboards[index][WMInput.KeyMap[rin.Data.Keyboard.VKey]] = pressed;
                            
                            return false;
                    }

                default:
                    throw new ApplicationException("Windows raw keyboard driver received invalid data.");
            }
        }

        #endregion

        #region --- IInputDevice Members ---

        public string Description
        {
            get { throw new Exception("The method or operation is not implemented."); }
        }

        public Input.InputDeviceType DeviceType
        {
            get { return Input.InputDeviceType.Keyboard; }
        }

        #endregion

        #region --- IKeyboardDriver Members ---

        public IList<KeyboardDevice> Keyboard
        {
            get { return keyboards; }
        }

        #endregion

        #region --- IDisposable Members ---

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
                    keyboards.Clear();
                }
                disposed = true;
            }
        }

        ~WinRawKeyboard()
        {
            Dispose(false);
        }

        #endregion
    }
}
