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
using OpenTK.Input;

namespace OpenTK.Platform.Linux
{
    // Bindings for linux/input.h
    class Evdev
    {
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
    }

    enum EvdevButton : uint
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
    }
}

