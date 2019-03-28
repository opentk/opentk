//
// MouseEventArgs.cs
//
// Copyright (C) 2018 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using OpenToolkit.Mathematics;
using OpenToolkit.Windowing.Common;
using OpenToolkit.Windowing.Common.Input;

namespace OpenToolkit.Windowing.EventingModels
{
    /// <summary>
    /// Defines base event data for mouse related events events.
    /// </summary>
    /// <remarks>
    ///  <para>
    /// Do not cache instances of this type outside their event handler.
    /// If necessary, you can clone an instance using the
    ///  <see cref="MouseEventArgs(MouseEventArgs)" /> constructor.
    ///  </para>
    /// </remarks>
    public class MouseEventArgs : EventArgs
    {
        private MouseState _state;

        /// <summary>
        /// Initializes a new instance of the <see cref="MouseEventArgs"/> class.
        /// </summary>
        public MouseEventArgs()
        {
            _state.SetIsConnected(true);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MouseEventArgs"/> class.
        /// </summary>
        /// <param name="x">The X position.</param>
        /// <param name="y">The Y position.</param>
        public MouseEventArgs(double x, double y)
            : this()
        {
            _state.X = x;
            _state.Y = y;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MouseEventArgs"/> class.
        /// </summary>
        /// <param name="args">The <see cref="MouseEventArgs" /> instance to clone.</param>
        public MouseEventArgs(MouseEventArgs args)
            : this(args.X, args.Y)
        {
        }

        /// <summary>
        /// Gets the X position of the mouse for the event.
        /// </summary>
        public double X
        {
            get => _state.X;
            internal set => _state.X = value;
        }

        /// <summary>
        /// Gets the Y position of the mouse for the event.
        /// </summary>
        public double Y
        {
            get => _state.Y;
            internal set => _state.Y = value;
        }

        /// <summary>
        /// Gets or sets a <see cref="System.Drawing.Point" /> representing the location of the mouse for the event.
        /// </summary>
        public Vector2d Position
        {
            get => new Vector2d(_state.X, _state.Y);
            set
            {
                X = value.X;
                Y = value.Y;
            }
        }

        /// <summary>
        /// Gets the current <see cref="OpenToolkit.Windowing.Common.Input.MouseState" />.
        /// </summary>
        public MouseState Mouse
        {
            get => _state;
            internal set => _state = value;
        }

        /// <summary>
        /// Sets the button state of a specified button to a given state value.
        /// </summary>
        /// <param name="button">The button state to set.</param>
        /// <param name="state">The value to change the state to.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when <paramref name="button"/> is outside of valid range of [0;<see cref="MouseButton.LastButton"/>].
        /// </exception>
        internal void SetButton(MouseButton button, ButtonState state)
        {
            if (button < 0 || button > MouseButton.LastButton)
            {
                throw new ArgumentOutOfRangeException();
            }

            switch (state)
            {
                case ButtonState.Pressed:
                    this._state.EnableBit((int)button);
                    break;

                case ButtonState.Released:
                    this._state.DisableBit((int)button);
                    break;
            }
        }

        /// <summary>
        /// Gets the button state of a specified button.
        /// </summary>
        /// <param name="button">The button of which to get the button state from.</param>
        /// <returns>The button state of the given <paramref name="button"/>.</returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when <paramref name="button"/> is outside of valid range of [0;<see cref="MouseButton.LastButton"/>].
        /// </exception>
        internal ButtonState GetButton(MouseButton button)
        {
            if (button < 0 || button > MouseButton.LastButton)
            {
                throw new ArgumentOutOfRangeException();
            }

            return
                _state.ReadBit((int)button) ? ButtonState.Pressed : ButtonState.Released;
        }
    }
}
