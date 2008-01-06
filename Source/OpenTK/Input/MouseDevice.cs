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
        private int wheel, last_wheel;
        private Point pos = new Point();
        internal int last_x, last_y;

        #region --- IInputDevice Members ---

        /// <summary>
        /// Gets a string describing this MouseDevice.
        /// </summary>
        public string Description
        {
            get { return description; }
            internal set { description = value; }
        }

        /// <summary>
        /// Gets an value indicating the InputDeviceType of this InputDevice. 
        /// </summary>
        public InputDeviceType DeviceType
        {
            get { return InputDeviceType.Mouse; }
        }

        #endregion

        #region --- Public Members ---

        /// <summary>
        /// Gets an integer representing the number of buttons on this MouseDevice.
        /// </summary>
        public int NumberOfButtons
        {
            get { return numButtons; }
            internal set { numButtons = value; }
        }

        /// <summary>
        /// Gets an integer representing the number of wheels on this MouseDevice.
        /// </summary>
        public int NumberOfWheels
        {
            get { return numWheels; }
            internal set { numWheels = value; }
        }

        /// <summary>
        /// Gets an IntPtr representing a device dependent ID.
        /// </summary>
        public IntPtr DeviceID
        {
            get { return id; }
            internal set { id = value; }
        }

        /// <summary>
        /// Gets an integer representing the absolute wheel position.
        /// </summary>
        public int Wheel
        {
            get { return wheel; }
            internal set
            {
                last_wheel = wheel;
                wheel = value;
            }
        }

        /// <summary>
        /// Gets an integer representing the relative wheel movement.
        /// </summary>
        public int WheelDelta
        {
            get
            {
                return wheel - last_wheel;
            }
            //internal set { wheel_delta = value; }
        }

        /// <summary>
        /// Gets an integer representing the absolute x position of the pointer, in screen pixel coordinates.
        /// </summary>
        public int X
        {
            get { return pos.X; }
            internal set
            {
                last_x = pos.X;
                pos.X = value;
            }
        }

        /// <summary>
        /// Gets an integer representing the absolute y position of the pointer, in screen pixel coordinates.
        /// </summary>
        public int Y
        {
            get { return pos.Y; }
            internal set
            {
                last_y = pos.Y;
                pos.Y = value;
            }
        }

        /// <summary>
        /// Gets an integer representing the relative x movement of the pointer, in pixel coordinates.
        /// </summary>
        public int XDelta
        {
            get
            {
                //return delta_x;
                return pos.X - last_x;
            }
            //internal set { delta_x = value; }
        }

        /// <summary>
        /// Gets an integer representing the relative y movement of the pointer, in pixel coordinates.
        /// </summary>
        public int YDelta
        {
            get
            {
                //return delta_y;
                return pos.Y - last_y;
            }
            //internal set { delta_y = value; }
        }

        #region public Point Position

        /// <summary>
        /// Gets a System.Drawing.Point representing the absolute position of the pointer, in screen pixel coordinates.
        /// </summary>
        public Point Position
        {
            get { return pos; }
        }

        #endregion

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
                {
                    ButtonDown(this, b);
                }
                else if (ButtonUp != null && !value && button[(int)b])
                {
                    ButtonUp(this, b);
                }
                button[(int)b] = value;
                //System.Diagnostics.Debug.Print("Mouse button {0} {1}", b, value ? "down" : "up");
            }
        }

        #endregion

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
    }

    //public delegate void MouseMoveEvent(MouseDevice sender, MouseMoveData key);
    public delegate void MouseButtonDownEvent(MouseDevice sender, MouseButton button);
    public delegate void MouseButtonUpEvent(MouseDevice sender, MouseButton button);

    #region public enum MouseButton

    /// <summary>
    /// Enumerates all possible mouse buttons.
    /// </summary>
    public enum MouseButton
    {
        Left = 0,
        Middle,
        Right,
        Button1,
        Button2,
        Button3,
        Button4,
        Button5,
        Button6,
        Button7,
        Button8,
        Button9,
        LastButton
    }

    #endregion

    #region internal class MouseMoveData

    /// <summary>
    /// Not used yet.
    /// </summary>
    internal class MouseMoveData
    {
        private int x;
        private int y;
        private int deltaX;
        private int deltaY;
        private int wheel, deltaWheel;

        /// <summary>
        /// Gets the absolute X position of the mouse in screen pixel coordinates.
        /// </summary>
        public int X
        {
            get { return x; }
            internal set { x = value; }
        }

        /// <summary>
        /// Gets the absolute Y position of the mouse in screen pixel coordinates.
        /// </summary>
        public int Y
        {
            get { return y; }
            internal set { y = value; }
        }

        /// <summary>
        /// Gets the relative movement of the mouse in the X direction, in pixels.
        /// </summary>
        public int DeltaX
        {
            get { return deltaX; }
            internal set { deltaX = value; }
        }

        /// <summary>
        /// Gets the relative movement of the mouse in the Y direction, in pixels.
        /// </summary>
        public int DeltaY
        {
            get { return deltaY; }
            internal set { deltaY = value; }
        }

        /// <summary>
        /// Gets data relevant to the mouse wheel.
        /// </summary>
        //public MouseWheel Wheel
        //{
        //    get { return wheel; }
        //    internal set { wheel = value; }
        //}
    }

    #endregion
}
