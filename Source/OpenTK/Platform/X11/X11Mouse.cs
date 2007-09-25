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
        List<Mouse> mice = new List<Mouse>();

        #region Constructor

        public X11Mouse(WindowInfo window)
        {
            this.window = window;

            // Just create one mouse now.
            // TODO: support for multiple devices through evdev.
            Mouse m = new Mouse();
            m.Description = "Default X11 mouse";
            m.DeviceID = IntPtr.Zero;
            m.NumberOfButtons = 5;
            m.NumberOfWheels = 1;
            mice.Add(m);
        }

        #endregion

        #region --- IMouseDriver Members ---

        public IList<Mouse> Mouse
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
            Mouse m = mice[0];
            bool pressed = e.type == XEventName.ButtonPress;
            if ((e.state & (int)X11.MouseMask.Button1Mask) != 0) m[OpenTK.Input.MouseButton.Button1] = pressed;
            if ((e.state & (int)X11.MouseMask.Button2Mask) != 0) m[OpenTK.Input.MouseButton.Button2] = pressed;
            if ((e.state & (int)X11.MouseMask.Button3Mask) != 0) m[OpenTK.Input.MouseButton.Button3] = pressed;
            if ((e.state & (int)X11.MouseMask.Button4Mask) != 0) m[OpenTK.Input.MouseButton.Button4] = pressed;
            if ((e.state & (int)X11.MouseMask.Button5Mask) != 0) m[OpenTK.Input.MouseButton.Button5] = pressed;
            return true;
        }

        /// <summary>
        /// Processes XMotionEvents.
        /// </summary>
        /// <param name="e">The X11.XMotionEvent to process.</param>
        /// <returns>True if the event was processed, false otherwise.</returns>
        internal bool ProcessMotion(ref X11.XMotionEvent e)
        {
            Mouse m = mice[0];
            m.X = e.x;
            m.Y = e.y;
            return true;
        }
    }
}
