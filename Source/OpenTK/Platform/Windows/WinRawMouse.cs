#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using OpenTK.Input;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace OpenTK.Platform.Windows
{
    /// <summary>
    /// Contains methods to register for and process mouse WM_INPUT messages.
    /// </summary>
    internal class WinRawMouse : IMouseDriver, IDisposable
    {
        private List<MouseDevice> mice = new List<MouseDevice>();
        private IntPtr window;

        #region --- Constructors ---

        internal WinRawMouse()
            : this(IntPtr.Zero)
        {
        }

        internal WinRawMouse(IntPtr windowHandle)
        {
            Debug.WriteLine("Initializing mouse driver (WinRawMouse).");
            Debug.Indent();

            this.window = windowHandle;

            RegisterDevices();

            Debug.Unindent();
        }

        #endregion

        #region --- IMouseDriver Members ---

        public IList<MouseDevice> Mouse
        {
            get { return mice; }
        }

        #region public int RegisterDevices()

        public int RegisterDevices()
        {
            int count = WinRawInput.DeviceCount;
            RawInputDeviceList[] ridl = new RawInputDeviceList[count];
            for (int i = 0; i < count; i++)
                ridl[i] = new RawInputDeviceList();
            Functions.GetRawInputDeviceList(ridl, ref count, API.RawInputDeviceListSize);

            // Discover mouse devices:
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
                else if (ridl[i].Type == RawInputDeviceType.MOUSE || ridl[i].Type == RawInputDeviceType.HID)
                {
                    // This is a mouse or a USB mouse device. In the latter case, discover if it really is a
                    // mouse device by qeurying the registry.

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

                    string deviceDesc = (string)regkey.GetValue("DeviceDesc");
                    deviceDesc = deviceDesc.Substring(deviceDesc.LastIndexOf(';') + 1);
                    string deviceClass = (string)regkey.GetValue("Class");

                    if (!String.IsNullOrEmpty(deviceClass) && deviceClass.ToLower().Equals("mouse"))
                    {
                        OpenTK.Input.MouseDevice mouse = new OpenTK.Input.MouseDevice();
                        mouse.Description = deviceDesc;

                        // Register the keyboard:
                        RawInputDeviceInfo info = new RawInputDeviceInfo();
                        int devInfoSize = API.RawInputDeviceInfoSize;
                        Functions.GetRawInputDeviceInfo(ridl[i].Device, RawInputDeviceInfoEnum.DEVICEINFO,
                                info, ref devInfoSize);

                        mouse.NumberOfButtons = info.Device.Mouse.NumberOfButtons;
                        mouse.NumberOfWheels = info.Device.Mouse.HasHorizontalWheel ? 1 : 0;

                        mouse.DeviceID = ridl[i].Device;//(IntPtr)info.Device.Mouse.Id;

                        this.RegisterRawDevice(mouse);
                        mice.Add(mouse);
                    }
                }
            }

            return count;
        }

        #endregion

        #endregion

        #region internal void RegisterRawDevice(OpenTK.Input.Mouse mouse)

        internal void RegisterRawDevice(OpenTK.Input.MouseDevice mouse)
        {
            RawInputDevice[] rid = new RawInputDevice[1];
            // Mouse is 1/2 (page/id). See http://www.microsoft.com/whdc/device/input/HID_HWID.mspx
            rid[0] = new RawInputDevice();
            rid[0].UsagePage = 1;
            rid[0].Usage = 2;
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
                Debug.Print("Registered mouse {0}", mouse.ToString());
                System.Drawing.Point p = new System.Drawing.Point();
                if (Functions.GetCursorPos(ref p))
                    mouse.Position = p;
            }
        }

        #endregion

        #region internal bool ProcessEvent(API.RawInput rin)

        /// <summary>
        /// Processes raw input events.
        /// </summary>
        /// <param name="rin"></param>
        /// <returns></returns>
        internal bool ProcessEvent(RawInput rin)
        {
            //MouseDevice mouse = mice.Find(delegate(MouseDevice m)
            //{
            //    return m.DeviceID == rin.Header.Device;
            //});
            MouseDevice mouse;
            if (mice.Count > 0) mouse = mice[0];
            else return false;

            switch (rin.Header.Type)
            {
                case RawInputDeviceType.MOUSE:
                    if ((rin.Data.Mouse.ButtonFlags & RawInputMouseState.LEFT_BUTTON_DOWN) != 0) mouse[MouseButton.Left] = true;
                    if ((rin.Data.Mouse.ButtonFlags & RawInputMouseState.LEFT_BUTTON_UP) != 0) mouse[MouseButton.Left] = false;
                    if ((rin.Data.Mouse.ButtonFlags & RawInputMouseState.RIGHT_BUTTON_DOWN) != 0) mouse[MouseButton.Right] = true;
                    if ((rin.Data.Mouse.ButtonFlags & RawInputMouseState.RIGHT_BUTTON_UP) != 0) mouse[MouseButton.Right] = false;
                    if ((rin.Data.Mouse.ButtonFlags & RawInputMouseState.MIDDLE_BUTTON_DOWN) != 0) mouse[MouseButton.Middle] = true;
                    if ((rin.Data.Mouse.ButtonFlags & RawInputMouseState.MIDDLE_BUTTON_UP) != 0) mouse[MouseButton.Middle] = false;
                    if ((rin.Data.Mouse.ButtonFlags & RawInputMouseState.BUTTON_4_DOWN) != 0) mouse[MouseButton.Button1] = true;
                    if ((rin.Data.Mouse.ButtonFlags & RawInputMouseState.BUTTON_4_UP) != 0) mouse[MouseButton.Button1] = false;
                    if ((rin.Data.Mouse.ButtonFlags & RawInputMouseState.BUTTON_5_DOWN) != 0) mouse[MouseButton.Button2] = true;
                    if ((rin.Data.Mouse.ButtonFlags & RawInputMouseState.BUTTON_5_UP) != 0) mouse[MouseButton.Button2] = false;

                    if ((rin.Data.Mouse.ButtonFlags & RawInputMouseState.WHEEL) != 0)
                        mouse.Wheel += (short)rin.Data.Mouse.ButtonData / 120;

                    if ((rin.Data.Mouse.Flags & RawMouseFlags.MOUSE_MOVE_ABSOLUTE) != 0)
                    {
                        mouse.Position = new System.Drawing.Point(rin.Data.Mouse.LastX, rin.Data.Mouse.LastY);
                    }
                    else
                    {   // Seems like MOUSE_MOVE_RELATIVE is the default, unless otherwise noted.
                        mouse.Position = new System.Drawing.Point(mouse.X + rin.Data.Mouse.LastX,
                                                                  mouse.Y + rin.Data.Mouse.LastY);
                    }

                    if ((rin.Data.Mouse.Flags & RawMouseFlags.MOUSE_VIRTUAL_DESKTOP) != 0)
                        Debug.WriteLine(String.Format("Mouse {0} defines MOUSE_VIRTUAL_DESKTOP flag, please report at http://www.opentk.com", mouse.ToString()));
                    
                    return true;

                default:
                    throw new ApplicationException("WinRawMouse driver received invalid data.");
            }
        }

        #endregion

        #region public void Poll()

        public void Poll()
        {
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
                    mice.Clear();
                }
                disposed = true;
            }
        }

        ~WinRawMouse()
        {
            Dispose(false);
        }

        #endregion
    }
}
