#region License
//
// MouseEventArgs.cs
//
// Author:
//       Stefanos A. <stapostol@gmail.com>
//
// Copyright (c) 2006-2014 Stefanos Apostolopoulos
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//
#endregion

using System;
using System.Drawing;

namespace OpenTK.Input
{
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

        MouseState state;

        #endregion

        #region Constructors

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
        public MouseEventArgs(int x, int y)
            : this()
        {
            state.X = x;
            state.Y = y;
        }

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        /// <param name="args">The <see cref="MouseEventArgs"/> instance to clone.</param>
        public MouseEventArgs(MouseEventArgs args)
            : this(args.X, args.Y)
        {
        }

        #endregion

        #region Protected Members

        internal void SetButton(MouseButton button, ButtonState state)
        {
            if (button < 0 || button > MouseButton.LastButton)
                throw new ArgumentOutOfRangeException();

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
                throw new ArgumentOutOfRangeException();

            return
                state.ReadBit((int)button) ?
                ButtonState.Pressed : ButtonState.Released;
        }

        #endregion

        #region Public Members

        /// <summary>
        /// Gets the X position of the mouse for the event.
        /// </summary>
        public int X { get { return state.X; } internal set { state.X = value; } }

        /// <summary>
        /// Gets the Y position of the mouse for the event.
        /// </summary>
        public int Y { get { return state.Y; } internal set { state.Y = value; } }

        /// <summary>
        /// Gets a <see cref="System.Drawing.Point"/> representing the location of the mouse for the event.
        /// </summary>
        public Point Position
        {
            get { return new Point(state.X, state.Y); }
            set
            {
                X = value.X;
                Y = value.Y;
            }
        }

        /// <summary>
        /// Gets the current <see cref="OpenTK.Input.MouseState"/>.
        /// </summary>
        public MouseState Mouse
        {
            get { return state; }
            internal set { state = value; }
        }

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
        /// Gets the <see cref="MouseButton"/> that triggered this event.
        /// </summary>
        public MouseButton Button { get { return button; } internal set { button = value; } }

        /// <summary>
        /// Gets a System.Boolean representing the state of the mouse button for the event.
        /// </summary>
        public bool IsPressed
        {
            get { return GetButton(Button) == ButtonState.Pressed; }
            internal set { SetButton(Button, value ? ButtonState.Pressed : ButtonState.Released); }
        }

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
            Mouse.SetScrollAbsolute(Mouse.Scroll.X, value);
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
        public int Value { get { return (int)Math.Round(Mouse.Scroll.Y, MidpointRounding.AwayFromZero); } }

        /// <summary>
        /// Gets the change in value of the wheel for this event in integer units.
        /// To support high-precision mice, it is recommended to use <see cref="DeltaPrecise"/> instead.
        /// </summary>
        public int Delta { get { return (int)Math.Round(delta, MidpointRounding.AwayFromZero); } }

        /// <summary>
        /// Gets the precise value of the wheel in floating-point units.
        /// </summary>
        public float ValuePrecise
        {
            get { return Mouse.Scroll.Y; }
        }

        /// <summary>
        /// Gets the precise change in value of the wheel for this event in floating-point units.
        /// </summary>
        public float DeltaPrecise { get { return delta; } internal set { delta = value; } }

        #endregion
    }
}

