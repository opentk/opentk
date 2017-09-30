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

using System;
#if !MINIMAL
using System.Drawing;
#endif


namespace OpenTK.Input
{
    /// <summary>
    /// Represents a mouse device and provides methods to query its status.
    /// </summary>
    public sealed class MouseDevice : IInputDevice
    {
        private IntPtr id;

        private MouseState state;

        /// <summary>
        /// Gets a string describing this MouseDevice.
        /// </summary>
        public string Description { get; internal set; }

        /// <summary>
        /// Gets a value indicating the InputDeviceType of this InputDevice.
        /// </summary>
        public InputDeviceType DeviceType
        {
            get { return InputDeviceType.Mouse; }
        }

        /// <summary>
        /// Retrieves the combined hardware <see cref="OpenTK.Input.MouseState"/> for all specified mouse devices.
        /// This method is equivalent to <see cref="OpenTK.Input.Mouse.GetState()"/>.
        /// </summary>
        /// <returns>A <see cref="OpenTK.Input.MouseState"/> structure representing the state for the specified mouse device.</returns>
        /// <seealso cref="OpenTK.Input.Mouse.GetState()"/>
        public MouseState GetState()
        {
            return Mouse.GetState();
        }

        /// <summary>
        /// Retrieves the hardware <see cref="OpenTK.Input.MouseState"/> for the specified mouse device.
        /// This method is equivalent to <see cref="OpenTK.Input.Mouse.GetState(int)"/>.
        /// </summary>
        /// <param name="index">The index of the mouse device.</param>
        /// <returns>A <see cref="OpenTK.Input.MouseState"/> structure representing the state for the specified mouse device.</returns>
        /// <seealso cref="OpenTK.Input.Mouse.GetState(int)"/>
        public MouseState GetState(int index)
        {
            return Mouse.GetState(index);
        }

        /// <summary>
        /// Retreves the <see cref="OpenTK.Input.MouseState"/> for the mouse cursor.
        /// This method is equivalent to <see cref="OpenTK.Input.Mouse.GetCursorState"/>.
        /// </summary>
        /// <returns>A <see cref="OpenTK.Input.MouseState"/> structure representing the state of the mouse cursor.</returns>
        /// <seealso cref="OpenTK.Input.Mouse.GetCursorState()"/>
        public MouseState GetCursorState()
        {
            return Mouse.GetCursorState();
        }

        /// <summary>
        /// Gets an integer representing the number of buttons on this MouseDevice.
        /// </summary>
        public int NumberOfButtons { get; internal set; }

        /// <summary>
        /// Gets an integer representing the number of wheels on this MouseDevice.
        /// </summary>
        public int NumberOfWheels { get; internal set; }

        /// <summary>
        /// Gets an IntPtr representing a device dependent ID.
        /// </summary>
        public IntPtr DeviceID
        {
            get { return id; }
            internal set { id = value; }
        }

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

        /// <summary>
        /// Gets an integer representing the absolute x position of the pointer, in window pixel coordinates.
        /// </summary>
        public int X
        {
            get { return state.X; }
        }

        /// <summary>
        /// Gets an integer representing the absolute y position of the pointer, in window pixel coordinates.
        /// </summary>
        public int Y
        {
            get { return state.Y; }
        }

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

        /// <summary>
        /// Calculates the hash code for this instance.
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return (int)(NumberOfButtons ^ NumberOfWheels ^ id.GetHashCode() ^ Description.GetHashCode());
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
    }
}
