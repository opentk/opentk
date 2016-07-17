#region License
//
// LibInput.cs
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

#pragma warning disable 0169, 0219

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace OpenTK.Platform.Linux
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    delegate int OpenRestrictedCallback(IntPtr path, int flags, IntPtr data);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    delegate void CloseRestrictedCallback(int fd, IntPtr data);

    class LibInput
    {
        internal const string lib = "libinput";

        [DllImport(lib, EntryPoint = "libinput_udev_create_for_seat", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr CreateContext(InputInterface @interface,
            IntPtr user_data, IntPtr udev, string seat_id);

        [DllImport(lib, EntryPoint = "libinput_destroy", CallingConvention = CallingConvention.Cdecl)]
        public static extern void DestroyContext(IntPtr libinput);

        [DllImport(lib, EntryPoint = "libinput_event_destroy", CallingConvention = CallingConvention.Cdecl)]
        public static extern void DestroyEvent(IntPtr @event);

        [DllImport(lib, EntryPoint = "libinput_device_get_sysname", CallingConvention = CallingConvention.Cdecl)]
        static extern IntPtr DeviceGetNameInternal(IntPtr device);
        public static string DeviceGetName(IntPtr device)
        {
            unsafe
            {
                return new string((sbyte*)DeviceGetNameInternal(device));
            }
        }

        [DllImport(lib, EntryPoint = "libinput_device_get_user_data", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr DeviceGetData(IntPtr device);

        [DllImport(lib, EntryPoint = "libinput_device_set_user_data", CallingConvention = CallingConvention.Cdecl)]
        public static extern void DeviceSetData(IntPtr device, IntPtr user_data);

        [DllImport(lib, EntryPoint = "libinput_device_get_output_name", CallingConvention = CallingConvention.Cdecl)]
        static extern IntPtr DeviceGetOutputNameInternal(IntPtr device);
        public static string DeviceGetOutputName(IntPtr device)
        {
            unsafe
            {
                sbyte* pname = (sbyte*)DeviceGetOutputNameInternal(device);
                return pname == null ? String.Empty : new string(pname);
            }
        }

        [DllImport(lib, EntryPoint = "libinput_device_get_seat", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr DeviceGetSeat(IntPtr device);

        [DllImport(lib, EntryPoint = "libinput_device_has_capability", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeviceHasCapability(IntPtr device, DeviceCapability capability);

        [DllImport(lib, EntryPoint = "libinput_dispatch", CallingConvention = CallingConvention.Cdecl)]
        public static extern int Dispatch(IntPtr libinput);

        [DllImport(lib, EntryPoint = "libinput_event_get_device", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr GetDevice(IntPtr @event);

        [DllImport(lib, EntryPoint = "libinput_get_event", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr GetEvent(IntPtr libinput);

        [DllImport(lib, EntryPoint = "libinput_event_get_keyboard_event", CallingConvention = CallingConvention.Cdecl)]
        public static extern KeyboardEvent GetKeyboardEvent(IntPtr @event);

        [DllImport(lib, EntryPoint = "libinput_event_get_pointer_event", CallingConvention = CallingConvention.Cdecl)]
        public static extern PointerEvent GetPointerEvent(IntPtr @event);

        [DllImport(lib, EntryPoint = "libinput_event_get_type", CallingConvention = CallingConvention.Cdecl)]
        public static extern InputEventType GetEventType(IntPtr @event);

        [DllImport(lib, EntryPoint = "libinput_get_fd", CallingConvention = CallingConvention.Cdecl)]
        public static extern int GetFD(IntPtr libinput);

        [DllImport(lib, EntryPoint = "libinput_next_event_type", CallingConvention = CallingConvention.Cdecl)]
        public static extern InputEventType NextEventType(IntPtr libinput);

        [DllImport(lib, EntryPoint = "libinput_resume", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Resume(IntPtr libinput);

        [DllImport(lib, EntryPoint = "libinput_suspend", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Suspend(IntPtr libinput);

        [DllImport(lib, EntryPoint = "libinput_seat_get_logical_name", CallingConvention = CallingConvention.Cdecl)]
        static extern public IntPtr SeatGetLogicalNameInternal(IntPtr seat);
        public static string SeatGetLogicalName(IntPtr seat)
        {
            unsafe
            {
                return new string((sbyte*)SeatGetLogicalNameInternal(seat));
            }
        }

        [DllImport(lib, EntryPoint = "libinput_seat_get_physical_name", CallingConvention = CallingConvention.Cdecl)]
        static extern public IntPtr SeatGetPhysicalNameInternal(IntPtr seat);
        public static string SeatGetPhysicalName(IntPtr seat)
        {
            unsafe
            {
                return new string((sbyte*)SeatGetPhysicalNameInternal(seat));
            }
        }
    }

    enum DeviceCapability
    {
        Keyboard = 0,
        Mouse,
        Touch
    }

    enum InputEventType
    {
        None = 0,

        DeviceAdded,
        DeviceRemoved,

        KeyboardKey = 300,

        PointerMotion = 400,
        PointerMotionAbsolute,
        PointerButton,
        PointerAxis,

        TouchDown = 500,
        TouchUP,
        TouchMotion,
        TouchCancel,

        /// \internal
        /// <summary>
        /// Signals the end of a set of touchpoints at one device sample
        /// time. This event has no coordinate information attached.
        /// </summary>
        TouchFrame
    }

    enum ButtonState
    {
        Released = 0,
        Pressed = 1
    }

    enum KeyState
    {
        Released = 0,
        Pressed = 1
    }

    enum PointerAxis
    {
        VerticalScroll = 0,
        HorizontalScroll = 1
    }

    struct Fixed24
    {
        internal readonly int Value;

        public static implicit operator double(Fixed24 n)
        {
            long l = ((1023L + 44L) << 52) + (1L << 51) + n.Value;
            unsafe
            {
                double d = *(double*)&l;
                return d - (3L << 43);
            }
        }

        public static implicit operator float(Fixed24 n)
        {
            return (float)(double)n;
        }

        public static explicit operator int(Fixed24 n)
        {
            return n.Value >> 8;
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    class InputInterface
    {
        internal readonly IntPtr open;
        internal readonly IntPtr close;

        public InputInterface(
            OpenRestrictedCallback open_restricted,
            CloseRestrictedCallback close_restricted)
        {
            if (open_restricted == null || close_restricted == null)
                throw new ArgumentNullException();

            open = Marshal.GetFunctionPointerForDelegate(open_restricted);
            close = Marshal.GetFunctionPointerForDelegate(close_restricted);
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    struct KeyboardEvent
    {
        IntPtr @event;

        public IntPtr BaseEvent { get { return GetBaseEvent(@event); } }
        public IntPtr Event { get { return @event; } }
        public uint Time { get { return GetTime(@event); } }
        public uint Key { get { return GetKey(@event); } }
        public uint KeyCount { get { return GetSeatKeyCount(@event); } }
        public KeyState KeyState { get { return GetKeyState(@event); } }

        [DllImport(LibInput.lib, EntryPoint = "libinput_event_keyboard_get_time", CallingConvention = CallingConvention.Cdecl)]
        static extern uint GetTime(IntPtr @event);

        [DllImport(LibInput.lib, EntryPoint = "libinput_event_keyboard_get_base_event", CallingConvention = CallingConvention.Cdecl)]
        static extern IntPtr GetBaseEvent(IntPtr @event);

        [DllImport(LibInput.lib, EntryPoint = "libinput_event_keyboard_get_seat_key_count", CallingConvention = CallingConvention.Cdecl)]
        static extern uint GetSeatKeyCount(IntPtr @event);

        [DllImport(LibInput.lib, EntryPoint = "libinput_event_keyboard_get_key", CallingConvention = CallingConvention.Cdecl)]
        static extern uint GetKey(IntPtr @event);

        [DllImport(LibInput.lib, EntryPoint = "libinput_event_keyboard_get_key_state", CallingConvention = CallingConvention.Cdecl)]
        static extern KeyState GetKeyState(IntPtr @event);
    }


    [StructLayout(LayoutKind.Sequential)]
    struct PointerEvent
    {
        IntPtr @event;

        public IntPtr BaseEvent { get { return GetBaseEvent(@event); } }
        public IntPtr Event { get { return @event; } }
        public uint Time { get { return GetTime(@event); } }
        public EvdevButton Button { get { return (EvdevButton)GetButton(@event); } }
        public uint ButtonCount { get { return GetButtonCount(@event); } }
        public ButtonState ButtonState { get { return GetButtonState(@event); } }
        public PointerAxis Axis { get { return GetAxis(@event); } }
        public Fixed24 AxisValue { get { return GetAxisValue(@event); } }
        public Fixed24 DeltaX { get { return GetDX(@event); } }
        public Fixed24 DeltaY { get { return GetDY(@event); } }
        public Fixed24 X { get { return GetAbsX(@event); } }
        public Fixed24 Y { get { return GetAbsY(@event); } }
        public Fixed24 TransformedX(int width) { return GetAbsXTransformed(@event, width); }
        public Fixed24 TransformedY(int height) { return GetAbsYTransformed(@event, height); }

        [DllImport(LibInput.lib, EntryPoint = "libinput_event_pointer_get_time", CallingConvention = CallingConvention.Cdecl)]
        static extern uint GetTime(IntPtr @event);

        [DllImport(LibInput.lib, EntryPoint = "libinput_event_pointer_get_base_event", CallingConvention = CallingConvention.Cdecl)]
        static extern IntPtr GetBaseEvent(IntPtr @event);

        [DllImport(LibInput.lib, EntryPoint = "libinput_event_pointer_get_seat_key_count", CallingConvention = CallingConvention.Cdecl)]
        static extern uint GetSeatKeyCount(IntPtr @event);

        [DllImport(LibInput.lib, EntryPoint = "libinput_event_pointer_get_button", CallingConvention = CallingConvention.Cdecl)]
        static extern uint GetButton(IntPtr @event);

        [DllImport(LibInput.lib, EntryPoint = "libinput_event_pointer_get_seat_button_count", CallingConvention = CallingConvention.Cdecl)]
        static extern uint GetButtonCount(IntPtr @event);

        [DllImport(LibInput.lib, EntryPoint = "libinput_event_pointer_get_button_state", CallingConvention = CallingConvention.Cdecl)]
        static extern ButtonState GetButtonState(IntPtr @event);

        [DllImport(LibInput.lib, EntryPoint = "libinput_event_pointer_get_axis", CallingConvention = CallingConvention.Cdecl)]
        static extern PointerAxis GetAxis(IntPtr @event);

        [DllImport(LibInput.lib, EntryPoint = "libinput_event_pointer_get_axis_value", CallingConvention = CallingConvention.Cdecl)]
        static extern Fixed24 GetAxisValue(IntPtr @event);

        [DllImport(LibInput.lib, EntryPoint = "libinput_event_pointer_get_dx", CallingConvention = CallingConvention.Cdecl)]
        static extern Fixed24 GetDX(IntPtr @event);

        [DllImport(LibInput.lib, EntryPoint = "libinput_event_pointer_get_dy", CallingConvention = CallingConvention.Cdecl)]
        static extern Fixed24 GetDY(IntPtr @event);

        [DllImport(LibInput.lib, EntryPoint = "libinput_event_pointer_get_absolute_x", CallingConvention = CallingConvention.Cdecl)]
        static extern Fixed24 GetAbsX(IntPtr @event);

        [DllImport(LibInput.lib, EntryPoint = "libinput_event_pointer_get_absolute_y", CallingConvention = CallingConvention.Cdecl)]
        static extern Fixed24 GetAbsY(IntPtr @event);

        [DllImport(LibInput.lib, EntryPoint = "libinput_event_pointer_get_absolute_x_transformed", CallingConvention = CallingConvention.Cdecl)]
        static extern Fixed24 GetAbsXTransformed(IntPtr @event, int width);

        [DllImport(LibInput.lib, EntryPoint = "libinput_event_pointer_get_absolute_y_transformed", CallingConvention = CallingConvention.Cdecl)]
        static extern Fixed24 GetAbsYTransformed(IntPtr @event, int height);
    }
}

