#define COMPAT_REV1519 // Keeps compatibility with revision 1519

#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.ComponentModel;

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
        int wheel, last_wheel;
        Point pos = new Point(), last_pos = new Point();
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
        /// Gets an integer representing the absolute wheel position.
        /// </summary>
        public int Wheel
        {
            get { return wheel; }
            internal set
            {
                wheel = value;
                if (WheelChanged != null)
                    WheelChanged(
                        this,
                        new MouseWheelEventArgs(
                            pos.X,
                            pos.Y,
                            wheel,
                            wheel - last_wheel
                        )
                    );
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

                MouseButtonEventArgs e = new MouseButtonEventArgs(pos.X, pos.Y, button, value);
                if (value && !previous_state)
                    ButtonDown(this, e);
                else if (!value && previous_state)
                    ButtonUp(this, e);
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
            set
            {
                pos = value;
                Move(this, new MouseMoveEventArgs(pos.X, pos.Y, pos.X - last_pos.X, pos.Y - last_pos.Y));
                last_pos = pos;
            }
        }

        #endregion

        #endregion

        #region --- Events ---

        /// <summary>
        /// Occurs when the mouse's position is moved.
        /// </summary>
        public event MouseMoveEventHandler Move = delegate(object sender, MouseMoveEventArgs e) { };

        /// <summary>
        /// Occurs when a button is pressed.
        /// </summary>
        public event MouseButtonEventHandler ButtonDown = delegate(object sender, MouseButtonEventArgs e) { };

        /// <summary>
        /// Occurs when a button is released.
        /// </summary>
        public event MouseButtonEventHandler ButtonUp = delegate(object sender, MouseButtonEventArgs e) { };

        /// <summary>
        /// Occurs when one of the mouse wheels is moved.
        /// </summary>
        public event MouseWheelEventHandler WheelChanged = delegate(object sender, MouseWheelEventArgs e) { };

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
                int result = wheel - wheel_last_accessed;
                wheel_last_accessed = wheel;
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

    #region Event Arguments

    public struct MouseMoveEventArgs
    {
        #region Fields

        int x, y;
        int x_delta, y_delta;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MouseMoveEventArgs"/> class.
        /// </summary>
        /// <param name="x">The X position.</param>
        /// <param name="y">The Y position.</param>
        /// <param name="xDelta">The change in X position produced by this event.</param>
        /// <param name="yDelta">The change in Y position produced by this event.</param>
        public MouseMoveEventArgs(int x, int y, int xDelta, int yDelta)
        {
            this.x = x;
            this.y = y;
            this.x_delta = xDelta;
            this.y_delta = yDelta;
        }

        #endregion

        #region Public Members

        /// <summary>
        /// Gets the X position of the mouse for the event.
        /// </summary>
        public int X { get { return x; } }

        /// <summary>
        /// Gets the Y position of the mouse for the event.
        /// </summary>
        public int Y { get { return y; } }

        /// <summary>
        /// Gets a System.Drawing.Points representing the location of the mouse for the event.
        /// </summary>
        public Point Position { get { return new Point(x, y); } }

        /// <summary>
        /// Gets the change in X position produced by this event.
        /// </summary>
        public int XDelta { get { return x_delta; } }

        /// <summary>
        /// Gets the change in Y position produced by this event.
        /// </summary>
        public int YDelta { get { return y_delta; } }

        #endregion
    }

    /// <summary>
    /// Provides data for the <see cref="MouseDevice.ButtonDown"/> and <see cref="MouseDevice.ButtonUp"/> events.
    /// </summary>
    public struct MouseButtonEventArgs
    {
        #region Fields

        MouseButton button;
        bool pressed;
        int x, y;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MouseButtonEventArgs"/> class.
        /// </summary>
        /// <param name="x">The X position.</param>
        /// <param name="y">The Y position.</param>
        /// <param name="button">The mouse button for the event.</param>
        /// <param name="pressed">The current state of the button.</param>
        internal MouseButtonEventArgs(int x, int y, MouseButton button, bool pressed)
        {
            this.x = x;
            this.y = y;
            this.button = button;
            this.pressed = pressed;
        }

        #endregion

        #region Public Members

        /// <summary>
        /// Gets the X position of the mouse for the event.
        /// </summary>
        public int X { get { return x; } }

        /// <summary>
        /// Gets the Y position of the mouse for the event.
        /// </summary>
        public int Y { get { return y; } }

        /// <summary>
        /// Gets a System.Drawing.Points representing the location of the mouse for the event.
        /// </summary>
        public Point Position { get { return new Point(x, y); } }

        /// <summary>
        /// The mouse button for the event.
        /// </summary>
        public MouseButton Button { get { return this.button; } }

        /// <summary>
        /// Gets a System.Boolean representing the state of the mouse button for the event.
        /// </summary>
        public bool IsPressed { get { return pressed; } }

        #endregion
    }

    /// <summary>
    /// Provides data for the <see cref="MouseDevice.WheelChanged"/> event.
    /// </summary>
    public struct MouseWheelEventArgs
    {
        #region Fields

        int value;
        int delta;
        int x, y;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MouseWheelEventArgs"/> class.
        /// </summary>
        /// <param name="x">The X position.</param>
        /// <param name="y">The Y position.</param>
        /// <param name="value">The value of the wheel.</param>
        /// <param name="delta">The change in value of the wheel for this event.</param>
        public MouseWheelEventArgs(int x, int y, int value, int delta)
        {
            this.x = x;
            this.y = y;
            this.value = value;
            this.delta = delta;
        }

        #endregion

        #region Public Members

        /// <summary>
        /// Gets the X position of the mouse for the event.
        /// </summary>
        public int X { get { return x; } }

        /// <summary>
        /// Gets the Y position of the mouse for the event.
        /// </summary>
        public int Y { get { return y; } }

        /// <summary>
        /// Gets a System.Drawing.Points representing the location of the mouse for the event.
        /// </summary>
        public Point Position { get { return new Point(x, y); } }

        /// <summary>
        /// The value of the wheel.
        /// </summary>
        public int Value { get { return value; } }

        /// <summary>
        /// The change in value of the wheel for this event.
        /// </summary>
        public int Delta { get { return delta; } }

        #endregion
    }

    #endregion

    #region Event Handlers

    /// <summary>
    /// Defines a <see cref="MouseDevice.Move"/> event.
    /// </summary>
    /// <param name="sender">The MouseDevice that generated this event.</param>
    /// <param name="e">A <see cref="MouseMoveEventArgs"/> that contains the event data.</param>
    public delegate void MouseMoveEventHandler(object sender, MouseMoveEventArgs e);

    /// <summary>
    /// Defines a <see cref="MouseDevice.WheelChanged"/> event.
    /// </summary>
    /// <param name="sender">The MouseDevice that generated this event.</param>
    /// <param name="e">A <see>MouseWheelEventArgs</see> that contains the event data.</param>
    public delegate void MouseWheelEventHandler(object sender, MouseWheelEventArgs e);

    /// <summary>
    /// Defines the <see cref="MouseDevice.ButtonDown"/> and <see cref="MouseDevice.ButtonUp"/> events.
    /// </summary>
    /// <param name="sender">The MouseDevice that generated this event.</param>
    /// <param name="e">A <see cref="MouseButtonEventArgs"/> that contains the event data.</param>
    public delegate void MouseButtonEventHandler(object sender, MouseButtonEventArgs e);

    #endregion
}
