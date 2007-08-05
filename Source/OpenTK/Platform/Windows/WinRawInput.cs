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
    internal class WinRawInput : NativeWindow, IInputDriver
    {
        /// <summary>
        /// Input event data.
        /// </summary>
        private API.RawInput data = new API.RawInput();
        /// <summary>
        /// The total number of input devices connected to this system.
        /// </summary>
        private static int deviceCount;


        private WinRawKeyboard keyboardDriver;

        #region --- Constructors ---

        internal WinRawInput(IntPtr parentHandle)
        {
            Debug.WriteLine("Initalizing windows raw input driver.");
            Debug.Indent();
            
            AssignHandle(parentHandle);
            Debug.Print("Input window attached to parent {0}", this.Handle);
            keyboardDriver = new WinRawKeyboard(this.Handle);
            
            Debug.Unindent();
        }

        #endregion

        internal static int DeviceCount
        {
            get
            {
                API.GetRawInputDeviceList(null, ref deviceCount, API.RawInputDeviceListSize);
                return deviceCount;
            }
        }

        #region protected override void WndProc(ref Message msg)

        int size = 0;

        /// <summary>
        /// Processes the input Windows Message, routing the data to the correct Keyboard, Mouse or HID.
        /// </summary>
        /// <param name="msg">The WM_INPUT message, containing the data on the input event.</param>
        protected override void WndProc(ref Message msg)
        {
            switch (msg.Msg)
            {
                case API.Constants.WM_INPUT:
                    size = 0;
                    // Get the size of the input data
                    API.GetRawInputData(msg.LParam, API.GetRawInputDataEnum.INPUT,
                        IntPtr.Zero, ref size, API.RawInputHeaderSize);

                    //if (data == null || API.RawInputSize < size)
                    //{
                    //    throw new ApplicationException("Critical error when processing raw windows input.");
                    //}

                    if (size == API.GetRawInputData(msg.LParam, API.GetRawInputDataEnum.INPUT,
                            data, ref size, API.RawInputHeaderSize))
                    {
                        switch (data.Header.Type)
                        {
                            case API.RawInputDeviceType.KEYBOARD:
                                keyboardDriver.ProcessKeyboardEvent(data);
                                break;

                            case API.RawInputDeviceType.MOUSE:
                                //throw new NotImplementedException();
                                break;

                            case API.RawInputDeviceType.HID:
                                //throw new NotImplementedException();
                                break;
                        }
                    }
                    else
                    {
                        throw new ApplicationException(String.Format(
                            "GetRawInputData returned invalid data. Windows error {0}. Please file a bug at http://opentk.sourceforge.net",
                            Marshal.GetLastWin32Error()));
                    }
                    break;

                case API.Constants.WM_CLOSE:
                case API.Constants.WM_DESTROY:
                    Debug.Print("Input window detached from parent {0}.", Handle);
                    ReleaseHandle();
                    break;

                case API.Constants.WM_QUIT:
                    Debug.WriteLine("Input window quit.");
                    break;
            }

            base.WndProc(ref msg);
        }

        #endregion

        #region --- IInputDriver Members ---

        IList<Input.IInputDevice> Input.IInputDriver.InputDevices
        {
            get { throw new Exception("The method or operation is not implemented."); }
        }

        public IList<Keyboard> Keyboard
        {
            get { return keyboardDriver.Keyboard; }
        }

        public IList<Keyboard> Mouse
        {
            get { throw new Exception("The method or operation is not implemented."); }
        }

        public void ProcessEvents()
        {
            // Do nothing, the WndProc is automatically notified of new events.
        }


        #endregion

        #region IMouseDriver Members

        IList<Mouse> IMouseDriver.Mouse
        {
            get { throw new Exception("The method or operation is not implemented."); }
        }

        #endregion
    }
}
