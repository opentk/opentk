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
        }

        internal bool ProcessEvent(API.RawInput rin)
        {
            if (rin.Data.Keyboard.VKey == API.Constants.VK_ESCAPE)
            {
                if (rin.Data.Keyboard.Message == API.Constants.WM_KEYDOWN)
                    keys[(int)Keys.Escape] = true;
                else
                    keys[(int)Keys.Escape] = false;

                return true;
            }

            return false;
        }

        #region --- IKeyboard members ---

        public bool this[Keys k]
        {
            get { return keys[(int)k]; }
            set
            {
                /*keys[(int)k] = value;*/
                throw new NotImplementedException();
            }
        }

        #endregion
    }


}
