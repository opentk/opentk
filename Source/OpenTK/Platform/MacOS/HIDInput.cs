#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2010 the Open Toolkit library.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to 
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//
#endregion

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using OpenTK.Input;

namespace OpenTK.Platform.MacOS
{
    using Carbon;
    using CFAllocatorRef = System.IntPtr;
    using CFDictionaryRef = System.IntPtr;
    using CFIndex = System.IntPtr;
    using CFRunLoop = System.IntPtr;
    using CFString = System.IntPtr;
    using CFStringRef = System.IntPtr; // Here used interchangeably with the CFString
    using CFTypeRef = System.IntPtr;
    using IOHIDDeviceRef = System.IntPtr;
    using IOHIDElementRef = System.IntPtr;
    using IOHIDManagerRef = System.IntPtr;
    using IOHIDValueRef = System.IntPtr;
    using IOOptionBits = System.IntPtr;
    using IOReturn = System.IntPtr;

    // Requires Mac OS X 10.5 or higher.
    // Todo: create a driver for older installations. Maybe use CGGetLastMouseDelta for that?
    class HIDInput : IMouseDriver2
    {
        #region Fields

        readonly IOHIDManagerRef hidmanager;

        readonly Dictionary<IntPtr, MouseState> MouseDevices =
            new Dictionary<IntPtr, MouseState>(new IntPtrEqualityComparer());
        readonly Dictionary<int, IntPtr> MouseIndexToDevice =
            new Dictionary<int, IntPtr>();

        readonly CFRunLoop RunLoop = CF.CFRunLoopGetMain();
        readonly CFString InputLoopMode = CF.RunLoopModeDefault;
        readonly CFDictionary DeviceTypes = new CFDictionary();

        readonly NativeMethods.IOHIDDeviceCallback HandleDeviceAdded;
        readonly NativeMethods.IOHIDDeviceCallback HandleDeviceRemoved;
        readonly NativeMethods.IOHIDValueCallback HandleDeviceValueReceived;

        #endregion

        #region Constructors

        public HIDInput()
        {
            Debug.Print("Using {0}.", typeof(HIDInput).Name);

            HandleDeviceAdded = DeviceAdded;
            HandleDeviceRemoved = DeviceRemoved;
            HandleDeviceValueReceived = DeviceValueReceived;

            hidmanager = CreateHIDManager();
            RegisterHIDCallbacks(hidmanager);
        }

        #endregion

         #region Private Members

        IOHIDManagerRef CreateHIDManager()
        {
            return NativeMethods.IOHIDManagerCreate(IntPtr.Zero, IntPtr.Zero);
        }

        // Registers callbacks for device addition and removal. These callbacks
        // are called when we run the loop in CheckDevicesMode
        void RegisterHIDCallbacks(IOHIDManagerRef hidmanager)
        {
            NativeMethods.IOHIDManagerRegisterDeviceMatchingCallback(
                hidmanager, HandleDeviceAdded, IntPtr.Zero);
            NativeMethods.IOHIDManagerRegisterDeviceRemovalCallback(
                hidmanager, HandleDeviceRemoved, IntPtr.Zero);
            NativeMethods.IOHIDManagerScheduleWithRunLoop(hidmanager,
                RunLoop, InputLoopMode);

            NativeMethods.IOHIDManagerSetDeviceMatching(hidmanager, DeviceTypes.Ref);
            NativeMethods.IOHIDManagerOpen(hidmanager, IOOptionBits.Zero);
        }

        void DeviceAdded(IntPtr context, IOReturn res, IntPtr sender, IOHIDDeviceRef device)
        {
            Debug.Print("Device {0} discovered", device);

            if (NativeMethods.IOHIDDeviceOpen(device, IOOptionBits.Zero) == IOReturn.Zero)
            {
                Debug.Print("Device {0} connected", device);

                if (NativeMethods.IOHIDDeviceConformsTo(device, HIDPage.GenericDesktop, (int)HIDUsageGD.Mouse))
                {
                    MouseState state = new MouseState();
                    state.IsConnected = true;
                    MouseIndexToDevice.Add(MouseDevices.Count, device);
                    MouseDevices.Add(device, state);
                }

                NativeMethods.IOHIDDeviceRegisterInputValueCallback(device,
                    HandleDeviceValueReceived, IntPtr.Zero);
                NativeMethods.IOHIDDeviceScheduleWithRunLoop(device, RunLoop, InputLoopMode);
            }
        }

        void DeviceRemoved(IntPtr context, IOReturn res, IntPtr sender, IOHIDDeviceRef device)
        {
            Debug.Print("Device {0} disconnected", device);

            if (NativeMethods.IOHIDDeviceConformsTo(device, HIDPage.GenericDesktop, (int)HIDUsageGD.Mouse) &&
                MouseDevices.ContainsKey(device))
            {
                // Keep the device in case it comes back later on
                MouseState state = MouseDevices[device];
                state.IsConnected = false;
                MouseDevices[device] = state;
            }

            NativeMethods.IOHIDDeviceRegisterInputValueCallback(device, null, IntPtr.Zero);
            NativeMethods.IOHIDDeviceUnscheduleWithRunLoop(device, RunLoop, InputLoopMode);
        }

        void DeviceValueReceived(IntPtr context, IOReturn res, IntPtr sender, IOHIDValueRef val)
        {
            MouseState mouse;
            if (MouseDevices.TryGetValue(sender, out mouse))
            {
                MouseDevices[sender] = UpdateMouse(mouse, val);
            }
        }

        static MouseState UpdateMouse(MouseState state, IOHIDValueRef val)
        {
            IOHIDElementRef elem = NativeMethods.IOHIDValueGetElement(val);
            int v_int = NativeMethods.IOHIDValueGetIntegerValue(val).ToInt32();
            //double v_physical = NativeMethods.IOHIDValueGetScaledValue(val, IOHIDValueScaleType.Physical);
            //double v_calbrated = NativeMethods.IOHIDValueGetScaledValue(val, IOHIDValueScaleType.Calibrated);
            HIDPage page = NativeMethods.IOHIDElementGetUsagePage(elem);
            int usage = NativeMethods.IOHIDElementGetUsage(elem);

            switch (page)
            {
                case HIDPage.GenericDesktop:
                    switch ((HIDUsageGD)usage)
                    {
                        case HIDUsageGD.X:
                            state.X += v_int;
                            break;

                        case HIDUsageGD.Y:
                            state.Y += v_int;
                            break;

                        case HIDUsageGD.Wheel:
                            state.WheelPrecise += v_int;
                            break;
                    }
                    break;

                case HIDPage.Button:
                    state[OpenTK.Input.MouseButton.Left + usage - 1] = v_int == 1;
                    break;
            }

            return state;
        }

        #endregion

        #region IMouseDriver2 Members

        MouseState IMouseDriver2.GetState()
        {
            MouseState master = new MouseState();
            foreach (KeyValuePair<IntPtr, MouseState> item in MouseDevices)
            {
                master.MergeBits(item.Value);
            }

            return master;
        }

        MouseState IMouseDriver2.GetState(int index)
        {
            IntPtr device;
            if (MouseIndexToDevice.TryGetValue(index, out device))
            {
                return MouseDevices[device];
            }

            return new MouseState();
        }

        void IMouseDriver2.SetPosition(double x, double y)
        {
            CG.WarpMouseCursorPosition(new Carbon.HIPoint(x, y));
        }

        #endregion

        #region NativeMethods

        class NativeMethods
        {
            const string hid = "/System/Library/Frameworks/IOKit.framework/Versions/Current/IOKit";
            public static readonly CFString IOHIDDeviceUsageKey = CF.CFSTR("DeviceUsage");
            public static readonly CFString IOHIDDeviceUsagePageKey = CF.CFSTR("DeviceUsagePage");
            public static readonly CFString IOHIDDeviceUsagePairsKey = CF.CFSTR("DeviceUsagePairs");

            [DllImport(hid)]
            public static extern IOHIDManagerRef IOHIDManagerCreate(
                CFAllocatorRef allocator, IOOptionBits options) ;

            // This routine will be called when a new (matching) device is connected.
            [DllImport(hid)]
            public static extern void IOHIDManagerRegisterDeviceMatchingCallback(
                IOHIDManagerRef inIOHIDManagerRef,
                IOHIDDeviceCallback inIOHIDDeviceCallback,
                IntPtr inContext);

            // This routine will be called when a (matching) device is disconnected.
            [DllImport(hid)]
            public static extern void IOHIDManagerRegisterDeviceRemovalCallback(
                IOHIDManagerRef inIOHIDManagerRef,
                IOHIDDeviceCallback inIOHIDDeviceCallback,
                IntPtr inContext);

            [DllImport(hid)]
            public static extern void IOHIDManagerScheduleWithRunLoop(
                IOHIDManagerRef inIOHIDManagerRef,
                CFRunLoop inCFRunLoop,
                CFString inCFRunLoopMode);

            [DllImport(hid)]
            public static extern void IOHIDManagerSetDeviceMatching(
                IOHIDManagerRef manager,
                CFDictionaryRef matching) ;

            [DllImport(hid)]
            public static extern IOReturn IOHIDManagerOpen(
                IOHIDManagerRef manager,
                IOOptionBits options) ;

            [DllImport(hid)]
            public static extern IOReturn IOHIDDeviceOpen(
                IOHIDDeviceRef manager,
                IOOptionBits opts);

            [DllImport(hid)]
            public static extern CFTypeRef IOHIDDeviceGetProperty(
                IOHIDDeviceRef device,
                CFStringRef key);

            [DllImport(hid)]
            public static extern bool IOHIDDeviceConformsTo(
                IOHIDDeviceRef inIOHIDDeviceRef,  // IOHIDDeviceRef for the HID device
                HIDPage inUsagePage,      // the usage page to test conformance with
                int inUsage);         // the usage to test conformance with

            [DllImport(hid)]
            public static extern void IOHIDDeviceRegisterInputValueCallback(
                IOHIDDeviceRef device,
                IOHIDValueCallback callback,
                IntPtr context);

            [DllImport(hid)]
            public static extern void IOHIDDeviceScheduleWithRunLoop(
                IOHIDDeviceRef device,
                CFRunLoop inCFRunLoop,
                CFString inCFRunLoopMode);

            [DllImport(hid)]
            public static extern void IOHIDDeviceUnscheduleWithRunLoop(
                IOHIDDeviceRef device,
                CFRunLoop inCFRunLoop,
                CFString inCFRunLoopMode);

            [DllImport(hid)]
            public static extern IOHIDElementRef IOHIDValueGetElement(IOHIDValueRef @value);

            [DllImport(hid)]
            public static extern CFIndex IOHIDValueGetIntegerValue(IOHIDValueRef @value);

            [DllImport(hid)]
            public static extern double IOHIDValueGetScaledValue(
                IOHIDValueRef @value,
                IOHIDValueScaleType type) ;

            [DllImport(hid)]
            public static extern int IOHIDElementGetUsage(IOHIDElementRef elem);

            [DllImport(hid)]
            public static extern HIDPage IOHIDElementGetUsagePage(IOHIDElementRef elem);

            public delegate void IOHIDDeviceCallback(IntPtr ctx, IOReturn res, IntPtr sender, IOHIDDeviceRef device);
            public delegate void IOHIDValueCallback(IntPtr ctx, IOReturn res, IntPtr sender, IOHIDValueRef val);
        }

        enum IOHIDValueScaleType
        {
            Physical, // [device min, device max]
            Calibrated // [-1, +1]
        }

        enum HIDPage
        {
            Undefined  = 0x00,
            GenericDesktop = 0x01,
            Simulation = 0x02,
            VR = 0x03,
            Sport  = 0x04,
            Game   = 0x05,
            /* Reserved 0x06 */
            KeyboardOrKeypad   = 0x07, /* USB Device Class Definition for Human Interface Devices (HID). Note: the usage type for all key codes is Selector (Sel). */
            LEDs   = 0x08,
            Button = 0x09,
            Ordinal    = 0x0A,
            Telephony  = 0x0B,
            Consumer   = 0x0C,
            Digitizer  = 0x0D,
            /* Reserved 0x0E */
            PID    = 0x0F, /* USB Physical Interface Device definitions for force feedback and related devices. */
            Unicode    = 0x10,
            /* Reserved 0x11 - 0x13 */
            AlphanumericDisplay    = 0x14,
            /* Reserved 0x15 - 0x7F */
            /* Monitor 0x80 - 0x83   USB Device Class Definition for Monitor Devices */
            /* Power 0x84 - 0x87     USB Device Class Definition for Power Devices */
            PowerDevice = 0x84,                /* Power Device Page */
            BatterySystem = 0x85,              /* Battery System Page */
            /* Reserved 0x88 - 0x8B */
            BarCodeScanner = 0x8C, /* (Point of Sale) USB Device Class Definition for Bar Code Scanner Devices */
            WeighingDevice = 0x8D, /* (Point of Sale) USB Device Class Definition for Weighing Devices */
            Scale  = 0x8D, /* (Point of Sale) USB Device Class Definition for Scale Devices */
            MagneticStripeReader = 0x8E,
            /* ReservedPointofSalepages 0x8F */
            CameraControl  = 0x90, /* USB Device Class Definition for Image Class Devices */
            Arcade = 0x91, /* OAAF Definitions for arcade and coinop related Devices */
            /* Reserved 0x92 - 0xFEFF */
            /* VendorDefined 0xFF00 - 0xFFFF */
            VendorDefinedStart = 0xFF00
        }

        // Generic desktop usage
        enum HIDUsageGD
        {
            Pointer    = 0x01, /* Physical Collection */
            Mouse  = 0x02, /* Application Collection */
            /* 0x03 Reserved */
            Joystick   = 0x04, /* Application Collection */
            GamePad    = 0x05, /* Application Collection */
            Keyboard   = 0x06, /* Application Collection */
            Keypad = 0x07, /* Application Collection */
            MultiAxisController    = 0x08, /* Application Collection */
            /* 0x09 - 0x2F Reserved */
            X  = 0x30, /* Dynamic Value */
            Y  = 0x31, /* Dynamic Value */
            Z  = 0x32, /* Dynamic Value */
            Rx = 0x33, /* Dynamic Value */
            Ry = 0x34, /* Dynamic Value */
            Rz = 0x35, /* Dynamic Value */
            Slider = 0x36, /* Dynamic Value */
            Dial   = 0x37, /* Dynamic Value */
            Wheel  = 0x38, /* Dynamic Value */
            Hatswitch  = 0x39, /* Dynamic Value */
            CountedBuffer  = 0x3A, /* Logical Collection */
            ByteCount  = 0x3B, /* Dynamic Value */
            MotionWakeup   = 0x3C, /* One-Shot Control */
            Start  = 0x3D, /* On/Off Control */
            Select = 0x3E, /* On/Off Control */
            /* 0x3F Reserved */
            Vx = 0x40, /* Dynamic Value */
            Vy = 0x41, /* Dynamic Value */
            Vz = 0x42, /* Dynamic Value */
            Vbrx   = 0x43, /* Dynamic Value */
            Vbry   = 0x44, /* Dynamic Value */
            Vbrz   = 0x45, /* Dynamic Value */
            Vno    = 0x46, /* Dynamic Value */
            /* 0x47 - 0x7F Reserved */
            SystemControl  = 0x80, /* Application Collection */
            SystemPowerDown    = 0x81, /* One-Shot Control */
            SystemSleep    = 0x82, /* One-Shot Control */
            SystemWakeUp   = 0x83, /* One-Shot Control */
            SystemContextMenu  = 0x84, /* One-Shot Control */
            SystemMainMenu = 0x85, /* One-Shot Control */
            SystemAppMenu  = 0x86, /* One-Shot Control */
            SystemMenuHelp = 0x87, /* One-Shot Control */
            SystemMenuExit = 0x88, /* One-Shot Control */
            SystemMenu = 0x89, /* Selector */
            SystemMenuRight    = 0x8A, /* Re-Trigger Control */
            SystemMenuLeft = 0x8B, /* Re-Trigger Control */
            SystemMenuUp   = 0x8C, /* Re-Trigger Control */
            SystemMenuDown = 0x8D, /* Re-Trigger Control */
            /* 0x8E - 0x8F Reserved */
            DPadUp = 0x90, /* On/Off Control */
            DPadDown   = 0x91, /* On/Off Control */
            DPadRight  = 0x92, /* On/Off Control */
            DPadLeft   = 0x93, /* On/Off Control */
            /* 0x94 - 0xFFFF Reserved */
            Reserved = 0xFFFF
        }

        enum HIDButton
        {
            Button_1  = 0x01, /* (primary/trigger) */
            Button_2  = 0x02, /* (secondary) */
            Button_3  = 0x03, /* (tertiary) */
            Button_4  = 0x04, /* 4th button */
            /* ... */
            Button_65535  = 0xFFFF
        }

        #endregion
    }
}

