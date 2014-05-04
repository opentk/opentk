#define COMPAT_REV1519 // Keeps compatibility with revision 1519

 #region License
 //
 // The Open Toolkit Library License
 //
 // Copyright (c) 2006 - 2009 the Open Toolkit library.
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
using System.ComponentModel;
#if !MINIMAL
using System.Drawing;
#endif
using System.Text;


namespace OpenTK.Input
{
    /// <summary>
    /// Represents a mouse device and provides methods to query its status.
    /// </summary>
    public sealed class MouseDevice : IInputDevice
    {
        #region --- Fields ---

        string description;
        IntPtr id;
        int numButtons, numWheels;

        MouseState state;
#if COMPAT_REV1519
        int wheel_last_accessed = 0;
        Point pos_last_accessed = new Point();
#endif

        #endregion

        #region --- IInputDevice Members ---

        #region public string Description

        /// <summary>
        /// Gets a string describing this MouseDevice.
        /// </summary>
        public string Description
        {
            get { return description; }
            internal set { description = value; }
        }

        #endregion

        #region public InputDeviceType DeviceType

        /// <summary>
        /// Gets a value indicating the InputDeviceType of this InputDevice. 
        /// </summary>
        public InputDeviceType DeviceType
        {
            get { return InputDeviceType.Mouse; }
        }

        #endregion

        #endregion

        #region --- Public Members ---

        #region public int NumberOfButtons

        /// <summary>
        /// Gets an integer representing the number of buttons on this MouseDevice.
        /// </summary>
        public int NumberOfButtons
        {
            get { return numButtons; }
            internal set { numButtons = value; }
        }

        #endregion

        #region public int NumberOfWheels

        /// <summary>
        /// Gets an integer representing the number of wheels on this MouseDevice.
        /// </summary>
        public int NumberOfWheels
        {
            get { return numWheels; }
            internal set { numWheels = value; }
        }

        #endregion

        #region public IntPtr DeviceID

        /// <summary>
        /// Gets an IntPtr representing a device dependent ID.
        /// </summary>
        public IntPtr DeviceID
        {
            get { return id; }
            internal set { id = value; }
        }

        #endregion

        #region public int Wheel

        /// <summary>
        /// Gets the absolute wheel position in integer units.
        /// To support high-precision mice, it is recommended to use <see cref="WheelPrecise"/> instead.
        /// </summary>
        public int Wheel
        {
            get { return state.Wheel; }
        }

        /// <summary>
        /// Gets the absolute wheel position in floating-point units.
        /// </summary>
        public float WheelPrecise
        {
            get { return state.WheelPrecise; }
        }

        #endregion

        #region public int X

        /// <summary>
        /// Gets an integer representing the absolute x position of the pointer, in window pixel coordinates.
        /// </summary>
        public int X
        {
            get { return state.X; }
        }

        #endregion

        #region public int Y

        /// <summary>
        /// Gets an integer representing the absolute y position of the pointer, in window pixel coordinates.
        /// </summary>
        public int Y
        {
            get { return state.Y; }
        }

        #endregion

        #region public bool this[MouseButton b]

        /// <summary>
        /// Gets a System.Boolean indicating the state of the specified MouseButton.
        /// </summary>
        /// <param name="button">The MouseButton to check.</param>
        /// <returns>True if the MouseButton is pressed, false otherwise.</returns>
        public bool this[MouseButton button]
        {
            get
            {
                return state[button];
            }
            internal set
            {
                state[button] = value;
            }
        }

        #endregion

        #endregion

        #region --- Internal Members ---

        internal void HandleMouseDown(object sender, MouseButtonEventArgs e)
        {
            state = e.Mouse;
            ButtonDown(this, e);
        }

        internal void HandleMouseUp(object sender, MouseButtonEventArgs e)
        {
            state = e.Mouse;
            ButtonUp(this, e);
        }

        internal void HandleMouseMove(object sender, MouseMoveEventArgs e)
        {
            state = e.Mouse;
            Move(this, e);
        }

        internal void HandleMouseWheel(object sender, MouseWheelEventArgs e)
        {
            state = e.Mouse;
            WheelChanged(this, e);
        }

        #endregion

        #region --- Events ---

        /// <summary>
        /// Occurs when the mouse's position is moved.
        /// </summary>
        public event EventHandler<MouseMoveEventArgs> Move = delegate { };

        /// <summary>
        /// Occurs when a button is pressed.
        /// </summary>
        public event EventHandler<MouseButtonEventArgs> ButtonDown = delegate { };

        /// <summary>
        /// Occurs when a button is released.
        /// </summary>
        public event EventHandler<MouseButtonEventArgs> ButtonUp = delegate { };

        /// <summary>
        /// Occurs when one of the mouse wheels is moved.
        /// </summary>
        public event EventHandler<MouseWheelEventArgs> WheelChanged = delegate { };

        #region --- Overrides ---

        /// <summary>
        /// Calculates the hash code for this instance.
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return (int)(numButtons ^ numWheels ^ id.GetHashCode() ^ description.GetHashCode());
        }

        /// <summary>
        /// Returns a <see cref="System.String"/> that describes this instance.
        /// </summary>
        /// <returns>A <see cref="System.String"/> that describes this instance.</returns>
        public override string ToString()
        {
            return String.Format("ID: {0} ({1}). Buttons: {2}, Wheels: {3}",
                DeviceID, Description, NumberOfButtons, NumberOfWheels);
        }

        #endregion

        #endregion

        #region COMPAT_REV1519

#if COMPAT_REV1519

        #region public int WheelDelta

        /// <summary>
        /// Gets an integer representing the relative wheel movement.
        /// </summary>
        [Obsolete("WheelDelta is only defined for a single WheelChanged event.  Use the OpenTK.Input.MouseWheelEventArgs::Delta property with the OpenTK.Input.MouseDevice::WheelChanged event.", false)]
        public int WheelDelta
        {
            get
            {
                int result = (int)Math.Round(state.WheelPrecise - wheel_last_accessed, MidpointRounding.AwayFromZero);
                wheel_last_accessed = state.Wheel;
                return result;
            }
        }

        #endregion

        #region public int XDelta

        /// <summary>
        /// Gets an integer representing the relative x movement of the pointer, in pixel coordinates.
        /// </summary>
        [Obsolete("XDelta is only defined for a single Move event.  Use the OpenTK.Input.MouseMoveEventArgs::Delta property with the OpenTK.Input.MouseDevice::Move event.", false)]
        public int XDelta
        {
            get
            {
                int result = state.X - pos_last_accessed.X;
                pos_last_accessed.X = state.X;
                return result;
            }
        }

        #endregion

        #region public int YDelta

        /// <summary>
        /// Gets an integer representing the relative y movement of the pointer, in pixel coordinates.
        /// </summary>
        [Obsolete("YDelta is only defined for a single Move event.  Use the OpenTK.Input.MouseMoveEventArgs::Delta property with the OpenTK.Input.MouseDevice::Move event.", false)]
        public int YDelta
        {
            get
            {
                int result = state.Y - pos_last_accessed.Y;
                pos_last_accessed.Y = state.Y;
                return result;
            }
        }

        #endregion

#endif

        #endregion
    }
}
