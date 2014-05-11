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

namespace OpenTK.Platform.X11
{
    // Todo: multi-mouse support. Right now we aggregate all data into a single mouse device.
    // This should be easy: just read the device id and route the data to the correct device.
    sealed class XI2Mouse : IMouseDriver2
    {
        class XIMouse
        {
            public MouseState State;
            public XIDeviceInfo DeviceInfo;
            public XIScrollClassInfo ScrollX = new XIScrollClassInfo { number = -1 };
            public XIScrollClassInfo ScrollY = new XIScrollClassInfo { number = -1 };
            public XIValuatorClassInfo MotionX = new XIValuatorClassInfo { number = -1 };
            public XIValuatorClassInfo MotionY = new XIValuatorClassInfo { number = -1 };
        }

        // Atoms
        //static readonly IntPtr ButtonLeft;
        //static readonly IntPtr ButtonMiddle;
        ////static readonly IntPtr ButtonRight;
        //static readonly IntPtr ButtonWheelUp;
        //static readonly IntPtr ButtonWheelDown;
        //static readonly IntPtr ButtonWheelLeft;
        //static readonly IntPtr ButtonWheelRight;
        static readonly IntPtr RelX;
        static readonly IntPtr RelY;
        //static readonly IntPtr RelHorizScroll;
        //static readonly IntPtr RelVertScroll;
        //static readonly IntPtr RelHorizWheel;
        //static readonly IntPtr RelVertWheel;

        List<XIMouse> devices = new List<XIMouse>(); // List of connected mice
        Dictionary<int, int> rawids = new Dictionary<int, int>(); // maps hardware device ids to XIMouse ids

        internal readonly X11WindowInfo window;
        internal static int XIOpCode { get; private set; }

        static readonly Functions.EventPredicate PredicateImpl = IsEventValid;
        readonly IntPtr Predicate = Marshal.GetFunctionPointerForDelegate(PredicateImpl);

        // Store information on a mouse warp event, so it can be ignored.
        struct MouseWarp : IEquatable<MouseWarp>
        {
            public MouseWarp(double x, double y) { X = x; Y = y; }
            double X, Y;
            public bool Equals(MouseWarp warp) { return X == warp.X && Y == warp.Y; }
        }
        MouseWarp? mouse_warp_event;
        int mouse_warp_event_count;

        static XI2Mouse()
        {
            using (new XLock(API.DefaultDisplay))
            {
                // Mouse
                //ButtonLeft = Functions.XInternAtom(API.DefaultDisplay, "Button Left", false);
                //ButtonMiddle = Functions.XInternAtom(API.DefaultDisplay, "Button Middle", false);
                //ButtonRight = Functions.XInternAtom(API.DefaultDisplay, "Button Right", false);
                //ButtonWheelUp = Functions.XInternAtom(API.DefaultDisplay, "Button Wheel Up", false);
                //ButtonWheelDown = Functions.XInternAtom(API.DefaultDisplay, "Button Wheel Down", false);
                //ButtonWheelLeft = Functions.XInternAtom(API.DefaultDisplay, "Button Horiz Wheel Left", false);
                //ButtonWheelRight = Functions.XInternAtom(API.DefaultDisplay, "Button Horiz Wheel Right", false);
                RelX = Functions.XInternAtom(API.DefaultDisplay, "Rel X", false);
                RelY = Functions.XInternAtom(API.DefaultDisplay, "Rel Y", false);
                //RelHorizWheel = Functions.XInternAtom(API.DefaultDisplay, "Rel Horiz Wheel", false);
                //RelVertWheel = Functions.XInternAtom(API.DefaultDisplay, "Rel Vert Wheel", false);
                //RelHorizScroll = Functions.XInternAtom(API.DefaultDisplay, "Rel Horiz Scroll", false);
                //RelVertScroll = Functions.XInternAtom(API.DefaultDisplay, "Rel Vert Scroll", false);

                // Multitouch
                //TouchX = Functions.XInternAtom(API.DefaultDisplay, "Abs MT Position X", false);
                //TouchY = Functions.XInternAtom(API.DefaultDisplay, "Abs MT Position Y", false);
                //TouchMajor = Functions.XInternAtom(API.DefaultDisplay, "Abs MT Touch Major", false);
                //TouchMinor = Functions.XInternAtom(API.DefaultDisplay, "Abs MT Touch Minor", false);
                //TouchPressure = Functions.XInternAtom(API.DefaultDisplay, "Abs MT Pressure", false);
                //TouchId = Functions.XInternAtom(API.DefaultDisplay, "Abs MT Tracking ID", false);
                //TouchMaxContacts = Functions.XInternAtom(API.DefaultDisplay, "Max Contacts", false);
            }
        }

        public XI2Mouse()
        {
            Debug.WriteLine("Using XI2Mouse.");

            using (new XLock(API.DefaultDisplay))
            {
                window = new X11WindowInfo();
                window.Display = API.DefaultDisplay;
                window.Screen = Functions.XDefaultScreen(window.Display);
                window.RootWindow = Functions.XRootWindow(window.Display, window.Screen);
                window.Handle = window.RootWindow;
            }

            if (!IsSupported(window.Display))
                throw new NotSupportedException("XInput2 not supported.");

            using (new XLock(API.DefaultDisplay))
            using (XIEventMask mask = new XIEventMask(1,
                XIEventMasks.RawButtonPressMask |
                XIEventMasks.RawButtonReleaseMask |
                XIEventMasks.RawMotionMask |
                XIEventMasks.DeviceChangedMask))
            {
                XI.SelectEvents(window.Display, window.Handle, mask);
            }

            UpdateDevices();
        }

        // Checks whether XInput2 is supported on the specified display.
        // If a display is not specified, the default display is used.
        internal static bool IsSupported(IntPtr display)
        {
            if (display == IntPtr.Zero)
                display = API.DefaultDisplay;

            using (new XLock(display))
            {
                int major, ev, error;
                if (Functions.XQueryExtension(display, "XInputExtension", out major, out ev, out error) != 0)
                {
                    XIOpCode = major;

                    int minor = 2;
                    while (minor >= 0)
                    {
                        if (XI.QueryVersion(display, ref major, ref minor) == ErrorCodes.Success)
                        {
                            return true;
                        }
                        minor--;
                    }
                }
            }

            return false;
        }

        void UpdateDevices()
        {
            int count;
            unsafe
            {
                XIDeviceInfo* list = (XIDeviceInfo*)XI.QueryDevice(window.Display, 1, out count);

                Debug.Print("Refreshing mouse device list");
                Debug.Print("{0} mouse devices detected", count);

                for (int i = 0; i < count; i++)
                {
                    if (devices.Count <= i)
                    {
                        devices.Add(new XIMouse());
                    }
                    XIMouse d = devices[i];
                    d.DeviceInfo = *(list + i);
                    d.State.SetIsConnected(d.DeviceInfo.enabled);
                    Debug.Print("Device {0} is {1} and has:",
                        i, d.DeviceInfo.enabled ? "enabled" : "disabled");

                    // Decode the XIDeviceInfo to axes, buttons and scroll types
                    for (int j = 0; j < d.DeviceInfo.num_classes; j++)
                    {
                        XIAnyClassInfo* class_info = *((XIAnyClassInfo**)d.DeviceInfo.classes + j);
                        switch (class_info->type)
                        {
                            case XIClassType.Button:
                                {
                                    XIButtonClassInfo* button = (XIButtonClassInfo*)class_info;
                                    Debug.Print("\t{0} buttons", button->num_buttons);
                                }
                                break;

                            case XIClassType.Scroll:
                                {
                                    XIScrollClassInfo* scroll = (XIScrollClassInfo*)class_info;
                                    switch (scroll->scroll_type)
                                    {
                                        case XIScrollType.Vertical:
                                            Debug.WriteLine("\tSmooth vertical scrolling");
                                            d.ScrollY = *scroll;
                                            break;

                                        case XIScrollType.Horizontal:
                                            Debug.WriteLine("\tSmooth horizontal scrolling");
                                            d.ScrollX = *scroll;
                                            break;

                                        default:
                                            Debug.Print("\tUnknown scrolling type {0}", scroll->scroll_type);
                                            break;
                                    }
                                }
                                break;

                            case XIClassType.Valuator:
                                {
                                    XIValuatorClassInfo* valuator = (XIValuatorClassInfo*)class_info;
                                    if (valuator->label == RelX)
                                    {
                                        Debug.WriteLine("\tRelative X movement");
                                        d.MotionX = *valuator;
                                    }
                                    else if (valuator->label == RelY)
                                    {
                                        Debug.WriteLine("\tRelative Y movement");
                                        d.MotionY = *valuator;
                                    }
                                }
                                break;
                        }
                    }

                    // Map the hardware device id to the current XIMouse id
                    if (!rawids.ContainsKey(d.DeviceInfo.deviceid))
                    {
                        rawids.Add(d.DeviceInfo.deviceid, 0);
                    }
                    rawids[d.DeviceInfo.deviceid] = i;
                }
                XI.FreeDeviceInfo((IntPtr)list);
            }

        }

        #region IMouseDriver2 Members

        public MouseState GetState()
        {
            ProcessEvents();
            MouseState master = new MouseState();
            foreach (var d in devices)
            {
                master.MergeBits(d.State);
            }
            return master;
        }

        public MouseState GetState(int index)
        {
            ProcessEvents();
            if (devices.Count > index)
                return devices[index].State;
            else
                return new MouseState();
        }

        public MouseState GetCursorState()
        {
            IntPtr dummy;
            int x, y, dummy2;
            using (new XLock(window.Display))
            {
                Functions.XQueryPointer(window.Display, window.RootWindow,
                    out dummy, out dummy, out x, out y,
                    out dummy2, out dummy2, out dummy2);
            }

            MouseState master = GetState();
            master.X = x;
            master.Y = y;
            return master;
        }

        public void SetPosition(double x, double y)
        {
            using (new XLock(window.Display))
            {
                Functions.XWarpPointer(window.Display,
                    IntPtr.Zero, window.RootWindow, 0, 0, 0, 0, (int)x, (int)y);

                // Mark the expected warp-event so it can be ignored.
                if (mouse_warp_event == null)
                    mouse_warp_event_count = 0;
                mouse_warp_event_count++;
                mouse_warp_event = new MouseWarp((int)x, (int)y);
            }

            ProcessEvents();
        }

        #endregion

        bool CheckMouseWarp(double x, double y)
        {
            // Check if a mouse warp with the specified destination exists.
            bool is_warp =
                mouse_warp_event.HasValue &&
                mouse_warp_event.Value.Equals(new MouseWarp((int)x, (int)y));

            if (is_warp && --mouse_warp_event_count <= 0)
                    mouse_warp_event = null;

            return is_warp;
        }

        void ProcessEvents()
        {
            while (true)
            {
                XEvent e = new XEvent();
                XGenericEventCookie cookie;

                using (new XLock(window.Display))
                {
                    if (!Functions.XCheckIfEvent(window.Display, ref e, Predicate, new IntPtr(XIOpCode)))
                        return;

                    cookie = e.GenericEventCookie;
                    if (Functions.XGetEventData(window.Display, ref cookie) != 0)
                    {
                        switch ((XIEventType)cookie.evtype)
                        {
                            case XIEventType.RawMotion:
                            case XIEventType.RawButtonPress:
                            case XIEventType.RawButtonRelease:
                                // Delivered to all XIMouse instances
                                ProcessRawEvent(ref cookie);
                                break;

                            case XIEventType.DeviceChanged:
                                UpdateDevices();
                                break;
                        }
                    }
                    Functions.XFreeEventData(window.Display, ref cookie);
                }
            }
        }

        void ProcessRawEvent(ref XGenericEventCookie cookie)
        {
            unsafe
            {
                XIRawEvent* raw = (XIRawEvent*)cookie.data;

                if (!rawids.ContainsKey(raw->deviceid))
                {
                    Debug.Print("Unknown mouse device {0} encountered, ignoring.", raw->deviceid);
                    return;
                }

                var d = devices[rawids[raw->deviceid]];

                switch (raw->evtype)
                {
                    case XIEventType.RawMotion:
                        {
                            // Check if this event contains position information
                            // Note: we use the raw values here, without pointer
                            // ballistics and any other modification.
                            double x = 0, y = 0;
                            if (IsBitSet(raw->valuators.mask, d.MotionX.number))
                            {
                                x = *((double*)raw->raw_values + d.MotionX.number);
                            }
                            if (IsBitSet(raw->valuators.mask, d.MotionY.number))
                            {
                                y = *((double*)raw->raw_values + d.MotionY.number);
                            }
                            d.State.X += (int)Math.Round(x);
                            d.State.Y += (int)Math.Round(y);

                            // Check if this event contains scrolling information
                            // Note: we use transformed (valuator) values here,
                            // because they seem to make more sense compared to
                            // the raw values (the XI2 docs are pretty scarce on
                            // how to use the raw values for scrolling.)
                            double h = 0, v = 0;
                            bool is_emulated = (raw->flags & XIEventFlags.PointerEmulated) != 0;
                            if (!is_emulated && IsBitSet(raw->valuators.mask, d.ScrollX.number))
                            {
                                h = *((double*)raw->valuators.values + d.ScrollX.number) / d.ScrollX.increment;
                                if (Double.IsInfinity(h))
                                {
                                    Debug.WriteLine("[XI2] Mouse horizontal scroll was infinity.");
                                    h = 0;
                                }
                            }
                            if (!is_emulated && IsBitSet(raw->valuators.mask, d.ScrollY.number))
                            {
                                v = *((double*)raw->valuators.values + d.ScrollY.number) / d.ScrollY.increment;
                                if (Double.IsInfinity(v))
                                {
                                    Debug.WriteLine("[XI2] Mouse horizontal scroll was infinity.");
                                    v = 0;
                                }
                            }
                            d.State.SetScrollRelative((float)h, (float)v);
                        }
                        break;

                    case XIEventType.RawButtonPress:
                        switch (raw->detail)
                        {
                            case 1: d.State.EnableBit((int)MouseButton.Left); break;
                            case 2: d.State.EnableBit((int)MouseButton.Middle); break;
                            case 3: d.State.EnableBit((int)MouseButton.Right); break;
                            case 6: d.State.EnableBit((int)MouseButton.Button1); break;
                            case 7: d.State.EnableBit((int)MouseButton.Button2); break;
                            case 8: d.State.EnableBit((int)MouseButton.Button3); break;
                            case 9: d.State.EnableBit((int)MouseButton.Button4); break;
                            case 10: d.State.EnableBit((int)MouseButton.Button5); break;
                            case 11: d.State.EnableBit((int)MouseButton.Button6); break;
                            case 12: d.State.EnableBit((int)MouseButton.Button7); break;
                            case 13: d.State.EnableBit((int)MouseButton.Button8); break;
                            case 14: d.State.EnableBit((int)MouseButton.Button9); break;
                        }
                        break;

                    case XIEventType.RawButtonRelease:
                        switch (raw->detail)
                        {
                            case 1: d.State.DisableBit((int)MouseButton.Left); break;
                            case 2: d.State.DisableBit((int)MouseButton.Middle); break;
                            case 3: d.State.DisableBit((int)MouseButton.Right); break;
                            case 6: d.State.DisableBit((int)MouseButton.Button1); break;
                            case 7: d.State.DisableBit((int)MouseButton.Button2); break;
                            case 8: d.State.DisableBit((int)MouseButton.Button3); break;
                            case 9: d.State.DisableBit((int)MouseButton.Button4); break;
                            case 10: d.State.DisableBit((int)MouseButton.Button5); break;
                            case 11: d.State.DisableBit((int)MouseButton.Button6); break;
                            case 12: d.State.DisableBit((int)MouseButton.Button7); break;
                            case 13: d.State.DisableBit((int)MouseButton.Button8); break;
                            case 14: d.State.DisableBit((int)MouseButton.Button9); break;
                        }
                        break;
                }
            }
        }

        static bool IsEventValid(IntPtr display, ref XEvent e, IntPtr arg)
        {
            return
                (long)e.GenericEventCookie.extension == arg.ToInt64() &&
                e.GenericEventCookie.evtype == (int)XIEventType.RawMotion ||
                e.GenericEventCookie.evtype == (int)XIEventType.RawButtonPress ||
                e.GenericEventCookie.evtype == (int)XIEventType.RawButtonRelease ||
                e.GenericEventCookie.evtype == (int)XIEventType.DeviceChanged;
        }

        static bool IsBitSet(IntPtr mask, int bit)
        {
            unsafe
            {
                return bit >= 0 && (*((byte*)mask + (bit >> 3)) & (1 << (bit & 7))) != 0;
            }
        }
    }
}

