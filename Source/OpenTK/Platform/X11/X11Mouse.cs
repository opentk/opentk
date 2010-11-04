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
        readonly IntPtr display;
        MouseState mouse = new MouseState();

         // Can either attach itself to the specified window or can hook the root window.
        public X11Mouse()
        {
            Debug.WriteLine("Using X11Mouse.");
            mouse.IsConnected = true;
            display = API.DefaultDisplay;
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

            using (new XLock(display))
            {
                IntPtr window = Functions.XRootWindow(display, Functions.XDefaultScreen(display));
                Functions.XQueryPointer(display, window, out root, out child,
                    out root_x, out root_y, out win_x, out win_y, out buttons);

                mouse.X = root_x;
                mouse.Y = root_y;
                WriteBit(MouseButton.Left, buttons & (int)MouseMask.Button1Mask);
                WriteBit(MouseButton.Middle, buttons & (int)MouseMask.Button2Mask);
                WriteBit(MouseButton.Right, buttons & (int)MouseMask.Button3Mask);
                // Note: this will never work right. After spending a week on this, I simply don't care
                // anymore. If someone can fix it, please do.
                // Note 2: I have tried passively grabbing those buttons - no go (BadAccess).
                if ((buttons & (int)MouseMask.Button4Mask) != 0)
                   mouse.WheelPrecise++;
                if ((buttons & (int)MouseMask.Button5Mask) != 0)
                    mouse.WheelPrecise--;
                WriteBit(MouseButton.Button1, buttons & (int)MouseMask.Button6Mask);
                WriteBit(MouseButton.Button2, buttons & (int)MouseMask.Button7Mask);
                WriteBit(MouseButton.Button3, buttons & (int)MouseMask.Button8Mask);
            }
        }
    }
}

