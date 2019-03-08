//
// MouseEventArgs.cs
//
// Copyright (C) 2018 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using OpenToolkit.Windowing.Common.Input;
using OpenToolkit.Mathematics;

namespace OpenToolkit.Windowing.EventingModels
{
    /// <summary>
    /// Defines the event data for <see cref="MouseDevice" /> events.
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
        private MouseState state;

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public MouseEventArgs()
        {
            state.SetIsConnected(true);
        }

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        /// <param name="x">The X position.</param>
        /// <param name="y">The Y position.</param>
        public MouseEventArgs(double x, double y)
            : this()
        {
            state.X = x;
            state.Y = y;
        }

        /// <summary>
        /// Constructs a new instance.
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
            get => state.X;
            internal set => state.X = value;
        }

        /// <summary>
        /// Gets the Y position of the mouse for the event.
        /// </summary>
        public double Y
        {
            get => state.Y;
            internal set => state.Y = value;
        }

        /// <summary>
        /// Gets a <see cref="System.Drawing.Point" /> representing the location of the mouse for the event.
        /// </summary>
        public Vector2d Position
        {
            get => new Vector2d(state.X, state.Y);
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
            get => state;
            internal set => state = value;
        }

        internal void SetButton(MouseButton button, ButtonState state)
        {
            if (button < 0 || button > MouseButton.LastButton)
            {
                throw new ArgumentOutOfRangeException();
            }

            switch (state)
            {
                case ButtonState.Pressed:
                    this.state.EnableBit((int)button);
                    break;

                case ButtonState.Released:
                    this.state.DisableBit((int)button);
                    break;
            }
        }

        internal ButtonState GetButton(MouseButton button)
        {
            if (button < 0 || button > MouseButton.LastButton)
            {
                throw new ArgumentOutOfRangeException();
            }

            return
                state.ReadBit((int)button) ? ButtonState.Pressed : ButtonState.Released;
        }
    }
}
