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

using System;
using OpenToolkit.Windowing.Common.Input;
#if !MINIMAL
using System.Drawing;

#endif

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
        public MouseEventArgs(int x, int y)
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
        public int X
        {
            get => state.X;
            internal set => state.X = value;
        }

        /// <summary>
        /// Gets the Y position of the mouse for the event.
        /// </summary>
        public int Y
        {
            get => state.Y;
            internal set => state.Y = value;
        }

        /// <summary>
        /// Gets a <see cref="System.Drawing.Point" /> representing the location of the mouse for the event.
        /// </summary>
        public Point Position
        {
            get => new Point(state.X, state.Y);
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
