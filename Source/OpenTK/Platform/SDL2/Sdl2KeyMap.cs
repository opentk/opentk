#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2013 Stefanos Apostolopoulos for the Open Toolkit library.
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
using OpenTK.Input;

namespace OpenTK.Platform.SDL2
{
    using Code = Scancode;

    class Sdl2KeyMap
    {
        public static Key GetKey(Code code)
        {
            switch (code)
            {
                case Code.ESCAPE:
                    return Key.Escape;

                // Function keys
                case Code.F1:
                    return Key.F1;
                case Code.F2:
                    return Key.F2;
                case Code.F3:
                    return Key.F3;
                case Code.F4:
                    return Key.F4;
                case Code.F5:
                    return Key.F5;
                case Code.F6:
                    return Key.F6;
                case Code.F7:
                    return Key.F7;
                case Code.F8:
                    return Key.F8;
                case Code.F9:
                    return Key.F9;
                case Code.F10:
                    return Key.F10;
                case Code.F11:
                    return Key.F11;
                case Code.F12:
                    return Key.F12;
                case Code.F13:
                    return Key.F13;
                case Code.F14:
                    return Key.F14;
                case Code.F15:
                    return Key.F15;
                case Code.F16:
                    return Key.F16;
                case Code.F17:
                    return Key.F17;
                case Code.F18:
                    return Key.F18;
                case Code.F19:
                    return Key.F19;
                case Code.F20:
                    return Key.F20;
                case Code.F21:
                    return Key.F21;
                case Code.F22:
                    return Key.F22;
                case Code.F23:
                    return Key.F23;
                case Code.F24:
                    return Key.F24;

                // Number keys (0-9)
                case Code.Num0:
                    return Key.Number0;
                case Code.Num1:
                    return Key.Number1;
                case Code.Num2:
                    return Key.Number2;
                case Code.Num3:
                    return Key.Number3;
                case Code.Num4:
                    return Key.Number4;
                case Code.Num5:
                    return Key.Number5;
                case Code.Num6:
                    return Key.Number6;
                case Code.Num7:
                    return Key.Number7;
                case Code.Num8:
                    return Key.Number8;
                case Code.Num9:
                    return Key.Number9;

                // Letters (A-Z)
                case Code.A:
                    return Key.A;
                case Code.B:
                    return Key.B;
                case Code.C:
                    return Key.C;
                case Code.D:
                    return Key.D;
                case Code.E:
                    return Key.E;
                case Code.F:
                    return Key.F;
                case Code.G:
                    return Key.G;
                case Code.H:
                    return Key.H;
                case Code.I:
                    return Key.I;
                case Code.J:
                    return Key.J;
                case Code.K:
                    return Key.K;
                case Code.L:
                    return Key.L;
                case Code.M:
                    return Key.M;
                case Code.N:
                    return Key.N;
                case Code.O:
                    return Key.O;
                case Code.P:
                    return Key.P;
                case Code.Q:
                    return Key.Q;
                case Code.R:
                    return Key.R;
                case Code.S:
                    return Key.S;
                case Code.T:
                    return Key.T;
                case Code.U:
                    return Key.U;
                case Code.V:
                    return Key.V;
                case Code.W:
                    return Key.W;
                case Code.X:
                    return Key.X;
                case Code.Y:
                    return Key.Y;
                case Code.Z:
                    return Key.Z;

                case Code.TAB:
                    return Key.Tab;
                case Code.CAPSLOCK:
                    return Key.CapsLock;
                case Code.LCTRL:
                    return Key.ControlLeft;
                case Code.LSHIFT:
                    return Key.ShiftLeft;
                case Code.LALT:
                    return Key.AltLeft;
                case Code.MENU:
                    return Key.Menu;
                case Code.LGUI:
                    return Key.WinLeft;
                case Code.RGUI:
                    return Key.WinRight;
                case Code.SPACE:
                    return Key.Space;
                case Code.RALT:
                    return Key.AltRight;
                //case Code.:
                //    return Key.WinRight;
                case Code.APPLICATION:
                    return Key.Menu;
                case Code.RCTRL:
                    return Key.ControlRight;
                case Code.RSHIFT:
                    return Key.ShiftRight;
                case Code.RETURN:
                    return Key.Enter;
                case Code.BACKSPACE:
                    return Key.BackSpace;

                case Code.SEMICOLON:
                    return Key.Semicolon;      // Varies by keyboard: return ;: on Win2K/US
                case Code.SLASH:
                    return Key.Slash;          // Varies by keyboard: return /? on Win2K/US
                case Code.GRAVE:
                    return Key.Tilde;          // Varies by keyboard: return `~ on Win2K/US
                case Code.LEFTBRACKET:
                    return Key.BracketLeft;    // Varies by keyboard: return [{ on Win2K/US
                case Code.BACKSLASH:
                    return Key.BackSlash;      // Varies by keyboard: return \| on Win2K/US
                case Code.RIGHTBRACKET:
                    return Key.BracketRight;   // Varies by keyboard: return ]} on Win2K/US
                case Code.APOSTROPHE:
                    return Key.Quote;          // Varies by keyboard: return '" on Win2K/US
                case Code.EQUALS:
                    return Key.Plus;
                case Code.COMMA:
                    return Key.Comma;     // Invariant: : return
                case Code.MINUS:
                    return Key.Minus;     // Invariant: -
                case Code.PERIOD:
                    return Key.Period;    // Invariant: .

                case Code.HOME:
                    return Key.Home;
                case Code.END:
                    return Key.End;
                case Code.DELETE:
                    return Key.Delete;
                case Code.PAGEUP:
                    return Key.PageUp;
                case Code.PAGEDOWN:
                    return Key.PageDown;
                case Code.PAUSE:
                    return Key.Pause;
                case Code.NUMLOCKCLEAR:
                    return Key.NumLock;

                case Code.SCROLLLOCK:
                    return Key.ScrollLock;
                case Code.PRINTSCREEN:
                    return Key.PrintScreen;
                case Code.CLEAR:
                    return Key.Clear;
                case Code.INSERT:
                    return Key.Insert;

                case Code.SLEEP:
                    return Key.Sleep;

                // Keypad
                case Code.KP_0:
                    return Key.Keypad0;
                case Code.KP_1:
                    return Key.Keypad1;
                case Code.KP_2:
                    return Key.Keypad2;
                case Code.KP_3:
                    return Key.Keypad3;
                case Code.KP_4:
                    return Key.Keypad4;
                case Code.KP_5:
                    return Key.Keypad5;
                case Code.KP_6:
                    return Key.Keypad6;
                case Code.KP_7:
                    return Key.Keypad7;
                case Code.KP_8:
                    return Key.Keypad8;
                case Code.KP_9:
                    return Key.Keypad9;

                case Code.KP_DECIMAL:
                    return Key.KeypadDecimal;
                case Code.KP_PLUS:
                    return Key.KeypadAdd;
                case Code.KP_MINUS:
                    return Key.KeypadSubtract;
                case Code.KP_DIVIDE:
                    return Key.KeypadDivide;
                case Code.KP_MULTIPLY:
                    return Key.KeypadMultiply;

                // Navigation
                case Code.UP:
                    return Key.Up;
                case Code.DOWN:
                    return Key.Down;
                case Code.LEFT:
                    return Key.Left;
                case Code.RIGHT:
                    return Key.Right;

                default:
                    return Key.Unknown;
            }
        }

        public static KeyModifiers GetModifiers(Keymod mod)
        {
            KeyModifiers result = 0;
            result |= (mod & Keymod.ALT) != 0 ? KeyModifiers.Alt : 0;
            result |= (mod & Keymod.CTRL) != 0 ? KeyModifiers.Control : 0;
            result |= (mod & Keymod.SHIFT) != 0 ? KeyModifiers.Shift : 0;
            return result;
        }
    }
}

