#region License
//
// GamePadCapabilities.cs
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
#endregion

using System;

namespace OpenTK.Input
{
    /// <summary>
    /// Describes the capabilities of a <c>GamePad</c> input device.
    /// </summary>
    public struct GamePadCapabilities : IEquatable<GamePadCapabilities>
    {
        Buttons buttons;
        GamePadAxes axes;
        byte gamepad_type;
        bool is_connected;

        #region Constructors

        internal GamePadCapabilities(GamePadType type, GamePadAxes axes, Buttons buttons, bool is_connected)
            : this()
        {
            gamepad_type = (byte)type;
            this.axes = axes;
            this.buttons = buttons;
            this.is_connected = is_connected;
        }

        #endregion

        #region Public Members

        /// <summary>
        /// Gets a <see cref="GamePadType"/>  value describing the type of a <see cref="GamePad"/> input device.
        /// This value depends on the connected device and the drivers in use. If <c>IsConnected</c>
        /// is false, then this value will be <c>GamePadType.Unknown</c>.
        /// </summary>
        /// <value>The <c>GamePadType</c> of the connected input device.</value>
        public GamePadType GamePadType
        {
            get { return (GamePadType)gamepad_type; }
        }

        /// <summary>
        /// Gets a <see cref="System.Boolean"/> value describing whether this <c>GamePad</c> has
        /// an up digital pad button.
        /// </summary>
        /// <value><c>true</c> if this instance has an up digital pad button; otherwise, <c>false</c>.</value>
        public bool HasDPadUpButton
        {
            get { return (buttons & Buttons.DPadUp) != 0; }
        }

        /// <summary>
        /// Gets a <see cref="System.Boolean"/> value describing whether this <c>GamePad</c> has
        /// a down digital pad button.
        /// </summary>
        /// <value><c>true</c> if this instance has a down digital pad button; otherwise, <c>false</c>.</value>
        public bool HasDPadDownButton
        {
            get { return (buttons & Buttons.DPadDown) != 0; }
        }

        /// <summary>
        /// Gets a <see cref="System.Boolean"/> value describing whether this <c>GamePad</c> has
        /// a left digital pad button.
        /// </summary>
        /// <value><c>true</c> if this instance has a left digital pad button; otherwise, <c>false</c>.</value>
        public bool HasDPadLeftButton
        {
            get { return (buttons & Buttons.DPadLeft) != 0; }
        }

        /// <summary>
        /// Gets a <see cref="System.Boolean"/> value describing whether this <c>GamePad</c> has
        /// a right digital pad button.
        /// </summary>
        /// <value><c>true</c> if this instance has a right digital pad button; otherwise, <c>false</c>.</value>
        public bool HasDPadRightButton
        {
            get { return (buttons & Buttons.DPadRight) != 0; }
        }

        /// <summary>
        /// Gets a <see cref="System.Boolean"/> value describing whether this <c>GamePad</c> has
        /// an A button.
        /// </summary>
        /// <value><c>true</c> if this instance has an A button; otherwise, <c>false</c>.</value>
        public bool HasAButton
        {
            get { return (buttons & Buttons.A) != 0; }
        }

        /// <summary>
        /// Gets a <see cref="System.Boolean"/> value describing whether this <c>GamePad</c> has
        /// a B button.
        /// </summary>
        /// <value><c>true</c> if this instance has a B button; otherwise, <c>false</c>.</value>
        public bool HasBButton
        {
            get { return (buttons & Buttons.B) != 0; }
        }

        /// <summary>
        /// Gets a <see cref="System.Boolean"/> value describing whether this <c>GamePad</c> has
        /// a X button.
        /// </summary>
        /// <value><c>true</c> if this instance has a X button; otherwise, <c>false</c>.</value>
        public bool HasXButton
        {
            get { return (buttons & Buttons.X) != 0; }
        }

        /// <summary>
        /// Gets a <see cref="System.Boolean"/> value describing whether this <c>GamePad</c> has
        /// a Y button.
        /// </summary>
        /// <value><c>true</c> if this instance has a Y button; otherwise, <c>false</c>.</value>
        public bool HasYButton
        {
            get { return (buttons & Buttons.Y) != 0; }
        }

        /// <summary>
        /// Gets a <see cref="System.Boolean"/> value describing whether this <c>GamePad</c> has
        /// a left stick button.
        /// </summary>
        /// <value><c>true</c> if this instance has a left stick button; otherwise, <c>false</c>.</value>
        public bool HasLeftStickButton
        {
            get { return (buttons & Buttons.LeftStick) != 0; }
        }

        /// <summary>
        /// Gets a <see cref="System.Boolean"/> value describing whether this <c>GamePad</c> has
        /// a right stick button.
        /// </summary>
        /// <value><c>true</c> if this instance has a right stick button; otherwise, <c>false</c>.</value>
        public bool HasRightStickButton
        {
            get { return (buttons & Buttons.RightStick) != 0; }
        }

        /// <summary>
        /// Gets a <see cref="System.Boolean"/> value describing whether this <c>GamePad</c> has
        /// a left shoulder button.
        /// </summary>
        /// <value><c>true</c> if this instance has a left shoulder button; otherwise, <c>false</c>.</value>
        public bool HasLeftShoulderButton
        {
            get { return (buttons & Buttons.LeftShoulder) != 0; }
        }

        /// <summary>
        /// Gets a <see cref="System.Boolean"/> value describing whether this <c>GamePad</c> has
        /// a right shoulder button.
        /// </summary>
        /// <value><c>true</c> if this instance has a right shoulder button; otherwise, <c>false</c>.</value>
        public bool HasRightShoulderButton
        {
            get { return (buttons & Buttons.RightShoulder) != 0; }
        }

        /// <summary>
        /// Gets a <see cref="System.Boolean"/> value describing whether this <c>GamePad</c> has
        /// a back button.
        /// </summary>
        /// <value><c>true</c> if this instance has a back button; otherwise, <c>false</c>.</value>
        public bool HasBackButton
        {
            get { return (buttons & Buttons.Back) != 0; }
        }

        /// <summary>
        /// Gets a <see cref="System.Boolean"/> value describing whether this <c>GamePad</c> has
        /// a big button. (also known as "guide" or "home" button).
        /// </summary>
        /// <value><c>true</c> if this instance has a big button; otherwise, <c>false</c>.</value>
        public bool HasBigButton
        {
            get { return (buttons & Buttons.BigButton) != 0; }
        }

        /// <summary>
        /// Gets a <see cref="System.Boolean"/> value describing whether this <c>GamePad</c> has
        /// a start button.
        /// </summary>
        /// <value><c>true</c> if this instance has a start button; otherwise, <c>false</c>.</value>
        public bool HasStartButton
        {
            get { return (buttons & Buttons.Start) != 0; }
        }

        /// <summary>
        /// Gets a <see cref="System.Boolean"/> value describing whether this <c>GamePad</c> has
        /// a left thumbstick with a x-axis.
        /// </summary>
        /// <value><c>true</c> if this instance has a left thumbstick with a x-axis; otherwise, <c>false</c>.</value>
        public bool HasLeftXThumbStick
        {
            get { return (axes & GamePadAxes.LeftX) != 0; }
        }

        /// <summary>
        /// Gets a <see cref="System.Boolean"/> value describing whether this <c>GamePad</c> has
        /// a left thumbstick with a y-axis.
        /// </summary>
        /// <value><c>true</c> if this instance has a left thumbstick with a y-axis; otherwise, <c>false</c>.</value>
        public bool HasLeftYThumbStick
        {
            get { return (axes & GamePadAxes.LeftY) != 0; }
        }

        /// <summary>
        /// Gets a <see cref="System.Boolean"/> value describing whether this <c>GamePad</c> has
        /// a right thumbstick with a x-axis.
        /// </summary>
        /// <value><c>true</c> if this instance has a right thumbstick with a x-axis; otherwise, <c>false</c>.</value>
        public bool HasRightXThumbStick
        {
            get { return (axes & GamePadAxes.RightX) != 0; }
        }

        /// <summary>
        /// Gets a <see cref="System.Boolean"/> value describing whether this <c>GamePad</c> has
        /// a right thumbstick with a y-axis.
        /// </summary>
        /// <value><c>true</c> if this instance has a right thumbstick with a y-axis; otherwise, <c>false</c>.</value>
        public bool HasRightYThumbStick
        {
            get { return (axes & GamePadAxes.RightY) != 0; }
        }

        /// <summary>
        /// Gets a <see cref="System.Boolean"/> value describing whether this <c>GamePad</c> has
        /// a left trigger.
        /// </summary>
        /// <value><c>true</c> if this instance has a left trigger; otherwise, <c>false</c>.</value>
        public bool HasLeftTrigger
        {
            get { return (axes & GamePadAxes.LeftTrigger) != 0; }
        }

        /// <summary>
        /// Gets a <see cref="System.Boolean"/> value describing whether this <c>GamePad</c> has
        /// a right trigger.
        /// </summary>
        /// <value><c>true</c> if this instance has a right trigger; otherwise, <c>false</c>.</value>
        public bool HasRightTrigger
        {
            get { return (axes & GamePadAxes.RightTrigger) != 0; }
        }

        /// <summary>
        /// Gets a <see cref="System.Boolean"/> value describing whether this <c>GamePad</c> has
        /// a low-frequency vibration motor.
        /// </summary>
        /// <value><c>true</c> if this instance has a low-frequency vibration motor; otherwise, <c>false</c>.</value>
        public bool HasLeftVibrationMotor
        {
            get { return false; }
        }

        /// <summary>
        /// Gets a <see cref="System.Boolean"/> value describing whether this <c>GamePad</c> has
        /// a high-frequency vibration motor.
        /// </summary>
        /// <value><c>true</c> if this instance has a high frequency vibration motor; otherwise, <c>false</c>.</value>
        public bool HasRightVibrationMotor
        {
            get { return false; }
        }

        /// <summary>
        /// Gets a <see cref="System.Boolean"/> value describing whether this <c>GamePad</c> has
        /// a microphone input.
        /// </summary>
        /// <value><c>true</c> if this instance has a microphone input; otherwise, <c>false</c>.</value>
        public bool HasVoiceSupport
        {
            get { return false; }
        }

        /// <summary>
        /// Gets a <see cref="System.Boolean"/> value describing whether this <c>GamePad</c> is
        /// currently connected.
        /// </summary>
        /// <value><c>true</c> if this instance is currently connected; otherwise, <c>false</c>.</value>
        public bool IsConnected
        {
            get { return is_connected; }
        }

        /// <param name="left">A <see cref="GamePadCapabilities"/> structure to test for equality.</param>
        /// <param name="right">A <see cref="GamePadCapabilities"/> structure to test for equality.</param>
        public static bool operator ==(GamePadCapabilities left, GamePadCapabilities right)
        {
            return left.Equals(right);
        }

        /// <param name="left">A <see cref="GamePadCapabilities"/> structure to test for inequality.</param>
        /// <param name="right">A <see cref="GamePadCapabilities"/> structure to test for inequality.</param>
        public static bool operator !=(GamePadCapabilities left, GamePadCapabilities right)
        {
            return !left.Equals(right);
        }

        /// <summary>
        /// Returns a <see cref="System.String"/> that represents the current <see cref="OpenTK.Input.GamePadCapabilities"/>.
        /// </summary>
        /// <returns>A <see cref="System.String"/> that represents the current <see cref="OpenTK.Input.GamePadCapabilities"/>.</returns>
        public override string ToString()
        {
            return String.Format(
                "{{Type: {0}; Axes: {1}; Buttons: {2}; Connected: {3}}}",
                GamePadType,
                Convert.ToString((int)axes, 2),
                Convert.ToString((int)buttons, 2),
                IsConnected);
        }

        /// <summary>
        /// Serves as a hash function for a <see cref="OpenTK.Input.GamePadCapabilities"/> object.
        /// </summary>
        /// <returns>A hash code for this instance that is suitable for use in hashing algorithms and data structures such as a
        /// hash table.</returns>
        public override int GetHashCode()
        {
            return
                buttons.GetHashCode() ^
                is_connected.GetHashCode() ^
                gamepad_type.GetHashCode();
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object"/> is equal to the current <see cref="OpenTK.Input.GamePadCapabilities"/>.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object"/> to compare with the current <see cref="OpenTK.Input.GamePadCapabilities"/>.</param>
        /// <returns><c>true</c> if the specified <see cref="System.Object"/> is equal to the current
        /// <see cref="OpenTK.Input.GamePadCapabilities"/>; otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            return
                obj is GamePadCapabilities &&
                Equals((GamePadCapabilities)obj);
        }

        #endregion

        #region IEquatable<GamePadCapabilities> Members

        /// <summary>
        /// Determines whether the specified <see cref="OpenTK.Input.GamePadCapabilities"/> is equal to the current <see cref="OpenTK.Input.GamePadCapabilities"/>.
        /// </summary>
        /// <param name="other">The <see cref="OpenTK.Input.GamePadCapabilities"/> to compare with the current <see cref="OpenTK.Input.GamePadCapabilities"/>.</param>
        /// <returns><c>true</c> if the specified <see cref="OpenTK.Input.GamePadCapabilities"/> is equal to the current
        /// <see cref="OpenTK.Input.GamePadCapabilities"/>; otherwise, <c>false</c>.</returns>
        public bool Equals(GamePadCapabilities other)
        {
            return
                buttons == other.buttons &&
                is_connected == other.is_connected &&
                gamepad_type == other.gamepad_type;
        }

        #endregion
    }
}

