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
using OpenTK.Platform.Common;

namespace OpenTK.Platform.MacOS
{
    using Carbon;
    using CFAllocatorRef = System.IntPtr;
    using CFArrayRef = System.IntPtr;
    using CFDictionaryRef = System.IntPtr;
    using CFIndex = System.IntPtr;
    using CFRunLoop = System.IntPtr;
    using CFString = System.IntPtr;
    using CFStringRef = System.IntPtr; // Here used interchangeably with the CFString
    using CFTypeRef = System.IntPtr;
    using IOHIDDeviceRef = System.IntPtr;
    using IOHIDElementRef = System.IntPtr;
    using IOHIDElementCookie = System.IntPtr;
    using IOHIDManagerRef = System.IntPtr;
    using IOHIDValueRef = System.IntPtr;
    using IOOptionBits = System.IntPtr;
    using IOReturn = System.IntPtr;

    // Requires Mac OS X 10.5 or higher.
    // Todo: create a driver for older installations. Maybe use CGGetLastMouseDelta for that?
    class HIDInput : IInputDriver2, IMouseDriver2, IKeyboardDriver2, IJoystickDriver2
    {
        #region Fields

        class MouseData
        {
            public IntPtr Id;
            public MouseState State;

            public MouseData(IntPtr id)
            {
                Id = id;
            }
        }

        class KeyboardData
        {
            public IntPtr Id;
            public KeyboardState State;

            public KeyboardData(IntPtr id)
            {
                Id = id;
            }
        }

        class JoystickData
        {
            public IntPtr Id;
            public string Name;
            public Guid Guid;
            public JoystickState State;
            public JoystickCapabilities Capabilities;

            readonly public Dictionary<IOHIDElementCookie, JoystickElement> Elements =
                new Dictionary<IOHIDElementCookie, JoystickElement>();

            public JoystickData(IntPtr id)
            {
                Id = id;
            }

            public void AddElement(JoystickElement e)
            {
                if (!Elements.ContainsKey(e.Cookie))
                {
                    Elements.Add(e.Cookie, e);
                    Debug.Print("Discovered joystick element {0:x} ({1}/{2})",
                        e.Cookie, e.Page, e.Usage);
                }
                else
                {
                    Debug.Print("Duplicate joystick element {0:x} ({1}/{2}) ignored.",
                        e.Cookie, e.Page, e.Usage);
                }
            }
        }

        class JoystickElement : IComparable<JoystickElement>, IEquatable<JoystickElement>
        {
            public IntPtr Element;
            public IntPtr Cookie;
            public HIDPage Page;
            public int Usage;
            // Hardware axis range
            public int Min;
            public int Max;
            // Reported axis range (can sometimes be larger than hardware range)
            public int MinReported;
            public int MaxReported;

            // Order in which this element was reported
            public int Index;

            public JoystickElement(
                IntPtr element, IntPtr cookie,
                HIDPage page, int usage,
                int min, int max)
            {
                Element = element;
                Cookie = cookie;
                Page = page;
                Usage = usage;
                Min = min;
                Max = max;
                MinReported = min;
                MaxReported = max;
            }

            #region IComparable implementation

            public int CompareTo(JoystickElement other)
            {
                return Usage.CompareTo(other.Usage);
            }

            #endregion

            #region IEquatable implementation

            public bool Equals(JoystickElement other)
            {
                return Cookie.Equals(other.Cookie);
            }

            #endregion
        }

        IOHIDManagerRef hidmanager;

        readonly DeviceCollection<MouseData> MouseDevices =
            new DeviceCollection<MouseData>();
        readonly DeviceCollection<KeyboardData> KeyboardDevices =
            new DeviceCollection<KeyboardData>();
        readonly DeviceCollection<JoystickData> JoystickDevices =
            new DeviceCollection<JoystickData>();

        readonly CFRunLoop RunLoop;
        readonly CFString InputLoopMode = CF.RunLoopModeDefault;
        readonly CFDictionary DeviceTypes = new CFDictionary();

        readonly MappedGamePadDriver mapped_gamepad = new MappedGamePadDriver();

        // Used for device discovery
        readonly List<JoystickElement> axis_elements = new List<JoystickElement>();
        readonly List<JoystickElement> button_elements = new List<JoystickElement>();
        readonly List<JoystickElement> hat_elements = new List<JoystickElement>();
        readonly List<JoystickElement> vendor_elements = new List<JoystickElement>();

        IntPtr MouseEventTap;
        IntPtr MouseEventTapSource;
        MouseState CursorState;

        NativeMethods.IOHIDDeviceCallback HandleDeviceAdded;
        NativeMethods.IOHIDDeviceCallback HandleDeviceRemoved;
        NativeMethods.IOHIDValueCallback HandleDeviceValueReceived;

        bool disposed;

        #endregion

        #region Constructors

        public HIDInput()
        {
            Debug.Print("Using HIDInput.");

            RunLoop = CF.CFRunLoopGetMain();
            if (RunLoop == IntPtr.Zero)
                RunLoop = CF.CFRunLoopGetCurrent();
            if (RunLoop == IntPtr.Zero)
            {
                Debug.Print("[Error] No CFRunLoop found for {0}", GetType().FullName);
                throw new InvalidOperationException();
            }
            CF.CFRetain(RunLoop);

            HandleDeviceAdded = DeviceAdded;
            HandleDeviceRemoved = DeviceRemoved;
            HandleDeviceValueReceived = DeviceValueReceived;

            // For retrieving input directly from the hardware
            hidmanager = CreateHIDManager();
            if (hidmanager == IntPtr.Zero)
            {
                Debug.Print("[Mac] Failed to create IO HID manager, HIDInput driver not supported.");
                throw new NotSupportedException();
            }

            RegisterHIDCallbacks(hidmanager);

            // For retrieving the global cursor position
            RegisterMouseMonitor();
        }

        #endregion

        #region Private Members

        void RegisterMouseMonitor()
        {
            Debug.Write("Creating mouse event monitor... ");
            MouseEventTapDelegate = MouseEventTapCallback;
            MouseEventTap = CG.EventTapCreate(
                CGEventTapLocation.HIDEventTap,
                CGEventTapPlacement.HeadInsert,
                CGEventTapOptions.ListenOnly,
                CGEventMask.AllMouse,
                MouseEventTapDelegate,
                IntPtr.Zero);

            if (MouseEventTap != IntPtr.Zero)
            {
                MouseEventTapSource = CF.MachPortCreateRunLoopSource(IntPtr.Zero, MouseEventTap, IntPtr.Zero);
                CF.RunLoopAddSource(RunLoop, MouseEventTapSource, CF.RunLoopModeDefault);
            }

            Debug.WriteLine(
                MouseEventTap != IntPtr.Zero  && MouseEventTapSource != IntPtr.Zero ?
                "success!" : "failed.");
        }

        CG.EventTapCallBack MouseEventTapDelegate;
        IntPtr MouseEventTapCallback(
            IntPtr proxy,
            CGEventType type,
            IntPtr @event,
            IntPtr refcon)
        {
            try
            {
                CursorState.SetIsConnected(true);

                switch (type)
                {
                    case CGEventType.MouseMoved:
                    case CGEventType.LeftMouseDragged:
                    case CGEventType.RightMouseDragged:
                    case CGEventType.OtherMouseDragged:
                        {
                            Carbon.HIPoint p = CG.EventGetLocation(@event);
                            CursorState.X = (int)Math.Round(p.X);
                            CursorState.Y = (int)Math.Round(p.Y);
                        }
                        break;

                    case CGEventType.ScrollWheel:
                        {
                            // Note: OpenTK follows the win32 convention, where
                            // (+h, +v) = (right, up). MacOS reports (+h, +v) = (left, up)
                            // so we need to flip the horizontal scroll direction.
                            double h = CG.EventGetDoubleValueField(@event, CGEventField.ScrollWheelEventPointDeltaAxis2) * MacOSFactory.ScrollFactor;
                            double v = CG.EventGetDoubleValueField(@event, CGEventField.ScrollWheelEventPointDeltaAxis1) * MacOSFactory.ScrollFactor;
                            CursorState.SetScrollRelative((float)(-h), (float)v);
                        }
                        break;

                    case CGEventType.LeftMouseDown:
                    case CGEventType.RightMouseDown:
                    case CGEventType.OtherMouseDown:
                        {
                            int n = CG.EventGetIntegerValueField(@event, CGEventField.MouseEventButtonNumber);
                            n = n == 1 ? 2 : n == 2 ? 1 : n; // flip middle and right button numbers to match OpenTK
                            MouseButton b = MouseButton.Left + n;
                            CursorState[b] = true;
                        }
                        break;

                    case CGEventType.LeftMouseUp:
                    case CGEventType.RightMouseUp:
                    case CGEventType.OtherMouseUp:
                        {
                            int n = CG.EventGetIntegerValueField(@event, CGEventField.MouseEventButtonNumber);
                            n = n == 1 ? 2 : n == 2 ? 1 : n; // flip middle and right button numbers to match OpenTK
                            MouseButton b = MouseButton.Left + n;
                            CursorState[b] = false;
                        }
                        break;
                }
            }
            catch (Exception e)
            {
                // Do not let any exceptions escape into unmanaged code!
                Debug.Print(e.ToString());
            }

            return @event;
        }

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
            try
            {
                bool recognized = false;

                if (NativeMethods.IOHIDDeviceOpen(device, IOOptionBits.Zero) == IOReturn.Zero)
                {
                    if (NativeMethods.IOHIDDeviceConformsTo(device,
                            HIDPage.GenericDesktop, (int)HIDUsageGD.Mouse))
                    {
                        AddMouse(sender, device);
                        recognized = true;
                    }

                    if (NativeMethods.IOHIDDeviceConformsTo(device,
                            HIDPage.GenericDesktop, (int)HIDUsageGD.Keyboard))
                    {
                        AddKeyboard(sender, device);
                        recognized = true;
                    }

                    bool is_joystick = false;
                    is_joystick |= NativeMethods.IOHIDDeviceConformsTo(device,
                        HIDPage.GenericDesktop, (int)HIDUsageGD.Joystick);
                    is_joystick |= NativeMethods.IOHIDDeviceConformsTo(device,
                        HIDPage.GenericDesktop, (int)HIDUsageGD.GamePad);
                    is_joystick |= NativeMethods.IOHIDDeviceConformsTo(device,
                        HIDPage.GenericDesktop, (int)HIDUsageGD.MultiAxisController);
                    is_joystick |= NativeMethods.IOHIDDeviceConformsTo(device,
                        HIDPage.GenericDesktop, (int)HIDUsageGD.Wheel);
                    // Todo: any other interesting devices under HIDPage.Simulation + HIDUsageSim?
                    if (is_joystick)
                    {
                        AddJoystick(sender, device);
                        recognized = true;
                    }

                    if (recognized)
                    {
                        // The device is not normally available in the InputValueCallback (HandleDeviceValueReceived), so we include
                        // the device identifier as the context variable, so we can identify it and figure out the device later.
                        // Thanks to Jase: http://www.opentk.com/node/2800
                        NativeMethods.IOHIDDeviceRegisterInputValueCallback(device,
                            HandleDeviceValueReceived, device);

                        NativeMethods.IOHIDDeviceScheduleWithRunLoop(device, RunLoop, InputLoopMode);
                    }
                }
            }
            catch (Exception e)
            {
                Debug.Print("[Mac] Exception in managed callback: {0}", e);
            }
        }

        void DeviceRemoved(IntPtr context, IOReturn res, IntPtr sender, IOHIDDeviceRef device)
        {
            try
            {
                bool recognized = false;
                long id = device.ToInt64();

                MouseData mouse;
                KeyboardData keyboard;
                JoystickData joystick;

                if (MouseDevices.FromHardwareId(id, out mouse))
                {
                    RemoveMouse(sender, id);
                    recognized = true;
                }

                if (KeyboardDevices.FromHardwareId(id, out keyboard))
                {
                    RemoveKeyboard(sender, id);
                    recognized = true;
                }

                if (JoystickDevices.FromHardwareId(id, out joystick))
                {
                    RemoveJoystick(sender, id);
                    recognized = true;
                }

                if (recognized)
                {
                    NativeMethods.IOHIDDeviceRegisterInputValueCallback(device, IntPtr.Zero, IntPtr.Zero);
                    NativeMethods.IOHIDDeviceUnscheduleFromRunLoop(device, RunLoop, InputLoopMode);
                    NativeMethods.IOHIDDeviceClose(device, IOOptionBits.Zero);
                }
            }
            catch (Exception e)
            {
                Debug.Print("[Mac] Exception in managed callback: {0}", e);
            }
        }

        void DeviceValueReceived(IntPtr context, IOReturn res, IntPtr sender, IOHIDValueRef val)
        {
            try
            {
                if (disposed)
                {
                    Debug.Print("DeviceValueReceived({0}, {1}, {2}, {3}) called on disposed {4}",
                        context, res, sender, val, GetType());
                    return;
                }

                MouseData mouse;
                KeyboardData keyboard;
                JoystickData joystick;
                long id = context.ToInt64();
                if (MouseDevices.FromHardwareId(id, out mouse))
                {
                    UpdateMouse(mouse, val);
                }
                else if (KeyboardDevices.FromHardwareId(id, out keyboard))
                {
                    UpdateKeyboard(keyboard, val);
                }
                else if (JoystickDevices.FromHardwareId(id, out joystick))
                {
                    UpdateJoystick(joystick, val);
                }
                else
                {
                    //Debug.Print ("Device {0:x} not found in list of keyboards or mice", sender);
                }
            }
            catch (Exception e)
            {
                Debug.Print("[Mac] Exception in managed callback: {0}", e);
            }
        }

        #region Mouse

        void AddMouse(CFAllocatorRef sender, CFAllocatorRef device)
        {
            Debug.Print("Mouse device {0:x} discovered, sender is {1:x}", device, sender);
            MouseData mouse = new MouseData(device);
            mouse.State.SetIsConnected(true);
            MouseDevices.Add(device.ToInt64(), mouse);
        }

        void RemoveMouse(CFAllocatorRef sender, long id)
        {
            Debug.Print("Mouse device {0:x} disconnected, sender is {1:x}", id, sender);
            MouseDevices.Remove(id);
        }

        static void UpdateMouse(MouseData mouse, IOHIDValueRef val)
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
                            mouse.State.X += v_int;
                            break;

                        case HIDUsageGD.Y:
                            mouse.State.Y += v_int;
                            break;

                        case HIDUsageGD.Z:
                            // Horizontal scrolling for apple mouse (old-style with trackball)
                            mouse.State.SetScrollRelative(v_int, 0);
                            break;

                        case HIDUsageGD.Wheel:
                            mouse.State.SetScrollRelative(0, v_int);
                            break;
                    }
                    break;

                case HIDPage.Button:
                    mouse.State[OpenTK.Input.MouseButton.Left + usage - 1] = v_int == 1;
                    break;

                case HIDPage.Consumer:
                    switch ((HIDUsageCD)usage)
                    {
                        case HIDUsageCD.ACPan:
                            mouse.State.SetScrollRelative(v_int, 0);
                            break;
                    }
                    break;
            }
        }

        #endregion

        #region Keyboard

        void AddKeyboard(CFAllocatorRef sender, CFAllocatorRef device)
        {
            Debug.Print("Keyboard device {0:x} discovered, sender is {1:x}", device, sender);
            KeyboardData keyboard = new KeyboardData(device);
            keyboard.State.SetIsConnected(true);
            KeyboardDevices.Add(device.ToInt64(), keyboard);
        }

        void RemoveKeyboard(CFAllocatorRef sender, long id)
        {
            Debug.Print("Keyboard device {0:x} disconnected, sender is {1:x}", id, sender);
            KeyboardDevices.Remove(id);
        }

        static void UpdateKeyboard(KeyboardData keyboard, IOHIDValueRef val)
        {
            IOHIDElementRef elem = NativeMethods.IOHIDValueGetElement(val);
            int v_int = NativeMethods.IOHIDValueGetIntegerValue(val).ToInt32();
            HIDPage page = NativeMethods.IOHIDElementGetUsagePage(elem);
            int usage = NativeMethods.IOHIDElementGetUsage(elem);
 
            // This will supress the debug printing below. Seems like it generates a lot of -1s. 
            // Couldn't find any details in USB spec or Apple docs for this behavior.
            if (usage >= 0)
            {

                switch (page)
                {
                    case HIDPage.GenericDesktop:
                    case HIDPage.KeyboardOrKeypad:
                        if (usage >= RawKeyMap.Length)
                        {
                            Debug.Print("[Warning] Key {0} not mapped.", usage);
                        }

                        keyboard.State[RawKeyMap[usage]] = v_int != 0;
                        break;
                }
            }
        }

        #endregion

        #region Joystick

        Guid CreateJoystickGuid(IntPtr device, string name)
        {
            // Create a device guid from the product and vendor id keys
            List<byte> guid_bytes = new List<byte>();
            long vendor_id = 0;
            long product_id = 0;

            IntPtr vendor_id_ref = NativeMethods.IOHIDDeviceGetProperty(device, NativeMethods.IOHIDVendorIDKey);
            IntPtr product_id_ref = NativeMethods.IOHIDDeviceGetProperty(device, NativeMethods.IOHIDProductIDKey);
            if (vendor_id_ref != IntPtr.Zero)
            {
                CF.CFNumberGetValue(vendor_id_ref, CF.CFNumberType.kCFNumberLongType, out vendor_id);
            }
            if (product_id_ref != IntPtr.Zero)
            {
                CF.CFNumberGetValue(product_id_ref, CF.CFNumberType.kCFNumberLongType, out product_id);
            }

            if (vendor_id != 0 && product_id != 0)
            {
                guid_bytes.AddRange(BitConverter.GetBytes(vendor_id));
                guid_bytes.AddRange(BitConverter.GetBytes(product_id));
            }
            else
            {
                // Bluetooth devices don't have USB vendor/product id keys.
                // Match SDL2 algorithm for compatibility.
                guid_bytes.Add(0x05); // BUS_BLUETOOTH
                guid_bytes.Add(0x00);
                guid_bytes.Add(0x00);
                guid_bytes.Add(0x00);

                // Copy the first 12 bytes of the product name
                byte[] name_bytes = new byte[12];
                Array.Copy(System.Text.Encoding.UTF8.GetBytes(name), name_bytes, name_bytes.Length);
                guid_bytes.AddRange(name_bytes);
            }

            // The Guid(byte[]) constructor performs byte-swapping on the first 4+2+2 bytes, while
            // the Guid(string) constructor does not. Since our database is using the string
            // constructor, we need to compensate for this difference or the database lookups
            // will fail.
            byte[] guid_array = guid_bytes.ToArray();
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(guid_array, 0, 4);
                Array.Reverse(guid_array, 4, 2);
                Array.Reverse(guid_array, 6, 2);
            }
            return new Guid(guid_array);
        }

        JoystickData CreateJoystick(IntPtr sender, IntPtr device)
        {
            JoystickData joy = null;

            // Retrieve all elements of this device
            CFArrayRef element_array_ref = NativeMethods.IOHIDDeviceCopyMatchingElements(device, IntPtr.Zero, IntPtr.Zero);
            if (element_array_ref != IntPtr.Zero)
            {
                joy = new JoystickData(device);

                CFStringRef name_ref = NativeMethods.IOHIDDeviceGetProperty(device, NativeMethods.IOHIDProductKey);
                string name = CF.CFStringGetCString(name_ref);

                Guid guid = CreateJoystickGuid(device, name);

                axis_elements.Clear();
                button_elements.Clear();
                hat_elements.Clear();
                vendor_elements.Clear();
                AddElements(joy, element_array_ref);

                // Ensure a stable sorting order that matches SDL2.
                // (This is necessary for the gamepad database).
                axis_elements.Sort();
                button_elements.Sort();
                hat_elements.Sort();
                vendor_elements.Sort();

                // Store all discovered elements in JoystickData
                for (int i = 0; i < Math.Min(axis_elements.Count, JoystickState.MaxAxes); i++)
                {
                    JoystickElement e = axis_elements[i];
                    e.Index = i;
                    joy.AddElement(e);
                }

                for (int i = 0; i < Math.Min(button_elements.Count, JoystickState.MaxButtons); i++)
                {
                    JoystickElement e = button_elements[i];
                    e.Index = i;
                    joy.AddElement(e);
                }

                for (int i = 0; i < Math.Min(hat_elements.Count, JoystickState.MaxHats); i++)
                {
                    JoystickElement e = hat_elements[i];
                    e.Index = i;
                    joy.AddElement(e);
                }

                for (int i = 0; i < vendor_elements.Count; i++)
                {
                    JoystickElement e = vendor_elements[i];
                    e.Index = i;
                    joy.AddElement(e);
                }

                if (axis_elements.Count >= JoystickState.MaxAxes)
                {
                    Debug.Print("[Mac] JoystickAxis limit reached ({0} > {1}), please report a bug at http://www.opentk.com",
                        axis_elements.Count, JoystickState.MaxAxes);
                }
                if (button_elements.Count > JoystickState.MaxButtons)
                {
                    Debug.Print("[Mac] JoystickButton limit reached ({0} > {1}), please report a bug at http://www.opentk.com",
                        button_elements.Count, JoystickState.MaxButtons);
                }
                if (hat_elements.Count > JoystickState.MaxHats)
                {
                    Debug.Print("[Mac] JoystickHat limit reached ({0} > {1}), please report a bug at http://www.opentk.com",
                        hat_elements.Count, JoystickState.MaxHats);
                }

                joy.Name = name;
                joy.Guid = guid;
                joy.State.SetIsConnected(true);
                joy.Capabilities = new JoystickCapabilities(
                    axis_elements.Count, button_elements.Count, hat_elements.Count, true);
            }
            CF.CFRelease(element_array_ref);

            return joy;
        }

        void AddElements(JoystickData joy, CFArrayRef element_array_ref)
        {
            CFArray element_array = new CFArray(element_array_ref);
            for (int i = 0; i < element_array.Count; i++)
            {
                IOHIDElementRef element_ref = element_array[i];

                if (element_ref != IntPtr.Zero && CF.CFGetTypeID(element_ref) == NativeMethods.IOHIDElementGetTypeID())
                {
                    IOHIDElementCookie cookie = NativeMethods.IOHIDElementGetCookie(element_ref);
                    HIDPage page = NativeMethods.IOHIDElementGetUsagePage(element_ref);
                    int usage = NativeMethods.IOHIDElementGetUsage(element_ref);
                    JoystickElement e = null;

                    switch (NativeMethods.IOHIDElementGetType(element_ref))
                    {
                        case IOHIDElementType.Input_Axis:
                        case IOHIDElementType.Input_Button:
                        case IOHIDElementType.Input_Misc:
                            switch (page)
                            {
                                case HIDPage.GenericDesktop:
                                    switch ((HIDUsageGD)usage)
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
                                            e = new JoystickElement(element_ref, cookie, page, usage, 0, 0);
                                            if (!axis_elements.Contains(e))
                                            {
                                                axis_elements.Add(e);
                                            }
                                            break;

                                        case HIDUsageGD.Hatswitch:
                                            e = new JoystickElement(element_ref, cookie, page, usage, 0, 0);
                                            if (!hat_elements.Contains(e))
                                            {
                                                hat_elements.Add(e);
                                            }
                                            break;
                                    }
                                    break;

                                case HIDPage.Simulation:
                                    switch ((HIDUsageSim)usage)
                                    {
                                        case HIDUsageSim.Rudder:
                                        case HIDUsageSim.Throttle:
                                            e = new JoystickElement(element_ref, cookie, page, usage, 0, 0);
                                            if (!axis_elements.Contains(e))
                                            {
                                                axis_elements.Add(e);
                                            }
                                            break;
                                    }
                                    break;

                                case HIDPage.Button:
                                    e = new JoystickElement(element_ref, cookie, page, usage, 0, 0);
                                    if (!button_elements.Contains(e))
                                    {
                                        button_elements.Add(e);
                                    }
                                    break;

                                case HIDPage.VendorDefinedStart:
                                    e = new JoystickElement(element_ref, cookie, page, usage, 0, 0);
                                    if (!vendor_elements.Contains(e))
                                    {
                                        vendor_elements.Add(e);
                                    }
                                    break;
                            }
                            break;

                        case IOHIDElementType.Collection:
                            CFArrayRef children_array_ref = NativeMethods.IOHIDElementGetChildren(element_ref);
                            if (children_array_ref != IntPtr.Zero)
                            {
                                AddElements(joy, children_array_ref);
                            }
                            break;
                    }
                }
            }
        }

        JoystickData GetJoystick(int index)
        {
            return JoystickDevices.FromIndex(index);
        }

        void AddJoystick(CFAllocatorRef sender, CFAllocatorRef device)
        {
            Debug.Print("Joystick device {0:x} discovered, sender is {1:x}", device, sender);
            Debug.Indent();

            try
            {
                JoystickData joy = CreateJoystick(sender, device);
                if (joy != null)
                {
                    JoystickDevices.Add(device.ToInt64(), joy);
                }
            }
            finally
            {
                Debug.Unindent();
            }
        }

        void RemoveJoystick(CFAllocatorRef sender, long id)
        {
            Debug.Print("Joystick device {0:x} disconnected, sender is {1:x}", id, sender);
            JoystickDevices.Remove(id);
        }

        static void UpdateJoystick(JoystickData joy, IOHIDValueRef val)
        {
            IOHIDElementRef elem = NativeMethods.IOHIDValueGetElement(val);
            IOHIDElementCookie cookie = NativeMethods.IOHIDElementGetCookie(elem);
            HIDPage page = NativeMethods.IOHIDElementGetUsagePage(elem);
            int usage = NativeMethods.IOHIDElementGetUsage(elem);

            if (!joy.Elements.ContainsKey(cookie))
            {
                Debug.Print("[{0}] Reported joystick element {1:x} ({2}/{3}) is unknown",
                    typeof(HIDInput).Name, cookie, page, usage);
                return;
            }

            switch (page)
            {
                case HIDPage.GenericDesktop:
                    switch ((HIDUsageGD)usage)
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
                            short offset = GetJoystickAxis(val, elem);
                            JoystickAxis axis = JoystickAxis.Axis0 + joy.Elements[cookie].Index;
                            if (axis >= JoystickAxis.Axis0 && axis <= JoystickAxis.Last)
                            {
                                joy.State.SetAxis(axis, offset);
                            }
                            break;

                        case HIDUsageGD.Hatswitch:
                            HatPosition position = GetJoystickHat(val, elem);
                            JoystickHat hat = JoystickHat.Hat0 + joy.Elements[cookie].Index;
                            if (hat >= JoystickHat.Hat0 && hat <= JoystickHat.Last)
                            {
                                joy.State.SetHat(hat, new JoystickHatState(position));
                            }
                            break;
                    }
                    break;

                case HIDPage.Simulation:
                    switch ((HIDUsageSim)usage)
                    {
                        case HIDUsageSim.Rudder:
                        case HIDUsageSim.Throttle:
                            short offset = GetJoystickAxis(val, elem);
                            JoystickAxis axis = JoystickAxis.Axis0 + joy.Elements[cookie].Index;
                            if (axis >= JoystickAxis.Axis0 && axis <= JoystickAxis.Last)
                            {
                                joy.State.SetAxis(axis, offset);
                            }
                            break;
                    }
                    break;

                case HIDPage.Button:
                    {
                        bool pressed = GetJoystickButton(val, elem);
                        JoystickButton button = JoystickButton.Button0 + joy.Elements[cookie].Index;
                        if (button >= JoystickButton.Button0 && button <= JoystickButton.Last)
                        {
                            joy.State.SetButton(button, pressed);
                        }
                    }
                    break;
            }
        }

        static short GetJoystickAxis(IOHIDValueRef val, IOHIDElementRef element)
        {
            int max = NativeMethods.IOHIDElementGetLogicalMax(element).ToInt32();
            int min = NativeMethods.IOHIDElementGetLogicalMin(element).ToInt32();
            int offset = NativeMethods.IOHIDValueGetIntegerValue(val).ToInt32();
            return (short)HidHelper.ScaleValue(offset, min, max, short.MinValue, short.MaxValue);
        }

        static bool GetJoystickButton(IOHIDValueRef val, IOHIDElementRef element)
        {
            // Todo: analogue buttons are transformed to digital
            int value = NativeMethods.IOHIDValueGetIntegerValue(val).ToInt32();
            return value >= 1;
        }

        static HatPosition GetJoystickHat(IOHIDValueRef val, IOHIDElementRef element)
        {
            HatPosition position = HatPosition.Centered;
            int max = NativeMethods.IOHIDElementGetLogicalMax(element).ToInt32();
            int min = NativeMethods.IOHIDElementGetLogicalMin(element).ToInt32();
            int value = NativeMethods.IOHIDValueGetIntegerValue(val).ToInt32() - min;
            int range = Math.Abs(max - min + 1);

            if (value >= 0)
            {
                if (range == 4)
                {
                    // 4-position hat (no diagonals)
                    // 0 = up; 1 = right; 2 = down; 3 = left
                    // map to a 8-position hat (processed below)
                    value *= 2;
                }

                if (range == 8)
                {
                    // 0 = up; 1 = up-right; 2 = right; 3 = right-down;
                    // 4 = down; 5 = down-left; 6 = left; 7 = up-left
                    switch (value)
                    {
                        case 0:
                            position = HatPosition.Up;
                            break;
                        case 1:
                            position = HatPosition.UpRight;
                            break;
                        case 2:
                            position = HatPosition.Right;
                            break;
                        case 3:
                            position = HatPosition.DownRight;
                            break;
                        case 4:
                            position = HatPosition.Down;
                            break;
                        case 5:
                            position = HatPosition.DownLeft;
                            break;
                        case 6:
                            position = HatPosition.Left;
                            break;
                        case 7:
                            position = HatPosition.UpLeft;
                            break;
                    }
                }
                else
                {
                    // Todo: implement support for continuous hats
                }
            }

            return position;
        }

        #endregion

        #endregion

        #region IInputDriver2 Members

        public IMouseDriver2 MouseDriver { get { return this; } }
        public IKeyboardDriver2 KeyboardDriver { get { return this; } }
        public IGamePadDriver GamePadDriver { get { return mapped_gamepad; } }
        public IJoystickDriver2 JoystickDriver { get { return this; } }

        #endregion

        #region IMouseDriver2 Members

        MouseState IMouseDriver2.GetState()
        {
            MouseState master = new MouseState();
            foreach (MouseData item in MouseDevices)
            {
                master.MergeBits(item.State);
            }

            return master;
        }

        MouseState IMouseDriver2.GetState(int index)
        {
            MouseData mouse;
            if (MouseDevices.FromIndex(index, out mouse))
            {
                return mouse.State;
            }

            return new MouseState();
        }

        MouseState IMouseDriver2.GetCursorState()
        {
            return CursorState;
        }

        void IMouseDriver2.SetPosition(double x, double y)
        {
            CG.SetLocalEventsSuppressionInterval(0.0);
            CG.WarpMouseCursorPosition(new Carbon.HIPoint(x, y));
        }

        #endregion

        #region IKeyboardDriver2

        KeyboardState IKeyboardDriver2.GetState()
        {
            KeyboardState master = new KeyboardState();
            foreach (KeyboardData item in KeyboardDevices)
            {
                master.MergeBits(item.State);
            }

            return master;
        }

        KeyboardState IKeyboardDriver2.GetState(int index)
        {
            KeyboardData keyboard;
            if (KeyboardDevices.FromIndex(index, out keyboard))
            {
                return keyboard.State;
            }

            return new KeyboardState();
        }

        string IKeyboardDriver2.GetDeviceName(int index)
        {
            KeyboardData keyboard;
            if (KeyboardDevices.FromIndex(index, out keyboard))
            {
                IntPtr vendor_id = NativeMethods.IOHIDDeviceGetProperty(keyboard.Id, NativeMethods.IOHIDVendorIDKey);
                IntPtr product_id = NativeMethods.IOHIDDeviceGetProperty(keyboard.Id, NativeMethods.IOHIDProductIDKey);
                // Todo: find out the real vendor/product name from the relevant ids.
                return String.Format("{0}:{1}", vendor_id, product_id);
            }
            return String.Empty;
        }

        #endregion

        #region IJoystickDriver2 Members

        JoystickState IJoystickDriver2.GetState(int index)
        {
            JoystickData joystick = GetJoystick(index);
            if (joystick != null)
            {
                return joystick.State;
            }
            return new JoystickState();
        }

        JoystickCapabilities IJoystickDriver2.GetCapabilities(int index)
        {
            JoystickData joystick = GetJoystick(index);
            if (joystick != null)
            {
                return joystick.Capabilities;
            }
            return new JoystickCapabilities();
        }

        Guid IJoystickDriver2.GetGuid(int index)
        {
            JoystickData joystick = GetJoystick(index);
            if (joystick != null)
            {
                return joystick.Guid;
            }
            return new Guid();
        }

        #endregion

        #region NativeMethods

        class NativeMethods
        {
            const string hid = "/System/Library/Frameworks/IOKit.framework/Versions/Current/IOKit";

            public static readonly CFString IOHIDVendorIDKey = CF.CFSTR("VendorID");
            public static readonly CFString IOHIDVendorIDSourceKey = CF.CFSTR("VendorIDSource");
            public static readonly CFString IOHIDProductIDKey = CF.CFSTR("ProductID");
            public static readonly CFString IOHIDVersionNumberKey = CF.CFSTR("VersionNumber");
            public static readonly CFString IOHIDManufacturerKey = CF.CFSTR("Manufacturer");
            public static readonly CFString IOHIDProductKey = CF.CFSTR("Product");
            public static readonly CFString IOHIDDeviceUsageKey = CF.CFSTR("DeviceUsage");
            public static readonly CFString IOHIDDeviceUsagePageKey = CF.CFSTR("DeviceUsagePage");
            public static readonly CFString IOHIDDeviceUsagePairsKey = CF.CFSTR("DeviceUsagePairs");

            [DllImport(hid)]
            public static extern IOHIDManagerRef IOHIDManagerCreate(
                CFAllocatorRef allocator, IOOptionBits options);

            [DllImport(hid)]
            public static extern IOReturn IOHIDManagerClose(
                IOHIDManagerRef allocator, IOOptionBits options);

            // This routine will be called when a new (matching) device is connected.
            [DllImport(hid)]
            public static extern void IOHIDManagerRegisterDeviceMatchingCallback(
                IOHIDManagerRef inIOHIDManagerRef,
                IOHIDDeviceCallback inIOHIDDeviceCallback,
                IntPtr inContext);

            [DllImport(hid)]
            public static extern void IOHIDManagerRegisterDeviceMatchingCallback(
                IOHIDManagerRef inIOHIDManagerRef,
                IntPtr inIOHIDDeviceCallback,
                IntPtr inContext);

            // This routine will be called when a (matching) device is disconnected.
            [DllImport(hid)]
            public static extern void IOHIDManagerRegisterDeviceRemovalCallback(
                IOHIDManagerRef inIOHIDManagerRef,
                IOHIDDeviceCallback inIOHIDDeviceCallback,
                IntPtr inContext);

            [DllImport(hid)]
            public static extern void IOHIDManagerRegisterDeviceRemovalCallback(
                IOHIDManagerRef inIOHIDManagerRef,
                IntPtr inIOHIDDeviceCallback,
                IntPtr inContext);

            [DllImport(hid)]
            public static extern void IOHIDManagerScheduleWithRunLoop(
                IOHIDManagerRef inIOHIDManagerRef,
                CFRunLoop inCFRunLoop,
                CFString inCFRunLoopMode);

            [DllImport(hid)]
            public static extern void IOHIDManagerUnscheduleFromRunLoop(
                IOHIDManagerRef inIOHIDManagerRef,
                CFRunLoop inCFRunLoop,
                CFString inCFRunLoopMode);

            [DllImport(hid)]
            public static extern void IOHIDManagerSetDeviceMatching(
                IOHIDManagerRef manager,
                CFDictionaryRef matching);

            [DllImport(hid)]
            public static extern IOReturn IOHIDManagerOpen(
                IOHIDManagerRef manager,
                IOOptionBits options) ;

            [DllImport(hid)]
            public static extern IOReturn IOHIDDeviceOpen(
                IOHIDDeviceRef manager,
                IOOptionBits opts);

            [DllImport(hid)]
            public static extern IOReturn IOHIDDeviceClose(
                IOHIDDeviceRef device,
                IOOptionBits options);

            [DllImport(hid)]
            public static extern CFTypeRef IOHIDDeviceGetProperty(
                IOHIDDeviceRef device,
                CFStringRef key);

            [DllImport(hid)]
            public static extern bool IOHIDDeviceConformsTo(
                IOHIDDeviceRef inIOHIDDeviceRef,  // IOHIDDeviceRef for the HID device
                HIDPage inUsagePage,      // the usage page to test conformance with
                int inUsage);         // the usage to test conformance with

            // return the HID elements that match the criteria contained in the matching dictionary
            [DllImport(hid)]
            public static extern CFArrayRef IOHIDDeviceCopyMatchingElements(
                IOHIDDeviceRef  inIOHIDDeviceRef,       // IOHIDDeviceRef for the HID device
                CFDictionaryRef inMatchingCFDictRef,    // the matching dictionary
                IOOptionBits    inOptions);             // Option bits

            [DllImport(hid)]
            public static extern void IOHIDDeviceRegisterInputValueCallback(
                IOHIDDeviceRef device,
                IOHIDValueCallback callback,
                IntPtr context);

            [DllImport(hid)]
            public static extern void IOHIDDeviceRegisterInputValueCallback(
                IOHIDDeviceRef device,
                IntPtr callback,
                IntPtr context);

            [DllImport(hid)]
            public static extern void IOHIDDeviceScheduleWithRunLoop(
                IOHIDDeviceRef device,
                CFRunLoop inCFRunLoop,
                CFString inCFRunLoopMode);

            [DllImport(hid)]
            public static extern void IOHIDDeviceUnscheduleFromRunLoop(
                IOHIDDeviceRef device,
                CFRunLoop inCFRunLoop,
                CFString inCFRunLoopMode);

            [DllImport(hid)]
            public static extern IOHIDElementRef IOHIDValueGetElement(IOHIDValueRef @value);

            [DllImport(hid)]
            public static extern CFArrayRef IOHIDElementGetChildren(IOHIDElementRef element_ref);

            [DllImport(hid)]
            public static extern IOHIDElementCookie IOHIDElementGetCookie(IOHIDElementRef element);

            [DllImport(hid)]
            public static extern CFIndex IOHIDValueGetIntegerValue(IOHIDValueRef @value);

            [DllImport(hid)]
            public static extern double IOHIDValueGetScaledValue(
                IOHIDValueRef @value,
                IOHIDValueScaleType type) ;

            [DllImport(hid)]
            public static extern IOHIDElementType IOHIDElementGetType(
                IOHIDElementRef element);

            [DllImport(hid)]
            public static extern IOHIDElementCookie IOHIDElementGetTypeID();

            [DllImport(hid)]
            public static extern int IOHIDElementGetUsage(IOHIDElementRef elem);

            [DllImport(hid)]
            public static extern HIDPage IOHIDElementGetUsagePage(IOHIDElementRef elem);

            [DllImport(hid)]
            public static extern CFIndex IOHIDElementGetLogicalMax(IOHIDElementRef element);

            [DllImport(hid)]
            public static extern CFIndex IOHIDElementGetLogicalMin(IOHIDElementRef element);

            public delegate void IOHIDDeviceCallback(IntPtr ctx, IOReturn res, IntPtr sender, IOHIDDeviceRef device);
            public delegate void IOHIDValueCallback(IntPtr ctx, IOReturn res, IntPtr sender, IOHIDValueRef val);
        }

        enum IOHIDElementType
        {
            Input_Misc = 1,
            Input_Button = 2,
            Input_Axis = 3,
            Input_ScanCodes = 4,
            Output = 129,
            Feature = 257,
            Collection = 513
        }

        enum IOHIDValueScaleType
        {
            Physical, // [device min, device max]
            Calibrated // [-1, +1]
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

        enum HIDKey
        {
            ErrorRollOver = 0x01, /* ErrorRollOver */
            POSTFail  = 0x02, /* POSTFail */
            ErrorUndefined    = 0x03, /* ErrorUndefined */
            A = 0x04, /* a or A */
            B = 0x05, /* b or B */
            C = 0x06, /* c or C */
            D = 0x07, /* d or D */
            E = 0x08, /* e or E */
            F = 0x09, /* f or F */
            G = 0x0A, /* g or G */
            H = 0x0B, /* h or H */
            I = 0x0C, /* i or I */
            J = 0x0D, /* j or J */
            K = 0x0E, /* k or K */
            L = 0x0F, /* l or L */
            M = 0x10, /* m or M */
            N = 0x11, /* n or N */
            O = 0x12, /* o or O */
            P = 0x13, /* p or P */
            Q = 0x14, /* q or Q */
            R = 0x15, /* r or R */
            S = 0x16, /* s or S */
            T = 0x17, /* t or T */
            U = 0x18, /* u or U */
            V = 0x19, /* v or V */
            W = 0x1A, /* w or W */
            X = 0x1B, /* x or X */
            Y = 0x1C, /* y or Y */
            Z = 0x1D, /* z or Z */
            Number1 = 0x1E, /* 1 or ! */
            Number2 = 0x1F, /* 2 or @ */
            Number3 = 0x20, /* 3 or # */
            Number4 = 0x21, /* 4 or $ */
            Number5 = 0x22, /* 5 or % */
            Number6 = 0x23, /* 6 or ^ */
            Number7 = 0x24, /* 7 or & */
            Number8 = 0x25, /* 8 or * */
            Number9 = 0x26, /* 9 or ( */
            Number0 = 0x27, /* 0 or ) */
            ReturnOrEnter = 0x28, /* Return (Enter) */
            Escape    = 0x29, /* Escape */
            DeleteOrBackspace = 0x2A, /* Delete (Backspace) */
            Tab   = 0x2B, /* Tab */
            Spacebar  = 0x2C, /* Spacebar */
            Hyphen    = 0x2D, /* - or _ */
            EqualSign = 0x2E, /* = or + */
            OpenBracket   = 0x2F, /* [ or { */
            CloseBracket  = 0x30, /* ] or } */
            Backslash = 0x31, /* \ or | */
            NonUSPound    = 0x32, /* Non-US # or _ */
            Semicolon = 0x33, /* ; or : */
            Quote = 0x34, /* ' or " */
            GraveAccentAndTilde   = 0x35, /* Grave Accent and Tilde */
            Comma = 0x36, /* , or < */
            Period    = 0x37, /* . or > */
            Slash = 0x38, /* / or ? */
            CapsLock  = 0x39, /* Caps Lock */
            F1    = 0x3A, /* F1 */
            F2    = 0x3B, /* F2 */
            F3    = 0x3C, /* F3 */
            F4    = 0x3D, /* F4 */
            F5    = 0x3E, /* F5 */
            F6    = 0x3F, /* F6 */
            F7    = 0x40, /* F7 */
            F8    = 0x41, /* F8 */
            F9    = 0x42, /* F9 */
            F10   = 0x43, /* F10 */
            F11   = 0x44, /* F11 */
            F12   = 0x45, /* F12 */
            PrintScreen   = 0x46, /* Print Screen */
            ScrollLock    = 0x47, /* Scroll Lock */
            Pause = 0x48, /* Pause */
            Insert    = 0x49, /* Insert */
            Home  = 0x4A, /* Home */
            PageUp    = 0x4B, /* Page Up */
            DeleteForward = 0x4C, /* Delete Forward */
            End   = 0x4D, /* End */
            PageDown  = 0x4E, /* Page Down */
            RightArrow    = 0x4F, /* Right Arrow */
            LeftArrow = 0x50, /* Left Arrow */
            DownArrow = 0x51, /* Down Arrow */
            UpArrow   = 0x52, /* Up Arrow */
            KeypadNumLock = 0x53, /* Keypad NumLock or Clear */
            KeypadSlash   = 0x54, /* Keypad / */
            KeypadAsterisk    = 0x55, /* Keypad * */
            KeypadHyphen  = 0x56, /* Keypad - */
            KeypadPlus    = 0x57, /* Keypad + */
            KeypadEnter   = 0x58, /* Keypad Enter */
            Keypad1   = 0x59, /* Keypad 1 or End */
            Keypad2   = 0x5A, /* Keypad 2 or Down Arrow */
            Keypad3   = 0x5B, /* Keypad 3 or Page Down */
            Keypad4   = 0x5C, /* Keypad 4 or Left Arrow */
            Keypad5   = 0x5D, /* Keypad 5 */
            Keypad6   = 0x5E, /* Keypad 6 or Right Arrow */
            Keypad7   = 0x5F, /* Keypad 7 or Home */
            Keypad8   = 0x60, /* Keypad 8 or Up Arrow */
            Keypad9   = 0x61, /* Keypad 9 or Page Up */
            Keypad0   = 0x62, /* Keypad 0 or Insert */
            KeypadPeriod  = 0x63, /* Keypad . or Delete */
            NonUSBackslash    = 0x64, /* Non-US \ or | */
            Application   = 0x65, /* Application */
            Power = 0x66, /* Power */
            KeypadEqualSign   = 0x67, /* Keypad = */
            F13   = 0x68, /* F13 */
            F14   = 0x69, /* F14 */
            F15   = 0x6A, /* F15 */
            F16   = 0x6B, /* F16 */
            F17   = 0x6C, /* F17 */
            F18   = 0x6D, /* F18 */
            F19   = 0x6E, /* F19 */
            F20   = 0x6F, /* F20 */
            F21   = 0x70, /* F21 */
            F22   = 0x71, /* F22 */
            F23   = 0x72, /* F23 */
            F24   = 0x73, /* F24 */
            Execute   = 0x74, /* Execute */
            Help  = 0x75, /* Help */
            Menu  = 0x76, /* Menu */
            Select    = 0x77, /* Select */
            Stop  = 0x78, /* Stop */
            Again = 0x79, /* Again */
            Undo  = 0x7A, /* Undo */
            Cut   = 0x7B, /* Cut */
            Copy  = 0x7C, /* Copy */
            Paste = 0x7D, /* Paste */
            Find  = 0x7E, /* Find */
            Mute  = 0x7F, /* Mute */
            VolumeUp  = 0x80, /* Volume Up */
            VolumeDown    = 0x81, /* Volume Down */
            LockingCapsLock   = 0x82, /* Locking Caps Lock */
            LockingNumLock    = 0x83, /* Locking Num Lock */
            LockingScrollLock = 0x84, /* Locking Scroll Lock */
            KeypadComma   = 0x85, /* Keypad Comma */
            KeypadEqualSignAS400  = 0x86, /* Keypad Equal Sign for AS/400 */
            International1    = 0x87, /* International1 */
            International2    = 0x88, /* International2 */
            International3    = 0x89, /* International3 */
            International4    = 0x8A, /* International4 */
            International5    = 0x8B, /* International5 */
            International6    = 0x8C, /* International6 */
            International7    = 0x8D, /* International7 */
            International8    = 0x8E, /* International8 */
            International9    = 0x8F, /* International9 */
            LANG1 = 0x90, /* LANG1 */
            LANG2 = 0x91, /* LANG2 */
            LANG3 = 0x92, /* LANG3 */
            LANG4 = 0x93, /* LANG4 */
            LANG5 = 0x94, /* LANG5 */
            LANG6 = 0x95, /* LANG6 */
            LANG7 = 0x96, /* LANG7 */
            LANG8 = 0x97, /* LANG8 */
            LANG9 = 0x98, /* LANG9 */
            AlternateErase    = 0x99, /* AlternateErase */
            SysReqOrAttention = 0x9A, /* SysReq/Attention */
            Cancel    = 0x9B, /* Cancel */
            Clear = 0x9C, /* Clear */
            Prior = 0x9D, /* Prior */
            Return    = 0x9E, /* Return */
            Separator = 0x9F, /* Separator */
            Out   = 0xA0, /* Out */
            Oper  = 0xA1, /* Oper */
            ClearOrAgain  = 0xA2, /* Clear/Again */
            CrSelOrProps  = 0xA3, /* CrSel/Props */
            ExSel = 0xA4, /* ExSel */
            /* 0xA5-0xDF Reserved */
            LeftControl   = 0xE0, /* Left Control */
            LeftShift = 0xE1, /* Left Shift */
            LeftAlt   = 0xE2, /* Left Alt */
            LeftGUI   = 0xE3, /* Left GUI */
            RightControl  = 0xE4, /* Right Control */
            RightShift    = 0xE5, /* Right Shift */
            RightAlt  = 0xE6, /* Right Alt */
            RightGUI  = 0xE7, /* Right GUI */
            /* 0xE8-0xFFFF Reserved */
            //_Reserved = 0xFFFF
        }

        // Maps HIDKey to OpenTK.Input.Key.
        static readonly Key[] RawKeyMap = new Key[]
        {
            Key.Unknown,
            Key.Unknown, /* ErrorRollOver */
            Key.Unknown,  /* POSTFail */
            Key.Unknown, /* ErrorUndefined */
            Key.A, /* a or A */
            Key.B, /* b or B */
            Key.C, /* c or C */
            Key.D, /* d or D */
            Key.E, /* e or E */
            Key.F, /* f or F */
            Key.G, /* g or G */
            Key.H, /* h or H */
            Key.I, /* i or I */
            Key.J, /* j or J */
            Key.K, /* k or K */
            Key.L, /* l or L */
            Key.M, /* m or M */
            Key.N, /* n or N */
            Key.O, /* o or O */
            Key.P, /* p or P */
            Key.Q, /* q or Q */
            Key.R, /* r or R */
            Key.S, /* s or S */
            Key.T, /* t or T */
            Key.U, /* u or U */
            Key.V, /* v or V */
            Key.W, /* w or W */
            Key.X, /* x or X */
            Key.Y, /* y or Y */
            Key.Z, /* z or Z */
            Key.Number1, /* 1 or ! */
            Key.Number2, /* 2 or @ */
            Key.Number3, /* 3 or # */
            Key.Number4, /* 4 or $ */
            Key.Number5, /* 5 or % */
            Key.Number6, /* 6 or ^ */
            Key.Number7, /* 7 or & */
            Key.Number8, /* 8 or * */
            Key.Number9, /* 9 or ( */
            Key.Number0, /* 0 or ) */
            Key.Enter, /* Return (Enter) */
            Key.Escape, /* Escape */
            Key.BackSpace, /* Delete (Backspace) */
            Key.Tab, /* Tab */
            Key.Space, /* Spacebar */
            Key.Minus, /* - or _ */
            Key.Plus, /* = or + */
            Key.BracketLeft, /* [ or { */
            Key.BracketRight, /* ] or } */
            Key.BackSlash, /* \ or | */
            Key.Minus, /* Non-US # or _ */
            Key.Semicolon, /* ; or : */
            Key.Quote, /* ' or " */
            Key.Tilde, /* Grave Accent and Tilde */
            Key.Comma, /* , or < */
            Key.Period, /* . or > */
            Key.Slash, /* / or ? */
            Key.CapsLock, /* Caps Lock */
            Key.F1, /* F1 */
            Key.F2, /* F2 */
            Key.F3, /* F3 */
            Key.F4, /* F4 */
            Key.F5, /* F5 */
            Key.F6, /* F6 */
            Key.F7, /* F7 */
            Key.F8, /* F8 */
            Key.F9, /* F9 */
            Key.F10, /* F10 */
            Key.F11, /* F11 */
            Key.F12, /* F12 */
            Key.PrintScreen, /* Print Screen */
            Key.ScrollLock, /* Scroll Lock */
            Key.Pause, /* Pause */
            Key.Insert, /* Insert */
            Key.Home, /* Home */
            Key.PageUp, /* Page Up */
            Key.Delete, /* Delete Forward */
            Key.End, /* End */
            Key.PageDown, /* Page Down */
            Key.Right, /* Right Arrow */
            Key.Left, /* Left Arrow */
            Key.Down, /* Down Arrow */
            Key.Up, /* Up Arrow */
            Key.NumLock, /* Keypad NumLock or Clear */
            Key.KeypadDivide, /* Keypad / */
            Key.KeypadMultiply, /* Keypad * */
            Key.KeypadMinus, /* Keypad - */
            Key.KeypadPlus, /* Keypad + */
            Key.KeypadEnter, /* Keypad Enter */
            Key.Keypad1, /* Keypad 1 or End */
            Key.Keypad2, /* Keypad 2 or Down Arrow */
            Key.Keypad3, /* Keypad 3 or Page Down */
            Key.Keypad4, /* Keypad 4 or Left Arrow */
            Key.Keypad5, /* Keypad 5 */
            Key.Keypad6, /* Keypad 6 or Right Arrow */
            Key.Keypad7, /* Keypad 7 or Home */
            Key.Keypad8, /* Keypad 8 or Up Arrow */
            Key.Keypad9, /* Keypad 9 or Page Up */
            Key.Keypad0, /* Keypad 0 or Insert */
            Key.KeypadDecimal, /* Keypad . or Delete */
            Key.BackSlash, /* Non-US \ or | */
            Key.Unknown, /* Application */
            Key.Unknown, /* Power */
            Key.Unknown, /* Keypad = */
            Key.F13, /* F13 */
            Key.F14, /* F14 */
            Key.F15, /* F15 */
            Key.F16, /* F16 */
            Key.F17, /* F17 */
            Key.F18, /* F18 */
            Key.F19, /* F19 */
            Key.F20, /* F20 */
            Key.F21, /* F21 */
            Key.F22, /* F22 */
            Key.F23, /* F23 */
            Key.F24, /* F24 */
            Key.Unknown, /* Execute */
            Key.Unknown, /* Help */
            Key.Menu, /* Menu */
            Key.Unknown, /* Select */
            Key.Unknown, /* Stop */
            Key.Unknown, /* Again */
            Key.Unknown, /* Undo */
            Key.Unknown, /* Cut */
            Key.Unknown, /* Copy */
            Key.Unknown, /* Paste */
            Key.Unknown, /* Find */
            Key.Unknown, /* Mute */
            Key.Unknown, /* Volume Up */
            Key.Unknown, /* Volume Down */
            Key.CapsLock, /* Locking Caps Lock */
            Key.NumLock , /* Locking Num Lock */
            Key.ScrollLock, /* Locking Scroll Lock */
            Key.KeypadDecimal, /* Keypad Comma */
            Key.Unknown, /* Keypad Equal Sign for AS/400 */
            Key.Unknown, /* International1 */
            Key.Unknown, /* International2 */
            Key.Unknown, /* International3 */
            Key.Unknown, /* International4 */
            Key.Unknown, /* International5 */
            Key.Unknown, /* International6 */
            Key.Unknown, /* International7 */
            Key.Unknown, /* International8 */
            Key.Unknown, /* International9 */
            Key.Unknown, /* LANG1 */
            Key.Unknown, /* LANG2 */
            Key.Unknown, /* LANG3 */
            Key.Unknown, /* LANG4 */
            Key.Unknown, /* LANG5 */
            Key.Unknown, /* LANG6 */
            Key.Unknown, /* LANG7 */
            Key.Unknown, /* LANG8 */
            Key.Unknown, /* LANG9 */
            Key.Unknown, /* AlternateErase */
            Key.Unknown, /* SysReq/Attention */
            Key.Unknown, /* Cancel */
            Key.Unknown, /* Clear */
            Key.Unknown, /* Prior */
            Key.Enter, /* Return */
            Key.Unknown, /* Separator */
            Key.Unknown, /* Out */
            Key.Unknown, /* Oper */
            Key.Unknown, /* Clear/Again */
            Key.Unknown, /* CrSel/Props */
            Key.Unknown, /* ExSel */
            /* 0xA5-0xDF Reserved */
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            Key.LControl, /* Left Control */
            Key.LShift, /* Left Shift */
            Key.LAlt, /* Left Alt */
            Key.LWin, /* Left GUI */
            Key.RControl, /* Right Control */
            Key.RShift, /* Right Shift */
            Key.RAlt, /* Right Alt */
            Key.RWin, /* Right GUI */
            /* 0xE8-0xFFFF Reserved */
        };

        #endregion

        #region IDisposable Members


        void Dispose(bool manual)
        {
            if (!disposed)
            {
                if (manual)
                {
                    if (MouseEventTapSource != IntPtr.Zero)
                    {
                        // Note: releasing the mach port (tap source)
                        // automatically releases the event tap.
                        CF.RunLoopRemoveSource(RunLoop, MouseEventTapSource, CF.RunLoopModeDefault);
                        CF.CFRelease(MouseEventTapSource);
                        MouseEventTapSource = IntPtr.Zero;
                    }

                    NativeMethods.IOHIDManagerRegisterDeviceMatchingCallback(
                        hidmanager, IntPtr.Zero, IntPtr.Zero);
                    NativeMethods.IOHIDManagerRegisterDeviceRemovalCallback(
                        hidmanager, IntPtr.Zero, IntPtr.Zero);
                    NativeMethods.IOHIDManagerUnscheduleFromRunLoop(
                        hidmanager, RunLoop, InputLoopMode);

                    for (int i = 0; i < Math.Max(MouseDevices.Count, 4); i++)
                    {
                        if (MouseDevices[i] != null)
                        {
                            DeviceRemoved(IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, MouseDevices[i].Id);
                        }
                    }

                    for (int i = 0; i < Math.Max(KeyboardDevices.Count, 4); i++)
                    {
                        if (KeyboardDevices[i] != null)
                        {
                            DeviceRemoved(IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, KeyboardDevices[i].Id);
                        }
                    }

                    for (int i = 0; i < Math.Max(JoystickDevices.Count, 4); i++)
                    {
                        if (JoystickDevices[i] != null)
                        {
                            DeviceRemoved(IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, JoystickDevices[i].Id);
                        }
                    }

                    if (hidmanager != IntPtr.Zero)
                    {
                        NativeMethods.IOHIDManagerClose(hidmanager, IOOptionBits.Zero);
                        hidmanager = IntPtr.Zero;
                    }

                    if (RunLoop != IntPtr.Zero)
                    {
                        CF.CFRelease(RunLoop);
                    }
                }
                else
                {
                    Debug.Print("{0} leaked, did you forget to call Dispose()?", GetType());
                }
                disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~HIDInput()
        {
            Dispose(false);
        }

        #endregion
    }
}

