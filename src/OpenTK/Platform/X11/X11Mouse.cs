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
    // Note: we cannot create a background window to retrieve events,
    // because X11 doesn't deliver core pointer events to background
    // windows (unless we grab, which will break *everything*).
    // The only solution is to poll.
    // Note 2: this driver only supports absolute positions. Relative motion
    // is faked through SetPosition. This is called automatically when
    // NativeWindow.CursorVisible = false, otherwise it must be called
    // by the user.
    // Note 3: this driver cannot drive the mouse wheel reliably.
    // See comments in ProcessEvents() for more information.
    // (If someone knows of a solution, please tell!)
    sealed class X11Mouse : IMouseDriver2
    {
        readonly IntPtr display;
        readonly IntPtr root_window;
        MouseState mouse = new MouseState();
        MouseState cursor = new MouseState();

        // When the mouse warps, "detach" the current location
        // from the pointer.
        bool mouse_detached;
        int mouse_detached_x, mouse_detached_y;

        public X11Mouse()
        {
            Debug.WriteLine("Using X11Mouse.");
            mouse.IsConnected = true;
            cursor.IsConnected = true;
            display = API.DefaultDisplay;
            root_window = Functions.XRootWindow(display, Functions.XDefaultScreen(display));
        }

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

        public MouseState GetCursorState()
        {
            ProcessEvents();
            return cursor;
        }

        public void SetPosition(double x, double y)
        {
            // Update the current location, otherwise the pointer
            // may become locked (for instance, if we call
            // SetPosition too often, like X11GLNative does).
            ProcessEvents();

            using (new XLock(display))
            {
                // Mark the expected warp-event so it can be ignored.
                mouse_detached = true;
                mouse_detached_x = (int)x;
                mouse_detached_y = (int)y;

                Functions.XWarpPointer(display,
                    IntPtr.Zero, root_window, 0, 0, 0, 0, (int)x, (int)y);
            }
        }

        void ProcessEvents()
        {
            IntPtr root, child;
            int root_x, root_y, win_x, win_y;
            int buttons;

            using (new XLock(display))
            {
                IntPtr window = root_window;
                Functions.XQueryPointer(display, window, out root, out child,
                    out root_x, out root_y, out win_x, out win_y, out buttons);

                cursor.X = root_x;
                cursor.Y = root_y;

                if (!mouse_detached)
                {
                    mouse.X = root_x;
                    mouse.Y = root_y;
                }
                else
                {
                    mouse.X += (int)root_x - mouse_detached_x;
                    mouse.Y += (int)root_y - mouse_detached_y;
                    mouse_detached_x = root_x;
                    mouse_detached_y = root_y;
                }
                cursor[MouseButton.Left] = mouse[MouseButton.Left] = (buttons & (int)MouseMask.Button1Mask) != 0;
                cursor[MouseButton.Middle] = mouse[MouseButton.Middle] = (buttons & (int)MouseMask.Button2Mask) != 0;
                cursor[MouseButton.Right] = mouse[MouseButton.Right] = (buttons & (int)MouseMask.Button3Mask) != 0;
                // Note: this will never work right, wheel events have a duration of 0
                // (yes, zero). They are impposible to catch via polling.
                // After spending a week on this, I simply don't care anymore.
                // If someone can fix it, please do.
                // Note 2: I have tried passively grabbing those buttons - no go (BadAccess).
                // Maybe I am doing something wrong with the grab.
                //if ((buttons & (int)MouseMask.Button4Mask) != 0)
                //   mouse.WheelPrecise++;
                //if ((buttons & (int)MouseMask.Button5Mask) != 0)
                //    mouse.WheelPrecise--;
                cursor[MouseButton.Button1] = mouse[MouseButton.Button1] = (buttons & (int)MouseMask.Button6Mask) != 0;
                cursor[MouseButton.Button2] = mouse[MouseButton.Button2] = (buttons & (int)MouseMask.Button7Mask) != 0;
                cursor[MouseButton.Button3] = mouse[MouseButton.Button3] = (buttons & (int)MouseMask.Button8Mask) != 0;
            }
        }
    }
}

