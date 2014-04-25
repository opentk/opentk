#region --- License ---
/* Licensed under the MIT/X11 license.
 * Copyright (c) 2006-2008 the OpenTK team.
 * This notice may not be removed.
 * See license.txt for licensing detailed licensing details.
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using OpenTK.Input;

namespace OpenTK.Platform.X11
{
    static class X11KeyMap
    {
        public static Key GetKey(XKey key)
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
    }
}
