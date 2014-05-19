#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2014 Stefanos Apostolopoulos for the Open Toolkit library.
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
using System.Runtime.InteropServices;
using System.Text;

namespace OpenTK.Platform.X11
{
    using Bool = Boolean;
    using Cursor = IntPtr;
    using Display = IntPtr;
    using Status = ErrorCodes;
    using Time = IntPtr;
    using Window = IntPtr;

    // Bindings for the XInput2 extension
    class XI
    {
        const string lib = "libXi";

        internal const int XIAllDevices = 0;
        internal const int XIAllMasterDevices = 1;

        // mouse
        internal static readonly IntPtr ButtonLeft = Functions.XInternAtom(API.DefaultDisplay, "Button Left", false);
        internal static readonly IntPtr ButtonMiddle = Functions.XInternAtom(API.DefaultDisplay, "Button Middle", false);
        internal static readonly IntPtr ButtonRight = Functions.XInternAtom(API.DefaultDisplay, "Button Right", false);
        internal static readonly IntPtr ButtonWheelUp = Functions.XInternAtom(API.DefaultDisplay, "Button Wheel Up", false);
        internal static readonly IntPtr ButtonWheelDown = Functions.XInternAtom(API.DefaultDisplay, "Button Wheel Down", false);
        internal static readonly IntPtr ButtonWheelLeft = Functions.XInternAtom(API.DefaultDisplay, "Button Horiz Wheel Left", false);
        internal static readonly IntPtr ButtonWheelRight = Functions.XInternAtom(API.DefaultDisplay, "Button Horiz Wheel Right", false);
        internal static readonly IntPtr RelativeX = Functions.XInternAtom(API.DefaultDisplay, "Rel X", false);
        internal static readonly IntPtr RelativeY = Functions.XInternAtom(API.DefaultDisplay, "Rel Y", false);
        internal static readonly IntPtr RelativeHWheel = Functions.XInternAtom(API.DefaultDisplay, "Rel Horiz Wheel", false);
        internal static readonly IntPtr RelativeVWheel = Functions.XInternAtom(API.DefaultDisplay, "Rel Vert Wheel", false);
        internal static readonly IntPtr RelativeHScroll = Functions.XInternAtom(API.DefaultDisplay, "Rel Horiz Scroll", false);
        internal static readonly IntPtr RelativeVScroll = Functions.XInternAtom(API.DefaultDisplay, "Rel Vert Scroll", false);

        // multitouch
        internal static readonly IntPtr TouchX = Functions.XInternAtom(API.DefaultDisplay, "Abs MT Position X", false);
        internal static readonly IntPtr TouchY = Functions.XInternAtom(API.DefaultDisplay, "Abs MT Position Y", false);
        internal static readonly IntPtr TouchMajor = Functions.XInternAtom(API.DefaultDisplay, "Abs MT Touch Major", false);
        internal static readonly IntPtr TouchMinor = Functions.XInternAtom(API.DefaultDisplay, "Abs MT Touch Minor", false);
        internal static readonly IntPtr TouchPressure = Functions.XInternAtom(API.DefaultDisplay, "Abs MT Pressure", false);
        internal static readonly IntPtr TouchId = Functions.XInternAtom(API.DefaultDisplay, "Abs MT Tracking ID", false);
        internal static readonly IntPtr TouchMaxContacts = Functions.XInternAtom(API.DefaultDisplay, "Max Contacts", false);

        // tablet
        internal static readonly IntPtr AbsoluteX = Functions.XInternAtom(API.DefaultDisplay, "Abs X", false);
        internal static readonly IntPtr AbsoluteY = Functions.XInternAtom(API.DefaultDisplay, "Abs Y", false);
        internal static readonly IntPtr AbsolutePressure = Functions.XInternAtom(API.DefaultDisplay, "Abs Pressure", false);
        internal static readonly IntPtr AbsoluteTiltX = Functions.XInternAtom(API.DefaultDisplay, "Abs Tilt X", false);
        internal static readonly IntPtr AbsoluteTiltY = Functions.XInternAtom(API.DefaultDisplay, "Abs Tilt Y", false);
        internal static readonly IntPtr AbsoluteWheel = Functions.XInternAtom(API.DefaultDisplay, "Abs Wheel", false);
        internal static readonly IntPtr AbsoluteDistance = Functions.XInternAtom(API.DefaultDisplay, "Abs Distance", false);

        [DllImport(lib, EntryPoint = "XISelectEvents")]
        static extern int SelectEvents(IntPtr dpy, Window win, [In] XIEventMask[] masks, int num_masks);
        
        [DllImport(lib, EntryPoint = "XISelectEvents")]
        static extern int SelectEvents(IntPtr dpy, Window win, [In] ref XIEventMask masks, int num_masks);

        public static int SelectEvents(IntPtr dpy, Window win, XIEventMask[] masks)
        {
            return SelectEvents(dpy, win, masks, masks.Length);
        }

        public static int SelectEvents(IntPtr dpy, Window win, XIEventMask mask)
        {
            return SelectEvents(dpy, win, ref mask, 1);
        }

        [DllImport(lib, EntryPoint = "XIGrabDevice")]
        static extern Status GrabDevice(IntPtr display, int deviceid, Window grab_window, Time time,
            Cursor cursor, int grab_mode, int paired_device_mode, Bool owner_events, XIEventMask[] mask);

        [DllImport(lib, EntryPoint = "XIUngrabDevice")]
        static extern Status UngrabDevice(IntPtr display, int deviceid, Time time);

        [DllImport(lib, EntryPoint = "XIWarpPointer")]
        public static extern Bool XIWarpPointer(Display display,
            int deviceid, Window src_w, Window dest_w,
            double src_x, double src_y, int src_width, int src_height,
            double dest_x, double dest_y);

        [DllImport(lib, EntryPoint = "XIQueryDevice")]
        public static extern IntPtr QueryDevice(Display display, int id, out int count);

        [DllImport(lib, EntryPoint = "XIFreeDeviceInfo")]
        public static extern void FreeDeviceInfo(IntPtr devices);

        [DllImport(lib, EntryPoint = "XIQueryPointer")]
        public static extern Bool QueryPointer(Display display,
            int deviceid, Window win,
            out Window root_return, out Window child_return,
            out double root_x_return, out double root_y_return,
            out double win_x_return, out double win_y_return,
            out XIButtonState buttons_return, out XIModifierState modifiers_return,
            out XIGroupState group_return);

        [DllImport(lib, EntryPoint = "XIQueryVersion")]
        internal static extern Status QueryVersion(Display display, ref int major, ref int minor);
    }

    enum XIDeviceType
    {
        MasterPointer = 1,
        MasterKeyboard = 2,
        SlavePointer = 3,
        SlaveKeyboard = 4,
        FloatingSlave = 5,
    }
}
