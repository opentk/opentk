#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Runtime.InteropServices;

using OpenTK.Input;

namespace OpenTK.Platform.X11
{
    /// <summary>
    /// Drives the InputDriver on X11.
    /// This class supports OpenTK, and is not intended for users of OpenTK.
    /// </summary>
    internal sealed class X11Input : IInputDriver
    {
        X11Joystick joystick_driver = new X11Joystick();
        //X11WindowInfo window;
        KeyboardDevice keyboard = new KeyboardDevice();
        MouseDevice mouse = new MouseDevice();
        List<KeyboardDevice> dummy_keyboard_list = new List<KeyboardDevice>(1);
        List<MouseDevice> dummy_mice_list = new List<MouseDevice>(1);

        X11KeyMap keymap = new X11KeyMap();
        int firstKeyCode, lastKeyCode; // The smallest and largest KeyCode supported by the X server.
        int keysyms_per_keycode;    // The number of KeySyms for each KeyCode.
        IntPtr[] keysyms;

        //bool disposed;

        #region --- Constructors ---

        /// <summary>
        /// Constructs a new X11Input driver. Creates a hidden InputOnly window, child to
        /// the main application window, which selects input events and routes them to 
        /// the device specific drivers (Keyboard, Mouse, Hid).
        /// </summary>
        /// <param name="attach">The window which the InputDriver will attach itself on.</param>
        public X11Input(IWindowInfo attach)
        {
            Debug.WriteLine("Initalizing X11 input driver.");
            Debug.Indent();

            if (attach == null)
                throw new ArgumentException("A valid parent window must be defined, in order to create an X11Input driver.");

            //window = new X11WindowInfo(attach);
            X11WindowInfo window = (X11WindowInfo)attach;

            // Init mouse
            mouse.Description = "Default X11 mouse";
            mouse.DeviceID = IntPtr.Zero;
            mouse.NumberOfButtons = 5;
            mouse.NumberOfWheels = 1;
            dummy_mice_list.Add(mouse);

            // Init keyboard
            API.DisplayKeycodes(window.Display, ref firstKeyCode, ref lastKeyCode);
            Debug.Print("First keycode: {0}, last {1}", firstKeyCode, lastKeyCode);

            IntPtr keysym_ptr = API.GetKeyboardMapping(window.Display, (byte)firstKeyCode,
                lastKeyCode - firstKeyCode + 1, ref keysyms_per_keycode);
            Debug.Print("{0} keysyms per keycode.", keysyms_per_keycode);

            keysyms = new IntPtr[(lastKeyCode - firstKeyCode + 1) * keysyms_per_keycode];
            Marshal.PtrToStructure(keysym_ptr, keysyms);
            API.Free(keysym_ptr);

            KeyboardDevice kb = new KeyboardDevice();
            keyboard.Description = "Default X11 keyboard";
            keyboard.NumberOfKeys = lastKeyCode - firstKeyCode + 1;
            keyboard.DeviceID = IntPtr.Zero;
            dummy_keyboard_list.Add(keyboard);

            Debug.Unindent();
        }

        #endregion

        #region private void InternalPoll()
#if false
        private void InternalPoll()
        {
            X11.XEvent e = new XEvent();
            try
            {
                while (!disposed)
                {
                    Functions.XMaskEvent(window.Display,
                        EventMask.PointerMotionMask | EventMask.PointerMotionHintMask |
                        EventMask.ButtonPressMask | EventMask.ButtonReleaseMask |
                        EventMask.KeyPressMask | EventMask.KeyReleaseMask |
                        EventMask.StructureNotifyMask, ref e);

                    if (disposed)
                        return;

                    switch (e.type)
                    {
                        case XEventName.KeyPress:
                        case XEventName.KeyRelease:
                            keyboardDriver.ProcessKeyboardEvent(ref e.KeyEvent);
                            break;

                        case XEventName.ButtonPress:
                        case XEventName.ButtonRelease:
                            mouseDriver.ProcessButton(ref e.ButtonEvent);
                            break;

                        case XEventName.MotionNotify:
                            mouseDriver.ProcessMotion(ref e.MotionEvent);
                            break;

                        case XEventName.DestroyNotify:
                            Functions.XPutBackEvent(window.Display, ref e);
                            //pollingThread.Abort();
                            return;
                    }
                }
            }
            catch (ThreadAbortException expt)
            {
                Functions.XUnmapWindow(window.Display, window.Handle);
                Functions.XDestroyWindow(window.Display, window.Handle);
                return;
            }
        }
#endif
        #endregion

        #region internal void ProcessEvent(ref XEvent e)

        internal void ProcessEvent(ref XEvent e)
        {
            switch (e.type)
            {
                case XEventName.KeyPress:
                case XEventName.KeyRelease:
                    bool pressed = e.type == XEventName.KeyPress;

                    IntPtr keysym = API.LookupKeysym(ref e.KeyEvent, 0);
                    IntPtr keysym2 = API.LookupKeysym(ref e.KeyEvent, 1);

                    if (keymap.ContainsKey((XKey)keysym))
                        keyboard[keymap[(XKey)keysym]] = pressed;
                    else if (keymap.ContainsKey((XKey)keysym2))
                        keyboard[keymap[(XKey)keysym2]] = pressed;
                    else
                        Debug.Print("KeyCode {0} (Keysym: {1}, {2}) not mapped.", e.KeyEvent.keycode, (XKey)keysym, (XKey)keysym2);
                    break;

                case XEventName.ButtonPress:
                    if      (e.ButtonEvent.button == 1) mouse[OpenTK.Input.MouseButton.Left] = true;
                    else if (e.ButtonEvent.button == 2) mouse[OpenTK.Input.MouseButton.Middle] = true;
                    else if (e.ButtonEvent.button == 3) mouse[OpenTK.Input.MouseButton.Right] = true;
                    else if (e.ButtonEvent.button == 4) mouse.Wheel++;
                    else if (e.ButtonEvent.button == 5) mouse.Wheel--;
                    else if (e.ButtonEvent.button == 6) mouse[OpenTK.Input.MouseButton.Button1] = true;
                    else if (e.ButtonEvent.button == 7) mouse[OpenTK.Input.MouseButton.Button2] = true;
                    else if (e.ButtonEvent.button == 8) mouse[OpenTK.Input.MouseButton.Button3] = true;
                    else if (e.ButtonEvent.button == 9) mouse[OpenTK.Input.MouseButton.Button4] = true;
                    else if (e.ButtonEvent.button == 10) mouse[OpenTK.Input.MouseButton.Button5] = true;
                    else if (e.ButtonEvent.button == 11) mouse[OpenTK.Input.MouseButton.Button6] = true;
                    else if (e.ButtonEvent.button == 12) mouse[OpenTK.Input.MouseButton.Button7] = true;
                    else if (e.ButtonEvent.button == 13) mouse[OpenTK.Input.MouseButton.Button8] = true;
                    else if (e.ButtonEvent.button == 14) mouse[OpenTK.Input.MouseButton.Button9] = true;
                    //if ((e.state & (int)X11.MouseMask.Button4Mask) != 0) m.Wheel++;
                    //if ((e.state & (int)X11.MouseMask.Button5Mask) != 0) m.Wheel--;
                    //Debug.Print("Button pressed: {0}", e.ButtonEvent.button);
                    break;

                case XEventName.ButtonRelease:
                    if      (e.ButtonEvent.button == 1) mouse[OpenTK.Input.MouseButton.Left] = false;
                    else if (e.ButtonEvent.button == 2) mouse[OpenTK.Input.MouseButton.Middle] = false;
                    else if (e.ButtonEvent.button == 3) mouse[OpenTK.Input.MouseButton.Right] = false;
                    else if (e.ButtonEvent.button == 6) mouse[OpenTK.Input.MouseButton.Button1] = false;
                    else if (e.ButtonEvent.button == 7) mouse[OpenTK.Input.MouseButton.Button2] = false;
                    else if (e.ButtonEvent.button == 8) mouse[OpenTK.Input.MouseButton.Button3] = false;
                    else if (e.ButtonEvent.button == 9) mouse[OpenTK.Input.MouseButton.Button4] = false;
                    else if (e.ButtonEvent.button == 10) mouse[OpenTK.Input.MouseButton.Button5] = false;
                    else if (e.ButtonEvent.button == 11) mouse[OpenTK.Input.MouseButton.Button6] = false;
                    else if (e.ButtonEvent.button == 12) mouse[OpenTK.Input.MouseButton.Button7] = false;
                    else if (e.ButtonEvent.button == 13) mouse[OpenTK.Input.MouseButton.Button8] = false;
                    else if (e.ButtonEvent.button == 14) mouse[OpenTK.Input.MouseButton.Button9] = false;
                    break;

                case XEventName.MotionNotify:
                    mouse.Position = new System.Drawing.Point(e.MotionEvent.x, e.MotionEvent.y);
                    break;
            }
        }

        #endregion

        #region --- IInputDriver Members ---

        #region public IList<Keyboard> Keyboard

        public IList<KeyboardDevice> Keyboard
        {
            get { return dummy_keyboard_list;  }//return keyboardDriver.Keyboard;
        }

        #endregion

        #region public IList<Mouse> Mouse

        public IList<MouseDevice> Mouse
        {
            get { return (IList<MouseDevice>)dummy_mice_list; } //return mouseDriver.Mouse;
        }

        #endregion

        #region public IList<JoystickDevice> Joysticks

        public IList<JoystickDevice> Joysticks
        {
            get { return joystick_driver.Joysticks; }
        }

        #endregion

        #region public void Poll()

        /// <summary>
        /// Polls and updates state of all keyboard, mouse and joystick devices.
        /// </summary>
        public void Poll()
        {
            joystick_driver.Poll();
        }

        #endregion

        #endregion

        #region --- IDisposable Members ---

        public void Dispose()
        {
            //this.Dispose(true);
            //GC.SuppressFinalize(this);
        }

        //private void Dispose(bool manual)
        //{
        //    if (!disposed)
        //    {
        //        //disposing = true;
        //        if (pollingThread != null && pollingThread.IsAlive)
        //            pollingThread.Abort();

        //        if (manual)
        //        {
        //        }

        //        disposed = true;
        //    }
        //}

        //~X11Input()
        //{
        //    this.Dispose(false);
        //}

        #endregion
    }
}
