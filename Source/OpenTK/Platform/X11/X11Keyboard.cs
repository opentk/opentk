#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;

using OpenTK.Input;
using System.Runtime.InteropServices;
using System.Diagnostics;

// TODO: How to detect multiple keyboards?

namespace OpenTK.Platform.X11
{
    /// <summary>
    /// Drives Keyboard devices on X11.
    /// This class supports OpenTK, and is not intended for use by OpenTK programs.
    /// </summary>
    internal sealed class X11Keyboard : IKeyboardDriver
    {
        /// <summary>
        /// The window receiving input events.
        /// </summary>
        WindowInfo window;

        List<KeyboardDevice> keyboards = new List<KeyboardDevice>();
        static Dictionary<XKey, Key> keymap = new Dictionary<XKey, Key>((int)Key.MaxKeys);
        /// <summary>
        /// The smallest and largest KeyCode supported by the X server. Queried through API.DisplayKeycodes()
        /// </summary>
        int firstKeyCode, lastKeyCode;
        /// <summary>
        /// The number of KeySyms for each KeyCode.
        /// </summary>
        int keysyms_per_keycode;

        IntPtr[] keysyms;

        private static bool keymapExists;

        #region private static void Initialize()

        private static void Initialize()
        {
            if (!keymapExists)
            {
                keymap.Add(XKey.Escape, Key.Escape);
                keymap.Add(XKey.Return, Key.Enter);
                keymap.Add(XKey.space, Key.Space);
                keymap.Add(XKey.BackSpace, Key.BackSpace);

                keymap.Add(XKey.Shift_L, Key.ShiftLeft);
                keymap.Add(XKey.Shift_R, Key.ShiftRight);
                keymap.Add(XKey.Alt_L, Key.AltLeft);
                keymap.Add(XKey.Alt_R, Key.AltRight);
                keymap.Add(XKey.Control_L, Key.ControlLeft);
                keymap.Add(XKey.Control_R, Key.ControlRight);
                keymap.Add(XKey.Super_L, Key.WinLeft);
                keymap.Add(XKey.Super_R, Key.WinRight);
                keymap.Add(XKey.Meta_L, Key.WinLeft);
                keymap.Add(XKey.Meta_R, Key.WinRight);
                
                keymap.Add(XKey.Menu, Key.Menu);
                keymap.Add(XKey.Tab, Key.Tab);
                keymap.Add(XKey.minus, Key.Minus);
                keymap.Add(XKey.plus, Key.Plus);
                keymap.Add(XKey.equal, Key.Plus);

                keymap.Add(XKey.Caps_Lock, Key.CapsLock);
                keymap.Add(XKey.Num_Lock, Key.NumLock);

                for (int i = (int)XKey.F1; i <= (int)XKey.F35; i++)
                {
                    keymap.Add((XKey)i, (Key)((int)Key.F1 + (i - (int)XKey.F1)));
                }

                for (int i = (int)XKey.a; i <= (int)XKey.z; i++)
                {
                    keymap.Add((XKey)i, (Key)((int)Key.A + (i - (int)XKey.a)));
                }

                for (int i = (int)XKey.A; i <= (int)XKey.Z; i++)
                {
                    keymap.Add((XKey)i, (Key)((int)Key.A + (i - (int)XKey.A)));
                }

                for (int i = (int)XKey.Number0; i <= (int)XKey.Number9; i++)
                {
                    keymap.Add((XKey)i, (Key)((int)Key.Number0 + (i - (int)XKey.Number0)));
                }

                for (int i = (int)XKey.KP_0; i <= (int)XKey.KP_9; i++)
                {
                    keymap.Add((XKey)i, (Key)((int)Key.Keypad0 + (i - (int)XKey.KP_0)));
                }

                keymap.Add(XKey.Pause, Key.Pause);
                keymap.Add(XKey.Break, Key.Pause);
                keymap.Add(XKey.Scroll_Lock, Key.Pause);
                keymap.Add(XKey.Insert, Key.PrintScreen);
                keymap.Add(XKey.Print, Key.PrintScreen);
                keymap.Add(XKey.Sys_Req, Key.PrintScreen);

                keymap.Add(XKey.backslash, Key.BackSlash);
                keymap.Add(XKey.bar, Key.BackSlash);
                keymap.Add(XKey.braceleft, Key.BracketLeft);
                keymap.Add(XKey.bracketleft, Key.BracketLeft);
                keymap.Add(XKey.braceright, Key.BracketRight);
                keymap.Add(XKey.bracketright, Key.BracketRight);
                keymap.Add(XKey.colon, Key.Semicolon);
                keymap.Add(XKey.semicolon, Key.Semicolon);
                keymap.Add(XKey.quoteright, Key.Quote);
                keymap.Add(XKey.quotedbl, Key.Quote);
                keymap.Add(XKey.quoteleft, Key.Tilde);
                keymap.Add(XKey.asciitilde, Key.Tilde);

                keymap.Add(XKey.comma, Key.Comma);
                keymap.Add(XKey.less, Key.Comma);
                keymap.Add(XKey.period, Key.Period);
                keymap.Add(XKey.greater, Key.Period);
                keymap.Add(XKey.slash, Key.Slash);
                keymap.Add(XKey.question, Key.Slash);

                keymap.Add(XKey.Left, Key.Left);
                keymap.Add(XKey.Down, Key.Down);
                keymap.Add(XKey.Right, Key.Right);
                keymap.Add(XKey.Up, Key.Up);
                
                keymap.Add(XKey.Delete, Key.Delete);
                keymap.Add(XKey.Home, Key.Home);
                keymap.Add(XKey.End, Key.End);
                //keymap.Add(XKey.Prior, Key.PageUp);   // XKey.Prior == XKey.Page_Up
                keymap.Add(XKey.Page_Up, Key.PageUp);
                keymap.Add(XKey.Page_Down, Key.PageDown);
                //keymap.Add(XKey.Next, Key.PageDown);  // XKey.Next == XKey.Page_Down
                
                keymap.Add(XKey.KP_Add, Key.KeypadAdd);
                keymap.Add(XKey.KP_Subtract, Key.KeypadSubtract);
                keymap.Add(XKey.KP_Multiply, Key.KeypadMultiply);
                keymap.Add(XKey.KP_Divide, Key.KeypadDivide);
                keymap.Add(XKey.KP_Decimal, Key.KeypadDecimal);
                keymap.Add(XKey.KP_Insert, Key.Keypad0);
                keymap.Add(XKey.KP_End, Key.Keypad1);
                keymap.Add(XKey.KP_Down, Key.Keypad2);
                keymap.Add(XKey.KP_Page_Down, Key.Keypad3);
                keymap.Add(XKey.KP_Left, Key.Keypad4);
                keymap.Add(XKey.KP_Right, Key.Keypad6);
                keymap.Add(XKey.KP_Home, Key.Keypad7);
                keymap.Add(XKey.KP_Up, Key.Keypad8);
                keymap.Add(XKey.KP_Page_Up, Key.Keypad9);
                keymap.Add(XKey.KP_Delete, Key.KeypadDecimal);
                keymap.Add(XKey.KP_Enter, Key.Enter);

                keymapExists = true;
            }
        }

        #endregion

        #region --- Constructor ---

        internal X11Keyboard(WindowInfo window)
        {
            if (window == null)
                throw new ArgumentNullException("window");

            this.window = window;
            Initialize();

            //Debug.Print("Info: {0}", window.ToString());

            API.DisplayKeycodes(window.Display, ref firstKeyCode, ref lastKeyCode);
            Debug.Print("First keycode: {0}, last {1}", firstKeyCode, lastKeyCode);

            IntPtr keysym_ptr = API.GetKeyboardMapping(window.Display, (byte)firstKeyCode,
                lastKeyCode - firstKeyCode + 1, ref keysyms_per_keycode);
            Debug.Print("{0} keysyms per keycode.", keysyms_per_keycode);

            keysyms = new IntPtr[(lastKeyCode - firstKeyCode + 1) * keysyms_per_keycode];
            Marshal.PtrToStructure(keysym_ptr, keysyms);
            //keysyms = (IntPtr[])Marshal.PtrToStructure(keysym_ptr, typeof(IntPtr[]));

            API.Free(keysym_ptr);
            
            KeyboardDevice kb = new KeyboardDevice();
            kb.Description = "Default X11 keyboard";
            kb.NumberOfKeys = lastKeyCode - firstKeyCode + 1;
            kb.DeviceID = IntPtr.Zero;
            keyboards.Add(kb);
            Debug.Print("Keyboard added: {0}", kb.ToString());
        }

        #endregion

        #region internal bool ProcessKeyboardEvent(X11.KeyEvent e)

        /// <summary>
        /// Processes X11 KeyEvents.
        /// </summary>
        /// <param name="e">The X11.KeyEvent to process</param>
        /// <returns>True if the event was processed, false otherwise.</returns>
        internal bool ProcessKeyboardEvent(ref X11.XKeyEvent e)
        {
            //int keysym = keysyms[(e.keycode - firstKeyCode) * keysyms_per_keycode].ToInt32();
            //int keysym2 = keysyms[(e.keycode - firstKeyCode) * keysyms_per_keycode].ToInt32();
            bool pressed = e.type == XEventName.KeyPress;

            IntPtr keysym = API.LookupKeysym(ref e, 0);
            IntPtr keysym2 = API.LookupKeysym(ref e, 1);

            //Debug.Print("Key down: {0}", e.ToString());

            int index = keyboards.FindIndex(delegate(KeyboardDevice kb)
            {
                return kb.DeviceID == IntPtr.Zero;
            });

            switch (keysym.ToInt64())
            {
                default:
                if (keymap.ContainsKey((XKey)keysym))
                {
                    keyboards[index][keymap[(XKey)keysym]] = pressed;
                }
                else if (keymap.ContainsKey((XKey)keysym2))
                {
                    keyboards[index][keymap[(XKey)keysym2]] = pressed;
                }
                else
                {
                    //Debug.Print("KeyCode {0} (Keysym: {1}, {2}) not mapped.", e.keycode, (XKey)keysym, (XKey)keysym2);
                    return false;
                }
                return true;
            }
        }

        #endregion

        #region --- IKeyboardDriver Members ---

        public IList<KeyboardDevice> Keyboard
        {
            get { return keyboards; }
        }

        #endregion

        #region public void Poll()

        public void Poll()
        {
            //Keymap map = new Keymap();
            //X11.Functions.XQueryKeymap(window.Display, map);
            /*
            byte[] bits = new byte[32];
            X11.Functions.XQueryKeymap(window.Display, bits);

            XKeyEvent e = new XKeyEvent();
            e.display = window.Display;
            e.window = window.Handle;
            e.root = window.RootWindow;

            for (int i = 0; i < 256; i++)
            {
                e.keycode = i;
                ProcessKeyboardEvent(e);

                //if (keymap.ContainsKey((XKey)i))
                //    keyboards[0][keymap[(XKey)i]] = ((bits[i / 8] >> (i % 8)) & 0x01) != 0;
            }
            */
        }

        #endregion
    }
}
