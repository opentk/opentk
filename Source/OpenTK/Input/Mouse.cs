#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Input
{
    public sealed class Mouse : IMouse
    {
        private string description;
        private int numButtons, numWheels;
        private IntPtr id;
        private bool[] button = new bool[(int)MouseButton.LastButton];
        private int wheel, x, y, wheel_delta, delta_x, delta_y;

        #region --- IInputDevice Members ---

        public string Description
        {
            get { return description; }
            internal set { description = value; }
        }

        public InputDeviceType DeviceType
        {
            get { return InputDeviceType.Mouse; }
        }

        #endregion

        #region --- IMouse Members ---

        public int NumberOfButtons
        {
            get { return numButtons; }
            internal set { numButtons = value; }
        }

        public int NumberOfWheels
        {
            get { return numWheels; }
            internal set { numWheels = value; }
        }

        public IntPtr DeviceID
        {
            get { return id; }
            internal set { id = value; }
        }

        public int Wheel
        {
            get { return wheel; }
            internal set
            {
                wheel = value;
            }
        }

        internal int WheelDelta
        {
            get
            {
                int delta = wheel_delta;
                //wheel_delta = 0;
                return delta;
            }
            set
            {
                wheel_delta = value;
            }
        }

        public int X
        {
            get { return x; }
            internal set { x = value; }
        }

        public int Y
        {
            get { return y; }
            internal set { y = value; }
        }

        public int XDelta
        {
            get { return delta_x; }
            internal set { delta_x = value; }
        }

        public int YDelta
        {
            get { return delta_y; }
            internal set { delta_y = value; }
        }

        public event MouseMoveEvent Move;
        public event MouseButtonDownEvent ButtonDown;
        public event MouseButtonUpEvent ButtonUp;

        #endregion

        #region public bool this[MouseButton b]

        public bool this[MouseButton b]
        {
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
            }

            get
            {
                return button[(int)b];
            }
        }

        #endregion
    }

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

    public class MouseWheel
    {
        private int position;
        private int delta;

        /// <summary>
        /// Gets the absolute position of the mouse wheel.
        /// </summary>
        public int Position
        {
            get { return position; }
            internal set { position = value; }
        }

        /// <summary>
        /// Gets the relative movement of the mouse wheel.
        /// </summary>
        public int Delta
        {
            get { return delta; }
            internal set { delta = value; }
        }
    }

    public class MouseMoveData
    {
        private int x;
        private int y;
        private int deltaX;
        private int deltaY;
        private MouseWheel wheel;

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
        public MouseWheel Wheel
        {
            get { return wheel; }
            internal set { wheel = value; }
        }
    }
}
