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
            get { return (int)(wheel + 0.5f); }
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
                int result = (int)(wheel - wheel_last_accessed + 0.5f);
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

    #region Event Arguments

    /// <summary>
    /// Defines the event data for <see cref="MouseDevice"/> events.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Do not cache instances of this type outside their event handler.
    /// If necessary, you can clone an instance using the 
    /// <see cref="MouseEventArgs(MouseEventArgs)"/> constructor.
    /// </para>
    /// </remarks>
    public class MouseEventArgs : EventArgs
    {
        #region Fields

        int x, y;

        #endregion

        #region Constructors

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public MouseEventArgs()
        {
        }

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        /// <param name="x">The X position.</param>
        /// <param name="y">The Y position.</param>
        public MouseEventArgs(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        /// <param name="args">The <see cref="MouseEventArgs"/> instance to clone.</param>
        public MouseEventArgs(MouseEventArgs args)
            : this(args.x, args.y)
        {
        }

        #endregion

        #region Public Members

        /// <summary>
        /// Gets the X position of the mouse for the event.
        /// </summary>
        public int X { get { return x; } internal set { x = value; } }

        /// <summary>
        /// Gets the Y position of the mouse for the event.
        /// </summary>
        public int Y { get { return y; } internal set { y = value; } }

        /// <summary>
        /// Gets a System.Drawing.Points representing the location of the mouse for the event.
        /// </summary>
        public Point Position { get { return new Point(x, y); } }

        #endregion
    }

    /// <summary>
    /// Defines the event data for <see cref="MouseDevice.Move"/> events.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Do not cache instances of this type outside their event handler.
    /// If necessary, you can clone an instance using the 
    /// <see cref="MouseMoveEventArgs(MouseMoveEventArgs)"/> constructor.
    /// </para>
    /// </remarks>
    public class MouseMoveEventArgs : MouseEventArgs
    {
        #region Fields

        int x_delta, y_delta;

        #endregion

        #region Constructors

        /// <summary>
        /// Constructs a new <see cref="MouseMoveEventArgs"/> instance.
        /// </summary>
        public MouseMoveEventArgs() { }

        /// <summary>
        /// Constructs a new <see cref="MouseMoveEventArgs"/> instance.
        /// </summary>
        /// <param name="x">The X position.</param>
        /// <param name="y">The Y position.</param>
        /// <param name="xDelta">The change in X position produced by this event.</param>
        /// <param name="yDelta">The change in Y position produced by this event.</param>
        public MouseMoveEventArgs(int x, int y, int xDelta, int yDelta)
            : base(x, y)
        {
            XDelta = xDelta;
            YDelta = yDelta;
        }

        /// <summary>
        /// Constructs a new <see cref="MouseMoveEventArgs"/> instance.
        /// </summary>
        /// <param name="args">The <see cref="MouseMoveEventArgs"/> instance to clone.</param>
        public MouseMoveEventArgs(MouseMoveEventArgs args)
            : this(args.X, args.Y, args.XDelta, args.YDelta)
        {
        }

        #endregion

        #region Public Members

        /// <summary>
        /// Gets the change in X position produced by this event.
        /// </summary>
        public int XDelta { get { return x_delta; } internal set { x_delta = value; } }

        /// <summary>
        /// Gets the change in Y position produced by this event.
        /// </summary>
        public int YDelta { get { return y_delta; } internal set { y_delta = value; } }

        #endregion
    }

    /// <summary>
    /// Defines the event data for <see cref="MouseDevice.ButtonDown"/> and <see cref="MouseDevice.ButtonUp"/> events.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Do not cache instances of this type outside their event handler.
    /// If necessary, you can clone an instance using the 
    /// <see cref="MouseButtonEventArgs(MouseButtonEventArgs)"/> constructor.
    /// </para>
    /// </remarks>
    public class MouseButtonEventArgs : MouseEventArgs
    {
        #region Fields

        MouseButton button;
        bool pressed;

        #endregion

        #region Constructors

        /// <summary>
        /// Constructs a new <see cref="MouseButtonEventArgs"/> instance.
        /// </summary>
        public MouseButtonEventArgs() { }

        /// <summary>
        /// Constructs a new <see cref="MouseButtonEventArgs"/> instance.
        /// </summary>
        /// <param name="x">The X position.</param>
        /// <param name="y">The Y position.</param>
        /// <param name="button">The mouse button for the event.</param>
        /// <param name="pressed">The current state of the button.</param>
        public MouseButtonEventArgs(int x, int y, MouseButton button, bool pressed)
            : base(x, y)
        {
            this.button = button;
            this.pressed = pressed;
        }

        /// <summary>
        /// Constructs a new <see cref="MouseButtonEventArgs"/> instance.
        /// </summary>
        /// <param name="args">The <see cref="MouseButtonEventArgs"/> instance to clone.</param>
        public MouseButtonEventArgs(MouseButtonEventArgs args)
            : this(args.X, args.Y, args.Button, args.IsPressed)
        {
        }

        #endregion

        #region Public Members

        /// <summary>
        /// The mouse button for the event.
        /// </summary>
        public MouseButton Button { get { return button; } internal set { button = value; } }

        /// <summary>
        /// Gets a System.Boolean representing the state of the mouse button for the event.
        /// </summary>
        public bool IsPressed { get { return pressed; } internal set { pressed = value; } }

        #endregion
    }

    /// <summary>
    /// Defines the event data for <see cref="MouseDevice.WheelChanged"/> events.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Do not cache instances of this type outside their event handler.
    /// If necessary, you can clone an instance using the 
    /// <see cref="MouseWheelEventArgs(MouseWheelEventArgs)"/> constructor.
    /// </para>
    /// </remarks>
    public class MouseWheelEventArgs : MouseEventArgs
    {
        #region Fields

        float value;
        float delta;

        #endregion

        #region Constructors

        /// <summary>
        /// Constructs a new <see cref="MouseWheelEventArgs"/> instance.
        /// </summary>
        public MouseWheelEventArgs() { }

        /// <summary>
        /// Constructs a new <see cref="MouseWheelEventArgs"/> instance.
        /// </summary>
        /// <param name="x">The X position.</param>
        /// <param name="y">The Y position.</param>
        /// <param name="value">The value of the wheel.</param>
        /// <param name="delta">The change in value of the wheel for this event.</param>
        public MouseWheelEventArgs(int x, int y, int value, int delta)
            : base(x, y)
        {
            this.value = value;
            this.delta = delta;
        }

        /// <summary>
        /// Constructs a new <see cref="MouseWheelEventArgs"/> instance.
        /// </summary>
        /// <param name="args">The <see cref="MouseWheelEventArgs"/> instance to clone.</param>
        public MouseWheelEventArgs(MouseWheelEventArgs args)
            : this(args.X, args.Y, args.Value, args.Delta)
        {
        }

        #endregion

        #region Public Members

        /// <summary>
        /// Gets the value of the wheel in integer units.
        /// To support high-precision mice, it is recommended to use <see cref="ValuePrecise"/> instead.
        /// </summary>
        public int Value { get { return (int)(value + 0.5f); } }

        /// <summary>
        /// Gets the change in value of the wheel for this event in integer units.
        /// To support high-precision mice, it is recommended to use <see cref="DeltaPrecise"/> instead.
        /// </summary>
        public int Delta { get { return (int)(delta + 0.5f); } }

        /// <summary>
        /// Gets the precise value of the wheel in floating-point units.
        /// </summary>
        public float ValuePrecise { get { return value; } internal set { this.value = value; } }

        /// <summary>
        /// Gets the precise change in value of the wheel for this event in floating-point units.
        /// </summary>
        public float DeltaPrecise { get { return delta; } internal set { delta = value; } }

        #endregion
    }

    #endregion
}
