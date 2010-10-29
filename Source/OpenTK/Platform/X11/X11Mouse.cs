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

namespace OpenTK.Platform.X11
{
    sealed class X11Mouse : IMouseDriver2
    {
        MouseState mouse = new MouseState();
        X11WindowInfo window;

        // Can either attach itself to the specified window or can hook the root window.
        public X11Mouse(X11WindowInfo win)
        {
            if (win != null)
            {
                window = win;
            }
            else
            {
                using (new XLock(API.DefaultDisplay))
                {
                    window = new X11WindowInfo();
                    window.Display = API.DefaultDisplay;
                    window.Screen = Functions.XDefaultScreen(window.Display);
                    window.RootWindow = Functions.XRootWindow(window.Display, window.Screen);
                    window.WindowHandle = window.RootWindow;
                    window.EventMask = EventMask.ButtonMotionMask |
                        EventMask.ButtonPressMask | EventMask.ButtonReleaseMask;

                    //Functions.XGrabPointer(window.Display, window.RootWindow, true,
                    //    window.EventMask, GrabMode.GrabModeAsync, GrabMode.GrabModeAsync, IntPtr.Zero,
                    //     IntPtr.Zero, IntPtr.Zero);
                    //Functions.XSelectInput(window.Display, window.RootWindow, new IntPtr((int)window.EventMask));
                }

                Debug.WriteLine("Using X11Mouse.");
            }
        }

        // Todo: remove this
        public IList<MouseDevice> Mouse { get { throw new NotSupportedException(); } }

        public MouseState GetState()
        {
            ProcessEvents();
            return mouse;
        }

        public MouseState GetState(int index)
        {
            ProcessEvents();
            // X11Mouse supports only one device
            if (index == 0)
                return mouse;
            else
                return new MouseState();
        }

        void WriteBit(MouseButton offset, int enabled)
        {
            if (enabled != 0)
                mouse.EnableBit((int)offset);
            else
                mouse.DisableBit((int)offset);
        }

        void ProcessEvents()
        {
            IntPtr root, child;
            int root_x, root_y, win_x, win_y;
            int buttons;
            Functions.XQueryPointer(window.Display, window.WindowHandle, out root, out child,
                out root_x, out root_y, out win_x, out win_y, out buttons);
            mouse.X = root_x;
            mouse.Y = root_y;
            WriteBit(MouseButton.Left, buttons & (int)MouseMask.Button1Mask);
            WriteBit(MouseButton.Middle, buttons & (int)MouseMask.Button2Mask);
            WriteBit(MouseButton.Right, buttons & (int)MouseMask.Button3Mask);
            if ((buttons & (int)MouseMask.Button4Mask) != 0)
                mouse.WheelPrecise++;
            if ((buttons & (int)MouseMask.Button5Mask) != 0)
                mouse.WheelPrecise--;
            WriteBit(MouseButton.Button1, buttons & (int)MouseMask.Button6Mask);
            WriteBit(MouseButton.Button2, buttons & (int)MouseMask.Button7Mask);
            WriteBit(MouseButton.Button3, buttons & (int)MouseMask.Button8Mask);

//            XEvent e = new XEvent();
//
//            while (true)
//            {
//                using (new XLock(window.Display))
//                {
//                    if (!Functions.XCheckWindowEvent(window.Display, window.WindowHandle, window.EventMask, ref e))
//                        break;
//
//                    switch (e.type)
//                    {
//                        case XEventName.ButtonPress:
//                            switch (e.ButtonEvent.button)
//                            {
//                                case 1: mouse.EnableBit((int)MouseButton.Left); break;
//                                case 2: mouse.EnableBit((int)MouseButton.Middle); break;
//                                case 3: mouse.EnableBit((int)MouseButton.Right); break;
//                                case 4: mouse.WheelPrecise++; break;
//                                case 5: mouse.WheelPrecise--; break;
//                                case 6: mouse.EnableBit((int)MouseButton.Button1); break;
//                                case 7: mouse.EnableBit((int)MouseButton.Button2); break;
//                                case 8: mouse.EnableBit((int)MouseButton.Button3); break;
//                                case 9: mouse.EnableBit((int)MouseButton.Button4); break;
//                                case 10: mouse.EnableBit((int)MouseButton.Button5); break;
//                                case 11: mouse.EnableBit((int)MouseButton.Button6); break;
//                                case 12: mouse.EnableBit((int)MouseButton.Button7); break;
//                                case 13: mouse.EnableBit((int)MouseButton.Button8); break;
//                                case 15: mouse.EnableBit((int)MouseButton.Button9); break;
//                            }
//                            break;
//
//                        case XEventName.ButtonRelease:
//                            switch (e.ButtonEvent.button)
//                            {
//                                case 1: mouse.DisableBit((int)MouseButton.Left); break;
//                                case 2: mouse.DisableBit((int)MouseButton.Middle); break;
//                                case 3: mouse.DisableBit((int)MouseButton.Right); break;
//                                case 6: mouse.DisableBit((int)MouseButton.Button1); break;
//                                case 7: mouse.DisableBit((int)MouseButton.Button2); break;
//                                case 8: mouse.DisableBit((int)MouseButton.Button3); break;
//                                case 9: mouse.DisableBit((int)MouseButton.Button4); break;
//                                case 10: mouse.DisableBit((int)MouseButton.Button5); break;
//                                case 11: mouse.DisableBit((int)MouseButton.Button6); break;
//                                case 12: mouse.DisableBit((int)MouseButton.Button7); break;
//                                case 13: mouse.DisableBit((int)MouseButton.Button8); break;
//                                case 15: mouse.DisableBit((int)MouseButton.Button9); break;
//                            }
//                            break;
//
//                        case XEventName.MotionNotify:
//                            mouse.X = e.MotionEvent.x;
//                            mouse.Y = e.MotionEvent.y;
//                            break;
//                    }
//                }
//            }
        }
    }
}

