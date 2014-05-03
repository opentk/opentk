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
        readonly bool[] button_state = new bool[Enum.GetValues(typeof(MouseButton)).Length];
        float wheel, last_wheel;
        Point pos = new Point(), last_pos = new Point();
        MouseMoveEventArgs move_args = new MouseMoveEventArgs();
        MouseButtonEventArgs button_args = new MouseButtonEventArgs();
        MouseWheelEventArgs wheel_args = new MouseWheelEventArgs();
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
            get { return (int)Math.Round(wheel, MidpointRounding.AwayFromZero); }
            internal set { WheelPrecise = value; }
        }

        /// <summary>
        /// Gets the absolute wheel position in floating-point units.
        /// </summary>
        public float WheelPrecise
        {
            get { return wheel; }
            internal set
            {
                wheel = value;

                wheel_args.X = pos.X;
                wheel_args.Y = pos.Y;
                wheel_args.ValuePrecise = wheel;
                wheel_args.DeltaPrecise = wheel - last_wheel;

                WheelChanged(this, wheel_args);

                last_wheel = wheel;
            }
        }

        #endregion

        #region public int X

        /// <summary>
        /// Gets an integer representing the absolute x position of the pointer, in window pixel coordinates.
        /// </summary>
        public int X
        {
            get { return pos.X; }
        }

        #endregion

        #region public int Y

        /// <summary>
        /// Gets an integer representing the absolute y position of the pointer, in window pixel coordinates.
        /// </summary>
        public int Y
        {
            get { return pos.Y; }
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
                return button_state[(int)button];
            }
            internal set
            {
                bool previous_state = button_state[(int)button];
                button_state[(int)button] = value;

                button_args.X = pos.X;
                button_args.Y = pos.Y;
                button_args.Button = button;
                button_args.IsPressed = value;
                if (value && !previous_state)
                    ButtonDown(this, button_args);
                else if (!value && previous_state)
                    ButtonUp(this, button_args);
            }
        }

        #endregion

        #endregion

        #region --- Internal Members ---

        #region internal Point Position

        /// <summary>
        /// Sets a System.Drawing.Point representing the absolute position of the pointer, in window pixel coordinates.
        /// </summary>
        internal Point Position
        {
            get
            {
                return pos;
            }
            set
            {
                pos = value;
                move_args.X = pos.X;
                move_args.Y = pos.Y;
                move_args.XDelta = pos.X - last_pos.X;
                move_args.YDelta = pos.Y - last_pos.Y;
                Move(this, move_args);
                last_pos = pos;
            }
        }

        #endregion

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
                int result = (int)Math.Round(wheel - wheel_last_accessed, MidpointRounding.AwayFromZero);
                wheel_last_accessed = (int)wheel;
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
                int result = pos.X - pos_last_accessed.X;
                pos_last_accessed.X = pos.X;
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
                int result = pos.Y - pos_last_accessed.Y;
                pos_last_accessed.Y = pos.Y;
                return result;
            }
        }

        #endregion

#endif

        #endregion
    }
}
