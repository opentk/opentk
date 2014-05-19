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
using OpenTK.Input;

namespace OpenTK.Platform.Windows
{
    static class WinKeyMap
    {
        public static Key GetKey(int code)
        {
            switch (code)
            {
                // 0 - 15
                case 0: return Key.Unknown;
                case 1: return Key.Escape;
                case 2: return Key.Number1;
                case 3: return Key.Number2;
                case 4: return Key.Number3;
                case 5: return Key.Number4;
                case 6: return Key.Number5;
                case 7: return Key.Number6;
                case 8: return Key.Number7;
                case 9: return Key.Number8;
                case 10: return Key.Number9;
                case 11: return Key.Number0;
                case 12: return Key.Minus;
                case 13: return Key.Plus;
                case 14: return Key.BackSpace;
                case 15: return Key.Tab;

                // 16-31
                case 16: return Key.Q;
                case 17: return Key.W;
                case 18: return Key.E;
                case 19: return Key.R;
                case 20: return Key.T;
                case 21: return Key.Y;
                case 22: return Key.U;
                case 23: return Key.I;
                case 24: return Key.O;
                case 25: return Key.P;
                case 26: return Key.BracketLeft;
                case 27: return Key.BracketRight;
                case 28: return Key.Enter;
                case 29: return Key.ControlLeft;
                case 30: return Key.A;
                case 31: return Key.S;

                // 32 - 47
                case 32: return Key.D;
                case 33: return Key.F;
                case 34: return Key.G;
                case 35: return Key.H;
                case 36: return Key.J;
                case 37: return Key.K;
                case 38: return Key.L;
                case 39: return Key.Semicolon;
                case 40: return Key.Quote;
                case 41: return Key.Grave;
                case 42: return Key.ShiftLeft;
                case 43: return Key.BackSlash;
                case 44: return Key.Z;
                case 45: return Key.X;
                case 46: return Key.C;
                case 47: return Key.V;

                // 48 - 63
                case 48: return Key.B;
                case 49: return Key.N;
                case 50: return Key.M;
                case 51: return Key.Comma;
                case 52: return Key.Period;
                case 53: return Key.Slash;
                case 54: return Key.ShiftRight;
                case 55: return Key.PrintScreen;
                case 56: return Key.AltLeft;
                case 57: return Key.Space;
                case 58: return Key.CapsLock;
                case 59: return Key.F1;
                case 60: return Key.F2;
                case 61: return Key.F3;
                case 62: return Key.F4;
                case 63: return Key.F5;

                // 64 - 79
                case 64: return Key.F6;
                case 65: return Key.F7;
                case 66: return Key.F8;
                case 67: return Key.F9;
                case 68: return Key.F10;
                case 69: return Key.NumLock;
                case 70: return Key.ScrollLock;
                case 71: return Key.Home;
                case 72: return Key.Up;
                case 73: return Key.PageUp;
                case 74: return Key.KeypadMinus;
                case 75: return Key.Left;
                case 76: return Key.Keypad5;
                case 77: return Key.Right;
                case 78: return Key.KeypadPlus;
                case 79: return Key.End;

                // 80 - 95
                case 80: return Key.Down;
                case 81: return Key.PageDown;
                case 82: return Key.Insert;
                case 83: return Key.Delete;
                case 84: return Key.Unknown;
                case 85: return Key.Unknown;
                case 86: return Key.NonUSBackSlash;
                case 87: return Key.F11;
                case 88: return Key.F12;
                case 89: return Key.Pause;
                case 90: return Key.Unknown;
                case 91: return Key.WinLeft;
                case 92: return Key.WinRight;
                case 93: return Key.Menu;
                case 94: return Key.Unknown;
                case 95: return Key.Unknown;

                // 96 - 106
                case 96: return Key.Unknown;
                case 97: return Key.Unknown;
                case 98: return Key.Unknown;
                case 99: return Key.Unknown;
                case 100: return Key.F13;
                case 101: return Key.F14;
                case 102: return Key.F15;
                case 103: return Key.F16;
                case 104: return Key.F17;
                case 105: return Key.F18;
                case 106: return Key.F19;

                default: return Key.Unknown;
            }
        }

        public static Key TranslateKey(short scancode, VirtualKeys vkey, bool extended0, bool extended1, out bool is_valid)
        {
            is_valid = true;

            Key key = GetKey(scancode);

            if (!extended0)
            {
                switch (key)
                {
                    case Key.Insert: key = Key.Keypad0; break;
                    case Key.End: key = Key.Keypad1; break;
                    case Key.Down: key = Key.Keypad2; break;
                    case Key.PageDown: key = Key.Keypad3; break;
                    case Key.Left: key = Key.Keypad4; break;
                    case Key.Right: key = Key.Keypad6; break;
                    case Key.Home: key = Key.Keypad7; break;
                    case Key.Up: key = Key.Keypad8; break;
                    case Key.PageUp: key = Key.Keypad9; break;
                    case Key.PrintScreen: key = Key.KeypadMultiply; break;
                    case Key.Delete: key = Key.KeypadDecimal; break;
                    case Key.NumLock:
                        if (vkey == VirtualKeys.Last)
                            is_valid = false;
                        else if (vkey == VirtualKeys.PAUSE)
                            key = Key.Pause;
                        break;
                }
            }
            else
            {
                switch (key)
                {
                    case Key.Enter: key = Key.KeypadEnter; break;
                    case Key.AltLeft: key = Key.AltRight; break;
                    case Key.AltRight: key = Key.AltLeft; break;
                    case Key.ControlLeft: key = Key.ControlRight; break;
                    case Key.ControlRight: key = Key.ControlLeft; break;
                    case Key.ShiftLeft: is_valid = false; break;
                }
            }

            if (extended1)
            {
                switch (key)
                {
                    case Key.ControlLeft: key = Key.Pause; break;
                }
            }

            return key;
        }
    }
}
