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
using OpenTK.Input;

namespace OpenTK.Platform.X11
{
    // Standard keyboard driver that relies on xlib input events.
    // Only one keyboard supported.
    sealed class X11Keyboard : IKeyboardDriver
    {
        readonly X11WindowInfo window = new X11WindowInfo();
        readonly X11KeyMap keymap = new X11KeyMap();
        KeyboardState state = new KeyboardState();

        // Can either attach itself to the specified window or can hook the root window.
        public X11Keyboard(X11WindowInfo win)
        {
            if (win != null)
            {
                window = win;
            }
            else
            {
                using (new XLock(API.DefaultDisplay))
                {
                    window.Display = API.DefaultDisplay;
                    window.Screen = Functions.XDefaultScreen(window.Display);
                    window.RootWindow = Functions.XRootWindow(window.Display, window.Screen);
                    window.WindowHandle = window.RootWindow;
                    window.EventMask =EventMask.KeyPressMask | EventMask.KeyReleaseMask | EventMask.KeymapStateMask;

                    Functions.XGrabKeyboard(window.Display, window.RootWindow, true,
                        GrabMode.GrabModeAsync, GrabMode.GrabModeAsync, IntPtr.Zero);
                    Functions.XSelectInput(window.Display, window.RootWindow, new IntPtr((int)window.EventMask));
                }
            }
        }

        // Todo: remove this
        public IList<KeyboardDevice> Keyboard { get { throw new NotSupportedException(); } }

        public KeyboardState GetState()
        {
            ProcessEvents();
            return state;
        }

        public KeyboardState GetState(int index)
        {
            ProcessEvents();
            return state;
        }

        void ProcessEvents()
        {
            XEvent e = new XEvent();

            while (true)
            {
                using (new XLock(window.Display))
                {
                    if (!Functions.XCheckWindowEvent(window.Display, window.WindowHandle, window.EventMask, ref e))
                        break;

                    switch (e.type)
                    {
                        case XEventName.KeyPress:
                        case XEventName.KeyRelease:
                            bool pressed = e.type == XEventName.KeyPress;
        
                            IntPtr keysym = API.LookupKeysym(ref e.KeyEvent, 0);
                            IntPtr keysym2 = API.LookupKeysym(ref e.KeyEvent, 1);
        
                            if (keymap.ContainsKey((XKey)keysym))
                            {
                                if (pressed)
                                    state.EnableBit((int)keymap[(XKey)keysym]);
                                else
                                    state.DisableBit((int)keymap[(XKey)keysym]);
                            }
                            else if (keymap.ContainsKey((XKey)keysym2))
                            {
                                if (pressed)
                                    state.EnableBit((int)keymap[(XKey)keysym2]);
                                else
                                    state.DisableBit((int)keymap[(XKey)keysym2]);
                            }
                            else
                            {
                                System.Diagnostics.Debug.Print("KeyCode {0} (Keysym: {1}, {2}) not mapped.",
                                    e.KeyEvent.keycode, (XKey)keysym, (XKey)keysym2);
                            }
                            break;

                        case XEventName.KeymapNotify:
                            System.Diagnostics.Debug.Print("Keymap event: {0}", e.KeymapEvent.key_vector0);
                            break;
                    }
                }
            }
        }
    }
}

