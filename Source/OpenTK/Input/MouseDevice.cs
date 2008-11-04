#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace OpenTK.Input
{
    /// <summary>
    /// Represents a mouse device and provides methods to query its status.
    /// </summary>
    public sealed class MouseDevice : IInputDevice
    {
        private string description;
        private int numButtons, numWheels;
        private IntPtr id;
        private bool[] button = new bool[(int)MouseButton.LastButton];
        private int wheel, wheel_last_accessed = 0;
        private Point pos = new Point();
        private Point pos_last_accessed = new Point();
        internal int last_x, last_y;

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
        /// Gets an integer representing the absolute wheel position.
        /// </summary>
        public int Wheel
        {
            get { return wheel; }
            internal set
            {
                wheel = value;
                //if (Move != null)
                //    Move(this, EventArgs.Empty);
            }
        }

        #endregion

        #region public int WheelDelta

        /// <summary>
        /// Gets an integer representing the relative wheel movement.
        /// </summary>
        public int WheelDelta
        {
            get
            {
                int result = wheel - wheel_last_accessed;
                wheel_last_accessed = wheel;
                return result;
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

        #region public int XDelta

        /// <summary>
        /// Gets an integer representing the relative x movement of the pointer, in pixel coordinates.
        /// </summary>
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

        #region internal Point Position

        /// <summary>
        /// Sets a System.Drawing.Point representing the absolute position of the pointer, in window pixel coordinates.
        /// </summary>
        internal Point Position
        {
            set
            {
                pos = value;
                //if (Move != null)
                //    Move(this, EventArgs.Empty);
            }
        }

        #endregion

        ///// <summary>
        /// Occurs when the mouse, or one of its wheels, is moved.
        /// </summary>
        //public event MouseMoveEvent Move;

        /// <summary>
        /// Occurs when a button is pressed.
        /// </summary>
        public event MouseButtonDownEvent ButtonDown;

        /// <summary>
        /// Occurs when a button is released.
        /// </summary>
        public event MouseButtonUpEvent ButtonUp;

        #region public bool this[MouseButton b]

        /// <summary>
        /// Gets a value indicating the status of the specified MouseButton.
        /// </summary>
        /// <param name="key">The MouseButton to check.</param>
        /// <returns>True if the MouseButton is pressed, false otherwise.</returns>
        public bool this[MouseButton b]
        {
            get
            {
                return button[(int)b];
            }
            internal set
            {
                if (ButtonDown != null && value && !button[(int)b])
                    ButtonDown(this, b);
                else if (ButtonUp != null && !value && button[(int)b])
                    ButtonUp(this, b);
                button[(int)b] = value;

                //System.Diagnostics.Debug.Print("Mouse button {0} {1}", b, value ? "down" : "up");
            }
        }

        #endregion

        #region --- Overrides ---

        public override int GetHashCode()
        {
            //return base.GetHashCode();
            return (int)(numButtons ^ numWheels ^ id.GetHashCode() ^ description.GetHashCode());
        }

        public override string ToString()
        {
            return String.Format("ID: {0} ({1}). Buttons: {2}, Wheels: {3}",
                DeviceID, Description, NumberOfButtons, NumberOfWheels);
        }

        #endregion

        #endregion
    }

    /// <summary>
    /// Defines a MouseMove event.
    /// </summary>
    /// <param name="sender">The MouseDevice that generated this event.</param>
    /// <param name="e">Not used.</param>
    public delegate void MouseMoveEvent(MouseDevice sender, EventArgs e);

    /// <summary>
    /// Defines the MouseButtonDown event.
    /// </summary>
    /// <param name="sender">The MouseDevice that generated this event.</param>
    /// <param name="button">The MouseButton that was pressed.</param>
    public delegate void MouseButtonDownEvent(MouseDevice sender, MouseButton button);

    /// <summary>
    /// Defines the MouseButtonUp event.
    /// </summary>
    /// <param name="sender">The MouseDevice that generated this event.</param>
    /// <param name="button">The MouseButton that was released.</param>
    public delegate void MouseButtonUpEvent(MouseDevice sender, MouseButton button);
}
