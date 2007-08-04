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
    internal class WinRawKeyboard : IKeyboardDriver
    {
        private List<Keyboard> keyboards = new List<Keyboard>();
        private IntPtr windowHandle;

        #region internal static Dictionary<API.VirtualKeys, Input.Keys> KeyMap

        internal static Dictionary<API.VirtualKeys, Input.Keys> KeyMap =
            new Dictionary<API.VirtualKeys, Input.Keys>((int)API.VirtualKeys.Last);

        private static bool keyMapExists;
        /// <summary>
        /// Initializes the map between VirtualKeys and OpenTK.Keys
        /// </summary>
        private static void InitKeyMap()
        {
            if (!keyMapExists)
            {
                try
                {
                    KeyMap.Add(API.VirtualKeys.ESCAPE, Input.Keys.Escape);

                    // Function keys
                    for (int i = 0; i < 24; i++)
                    {
                        KeyMap.Add((API.VirtualKeys)((int)API.VirtualKeys.F1 + i), Input.Keys.F1 + i);
                    }

                    // Number keys (0-9)
                    for (int i = 0; i <= 9; i++)
                    {
                        KeyMap.Add((API.VirtualKeys)(0x30 + i), Input.Keys.Number0 + i);
                    }

                    // Letters (A-Z)
                    for (int i = 0; i < 26; i++)
                    {
                        KeyMap.Add((API.VirtualKeys)(0x41 + i), Input.Keys.A + i);
                    }

                    KeyMap.Add(API.VirtualKeys.TAB, Input.Keys.Tab);
                    KeyMap.Add(API.VirtualKeys.CAPITAL, Input.Keys.CapsLock);
                    KeyMap.Add(API.VirtualKeys.LCONTROL, Input.Keys.LeftControl);
                    KeyMap.Add(API.VirtualKeys.LSHIFT, Input.Keys.LeftShift);
                    KeyMap.Add(API.VirtualKeys.LWIN, Input.Keys.LeftApp);
                    KeyMap.Add(API.VirtualKeys.LMENU, Input.Keys.LeftAlt);
                    KeyMap.Add(API.VirtualKeys.SPACE, Input.Keys.Space);
                    KeyMap.Add(API.VirtualKeys.RMENU, Input.Keys.RightAlt);
                    KeyMap.Add(API.VirtualKeys.RWIN, Input.Keys.RightApp);
                    KeyMap.Add(API.VirtualKeys.APPS, Input.Keys.Menu);
                    KeyMap.Add(API.VirtualKeys.RCONTROL, Input.Keys.RightControl);
                    KeyMap.Add(API.VirtualKeys.RSHIFT, Input.Keys.RightShift);
                    KeyMap.Add(API.VirtualKeys.RETURN, Input.Keys.Enter);
                    KeyMap.Add(API.VirtualKeys.BACK, Input.Keys.Backspace);

                    KeyMap.Add(API.VirtualKeys.OEM_1, Input.Keys.Semicolon);      // Varies by keyboard, ;: on Win2K/US
                    KeyMap.Add(API.VirtualKeys.OEM_2, Input.Keys.Slash);          // Varies by keyboard, /? on Win2K/US
                    KeyMap.Add(API.VirtualKeys.OEM_3, Input.Keys.Tilde);          // Varies by keyboard, `~ on Win2K/US
                    KeyMap.Add(API.VirtualKeys.OEM_4, Input.Keys.LeftBracket);    // Varies by keyboard, [{ on Win2K/US
                    KeyMap.Add(API.VirtualKeys.OEM_5, Input.Keys.BackSlash);      // Varies by keyboard, \| on Win2K/US
                    KeyMap.Add(API.VirtualKeys.OEM_6, Input.Keys.RightBracket);   // Varies by keyboard, ]} on Win2K/US
                    KeyMap.Add(API.VirtualKeys.OEM_7, Input.Keys.Quote);          // Varies by keyboard, '" on Win2K/US
                    KeyMap.Add(API.VirtualKeys.OEM_PLUS, Input.Keys.Plus);        // Invariant: +
                    KeyMap.Add(API.VirtualKeys.OEM_COMMA, Input.Keys.Comma);      // Invariant: ,
                    KeyMap.Add(API.VirtualKeys.OEM_MINUS, Input.Keys.Minus);      // Invariant: -
                    KeyMap.Add(API.VirtualKeys.OEM_PERIOD, Input.Keys.Period);    // Invariant: .

                    KeyMap.Add(API.VirtualKeys.HOME, Input.Keys.Home);
                    KeyMap.Add(API.VirtualKeys.END, Input.Keys.End);
                    KeyMap.Add(API.VirtualKeys.DELETE, Input.Keys.Delete);
                    KeyMap.Add(API.VirtualKeys.PRIOR, Input.Keys.PageUp);
                    KeyMap.Add(API.VirtualKeys.NEXT, Input.Keys.PageDown);
                    KeyMap.Add(API.VirtualKeys.PRINT, Input.Keys.PrintScreen);
                    KeyMap.Add(API.VirtualKeys.PAUSE, Input.Keys.Pause);
                    KeyMap.Add(API.VirtualKeys.NUMLOCK, Input.Keys.NumLock);
                    
                    KeyMap.Add(API.VirtualKeys.SLEEP, Input.Keys.Sleep);

                    // Keypad
                    for (int i = 0; i <= 9; i++)
                    {
                        KeyMap.Add((API.VirtualKeys)((int)API.VirtualKeys.NUMPAD0 + i), Input.Keys.Keypad0 + i);

                    }
                    KeyMap.Add(API.VirtualKeys.DECIMAL, Input.Keys.KeypadDecimal);
                    KeyMap.Add(API.VirtualKeys.ADD, Input.Keys.KeypadAdd);
                    KeyMap.Add(API.VirtualKeys.SUBTRACT, Input.Keys.KeypadSubtract);
                    KeyMap.Add(API.VirtualKeys.DIVIDE, Input.Keys.KeypadDivide);
                    KeyMap.Add(API.VirtualKeys.MULTIPLY, Input.Keys.KeypadMultiply);

                    // Navigation
                    KeyMap.Add(API.VirtualKeys.UP, Input.Keys.Up);
                    KeyMap.Add(API.VirtualKeys.DOWN, Input.Keys.Down);
                    KeyMap.Add(API.VirtualKeys.LEFT, Input.Keys.Left);
                    KeyMap.Add(API.VirtualKeys.RIGHT, Input.Keys.Right);
                }
                catch (ArgumentException e)
                {
                    Debug.Print("Exception while creating keymap: '{0}'.", e.ToString());
                    System.Windows.Forms.MessageBox.Show(
                        String.Format("Exception while creating keymap: '{0}'.", e.ToString()));
                }
                finally
                {
                    keyMapExists = true;
                }
            }
        }

        #endregion

        #region --- Constructors ---

        internal WinRawKeyboard()
            : this(IntPtr.Zero)
        {
        }

        internal WinRawKeyboard(IntPtr windowHandle)
        {
            Debug.WriteLine("Initializing keyboard driver.");
            Debug.Indent();

            this.windowHandle = windowHandle;
            InitKeyMap();

            UpdateKeyboardList();

            Debug.Unindent();
        }

        #endregion

        #region internal static void UpdateKeyboardList()

        internal void UpdateKeyboardList()
        {
            uint count = WinRawInput.DeviceCount;
            API.RawInputDeviceList[] ridl = new API.RawInputDeviceList[count];
            for (int i = 0; i < count; i++)
                ridl[i] = new API.RawInputDeviceList();
            API.GetRawInputDeviceList(ridl, ref count, API.RawInputDeviceListSize);

            // Discover keyboard devices:
            for (int i = 0; i < count; i++)
            {
                uint size = 0;
                API.GetRawInputDeviceInfo(ridl[i].Device, API.RawInputDeviceInfoEnum.DEVICENAME, IntPtr.Zero, ref size);
                IntPtr name_ptr = Marshal.AllocHGlobal((IntPtr)size);
                API.GetRawInputDeviceInfo(ridl[i].Device, API.RawInputDeviceInfoEnum.DEVICENAME, name_ptr, ref size);
                string name = Marshal.PtrToStringAnsi(name_ptr);
                Marshal.FreeHGlobal(name_ptr);
                if (name.ToLower().Contains("root"))
                {
                    // This is a terminal services devices, skip it.
                    continue;
                }
                else if (
                    ridl[i].Type == API.RawInputDeviceType.KEYBOARD ||
                    ridl[i].Type == API.RawInputDeviceType.HID)
                {
                    //It's a keyboard – or a USB device that could be a keyboard

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
                        Keyboard kb = new Keyboard();
                        kb.Description = deviceDesc;

                        // Register the keyboard:
                        API.RawInputDeviceInfo info = new API.RawInputDeviceInfo();
                        uint devInfoSize = API.RawInputDeviceInfoSize;
                        API.GetRawInputDeviceInfo(ridl[i].Device, API.RawInputDeviceInfoEnum.DEVICEINFO,
                                info, ref devInfoSize);

                        kb.NumberOfLeds = info.Device.Keyboard.NumberOfIndicators;
                        kb.NumberOfFunctionKeys = info.Device.Keyboard.NumberOfFunctionKeys;
                        kb.NumberOfKeys = info.Device.Keyboard.NumberOfKeysTotal;
                        kb.DeviceID = (info.Device.Keyboard.Type << 32) + info.Device.Keyboard.SubType;

                        if (!keyboards.Contains(kb))
                        {
                            this.RegisterKeyboardDevice(kb);
                            keyboards.Add(kb);
                        }
                    }
                }
            }
        }

        #endregion

        #region internal void RegisterKeyboardDevice(Keyboard kb)

        internal void RegisterKeyboardDevice(Keyboard kb)
        {
            API.RawInputDevice[] rid = new API.RawInputDevice[1];
            // Keyboard is 1/6 (page/id). See http://www.microsoft.com/whdc/device/input/HID_HWID.mspx
            rid[0] = new API.RawInputDevice();
            rid[0].UsagePage = 1;
            rid[0].Usage = 6;
            rid[0].Flags = API.RawInputDeviceFlags.INPUTSINK;
            rid[0].Target = windowHandle;

            if (!API.RegisterRawInputDevices(rid, 1, API.RawInputDeviceSize))
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
        internal bool ProcessKeyboardEvent(API.RawInput rin)
        {
            //Keyboard key = keyboards[0];
            //rin.Header.Device;
            switch (rin.Header.Type)
            {
                case API.RawInputDeviceType.KEYBOARD:
                    bool pressed =
                        rin.Data.Keyboard.Message == API.Constants.WM_KEYDOWN ||
                        rin.Data.Keyboard.Message == API.Constants.WM_SYSKEYDOWN;

                    // Generic control, shift, alt keys may be sent instead of left/right.
                    // It seems you have to explicitly register left/right events.
                    switch (rin.Data.Keyboard.VKey)
                    {
                        case API.VirtualKeys.SHIFT:
                            keyboards[0][Input.Keys.LeftShift] = keyboards[0][Input.Keys.RightShift] = pressed;
                            return false;

                        case API.VirtualKeys.CONTROL:
                            keyboards[0][Input.Keys.LeftControl] = keyboards[0][Input.Keys.RightControl] = pressed;
                            return false;

                        case API.VirtualKeys.MENU:
                            keyboards[0][Input.Keys.LeftAlt] = keyboards[0][Input.Keys.RightAlt] = pressed;
                            return false;

                        default:
                            if (!WinRawKeyboard.KeyMap.ContainsKey(rin.Data.Keyboard.VKey))
                            {
                                Debug.Print("Virtual key {0} not mapped.", rin.Data.Keyboard.VKey);
                                OpenTK.OpenGL.GL.ClearColor(1.0f, 0.3f, 0.3f, 0.0f);
                            }
                            else
                            {
                                keyboards[0][WinRawKeyboard.KeyMap[rin.Data.Keyboard.VKey]] = pressed;
                                OpenTK.OpenGL.GL.ClearColor(0.0f, 0.0f, 0.0f, 0.0f);
                            }
                            break;
                    }
                    break;

                default:
                    throw new ApplicationException("Windows raw keyboard driver received invalid data.");
            }
            return false;
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

        public IList<Keyboard> Keyboard
        {
            get { return keyboards; }
        }

        #endregion
    }
}
