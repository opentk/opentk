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
    class WinKeyMap
    {
        readonly Dictionary<int, Key> ScanMap = new Dictionary<int, Key>();

        public WinKeyMap()
        {
            // 0 - 15
            Append(Key.Unknown);
            Append(Key.Escape);

            for (int i = 0; i < 9; i++)
                Append(Key.Number1 + i);
            Append(Key.Number0);

            Append(Key.Minus);
            Append(Key.Plus);
            Append(Key.BackSpace);
            Append(Key.Tab);

            // 16-31
            Append(Key.Q);
            Append(Key.W);
            Append(Key.E);
            Append(Key.R);
            Append(Key.T);
            Append(Key.Y);
            Append(Key.U);
            Append(Key.I);
            Append(Key.O);
            Append(Key.P);
            Append(Key.BracketLeft);
            Append(Key.BracketRight);
            Append(Key.Enter);
            Append(Key.ControlLeft);
            Append(Key.A);
            Append(Key.S);

            // 32 - 47
            Append(Key.D);
            Append(Key.F);
            Append(Key.G);
            Append(Key.H);
            Append(Key.J);
            Append(Key.K);
            Append(Key.L);
            Append(Key.Semicolon);
            Append(Key.Quote);
            Append(Key.Grave);
            Append(Key.ShiftLeft);
            Append(Key.BackSlash);
            Append(Key.Z);
            Append(Key.X);
            Append(Key.C);
            Append(Key.V);

            // 48 - 63
            Append(Key.B);
            Append(Key.N);
            Append(Key.M);
            Append(Key.Comma);
            Append(Key.Period);
            Append(Key.Slash);
            Append(Key.ShiftRight);
            Append(Key.PrintScreen);
            Append(Key.AltLeft);
            Append(Key.Space);
            Append(Key.CapsLock);
            Append(Key.F1);
            Append(Key.F2);
            Append(Key.F3);
            Append(Key.F4);
            Append(Key.F5);

            // 64 - 79
            Append(Key.F6);
            Append(Key.F7);
            Append(Key.F8);
            Append(Key.F9);
            Append(Key.F10);
            Append(Key.NumLock);
            Append(Key.ScrollLock);
            Append(Key.Home);
            Append(Key.Up);
            Append(Key.PageUp);
            Append(Key.KeypadMinus);
            Append(Key.Left);
            Append(Key.Keypad5);
            Append(Key.Right);
            Append(Key.KeypadPlus);
            Append(Key.End);

            // 80 - 95
            Append(Key.Down);
            Append(Key.PageDown);
            Append(Key.Insert);
            Append(Key.Delete);
            Append(Key.Unknown);
            Append(Key.Unknown);
            Append(Key.NonUSBackSlash);
            Append(Key.F11);
            Append(Key.F12);
            Append(Key.Pause);
            Append(Key.Unknown);
            Append(Key.WinLeft);
            Append(Key.WinRight);
            Append(Key.Menu);
            Append(Key.Unknown);
            Append(Key.Unknown);

            // 96 - 111
            Append(Key.Unknown);
            Append(Key.Unknown);
            Append(Key.Unknown);
            Append(Key.Unknown);
            Append(Key.F13);
            Append(Key.F14);
            Append(Key.F15);
            Append(Key.F16);
            Append(Key.F17);
            Append(Key.F18);
            Append(Key.F19);
            Append(Key.Unknown);
            Append(Key.Unknown);
            Append(Key.Unknown);
            Append(Key.Unknown);
            Append(Key.Unknown);

            // 112 - 127
            Append(Key.Unknown);
            Append(Key.Unknown);
            Append(Key.Unknown);
            Append(Key.Unknown);
            Append(Key.Unknown);
            Append(Key.Unknown);
            Append(Key.Unknown);
            Append(Key.Unknown);
            Append(Key.Unknown);
            Append(Key.Unknown);
            Append(Key.Unknown);
            Append(Key.Unknown);
            Append(Key.Unknown);
            Append(Key.Unknown);
            Append(Key.Unknown);
            Append(Key.Unknown);
        }

        void Append(Key key)
        {
            ScanMap.Add(ScanMap.Count, key);
        }

        public Key TranslateKey(short scancode, VirtualKeys vkey, bool extended0, bool extended1, out bool is_valid)
        {
            is_valid = true;

            Key key;
            ScanMap.TryGetValue(scancode, out key);

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
