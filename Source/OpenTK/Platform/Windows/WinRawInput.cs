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
        private RawInput data = new RawInput();
        /// <summary>
        /// The total number of input devices connected to this system.
        /// </summary>
        private static int deviceCount;

        private WinRawKeyboard keyboardDriver;
        private WinRawMouse mouseDriver;

        #region --- Constructors ---

        internal WinRawInput(IWindowInfo parent)
        {
            Debug.WriteLine("Initalizing windows raw input driver.");
            Debug.Indent();

            AssignHandle(parent.Handle);
            Debug.Print("Input window attached to parent {0}", parent);
            keyboardDriver = new WinRawKeyboard(this.Handle);
            mouseDriver = new WinRawMouse(this.Handle);
            
            Debug.Unindent();
        }

        #endregion

        #region internal static int DeviceCount

        internal static int DeviceCount
        {
            get
            {
                API.GetRawInputDeviceList(null, ref deviceCount, API.RawInputDeviceListSize);
                return deviceCount;
            }
        }

        #endregion

        #region protected override void WndProc(ref Message msg)

        int size = 0;

        /// <summary>
        /// Processes the input Windows Message, routing the data to the correct Keyboard, Mouse or HID.
        /// </summary>
        /// <param name="msg">The WM_INPUT message, containing the data on the input event.</param>
        protected override void WndProc(ref Message msg)
        {
            switch ((WindowMessage)msg.Msg)
            {
                case WindowMessage.INPUT:
                    size = 0;
                    // Get the size of the input data
                    API.GetRawInputData(msg.LParam, GetRawInputDataEnum.INPUT,
                        IntPtr.Zero, ref size, API.RawInputHeaderSize);

                    //if (data == null || API.RawInputSize < size)
                    //{
                    //    throw new ApplicationException("Critical error when processing raw windows input.");
                    //}

                    if (size == API.GetRawInputData(msg.LParam, GetRawInputDataEnum.INPUT,
                            data, ref size, API.RawInputHeaderSize))
                    {
                        switch (data.Header.Type)
                        {
                            case RawInputDeviceType.KEYBOARD:
                                if (!keyboardDriver.ProcessKeyboardEvent(data))
                                    API.DefRawInputProc(ref data, 1, (uint)API.RawInputHeaderSize);
                                return;

                            case RawInputDeviceType.MOUSE:
                                if (!mouseDriver.ProcessEvent(data))
                                    API.DefRawInputProc(ref data, 1, (uint)API.RawInputHeaderSize);
                                return;

                            case RawInputDeviceType.HID:
                                API.DefRawInputProc(ref data, 1, (uint)API.RawInputHeaderSize);
                                return;

                            default:
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

                case WindowMessage.CLOSE:
                case WindowMessage.DESTROY:
                Debug.Print("Input window detached from parent {0}.", Handle);
                ReleaseHandle();
                break;

                case WindowMessage.QUIT:
                Debug.WriteLine("Input window quit.");
                this.Dispose();
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

        public IList<Mouse> Mouse
        {
            get { return mouseDriver.Mouse; }
        }

        public void ProcessEvents()
        {
            // Do nothing, the WndProc is automatically notified of new events (sub-classing magic).
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
                    keyboardDriver.Dispose();
                    this.ReleaseHandle();
                }

                disposed = true;
            }
        }

        ~WinRawInput()
        {
            Dispose(false);
        }

        #endregion
    }
}
