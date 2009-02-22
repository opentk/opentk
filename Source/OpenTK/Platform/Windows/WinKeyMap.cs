#region --- License ---
/* Copyright (c) 2007 Stefanos Apostolopoulos
 * See license.txt for license information
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using OpenTK.Platform.Windows;
using OpenTK.Input;
using System.Diagnostics;

namespace OpenTK.Platform.Windows
{
    internal class WinKeyMap : Dictionary<VirtualKeys, Input.Key>
    {
        /// <summary>
        /// Initializes the map between VirtualKeys and OpenTK.Key
        /// </summary>
        internal WinKeyMap()
        {
            try
            {
                this.Add(VirtualKeys.ESCAPE, Key.Escape);

                // Function keys
                for (int i = 0; i < 24; i++)
                {
                    this.Add((VirtualKeys)((int)VirtualKeys.F1 + i), Key.F1 + i);
                }

                // Number keys (0-9)
                for (int i = 0; i <= 9; i++)
                {
                    this.Add((VirtualKeys)(0x30 + i), Key.Number0 + i);
                }

                // Letters (A-Z)
                for (int i = 0; i < 26; i++)
                {
                    this.Add((VirtualKeys)(0x41 + i), Key.A + i);
                }

                this.Add(VirtualKeys.TAB, Key.Tab);
                this.Add(VirtualKeys.CAPITAL, Key.CapsLock);
                this.Add(VirtualKeys.LCONTROL, Key.ControlLeft);
                this.Add(VirtualKeys.LSHIFT, Key.ShiftLeft);
                this.Add(VirtualKeys.LWIN, Key.WinLeft);
                this.Add(VirtualKeys.LMENU, Key.AltLeft);
                this.Add(VirtualKeys.SPACE, Key.Space);
                this.Add(VirtualKeys.RMENU, Key.AltRight);
                this.Add(VirtualKeys.RWIN, Key.WinRight);
                this.Add(VirtualKeys.APPS, Key.Menu);
                this.Add(VirtualKeys.RCONTROL, Key.ControlRight);
                this.Add(VirtualKeys.RSHIFT, Key.ShiftRight);
                this.Add(VirtualKeys.RETURN, Key.Enter);
                this.Add(VirtualKeys.BACK, Key.BackSpace);

                this.Add(VirtualKeys.OEM_1, Key.Semicolon);      // Varies by keyboard, ;: on Win2K/US
                this.Add(VirtualKeys.OEM_2, Key.Slash);          // Varies by keyboard, /? on Win2K/US
                this.Add(VirtualKeys.OEM_3, Key.Tilde);          // Varies by keyboard, `~ on Win2K/US
                this.Add(VirtualKeys.OEM_4, Key.BracketLeft);    // Varies by keyboard, [{ on Win2K/US
                this.Add(VirtualKeys.OEM_5, Key.BackSlash);      // Varies by keyboard, \| on Win2K/US
                this.Add(VirtualKeys.OEM_6, Key.BracketRight);   // Varies by keyboard, ]} on Win2K/US
                this.Add(VirtualKeys.OEM_7, Key.Quote);          // Varies by keyboard, '" on Win2K/US
                this.Add(VirtualKeys.OEM_PLUS, Key.Plus);        // Invariant: +
                this.Add(VirtualKeys.OEM_COMMA, Key.Comma);      // Invariant: ,
                this.Add(VirtualKeys.OEM_MINUS, Key.Minus);      // Invariant: -
                this.Add(VirtualKeys.OEM_PERIOD, Key.Period);    // Invariant: .

                this.Add(VirtualKeys.HOME, Key.Home);
                this.Add(VirtualKeys.END, Key.End);
                this.Add(VirtualKeys.DELETE, Key.Delete);
                this.Add(VirtualKeys.PRIOR, Key.PageUp);
                this.Add(VirtualKeys.NEXT, Key.PageDown);
                this.Add(VirtualKeys.PRINT, Key.PrintScreen);
                this.Add(VirtualKeys.PAUSE, Key.Pause);
                this.Add(VirtualKeys.NUMLOCK, Key.NumLock);

                this.Add(VirtualKeys.SCROLL, Key.ScrollLock);
                this.Add(VirtualKeys.SNAPSHOT, Key.PrintScreen);
                this.Add(VirtualKeys.CLEAR, Key.Clear);
                this.Add(VirtualKeys.INSERT, Key.Insert);

                this.Add(VirtualKeys.SLEEP, Key.Sleep);

                // Keypad
                for (int i = 0; i <= 9; i++)
                {
                    this.Add((VirtualKeys)((int)VirtualKeys.NUMPAD0 + i), Key.Keypad0 + i);
                }
                this.Add(VirtualKeys.DECIMAL, Key.KeypadDecimal);
                this.Add(VirtualKeys.ADD, Key.KeypadAdd);
                this.Add(VirtualKeys.SUBTRACT, Key.KeypadSubtract);
                this.Add(VirtualKeys.DIVIDE, Key.KeypadDivide);
                this.Add(VirtualKeys.MULTIPLY, Key.KeypadMultiply);

                // Navigation
                this.Add(VirtualKeys.UP, Key.Up);
                this.Add(VirtualKeys.DOWN, Key.Down);
                this.Add(VirtualKeys.LEFT, Key.Left);
                this.Add(VirtualKeys.RIGHT, Key.Right);
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
