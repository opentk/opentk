#region License
//
// Evdev.cs
//
// Author:
//       Stefanos A. <stapostol@gmail.com>
//
// Copyright (c) 2006-2014 
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
using System.Diagnostics;
using System.Runtime.InteropServices;
using OpenTK.Input;

namespace OpenTK.Platform.Linux
{
    // Bindings for linux/input.h
    class Evdev
    {
        public const int KeyCount = 0x300;
        public const int AxisCount = 0x40;
        public const int EventCount = (int)EvdevType.CNT;

        #region KeyMap

        public static readonly Key[] KeyMap = new Key[]
        {
            // 0-7
            Key.Unknown,
            Key.Escape,
            Key.Number1,
            Key.Number2,
            Key.Number3,
            Key.Number4,
            Key.Number5,
            Key.Number6,
            // 8-15
            Key.Number7,
            Key.Number8,
            Key.Number9,
            Key.Number0,
            Key.Minus,
            Key.Plus,
            Key.BackSpace,
            Key.Tab,
            // 16-23
            Key.Q,
            Key.W,
            Key.E,
            Key.R,
            Key.T,
            Key.Y,
            Key.U,
            Key.I,
            // 24-31
            Key.O,
            Key.P,
            Key.BracketLeft,
            Key.BracketRight,
            Key.Enter,
            Key.ControlLeft,
            Key.A,
            Key.S,
            // 32-39
            Key.D,
            Key.F,
            Key.G,
            Key.H,
            Key.J,
            Key.K,
            Key.L,
            Key.Semicolon,
            // 40-47
            Key.Quote,
            Key.Tilde,
            Key.ShiftLeft,
            Key.BackSlash, //Key.Execute,
            Key.Z,
            Key.X,
            Key.C,
            Key.V, //Key.Help,
            // 48-55
            Key.B,
            Key.N,
            Key.M,
            Key.Comma,
            Key.Period,
            Key.Slash,
            Key.ShiftRight,
            Key.KeypadMultiply,
            // 56-63
            Key.AltLeft,
            Key.Space,
            Key.CapsLock,
            Key.F1,
            Key.F2,
            Key.F3,
            Key.F4,
            Key.F5,
            // 64-71
            Key.F6,
            Key.F7,
            Key.F8,
            Key.F9,
            Key.F10,
            Key.NumLock,
            Key.ScrollLock,
            Key.Keypad7,
            // 72-79
            Key.Keypad8,
            Key.Keypad9,
            Key.KeypadSubtract,
            Key.Keypad4,
            Key.Keypad5,
            Key.Keypad6,
            Key.KeypadPlus,
            Key.Keypad1,
            // 80-87
            Key.Keypad2,
            Key.Keypad3,
            Key.Keypad0,
            Key.KeypadPeriod,
            Key.Unknown,
            Key.Unknown, // zenkakuhankaku
            Key.Unknown, // 102ND
            Key.F11,
            // 88-95
            Key.F12,
            Key.Unknown, // ro
            Key.Unknown, // katakana
            Key.Unknown, // hiragana
            Key.Unknown, // henkan
            Key.Unknown, // katakanahiragana
            Key.Unknown, // muhenkan
            Key.Unknown, // kpjpcomma
            // 96-103
            Key.KeypadEnter,
            Key.ControlRight,
            Key.KeypadDivide,
            Key.Unknown, // sysrq
            Key.AltRight,
            Key.Unknown, // linefeed
            Key.Home,
            Key.Up,
            // 104-111
            Key.PageUp,
            Key.Left,
            Key.Right,
            Key.End,
            Key.Down,
            Key.PageDown,
            Key.Insert,
            Key.Delete,
            // 112-119
            Key.Unknown, // macro
            Key.Unknown, // mute
            Key.Unknown, // volumedown
            Key.Unknown, // volumeup
            Key.Unknown, // power
            Key.Unknown, // kpequal
            Key.Unknown, // kpplusminus
            Key.Pause,
            // 120-127
            Key.Unknown, // scale
            Key.Unknown, // kpcomma
            Key.Unknown, // hangeul / hanguel
            Key.Unknown, // hanja
            Key.Unknown, // yen
            Key.WinLeft,
            Key.WinRight,
            Key.Unknown, // compose
            // 128-135
            Key.Unknown, // stop
            Key.Unknown, // again
            Key.Unknown, // props
            Key.Unknown, // undo
            Key.Unknown, // front
            Key.Unknown, // copy
            Key.Unknown, // open
            Key.Unknown, // paste
            // 136-143
            Key.Unknown, // find
            Key.Unknown, // cut
            Key.Unknown, // help
            Key.Unknown, // menu
            Key.Unknown, // calc
            Key.Unknown, // setup
            Key.Unknown, // sleep
            Key.Unknown, // wakeup
            // 144-151
            Key.Unknown, // file
            Key.Unknown, // send file
            Key.Unknown, // delete file
            Key.Unknown, // xfer
            Key.Unknown, // prog1
            Key.Unknown, // prog2
            Key.Unknown, // www
            Key.Unknown, // msdos
            // 152-159
            Key.Unknown, // coffee / screenlock
            Key.Unknown, // direction
            Key.Unknown, // cycle windows
            Key.Unknown, // mail
            Key.Unknown, // bookmarks
            Key.Unknown, // computer
            Key.Back,
            Key.Unknown, // forward
            // 160-167
            Key.Unknown, // close cd
            Key.Unknown, // eject cd
            Key.Unknown, // eject/close cd
            Key.Unknown, // next song
            Key.Unknown, // play/pause
            Key.Unknown, // previous song
            Key.Unknown, // stop cd
            Key.Unknown, // record
            // 168-175
            Key.Unknown, // rewind
            Key.Unknown, // phone
            Key.Unknown, // iso
            Key.Unknown, // config
            Key.Unknown, // homepage
            Key.Unknown, // refresh
            Key.Unknown, // exit
            Key.Unknown, // move,
            // 176-183
            Key.Unknown, // edit,
            Key.Unknown, // scroll up,
            Key.Unknown, // scroll down,
            Key.Unknown, // kp left paren,
            Key.Unknown, // kp right paren,
            Key.Unknown, // new,
            Key.Unknown, // redo,
            Key.F13,
            // 184-191
            Key.F14,
            Key.F15,
            Key.F16,
            Key.F17,
            Key.F18,
            Key.F19,
            Key.F20,
            Key.F21,
            // 192-199
            Key.F22,
            Key.F23,
            Key.F24,
            Key.Unknown,
            Key.Unknown,
            Key.Unknown,
            Key.Unknown,
            Key.Unknown,
            // 200-207
            Key.Unknown, // play cd
            Key.Unknown, // pause cd
            Key.Unknown, // prog3
            Key.Unknown, // prog4
            Key.Unknown, // dashboard
            Key.Unknown, // suspend
            Key.Unknown, // close
            Key.Unknown, // play
            // 208-215
            Key.Unknown, // fast forward
            Key.Unknown, // bass boost
            Key.Unknown, // print
            Key.Unknown, // hp
            Key.Unknown, // camera
            Key.Unknown, // sound
            Key.Unknown, // question
            Key.Unknown, // email
            // 216-223
            Key.Unknown, // chat
            Key.Unknown, // search
            Key.Unknown, // connect
            Key.Unknown, // finance
            Key.Unknown, // sport
            Key.Unknown, // shop
            Key.Unknown, // alt erase
            Key.Unknown, // cancel
            // 224-231
            Key.Unknown, // brightness down
            Key.Unknown, // brightness up
            Key.Unknown, // media
            Key.Unknown, // switch video mode
            Key.Unknown, // dillum toggle
            Key.Unknown, // dillum down
            Key.Unknown, // dillum up
            Key.Unknown, // send
            // 232-239
            Key.Unknown, // reply
            Key.Unknown, // forward email
            Key.Unknown, // save
            Key.Unknown, // documents
            Key.Unknown, // battery
            Key.Unknown, // bluetooth
            Key.Unknown, // wlan
            Key.Unknown, // uwb
            // 240-247
            Key.Unknown,
            Key.Unknown, // video next
            Key.Unknown, // video prev
            Key.Unknown, // brightness cycle
            Key.Unknown, // brightness zero
            Key.Unknown, // display off
            Key.Unknown, // wwan / wimax
            Key.Unknown, // rfkill
            // 248-255
            Key.Unknown, // mic mute
            Key.Unknown,
            Key.Unknown,
            Key.Unknown,
            Key.Unknown,
            Key.Unknown,
            Key.Unknown,
            Key.Unknown, // reserved
        };

        #endregion

        public static MouseButton GetMouseButton(EvdevButton button)
        {
            switch (button)
            {
                case EvdevButton.LEFT:
                    return MouseButton.Left;
                case EvdevButton.RIGHT:
                    return MouseButton.Right;
                case EvdevButton.MIDDLE:
                    return MouseButton.Middle;
                case EvdevButton.BTN0:
                    return MouseButton.Button1;
                case EvdevButton.BTN1:
                    return MouseButton.Button2;
                case EvdevButton.BTN2:
                    return MouseButton.Button3;
                case EvdevButton.BTN3:
                    return MouseButton.Button4;
                case EvdevButton.BTN4:
                    return MouseButton.Button5;
                case EvdevButton.BTN5:
                    return MouseButton.Button6;
                case EvdevButton.BTN6:
                    return MouseButton.Button7;
                case EvdevButton.BTN7:
                    return MouseButton.Button8;
                case EvdevButton.BTN8:
                    return MouseButton.Button9;
                default:
                    Debug.Print("[Input] Unknown EvdevButton {0}", button);
                    return MouseButton.Left;
            }
        }

        static uint IOCreate(DirectionFlags dir, int number, int length)
        {
            long v =
                ((byte)dir << 30) |
                ((byte)'E' << 8) |
                (number << 0) |
                (length << 16);
            return (uint)v;
        }

        // Get absolute value / limits
        public static int GetAbs(int fd, EvdevAxis axis, out InputAbsInfo info)
        {
            info = default(InputAbsInfo);
            unsafe
            {
                fixed (InputAbsInfo* pinfo = &info)
                {
                    // EVIOCGABS(abs) = _IOR('E', 0x40 + (abs), struct input_absinfo)
                    uint ioctl = IOCreate(DirectionFlags.Read, (int)axis + 0x40, BlittableValueType<InputAbsInfo>.Stride);
                    int retval = Libc.ioctl(fd, ioctl, new IntPtr(pinfo));
                    return retval;
                }
            }
        }

        // Get supported event bits
        public static int GetBit(int fd, EvdevType ev, int length, IntPtr data)
        {
            // EVIOCGBIT = _IOC(_IOC_READ, 'E', 0x20 + (ev), len)
            uint ioctl = IOCreate(DirectionFlags.Read, (int)ev + 0x20, length);
            int retval = Libc.ioctl(fd, ioctl, data);
            return retval;
        }

        public static int GetName(int fd, out string name)
        {
            unsafe
            {
                sbyte* pname = stackalloc sbyte[129];
                int ret = Libc.ioctl(fd, EvdevIoctl.Name128, new IntPtr(pname));
#if !_NET_CORECLR
                name = new string(pname);
#else
                name = UTF8String.String((IntPtr) pname);
#endif
                return ret;
            }
        }

        public static int GetId(int fd, out EvdevInputId id)
        {
            id = default(EvdevInputId);
            unsafe
            {
                fixed (EvdevInputId* pid = &id)
                {
                    return Libc.ioctl(fd, EvdevIoctl.Id, new IntPtr(pid));
                }
            }
        }
    }

    enum EvdevAxis
    {
        X           = 0x00,
        Y           = 0x01,
        Z           = 0x02,
        RX          = 0x03,
        RY          = 0x04,
        RZ          = 0x05,
        THROTTLE    = 0x06,
        RUDDER      = 0x07,
        WHEEL       = 0x08,
        GAS         = 0x09,
        BRAKE       = 0x0a,
        HAT0X       = 0x10,
        HAT0Y       = 0x11,
        HAT1X       = 0x12,
        HAT1Y       = 0x13,
        HAT2X       = 0x14,
        HAT2Y       = 0x15,
        HAT3X       = 0x16,
        HAT3Y       = 0x17,
        PRESSURE    = 0x18,
        DISTANCE    = 0x19,
        TILT_X      = 0x1a,
        TILT_Y      = 0x1b,
        TOOL_WIDTH  = 0x1c,

        VOLUME      = 0x20,

        MISC        = 0x28,

        MT_SLOT     = 0x2f,    /* MT slot being modified */
        MT_TOUCH_MAJOR  = 0x30,    /* Major axis of touching ellipse */
        MT_TOUCH_MINOR  = 0x31,    /* Minor axis (omit if circular) */
        MT_WIDTH_MAJOR  = 0x32,    /* Major axis of approaching ellipse */
        MT_WIDTH_MINOR  = 0x33,    /* Minor axis (omit if circular) */
        MT_ORIENTATION  = 0x34,    /* Ellipse orientation */
        MT_POSITION_X   = 0x35,    /* Center X touch position */
        MT_POSITION_Y   = 0x36,    /* Center Y touch position */
        MT_TOOL_TYPE    = 0x37,    /* Type of touching device */
        MT_BLOB_ID      = 0x38,    /* Group a set of packets as a blob */
        MT_TRACKING_ID  = 0x39,    /* Unique ID of initiated contact */
        MT_PRESSURE     = 0x3a,    /* Pressure on contact area */
        MT_DISTANCE     = 0x3b,    /* Contact hover distance */
        MT_TOOL_X       = 0x3c,    /* Center X tool position */
        MT_TOOL_Y       = 0x3d,    /* Center Y tool position */

        MAX         = 0x3f,
        CNT         = (MAX+1),
    }

    enum EvdevButton
    {
        MISC        = 0x100,
        BTN0        = 0x100,
        BTN1        = 0x101,
        BTN2        = 0x102,
        BTN3        = 0x103,
        BTN4        = 0x104,
        BTN5        = 0x105,
        BTN6        = 0x106,
        BTN7        = 0x107,
        BTN8        = 0x108,
        BTN9        = 0x109,

        MOUSE       = 0x110,
        LEFT        = 0x110,
        RIGHT       = 0x111,
        MIDDLE      = 0x112,
        SIDE        = 0x113,
        EXTRA       = 0x114,
        FORWARD     = 0x115,
        BACK        = 0x116,
        TASK        = 0x117,

        JOYSTICK    = 0x120,
        TRIGGER     = 0x120,
        THUMB       = 0x121,
        THUMB2      = 0x122,
        TOP         = 0x123,
        TOP2        = 0x124,
        PINKIE      = 0x125,
        BASE        = 0x126,
        BASE2       = 0x127,
        BASE3       = 0x128,
        BASE4       = 0x129,
        BASE5       = 0x12a,
        BASE6       = 0x12b,
        DEAD        = 0x12f,

        GAMEPAD     = 0x130,
        SOUTH       = 0x130,
        A           = SOUTH,
        EAST        = 0x131,
        B           = EAST,
        C           = 0x132,
        NORTH       = 0x133,
        X           = NORTH,
        WEST        = 0x134,
        Y           = WEST,
        Z           = 0x135,
        TL          = 0x136,
        TR          = 0x137,
        TL2         = 0x138,
        TR2         = 0x139,
        SELECT      = 0x13a,
        START       = 0x13b,
        MODE        = 0x13c,
        THUMBL      = 0x13d,
        THUMBR      = 0x13e,

        DIGI        = 0x140,
        TOOL_PEN        = 0x140,
        TOOL_RUBBER     = 0x141,
        TOOL_BRUSH      = 0x142,
        TOOL_PENCIL     = 0x143,
        TOOL_AIRBRUSH   = 0x144,
        TOOL_FINGER     = 0x145,
        TOOL_MOUSE      = 0x146,
        TOOL_LENS       = 0x147,
        TOOL_QUINTTAP   = 0x148, // Five fingers on trackpad
        TOUCH           = 0x14a,
        STYLUS          = 0x14b,
        STYLUS2     = 0x14c,
        TOOL_DOUBLETAP  = 0x14d,
        TOOL_TRIPLETAP  = 0x14e,
        TOOL_QUADTAP    = 0x14f, // Four fingers on trackpad

        WHEEL       = 0x150,
        GEAR_DOWN   = 0x150,
        GEAR_UP     = 0x151,

        DPAD_UP     = 0x220,
        DPAD_DOWN   = 0x221,
        DPAD_LEFT   = 0x222,
        DPAD_RIGHT  = 0x223,

        Last = 0x300,
    }

    enum EvdevType : byte
    {
        SYN = 0x00,
        KEY = 0x01,
        REL = 0x02,
        ABS = 0x03,
        MSC = 0x04,
        SW =  0x05,
        LED = 0x11,
        SND = 0x12,
        REP = 0x14,
        FF =  0x15,
        PWR = 0x16,
        FF_STATUS = 0x17,
        MAX = 0x1f,
        CNT = (MAX+1),
    }

    enum EvdevIoctl : uint
    {
        Id = (2u << 30) | ((byte)'E' << 8) | (0x02u << 0) | (8u << 16), //EVIOCGID = _IOR('E', 0x02, struct input_id)
        Name128 = (2u << 30) | ((byte)'E' << 8) | (0x06u << 0) | (128u << 16), //EVIOCGNAME(len) = _IOC(_IOC_READ, 'E', 0x06, len)
    }

    [StructLayout(LayoutKind.Sequential)]
    struct InputAbsInfo
    {
        public int Value;
        public int Minimum;
        public int Maximum;
        public int Fuzz;
        public int Flat;
        public int Resolution;
    };

    [StructLayout(LayoutKind.Sequential)]
    struct InputId
    {
        public ushort BusType;
        public ushort Vendor;
        public ushort Product;
        public ushort Version;
    }

    [StructLayout(LayoutKind.Sequential)]
    struct InputEvent
    {
        public TimeVal Time;
        ushort type;
        public ushort Code;
        public int Value;

        public EvdevType Type { get { return (EvdevType)type; } }
    }

    [StructLayout(LayoutKind.Sequential)]
    struct TimeVal
    {
        public IntPtr Seconds;
        public IntPtr MicroSeconds;
    }
}

