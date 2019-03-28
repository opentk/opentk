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
        private Vector2d _position;
        private MouseScroll _scroll;
        private ushort _buttons;

        /// <summary>
        /// Gets a <see cref="bool" /> indicating whether the specified
        ///  <see cref="MouseButton" /> is pressed.
        /// </summary>
        /// <param name="button">The <see cref="MouseButton" /> to check.</param>
        /// <returns><c>true</c> if key is pressed; <c>false</c> otherwise.</returns>
        public bool this[MouseButton button]
        {
            get => IsButtonDown(button);
            internal set
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
            return !ReadBit((int)button);
        }

        /// <summary>
        /// Gets the absolute wheel position in integer units.
        /// To support high-precision mice, it is recommended to use <see cref="WheelPrecise" /> instead.
        /// </summary>
        public int Wheel => (int)Math.Round(_scroll.Y, MidpointRounding.AwayFromZero);

        /// <summary>
        /// Gets the absolute wheel position in floating-point units.
        /// </summary>
        public float WheelPrecise => _scroll.Y;

        /// <summary>
        /// Gets a <see cref="OpenToolkit.Windowing.Common.Input.MouseScroll" /> instance,
        /// representing the current state of the mouse scroll wheel.
        /// </summary>
        public MouseScroll Scroll => _scroll;

        /// <summary>
        /// Gets an integer representing the absolute x position of the pointer, in window pixel coordinates.
        /// </summary>
        public double X
        {
            get => _position.X;
            internal set => _position.X = value;
        }

        /// <summary>
        /// Gets an integer representing the absolute y position of the pointer, in window pixel coordinates.
        /// </summary>
        public double Y
        {
            get => _position.Y;
            internal set => _position.Y = value;
        }

        /// <summary>
        /// Gets a <see cref="ButtonState" /> indicating whether the left mouse button is pressed.
        /// This property is intended for XNA compatibility.
        /// </summary>
        public ButtonState LeftButton => IsButtonDown(MouseButton.Left) ? ButtonState.Pressed : ButtonState.Released;

        /// <summary>
        /// Gets a <see cref="ButtonState" /> indicating whether the middle mouse button is pressed.
        /// This property is intended for XNA compatibility.
        /// </summary>
        public ButtonState MiddleButton =>
            IsButtonDown(MouseButton.Middle) ? ButtonState.Pressed : ButtonState.Released;

        /// <summary>
        /// Gets a <see cref="ButtonState" /> indicating whether the right mouse button is pressed.
        /// This property is intended for XNA compatibility.
        /// </summary>
        public ButtonState RightButton => IsButtonDown(MouseButton.Right) ? ButtonState.Pressed : ButtonState.Released;

        /// <summary>
        /// Gets a <see cref="ButtonState" /> indicating whether the first extra mouse button is pressed.
        /// This property is intended for XNA compatibility.
        /// </summary>
        public ButtonState XButton1 => IsButtonDown(MouseButton.Button1) ? ButtonState.Pressed : ButtonState.Released;

        /// <summary>
        /// Gets a <see cref="ButtonState" /> indicating whether the second extra mouse button is pressed.
        /// This property is intended for XNA compatibility.
        /// </summary>
        public ButtonState XButton2 => IsButtonDown(MouseButton.Button2) ? ButtonState.Pressed : ButtonState.Released;

        /// <summary>
        /// Gets a value indicating whether any button is down.
        /// </summary>
        /// <value><c>true</c> if any button is down; otherwise, <c>false</c>.</value>
        public bool IsAnyButtonDown => _buttons != 0;

        /// <summary>
        /// Gets the absolute wheel position in integer units. This property is intended for XNA compatibility.
        /// To support high-precision mice, it is recommended to use <see cref="WheelPrecise" /> instead.
        /// </summary>
        public int ScrollWheelValue => Wheel;

        /// <summary>
        /// Gets a value indicating whether this instance is connected.
        /// </summary>
        /// <value><c>true</c> if this instance is connected; otherwise, <c>false</c>.</value>
        public bool IsConnected { get; internal set; }

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
            if (obj is MouseState)
            {
                return this == (MouseState)obj;
            }

            return false;
        }

        /// <summary>
        /// Generates a hashcode for the current instance.
        /// </summary>
        /// <returns>
        /// A <see cref="int" /> represting the hashcode for this instance.
        /// </returns>
        public override int GetHashCode()
        {
            return _buttons.GetHashCode() ^ X.GetHashCode() ^ Y.GetHashCode() ^ _scroll.GetHashCode();
        }

        /// <summary>
        /// Returns a <see cref="string" /> that represents the current <see cref="OpenToolkit.Windowing.Common.Input.MouseState" />.
        /// </summary>
        /// <returns>A <see cref="string" /> that represents the current <see cref="OpenToolkit.Windowing.Common.Input.MouseState" />.</returns>
        public override string ToString()
        {
            var b = Convert.ToString(_buttons, 2).PadLeft(10, '0');
            return $"[X={X}, Y={Y}, Scroll={Scroll}, Buttons={b}, IsConnected={IsConnected}]";
        }

        /// <summary>
        /// Gets or sets a <see cref="Vector2"/> representing the absolute position of the pointer,
        /// in window pixel coordinates.
        /// </summary>
        internal Vector2d Position
        {
            get => _position;
            set => _position = value;
        }

        /// <summary>
        /// Gets whether a single button is pressed using an offset corresponding to a <see cref="MouseButton"/>.
        /// </summary>
        /// <param name="offset">The offset corresponding to a <see cref="MouseButton"/>.</param>
        /// <returns>
        /// <c>true</c> when the button given by <paramref name="offset"/> is pressed; otherwise, <c>false</c>.
        /// </returns>
        internal bool ReadBit(int offset)
        {
            ValidateOffset(offset);
            return (_buttons & (1 << offset)) != 0;
        }

        /// <summary>
        /// Enables a single button using an offset corresponding to a <see cref="MouseButton"/>.
        /// </summary>
        /// <param name="offset">The offset corresponding to a <see cref="MouseButton"/>.</param>
        internal void EnableBit(int offset)
        {
            ValidateOffset(offset);
            _buttons |= unchecked((ushort)(1 << offset));
        }

        /// <summary>
        /// Disables a single button using an offset corresponding to a <see cref="MouseButton"/>.
        /// </summary>
        /// <param name="offset">The offset corresponding to a <see cref="MouseButton"/>.</param>
        internal void DisableBit(int offset)
        {
            ValidateOffset(offset);
            _buttons &= unchecked((ushort)~(1 << offset));
        }

        /// <summary>
        /// Merges this <see cref="MouseState"/> with an <paramref name="other"/>.
        /// </summary>
        /// <param name="other">The <paramref name="other"/> <see cref="MouseState"/> with which to merge.</param>
        internal void MergeBits(MouseState other)
        {
            _buttons |= other._buttons;
            SetScrollRelative(other._scroll.X, other._scroll.Y);
            X += other.X;
            Y += other.Y;
            IsConnected |= other.IsConnected;
        }

        /// <summary>
        /// Sets the <see cref="IsConnected"/> value to the given <paramref name="value"/>.
        /// </summary>
        /// <param name="value">The value to set the <see cref="IsConnected"/> property to.</param>
        internal void SetIsConnected(bool value)
        {
            IsConnected = value;
        }

        /// <summary>
        /// Sets the absolute <see cref="Scroll"/> components to
        /// <paramref name="x"/> and <paramref name="y"/> respectively.
        /// </summary>
        /// <param name="x">The value to set the <see cref="Scroll"/> x component to.</param>
        /// <param name="y">The value to set the <see cref="Scroll"/> y component to.</param>
        internal void SetScrollAbsolute(float x, float y)
        {
            _scroll.X = x;
            _scroll.Y = y;
        }

        /// <summary>
        /// Increments the <see cref="Scroll"/> value by <paramref name="x"/> and <paramref name="y"/> respectively.
        /// </summary>
        /// <param name="x">The amount to increment the <see cref="Scroll"/> x component by.</param>
        /// <param name="y">The amount to increment the <see cref="Scroll"/> y component by.</param>
        internal void SetScrollRelative(float x, float y)
        {
            _scroll.X += x;
            _scroll.Y += y;
        }

        private static void ValidateOffset(int offset)
        {
            if (offset < 0 || offset >= 16)
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
            return
                _buttons == other._buttons &&
                X == other.X &&
                Y == other.Y &&
                Scroll == other.Scroll;
        }
    }
}
