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
using OpenTK.Input.Hid;
using OpenTK.Input;
using OpenTK.NT.Native;
using OpenTK.Mathematics;

namespace OpenTK.Platform.Windows
{
    internal class WinRawJoystick : IJoystickDriver2
    {
        private static readonly string TypeName = typeof(WinRawJoystick).Name;
        private readonly DeviceCollection<Device> Devices = new DeviceCollection<Device>();

        // Defines which types of HID devices we are interested in
        private readonly RawInputDevice[] DeviceTypes;

        private readonly object UpdateLock = new object();

        private readonly XInputJoystick XInput = new XInputJoystick();
        private HidProtocolData[] DataBuffer = new HidProtocolData[16];

        private RawInput _rawData = default(RawInput);
        private byte[] PreparsedData = new byte[1024];

        public WinRawJoystick(IntPtr window)
        {
            Debug.WriteLine("Using WinRawJoystick.");
            Debug.Indent();

            if (window == IntPtr.Zero)
                throw new ArgumentNullException(nameof(window));

            DeviceTypes = new[]
            {
                new RawInputDevice(HidGenericDesktopUsage.Joystick, RawInputDeviceFlags.DevNotify | RawInputDeviceFlags.InputSink,
                    window),
                new RawInputDevice(HidGenericDesktopUsage.GamePad, RawInputDeviceFlags.DevNotify | RawInputDeviceFlags.InputSink,
                    window),
                new RawInputDevice(HidConsumerUsage.ConsumerControl,
                    RawInputDeviceFlags.DevNotify | RawInputDeviceFlags.InputSink, window)
            };

            if (!User32.RawInput.RegisterRawInputDevices(DeviceTypes, (uint)DeviceTypes.Length, RawInputDevice.SizeInBytes))
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

        public JoystickState GetState(int index)
        {
            lock (UpdateLock)
            {
                if (IsValid(index))
                {
                    var dev = Devices.FromIndex(index);
                    if (dev.IsXInput)
                        return XInput.GetState(dev.XInputIndex);

                    return dev.GetState();
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
                    var dev = Devices.FromIndex(index);
                    if (dev.IsXInput)
                        return XInput.GetCapabilities(dev.XInputIndex);

                    return dev.GetCapabilities();
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
                    var dev = Devices.FromIndex(index);
                    if (dev.IsXInput)
                        return XInput.GetGuid(dev.XInputIndex);

                    return dev.GetGuid();
                }

                return new Guid();
            }
        }

        public void RefreshDevices()
        {
            // Mark all devices as disconnected. We will check which of those
            // are connected below.
            foreach (var device in Devices)
                device.SetConnected(false);

            // Discover joystick devices
            var xinput_device_count = 0;
            foreach (var dev in WinRawInput.GetDeviceList())
            {
                // Skip non-joystick devices
                if (dev.Type != RawInputDeviceType.Hid)
                    continue;

                // We use the device handle as the hardware id.
                // This works, but the handle will change whenever the
                // device is unplugged/replugged. We compensate for this
                // by checking device GUIDs, below.
                // Note: we cannot use the GUID as the hardware id,
                // because it is costly to query (and we need to query
                // that every time we process a device event.)
                var handle = dev.Device;
                var is_xinput = IsXInput(handle);
                var guid = GetDeviceGuid(handle);
                var hardware_id = handle.ToInt64();

                var device = Devices.FromHardwareId(hardware_id);
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
                        continue;

                    device.SetConnected(true);

                    // Check if a disconnected device with identical GUID already exists.
                    // If so, replace that device with this instance.
                    Device match = null;
                    foreach (var candidate in Devices)
                        if (candidate.GetGuid() == guid && !candidate.GetCapabilities().IsConnected)
                            match = candidate;

                    if (match != null)
                        Devices.Remove(match.Handle.ToInt64());

                    Devices.Add(hardware_id, device);

                    Debug.Print("[{0}] Connected joystick {1} ({2})",
                        GetType().Name, device.GetGuid(), device.GetCapabilities());
                }
            }
        }

        public unsafe bool ProcessEvent(IntPtr raw)
        {
            // Query the size of the raw HID data buffer
            uint size = 0;
            User32.RawInput.GetRawInputData(raw, GetRawInputDataCommand.Input, IntPtr.Zero, ref size,
                RawInputHeader.SizeInBytes);

            // Retrieve the raw HID data buffer
            if (User32.RawInput.GetRawInputData(raw, out _rawData) > 0)
            {
                fixed (RawInput* rin = &_rawData)
                {
                    var handle = rin->Header.Device;
                    var stick = GetDevice(handle);
                    if (stick == null)
                    {
                        Debug.Print("[WinRawJoystick] Unknown device {0}", handle);
                        return false;
                    }

                    if (stick.IsXInput)
                        return true;

                    if (!GetPreparsedData(handle, ref PreparsedData))
                        return false;

                    // Query current state
                    // Allocate enough storage to hold the data of the current report
                    var report_count = HidProtocol.MaxDataListLength(HidProtocolReportType.Input, PreparsedData);
                    if (report_count == 0)
                    {
                        Debug.Print("[WinRawJoystick] HidProtocol.MaxDataListLength() failed with {0}",
                            Marshal.GetLastWin32Error());
                        return false;
                    }

                    // Fill the data buffer
                    if (DataBuffer.Length < report_count)
                        Array.Resize(ref DataBuffer, report_count);

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
            for (var i = 0; i < stick.AxisCaps.Count; i++)
            {
                if (stick.AxisCaps[i].IsRange)
                {
                    Debug.Print(
                        "[{0}] Axis range collections not implemented. Please report your controller type at https://github.com/opentk/opentk/issues",
                        GetType().Name);
                    continue;
                }

                var page = stick.AxisCaps[i].UsagePage;
                var usage = stick.AxisCaps[i].NotRange.Usage;
                uint value = 0;
                var collection = stick.AxisCaps[i].LinkCollection;

                var status = HidProtocol.GetUsageValue(
                    HidProtocolReportType.Input,
                    page, 0, usage, ref value,
                    PreparsedData,
                    new IntPtr(&rin->Data.Hid.RawData),
                    (int)rin->Data.Hid.SizeHid
                );

                if (status != HidProtocolStatus.Success)
                {
                    Debug.Print("[{0}] HidProtocol.GetScaledUsageValue() failed. Error: {1}",
                        GetType().Name, status);
                    continue;
                }

                if (page == HidPage.GenericDesktop && (HidGenericDesktopUsage)usage == HidGenericDesktopUsage.Hatswitch)
                {
                    stick.SetHat(collection, page, usage, GetHatPosition(value, stick.AxisCaps[i]));
                }
                else if (stick.AxisCaps[i].LogicalMin > 0)
                {
                    short scaled_value = (short)MathHelper.ScaleValue(
                        (int)(value + stick.AxisCaps[i].LogicalMin),
                        stick.AxisCaps[i].LogicalMin,
                        stick.AxisCaps[i].LogicalMax,
                        short.MinValue,
                        short.MaxValue
                    );

                    stick.SetAxis(collection, page, usage, scaled_value);
                }
                else
                {
                    //If our stick returns a minimum value below zero, we should not add this to our value
                    //before attempting to scale it, as this then inverts the value
                    var scaled_value = (short)MathHelper.ScaleValue(
                        (int)value,
                        stick.AxisCaps[i].LogicalMin,
                        stick.AxisCaps[i].LogicalMax,
                        short.MinValue,
                        short.MaxValue
                    );

                    stick.SetAxis(collection, page, usage, scaled_value);
                }
            }
        }

        private unsafe void UpdateButtons(RawInput* rin, Device stick)
        {
            stick.ClearButtons();

            for (var i = 0; i < stick.ButtonCaps.Count; i++)
            {
                short* usage_list = stackalloc short[64];
                var usage_length = 64;
                var page = stick.ButtonCaps[i].UsagePage;
                var collection = stick.ButtonCaps[i].LinkCollection;

                var status = HidProtocol.GetUsages(
                    HidProtocolReportType.Input,
                    page, 0, usage_list, ref usage_length,
                    PreparsedData,
                    new IntPtr(&rin->Data.Hid.RawData),
                    (int)rin->Data.Hid.SizeHid
                );

                if (status != HidProtocolStatus.Success)
                {
                    Debug.Print("[WinRawJoystick] HidProtocol.GetUsages() failed with {0}",
                        Marshal.GetLastWin32Error());
                    continue;
                }

                for (var j = 0; j < usage_length; j++)
                {
                    var usage = *(usage_list + j);
                    stick.SetButton(collection, page, usage, true);
                }
            }
        }

        private static bool GetPreparsedData(IntPtr handle, ref byte[] preparsed_data)
        {
            // Query the size of the _HIDP_PREPARSED_DATA structure for this event.
            uint preparsed_size = 0;
            User32.RawInput.GetRawInputDeviceInfo(handle, GetRawInputDeviceInfoEnum.PreparsedData,
                IntPtr.Zero, ref preparsed_size);
            if (preparsed_size == 0)
            {
                Debug.Print("[WinRawJoystick] GetRawInputDeviceInfo(PARSEDDATA) failed with {0}",
                    Marshal.GetLastWin32Error());
                return false;
            }

            // Allocate space for _HIDP_PREPARSED_DATA.
            // This is an untyped blob of data.
            if (preparsed_data.Length < preparsed_size)
                Array.Resize(ref preparsed_data, (int)preparsed_size);

            if (User32.RawInput.GetRawInputDeviceInfo(handle, GetRawInputDeviceInfoEnum.PreparsedData,
                    preparsed_data, ref preparsed_size) < 0)
            {
                Debug.Print("[WinRawJoystick] GetRawInputDeviceInfo(PARSEDDATA) failed with {0}",
                    Marshal.GetLastWin32Error());
                return false;
            }

            return true;
        }

        private bool QueryDeviceCaps(Device stick)
        {
            Debug.Print("[{0}] Querying joystick {1}",
                TypeName, stick.GetGuid());

            try
            {
                Debug.Indent();
                HidProtocolCaps caps;

                if (GetPreparsedData(stick.Handle, ref PreparsedData) &&
                    GetDeviceCaps(stick, PreparsedData, out caps))
                {
                    if (stick.AxisCaps.Count >= JoystickState.MaxAxes ||
                        stick.ButtonCaps.Count >= JoystickState.MaxButtons)
                    {
                        Debug.Print("Device {0} has {1} and {2} buttons. This might be a touch device - skipping.",
                            stick.Handle, stick.AxisCaps.Count, stick.ButtonCaps.Count);
                        return false;
                    }

                    for (var i = 0; i < stick.AxisCaps.Count; i++)
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

                        var page = stick.AxisCaps[i].UsagePage;
                        var collection = stick.AxisCaps[i].LinkCollection;
                        switch (page)
                        {
                            case HidPage.GenericDesktop:
                                var gd_usage = (HidGenericDesktopUsage)stick.AxisCaps[i].NotRange.Usage;
                                switch (gd_usage)
                                {
                                    case HidGenericDesktopUsage.X:
                                    case HidGenericDesktopUsage.Y:
                                    case HidGenericDesktopUsage.Z:
                                    case HidGenericDesktopUsage.RotationX:
                                    case HidGenericDesktopUsage.RotationY:
                                    case HidGenericDesktopUsage.RotationZ:
                                    case HidGenericDesktopUsage.Slider:
                                    case HidGenericDesktopUsage.Dial:
                                    case HidGenericDesktopUsage.Wheel:
                                        Debug.Print("Found axis {0} ({1} / {2})",
                                            stick.GetCapabilities().AxisCount,
                                            page, (HidGenericDesktopUsage)stick.AxisCaps[i].NotRange.Usage);
                                        stick.SetAxis(collection, page, stick.AxisCaps[i].NotRange.Usage, 0);
                                        break;

                                    case HidGenericDesktopUsage.Hatswitch:
                                        Debug.Print("Found hat {0} ({1} / {2})",
                                            JoystickHat.Hat0 + stick.GetCapabilities().HatCount,
                                            page, (HidGenericDesktopUsage)stick.AxisCaps[i].NotRange.Usage);
                                        stick.SetHat(collection, page, stick.AxisCaps[i].NotRange.Usage,
                                            HatPosition.Centered);
                                        break;

                                    default:
                                        Debug.Print("Unknown usage {0} for page {1}",
                                            gd_usage, page);
                                        break;
                                }

                                break;

                            case HidPage.Simulation:
                                switch ((HidSimulationUsage)stick.AxisCaps[i].NotRange.Usage)
                                {
                                    case HidSimulationUsage.Rudder:
                                    case HidSimulationUsage.Throttle:
                                        Debug.Print("Found simulation axis {0} ({1} / {2})",
                                            stick.GetCapabilities().AxisCount,
                                            page, (HidSimulationUsage)stick.AxisCaps[i].NotRange.Usage);
                                        stick.SetAxis(collection, page, stick.AxisCaps[i].NotRange.Usage, 0);
                                        break;
                                }

                                break;

                            default:
                                Debug.Print("Unknown page {0}", page);
                                break;
                        }
                    }

                    for (var i = 0; i < stick.ButtonCaps.Count; i++)
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

                        var is_range = stick.ButtonCaps[i].IsRange;
                        var page = stick.ButtonCaps[i].UsagePage;
                        var collection = stick.ButtonCaps[i].LinkCollection;
                        switch (page)
                        {
                            case HidPage.Button:
                                if (is_range)
                                {
                                    for (var usage = stick.ButtonCaps[i].Range.UsageMin;
                                        usage <= stick.ButtonCaps[i].Range.UsageMax;
                                        usage++)
                                    {
                                        Debug.Print("Found button {0} ({1} / {2})",
                                            stick.GetCapabilities().ButtonCount,
                                            page, usage);
                                        stick.SetButton(collection, page, usage, false);
                                    }
                                }
                                else
                                {
                                    Debug.Print("Found button {0} ({1} / {2})",
                                        stick.GetCapabilities().ButtonCount,
                                        page, stick.ButtonCaps[i].NotRange.Usage);
                                    stick.SetButton(collection, page, stick.ButtonCaps[i].NotRange.Usage, false);
                                }

                                break;

                            default:
                                Debug.Print("Unknown page {0} for button.", page);
                                break;
                        }
                    }
                }
                else
                {
                    return false;
                }
            }
            finally
            {
                Debug.Unindent();
            }

            return true;
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
            var axis_caps = new HidProtocolValueCaps[caps.NumberInputValueCaps];
            var button_caps = new HidProtocolButtonCaps[caps.NumberInputButtonCaps];

            // Axis capabilities
            var axis_count = (ushort)axis_caps.Length;
            if (HidProtocol.GetValueCaps(HidProtocolReportType.Input,
                    axis_caps, ref axis_count, preparsed_data) !=
                HidProtocolStatus.Success)
            {
                Debug.Print("[WinRawJoystick] HidProtocol.GetValueCaps() failed with {0}",
                    Marshal.GetLastWin32Error());
                return false;
            }

            // Button capabilities
            var button_count = (ushort)button_caps.Length;
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
            var info = new RawInputDeviceInfo();
            var size = info.Size;
            if (User32.RawInput.GetRawInputDeviceInfo(handle, GetRawInputDeviceInfoEnum.DeviceInfo, ref info, ref size) < 0)
            {
                Debug.Print("[WinRawJoystick] GetRawInputDeviceInfo(DEVICEINFO) failed with error {0}",
                    Marshal.GetLastWin32Error());
                return Guid.Empty;
            }

            // Todo: this Guid format is only valid for USB joysticks.
            // Bluetooth devices, such as OUYA controllers, have a totally
            // different PID/VID format in DirectInput.
            // Do we need to use the same guid or could we simply use PID/VID
            // there too? (Test with an OUYA controller.)
            var vid = info.Hid.VendorId;
            var pid = info.Hid.ProductId;
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
            var is_xinput = false;

            unsafe
            {
                // Find out how much memory we need to allocate
                // for the DEVICENAME string
                uint size = 0;
                if (User32.RawInput.GetRawInputDeviceInfo(handle, GetRawInputDeviceInfoEnum.DeviceName, IntPtr.Zero, ref size) <
                    0 || size == 0)
                {
                    Debug.Print("[WinRawJoystick] GetRawInputDeviceInfo(DEVICENAME) failed with error {0}",
                        Marshal.GetLastWin32Error());
                    return is_xinput;
                }

                // Allocate memory and retrieve the DEVICENAME string
                sbyte* pname = stackalloc sbyte[(int)size + 1];
                if (User32.RawInput.GetRawInputDeviceInfo(handle, GetRawInputDeviceInfoEnum.DeviceName, (IntPtr)pname,
                        ref size) < 0)
                {
                    Debug.Print("[WinRawJoystick] GetRawInputDeviceInfo(DEVICENAME) failed with error {0}",
                        Marshal.GetLastWin32Error());
                    return is_xinput;
                }

                // Convert the buffer to a .Net string, and split it into parts
                var name = new string(pname);
                if (string.IsNullOrEmpty(name))
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
            var hardware_id = handle.ToInt64();
            var is_device_known = false;

            lock (UpdateLock)
                is_device_known = Devices.FromHardwareId(hardware_id) != null;

            if (!is_device_known)
                RefreshDevices();

            lock (UpdateLock)
                return Devices.FromHardwareId(hardware_id);
        }

        private bool IsValid(int index)
            => Devices.FromIndex(index) != null;

        private class Device
        {
            private readonly Dictionary<int, int> axes =
                new Dictionary<int, int>();

            internal readonly List<HidProtocolValueCaps> AxisCaps =
                new List<HidProtocolValueCaps>();

            internal readonly List<HidProtocolButtonCaps> ButtonCaps =
                new List<HidProtocolButtonCaps>();

            private readonly Dictionary<int, int> buttons =
                new Dictionary<int, int>();

            private readonly Guid Guid;
            public readonly IntPtr Handle;

            private readonly Dictionary<int, JoystickHat> hats =
                new Dictionary<int, JoystickHat>();

            internal readonly bool IsXInput;
            internal readonly int XInputIndex;
            private JoystickCapabilities Capabilities;
            private JoystickState State;

            public Device(IntPtr handle, Guid guid, bool is_xinput, int xinput_index)
            {
                Handle = handle;
                Guid = guid;
                IsXInput = is_xinput;
                XInputIndex = xinput_index;
            }

            public void ClearButtons()
                => State.ClearButtons();

            public void SetAxis(short collection, HidPage page, short usage, short value)
            {
                // set axis only when HidPage is known by HidHelper.TranslateJoystickAxis() to avoid axis0 to be overwritten by unknown HidPage
                if (page == HidPage.GenericDesktop || page == HidPage.Simulation)
                {
                    //Certain joysticks (Speedlink Black Widow, PS3 pad connected via USB)
                    //return an invalid HID page of 1, so
                    if (usage != 1)
                    {
                        var axis = GetAxis(collection, page, usage);
                        State.SetAxis(axis, value);
                    }
                }
            }

            public void SetButton(short collection, HidPage page, short usage, bool value)
            {
                var button = GetButton(collection, page, usage);
                State.SetButton(button, value);
            }

            public void SetHat(short collection, HidPage page, short usage, HatPosition pos)
            {
                var hat = GetHat(collection, page, usage);
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
                => Capabilities = caps;

            public Guid GetGuid() => Guid;

            public JoystickState GetState() => State;

            private static int MakeKey(short collection, HidPage page, short usage)
            {
                var coll_byte = unchecked((byte)collection);
                var page_byte = unchecked((byte)((((ushort)page & 0xff00) >> 8) | ((ushort)page & 0xff)));
                return (coll_byte << 24) | (page_byte << 16) | unchecked((ushort)usage);
            }

            private int GetAxis(short collection, HidPage page, short usage)
            {
                var key = MakeKey(collection, page, usage);
                if (!axes.ContainsKey(key))
                {
                    var axis = HidHelper.TranslateJoystickAxis(page, usage);
                    axes.Add(key, axis);
                }

                return axes[key];
            }

            private int GetButton(short collection, HidPage page, short usage)
            {
                var key = MakeKey(collection, page, usage);
                if (!buttons.ContainsKey(key))
                    buttons.Add(key, buttons.Count);

                return buttons[key];
            }

            private JoystickHat GetHat(short collection, HidPage page, short usage)
            {
                var key = MakeKey(collection, page, usage);
                if (!hats.ContainsKey(key))
                    hats.Add(key, JoystickHat.Hat0 + hats.Count);

                return hats[key];
            }
        }
    }
}