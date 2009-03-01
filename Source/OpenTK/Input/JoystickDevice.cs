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
        List<float> axis = new List<float>();
        List<bool> button = new List<bool>();
        IList<float> axis_readonly;
        IList<bool> button_readonly;
        JoystickMoveEventArgs move_args = new JoystickMoveEventArgs(0, 0, 0);
        JoystickButtonEventArgs button_args = new JoystickButtonEventArgs(0, false);

        #endregion

        #region Constructors

        internal JoystickDevice(int id, int axes, int buttons)
        {
            if (axes <= 0)
                throw new ArgumentOutOfRangeException("axes");

            if (buttons <= 0)
                throw new ArgumentOutOfRangeException("buttons");

            Id = id;
            axis.AddRange(new float[axes]);
            button.AddRange(new bool[buttons]);

            axis_readonly = axis.AsReadOnly();
            button_readonly = button.AsReadOnly();
        }

        #endregion

        #region Public Members

        /// <summary>
        /// Gets a readonly IList containing the state of each axis on this instance. Values are normalized in the [-1, 1] range.
        /// </summary>
        public IList<float> Axis { get { return axis_readonly; } }

        /// <summary>
        /// Gets a readonly IList containing the state of each button on this instance. True indicates that the button is pressed.
        /// </summary>
        public IList<bool> Button { get { return button_readonly; } }

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

        internal void SetAxis(int num, float @value)
        {
            move_args.Index = num;
            move_args.Delta = move_args.Value - @value;
            axis[num] = move_args.Value = @value;
            Move(this, move_args);
        }

        internal void SetButton(int num, bool @value)
        {
            if (button[num] != @value)
            {
                button_args.Button = num;
                button[num] = button_args.Pressed = @value;
                if (@value)
                    ButtonDown(this, button_args);
                else
                    ButtonUp(this, button_args);
            }
        }

        #endregion
    }

    #region JoystickDevice<TDetail> : JoystickDevice

    // Provides platform-specific information about the relevant JoystickDevice.
    internal sealed class JoystickDevice<TDetail> : JoystickDevice
    {
        TDetail details;

        internal JoystickDevice(int id, int axes, int buttons)
            : base(id, axes, buttons)
        { }

        internal TDetail Details { get { return details; } set { details = value; } }
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

        int button;
        bool pressed;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="JoystickButtonEventArgs"/> class.
        /// </summary>
        /// <param name="button">The index of the joystick button for the event.</param>
        /// <param name="pressed">The current state of the button.</param>
        internal JoystickButtonEventArgs(int button, bool pressed)
        {
            this.button = button;
            this.pressed = pressed;
        }

        #endregion

        #region Public Members

        /// <summary>
        /// The index of the joystick button for the event.
        /// </summary>
        public int Button { get { return this.button; } internal set { this.button = value; } }

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

        int index;
        float value;
        float delta;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="JoystickMoveEventArgs"/> class.
        /// </summary>
        /// <param name="index">The index of the joystick axis that was moved.</param>
        /// <param name="value">The absolute value of the joystick axis.</param>
        /// <param name="delta">The relative change in value of the joystick axis.</param>
        public JoystickMoveEventArgs(int index, float value, float delta)
        {
            this.index = index;
            this.value = value;
            this.delta = delta;
        }

        #endregion

        #region Public Members

        /// <summary>
        /// Gets a System.Int32 representing the index of the axis that was moved.
        /// </summary>
        public int Index { get { return index; } internal set { this.index = value; } }

        /// <summary>
        /// Gets a System.Single representing the absolute position of the axis.
        /// </summary>
        public float Value { get { return value; } internal set { this.value = value; } }

        /// <summary>
        /// Gets a System.Single representing the relative change in the position of the axis.
        /// </summary>
        public float Delta { get { return delta; } internal set { this.delta = delta; } }

        #endregion
    }

    #endregion
}
