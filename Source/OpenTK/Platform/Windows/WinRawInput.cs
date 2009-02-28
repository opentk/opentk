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
    // Not complete.
    sealed class WinRawInput : NativeWindow, IInputDriver
    {
        // Input event data.
        RawInput data = new RawInput();
        // The total number of input devices connected to this system.
        static int deviceCount;
        int rawInputStructSize = API.RawInputSize;

        private WinRawKeyboard keyboardDriver;
        private WinRawMouse mouseDriver;

        #region --- Constructors ---

        internal WinRawInput(WinWindowInfo parent)
        {
            Debug.WriteLine("Initalizing windows raw input driver.");
            Debug.Indent();

            AssignHandle(parent.WindowHandle);
            Debug.Print("Input window attached to parent {0}", parent);
            keyboardDriver = new WinRawKeyboard(this.Handle);
            mouseDriver = new WinRawMouse(this.Handle);
            
            Debug.Unindent();

            //AllocateBuffer();
        }

        #endregion

        #region internal static int DeviceCount

        internal static int DeviceCount
        {
            get
            {
                Functions.GetRawInputDeviceList(null, ref deviceCount, API.RawInputDeviceListSize);
                return deviceCount;
            }
        }

        #endregion

        #region protected override void WndProc(ref Message msg)

        /// <summary>
        /// Processes the input Windows Message, routing the buffer to the correct Keyboard, Mouse or HID.
        /// </summary>
        /// <param name="msg">The WM_INPUT message, containing the buffer on the input event.</param>
        protected override void WndProc(ref Message msg)
        {
            switch ((WindowMessage)msg.Msg)
            {
                case WindowMessage.INPUT:
                    int size = 0;
                    // Get the size of the input buffer
                    Functions.GetRawInputData(msg.LParam, GetRawInputDataEnum.INPUT,
                        IntPtr.Zero, ref size, API.RawInputHeaderSize);

                    //if (buffer == null || API.RawInputSize < size)
                    //{
                    //    throw new ApplicationException("Critical error when processing raw windows input.");
                    //}
                    if (size == Functions.GetRawInputData(msg.LParam, GetRawInputDataEnum.INPUT,
                            out data, ref size, API.RawInputHeaderSize))
                    {
                        switch (data.Header.Type)
                        {
                            case RawInputDeviceType.KEYBOARD:
                                if (!keyboardDriver.ProcessKeyboardEvent(data))
                                    Functions.DefRawInputProc(ref data, 1, (uint)API.RawInputHeaderSize);
                                return;

                            case RawInputDeviceType.MOUSE:
                                if (!mouseDriver.ProcessEvent(data))
                                    Functions.DefRawInputProc(ref data, 1, (uint)API.RawInputHeaderSize);
                                return;

                            case RawInputDeviceType.HID:
                                Functions.DefRawInputProc(ref data, 1, (uint)API.RawInputHeaderSize);
                                return;

                            default:
                                break;
                        }
                    }
                    else
                    {
                        throw new ApplicationException(String.Format(
                            "GetRawInputData returned invalid buffer. Windows error {0}. Please file a bug at http://opentk.sourceforge.net",
                            Marshal.GetLastWin32Error()));
                    }
                    break;
                
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

        #region IInputDriver Members

        public void Poll()
        {
            return;
#if false
            // We will do a buffered read for all input devices and route the RawInput structures
            // to the correct 'ProcessData' handlers. First, we need to find out the size of the
            // buffer to allocate for the structures. Then we allocate the buffer and read the
            // structures, calling the correct handler for each one. Last, we free the allocated
            // buffer.
            int size = 0;
            Functions.GetRawInputBuffer(IntPtr.Zero, ref size, API.RawInputHeaderSize);
            size *= 256;
            IntPtr rin_data = Marshal.AllocHGlobal(size);

            while (true)
            {
                // Iterate reading all available RawInput structures and routing them to their respective
                // handlers.
                int num = Functions.GetRawInputBuffer(rin_data, ref size, API.RawInputHeaderSize);
                if (num == 0)
                    break;
                else if (num < 0)
                {
                    /*int error = Marshal.GetLastWin32Error();
                    if (error == 122)
                    {
                        // Enlarge the buffer, it was too small.
                        AllocateBuffer();
                    }
                    else
                    {
                        throw new ApplicationException(String.Format(
                            "GetRawInputBuffer failed with code: {0}", error));
                    }*/
                    Debug.Print("GetRawInputBuffer failed with code: {0}", Marshal.GetLastWin32Error());
                    //AllocateBuffer();
                    break;
                }

                RawInput[] rin_structs = new RawInput[num];
                IntPtr next_rin = rin_data;
                for (int i = 0; i < num; i++)
                {
                    rin_structs[i] = (RawInput)Marshal.PtrToStructure(next_rin, typeof(RawInput));

                    switch (rin_structs[i].Header.Type)
                    {
                        case RawInputDeviceType.KEYBOARD:
                            keyboardDriver.ProcessKeyboardEvent(rin_structs[i]);
                            break;

                        case RawInputDeviceType.MOUSE:
                            mouseDriver.ProcessEvent(rin_structs[i]);
                            break;
                    }

                    next_rin = Functions.NextRawInputStructure(next_rin);
                }
                Functions.DefRawInputProc(rin_structs, num, (uint)API.RawInputHeaderSize);
            }

            Marshal.FreeHGlobal(rin_data);
#endif
        }

        #endregion

        #region IKeyboardDriver Members

        public IList<KeyboardDevice> Keyboard
        {
            get { return keyboardDriver.Keyboard; }
        }

        #endregion

        #region IMouseDriver Members

        public IList<MouseDevice> Mouse
        {
            get { return mouseDriver.Mouse; }
        }

        #endregion

        #region IJoystickDriver Members

        public IList<JoystickDevice> Joysticks
        {
            get { throw new NotImplementedException(); }
        }

        #endregion

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
