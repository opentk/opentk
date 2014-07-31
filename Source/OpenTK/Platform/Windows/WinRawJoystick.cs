#region License
//
// WinRawJoystick.cs
//
// Author:
//       Stefanos A. <stapostol@gmail.com>
//
// Copyright (c) 2014 Stefanos Apostolopoulos
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//
#endregion

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using OpenTK.Input;
using OpenTK.Platform.Common;

namespace OpenTK.Platform.Windows
{
    class WinRawJoystick : IJoystickDriver2
    {
        class Device
        {
            public IntPtr Handle;
            JoystickCapabilities Capabilities;
            JoystickState State;
            Guid Guid;

            readonly Dictionary<int, JoystickAxis> axes =
                new Dictionary<int,JoystickAxis>();
            readonly Dictionary<int, JoystickButton> buttons =
                new Dictionary<int, JoystickButton>();

            #region Constructors

            public Device(IntPtr handle, Guid guid, JoystickCapabilities caps)
            {
                Handle = handle;
                Guid = guid;
                Capabilities = caps;
            }

            #endregion

            #region Public Members

            public void SetAxis(HIDPage page, short usage, short value)
            {
                JoystickAxis axis = GetAxis(page, usage);
                State.SetAxis(axis, value);
            }

            public void SetButton(HIDPage page, short usage, bool value)
            {
                JoystickButton button = GetButton(page, usage);
                State.SetButton(button, value);
            }

            public void SetConnected(bool value)
            {
                Capabilities.SetIsConnected(value);
                State.SetIsConnected(value);
            }

            public JoystickCapabilities GetCapabilities()
            {
                return Capabilities;
            }

            public Guid GetGuid()
            {
                return Guid;
            }

            public JoystickState GetState()
            {
                return State;
            }


            #endregion

            #region Private Members

            static int MakeKey(HIDPage page, short usage)
            {
                return ((ushort)page << 16) | unchecked((ushort)usage);
            }

            JoystickAxis GetAxis(HIDPage page, short usage)
            {
                int key = MakeKey(page, usage);
                if (!axes.ContainsKey(key))
                {
                    axes.Add(key, JoystickAxis.Axis0 + axes.Count);
                }
                return axes[key];
            }

            JoystickButton GetButton(HIDPage page, short usage)
            {
                int key = MakeKey(page, usage);
                if (!buttons.ContainsKey(key))
                {
                    buttons.Add(key, JoystickButton.Button0 + buttons.Count);
                }
                return buttons[key];
            }

            #endregion
        }

        // Defines which types of HID devices we are interested in
        readonly RawInputDevice[] DeviceTypes;

        readonly IntPtr Window;
        readonly object UpdateLock = new object();
        readonly Dictionary<IntPtr, Device> Devices =
            new Dictionary<IntPtr, Device>(new IntPtrEqualityComparer());
        readonly Dictionary<int, IntPtr> IndexToDevice =
            new Dictionary<int, IntPtr>();

        byte[] PreparsedData = new byte[1024];
        HidProtocolValueCaps[] AxisCaps = new HidProtocolValueCaps[4];
        HidProtocolButtonCaps[] ButtonCaps = new HidProtocolButtonCaps[4];
        HidProtocolData[] DataBuffer = new HidProtocolData[16];

        public WinRawJoystick(IntPtr window)
        {
            Debug.WriteLine("Using WinRawJoystick.");
            Debug.Indent();

            if (window == IntPtr.Zero)
                throw new ArgumentNullException("window");

            Window = window;
            DeviceTypes = new RawInputDevice[]
            {
                new RawInputDevice(HIDUsageGD.Joystick, RawInputDeviceFlags.INPUTSINK, window),
                new RawInputDevice(HIDUsageGD.GamePad, RawInputDeviceFlags.INPUTSINK, window),
            };

            if (!Functions.RegisterRawInputDevices(DeviceTypes, DeviceTypes.Length, API.RawInputDeviceSize))
            {
                Debug.Print("[Warning] Raw input registration failed with error: {0}.",
                    Marshal.GetLastWin32Error());
            }
            else
            {
                Debug.Print("[WinRawJoystick] Registered for raw input");
            }

            RefreshDevices();

            Debug.Unindent();
        }

        #region Public Members

        public void RefreshDevices()
        {
            // Mark all devices as disconnected. We will check which of those
            // are connected later on.
            for (int i = 0; i < IndexToDevice.Count; i++)
            {
                Devices[IndexToDevice[i]].SetConnected(false);
            }

            foreach (RawInputDeviceList dev in WinRawInput.GetDeviceList())
            {
                if (dev.Type != RawInputDeviceType.HID)
                    continue;

                IntPtr handle = dev.Device;
                Guid guid = GetDeviceGuid(handle);
                JoystickCapabilities caps = GetDeviceCaps(handle);

                if (!Devices.ContainsKey(handle))
                    Devices.Add(handle, new Device(handle, guid, caps));
                
                Device stick = Devices[handle];
                stick.SetConnected(true);
            }

        }

        public unsafe bool ProcessEvent(ref RawInput rin)
        {
            IntPtr handle = rin.Header.Device;
            Device stick = GetDevice(handle);
            if (stick == null)
            {
                Debug.Print("[WinRawJoystick] Unknown device {0}", handle);
                return false;
            }

            if (!GetPreparsedData(handle, ref PreparsedData))
            {
                return false;
            }

            HidProtocolCaps caps;
            int axis_caps_count;
            int button_caps_count;
            if (!GetDeviceCaps(PreparsedData, out caps,
                ref AxisCaps, out axis_caps_count,
                ref ButtonCaps, out button_caps_count))
            {
                return false;
            }

            // Query current state
            // Allocate enough storage to hold the data of the current report
            int size = HidProtocol.MaxDataListLength(HidProtocolReportType.Input, PreparsedData);
            if (size == 0)
            {
                Debug.Print("[WinRawJoystick] HidProtocol.MaxDataListLength() failed with {0}",
                    Marshal.GetLastWin32Error());
                return false;
            }

            // Fill the data buffer
            if (DataBuffer.Length < size)
            {
                Array.Resize(ref DataBuffer, size);
            }

            fixed (void* pdata = &rin.Data.HID.RawData)
            {
                if (HidProtocol.GetData(HidProtocolReportType.Input,
                    DataBuffer, ref size, PreparsedData,
                    (IntPtr)pdata, rin.Data.HID.Size) != HidProtocolStatus.Success)
                {
                    Debug.Print("[WinRawJoystick] HidProtocol.GetData() failed with {0}",
                        Marshal.GetLastWin32Error());
                    return false;
                }
            }

            UpdateAxes(stick, caps, AxisCaps, axis_caps_count, DataBuffer);
            UpdateButtons(stick, caps, ButtonCaps, button_caps_count, DataBuffer);

            return true;
        }

        #endregion

        #region Private Members

        static bool GetPreparsedData(IntPtr handle, ref byte[] prepared_data)
        {
            // Query the size of the _HIDP_PREPARSED_DATA structure for this event.
            int preparsed_size = 0;
            Functions.GetRawInputDeviceInfo(handle, RawInputDeviceInfoEnum.PREPARSEDDATA,
                IntPtr.Zero, ref preparsed_size);
            if (preparsed_size == 0)
            {
                Debug.Print("[WinRawJoystick] Functions.GetRawInputDeviceInfo(PARSEDDATA) failed with {0}",
                    Marshal.GetLastWin32Error());
                return false;
            }

            // Allocate space for _HIDP_PREPARSED_DATA.
            // This is an untyped blob of data.
            if (prepared_data.Length < preparsed_size)
            {
                Array.Resize(ref prepared_data, preparsed_size);
            }

            if (Functions.GetRawInputDeviceInfo(handle, RawInputDeviceInfoEnum.PREPARSEDDATA,
                prepared_data, ref preparsed_size) < 0)
            {
                Debug.Print("[WinRawJoystick] Functions.GetRawInputDeviceInfo(PARSEDDATA) failed with {0}",
                    Marshal.GetLastWin32Error());
                return false;
            }

            return true;
        }

        JoystickCapabilities GetDeviceCaps(IntPtr handle)
        {
            HidProtocolCaps caps;
            int axis_count;
            int button_count;

            if (GetPreparsedData(handle, ref PreparsedData) &&
                GetDeviceCaps(PreparsedData, out caps,
                    ref AxisCaps, out axis_count,
                    ref ButtonCaps, out button_count))
            {
                int axes = 0;
                int dpads = 0;
                int buttons = 0;

                for (int i = 0; i < axis_count; i++)
                {
                    if (AxisCaps[i].IsRange)
                    {
                        Debug.Print("[WinRawJoystick] Range axis elements not implemented.");
                        continue;
                    }

                    switch (AxisCaps[i].UsagePage)
                    {
                        case HIDPage.GenericDesktop:
                            switch ((HIDUsageGD)AxisCaps[i].NotRange.Usage)
                            {
                                case HIDUsageGD.X:
                                case HIDUsageGD.Y:
                                case HIDUsageGD.Z:
                                case HIDUsageGD.Rx:
                                case HIDUsageGD.Ry:
                                case HIDUsageGD.Rz:
                                case HIDUsageGD.Slider:
                                case HIDUsageGD.Dial:
                                case HIDUsageGD.Wheel:
                                    axes++;
                                    break;

                                case HIDUsageGD.Hatswitch:
                                    dpads++;
                                    break;
                            }
                            break;

                        case HIDPage.Simulation:
                            switch ((HIDUsageSim)AxisCaps[i].NotRange.Usage)
                            {
                                case HIDUsageSim.Rudder:
                                case HIDUsageSim.Throttle:
                                    axes++;
                                    break;
                            }
                            break;

                        case HIDPage.Button:
                            buttons++;
                            break;
                    }
                }

                for (int i = 0; i < button_count; i++)
                {
                    bool is_range = ButtonCaps[i].IsRange;
                    HIDPage page = ButtonCaps[i].UsagePage;
                    switch (page)
                    {
                        case HIDPage.Button:
                            if (is_range)
                            {
                                buttons += ButtonCaps[i].Range.UsageMax - ButtonCaps[i].Range.UsageMin + 1;
                            }
                            else
                            {
                                buttons++;
                            }
                            break;

                        default:
                            Debug.Print("[WinRawJoystick] Unknown HIDPage {0} for button.", page);
                            break;
                    }
                }

                    return new JoystickCapabilities(axes, buttons, dpads, true);
            }
            return new JoystickCapabilities();
        }

        static bool GetDeviceCaps(byte[] preparsed_data, out HidProtocolCaps caps,
            ref HidProtocolValueCaps[] axis_caps, out int axis_caps_count,
            ref HidProtocolButtonCaps[] button_caps, out int button_caps_count)
        {
            axis_caps_count = 0;
            button_caps_count = 0;

            // Query joystick capabilities
            caps = new HidProtocolCaps();
            if (HidProtocol.GetCaps(preparsed_data, ref caps) != HidProtocolStatus.Success)
            {
                Debug.Print("[WinRawJoystick] HidProtocol.GetCaps() failed with {0}",
                    Marshal.GetLastWin32Error());
                return false;
            }

            // Make sure our caps arrays are big enough
            if (axis_caps.Length < caps.NumberInputValueCaps)
            {
                Array.Resize(ref axis_caps, caps.NumberInputValueCaps);
            }
            if (button_caps.Length < caps.NumberInputButtonCaps)
            {
                Array.Resize(ref button_caps, caps.NumberInputButtonCaps);
            }

            // Axis capabilities
            ushort axis_count = (ushort)axis_caps.Length;
            if (HidProtocol.GetValueCaps(HidProtocolReportType.Input,
                axis_caps, ref axis_count, preparsed_data) !=
                HidProtocolStatus.Success)
            {
                Debug.Print("[WinRawJoystick] HidProtocol.GetValueCaps() failed with {0}",
                    Marshal.GetLastWin32Error());
                return false;
            }
            axis_caps_count = (int)axis_count;

            // Button capabilities
            ushort button_count = (ushort)button_caps.Length;
            if (HidProtocol.GetButtonCaps(HidProtocolReportType.Input,
                button_caps, ref button_count, preparsed_data) !=
                HidProtocolStatus.Success)
            {
                Debug.Print("[WinRawJoystick] HidProtocol.GetButtonCaps() failed with {0}",
                    Marshal.GetLastWin32Error());
                return false;
            }
            button_caps_count = (int)button_count;

            return true;
        }

        // Retrieves the GUID of a device, which is stored
        // in the last part of the DEVICENAME string
        Guid GetDeviceGuid(IntPtr handle)
        {
            Guid guid = new Guid();

            unsafe
            {
                // Find out how much memory we need to allocate
                // for the DEVICENAME string
                int size = 0;
                if (Functions.GetRawInputDeviceInfo(handle, RawInputDeviceInfoEnum.DEVICENAME, IntPtr.Zero, ref size) < 0 || size == 0)
                {
                    Debug.Print("[WinRawJoystick] Functions.GetRawInputDeviceInfo(DEVICENAME) failed with error {0}",
                        Marshal.GetLastWin32Error());
                    return guid;
                }

                // Allocate memory and retrieve the DEVICENAME string
                char* pname = stackalloc char[size + 1];
                if (Functions.GetRawInputDeviceInfo(handle, RawInputDeviceInfoEnum.DEVICENAME, (IntPtr)pname, ref size) < 0)
                {
                    Debug.Print("[WinRawJoystick] Functions.GetRawInputDeviceInfo(DEVICENAME) failed with error {0}",
                        Marshal.GetLastWin32Error());
                    return guid;
                }

                // Convert the buffer to a .Net string, and split it into parts
                string name = new string(pname);
                if (String.IsNullOrEmpty(name))
                {
                    Debug.Print("[WinRawJoystick] Failed to construct device name");
                    return guid;
                }

                // The GUID is stored in the last part of the string
                string[] parts = name.Split('#');
                if (parts.Length >= 3)
                {
                    guid = new Guid(parts[2]);
                }
            }

            return guid;
        }

        static void UpdateAxes(Device stick, HidProtocolCaps caps, HidProtocolValueCaps[] axes, int axes_count, HidProtocolData[] data)
        {
            // Use the data indices in the axis and button caps arrays to
            // access the data buffer we just filled.
            for (int i = 0; i < axes_count; i++)
            {
                if (!axes[i].IsRange)
                {
                    int index = axes[i].NotRange.DataIndex;
                    if (index < 0 || index >= caps.NumberInputValueCaps)
                    {
                        // Should never happen
                        Debug.Print("[WinRawJoystick] Error: DataIndex out of range");
                        continue;
                    }

                    if (data[i].DataIndex != index)
                    {
                        // Should also never happen
                        Debug.Print("[WinRawJoystick] DataIndex != index ({0} != {1})",
                            data[i].DataIndex, index);
                        continue;
                    }

                    short value = (short)HidHelper.ScaleValue(data[i].RawValue,
                        axes[i].LogicalMin, axes[i].LogicalMax,
                        short.MinValue, short.MaxValue);

                    stick.SetAxis(axes[i].UsagePage, axes[i].NotRange.Usage, value);
                }
                else
                {
                    // Todo: fall back to HidProtocol.GetLinkCollectionNodes
                }
            }
        }

        unsafe static void UpdateButtons(Device stick, HidProtocolCaps caps, HidProtocolButtonCaps[] buttons, int buttons_count, HidProtocolData[] data)
        {
            for (int i = 0; i < buttons_count; i++)
            {
                if (!buttons[i].IsRange)
                {
                    int index = buttons[i].NotRange.DataIndex;
                    if (index < 0 || index >= caps.NumberInputButtonCaps)
                    {
                        // Should never happen
                        Debug.Print("[WinRawJoystick] Error: DataIndex out of range");
                        continue;
                    }

                    if (data[i].DataIndex != index)
                    {
                        // Should also never happen
                        Debug.Print("[WinRawJoystick] DataIndex != index ({0} != {1})",
                            data[i].DataIndex, index);
                        continue;
                    }

                    bool value = data[i].On;
                    stick.SetButton(buttons[i].UsagePage, buttons[i].NotRange.Usage, value);
                }
                else
                {
                    // Todo: fall back to HidProtocol.GetLinkCollectionNodes
                }
            }
        }

        Device GetDevice(IntPtr handle)
        {
            bool is_device_known = false;

            lock (UpdateLock)
            {
                is_device_known = Devices.ContainsKey(handle);
            }

            if (!is_device_known)
            {
                RefreshDevices();
            }

            lock (UpdateLock)
            {
                return Devices.ContainsKey(handle) ? Devices[handle] : null;
            }
        }

        bool IsValid(int index)
        {
            return IndexToDevice.ContainsKey(index);
        }

        #endregion

        #region IJoystickDriver2 Members

        public JoystickState GetState(int index)
        {
            lock (UpdateLock)
            {
                if (IsValid(index))
                {
                    return Devices[IndexToDevice[index]].GetState();
                }
                return new JoystickState();
            }
        }

        public JoystickCapabilities GetCapabilities(int index)
        {
            lock (UpdateLock)
            {
                if (IsValid(index))
                {
                    return Devices[IndexToDevice[index]].GetCapabilities();
                }
                return new JoystickCapabilities();
            }
        }

        public Guid GetGuid(int index)
        {
            lock (UpdateLock)
            {
                if (IsValid(index))
                {
                    return Devices[IndexToDevice[index]].GetGuid();
                }
                return new Guid();
            }
        }

        #endregion
    }
}
