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
using System.Threading;
using OpenTK.Input;

namespace OpenTK.Platform.X11
{
    sealed class XI2MouseKeyboard : IKeyboardDriver2, IMouseDriver2, IDisposable
    {
        static readonly IntPtr ExitAtom;
        readonly object Sync = new object();
        readonly Thread ProcessingThread;
        readonly X11KeyMap KeyMap;
        bool disposed;

        class XIMouse
        {
            public MouseState State;
            public XIDeviceInfo DeviceInfo;
            public XIScrollClassInfo ScrollX = new XIScrollClassInfo { number = -1 };
            public XIScrollClassInfo ScrollY = new XIScrollClassInfo { number = -1 };
            public XIValuatorClassInfo MotionX = new XIValuatorClassInfo { number = -1 };
            public XIValuatorClassInfo MotionY = new XIValuatorClassInfo { number = -1 };
            public string Name;
        }

        class XIKeyboard
        {
            public KeyboardState State;
            public XIDeviceInfo DeviceInfo;
            public string Name;
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

        long cursor_x, cursor_y; // For GetCursorState()
        List<XIMouse> devices = new List<XIMouse>(); // list of connected mice
        Dictionary<int, int> rawids = new Dictionary<int, int>(); // maps hardware device ids to XIMouse ids

        List<XIKeyboard> keyboards = new List<XIKeyboard>(); // list of connected keybords
        Dictionary<int, int> keyboard_ids = new Dictionary<int, int>(); // maps hardware device ids to XIKeyboard ids

        internal readonly X11WindowInfo window;
        internal static int XIOpCode { get; private set; }
        internal static int XIVersion { get; private set; }

        static readonly Functions.EventPredicate PredicateImpl = IsEventValid;
        readonly IntPtr Predicate = Marshal.GetFunctionPointerForDelegate(PredicateImpl);

        static XI2MouseKeyboard()
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

                // Custom
                ExitAtom = Functions.XInternAtom(API.DefaultDisplay, "Exit Input Thread Message", false);
            }
        }

        public XI2MouseKeyboard()
        {
            window = new X11WindowInfo();

            window.Display = Functions.XOpenDisplay(IntPtr.Zero);
            using (new XLock(window.Display))
            {
                XSetWindowAttributes attr = new XSetWindowAttributes();

                window.Screen = Functions.XDefaultScreen(window.Display);
                window.RootWindow = Functions.XRootWindow(window.Display, window.Screen);
                window.Handle = Functions.XCreateWindow(window.Display, window.RootWindow,
                    0, 0, 1, 1, 0, 0,
                    CreateWindowArgs.InputOnly, IntPtr.Zero,
                    SetWindowValuemask.Nothing, attr);

                KeyMap = new X11KeyMap(window.Display);
            }

            if (!IsSupported(window.Display))
                throw new NotSupportedException("XInput2 not supported.");

            // Enable XI2 mouse/keyboard events
            // Note: the input event loop blocks waiting for these events
            // *or* a custom ClientMessage event that instructs us to exit.
            // See SendExitEvent() below.
            using (new XLock(window.Display))
            using (XIEventMask mask = new XIEventMask(1,
                XIEventMasks.RawKeyPressMask |
                XIEventMasks.RawKeyReleaseMask |
                XIEventMasks.RawButtonPressMask |
                XIEventMasks.RawButtonReleaseMask |
                XIEventMasks.RawMotionMask |
                XIEventMasks.MotionMask |
                XIEventMasks.DeviceChangedMask))
            {
                XI.SelectEvents(window.Display, window.RootWindow, mask);
                UpdateDevices();
            }

            ProcessingThread = new Thread(ProcessEvents);
            ProcessingThread.IsBackground = true;
            ProcessingThread.Start();
        }

        // Checks whether XInput2 is supported on the specified display.
        // If a display is not specified, the default display is used.
        internal static bool IsSupported(IntPtr display)
        {
            try
            {
                if (display == IntPtr.Zero)
                {
                    display = API.DefaultDisplay;
                }

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
                                XIVersion = major * 100 + minor * 10;
                                return true;
                            }
                            minor--;
                        }
                    }
                }
            }
            catch (DllNotFoundException e)
            {
                Debug.Print(e.ToString());
                Debug.Print("XInput2 extension not supported. Mouse support will suffer.");
            }

            return false;
        }

        #region IKeyboardDriver2 Members

        KeyboardState IKeyboardDriver2.GetState()
        {
            lock (Sync)
            {
                KeyboardState state = new KeyboardState();
                foreach (XIKeyboard k in keyboards)
                {
                    state.MergeBits(k.State);
                }
                return state;
            }
        }

        KeyboardState IKeyboardDriver2.GetState(int index)
        {
            lock (Sync)
            {
                if (index >= 0 && index < keyboards.Count)
                {
                    return keyboards[index].State;
                }
                return new KeyboardState();
            }
        }

        string IKeyboardDriver2.GetDeviceName(int index)
        {
            lock (Sync)
            {
                if (index >= 0 && index < keyboards.Count)
                {
                    return keyboards[index].Name;
                }
                return String.Empty;
            } 
        }

        #endregion

        #region IMouseDriver2 Members

        MouseState IMouseDriver2.GetState()
        {
            lock (Sync)
            {
                MouseState master = new MouseState();
                foreach (var d in devices)
                {
                    master.MergeBits(d.State);
                }
                return master;
            }
        }

        MouseState IMouseDriver2.GetState(int index)
        {
            lock (Sync)
            {
                if (index >= 0 && index < devices.Count)
                {
                    return devices[index].State;
                }
                return new MouseState();
            }
        }

        MouseState IMouseDriver2.GetCursorState()
        {
            lock (Sync)
            {
                MouseState master = (this as IMouseDriver2).GetState();
                master.X = (int)Interlocked.Read(ref cursor_x);
                master.Y = (int)Interlocked.Read(ref cursor_y);
                return master;
            }
        }

        void IMouseDriver2.SetPosition(double x, double y)
        {
            // Note: we cannot use window.Display here, because
            // that will deadlock the input thread, which is
            // blocking inside XIfEvent
            using (new XLock(API.DefaultDisplay))
            {
                Functions.XWarpPointer(API.DefaultDisplay,
                    IntPtr.Zero, window.RootWindow, 0, 0, 0, 0, (int)x, (int)y);
                Functions.XFlush(API.DefaultDisplay);
                Interlocked.Exchange(ref cursor_x, (long)x);
                Interlocked.Exchange(ref cursor_y, (long)y);
            }
        }

        #endregion

        #region Private Members

        void UpdateDevices()
        {
            lock (Sync)
            {
                devices.Clear();
                keyboards.Clear();

                int count;
                unsafe
                {
                    XIDeviceInfo* list = (XIDeviceInfo*)XI.QueryDevice(window.Display,
                        XI.XIAllDevices, out count);

                    Debug.Print("Refreshing input device list");
                    Debug.Print("{0} input devices detected", count);

                    for (int i = 0; i < count; i++)
                    {
                        switch ((list + i)->use)
                        {
                            case XIDeviceType.MasterKeyboard:
                            //case XIDeviceType.SlaveKeyboard:
                                {
                                    XIKeyboard k = new XIKeyboard();
                                    k.DeviceInfo = *(list + i);
                                    k.State.SetIsConnected(k.DeviceInfo.enabled);
                                    k.Name = Marshal.PtrToStringAnsi(k.DeviceInfo.name);
                                    int id = k.DeviceInfo.deviceid;
                                    if (!keyboard_ids.ContainsKey(id))
                                    {
                                        keyboard_ids.Add(k.DeviceInfo.deviceid, 0);
                                    }
                                    keyboard_ids[id] = keyboards.Count;
                                    keyboards.Add(k);
                                }
                                break;

                            case XIDeviceType.MasterPointer:
                            //case XIDeviceType.SlavePointer:
                            case XIDeviceType.FloatingSlave:
                                {
                                    XIMouse d = new XIMouse();
                                    d.DeviceInfo = *(list + i);
                       
                                    d.State.SetIsConnected(d.DeviceInfo.enabled);
                                    d.Name = Marshal.PtrToStringAnsi(d.DeviceInfo.name);
                                    Debug.Print("Device {0} \"{1}\" is {2} and has:",
                                        i, d.Name, d.DeviceInfo.enabled ? "enabled" : "disabled");

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
                                    int id = d.DeviceInfo.deviceid;
                                    if (!rawids.ContainsKey(id))
                                    {
                                        rawids.Add(id, 0);
                                    }
                                    rawids[id] = devices.Count;
                                    devices.Add(d);
                                }
                                break;
                        }
                    }
                    XI.FreeDeviceInfo((IntPtr)list);
                }
            }
        }

        void ProcessEvents()
        {
            while (!disposed)
            {
                XEvent e = new XEvent();
                XGenericEventCookie cookie;

                using (new XLock(window.Display))
                {
                    Functions.XIfEvent(window.Display, ref e, Predicate, new IntPtr(XIOpCode));

                    if (e.type == XEventName.ClientMessage && e.ClientMessageEvent.ptr1 == ExitAtom)
                    {
                        Functions.XDestroyWindow(window.Display, window.Handle);
                        window.Handle = IntPtr.Zero;
                        break;
                    }

                    if (e.type == XEventName.GenericEvent && e.GenericEvent.extension == XIOpCode)
                    {
                        IntPtr dummy;
                        int x, y, dummy2;
                        Functions.XQueryPointer(window.Display, window.RootWindow,
                            out dummy, out dummy, out x, out y,
                            out dummy2, out dummy2, out dummy2);
                        Interlocked.Exchange(ref cursor_x, (long)x);
                        Interlocked.Exchange(ref cursor_y, (long)y);

                        cookie = e.GenericEventCookie;
                        if (Functions.XGetEventData(window.Display, ref cookie) != 0)
                        {
                            switch ((XIEventType)cookie.evtype)
                            {
                                case XIEventType.Motion:
                                // Nothing to do
                                    break;

                                case XIEventType.RawKeyPress:
                                case XIEventType.RawKeyRelease:
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
            Debug.WriteLine("[X11] Exiting input event loop.");
        }

        void ProcessRawEvent(ref XGenericEventCookie cookie)
        {
            lock (Sync)
            {
                unsafe
                {
                    XIRawEvent raw = *(XIRawEvent*)cookie.data;
                    XIMouse mouse;
                    XIKeyboard keyboard;

                    switch (raw.evtype)
                    {
                        case XIEventType.RawMotion:
                            if (GetMouseDevice(raw.deviceid, out mouse))
                            {
                                ProcessRawMotion(mouse, ref raw);
                            }
                            break;

                        case XIEventType.RawButtonPress:
                        case XIEventType.RawButtonRelease:
                            if (GetMouseDevice(raw.deviceid, out mouse))
                            {
                                float dx, dy;
                                MouseButton button = X11KeyMap.TranslateButton(raw.detail, out dx, out dy);
                                mouse.State[button] = raw.evtype == XIEventType.RawButtonPress;
                            }
                            break;

                        case XIEventType.RawKeyPress:
                        case XIEventType.RawKeyRelease:
                            if (GetKeyboardDevice(raw.deviceid, out keyboard))
                            {
                                Key key;
                                if (KeyMap.TranslateKey(raw.detail, out key))
                                {
                                    keyboard.State[key] = raw.evtype == XIEventType.RawKeyPress;
                                }
                            }
                            break;
                    }
                }
            }
        }

        bool GetMouseDevice(int deviceid, out XIMouse mouse)
        {
            if (!rawids.ContainsKey(deviceid))
            {
                Debug.Print("Unknown mouse device {0} encountered, ignoring.", deviceid);
                mouse = null;
                return false;
            }
            mouse = devices[rawids[deviceid]];
            return true;
        }

        bool GetKeyboardDevice(int deviceid, out XIKeyboard keyboard)
        {
            if (!keyboard_ids.ContainsKey(deviceid))
            {
                Debug.Print("Unknown keyboard device {0} encountered, ignoring.", deviceid);
                keyboard = null;
                return false;
            }
            keyboard = keyboards[keyboard_ids[deviceid]];
            return true;
        }

        unsafe static void ProcessRawMotion(XIMouse d, ref XIRawEvent raw)
        {
            // Note: we use the raw values here, without pointer
            // ballistics and any other modification.
            double x = ReadRawValue(ref raw, d.MotionX.number);
            double y = ReadRawValue(ref raw, d.MotionY.number);
            double h = ReadRawValue(ref raw, d.ScrollX.number) / d.ScrollX.increment;
            double v = ReadRawValue(ref raw, d.ScrollY.number) / d.ScrollY.increment;

            d.State.X += (int)Math.Round(x);
            d.State.Y += (int)Math.Round(y);

            // Note: OpenTK follows the windows scrolling convention where
            // (+h, +v) = (right, up). XI2 uses (+h, +v) = (right, down)
            // instead, so we need to flip the vertical offset.
            d.State.SetScrollRelative((float)h, (float)(-v));
        }

        unsafe static double ReadRawValue(ref XIRawEvent raw, int bit)
        {
            double value = 0;
            if (IsBitSet(raw.valuators.mask, bit))
            {
                // Find the offset where this value is stored.
                // The offset is equal to the number of bits
                // set in raw.valuators.mask between [0, bit)
                int offset = 0;
                for (int i = 0; i < bit; i++)
                {
                    if (IsBitSet(raw.valuators.mask, i))
                    {
                        offset++;
                    }
                }
                value = *((double*)raw.raw_values + offset);
            }
            return value;
        }

        static bool IsEventValid(IntPtr display, ref XEvent e, IntPtr arg)
        {
            bool valid = false;
            switch (e.type)
            {
                case XEventName.GenericEvent:
                {
                    long extension = (long)e.GenericEventCookie.extension;
                    valid =
                        extension == arg.ToInt64() &&
                        (e.GenericEventCookie.evtype == (int)XIEventType.RawKeyPress ||
                        e.GenericEventCookie.evtype == (int)XIEventType.RawKeyRelease ||
                        e.GenericEventCookie.evtype == (int)XIEventType.RawMotion ||
                        e.GenericEventCookie.evtype == (int)XIEventType.RawButtonPress ||
                        e.GenericEventCookie.evtype == (int)XIEventType.RawButtonRelease ||
                        e.GenericEventCookie.evtype == (int)XIEventType.DeviceChanged);
                    valid |= extension == 0;
                    break;
                }

                case XEventName.ClientMessage:
                    valid =
                        e.ClientMessageEvent.ptr1 == ExitAtom;
                    break;
            }

            return valid;
        }

        static bool IsBitSet(IntPtr mask, int bit)
        {
            unsafe
            {
                return bit >= 0 && (*((byte*)mask + (bit >> 3)) & (1 << (bit & 7))) != 0;
            }
        }

        void SendExitEvent()
        {
            // Send a ClientMessage event to unblock XIfEvent
            // and exit the input event loop.
            using (new XLock(API.DefaultDisplay))
            {
                XEvent ev = new XEvent();
                ev.type = XEventName.ClientMessage;
                ev.ClientMessageEvent.display = window.Display;
                ev.ClientMessageEvent.window = window.Handle;
                ev.ClientMessageEvent.format = 32;
                ev.ClientMessageEvent.ptr1 = ExitAtom;
                Functions.XSendEvent(API.DefaultDisplay, window.Handle, false, 0, ref ev);
                Functions.XFlush(API.DefaultDisplay);
            }
        }

        #endregion

        #region IDisposable Members

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        void Dispose(bool disposing)
        {
            if (!disposed)
            {
                disposed = true;
                SendExitEvent();
            }
        }

        ~XI2MouseKeyboard()
        {
            Dispose(false);
        }

        #endregion
    }
}

