using System;
using System.Collections.Generic;
using System.Text;

using OpenTK.Input;
using System.Runtime.InteropServices;

namespace OpenTK.Platform.X11
{
    /// <summary>
    /// Drives the Keyboard devices on X11.
    /// This class supports OpenTK, and is not intended for use by OpenTK programs.
    /// </summary>
    internal class X11Keyboard : IKeyboardDriver
    {
        /// <summary>
        /// The window receiving input events.
        /// </summary>
        WindowInfo window;

        private bool[] keys = new bool[(int)OpenTK.Input.Key.MaxKeys];
        private List<Keyboard> keyboards;
        private static Dictionary<XKey, Key> keymap = new Dictionary<XKey, Key>((int)Key.MaxKeys);
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
                keymap.Add(XKey.Print, Key.PrintScreen);
                keymap.Add(XKey.Tab, Key.Tab);
                keymap.Add(XKey.minus, Key.Minus);
                keymap.Add(XKey.plus, Key.Plus);
                //keymap.Add

                //keymap.Add(XKey.Scroll_Lock, Key.Scr);
                keymap.Add(XKey.Caps_Lock, Key.CapsLock);
                keymap.Add(XKey.Num_Lock, Key.NumLock);

                for (int i = (int)XKey.F1; i < (int)XKey.F35; i++)
                {
                    keymap.Add((XKey)i, (Key)((int)Key.F1 + (i - (int)XKey.F1)));
                }

                for (int i = (int)XKey.a; i < 26; i++)
                {
                    keymap.Add((XKey)i, (Key)((int)Key.A + i));
                }

                for (int i = (int)XKey.A; i < 26; i++)
                {
                    keymap.Add((XKey)i, (Key)((int)Key.A + i));
                }

                for (int i = (int)XKey.Number0; i <= 9; i++)
                {
                    keymap.Add((XKey)i, (Key)((int)Key.Number0 + i));
                }

                for (int i = (int)XKey.KP_0; i <= 9; i++)
                {
                    keymap.Add((XKey)i, (Key)((int)Key.Keypad0 + i));
                }

                keymap.Add(XKey.Pause, Key.Pause);
                keymap.Add(XKey.Break, Key.Pause);

                keymapExists = true;
            }
        }

        #endregion

        internal X11Keyboard(WindowInfo window)
        {
            /*
            this.window = window;
            Initialize();

            API.DisplayKeycodes(window.Display, ref firstKeyCode, ref lastKeyCode);
            IntPtr keysym_ptr = API.GetKeyboardMapping(window.Display, (byte)firstKeyCode,
                lastKeyCode - firstKeyCode + 1, ref keysyms_per_keycode);

            keysyms = new IntPtr[(lastKeyCode - firstKeyCode + 1) * keysyms_per_keycode];
            Marshal.PtrToStructure(keysym_ptr, keysyms);
            //keysyms = (IntPtr[])Marshal.PtrToStructure(keysym_ptr, typeof(IntPtr[]));

            API.Free(keysym_ptr);
            */
            Keyboard kb = new Keyboard();
            kb.Description = "Default X11 keyboard";
            kb.NumberOfKeys = lastKeyCode - firstKeyCode + 1;
            keyboards.Add(kb);
        }

        #region internal bool ProcessKeyboardEvent(API.RawInput rin)

        /// <summary>
        /// Processes X11 KeyEvents.
        /// </summary>
        /// <param name="e">The X11.KeyEvent to process</param>
        /// <returns>True if the event was processed, false otherwise.</returns>
        internal bool ProcessKeyboardEvent(X11.KeyEvent e)
        {
            return false;
            /*API.e.keycode
            switch (rin.Header.Type)
            {
                case API.RawInputDeviceType.KEYBOARD:
                    bool pressed =
                        rin.Data.Keyboard.Message == API.Constants.WM_KEYDOWN ||
                        rin.Data.Keyboard.Message == API.Constants.WM_SYSKEYDOWN;

                    // Generic control, shift, alt keys may be sent instead of left/right.
                    // It seems you have to explicitly register left/right events.
                    switch (rin.Data.Keyboard.VKey)
                    {
                        case API.VirtualKeys.SHIFT:
                            keyboards[0][Input.Key.ShiftLeft] = keyboards[0][Input.Key.ShiftRight] = pressed;
                            return false;

                        case API.VirtualKeys.CONTROL:
                            keyboards[0][Input.Key.ControlLeft] = keyboards[0][Input.Key.ControlRight] = pressed;
                            return false;

                        case API.VirtualKeys.MENU:
                            keyboards[0][Input.Key.AltLeft] = keyboards[0][Input.Key.AltRight] = pressed;
                            return false;

                        default:
                            if (!WinRawKeyboard.KeyMap.ContainsKey(rin.Data.Keyboard.VKey))
                            {
                                Debug.Print("Virtual key {0} not mapped.", rin.Data.Keyboard.VKey);
                                OpenTK.OpenGL.GL.ClearColor(1.0f, 0.3f, 0.3f, 0.0f);
                            }
                            else
                            {
                                keyboards[0][WinRawKeyboard.KeyMap[rin.Data.Keyboard.VKey]] = pressed;
                                OpenTK.OpenGL.GL.ClearColor(0.0f, 0.0f, 0.0f, 0.0f);
                            }
                            break;
                    }
                    break;

                default:
                    throw new ApplicationException("Windows raw keyboard driver received invalid data.");
            }
            return false;*/
        }

        #endregion

        #region --- IKeyboardDriver Members ---

        public IList<Keyboard> Keyboard
        {
            get { return keyboards; }
        }

        #endregion
    }
}
