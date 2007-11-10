#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using OpenTK.Input;

namespace OpenTK.Platform.X11
{
    /// <summary>
    /// Drives Mouse devices on X11.
    /// This class supports OpenTK, and is not intended for use by OpenTK programs.
    /// </summary>
    internal sealed class X11Mouse : IMouseDriver
    {
        WindowInfo window;
        List<MouseDevice> mice = new List<MouseDevice>();

        #region --- Constructor ---

        public X11Mouse(WindowInfo window)
        {
            this.window = window;

            // Just create one mouse now.
            // TODO: support for multiple devices through evdev.
            // TODO: Should call XSelectInput for mouse pointer events.
            MouseDevice m = new MouseDevice();
            m.Description = "Default X11 mouse";
            m.DeviceID = IntPtr.Zero;
            m.NumberOfButtons = 5;
            m.NumberOfWheels = 1;
            mice.Add(m);
        }

        #endregion

        #region --- IMouseDriver Members ---

        public IList<MouseDevice> Mouse
        {
            get { return mice; }
        }

        #endregion

        /// <summary>
        /// Processes XButtonEvents.
        /// </summary>
        /// <param name="e">The X11.XButtonEvent to process.</param>
        /// <returns>True if the event was processed, false otherwise.</returns>
        internal bool ProcessButton(ref X11.XButtonEvent e)
        {
            MouseDevice m = mice[0];
            bool pressed = e.type == XEventName.ButtonPress;
            //e.
            if ((e.state & (int)X11.MouseMask.Button1Mask) != 0) m[OpenTK.Input.MouseButton.Left] = pressed;
            if ((e.state & (int)X11.MouseMask.Button2Mask) != 0) m[OpenTK.Input.MouseButton.Middle] = pressed;
            if ((e.state & (int)X11.MouseMask.Button3Mask) != 0) m[OpenTK.Input.MouseButton.Right] = pressed;
            if ((e.state & (int)X11.MouseMask.Button4Mask) != 0) m.Wheel++;
            if ((e.state & (int)X11.MouseMask.Button5Mask) != 0) m.Wheel--;
            return true;
        }

        /// <summary>
        /// Processes XMotionEvents.
        /// </summary>
        /// <param name="e">The X11.XMotionEvent to process.</param>
        /// <returns>True if the event was processed, false otherwise.</returns>
        internal bool ProcessMotion(ref X11.XMotionEvent e)
        {
            MouseDevice m = mice[0];
            m.X = e.x;
            m.Y = e.y;
            return true;
        }

        /// <summary>
        /// Queries the mouse pos.
        /// </summary>
        internal void Poll()
        {
            IntPtr root, child;
            int state, root_x, root_y, win_x, win_y;
            MouseDevice m = mice[0];
            Functions.XQueryPointer(window.Display, window.Handle, out root, out child, out root_x, out root_y, out win_x, out win_y, out state);
            m[OpenTK.Input.MouseButton.Left] = (state & (int)X11.MouseMask.Button1Mask) != 0;
            m[OpenTK.Input.MouseButton.Middle] = (state & (int)X11.MouseMask.Button2Mask) != 0;
            m[OpenTK.Input.MouseButton.Right] = (state & (int)X11.MouseMask.Button3Mask) != 0;
            if ((state & (int)X11.MouseMask.Button4Mask) != 0) m.Wheel++;
            if ((state & (int)X11.MouseMask.Button5Mask) != 0) m.Wheel--;
            //m.Wheel += (state & (int)X11.MouseMask.Button4Mask);
            //m.Wheel -= (state & (int)X11.MouseMask.Button5Mask);
            m.X = root_x;
            m.Y = root_y;
        }
    }
}
