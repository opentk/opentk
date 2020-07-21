//
// JoystickState.cs
//
// Copyright (C) OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using System.Text;

namespace OpenToolkit.Windowing.Common.Input
{
    /// <summary>
    /// Encapsulates the state of a joystick device.
    /// </summary>
    public struct JoystickState : IEquatable<JoystickState>
    {
        private Hat[] _hats;
        private float[] _axes;
        private byte[] _buttons;

        /// <summary>
        /// Gets the identity of the joystick this state describes.
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Gets the name of the joystick this state describes.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets a value indicating whether the joystick is active and connected.
        /// </summary>
        public bool IsConnected { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="JoystickState"/> struct.
        /// </summary>
        /// <param name="hatCount">The amount of hats.</param>
        /// <param name="axesCount">The amount of axes.</param>
        /// <param name="buttonCount">The amount of buttons.</param>
        /// <param name="id">The id of the joystick.</param>
        /// <param name="name">The name of the joystick.</param>
        public JoystickState(int hatCount, int axesCount, int buttonCount, int id, string name)
        {
            _hats = new Hat[hatCount];
            _axes = new float[axesCount];
            _buttons = new byte[(buttonCount + 7) / 8];
            Id = id;
            Name = name;
            IsConnected = true;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JoystickState"/> struct.
        /// </summary>
        /// <param name="hats">The hats belonging to the joystick.</param>
        /// <param name="axes">The axes belonging to the joystick.</param>
        /// <param name="buttons">The buttons belonging to the joystick.</param>
        /// <param name="id">The id of the joystick.</param>
        /// <param name="name">The name of the joystick.</param>
        public JoystickState(Hat[] hats, float[] axes, bool[] buttons, int id, string name)
        {
            _hats = hats;
            _axes = axes;
            Id = id;
            Name = name;
            IsConnected = true;

            _buttons = new byte[(buttons.Length + 7) / 8];
            for (int i = 0; i < buttons.Length; i++)
            {
                SetButtonDown(i, buttons[i]);
            }
        }

        /// <summary>
        /// Gets a <see cref="Hat"/> describing the state of a hat.
        /// </summary>
        /// <param name="index">The index of the hat to check.</param>
        /// <returns>A <see cref="Hat"/> describing the hat state.</returns>
        public Hat GetHat(int index)
        {
            return _hats[index];
        }

        /// <summary>
        /// Sets the state of a hat depending on the given value.
        /// </summary>
        /// <param name="index">The hat which position should be changed.</param>
        /// <param name="value">The new state the hat should be changed to.</param>
        internal void SetHat(int index, Hat value)
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
        private void SetButtonDown(int index, bool value)
        {
            int byteOffSet = index / 8;
            int bitOffset = index % 8;

            if (value)
            {
                _buttons[byteOffSet] |= (byte)(1 << bitOffset);
            }
            else
            {
                _buttons[byteOffSet] &= (byte)~(1 << bitOffset);
            }
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
        private void SetAxis(int index, float value)
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
            return _axes == other._axes && _hats == other._hats && _buttons == other._buttons && Id == other.Id && Name == other.Name;
        }

        /// <summary>
        /// Generates a hashcode for the current instance.
        /// </summary>
        /// <returns>A <see cref="int"/> representing the hashcode for this instance.</returns>
        public override int GetHashCode()
        {
            int hashCode = _axes.GetHashCode();
            hashCode ^= _hats.GetHashCode();
            hashCode ^= _buttons.GetHashCode();
            hashCode ^= Id.GetHashCode();
            hashCode ^= Name.GetHashCode();

            return hashCode;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.Append("{hats: [");
            builder.Append(_hats[0]);
            for (int i = 1; i < _hats.Length; i++)
            {
                builder.Append(", ");
                builder.Append(_hats[i]);
            }

            builder.Append("], axes: [");
            builder.Append(_axes[0]);
            for (int i = 1; i < _axes.Length; i++)
            {
                builder.Append(", ");
                builder.Append(_axes[i]);
            }

            builder.Append("], buttons: [");
            builder.Append(IsButtonDown(0) ? "down" : "up");
            for (int i = 0; i < _buttons.Length * 8; i++)
            {
                builder.Append(", ");
                builder.Append(IsButtonDown(0) ? "down" : "up");
            }

            builder.Append("], id: ");
            builder.Append(Id);
            builder.Append(", name: ");
            builder.Append(Name);
            builder.Append("}");

            return builder.ToString();
        }
    }
}
