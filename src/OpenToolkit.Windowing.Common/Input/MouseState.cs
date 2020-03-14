//
// MouseState.cs
//
// Copyright (C) 2018 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using OpenToolkit.Mathematics;

namespace OpenToolkit.Windowing.Common.Input
{
    /// <summary>
    /// Encapsulates the state of a mouse device.
    /// </summary>
    public struct MouseState : IEquatable<MouseState>
    {
        /// <summary>
        /// The maximal number of buttons a <see cref="MouseState"/> can represent.
        /// </summary>
        internal const int MaxButtons = 16; // we are storing in an ushort
        private ushort _buttons;

        /// <summary>
        /// Gets or sets or a <see cref="Vector2"/> representing the absolute position of the pointer,
        /// relative to the top-left corner of the contents of the window.
        /// </summary>
        public Vector2 Position { get; set; }

        /// <summary>
        /// Gets a <see cref="bool" /> indicating whether the specified
        ///  <see cref="MouseButton" /> is pressed.
        /// </summary>
        /// <param name="button">The <see cref="MouseButton" /> to check.</param>
        /// <returns><c>true</c> if key is pressed; <c>false</c> otherwise.</returns>
        public bool this[MouseButton button]
        {
            get => IsButtonDown(button);
            set
            {
                if (value)
                {
                    EnableBit((int)button);
                }
                else
                {
                    DisableBit((int)button);
                }
            }
        }

        /// <summary>
        /// Gets a <see cref="bool" /> indicating whether this button is down.
        /// </summary>
        /// <param name="button">The <see cref="OpenToolkit.Windowing.Common.Input.MouseButton" /> to check.</param>
        /// <returns><c>true</c> if the <paramref name="button"/> is down, otherwise <c>false</c>.</returns>
        public bool IsButtonDown(MouseButton button)
        {
            return ReadBit((int)button);
        }

        /// <summary>
        /// Gets a <see cref="bool" /> indicating whether this button is up.
        /// </summary>
        /// <param name="button">The <see cref="OpenToolkit.Windowing.Common.Input.MouseButton" /> to check.</param>
        /// <returns><c>true</c> if the <paramref name="button"/> is up, otherwise <c>false</c>.</returns>
        public bool IsButtonUp(MouseButton button)
        {
            return !IsButtonDown(button);
        }

        /// <summary>
        /// Gets an integer representing the absolute x position of the pointer, in window pixel coordinates.
        /// </summary>
        public float X => Position.X;

        /// <summary>
        /// Gets an integer representing the absolute y position of the pointer, in window pixel coordinates.
        /// </summary>
        public float Y => Position.Y;

        /// <summary>
        /// Gets a value indicating whether any button is down.
        /// </summary>
        /// <value><c>true</c> if any button is down; otherwise, <c>false</c>.</value>
        public bool IsAnyButtonDown => _buttons != 0;

        /// <summary>
        /// Checks whether two <see cref="MouseState" /> instances are equal.
        /// </summary>
        /// <param name="left">
        /// The first <see cref="MouseState" /> instance to compare.
        /// </param>
        /// <param name="right">
        /// The second <see cref="MouseState" /> instance to compare.
        /// </param>
        /// <returns>
        /// True if both left is equal to right; false otherwise.
        /// </returns>
        public static bool operator ==(MouseState left, MouseState right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// Checks whether two <see cref="MouseState" /> instances are not equal.
        /// </summary>
        /// <param name="left">
        /// The first <see cref="MouseState" /> instance to compare.
        /// </param>
        /// <param name="right">
        /// The second <see cref="MouseState" /> instance to compare.
        /// </param>
        /// <returns>
        /// True if both left is not equal to right; false otherwise.
        /// </returns>
        public static bool operator !=(MouseState left, MouseState right)
        {
            return !left.Equals(right);
        }

        /// <summary>
        /// Compares to an object instance for equality.
        /// </summary>
        /// <param name="obj">
        /// The <see cref="object" /> to compare to.
        /// </param>
        /// <returns>
        /// True if this instance is equal to obj; false otherwise.
        /// </returns>
        public override bool Equals(object obj)
        {
            return obj is MouseState other && Equals(other);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = Position.GetHashCode();
                hashCode = (hashCode * 397) ^ _buttons.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// Returns a <see cref="string" /> that represents the current <see cref="OpenToolkit.Windowing.Common.Input.MouseState" />.
        /// </summary>
        /// <returns>A <see cref="string" /> that represents the current <see cref="OpenToolkit.Windowing.Common.Input.MouseState" />.</returns>
        public override string ToString()
        {
            var b = Convert.ToString(_buttons, 2).PadLeft(10, '0');
            return $"[X={X}, Y={Y}, Buttons={b}]";
        }

        /// <summary>
        /// Gets whether a single button is pressed using an offset corresponding to a <see cref="MouseButton"/>.
        /// </summary>
        /// <param name="offset">The offset corresponding to a <see cref="MouseButton"/>.</param>
        /// <returns>
        /// <c>true</c> when the button given by <paramref name="offset"/> is pressed; otherwise, <c>false</c>.
        /// </returns>
        private bool ReadBit(int offset)
        {
            ValidateOffset(offset);
            return (_buttons & (1 << offset)) != 0;
        }

        /// <summary>
        /// Enables a single button using an offset corresponding to a <see cref="MouseButton"/>.
        /// </summary>
        /// <param name="offset">The offset corresponding to a <see cref="MouseButton"/>.</param>
        private void EnableBit(int offset)
        {
            ValidateOffset(offset);
            _buttons |= unchecked((ushort)(1 << offset));
        }

        /// <summary>
        /// Disables a single button using an offset corresponding to a <see cref="MouseButton"/>.
        /// </summary>
        /// <param name="offset">The offset corresponding to a <see cref="MouseButton"/>.</param>
        private void DisableBit(int offset)
        {
            ValidateOffset(offset);
            _buttons &= unchecked((ushort)~(1 << offset));
        }

        private static void ValidateOffset(int offset)
        {
            if (offset < 0 || offset >= MaxButtons)
            {
                throw new ArgumentOutOfRangeException(nameof(offset));
            }
        }

        /// <summary>
        /// Compares two MouseState instances.
        /// </summary>
        /// <param name="other">The instance to compare two.</param>
        /// <returns>True, if both instances are equal; false otherwise.</returns>
        public bool Equals(MouseState other)
        {
            return Position == other.Position && _buttons == other._buttons;
        }
    }
}
