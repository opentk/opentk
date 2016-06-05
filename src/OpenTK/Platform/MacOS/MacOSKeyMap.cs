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

//  Created by Erik Ylvisaker on 3/17/08.

using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Platform.MacOS
{
    using Carbon;
    using Input;

    static class MacOSKeyMap
    {
        public static Key GetKey(MacOSKeyCode code)
        {
            // comments indicate members of the Key enum that are missing
            switch (code)
            {
                case MacOSKeyCode.A:
                    return Key.A;
                case MacOSKeyCode.OptionAlt:
                    return Key.AltLeft;
                // AltRight
                case MacOSKeyCode.B:
                    return Key.B;
                case MacOSKeyCode.Backslash:
                    return Key.BackSlash;
                case MacOSKeyCode.Backspace:
                    return Key.BackSpace;
                case MacOSKeyCode.BracketLeft:
                    return Key.BracketLeft;
                case MacOSKeyCode.BracketRight:
                    return Key.BracketRight;
                case MacOSKeyCode.C:
                    return Key.C;
                // Capslock
                // Clear
                case MacOSKeyCode.Comma:
                    return Key.Comma;
                case MacOSKeyCode.Control:
                    return Key.ControlLeft;
                // ControlRight
                case MacOSKeyCode.D:
                    return Key.D;
                case MacOSKeyCode.Del:
                    return Key.Delete;
                case MacOSKeyCode.Down:
                    return Key.Down;
                case MacOSKeyCode.E:
                    return Key.E;
                case MacOSKeyCode.End:
                    return Key.End;
                case MacOSKeyCode.Enter:
                    return Key.Enter;
                case MacOSKeyCode.Return:
                    return Key.Enter;
                case MacOSKeyCode.Esc:
                    return Key.Escape;
                case MacOSKeyCode.F:
                    return Key.F;
                case MacOSKeyCode.F1:
                    return Key.F1;
                case MacOSKeyCode.F2:
                    return Key.F2;
                case MacOSKeyCode.F3:
                    return Key.F3;
                case MacOSKeyCode.F4:
                    return Key.F4;
                case MacOSKeyCode.F5:
                    return Key.F5;
                case MacOSKeyCode.F6:
                    return Key.F6;
                case MacOSKeyCode.F7:
                    return Key.F7;
                case MacOSKeyCode.F8:
                    return Key.F8;
                case MacOSKeyCode.F9:
                    return Key.F9;
                case MacOSKeyCode.F10:
                    return Key.F10;
                case MacOSKeyCode.F11:
                    return Key.F11;
                case MacOSKeyCode.F12:
                    return Key.F12;
                case MacOSKeyCode.F13:
                    return Key.F13;
                case MacOSKeyCode.F14:
                    return Key.F14;
                case MacOSKeyCode.F15:
                    return Key.F15;
                // F16-F35
                case MacOSKeyCode.G:
                    return Key.G;
                case MacOSKeyCode.H:
                    return Key.H;
                case MacOSKeyCode.Home:
                    return Key.Home;
                case MacOSKeyCode.I:
                    return Key.I;
                case MacOSKeyCode.Insert:
                    return Key.Insert;
                case MacOSKeyCode.J:
                    return Key.J;
                case MacOSKeyCode.K:
                    return Key.K;
                case MacOSKeyCode.KeyPad_0:
                    return Key.Keypad0;
                case MacOSKeyCode.KeyPad_1:
                    return Key.Keypad1;
                case MacOSKeyCode.KeyPad_2:
                    return Key.Keypad2;
                case MacOSKeyCode.KeyPad_3:
                    return Key.Keypad3;
                case MacOSKeyCode.KeyPad_4:
                    return Key.Keypad4;
                case MacOSKeyCode.KeyPad_5:
                    return Key.Keypad5;
                case MacOSKeyCode.KeyPad_6:
                    return Key.Keypad6;
                case MacOSKeyCode.KeyPad_7:
                    return Key.Keypad7;
                case MacOSKeyCode.KeyPad_8:
                    return Key.Keypad8;
                case MacOSKeyCode.KeyPad_9:
                    return Key.Keypad9;
                case MacOSKeyCode.KeyPad_Add:
                    return Key.KeypadAdd;
                case MacOSKeyCode.KeyPad_Decimal:
                    return Key.KeypadDecimal;
                case MacOSKeyCode.KeyPad_Divide:
                    return Key.KeypadDivide;
                case MacOSKeyCode.KeyPad_Enter:
                    return Key.KeypadEnter;
                case MacOSKeyCode.KeyPad_Multiply:
                    return Key.KeypadMultiply;
                case MacOSKeyCode.KeyPad_Subtract:
                    return Key.KeypadSubtract;
                //case MacOSKeyCode.KeyPad_Equal;
                case MacOSKeyCode.L:
                    return Key.L;
                case MacOSKeyCode.Left:
                    return Key.Left;
                case MacOSKeyCode.M:
                    return Key.M;
                //Key.MaxKeys 
                case MacOSKeyCode.Menu:
                    return Key.Menu;
                case MacOSKeyCode.Minus:
                    return Key.Minus;
                case MacOSKeyCode.N:
                    return Key.N;
                case MacOSKeyCode.Key_0:
                    return Key.Number0;
                case MacOSKeyCode.Key_1:
                    return Key.Number1;
                case MacOSKeyCode.Key_2:
                    return Key.Number2;
                case MacOSKeyCode.Key_3:
                    return Key.Number3;
                case MacOSKeyCode.Key_4:
                    return Key.Number4;
                case MacOSKeyCode.Key_5:
                    return Key.Number5;
                case MacOSKeyCode.Key_6:
                    return Key.Number6;
                case MacOSKeyCode.Key_7:
                    return Key.Number7;
                case MacOSKeyCode.Key_8:
                    return Key.Number8;
                case MacOSKeyCode.Key_9:
                    return Key.Number9;
                // Numlock
                case MacOSKeyCode.O:
                    return Key.O;
                case MacOSKeyCode.P:
                    return Key.P;
                case MacOSKeyCode.Pagedown:
                    return Key.PageDown;
                case MacOSKeyCode.Pageup:
                    return Key.PageUp;
                // Pause
                case MacOSKeyCode.Period:
                    return Key.Period;
                case MacOSKeyCode.Equals:
                    return Key.Plus;
                // PrintScreen
                case MacOSKeyCode.Q:
                    return Key.Q;
                case MacOSKeyCode.Quote:
                    return Key.Quote;
                case MacOSKeyCode.R:
                    return Key.R;
                case MacOSKeyCode.Right:
                    return Key.Right;
                case MacOSKeyCode.S:
                    return Key.S;
                // ScrollLock
                case MacOSKeyCode.Semicolon:
                    return Key.Semicolon;
                case MacOSKeyCode.Shift:
                    return Key.ShiftLeft;
                //Key.ShiftRight 
                case MacOSKeyCode.Slash:
                    return Key.Slash;
                // Key.Sleep
                case MacOSKeyCode.Space:
                    return Key.Space;
                case MacOSKeyCode.T:
                    return Key.T;
                case MacOSKeyCode.Tab:
                    return Key.Tab;
                case MacOSKeyCode.Tilde:
                    return Key.Tilde;
                case MacOSKeyCode.U:
                    return Key.U;
                case MacOSKeyCode.Up:
                    return Key.Up;
                case MacOSKeyCode.V:
                    return Key.V;
                case MacOSKeyCode.W:
                    return Key.W;
                case MacOSKeyCode.Command:
                    return Key.WinLeft;
                // WinKeyRight
                case MacOSKeyCode.X:
                    return Key.X;
                case MacOSKeyCode.Y:
                    return Key.Y;
                case MacOSKeyCode.Z:
                    return Key.Z;

                default:
                    return Key.Unknown;
            }
        }
    }
}
