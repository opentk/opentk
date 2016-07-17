// #region License
//
// GamePadDPad.cs
//
// Author:
//       Stefanos A. <stapostol@gmail.com>
//
// Copyright (c) 2006-2013 Stefanos Apostolopoulos
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
// #endregion

using System;

namespace OpenTK.Input
{
    /// <summary>
    /// Describes the state of a <see cref="GamePad"/> directional pad.
    /// </summary>
    public struct GamePadDPad : IEquatable<GamePadDPad>
    {
        [Flags]
        enum DPadButtons : byte
        {
            Up = Buttons.DPadUp,
            Down = Buttons.DPadDown,
            Left = Buttons.DPadLeft,
            Right = Buttons.DPadRight
        }

        DPadButtons buttons;

        #region Internal Members

        internal GamePadDPad(Buttons state)
        {
            // DPad butons are stored in the lower 4bits
            // of the Buttons enumeration.
            buttons = (DPadButtons)((int)state & 0x0f);
        }

        #endregion

        #region Public Members

        /// <summary>
        /// Gets the <see cref="ButtonState"/> for the up button.
        /// </summary>
        /// <value><c>ButtonState.Pressed</c> if the up button is pressed; otherwise, <c>ButtonState.Released</c>.</value>
        public ButtonState Up
        {
            get { return IsUp ? ButtonState.Pressed : ButtonState.Released; }
        }

        /// <summary>
        /// Gets the <see cref="ButtonState"/> for the down button.
        /// </summary>
        /// <value><c>ButtonState.Pressed</c> if the down button is pressed; otherwise, <c>ButtonState.Released</c>.</value>
        public ButtonState Down
        {
            get { return IsDown ? ButtonState.Pressed : ButtonState.Released; }
        }

        /// <summary>
        /// Gets the <see cref="ButtonState"/> for the left button.
        /// </summary>
        /// <value><c>ButtonState.Pressed</c> if the left button is pressed; otherwise, <c>ButtonState.Released</c>.</value>
        public ButtonState Left
        {
            get { return IsLeft ? ButtonState.Pressed : ButtonState.Released; }
        }

        /// <summary>
        /// Gets the <see cref="ButtonState"/> for the right button.
        /// </summary>
        /// <value><c>ButtonState.Pressed</c> if the right button is pressed; otherwise, <c>ButtonState.Released</c>.</value>
        public ButtonState Right
        {
            get { return IsRight ? ButtonState.Pressed : ButtonState.Released; }
        }

        /// <summary>
        /// Gets a value indicating whether the up button is pressed.
        /// </summary>
        /// <value><c>true</c> if the up button is pressed; otherwise, <c>false</c>.</value>
        public bool IsUp
        {
            get { return (buttons  & DPadButtons.Up) != 0; }
            internal set { SetButton(DPadButtons.Up, value); }
        }

        /// <summary>
        /// Gets a value indicating whether the down button is pressed.
        /// </summary>
        /// <value><c>true</c> if the down button is pressed; otherwise, <c>false</c>.</value>
        public bool IsDown
        {
            get { return (buttons & DPadButtons.Down) != 0; }
            internal set { SetButton(DPadButtons.Down, value); }
        }

        /// <summary>
        /// Gets a value indicating whether the left button is pressed.
        /// </summary>
        /// <value><c>true</c> if the left button is pressed; otherwise, <c>false</c>.</value>
        public bool IsLeft
        {
            get { return (buttons & DPadButtons.Left) != 0; }
            internal set { SetButton(DPadButtons.Left, value); }
        }

        /// <summary>
        /// Gets a value indicating whether the right button is pressed.
        /// </summary>
        /// <value><c>true</c> if the right button is pressed; otherwise, <c>false</c>.</value>
        public bool IsRight
        {
            get { return (buttons & DPadButtons.Right) != 0; }
            internal set { SetButton(DPadButtons.Right, value); }
        }

        /// <param name="left">A <see cref="GamePadDPad"/> instance to test for equality.</param>
        /// <param name="right">A <see cref="GamePadDPad"/> instance to test for equality.</param>
        public static bool operator ==(GamePadDPad left, GamePadDPad right)
        {
            return left.Equals(right);
        }

        /// <param name="left">A <see cref="GamePadDPad"/> instance to test for inequality.</param>
        /// <param name="right">A <see cref="GamePadDPad"/> instance to test for inequality.</param>
        public static bool operator !=(GamePadDPad left, GamePadDPad right)
        {
            return !left.Equals(right);
        }

        /// <summary>
        /// Returns a <see cref="System.String"/> that represents the current <see cref="OpenTK.Input.GamePadDPad"/>.
        /// </summary>
        /// <returns>A <see cref="System.String"/> that represents the current <see cref="OpenTK.Input.GamePadDPad"/>.</returns>
        public override string ToString()
        {
            return String.Format(
                "{{{0}{1}{2}{3}}}",
                IsUp ? "U" : String.Empty,
                IsLeft ? "L" : String.Empty,
                IsDown ? "D" : String.Empty,
                IsRight ? "R" : String.Empty);
        }

        /// <summary>
        /// Serves as a hash function for a <see cref="OpenTK.Input.GamePadDPad"/> object.
        /// </summary>
        /// <returns>A hash code for this instance that is suitable for use in hashing algorithms and data structures such as a
        /// hash table.</returns>
        public override int GetHashCode()
        {
            return buttons.GetHashCode();
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object"/> is equal to the current <see cref="OpenTK.Input.GamePadDPad"/>.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object"/> to compare with the current <see cref="OpenTK.Input.GamePadDPad"/>.</param>
        /// <returns><c>true</c> if the specified <see cref="System.Object"/> is equal to the current
        /// <see cref="OpenTK.Input.GamePadDPad"/>; otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            return
                obj is GamePadDPad &&
                Equals((GamePadDPad)obj);
        }

        #endregion

        #region Private Members

        void SetButton(DPadButtons button, bool value)
        {
            if (value)
            {
                buttons |= button;
            }
            else
            {
                buttons &= ~button;
            }
        }

        #endregion

        #region IEquatable<GamePadDPad> Members

        /// <summary>
        /// Determines whether the specified <see cref="OpenTK.Input.GamePadDPad"/> is equal to the current <see cref="OpenTK.Input.GamePadDPad"/>.
        /// </summary>
        /// <param name="other">The <see cref="OpenTK.Input.GamePadDPad"/> to compare with the current <see cref="OpenTK.Input.GamePadDPad"/>.</param>
        /// <returns><c>true</c> if the specified <see cref="OpenTK.Input.GamePadDPad"/> is equal to the current
        /// <see cref="OpenTK.Input.GamePadDPad"/>; otherwise, <c>false</c>.</returns>
        public bool Equals(GamePadDPad other)
        {
            return buttons == other.buttons;
        }

        #endregion
    }
}
