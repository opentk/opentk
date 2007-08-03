#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

#region --- Using directives ---

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Windows.Forms;
using OpenTK.Input;

#endregion

namespace OpenTK.Platform.Windows
{
    internal class WinRawInput : NativeWindow, Input.IInputDriver
    {
        /// <summary>
        /// Input event data.
        /// </summary>
        private API.RawInput data = new API.RawInput();

        /// <summary>
        /// The list of keyboards connected to this system.
        /// </summary>
        private List<WinRawKeyboard> keyboards = new List<WinRawKeyboard>();
        
        WinRawKeyboard key;

        internal IEnumerable<Input.IInputDevice> InputDevices
        {
            get
            {
                return (IEnumerable<Input.IInputDevice>)key;
            }
        }

        internal WinRawInput()
        {
            CreateParams cp = new CreateParams();
            /*cp.ClassStyle =
                (int)API.WindowClassStyle.ParentDC;
            cp.Style =
                (int)API.WindowStyle.Disabled |
                (int)API.WindowStyle.ChildWindow;*/

            cp.Caption = "OpenTK hidden input handler window";
            base.CreateHandle(cp);
            //key = new WinRawKeyboard(this.Handle);

            uint numKeyboards = WinRawKeyboard.Count;
        }


        private static uint deviceCount;

        internal static uint DeviceCount
        {
            get { return DeviceListChanged ? deviceCount : deviceCount; }
        }

        /// <summary>
        /// Gets a value indicating whether the Device list has changed, for example
        /// by removing or adding a device.
        /// </summary>
        internal static bool DeviceListChanged
        {
            get
            {
                uint count = 0;
                if (API.GetRawInputDeviceList(null, ref count, API.RawInputDeviceListSize) == 0)
                {
                    if (deviceCount == count)
                        return true;

                    deviceCount = count;
                    return false;
                }
                else
                {
                    throw new ApplicationException(String.Format(
                        "Could not retrieve the count of Keyboard devices. Windows error: {0}",
                        Marshal.GetLastWin32Error()));
                }
            }
        }

        #region protected override void WndProc(ref Message msg)

        /// <summary>
        /// Processes the input Windows Message, routing the data to the correct Keyboard, Mouse or HID.
        /// </summary>
        /// <param name="msg">The WM_INPUT message, containing the data on the input event.</param>
        protected override void WndProc(ref Message msg)
        {
            if (msg.Msg == API.Constants.WM_INPUT)
            {
                uint size = 0;
                // Get the size of the input data
                API.GetRawInputData(msg.LParam, API.GetRawInputDataEnum.INPUT,
                    IntPtr.Zero, ref size, API.RawInputHeaderSize);

                if (data == null || API.RawInputSize < size)
                {
                    throw new ApplicationException("Critical error when processing raw windows input.");
                }

                if (size == API.GetRawInputData(msg.LParam, API.GetRawInputDataEnum.INPUT,
                        data, ref size, API.RawInputHeaderSize))
                {
                    switch (data.Header.Type)
                    {
                        case API.RawInputDeviceType.KEYBOARD:
                            ProcessKeyboardEvent(data);
                            break;

                        case API.RawInputDeviceType.MOUSE:
                            throw new NotImplementedException();

                        case API.RawInputDeviceType.HID:
                            throw new NotImplementedException();
                    }
                }
                else
                {
                    throw new ApplicationException(
                        "GetRawInputData returned invalid data. Please file a bug at http://opentk.sourceforge.net"
                    );
                }
            }

            base.WndProc(ref msg);
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
                            key[Input.Keys.LeftShift] = key[Input.Keys.RightShift] = pressed;
                            return false;

                        case API.VirtualKeys.CONTROL:
                            key[Input.Keys.LeftControl] = key[Input.Keys.RightControl] = pressed;
                            return false;

                        case API.VirtualKeys.MENU:
                            key[Input.Keys.LeftAlt] = key[Input.Keys.RightAlt] = pressed;
                            return false;

                        default:
                            if (!WinRawKeyboard.KeyMap.ContainsKey(rin.Data.Keyboard.VKey))
                            {
                                Debug.Print("Virtual key {0} not mapped.", rin.Data.Keyboard.VKey);
                                OpenTK.OpenGL.GL.ClearColor(1.0f, 0.3f, 0.3f, 0.0f);
                            }
                            else
                            {
                                key[WinRawKeyboard.KeyMap[rin.Data.Keyboard.VKey]] = pressed;
                                OpenTK.OpenGL.GL.ClearColor(0.0f, 0.0f, 0.0f, 0.0f);
                            }
                            break;
                    }
                    break;

                case API.RawInputDeviceType.MOUSE:
                    break;

                case API.RawInputDeviceType.HID:
                    break;
            }
            return false;
        }

        #endregion

        #region --- IInputDriver Members ---

        IList<Input.IInputDevice> Input.IInputDriver.InputDevices
        {
            get { throw new Exception("The method or operation is not implemented."); }
        }

        public IList<IKeyboard> Keyboards
        {
            get { return (IList<IKeyboard>)keyboards; }
        }

        #endregion
    }
}
