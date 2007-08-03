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

#endregion

namespace OpenTK.Platform.Windows
{
    internal class WinRawKeyboard : Input.IKeyboard
    {
        private bool[] keys = new bool[(int)Input.Keys.MaxKeys];

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

        /// <summary>
        /// The count of physical keyboards connected to this computer.
        /// </summary>
        private static uint keyboardCount;
        internal static uint Count
        {
            get
            {
                if (!WinRawInput.DeviceListChanged && keyboardCount != 0)
                {
                    return keyboardCount;
                }
                else
                {
                    UpdateKeyboardList();
                    return keyboardCount;
                }
            }
        }

        internal static void UpdateKeyboardList()
        {
            uint count = WinRawInput.DeviceCount;
            API.RawInputDeviceList[] ridl = new API.RawInputDeviceList[count];
            for (int i = 0; i < count; i++)
                ridl[i] = new API.RawInputDeviceList();
            API.GetRawInputDeviceList(ridl, ref count, API.RawInputDeviceListSize);

            for (int i = 0; i < count; i++)
            {
                //do something with the information (see section on GetRawInputDeviceInfo)
                
            }
        }

        #region --- Constructors ---

        internal WinRawKeyboard()
            : this(IntPtr.Zero)
        {
        }

        internal WinRawKeyboard(IntPtr windowHandle)
        {
            Debug.WriteLine("Keyboard driver: Windows raw input");
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

            InitKeyMap();
        }

        #endregion

        #region --- IKeyboard members ---

        public bool this[Input.Keys k]
        {
            get { return keys[(int)k]; }
            internal set
            {
                Debug.Print("OpenTK key {0} {1}.", k, value ? "pressed" : "released");
                keys[(int)k] = value;
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
    }
}
