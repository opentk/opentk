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
        public static Key GetKey(VirtualKeys key)
        {
            switch (key)
            {
                case VirtualKeys.ESCAPE: return Key.Escape;
                case VirtualKeys.KEY_1: return Key.Number1;
                case VirtualKeys.KEY_2: return Key.Number2;
                case VirtualKeys.KEY_3: return Key.Number3;
                case VirtualKeys.KEY_4: return Key.Number4;
                case VirtualKeys.KEY_5: return Key.Number5;
                case VirtualKeys.KEY_6: return Key.Number6;
                case VirtualKeys.KEY_7: return Key.Number7;
                case VirtualKeys.KEY_8: return Key.Number8;
                case VirtualKeys.KEY_9: return Key.Number9;
                case VirtualKeys.KEY_0: return Key.Number0;
                case VirtualKeys.OEM_MINUS: return Key.Minus;
                case VirtualKeys.OEM_PLUS: return Key.Plus;
                case VirtualKeys.BACK: return Key.BackSpace;
                case VirtualKeys.TAB: return Key.Tab;

                case VirtualKeys.KEY_A: return Key.A;
                case VirtualKeys.KEY_B: return Key.B;
                case VirtualKeys.KEY_C: return Key.C;
                case VirtualKeys.KEY_D: return Key.D;
                case VirtualKeys.KEY_E: return Key.E;
                case VirtualKeys.KEY_F: return Key.F;
                case VirtualKeys.KEY_G: return Key.G;
                case VirtualKeys.KEY_H: return Key.H;
                case VirtualKeys.KEY_I: return Key.I;
                case VirtualKeys.KEY_J: return Key.J;
                case VirtualKeys.KEY_K: return Key.K;
                case VirtualKeys.KEY_L: return Key.L;
                case VirtualKeys.KEY_M: return Key.M;
                case VirtualKeys.KEY_N: return Key.N;
                case VirtualKeys.KEY_O: return Key.O;
                case VirtualKeys.KEY_P: return Key.P;
                case VirtualKeys.KEY_Q: return Key.Q;
                case VirtualKeys.KEY_R: return Key.R;
                case VirtualKeys.KEY_S: return Key.S;
                case VirtualKeys.KEY_T: return Key.T;
                case VirtualKeys.KEY_U: return Key.U;
                case VirtualKeys.KEY_V: return Key.V;
                case VirtualKeys.KEY_W: return Key.W;
                case VirtualKeys.KEY_X: return Key.X;
                case VirtualKeys.KEY_Y: return Key.Y;
                case VirtualKeys.KEY_Z: return Key.Z;

                case VirtualKeys.RETURN: return Key.Enter;
                case VirtualKeys.LCONTROL: return Key.ControlLeft;
                case VirtualKeys.RCONTROL: return Key.ControlRight;
                
                case VirtualKeys.OEM_1: return Key.Semicolon;
                case VirtualKeys.OEM_2: return Key.Slash;
                case VirtualKeys.OEM_3: return Key.Grave;
                case VirtualKeys.OEM_4: return Key.BracketLeft;
                case VirtualKeys.OEM_5: return Key.BackSlash;
                case VirtualKeys.OEM_6: return Key.BracketRight;
                case VirtualKeys.OEM_7: return Key.Quote;

                case VirtualKeys.LSHIFT: return Key.ShiftLeft;
                case VirtualKeys.RSHIFT: return Key.ShiftRight;
                case VirtualKeys.OEM_COMMA: return Key.Comma;
                case VirtualKeys.OEM_PERIOD: return Key.Period;
                case VirtualKeys.SNAPSHOT: return Key.PrintScreen;
                case VirtualKeys.LMENU: return Key.AltLeft;
                case VirtualKeys.RMENU: return Key.AltRight;
                case VirtualKeys.SPACE: return Key.Space;
                case VirtualKeys.CAPITAL: return Key.CapsLock;

                case VirtualKeys.F1: return Key.F1;
                case VirtualKeys.F2: return Key.F2;
                case VirtualKeys.F3: return Key.F3;
                case VirtualKeys.F4: return Key.F4;
                case VirtualKeys.F5: return Key.F5;
                case VirtualKeys.F6: return Key.F6;
                case VirtualKeys.F7: return Key.F7;
                case VirtualKeys.F8: return Key.F8;
                case VirtualKeys.F9: return Key.F9;
                case VirtualKeys.F10: return Key.F10;
                case VirtualKeys.F11: return Key.F11;
                case VirtualKeys.F12: return Key.F12;
                case VirtualKeys.F13: return Key.F13;
                case VirtualKeys.F14: return Key.F14;
                case VirtualKeys.F15: return Key.F15;
                case VirtualKeys.F16: return Key.F16;
                case VirtualKeys.F17: return Key.F17;
                case VirtualKeys.F18: return Key.F18;
                case VirtualKeys.F19: return Key.F19;
                case VirtualKeys.F20: return Key.F20;
                case VirtualKeys.F21: return Key.F21;
                case VirtualKeys.F22: return Key.F22;
                case VirtualKeys.F23: return Key.F23;
                case VirtualKeys.F24: return Key.F24;
                

                case VirtualKeys.NUMLOCK: return Key.NumLock;
                case VirtualKeys.SCROLL: return Key.ScrollLock;
                case VirtualKeys.HOME: return Key.Home;
                case VirtualKeys.UP: return Key.Up;
                case VirtualKeys.PRIOR: return Key.PageUp;
                case VirtualKeys.LEFT: return Key.Left;

                case VirtualKeys.NUMPAD0: return Key.Keypad0;
                case VirtualKeys.NUMPAD1: return Key.Keypad1;
                case VirtualKeys.NUMPAD2: return Key.Keypad2;
                case VirtualKeys.NUMPAD3: return Key.Keypad3;
                case VirtualKeys.NUMPAD4: return Key.Keypad4;
                case VirtualKeys.NUMPAD5: return Key.Keypad5;
                case VirtualKeys.NUMPAD6: return Key.Keypad6;
                case VirtualKeys.NUMPAD7: return Key.Keypad7;
                case VirtualKeys.NUMPAD8: return Key.Keypad8;
                case VirtualKeys.NUMPAD9: return Key.Keypad9;

                case VirtualKeys.RIGHT: return Key.Right;
                case VirtualKeys.END: return Key.End;

                case VirtualKeys.DOWN: return Key.Down;
                case VirtualKeys.NEXT: return Key.PageDown;
                case VirtualKeys.INSERT: return Key.Insert;
                case VirtualKeys.DELETE: return Key.Delete;

                case VirtualKeys.PAUSE: return Key.Pause;
                case VirtualKeys.LWIN: return Key.WinLeft;
                case VirtualKeys.RWIN: return Key.WinRight;

                default: return Key.Unknown;
            }
        }

        public static Key TranslateKey(VirtualKeys vkey, int scancode, bool extended)
        {
            vkey = MapLeftRightKeys(vkey, scancode, extended);
            return GetKey(vkey);
        }


        // http://stackoverflow.com/a/5681468/1873041
        static VirtualKeys MapLeftRightKeys(VirtualKeys vk, int scancode, bool extended)
        {
            VirtualKeys new_vkey = vk;

            switch (vk)
            {
                case VirtualKeys.SHIFT:
                    new_vkey = (VirtualKeys)Functions.MapVirtualKey((uint)scancode, MapVirtualKeyType.ScanCodeToVirtualKeyExtended);
                    break;
                case VirtualKeys.CONTROL:
                    new_vkey = extended ? VirtualKeys.RCONTROL : VirtualKeys.LCONTROL;
                    break;
                case VirtualKeys.MENU:
                    new_vkey = extended ? VirtualKeys.RMENU : VirtualKeys.LMENU;
                    break;
                default:
                    // not a key we map from generic to left/right specialized
                    //  just return it.
                    new_vkey = vk;
                    break;
            }

            return new_vkey;
        }
    }
}
