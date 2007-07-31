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

using OpenTK.Input;

#endregion

namespace OpenTK.Platform.Windows
{
    internal class WinRawKeyboard : OpenTK.Input.IKeyboard
    {
        private bool[] keys = new bool[(int)Keys.MaxKeys];

        internal WinRawKeyboard()
            : this(IntPtr.Zero)
        {
        }

        internal WinRawKeyboard(IntPtr windowHandle)
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

            // Set the VirtualKey -> OpenTK.Key map
            keyMap.Add(API.VirtualKeys.ESCAPE, Keys.Escape);
            keyMap.Add(API.VirtualKeys.F1, Keys.F1);
            keyMap.Add(API.VirtualKeys.F2, Keys.F2);
            keyMap.Add(API.VirtualKeys.F3, Keys.F3);
            keyMap.Add(API.VirtualKeys.F4, Keys.F4);
            keyMap.Add(API.VirtualKeys.F5, Keys.F5);
            keyMap.Add(API.VirtualKeys.F6, Keys.F6);
            keyMap.Add(API.VirtualKeys.F7, Keys.F7);
            keyMap.Add(API.VirtualKeys.F8, Keys.F8);
            keyMap.Add(API.VirtualKeys.F9, Keys.F9);
            keyMap.Add(API.VirtualKeys.F10, Keys.F10);
            keyMap.Add(API.VirtualKeys.F11, Keys.F11);
            keyMap.Add(API.VirtualKeys.F12, Keys.F12);
        }

        internal bool ProcessEvent(API.RawInput rin)
        {
            switch (rin.Header.Type)
            {
                case API.RawInputDeviceType.KEYBOARD:
                    this[keyMap[rin.Data.Keyboard.VKey]] =
                        rin.Data.Keyboard.Message == API.Constants.WM_KEYDOWN ||
                        rin.Data.Keyboard.Message == API.Constants.WM_SYSKEYDOWN;
                break;
            }

            return false;
        }

        #region KeyMap

        internal static Dictionary<API.VirtualKeys, Keys> keyMap =
            new Dictionary<API.VirtualKeys, Keys>((int)API.VirtualKeys.Last);

        /*
        internal static List<KeyValuePair<API.VirtualKeys, Keys>> keyMap =
            new List<KeyValuePair<API.VirtualKeys, Keys>>(
                new KeyValuePair<API.VirtualKeys, Keys>[]
                {
                    new KeyValuePair<API.VirtualKeys, Keys>(API.VirtualKeys.ESCAPE, Keys.Escape),
                    new KeyValuePair<API.VirtualKeys, Keys>(API.VirtualKeys.F1, Keys.F1)
                }
            );
        */
        #endregion

        #region --- IKeyboard members ---

        public bool this[Keys k]
        {
            get { return keys[(int)k]; }
            internal set
            {
                keys[(int)k] = value;
                //throw new NotImplementedException();
            }
        }

        #endregion
    }


}
