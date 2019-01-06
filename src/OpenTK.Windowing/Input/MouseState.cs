﻿//
// MouseState.cs
//
// Copyright (C) 2018 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using OpenToolkit.Mathematics;
using OpenToolkit.Windowing.Input.Enums;

namespace OpenToolkit.Windowing.Input
{
    /// <summary>
    /// Encapsulates the state of a mouse device.
    /// </summary>
    public struct MouseState : IEquatable<MouseState>
    {
        internal const int MaxButtons = 16; // we are storing in an ushort
        private Vector2 position;
        private MouseScroll scroll;
        private ushort buttons;

        /// <summary>
        /// Gets a <see cref="System.Boolean" /> indicating whether the specified
        ///  <see cref="OpenTK.Input.MouseButton" /> is pressed.
        /// </summary>
        /// <param name="button">The <see cref="OpenTK.Input.MouseButton" /> to check.</param>
        /// <returns>True if key is pressed; false otherwise.</returns>
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
        /// Gets a <see cref="System.Boolean" /> indicating whether this button is down.
        /// </summary>
        /// <param name="button">The <see cref="OpenTK.Input.MouseButton" /> to check.</param>
        public bool IsButtonDown(MouseButton button)
        {
            return ReadBit((int)button);
        }

        /// <summary>
        /// Gets a <see cref="System.Boolean" /> indicating whether this button is up.
        /// </summary>
        /// <param name="button">The <see cref="OpenTK.Input.MouseButton" /> to check.</param>
        public bool IsButtonUp(MouseButton button)
        {
            return !ReadBit((int)button);
        }

        /// <summary>
        /// Gets the absolute wheel position in integer units.
        /// To support high-precision mice, it is recommended to use <see cref="WheelPrecise" /> instead.
        /// </summary>
        public int Wheel => (int)Math.Round(scroll.Y, MidpointRounding.AwayFromZero);

        /// <summary>
        /// Gets the absolute wheel position in floating-point units.
        /// </summary>
        public float WheelPrecise => scroll.Y;

        /// <summary>
        /// Gets a <see cref="OpenTK.Input.MouseScroll" /> instance,
        /// representing the current state of the mouse scroll wheel.
        /// </summary>
        public MouseScroll Scroll => scroll;

        /// <summary>
        /// Gets an integer representing the absolute x position of the pointer, in window pixel coordinates.
        /// </summary>
        public int X
        {
            get => (int)Math.Round(position.X);
            internal set => position.X = value;
        }

        /// <summary>
        /// Gets an integer representing the absolute y position of the pointer, in window pixel coordinates.
        /// </summary>
        public int Y
        {
            get => (int)Math.Round(position.Y);
            internal set => position.Y = value;
        }

        /// <summary>
        /// Gets a <see cref="System.Boolean" /> indicating whether the left mouse button is pressed.
        /// This property is intended for XNA compatibility.
        /// </summary>
        public ButtonState LeftButton => IsButtonDown(MouseButton.Left) ? ButtonState.Pressed : ButtonState.Released;

        /// <summary>
        /// Gets a <see cref="System.Boolean" /> indicating whether the middle mouse button is pressed.
        /// This property is intended for XNA compatibility.
        /// </summary>
        public ButtonState MiddleButton =>
            IsButtonDown(MouseButton.Middle) ? ButtonState.Pressed : ButtonState.Released;

        /// <summary>
        /// Gets a <see cref="System.Boolean" /> indicating whether the right mouse button is pressed.
        /// This property is intended for XNA compatibility.
        /// </summary>
        public ButtonState RightButton => IsButtonDown(MouseButton.Right) ? ButtonState.Pressed : ButtonState.Released;

        /// <summary>
        /// Gets a <see cref="System.Boolean" /> indicating whether the first extra mouse button is pressed.
        /// This property is intended for XNA compatibility.
        /// </summary>
        public ButtonState XButton1 => IsButtonDown(MouseButton.Button1) ? ButtonState.Pressed : ButtonState.Released;

        /// <summary>
        /// Gets a <see cref="System.Boolean" /> indicating whether the second extra mouse button is pressed.
        /// This property is intended for XNA compatibility.
        /// </summary>
        public ButtonState XButton2 => IsButtonDown(MouseButton.Button2) ? ButtonState.Pressed : ButtonState.Released;

        /// <summary>
        /// Gets a value indicating whether any button is down.
        /// </summary>
        /// <value><c>true</c> if any button is down; otherwise, <c>false</c>.</value>
        public bool IsAnyButtonDown => buttons != 0;

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
        /// A <see cref="MouseState" /> instance.
        /// </param>
        /// <param name="right">
        /// A <see cref="MouseState" /> instance.
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
        /// A <see cref="MouseState" /> instance.
        /// </param>
        /// <param name="right">
        /// A <see cref="MouseState" /> instance.
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
        /// The <see cref="System.Object" /> to compare to.
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
        /// A <see cref="System.Int32" /> represting the hashcode for this instance.
        /// </returns>
        public override int GetHashCode()
        {
            return buttons.GetHashCode() ^ X.GetHashCode() ^ Y.GetHashCode() ^ scroll.GetHashCode();
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents the current <see cref="OpenTK.Input.MouseState" />.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents the current <see cref="OpenTK.Input.MouseState" />.</returns>
        public override string ToString()
        {
            var b = Convert.ToString(buttons, 2).PadLeft(10, '0');
            return $"[X={X}, Y={Y}, Scroll={Scroll}, Buttons={b}, IsConnected={IsConnected}]";
        }

        internal Vector2 Position
        {
            get => position;
            set => position = value;
        }

        internal bool ReadBit(int offset)
        {
            ValidateOffset(offset);
            return (buttons & (1 << offset)) != 0;
        }

        internal void EnableBit(int offset)
        {
            ValidateOffset(offset);
            buttons |= unchecked((ushort)(1 << offset));
        }

        internal void DisableBit(int offset)
        {
            ValidateOffset(offset);
            buttons &= unchecked((ushort)~(1 << offset));
        }

        internal void MergeBits(MouseState other)
        {
            buttons |= other.buttons;
            SetScrollRelative(other.scroll.X, other.scroll.Y);
            X += other.X;
            Y += other.Y;
            IsConnected |= other.IsConnected;
        }

        internal void SetIsConnected(bool value)
        {
            IsConnected = value;
        }

        internal void SetScrollAbsolute(float x, float y)
        {
            scroll.X = x;
            scroll.Y = y;
        }

        internal void SetScrollRelative(float x, float y)
        {
            scroll.X += x;
            scroll.Y += y;
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
                buttons == other.buttons &&
                X == other.X &&
                Y == other.Y &&
                Scroll == other.Scroll;
        }
    }
}