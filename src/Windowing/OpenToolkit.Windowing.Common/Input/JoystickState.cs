//
// JoystickState.cs
//
// Copyright (C) OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;

namespace OpenToolkit.Windowing.Common.Input
{
    /// <summary>
    /// Encapsulates the state of a joystick device.
    /// </summary>
    public struct JoystickState : IEquatable<JoystickState>
    {
        private HatState[] _hats;
        private float[] _axes;
        private byte[] _buttons;

        /// <summary>
        /// Gets a <see cref="HatState"/> describing the state of a hat.
        /// </summary>
        /// <param name="index">The index of the hat to check.</param>
        /// <returns>A <see cref="HatState"/> describing the hat state.</returns>
        public HatState GetHat(int index)
        {
            return _hats[index];
        }

        /// <summary>
        /// Sets the state of a hat depending on the given value.
        /// </summary>
        /// <param name="index">The hat which position should be changed.</param>
        /// <param name="value">The new state the hat should be changed to.</param>
        internal void SetHat(int index, HatState value)
        {
            _hats[index] = value;
        }

        /// <summary>
        /// Gets a <see cref="bool"/> describing the state of a button.
        /// </summary>
        /// <param name="index">The index of the button to check.</param>
        /// <returns><c>true</c> if the button is down; <c>false</c> otherwise.</returns>
        public bool IsButtonDown(int index)
        {
            byte b = _buttons[index / 8];
            int pow = (int)Math.Pow(2, index % 8);

            return (b & pow) == pow;
        }

        /// <summary>
        /// Sets the state of a button depending on the given value.
        /// </summary>
        /// <param name="index">The index of the button which should be changed.</param>
        /// <param name="value"><c>true</c> if the button is down; <c>false</c> otherwise.</param>
        internal void SetButtonDown(int index, bool value)
        {
            int i = index / 8;
            byte b = _buttons[i];
            int pow = (int)Math.Pow(2, index % 8);

            _buttons[i] = (byte)(b ^ pow);
        }

        /// <summary>
        /// Gets a <see cref="float"/> between -1 and 1 describing the position of an axis.
        /// </summary>
        /// <param name="index">The index of the Axis to check.</param>
        /// <returns>A <see cref="float"/> between -1 and 1 describing the position of the axis.</returns>
        public float GetAxis(int index)
        {
            return _axes[index];
        }

        /// <summary>
        /// Sets the state of an axis depending on the given value.
        /// </summary>
        /// <param name="index">The index of the axis which position should be changed.</param>
        /// <param name="value">The new state the key should be changed to.</param>
        internal void SetAxis(int index, float value)
        {
            _axes[index] = value < -1 ? -1 : (value > 1 ? 1 : value);
        }

        /// <summary>
        /// Checks wether two <see cref="JoystickState"/> instances are equal.
        /// </summary>
        /// <param name="left">The first <see cref="JoystickState"/> instance to compare.</param>
        /// <param name="right">The second <see cref="JoystickState"/> instance to compare.</param>
        /// <returns><c>true</c> if both left is equal to right; <c>false</c>otherwise.</returns>
        public static bool operator ==(JoystickState left, JoystickState right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// Checks wether two <see cref="JoystickState"/> instances are not equal.
        /// </summary>
        /// <param name="left">The first <see cref="JoystickState"/> instance to compare.</param>
        /// <param name="right">The second <see cref="JoystickState"/> instance to compare.</param>
        /// <returns><c>true</c> if both left is not equal to right; <c>false</c> otherwise.</returns>
        public static bool operator !=(JoystickState left, JoystickState right)
        {
            return !left.Equals(right);
        }

        /// <summary>
        /// Compares to an object instance for equality.
        /// </summary>
        /// <param name="obj">The <see cref="object"/> to compare to.</param>
        /// <returns><c>true</c> if this instance is equal to obj; <c>false</c> otherwise.</returns>
        public override bool Equals(object obj)
        {
            if (obj is JoystickState state)
            {
                return Equals(state);
            }
            return false;
        }

        /// <summary>
        /// Compares to <see cref="JoystickState"/> instances.
        /// </summary>
        /// <param name="other">The instance to compare to.</param>
        /// <returns><c>true</c> if both instances are equal; <c>false</c> otherwise.</returns>
        public bool Equals(JoystickState other)
        {
            return false;
        }

        /// <summary>
        /// Generates a hashcode for the current instance.
        /// </summary>
        /// <returns>A <see cref="int"/> representing the hashcode for this instance.</returns>
        public override int GetHashCode()
        {
        }

        /// <inheritdoc/>
        public override string ToString()
        {

        }
    }
}
