﻿#region License
//
// X11KeyMap.cs
//
// Author:
//       Stefanos Apostolopoulos <stapostol@gmail.com>
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
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using OpenTK.Input;

namespace OpenTK.Platform.X11
{
    class X11KeyMap
    {
        // Keycode lookup table for current layout
        readonly Key[] keycodes = new Key[256];
        readonly bool xkb_supported;

        internal X11KeyMap(IntPtr display)
        {
            xkb_supported = Xkb.IsSupported(display);
            if (xkb_supported)
            {
                RefreshKeycodes(display);
            }
        }

        // Refreshes the keycodes lookup table based
        // on the current keyboard layout.
        internal void RefreshKeycodes(IntPtr display)
        {
            // Approach inspired by GLFW: http://www.glfw.org/
            // Huge props to the GLFW team! 
            if (xkb_supported)
            {
                unsafe
                {
                    // Xkb.GetKeyboard appears to be broken (multiple bug reports across distros)
                    // so use Xkb.AllocKeyboard with Xkb.GetNames instead.
                    XkbDesc* keyboard = Xkb.AllocKeyboard(display);
                    if (keyboard != null)
                    {
                        Xkb.GetNames(display, XkbNamesMask.All, keyboard);

                        for (int i = 0; i < keycodes.Length; i++)
                        {
                            keycodes[i] = Key.Unknown;
                        }

                        // Map all alphanumeric keys of this layout
                        // Symbols are handled in GetKey() instead.
                        for (int i = keyboard->min_key_code; i <= keyboard->max_key_code; ++i)
                        {
                            string name = new string((sbyte*)keyboard->names->keys[i].name, 0, Xkb.KeyNameLength);

                            Key key = Key.Unknown;
                            switch (name)
                            {
                                case "TLDE":
                                    key = Key.Tilde;
                                    break;
                                case "AE01":
                                    key = Key.Number1;
                                    break;
                                case "AE02":
                                    key = Key.Number2;
                                    break;
                                case "AE03":
                                    key = Key.Number3;
                                    break;
                                case "AE04":
                                    key = Key.Number4;
                                    break;
                                case "AE05":
                                    key = Key.Number5;
                                    break;
                                case "AE06":
                                    key = Key.Number6;
                                    break;
                                case "AE07":
                                    key = Key.Number7;
                                    break;
                                case "AE08":
                                    key = Key.Number8;
                                    break;
                                case "AE09":
                                    key = Key.Number9;
                                    break;
                                case "AE10":
                                    key = Key.Number0;
                                    break;
                                case "AE11":
                                    key = Key.Minus;
                                    break;
                                case "AE12":
                                    key = Key.Plus;
                                    break;
                                case "AD01":
                                    key = Key.Q;
                                    break;
                                case "AD02":
                                    key = Key.W;
                                    break;
                                case "AD03":
                                    key = Key.E;
                                    break;
                                case "AD04":
                                    key = Key.R;
                                    break;
                                case "AD05":
                                    key = Key.T;
                                    break;
                                case "AD06":
                                    key = Key.Y;
                                    break;
                                case "AD07":
                                    key = Key.U;
                                    break;
                                case "AD08":
                                    key = Key.I;
                                    break;
                                case "AD09":
                                    key = Key.O;
                                    break;
                                case "AD10":
                                    key = Key.P;
                                    break;
                                case "AD11":
                                    key = Key.BracketLeft;
                                    break;
                                case "AD12":
                                    key = Key.BracketRight;
                                    break;
                                case "AC01":
                                    key = Key.A;
                                    break;
                                case "AC02":
                                    key = Key.S;
                                    break;
                                case "AC03":
                                    key = Key.D;
                                    break;
                                case "AC04":
                                    key = Key.F;
                                    break;
                                case "AC05":
                                    key = Key.G;
                                    break;
                                case "AC06":
                                    key = Key.H;
                                    break;
                                case "AC07":
                                    key = Key.J;
                                    break;
                                case "AC08":
                                    key = Key.K;
                                    break;
                                case "AC09":
                                    key = Key.L;
                                    break;
                                case "AC10":
                                    key = Key.Semicolon;
                                    break;
                                case "AC11":
                                    key = Key.Quote;
                                    break;
                                case "AB01":
                                    key = Key.Z;
                                    break;
                                case "AB02":
                                    key = Key.X;
                                    break;
                                case "AB03":
                                    key = Key.C;
                                    break;
                                case "AB04":
                                    key = Key.V;
                                    break;
                                case "AB05":
                                    key = Key.B;
                                    break;
                                case "AB06":
                                    key = Key.N;
                                    break;
                                case "AB07":
                                    key = Key.M;
                                    break;
                                case "AB08":
                                    key = Key.Comma;
                                    break;
                                case "AB09":
                                    key = Key.Period;
                                    break;
                                case "AB10":
                                    key = Key.Slash;
                                    break;
                                case "BKSL":
                                    key = Key.BackSlash;
                                    break;
                                case "LSGT":
                                    key = Key.Unknown;
                                    break;
                                default:
                                    key = Key.Unknown;
                                    break;
                            }

                            keycodes[i] = key;
                        }

                        Xkb.FreeKeyboard(keyboard, 0, true);
                    }
                }
            }

            // Translate unknown keys (and symbols) using
            // regular layout-dependent GetKey()
            for (int i = 0; i < 256; i++)
            {
                if (keycodes[i] == Key.Unknown)
                {
                    // TranslateKeyCode expects a XKeyEvent structure
                    // Make one up
                    XKeyEvent e = new XKeyEvent();
                    e.display = display;
                    e.keycode = i;
                    Key key = Key.Unknown;
                    if (TranslateKeyEvent(ref e, out key))
                    {
                        keycodes[i] = key;
                    }
                }
            }
        }

        static Key TranslateXKey(XKey key)
        {
            switch (key)
            {
                case XKey.Escape:
                    return Key.Escape;
                case XKey.Return:
                    return Key.Enter;
                case XKey.space:
                    return Key.Space;
                case XKey.BackSpace:
                    return Key.BackSpace;

                case XKey.Shift_L:
                    return Key.ShiftLeft;
                case XKey.Shift_R:
                    return Key.ShiftRight;
                case XKey.Alt_L:
                    return Key.AltLeft;
                case XKey.Alt_R:
                    return Key.AltRight;
                case XKey.Control_L:
                    return Key.ControlLeft;
                case XKey.Control_R:
                    return Key.ControlRight;
                case XKey.Super_L:
                    return Key.WinLeft;
                case XKey.Super_R:
                    return Key.WinRight;
                case XKey.Meta_L:
                    return Key.WinLeft;
                case XKey.Meta_R:
                    return Key.WinRight;
                case XKey.ISO_Level3_Shift:
                    return Key.AltRight; // Normally AltGr

                case XKey.Menu:
                    return Key.Menu;
                case XKey.Tab:
                    return Key.Tab;
                case XKey.minus:
                    return Key.Minus;
                case XKey.plus:
                    return Key.Plus;
                case XKey.equal:
                    return Key.Plus;

                case XKey.Caps_Lock:
                    return Key.CapsLock;
                case XKey.Num_Lock:
                    return Key.NumLock;

                case XKey.F1:
                    return Key.F1;
                case XKey.F2:
                    return Key.F2;
                case XKey.F3:
                    return Key.F3;
                case XKey.F4:
                    return Key.F4;
                case XKey.F5:
                    return Key.F5;
                case XKey.F6:
                    return Key.F6;
                case XKey.F7:
                    return Key.F7;
                case XKey.F8:
                    return Key.F8;
                case XKey.F9:
                    return Key.F9;
                case XKey.F10:
                    return Key.F10;
                case XKey.F11:
                    return Key.F11;
                case XKey.F12:
                    return Key.F12;
                case XKey.F13:
                    return Key.F13;
                case XKey.F14:
                    return Key.F14;
                case XKey.F15:
                    return Key.F15;
                case XKey.F16:
                    return Key.F16;
                case XKey.F17:
                    return Key.F17;
                case XKey.F18:
                    return Key.F18;
                case XKey.F19:
                    return Key.F19;
                case XKey.F20:
                    return Key.F20;
                case XKey.F21:
                    return Key.F21;
                case XKey.F22:
                    return Key.F22;
                case XKey.F23:
                    return Key.F23;
                case XKey.F24:
                    return Key.F24;
                case XKey.F25:
                    return Key.F25;
                case XKey.F26:
                    return Key.F26;
                case XKey.F27:
                    return Key.F27;
                case XKey.F28:
                    return Key.F28;
                case XKey.F29:
                    return Key.F29;
                case XKey.F30:
                    return Key.F30;
                case XKey.F31:
                    return Key.F31;
                case XKey.F32:
                    return Key.F32;
                case XKey.F33:
                    return Key.F33;
                case XKey.F34:
                    return Key.F34;
                case XKey.F35:
                    return Key.F35;

                case XKey.a:
                case XKey.A:
                    return Key.A;
                case XKey.b:
                case XKey.B:
                    return Key.B;
                case XKey.c:
                case XKey.C:
                    return Key.C;
                case XKey.d:
                case XKey.D:
                    return Key.D;
                case XKey.e:
                case XKey.E:
                    return Key.E;
                case XKey.f:
                case XKey.F:
                    return Key.F;
                case XKey.g:
                case XKey.G:
                    return Key.G;
                case XKey.h:
                case XKey.H:
                    return Key.H;
                case XKey.i:
                case XKey.I:
                    return Key.I;
                case XKey.j:
                case XKey.J:
                    return Key.J;
                case XKey.k:
                case XKey.K:
                    return Key.K;
                case XKey.l:
                case XKey.L:
                    return Key.L;
                case XKey.m:
                case XKey.M:
                    return Key.M;
                case XKey.n:
                case XKey.N:
                    return Key.N;
                case XKey.o:
                case XKey.O:
                    return Key.O;
                case XKey.p:
                case XKey.P:
                    return Key.P;
                case XKey.q:
                case XKey.Q:
                    return Key.Q;
                case XKey.r:
                case XKey.R:
                    return Key.R;
                case XKey.s:
                case XKey.S:
                    return Key.S;
                case XKey.t:
                case XKey.T:
                    return Key.T;
                case XKey.u:
                case XKey.U:
                    return Key.U;
                case XKey.v:
                case XKey.V:
                    return Key.V;
                case XKey.w:
                case XKey.W:
                    return Key.W;
                case XKey.x:
                case XKey.X:
                    return Key.X;
                case XKey.y:
                case XKey.Y:
                    return Key.Y;
                case XKey.z:
                case XKey.Z:
                    return Key.Z;

                case XKey.Number0:
                    return Key.Number0;
                case XKey.Number1:
                    return Key.Number1;
                case XKey.Number2:
                    return Key.Number2;
                case XKey.Number3:
                    return Key.Number3;
                case XKey.Number4:
                    return Key.Number4;
                case XKey.Number5:
                    return Key.Number5;
                case XKey.Number6:
                    return Key.Number6;
                case XKey.Number7:
                    return Key.Number7;
                case XKey.Number8:
                    return Key.Number8;
                case XKey.Number9:
                    return Key.Number9;

                case XKey.KP_0:
                    return Key.Keypad0;
                case XKey.KP_1:
                    return Key.Keypad1;
                case XKey.KP_2:
                    return Key.Keypad2;
                case XKey.KP_3:
                    return Key.Keypad3;
                case XKey.KP_4:
                    return Key.Keypad4;
                case XKey.KP_5:
                    return Key.Keypad5;
                case XKey.KP_6:
                    return Key.Keypad6;
                case XKey.KP_7:
                    return Key.Keypad7;
                case XKey.KP_8:
                    return Key.Keypad8;
                case XKey.KP_9:
                    return Key.Keypad9;

                case XKey.Pause:
                    return Key.Pause;
                case XKey.Break:
                    return Key.Pause;
                case XKey.Scroll_Lock:
                    return Key.Pause;
                case XKey.Insert:
                    return Key.PrintScreen;
                case XKey.Print:
                    return Key.PrintScreen;
                case XKey.Sys_Req:
                    return Key.PrintScreen;

                case XKey.backslash:
                    return Key.BackSlash;
                case XKey.bar:
                    return Key.BackSlash;
                case XKey.braceleft:
                    return Key.BracketLeft;
                case XKey.bracketleft:
                    return Key.BracketLeft;
                case XKey.braceright:
                    return Key.BracketRight;
                case XKey.bracketright:
                    return Key.BracketRight;
                case XKey.colon:
                    return Key.Semicolon;
                case XKey.semicolon:
                    return Key.Semicolon;
                case XKey.quoteright:
                    return Key.Quote;
                case XKey.quotedbl:
                    return Key.Quote;
                case XKey.quoteleft:
                    return Key.Tilde;
                case XKey.asciitilde:
                    return Key.Tilde;

                case XKey.comma:
                    return Key.Comma;
                case XKey.less:
                    return Key.Comma;
                case XKey.period:
                    return Key.Period;
                case XKey.greater:
                    return Key.Period;
                case XKey.slash:
                    return Key.Slash;
                case XKey.question:
                    return Key.Slash;

                case XKey.Left:
                    return Key.Left;
                case XKey.Down:
                    return Key.Down;
                case XKey.Right:
                    return Key.Right;
                case XKey.Up:
                    return Key.Up;

                case XKey.Delete:
                    return Key.Delete;
                case XKey.Home:
                    return Key.Home;
                case XKey.End:
                    return Key.End;
            //case XKey.Prior: return Key.PageUp;   // XKey.Prior == XKey.Page_Up
                case XKey.Page_Up:
                    return Key.PageUp;
                case XKey.Page_Down:
                    return Key.PageDown;
            //case XKey.Next: return Key.PageDown;  // XKey.Next == XKey.Page_Down

                case XKey.KP_Add:
                    return Key.KeypadAdd;
                case XKey.KP_Subtract:
                    return Key.KeypadSubtract;
                case XKey.KP_Multiply:
                    return Key.KeypadMultiply;
                case XKey.KP_Divide:
                    return Key.KeypadDivide;
                case XKey.KP_Decimal:
                    return Key.KeypadDecimal;
                case XKey.KP_Insert:
                    return Key.Keypad0;
                case XKey.KP_End:
                    return Key.Keypad1;
                case XKey.KP_Down:
                    return Key.Keypad2;
                case XKey.KP_Page_Down:
                    return Key.Keypad3;
                case XKey.KP_Left:
                    return Key.Keypad4;
                case XKey.KP_Right:
                    return Key.Keypad6;
                case XKey.KP_Home:
                    return Key.Keypad7;
                case XKey.KP_Up:
                    return Key.Keypad8;
                case XKey.KP_Page_Up:
                    return Key.Keypad9;
                case XKey.KP_Delete:
                    return Key.KeypadDecimal;
                case XKey.KP_Enter:
                    return Key.KeypadEnter;

                default:
                    return Key.Unknown;
            }
        }

        bool TranslateKeyEvent(ref XKeyEvent e, out Key key)
        {
            if (xkb_supported)
            {
                return TranslateKeyXkb(e.display, e.keycode, out key);
            }
            else
            {
                return TranslateKeyX11(ref e, out key);
            }
        }

        bool TranslateKeyX11(ref XKeyEvent e, out Key key)
        {
            XKey keysym = (XKey)API.LookupKeysym(ref e, 0);
            XKey keysym2 = (XKey)API.LookupKeysym(ref e, 1);
            key = X11KeyMap.TranslateXKey(keysym);
            if (key == Key.Unknown)
            {
                key = X11KeyMap.TranslateXKey(keysym2);
            }
            if (key == Key.Unknown)
            {
                Debug.Print("KeyCode {0} (Keysym: {1}, {2}) not mapped.", e.keycode, (XKey)keysym, (XKey)keysym2);
            }

            return key != Key.Unknown;
        }

        bool TranslateKeyXkb(IntPtr display, int keycode, out Key key)
        {
            if (keycode < 8 || keycode > 255)
            {
                key = Key.Unknown;
                return false;
            }

            // Translate the numeric keypad using the secondary group
            // (equivalent to NumLock = on)
            XKey keysym = Xkb.KeycodeToKeysym(display, keycode, 0, 1);
            switch (keysym)
            {
                case XKey.KP_0: key = Key.Keypad0; return true;
                case XKey.KP_1: key = Key.Keypad1; return true;
                case XKey.KP_2: key = Key.Keypad2; return true;
                case XKey.KP_3: key = Key.Keypad3; return true;
                case XKey.KP_4: key = Key.Keypad4; return true;
                case XKey.KP_5: key = Key.Keypad5; return true;
                case XKey.KP_6: key = Key.Keypad6; return true;
                case XKey.KP_7: key = Key.Keypad7; return true;
                case XKey.KP_8: key = Key.Keypad8; return true;
                case XKey.KP_9: key = Key.Keypad9; return true;
                case XKey.KP_Separator:
                case XKey.KP_Decimal: key = Key.KeypadDecimal; return true;
                case XKey.KP_Equal: key = Key.Unknown; return false; // Todo: fixme
                case XKey.KP_Enter: key = Key.KeypadEnter; return true;
            }

            // Translate non-alphanumeric keys using the primary group
            keysym = Xkb.KeycodeToKeysym(display, keycode, 0, 0);
            key = TranslateXKey(keysym);
            return key != Key.Unknown;
        }

        internal bool TranslateKey(int keycode, out Key key)
        {
            if (keycode < 0 || keycode > 255)
            {
                key = Key.Unknown;
            }
            else
            {
                key = keycodes[keycode];
            }
            return key != Key.Unknown;
        }

        internal bool TranslateKey(ref XKeyEvent e, out Key key)
        {
            return TranslateKey(e.keycode, out key);
        }

        internal static MouseButton TranslateButton(int button, out float wheelx, out float wheely)
        {
            wheelx = 0;
            wheely = 0;

            switch (button)
            {
                case 1: return MouseButton.Left;
                case 2: return MouseButton.Middle;
                case 3: return MouseButton.Right;
                case 4: wheely = +1; return MouseButton.LastButton;
                case 5: wheely = -1; return MouseButton.LastButton;
                case 6: wheelx = +1; return MouseButton.LastButton;
                case 7: wheelx = -1; return MouseButton.LastButton;
                case 8: return MouseButton.Button1;
                case 9: return MouseButton.Button2;
                case 10: return MouseButton.Button3;
                case 11: return MouseButton.Button4;
                case 12: return MouseButton.Button5;
                case 13: return MouseButton.Button6;
                case 14: return MouseButton.Button7;
                default: return MouseButton.LastButton;
            }
        }
    }
}
