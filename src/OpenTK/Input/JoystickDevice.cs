#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2008 the Open Toolkit library, except where noted.
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

namespace OpenTK.Input
{
    /// <summary>
    /// Represents a joystick device and provides methods to query its status.
    /// </summary>
    public abstract class JoystickDevice : IInputDevice
    {
        #region Fields

        int id;
        string description;
        JoystickAxisCollection axis_collection;
        JoystickButtonCollection button_collection;
        JoystickMoveEventArgs move_args = new JoystickMoveEventArgs(0, 0, 0);
        JoystickButtonEventArgs button_args = new JoystickButtonEventArgs(0, false);

        #endregion

        #region Constructors

        internal JoystickDevice(int id, int axes, int buttons)
        {
            if (axes < 0)
                throw new ArgumentOutOfRangeException("axes");

            if (buttons < 0)
                throw new ArgumentOutOfRangeException("buttons");

            Id = id;
            axis_collection = new JoystickAxisCollection(axes);
            button_collection = new JoystickButtonCollection(buttons);
        }

        #endregion

        #region Public Members

        /// <summary>
        /// Gets a JoystickAxisCollection containing the state of each axis on this instance. Values are normalized in the [-1, 1] range.
        /// </summary>
        public JoystickAxisCollection Axis { get { return axis_collection; } }

        /// <summary>
        /// Gets JoystickButtonCollection containing the state of each button on this instance. True indicates that the button is pressed.
        /// </summary>
        public JoystickButtonCollection Button { get { return button_collection; } }

        #endregion

        #region IInputDevice Members

        /// <summary>
        /// Gets a System.String containing a unique description for this instance.
        /// </summary>
        public string Description
        {
            get { return description; }
            internal set { description = value; }
        }

        /// <summary>
        /// Gets a value indicating the InputDeviceType of this InputDevice. 
        /// </summary>
        public InputDeviceType DeviceType
        {
            get { return InputDeviceType.Hid; }
        }

        #endregion

        #region Events
        
        /// <summary>
        /// Occurs when an axis of this JoystickDevice instance is moved.
        /// </summary>
        public EventHandler<JoystickMoveEventArgs> Move =
            delegate(object sender, JoystickMoveEventArgs e) { };

        /// <summary>
        /// Occurs when a button of this JoystickDevice instance is pressed.
        /// </summary>
        public EventHandler<JoystickButtonEventArgs> ButtonDown =
            delegate(object sender, JoystickButtonEventArgs e) { };

        /// <summary>
        /// Occurs when a button of this JoystickDevice is released.
        /// </summary>
        public EventHandler<JoystickButtonEventArgs> ButtonUp =
            delegate(object sender, JoystickButtonEventArgs e) { };

        #endregion

        #region Internal Members

        internal int Id
        {
            get { return id; }
            set { id = value; }
        }

        internal void SetAxis(JoystickAxis axis, float @value)
        {
            if ((int)axis < axis_collection.Count)
            {
                move_args.Axis = axis;
                move_args.Delta = move_args.Value - @value;
                axis_collection[axis] = move_args.Value = @value;
                Move(this, move_args);
            }
        }

        internal void SetButton(JoystickButton button, bool @value)
        {
            if ((int)button < button_collection.Count)
            {
                if (button_collection[button] != @value)
                {
                    button_args.Button = button;
                    button_collection[button] = button_args.Pressed = @value;
                    if (@value)
                        ButtonDown(this, button_args);
                    else
                        ButtonUp(this, button_args);
                }
            }
        }

        #endregion
    }

    #region JoystickDevice<TDetail> : JoystickDevice

    // Provides platform-specific information about the relevant JoystickDevice.
    internal class JoystickDevice<TDetail> : JoystickDevice
        where TDetail : new()
    {
        internal JoystickDevice(int id, int axes, int buttons)
            : base(id, axes, buttons)
        { }

        internal TDetail Details = new TDetail();
    }

    #endregion

    #region Event Arguments

    /// <summary>
    /// The base class for JoystickDevice event arguments.
    /// </summary>
    public class JoystickEventArgs : EventArgs
    {
    }

    /// <summary>
    /// Provides data for the <see cref="JoystickDevice.ButtonDown"/> and <see cref="JoystickDevice.ButtonUp"/> events.
    /// This class is cached for performance reasons - avoid storing references outside the scope of the event.
    /// </summary>
    public class JoystickButtonEventArgs : EventArgs
    {
        #region Fields

        JoystickButton button;
        bool pressed;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="JoystickButtonEventArgs"/> class.
        /// </summary>
        /// <param name="button">The index of the joystick button for the event.</param>
        /// <param name="pressed">The current state of the button.</param>
        internal JoystickButtonEventArgs(JoystickButton button, bool pressed)
        {
            this.button = button;
            this.pressed = pressed;
        }

        #endregion

        #region Public Members

        /// <summary>
        /// The index of the joystick button for the event.
        /// </summary>
        public JoystickButton Button { get { return this.button; } internal set { this.button = value; } }

        /// <summary>
        /// Gets a System.Boolean representing the state of the button for the event.
        /// </summary>
        public bool Pressed { get { return pressed; } internal set { this.pressed = value; } }

        #endregion
    }

    /// <summary>
    /// Provides data for the <see cref="JoystickDevice.Move"/> event.
    /// This class is cached for performance reasons - avoid storing references outside the scope of the event.
    /// </summary>
    public class JoystickMoveEventArgs : JoystickEventArgs
    {
        #region Fields

        JoystickAxis axis;
        float value;
        float delta;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="JoystickMoveEventArgs"/> class.
        /// </summary>
        /// <param name="axis">The index of the joystick axis that was moved.</param>
        /// <param name="value">The absolute value of the joystick axis.</param>
        /// <param name="delta">The relative change in value of the joystick axis.</param>
        public JoystickMoveEventArgs(JoystickAxis axis, float value, float delta)
        {
            this.axis = axis;
            this.value = value;
            this.delta = delta;
        }

        #endregion

        #region Public Members

        /// <summary>
        /// Gets a System.Int32 representing the index of the axis that was moved.
        /// </summary>
        public JoystickAxis Axis { get { return axis; } internal set { this.axis = value; } }

        /// <summary>
        /// Gets a System.Single representing the absolute position of the axis.
        /// </summary>
        public float Value { get { return value; } internal set { this.value = value; } }

        /// <summary>
        /// Gets a System.Single representing the relative change in the position of the axis.
        /// </summary>
        public float Delta { get { return delta; } internal set { this.delta = value; } }

        #endregion
    }

    #endregion

    #region JoystickButtonCollection

    /// <summary>
    /// Defines a collection of JoystickButtons.
    /// </summary>
    public sealed class JoystickButtonCollection
    {
        #region Fields

        bool[] button_state;

        #endregion

        #region Constructors

        internal JoystickButtonCollection(int numButtons)
        {
            if (numButtons < 0)
                throw new ArgumentOutOfRangeException("numButtons");

            button_state = new bool[numButtons];
        }

        #endregion

        #region Public Members

        /// <summary>
        /// Gets a System.Boolean indicating whether the JoystickButton with the specified index is pressed.
        /// </summary>
        /// <param name="index">The index of the JoystickButton to check.</param>
        /// <returns>True if the JoystickButton is pressed; false otherwise.</returns>
        public bool this[int index]
        {
            get { return button_state[index]; }
            internal set { button_state[index] = value; }
        }

        /// <summary>
        /// Gets a System.Boolean indicating whether the specified JoystickButton is pressed.
        /// </summary>
        /// <param name="button">The JoystickButton to check.</param>
        /// <returns>True if the JoystickButton is pressed; false otherwise.</returns>
        public bool this[JoystickButton button]
        {
            get { return button_state[(int)button]; }
            internal set { button_state[(int)button] = value; }
        }

        /// <summary>
        /// Gets a System.Int32 indicating the available amount of JoystickButtons.
        /// </summary>
        public int Count
        {
            get { return button_state.Length; }
        }

        #endregion
    }

    #endregion

    #region JoystickAxisCollection

    /// <summary>
    /// Defines a collection of JoystickAxes.
    /// </summary>
    public sealed class JoystickAxisCollection
    {
        #region Fields

        float[] axis_state;

        #endregion

        #region Constructors

        internal JoystickAxisCollection(int numAxes)
        {
            if (numAxes < 0)
                throw new ArgumentOutOfRangeException("numAxes");

            axis_state = new float[numAxes];
        }

        #endregion

        #region Public Members

        /// <summary>
        /// Gets a System.Single indicating the absolute position of the JoystickAxis with the specified index.
        /// </summary>
        /// <param name="index">The index of the JoystickAxis to check.</param>
        /// <returns>A System.Single in the range [-1, 1].</returns>
        public float this[int index]
        {
            get { return axis_state[index]; }
            internal set { axis_state[index] = value; }
        }

        /// <summary>
        /// Gets a System.Single indicating the absolute position of the JoystickAxis.
        /// </summary>
        /// <param name="axis">The JoystickAxis to check.</param>
        /// <returns>A System.Single in the range [-1, 1].</returns>
        public float this[JoystickAxis axis]
        {
            get { return axis_state[(int)axis]; }
            internal set { axis_state[(int)axis] = value; }
        }

        /// <summary>
        /// Gets a System.Int32 indicating the available amount of JoystickAxes.
        /// </summary>
        public int Count
        {
            get { return axis_state.Length; }
        }

        #endregion
    }

    #endregion
}
