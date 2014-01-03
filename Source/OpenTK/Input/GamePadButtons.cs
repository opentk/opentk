#region License
//
// GamePadButtons.cs
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

namespace OpenTK.Input
{
    /// <summary>
    /// Describes the <see cref="ButtonState"/> of <see cref="GamePad"/> <see cref="Buttons"/>.
    /// </summary>
    public struct GamePadButtons : IEquatable<GamePadButtons>
    {
        Buttons buttons;

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenTK.Input.GamePadButtons"/> structure.
        /// </summary>
        /// <param name="state">A bitmask containing the button state.</param>
        public GamePadButtons(Buttons state)
        {
            buttons = state;
        }

        #region Public Members

        /// <summary>
        /// Gets the <see cref="ButtonState"/> for the A button.
        /// </summary>
        public ButtonState A
        {
            get { return GetButton(Buttons.A); }
        }

        /// <summary>
        /// Gets the <see cref="ButtonState"/> for the B button.
        /// </summary>
        public ButtonState B
        {
            get { return GetButton(Buttons.B); }
        }

        /// <summary>
        /// Gets the <see cref="ButtonState"/> for the X button.
        /// </summary>
        public ButtonState X
        {
            get { return GetButton(Buttons.X); }
        }

        /// <summary>
        /// Gets the <see cref="ButtonState"/> for the Y button.
        /// </summary>
        public ButtonState Y
        {
            get { return GetButton(Buttons.Y); }
        }

        /// <summary>
        /// Gets the <see cref="ButtonState"/> for the Back button.
        /// </summary>
        public ButtonState Back
        {
            get { return GetButton(Buttons.Back); }
        }

        /// <summary>
        /// Gets the <see cref="ButtonState"/> for the big button.
        /// This button is also known as Home or Guide.
        /// </summary>
        public ButtonState BigButton
        {
            get { return GetButton(Buttons.BigButton); }
        }

        /// <summary>
        /// Gets the <see cref="ButtonState"/> for the left shoulder button.
        /// </summary>
        public ButtonState LeftShoulder
        {
            get { return GetButton(Buttons.LeftShoulder); }
        }

        /// <summary>
        /// Gets the <see cref="ButtonState"/> for the left stick button.
        /// This button represents a left stick that is pressed in.
        /// </summary>
        public ButtonState LeftStick
        {
            get { return GetButton(Buttons.LeftStick); }
        }

        /// <summary>
        /// Gets the <see cref="ButtonState"/> for the right shoulder button.
        /// </summary>
        public ButtonState RightShoulder
        {
            get { return GetButton(Buttons.RightShoulder); }
        }

        /// <summary>
        /// Gets the <see cref="ButtonState"/> for the right stick button.
        /// This button represents a right stick that is pressed in.
        /// </summary>
        public ButtonState RightStick
        {
            get { return GetButton(Buttons.RightStick); }
        }

        /// <summary>
        /// Gets the <see cref="ButtonState"/> for the starth button.
        /// </summary>
        public ButtonState Start
        {
            get { return GetButton(Buttons.Start); }
        }

        /// <param name="left">A <see cref="GamePadButtons"/> instance to test for equality.</param>
        /// <param name="right">A <see cref="GamePadButtons"/> instance to test for equality.</param>
        public static bool operator ==(GamePadButtons left, GamePadButtons right)
        {
            return left.Equals(right);
        }

        /// <param name="left">A <see cref="GamePadButtons"/> instance to test for inequality.</param>
        /// <param name="right">A <see cref="GamePadButtons"/> instance to test for inequality.</param>
        public static bool operator !=(GamePadButtons left, GamePadButtons right)
        {
            return !left.Equals(right);
        }

        /// <summary>
        /// Returns a <see cref="System.String"/> that represents the current <see cref="OpenTK.Input.GamePadButtons"/>.
        /// </summary>
        /// <returns>A <see cref="System.String"/> that represents the current <see cref="OpenTK.Input.GamePadButtons"/>.</returns>
        public override string ToString()
        {
            return Convert.ToString((int)buttons, 2).PadLeft(10, '0');
        }

        /// <summary>
        /// Serves as a hash function for a <see cref="OpenTK.Input.GamePadButtons"/> object.
        /// </summary>
        /// <returns>A hash code for this instance that is suitable for use in hashing algorithms and data structures such as a
        /// hash table.</returns>
        public override int GetHashCode()
        {
            return buttons.GetHashCode();
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object"/> is equal to the current <see cref="OpenTK.Input.GamePadButtons"/>.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object"/> to compare with the current <see cref="OpenTK.Input.GamePadButtons"/>.</param>
        /// <returns><c>true</c> if the specified <see cref="System.Object"/> is equal to the current
        /// <see cref="OpenTK.Input.GamePadButtons"/>; otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            return
                obj is GamePadButtons &&
                Equals((GamePadButtons)obj);
        }

        #endregion

        #region IEquatable<GamePadButtons> Members

        /// <summary>
        /// Determines whether the specified <see cref="OpenTK.Input.GamePadButtons"/> is equal to the current <see cref="OpenTK.Input.GamePadButtons"/>.
        /// </summary>
        /// <param name="other">The <see cref="OpenTK.Input.GamePadButtons"/> to compare with the current <see cref="OpenTK.Input.GamePadButtons"/>.</param>
        /// <returns><c>true</c> if the specified <see cref="OpenTK.Input.GamePadButtons"/> is equal to the current
        /// <see cref="OpenTK.Input.GamePadButtons"/>; otherwise, <c>false</c>.</returns>
        public bool Equals(GamePadButtons other)
        {
            return buttons == other.buttons;
        }

        #endregion

        #region Private Members

        ButtonState GetButton(Buttons b)
        {
            return (buttons & b) != 0 ? ButtonState.Pressed : ButtonState.Released;
        }

        #endregion
    }
}

