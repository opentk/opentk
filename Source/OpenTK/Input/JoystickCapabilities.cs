#region License
//
// JoystickCapabilities.cs
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
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace OpenTK.Input
{
    /// <summary>
    /// Describes the <c>JoystickCapabilities</c> of a <see cref="JoystickDevice"/>.
    /// </summary>
    public struct JoystickCapabilities : IEquatable<JoystickCapabilities>
    {
        byte axis_count;
        byte button_count;
        byte hat_count;
        bool is_connected;

        #region Constructors

        internal JoystickCapabilities(int axis_count, int button_count, int hat_count, bool is_connected)
        {
            if (axis_count < 0 || axis_count > JoystickState.MaxAxes)
                Debug.Print("[{0}] Axis count {1} out of range (0, {2})",
                    typeof(JoystickCapabilities).Name, axis_count, JoystickState.MaxAxes);
            if (button_count < 0 || button_count > JoystickState.MaxButtons)
                Debug.Print("[{0}] Button count {1} out of range (0, {2})",
                    typeof(JoystickCapabilities).Name, button_count, JoystickState.MaxButtons);
            if (hat_count < 0 || hat_count > JoystickState.MaxHats)
                Debug.Print("[{0}] Hat count {1} out of range (0, {2})",
                    typeof(JoystickCapabilities).Name, hat_count, JoystickState.MaxHats);

            axis_count = MathHelper.Clamp(axis_count, 0, JoystickState.MaxAxes);
            button_count = MathHelper.Clamp(button_count, 0, JoystickState.MaxButtons);
            hat_count = MathHelper.Clamp(hat_count, 0, JoystickState.MaxHats);

            this.axis_count = (byte)axis_count;
            this.button_count = (byte)button_count;
            this.hat_count = (byte)hat_count;
            this.is_connected = is_connected;
        }

        #endregion

        #region Internal Members

        internal void SetIsConnected(bool value)
        {
            is_connected = value;
        }

        #endregion

        #region Public Members

        /// <summary>
        /// Gets the number of axes supported by this <see cref="JoystickDevice"/>.
        /// </summary>
        public int AxisCount
        {
            get { return axis_count; }
        }

        /// <summary>
        /// Gets the number of buttons supported by this <see cref="JoystickDevice"/>.
        /// </summary>
        public int ButtonCount
        {
            get { return button_count; }
        }

        /// <summary>
        /// Gets the number of hats supported by this <see cref="JoystickDevice"/>.
        /// </summary>
        public int HatCount
        {
            get { return hat_count; }
        }

        /// <summary>
        /// Gets a value indicating whether this <see cref="JoystickDevice"/> is connected.
        /// </summary>
        /// <value><c>true</c> if this instance is connected; otherwise, <c>false</c>.</value>
        public bool IsConnected
        {
            get { return is_connected; }
            private set { is_connected = value; }
        }

        /// <summary>
        /// Returns a <see cref="System.String"/> that represents the current <see cref="OpenTK.Input.JoystickCapabilities"/>.
        /// </summary>
        /// <returns>A <see cref="System.String"/> that represents the current <see cref="OpenTK.Input.JoystickCapabilities"/>.</returns>
        public override string ToString()
        {
            return String.Format(
                "{{Axes: {0}; Buttons: {1}; Hats: {2}; IsConnected: {3}}}",
                AxisCount, ButtonCount, HatCount, IsConnected);
        }

        /// <summary>
        /// Serves as a hash function for a <see cref="OpenTK.Input.JoystickCapabilities"/> object.
        /// </summary>
        /// <returns>A hash code for this instance that is suitable for use in hashing algorithms and data structures such as a
        /// hash table.</returns>
        public override int GetHashCode()
        {
            return
                AxisCount.GetHashCode() ^
                ButtonCount.GetHashCode() ^
                HatCount.GetHashCode() ^
                IsConnected.GetHashCode();
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object"/> is equal to the current <see cref="OpenTK.Input.JoystickCapabilities"/>.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object"/> to compare with the current <see cref="OpenTK.Input.JoystickCapabilities"/>.</param>
        /// <returns><c>true</c> if the specified <see cref="System.Object"/> is equal to the current
        /// <see cref="OpenTK.Input.JoystickCapabilities"/>; otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            return
                obj is JoystickCapabilities &&
                Equals((JoystickCapabilities)obj);
        }

        #endregion

        #region IEquatable<JoystickCapabilities> Members

        /// <summary>
        /// Determines whether the specified <see cref="OpenTK.Input.JoystickCapabilities"/> is equal to the current <see cref="OpenTK.Input.JoystickCapabilities"/>.
        /// </summary>
        /// <param name="other">The <see cref="OpenTK.Input.JoystickCapabilities"/> to compare with the current <see cref="OpenTK.Input.JoystickCapabilities"/>.</param>
        /// <returns><c>true</c> if the specified <see cref="OpenTK.Input.JoystickCapabilities"/> is equal to the current
        /// <see cref="OpenTK.Input.JoystickCapabilities"/>; otherwise, <c>false</c>.</returns>
        public bool Equals(JoystickCapabilities other)
        {
            return
                AxisCount == other.AxisCount &&
                ButtonCount == other.ButtonCount &&
                HatCount == other.HatCount &&
                IsConnected == other.IsConnected;
        }

        #endregion
    }
}
