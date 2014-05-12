#region License
//
// EventServices.cs
//
// Author:
//       Stefanos A. <stapostol@gmail.com>
//
// Copyright (c) 2006-2014 Stefanos Apostolopoulos
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
using System.Runtime.InteropServices;

namespace OpenTK.Platform.MacOS
{
    using CGEventTapProxy = IntPtr;
    using CGEventRef = IntPtr;
    using CFMachPortRef = IntPtr;

    partial class CG
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate CGEventRef EventTapCallBack(
            CGEventTapProxy proxy,
            CGEventType type,
            CGEventRef @event,
            IntPtr refcon);

        [DllImport(lib, EntryPoint = "CGEventTapCreate")]
        public static extern CFMachPortRef EventTapCreate(
            CGEventTapLocation tap,
            CGEventTapPlacement place,
            CGEventTapOptions options,
            CGEventMask eventsOfInterest,
            [MarshalAs(UnmanagedType.FunctionPtr)]
            EventTapCallBack callback,
            IntPtr refcon);

        [DllImport(lib, EntryPoint = "CGEventGetDoubleValueField")]
        internal static extern double EventGetDoubleValueField(
            CGEventRef @event,
            CGEventField field);

        [DllImport(lib, EntryPoint = "CGEventGetIntegerValueField")]
        internal static extern int EventGetIntegerValueField(
            CGEventRef @event,
            CGEventField field);

        [DllImport(lib, EntryPoint = "CGEventGetLocation")]
        internal static extern Carbon.HIPoint EventGetLocation(CGEventRef @event);
    }

    enum CGEventTapLocation
    {
        HIDEventTap = 0,
        SessionEventTap,
        AnnotatedSessionEventTap
    }

    enum CGEventTapPlacement
    {
        HeadInsert = 0,
        TailAppend
    }

    enum CGEventTapOptions
    {
        Default = 0x00000000,
        ListenOnly = 0x00000001
    }

    [Flags]
    enum CGEventMask : long
    {
        LeftMouseDown       = 1 << CGEventType.LeftMouseDown,
        LeftMouseUp         = 1 << CGEventType.LeftMouseUp,
        RightMouseDown      = 1 << CGEventType.RightMouseDown,
        RightMouseUp        = 1 << CGEventType.RightMouseUp,
        MouseMoved          = 1 << CGEventType.MouseMoved,
        LeftMouseDragged    = 1 << CGEventType.LeftMouseDown,
        RightMouseDragged   = 1 << CGEventType.RightMouseDown,
        KeyDown             = 1 << CGEventType.KeyDown,
        KeyUp               = 1 << CGEventType.KeyUp,
        FlagsChanged        = 1 << CGEventType.FlagsChanged,
        ScrollWheel         = 1 << CGEventType.ScrollWheel,
        TabletPointer       = 1 << CGEventType.TabletPointer,
        TabletProximity     = 1 << CGEventType.TabletProximity,
        OtherMouseDown      = 1 << CGEventType.OtherMouseDown,
        OtherMouseUp        = 1 << CGEventType.OtherMouseUp,
        OtherMouseDragged   = 1 << CGEventType.OtherMouseDragged,
        All = -1,
        AllMouse =
            LeftMouseDown | LeftMouseUp | LeftMouseDragged |
            RightMouseDown | RightMouseUp | RightMouseDragged |
            OtherMouseDown | OtherMouseUp | OtherMouseDragged |
            ScrollWheel | MouseMoved
    }

    enum CGEventType
    {
        Null                = 0,
        LeftMouseDown       = 1,
        LeftMouseUp         = 2,
        RightMouseDown      = 3,
        RightMouseUp        = 4,
        MouseMoved          = 5,
        LeftMouseDragged    = 6,
        RightMouseDragged   = 7,
        KeyDown             = 10,
        KeyUp               = 11,
        FlagsChanged        = 12,
        ScrollWheel         = 22,
        TabletPointer       = 23,
        TabletProximity     = 24,
        OtherMouseDown      = 25,
        OtherMouseUp        = 26,
        OtherMouseDragged   = 27,
        TapDisabledByTimeout = -2,
        TapDisabledByUserInput = -1
    }

    enum CGEventField
    {
        MouseEventNumber = 0,
        MouseEventClickState = 1,
        MouseEventPressure = 2,
        MouseEventButtonNumber = 3,
        MouseEventDeltaX = 4,
        MouseEventDeltaY = 5,
        MouseEventInstantMouser = 6,
        MouseEventSubtype = 7,
        KeyboardEventAutorepeat = 8,
        KeyboardEventKeycode = 9,
        KeyboardEventKeyboardType = 10,
        ScrollWheelEventDeltaAxis1 = 11,
        ScrollWheelEventDeltaAxis2 = 12,
        ScrollWheelEventDeltaAxis3 = 13,
        ScrollWheelEventFixedPtDeltaAxis1 = 93,
        ScrollWheelEventFixedPtDeltaAxis2 = 94,
        ScrollWheelEventFixedPtDeltaAxis3 = 95,
        ScrollWheelEventPointDeltaAxis1 = 96,
        ScrollWheelEventPointDeltaAxis2 = 97,
        ScrollWheelEventPointDeltaAxis3 = 98,
        ScrollWheelEventInstantMouser = 14,
        TabletEventPointX = 15,
        TabletEventPointY = 16,
        TabletEventPointZ = 17,
        TabletEventPointButtons = 18,
        TabletEventPointPressure = 19,
        TabletEventTiltX = 20,
        TabletEventTiltY = 21,
        TabletEventRotation = 22,
        TabletEventTangentialPressure = 23,
        TabletEventDeviceID = 24,
        TabletEventVendor1 = 25,
        TabletEventVendor2 = 26,
        TabletEventVendor3 = 27,
        TabletProximityEventVendorID = 28,
        TabletProximityEventTabletID = 29,
        TabletProximityEventPointerID = 30,
        TabletProximityEventDeviceID = 31,
        TabletProximityEventSystemTabletID = 32,
        TabletProximityEventVendorPointerType = 33,
        TabletProximityEventVendorPointerSerialNumber = 34,
        TabletProximityEventVendorUniqueID = 35,
        TabletProximityEventCapabilityMask = 36,
        TabletProximityEventPointerType = 37,
        TabletProximityEventEnterProximity = 38,
        EventTargetProcessSerialNumber = 39,
        EventTargetUnixProcessID = 40,
        EventSourceUnixProcessID = 41,
        EventSourceUserData = 42,
        EventSourceUserID = 43,
        EventSourceGroupID = 44,
        EventSourceStateID = 45,
        ScrollWheelEventIsContinuous = 88
    }
}

