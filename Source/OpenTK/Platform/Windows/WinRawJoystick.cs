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
            RefreshDevices();

            Debug.Unindent();
        }

        #region Public Members

        public void RefreshDevices()
        {
            if (!Functions.RegisterRawInputDevices(DeviceTypes, DeviceTypes.Length, API.RawInputDeviceSize))
            {
                Debug.Print("[Warning] Raw input registration failed with error: {0}.",
                    Marshal.GetLastWin32Error());
            }
            else
            {
                Debug.Print("Registered for raw joystick input");
            }
        }

        public unsafe bool ProcessEvent(RawInput* rin)
        {
            IntPtr handle = rin->Header.Device;
            Device stick = GetDevice(handle);
            if (stick == null)
            {
                Debug.Print("[WinRawJoystick] Unknown device {0}", handle);
                return false;
            }

            // Query the size of the _HIDP_PREPARSED_DATA structure for this event.
            int preparsed_size = 0;
            Functions.GetRawInputDeviceInfo(rin->Header.Device, RawInputDeviceInfoEnum.PREPARSEDDATA,
                IntPtr.Zero, ref preparsed_size);
            if (preparsed_size == 0)
                return false;

            // Allocate space for _HIDP_PREPARSED_DATA.
            // This is an untyped blob of data.
            void* preparsed_data_ptr = stackalloc byte[preparsed_size];
            IntPtr preparsed_data = (IntPtr)preparsed_data_ptr;
            if (Functions.GetRawInputDeviceInfo(rin->Header.Device, RawInputDeviceInfoEnum.PREPARSEDDATA,
                preparsed_data, ref preparsed_size) < 0)
                return false;

            // Query joystick capabilities
            HidProtocolCaps caps = new HidProtocolCaps();
            if (HidProtocol.GetCaps(preparsed_data, ref caps) != HidProtocolStatus.Success)
                return false;

            // Axis capabilities
            HidProtocolValueCaps* axes_caps = stackalloc HidProtocolValueCaps[caps.NumberInputValueCaps];
            if (HidProtocol.GetValueCaps(HidProtocolReportType.Input,
                (IntPtr)axes_caps, ref caps.NumberInputValueCaps, preparsed_data) !=
                HidProtocolStatus.Success)
            {
                return false;
            }

            // Button capabilities
            HidProtocolButtonCaps* button_caps = stackalloc HidProtocolButtonCaps[caps.NumberInputButtonCaps];
            if (HidProtocol.GetButtonCaps(HidProtocolReportType.Input,
                (IntPtr)button_caps, ref caps.NumberInputButtonCaps, preparsed_data) !=
                HidProtocolStatus.Success)
            {
                Debug.Print("[WinRawJoystick] HidProtocol.GetButtonCaps() failed with {0}",
                    Marshal.GetLastWin32Error());
                return false;
            }

            // Query current state
            // Allocate enough storage to hold the data of the current report
            int size = HidProtocol.MaxDataListLength(HidProtocolReportType.Input, preparsed_data);
            if (size == 0)
            {
                Debug.Print("[WinRawJoystick] HidProtocol.MaxDataListLength() failed with {0}",
                    Marshal.GetLastWin32Error());
                return false;
            }

            // Fill the data buffer
            HidProtocolData* data = stackalloc HidProtocolData[size];
            if (HidProtocol.GetData(HidProtocolReportType.Input,
                (IntPtr)data, ref size, preparsed_data,
                new IntPtr(&rin->Data.HID.RawData), rin->Data.HID.Size) != HidProtocolStatus.Success)
            {
                Debug.Print("[WinRawJoystick] HidProtocol.GetData() failed with {0}",
                    Marshal.GetLastWin32Error());
                return false;
            }

            UpdateAxes(stick, caps, axes_caps, data);
            UpdateButtons(stick, caps, button_caps, data);

#if false
            // Button state
            //g_NumberOfButtons = pButtonCaps->Range.UsageMax - pButtonCaps->Range.UsageMin + 1;
#endif

            return true;
        }

        unsafe static void UpdateAxes(Device stick, HidProtocolCaps caps, HidProtocolValueCaps* axes_caps, HidProtocolData* data)
        {
            // Use the data indices in the axis and button caps arrays to
            // access the data buffer we just filled.
            for (int i = 0; i < caps.NumberInputValueCaps; i++)
            {
                HidProtocolValueCaps* axis = axes_caps + i;
                if (!axis->IsRange)
                {
                    int index = axis->NotRange.DataIndex;
                    if (index < 0 || index >= caps.NumberInputValueCaps)
                    {
                        // Should never happen
                        Debug.Print("[WinRawJoystick] Error: DataIndex out of range");
                        continue;
                    }

                    HidProtocolData* d = (data + index);
                    if (d->DataIndex != index)
                    {
                        // Should also never happen
                        Debug.Print("[WinRawJoystick] DataIndex != index ({0} != {1})",
                            d->DataIndex, index);
                        continue;
                    }

                    short value = (short)HidHelper.ScaleValue(d->RawValue,
                        axis->LogicalMin, axis->LogicalMax,
                        short.MinValue, short.MaxValue);

                    stick.SetAxis(axis->UsagePage, axis->NotRange.Usage, value);
                }
                else
                {
                    // Todo: fall back to HidProtocol.GetLinkCollectionNodes
                }
            }
        }

        unsafe static void UpdateButtons(Device stick, HidProtocolCaps caps, HidProtocolButtonCaps* button_caps, HidProtocolData* data)
        {
            for (int i = 0; i < caps.NumberInputButtonCaps; i++)
            {
                HidProtocolButtonCaps* button = button_caps + i;
                if (!button->IsRange)
                {
                    int index = button->NotRange.DataIndex;
                    if (index < 0 || index >= caps.NumberInputButtonCaps)
                    {
                        // Should never happen
                        Debug.Print("[WinRawJoystick] Error: DataIndex out of range");
                        continue;
                    }

                    HidProtocolData* d = (data + index);
                    if (d->DataIndex != index)
                    {
                        // Should also never happen
                        Debug.Print("[WinRawJoystick] DataIndex != index ({0} != {1})",
                            d->DataIndex, index);
                        continue;
                    }

                    bool value = d->On;

                    stick.SetButton(button->UsagePage, button->NotRange.Usage, value);
                }
                else
                {
                    // Todo: fall back to HidProtocol.GetLinkCollectionNodes
                }
            }
        }

        #endregion

        #region Private Members

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
