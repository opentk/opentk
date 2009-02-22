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
    internal class X11KeyMap : Dictionary<XKey, Key>
    {
        internal X11KeyMap()
        {
            try
            {
                this.Add(XKey.Escape, Key.Escape);
                this.Add(XKey.Return, Key.Enter);
                this.Add(XKey.space, Key.Space);
                this.Add(XKey.BackSpace, Key.BackSpace);

                this.Add(XKey.Shift_L, Key.ShiftLeft);
                this.Add(XKey.Shift_R, Key.ShiftRight);
                this.Add(XKey.Alt_L, Key.AltLeft);
                this.Add(XKey.Alt_R, Key.AltRight);
                this.Add(XKey.Control_L, Key.ControlLeft);
                this.Add(XKey.Control_R, Key.ControlRight);
                this.Add(XKey.Super_L, Key.WinLeft);
                this.Add(XKey.Super_R, Key.WinRight);
                this.Add(XKey.Meta_L, Key.WinLeft);
                this.Add(XKey.Meta_R, Key.WinRight);

                this.Add(XKey.Menu, Key.Menu);
                this.Add(XKey.Tab, Key.Tab);
                this.Add(XKey.minus, Key.Minus);
                this.Add(XKey.plus, Key.Plus);
                this.Add(XKey.equal, Key.Plus);

                this.Add(XKey.Caps_Lock, Key.CapsLock);
                this.Add(XKey.Num_Lock, Key.NumLock);

                for (int i = (int)XKey.F1; i <= (int)XKey.F35; i++)
                {
                    this.Add((XKey)i, (Key)((int)Key.F1 + (i - (int)XKey.F1)));
                }

                for (int i = (int)XKey.a; i <= (int)XKey.z; i++)
                {
                    this.Add((XKey)i, (Key)((int)Key.A + (i - (int)XKey.a)));
                }

                for (int i = (int)XKey.A; i <= (int)XKey.Z; i++)
                {
                    this.Add((XKey)i, (Key)((int)Key.A + (i - (int)XKey.A)));
                }

                for (int i = (int)XKey.Number0; i <= (int)XKey.Number9; i++)
                {
                    this.Add((XKey)i, (Key)((int)Key.Number0 + (i - (int)XKey.Number0)));
                }

                for (int i = (int)XKey.KP_0; i <= (int)XKey.KP_9; i++)
                {
                    this.Add((XKey)i, (Key)((int)Key.Keypad0 + (i - (int)XKey.KP_0)));
                }

                this.Add(XKey.Pause, Key.Pause);
                this.Add(XKey.Break, Key.Pause);
                this.Add(XKey.Scroll_Lock, Key.Pause);
                this.Add(XKey.Insert, Key.PrintScreen);
                this.Add(XKey.Print, Key.PrintScreen);
                this.Add(XKey.Sys_Req, Key.PrintScreen);

                this.Add(XKey.backslash, Key.BackSlash);
                this.Add(XKey.bar, Key.BackSlash);
                this.Add(XKey.braceleft, Key.BracketLeft);
                this.Add(XKey.bracketleft, Key.BracketLeft);
                this.Add(XKey.braceright, Key.BracketRight);
                this.Add(XKey.bracketright, Key.BracketRight);
                this.Add(XKey.colon, Key.Semicolon);
                this.Add(XKey.semicolon, Key.Semicolon);
                this.Add(XKey.quoteright, Key.Quote);
                this.Add(XKey.quotedbl, Key.Quote);
                this.Add(XKey.quoteleft, Key.Tilde);
                this.Add(XKey.asciitilde, Key.Tilde);

                this.Add(XKey.comma, Key.Comma);
                this.Add(XKey.less, Key.Comma);
                this.Add(XKey.period, Key.Period);
                this.Add(XKey.greater, Key.Period);
                this.Add(XKey.slash, Key.Slash);
                this.Add(XKey.question, Key.Slash);

                this.Add(XKey.Left, Key.Left);
                this.Add(XKey.Down, Key.Down);
                this.Add(XKey.Right, Key.Right);
                this.Add(XKey.Up, Key.Up);

                this.Add(XKey.Delete, Key.Delete);
                this.Add(XKey.Home, Key.Home);
                this.Add(XKey.End, Key.End);
                //this.Add(XKey.Prior, Key.PageUp);   // XKey.Prior == XKey.Page_Up
                this.Add(XKey.Page_Up, Key.PageUp);
                this.Add(XKey.Page_Down, Key.PageDown);
                //this.Add(XKey.Next, Key.PageDown);  // XKey.Next == XKey.Page_Down

                this.Add(XKey.KP_Add, Key.KeypadAdd);
                this.Add(XKey.KP_Subtract, Key.KeypadSubtract);
                this.Add(XKey.KP_Multiply, Key.KeypadMultiply);
                this.Add(XKey.KP_Divide, Key.KeypadDivide);
                this.Add(XKey.KP_Decimal, Key.KeypadDecimal);
                this.Add(XKey.KP_Insert, Key.Keypad0);
                this.Add(XKey.KP_End, Key.Keypad1);
                this.Add(XKey.KP_Down, Key.Keypad2);
                this.Add(XKey.KP_Page_Down, Key.Keypad3);
                this.Add(XKey.KP_Left, Key.Keypad4);
                this.Add(XKey.KP_Right, Key.Keypad6);
                this.Add(XKey.KP_Home, Key.Keypad7);
                this.Add(XKey.KP_Up, Key.Keypad8);
                this.Add(XKey.KP_Page_Up, Key.Keypad9);
                this.Add(XKey.KP_Delete, Key.KeypadDecimal);
                this.Add(XKey.KP_Enter, Key.KeypadEnter);

            }
            catch (ArgumentException e)
            {
                Debug.Print("Exception while creating keymap: '{0}'.", e.ToString());
                System.Windows.Forms.MessageBox.Show(
                    String.Format("Exception while creating keymap: '{0}'.", e.ToString()));
            }
        }
    }
}
