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

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using OpenTK.Input;
using OpenTK.Platform.Common;

namespace OpenTK.Platform.Windows
{
    internal class WinRawJoystick : IJoystickDriver2
    {
        private class Device
        {
            public IntPtr Handle;
            private JoystickCapabilities Capabilities;
            private JoystickState State;
            private Guid Guid;

            internal readonly List<HidProtocolValueCaps> AxisCaps =
                new List<HidProtocolValueCaps>();
            internal readonly List<HidProtocolButtonCaps> ButtonCaps =
                new List<HidProtocolButtonCaps>();
            internal readonly bool IsXInput;
            internal readonly int XInputIndex;

            private readonly Dictionary<int, int> axes =
                new Dictionary<int, int>();

            private readonly Dictionary<int, int> buttons =
                new Dictionary<int, int>();

            private readonly Dictionary<int, JoystickHat> hats =
                new Dictionary<int, JoystickHat>();

            public Device(IntPtr handle, Guid guid, bool is_xinput, int xinput_index)
            {
                Handle = handle;
                Guid = guid;
                IsXInput = is_xinput;
                XInputIndex = xinput_index;
            }

            public void ClearButtons()
            {
                State.ClearButtons();
            }

            public void SetAxis(short collection, HIDPage page, short usage, short value)
            {
                if (page == HIDPage.GenericDesktop || page == HIDPage.Simulation) // set axis only when HIDPage is known by HidHelper.TranslateJoystickAxis() to avoid axis0 to be overwritten by unknown HIDPage
                {
                    //Certain joysticks (Speedlink Black Widow, PS3 pad connected via USB)
                    //return an invalid HID page of 1, so
                    if ((int)usage != 1)
                    {
                        int axis = GetAxis(collection, page, usage);
                        // Skip axes that we couldn't map to any of our known joystick axes
                        if (axis == -1) return;
                        State.SetAxis(axis, value);
                    }
                }
            }

            public void SetButton(short collection, HIDPage page, short usage, bool value)
            {
                int button = GetButton(collection, page, usage);
                State.SetButton(button, value);
            }

            public void SetHat(short collection, HIDPage page, short usage, HatPosition pos)
            {
                JoystickHat hat = GetHat(collection, page, usage);
                State.SetHat(hat, new JoystickHatState(pos));
            }

            public void SetConnected(bool value)
            {
                Capabilities.SetIsConnected(value);
                State.SetIsConnected(value);
            }

            public JoystickCapabilities GetCapabilities()
            {
                Capabilities = new JoystickCapabilities(
                    axes.Count, buttons.Count, hats.Count,
                    Capabilities.IsConnected);
                return Capabilities;
            }

            internal void SetCapabilities(JoystickCapabilities caps)
            {
                Capabilities = caps;
            }

            public Guid GetGuid()
            {
                return Guid;
            }

            public JoystickState GetState()
            {
                return State;
            }

            private static int MakeKey(short collection, HIDPage page, short usage)
            {
                byte coll_byte = unchecked((byte)collection);
                byte page_byte = unchecked((byte)(((ushort)page & 0xff00) >> 8 | ((ushort)page & 0xff)));
                return (coll_byte << 24) | (page_byte << 16) | unchecked((ushort)usage);
            }

            private int GetAxis(short collection, HIDPage page, short usage)
            {
                int key = MakeKey(collection, page, usage);
                if (!axes.ContainsKey(key))
                {
                    int axis = HidHelper.TranslateJoystickAxis(page, usage);
                    axes.Add(key, axis);
                }
                return axes[key];
            }

            private int GetButton(short collection, HIDPage page, short usage)
            {
                int key = MakeKey(collection, page, usage);
                if (!buttons.ContainsKey(key))
                {
                    buttons.Add(key, buttons.Count);
                }
                return buttons[key];
            }

            private JoystickHat GetHat(short collection, HIDPage page, short usage)
            {
                int key = MakeKey(collection, page, usage);
                if (!hats.ContainsKey(key))
                {
                    hats.Add(key, JoystickHat.Hat0 + hats.Count);
                }
                return hats[key];
            }
        }

        private static readonly string TypeName = typeof(WinRawJoystick).Name;

        private XInputJoystick XInput = new XInputJoystick();

        // Defines which types of HID devices we are interested in
        private readonly RawInputDevice[] DeviceTypes;

        private readonly object UpdateLock = new object();
        private readonly DeviceCollection<Device> Devices = new DeviceCollection<Device>();

        private byte[] HIDData = new byte[1024];
        private byte[] PreparsedData = new byte[1024];
        private HidProtocolData[] DataBuffer = new HidProtocolData[16];

        public WinRawJoystick(IntPtr window)
        {
            Debug.WriteLine("Using WinRawJoystick.");
            Debug.Indent();

            if (window == IntPtr.Zero)
            {
                throw new ArgumentNullException("window");
            }

            DeviceTypes = new RawInputDevice[]
            {
                new RawInputDevice(HIDUsageGD.Joystick, RawInputDeviceFlags.DEVNOTIFY | RawInputDeviceFlags.INPUTSINK, window),
                new RawInputDevice(HIDUsageGD.GamePad, RawInputDeviceFlags.DEVNOTIFY | RawInputDeviceFlags.INPUTSINK, window),
                new RawInputDevice(HIDUsageCD.ConsumerControl, RawInputDeviceFlags.DEVNOTIFY | RawInputDeviceFlags.INPUTSINK, window),
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

        public void RefreshDevices()
        {
            // Mark all devices as disconnected. We will check which of those
            // are connected below.
            foreach (var device in Devices)
            {
                device.SetConnected(false);
            }

            // Discover joystick devices
            int xinput_device_count = 0;
            RawInputDeviceList[] deviceList = WinRawInput.GetDeviceList();
            foreach (RawInputDeviceList dev in deviceList)
            {
                // Skip non-joystick devices
                if (dev.Type != RawInputDeviceType.HID)
                {
                    continue;
                }

                // We use the device handle as the hardware id.
                // This works, but the handle will change whenever the
                // device is unplugged/replugged. We compensate for this
                // by checking device GUIDs, below.
                // Note: we cannot use the GUID as the hardware id,
                // because it is costly to query (and we need to query
                // that every time we process a device event.)
                IntPtr handle = dev.Device;
                bool is_xinput = IsXInput(handle);
                Guid guid = GetDeviceGuid(handle);
                long hardware_id = handle.ToInt64();

                Device device = Devices.FromHardwareId(hardware_id);
                if (device != null)
                {
                    // We have already opened this device, mark it as connected
                    device.SetConnected(true);
                }
                else
                {
                    device = new Device(handle, guid, is_xinput,
                        is_xinput ? xinput_device_count++ : 0);

                    // This is a new device, query its capabilities and add it
                    // to the device list
                    if (!QueryDeviceCaps(device) && !is_xinput)
                    {
                        continue;
                    }
                    device.SetConnected(true);

                    // Check if a disconnected device with identical GUID already exists.
                    // If so, replace that device with this instance.
                    Device match = null;
                    foreach (Device candidate in Devices)
                    {
                        if (candidate.GetGuid() == guid && !candidate.GetCapabilities().IsConnected)
                        {
                            match = candidate;
                        }
                    }
                    if (match != null)
                    {
                        Devices.Remove(match.Handle.ToInt64());
                    }

                    Devices.Add(hardware_id, device);

                    Debug.Print("[{0}] Connected joystick {1} ({2})",
                        GetType().Name, device.GetGuid(), device.GetCapabilities());
                }
            }
        }

        public unsafe bool ProcessEvent(IntPtr raw)
        {
            // Query the size of the raw HID data buffer
            int size = 0;
            Functions.GetRawInputData(raw, GetRawInputDataEnum.INPUT, IntPtr.Zero, ref size, RawInputHeader.SizeInBytes);
            if (size > HIDData.Length)
            {
                Array.Resize(ref HIDData, size);
            }

            // Retrieve the raw HID data buffer
            if (Functions.GetRawInputData(raw, HIDData) > 0)
            {
                fixed (byte* pdata = HIDData)
                {
                    RawInput* rin = (RawInput*)pdata;

                    IntPtr handle = rin->Header.Device;
                    Device stick = GetDevice(handle);
                    if (stick == null)
                    {
                        Debug.Print("[WinRawJoystick] Unknown device {0}", handle);
                        return false;
                    }

                    if (stick.IsXInput)
                    {
                        return true;
                    }

                    if (!GetPreparsedData(handle, ref PreparsedData))
                    {
                        return false;
                    }

                    // Query current state
                    // Allocate enough storage to hold the data of the current report
                    int report_count = HidProtocol.MaxDataListLength(HidProtocolReportType.Input, PreparsedData);
                    if (report_count == 0)
                    {
                        Debug.Print("[WinRawJoystick] HidProtocol.MaxDataListLength() failed with {0}",
                            Marshal.GetLastWin32Error());
                        return false;
                    }

                    // Fill the data buffer
                    if (DataBuffer.Length < report_count)
                    {
                        Array.Resize(ref DataBuffer, report_count);
                    }

                    UpdateAxes(rin, stick);
                    UpdateButtons(rin, stick);
                    return true;
                }
            }

            return false;
        }

        private HatPosition GetHatPosition(uint value, HidProtocolValueCaps caps)
        {
            if (value > caps.LogicalMax)
            {
                //Return zero if our value is out of bounds ==> e.g.
                //Thrustmaster T-Flight Hotas X returns 15 for the centered position
                return HatPosition.Centered;
            }
            if (caps.LogicalMax == 3)
            {
                //4-way hat switch as per the example in Appendix C
                //http://www.usb.org/developers/hidpage/Hut1_12v2.pdf
                switch (value)
                {
                    case 0:
                        return HatPosition.Left;
                    case 1:
                        return HatPosition.Up;
                    case 2:
                        return HatPosition.Right;
                    case 3:
                        return HatPosition.Down;
                }
            }
            if (caps.LogicalMax == 8)
            {
                //Hat states are represented as a plain number from 0-8
                //with centered being zero
                //Padding should have already been stripped out, so just cast
                return (HatPosition)value;
            }
            if (caps.LogicalMax == 7)
            {
                //Hat states are represented as a plain number from 0-7
                //with centered being 8
                value++;
                value %= 9;
                return (HatPosition)value;
            }
            //The HID report length is unsupported
            return HatPosition.Centered;
        }

        private unsafe void UpdateAxes(RawInput* rin, Device stick)
        {
            for (int i = 0; i < stick.AxisCaps.Count; i++)
            {
                if (stick.AxisCaps[i].IsRange)
                {
                    Debug.Print("[{0}] Axis range collections not implemented. Please report your controller type at https://github.com/opentk/opentk/issues",
                        GetType().Name);
                    continue;
                }

                HIDPage page = stick.AxisCaps[i].UsagePage;
                short usage = stick.AxisCaps[i].NotRange.Usage;
                uint value = 0;
                short collection = stick.AxisCaps[i].LinkCollection;

                HidProtocolStatus status = HidProtocol.GetUsageValue(
                    HidProtocolReportType.Input,
                    page, 0, usage, ref value,
                    PreparsedData,
                    new IntPtr((void*)&rin->Data.HID.RawData),
                    rin->Data.HID.Size);

                if (status != HidProtocolStatus.Success)
                {
                    Debug.Print("[{0}] HidProtocol.GetScaledUsageValue() failed. Error: {1}",
                        GetType().Name, status);
                    continue;
                }

                if (page == HIDPage.GenericDesktop && (HIDUsageGD)usage == HIDUsageGD.Hatswitch)
                {
                    stick.SetHat(collection, page, usage, GetHatPosition(value, stick.AxisCaps[i]));
                }
                else
                {
                    if (stick.AxisCaps[i].LogicalMin > 0)
                    {
                        short scaled_value = (short)HidHelper.ScaleValue(
                            (int)((long)value + stick.AxisCaps[i].LogicalMin),
                            stick.AxisCaps[i].LogicalMin, stick.AxisCaps[i].LogicalMax,
                            Int16.MinValue, Int16.MaxValue);
                        stick.SetAxis(collection, page, usage, scaled_value);
                    }
                    else
                    {
                        //If our stick returns a minimum value below zero, we should not add this to our value
                        //before attempting to scale it, as this then inverts the value
                        short scaled_value = (short)HidHelper.ScaleValue(
                            (int)(long)value,
                            stick.AxisCaps[i].LogicalMin, stick.AxisCaps[i].LogicalMax,
                            Int16.MinValue, Int16.MaxValue);
                        stick.SetAxis(collection, page, usage, scaled_value);
                    }
                }
            }
        }

        private unsafe void UpdateButtons(RawInput* rin, Device stick)
        {
            stick.ClearButtons();

            for (int i = 0; i < stick.ButtonCaps.Count; i++)
            {
                short* usage_list = stackalloc short[64];
                int usage_length = 64;
                HIDPage page = stick.ButtonCaps[i].UsagePage;
                short collection = stick.ButtonCaps[i].LinkCollection;

                HidProtocolStatus status = HidProtocol.GetUsages(
                    HidProtocolReportType.Input,
                    page, 0, usage_list, ref usage_length,
                    PreparsedData,
                    new IntPtr((void*)&rin->Data.HID.RawData),
                    rin->Data.HID.Size);

                if (status != HidProtocolStatus.Success)
                {
                    Debug.Print("[WinRawJoystick] HidProtocol.GetUsages() failed with {0}",
                        Marshal.GetLastWin32Error());
                    continue;
                }

                for (int j = 0; j < usage_length; j++)
                {
                    short usage = *(usage_list + j);
                    stick.SetButton(collection, page, usage, true);
                }
            }
        }

        private static bool GetPreparsedData(IntPtr handle, ref byte[] prepared_data)
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

        private bool QueryDeviceCaps(Device stick)
        {
            Debug.Print("[{0}] Querying joystick {1}",
                TypeName, stick.GetGuid());

            bool anyInputDetected = false;
            try
            {
                Debug.Indent();
                HidProtocolCaps caps;

                if (!GetPreparsedData(stick.Handle, ref PreparsedData) ||
                    !GetDeviceCaps(stick, PreparsedData, out caps))
                    return false;

                if (stick.AxisCaps.Count >= JoystickState.MaxAxes ||
                    stick.ButtonCaps.Count >= JoystickState.MaxButtons)
                {
                    Debug.Print("Device {0} has {1} and {2} buttons. This might be a touch device - skipping.",
                        stick.Handle, stick.AxisCaps.Count, stick.ButtonCaps.Count);
                    return false;
                }

                for (int i = 0; i < stick.AxisCaps.Count; i++)
                {
                    Debug.Print("Analyzing value collection {0} {1} {2}",
                        i,
                        stick.AxisCaps[i].IsRange ? "range" : "",
                        stick.AxisCaps[i].IsAlias ? "alias" : "");

                    if (stick.AxisCaps[i].IsRange || stick.AxisCaps[i].IsAlias)
                    {
                        Debug.Print("Skipping value collection {0}", i);
                        continue;
                    }

                    HIDPage page = stick.AxisCaps[i].UsagePage;
                    short collection = stick.AxisCaps[i].LinkCollection;
                    switch (page)
                    {
                        case HIDPage.GenericDesktop:
                            HIDUsageGD gd_usage = (HIDUsageGD)stick.AxisCaps[i].NotRange.Usage;
                            switch (gd_usage)
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
                                    Debug.Print("Found axis {0} ({1} / {2})",
                                        stick.GetCapabilities().AxisCount,
                                        page, (HIDUsageGD)stick.AxisCaps[i].NotRange.Usage);
                                    stick.SetAxis(collection, page, stick.AxisCaps[i].NotRange.Usage, 0);
                                    anyInputDetected = true;
                                    break;

                                case HIDUsageGD.Hatswitch:
                                    Debug.Print("Found hat {0} ({1} / {2})",
                                        JoystickHat.Hat0 + stick.GetCapabilities().HatCount,
                                        page, (HIDUsageGD)stick.AxisCaps[i].NotRange.Usage);
                                    stick.SetHat(collection, page, stick.AxisCaps[i].NotRange.Usage, HatPosition.Centered);
                                    anyInputDetected = true;
                                    break;

                                default:
                                    Debug.Print("Unknown usage {0} for page {1}",
                                        gd_usage, page);
                                    break;
                            }
                            break;

                        case HIDPage.Simulation:
                            switch ((HIDUsageSim)stick.AxisCaps[i].NotRange.Usage)
                            {
                                case HIDUsageSim.Rudder:
                                case HIDUsageSim.Throttle:
                                    Debug.Print("Found simulation axis {0} ({1} / {2})",
                                        stick.GetCapabilities().AxisCount,
                                        page, (HIDUsageSim)stick.AxisCaps[i].NotRange.Usage);
                                    stick.SetAxis(collection, page, stick.AxisCaps[i].NotRange.Usage, 0);
                                    anyInputDetected = true;
                                    break;
                            }
                            break;

                        default:
                            Debug.Print("Unknown page {0}", page);
                            break;
                    }
                }

                for (int i = 0; i < stick.ButtonCaps.Count; i++)
                {
                    Debug.Print("Analyzing button collection {0} {1} {2}",
                        i,
                        stick.ButtonCaps[i].IsRange ? "range" : "",
                        stick.ButtonCaps[i].IsAlias ? "alias" : "");

                    if (stick.ButtonCaps[i].IsAlias)
                    {
                        Debug.Print("Skipping button collection {0}", i);
                        continue;
                    }

                    bool is_range = stick.ButtonCaps[i].IsRange;
                    HIDPage page = stick.ButtonCaps[i].UsagePage;
                    short collection = stick.ButtonCaps[i].LinkCollection;
                    switch (page)
                    {
                        case HIDPage.Button:
                            if (is_range)
                            {
                                for (short usage = stick.ButtonCaps[i].Range.UsageMin; usage <= stick.ButtonCaps[i].Range.UsageMax; usage++)
                                {
                                    Debug.Print("Found button {0} ({1} / {2})",
                                        stick.GetCapabilities().ButtonCount,
                                        page, usage);
                                    stick.SetButton(collection, page, usage, false);
                                    anyInputDetected = true;
                                }
                            }
                            else
                            {
                                Debug.Print("Found button {0} ({1} / {2})",
                                    stick.GetCapabilities().ButtonCount,
                                    page, stick.ButtonCaps[i].NotRange.Usage);
                                stick.SetButton(collection, page, stick.ButtonCaps[i].NotRange.Usage, false);
                                anyInputDetected = true;
                            }
                            break;

                        default:
                            Debug.Print("Unknown page {0} for button.", page);
                            break;
                    }
                }
            }
            finally
            {
                Debug.Unindent();
            }

            return anyInputDetected;
        }


        private static bool GetDeviceCaps(Device stick, byte[] preparsed_data, out HidProtocolCaps caps)
        {
            // Query joystick capabilities
            caps = new HidProtocolCaps();
            if (HidProtocol.GetCaps(preparsed_data, ref caps) != HidProtocolStatus.Success)
            {
                Debug.Print("[WinRawJoystick] HidProtocol.GetCaps() failed with {0}",
                    Marshal.GetLastWin32Error());
                return false;
            }

            // Make sure our caps arrays are big enough
            HidProtocolValueCaps[] axis_caps = new HidProtocolValueCaps[caps.NumberInputValueCaps];
            HidProtocolButtonCaps[] button_caps = new HidProtocolButtonCaps[caps.NumberInputButtonCaps];

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

            stick.AxisCaps.Clear();
            stick.AxisCaps.AddRange(axis_caps);

            stick.ButtonCaps.Clear();
            stick.ButtonCaps.AddRange(button_caps);

            return true;
        }

        // Get a DirectInput-compatible Guid
        // (equivalent to DIDEVICEINSTANCE guidProduct field)
        private Guid GetDeviceGuid(IntPtr handle)
        {
            // Retrieve a RID_DEVICE_INFO struct which contains the VID and PID
            RawInputDeviceInfo info = new RawInputDeviceInfo();
            int size = info.Size;
            if (Functions.GetRawInputDeviceInfo(handle, RawInputDeviceInfoEnum.DEVICEINFO, info, ref size) < 0)
            {
                Debug.Print("[WinRawJoystick] Functions.GetRawInputDeviceInfo(DEVICEINFO) failed with error {0}",
                    Marshal.GetLastWin32Error());
                return Guid.Empty;
            }

            // Todo: this Guid format is only valid for USB joysticks.
            // Bluetooth devices, such as OUYA controllers, have a totally
            // different PID/VID format in DirectInput.
            // Do we need to use the same guid or could we simply use PID/VID
            // there too? (Test with an OUYA controller.)
            int vid = info.Device.HID.VendorId;
            int pid = info.Device.HID.ProductId;
            return new Guid(
                (pid << 16) | vid,
                0, 0,
                0, 0,
                (byte)'P', (byte)'I', (byte)'D',
                (byte)'V', (byte)'I', (byte)'D');
        }

        // Checks whether this is an XInput device.
        // XInput devices should be handled through
        // the XInput API.
        private bool IsXInput(IntPtr handle)
        {
            bool is_xinput = false;

            unsafe
            {
                // Find out how much memory we need to allocate
                // for the DEVICENAME string
                int size = 0;
                if (Functions.GetRawInputDeviceInfo(handle, RawInputDeviceInfoEnum.DEVICENAME, IntPtr.Zero, ref size) < 0 || size == 0)
                {
                    Debug.Print("[WinRawJoystick] Functions.GetRawInputDeviceInfo(DEVICENAME) failed with error {0}",
                        Marshal.GetLastWin32Error());
                    return is_xinput;
                }

                // Allocate memory and retrieve the DEVICENAME string
                sbyte* pname = stackalloc sbyte[size + 1];
                if (Functions.GetRawInputDeviceInfo(handle, RawInputDeviceInfoEnum.DEVICENAME, (IntPtr)pname, ref size) < 0)
                {
                    Debug.Print("[WinRawJoystick] Functions.GetRawInputDeviceInfo(DEVICENAME) failed with error {0}",
                        Marshal.GetLastWin32Error());
                    return is_xinput;
                }

                // Convert the buffer to a .Net string, and split it into parts
                string name = new string(pname);
                if (String.IsNullOrEmpty(name))
                {
                    Debug.Print("[WinRawJoystick] Failed to construct device name");
                    return is_xinput;
                }

                is_xinput = name.Contains("IG_");
            }

            return is_xinput;
        }

        private Device GetDevice(IntPtr handle)
        {
            long hardware_id = handle.ToInt64();
            bool is_device_known = false;

            lock (UpdateLock)
            {
                is_device_known = Devices.FromHardwareId(hardware_id) != null;
            }

            if (!is_device_known)
            {
                RefreshDevices();
            }

            lock (UpdateLock)
            {
                return Devices.FromHardwareId(hardware_id);
            }
        }

        private bool IsValid(int index)
        {
            return Devices.FromIndex(index) != null;
        }

        public JoystickState GetState(int index)
        {
            lock (UpdateLock)
            {
                if (IsValid(index))
                {
                    Device dev = Devices.FromIndex(index);
                    if (dev.IsXInput)
                    {
                        return XInput.GetState(dev.XInputIndex);
                    }
                    else
                    {
                        return dev.GetState();
                    }
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
                    Device dev = Devices.FromIndex(index);
                    if (dev.IsXInput)
                    {
                        return XInput.GetCapabilities(dev.XInputIndex);
                    }
                    else
                    {
                        return dev.GetCapabilities();
                    }
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
                    Device dev = Devices.FromIndex(index);
                    if (dev.IsXInput)
                    {
                        return XInput.GetGuid(dev.XInputIndex);
                    }
                    else
                    {
                        return dev.GetGuid();
                    }
                }
                return new Guid();
            }
        }
    }
}
