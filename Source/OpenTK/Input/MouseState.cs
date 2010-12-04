 #region License
 //
 // The Open Toolkit Library License
 //
 // Copyright (c) 2006 - 2009 the Open Toolkit library.
 //
 // Permission is hereby granted, free of charge, to any person obtaining a copy
 // of this software and associated documentation files (the "Software"), to deal
 // in the Software without restriction, including without limitation the rights to 
 // use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
 // the Software, and to permit persons to whom the Software is furnished to do
 // so, subject to the following conditions:
 //
 // The above copyright notice and this permission notice shall be included in all
 // copies or substantial portions of the Software.
 //
 // THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 // EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 // OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 // NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 // HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 // WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 // FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 // OTHER DEALINGS IN THE SOFTWARE.
 //
 #endregion

using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Input
{
    /// <summary>
    /// Encapsulates the state of a mouse device.
    /// </summary>
    public struct MouseState : IEquatable<MouseState>
    {
        #region Fields

        // Allocate enough ints to store all mouse buttons
        const int IntSize = sizeof(int);
        const int NumInts = ((int)MouseButton.LastButton + IntSize - 1) / IntSize;
        // The following line triggers bogus CS0214 in gmcs 2.0.1, sigh...
        unsafe fixed int Buttons[NumInts];
        int x, y;
        float wheel;
        bool is_connected;

        #endregion

        #region Public Members

        /// <summary>
        /// Gets a <see cref="System.Boolean"/> indicating whether the specified
        /// <see cref="OpenTK.Input.MouseButton"/> is pressed.
        /// </summary>
        /// <param name="button">The <see cref="OpenTK.Input.MouseButton"/> to check.</param>
        /// <returns>True if key is pressed; false otherwise.</returns>
        public bool this[MouseButton button]
        {
            get { return IsButtonDown(button); }
            internal set
            {
                if (value)
                    EnableBit((int)button);
                else
                    DisableBit((int)button);
            }
        }

        /// <summary>
        /// Gets a <see cref="System.Boolean"/> indicating whether this button is down.
        /// </summary>
        /// <param name="button">The <see cref="OpenTK.Input.MouseButton"/> to check.</param>
        public bool IsButtonDown(MouseButton button)
        {
            return ReadBit((int)button);
        }

        /// <summary>
        /// Gets a <see cref="System.Boolean"/> indicating whether this button is up.
        /// </summary>
        /// <param name="button">The <see cref="OpenTK.Input.MouseButton"/> to check.</param>
        public bool IsButtonUp(MouseButton button)
        {
            return !ReadBit((int)button);
        }

        /// <summary>
        /// Gets the absolute wheel position in integer units.
        /// To support high-precision mice, it is recommended to use <see cref="WheelPrecise"/> instead.
        /// </summary>
        public int Wheel
        {
            get { return (int)Math.Round(wheel, MidpointRounding.AwayFromZero); }
        }

        /// <summary>
        /// Gets the absolute wheel position in floating-point units.
        /// </summary>
        public float WheelPrecise
        {
            get { return wheel; }
            internal set
            {
                wheel = value;
            }
        }

        /// <summary>
        /// Gets an integer representing the absolute x position of the pointer, in window pixel coordinates.
        /// </summary>
        public int X
        {
            get { return x; }
            internal set { x = value; }
        }

        /// <summary>
        /// Gets an integer representing the absolute y position of the pointer, in window pixel coordinates.
        /// </summary>
        public int Y
        {
            get { return y; }
            internal set { y = value; }
        }

        /// <summary>
        /// Gets a <see cref="System.Boolean"/> indicating whether the left mouse button is pressed.
        /// This property is intended for XNA compatibility.
        /// </summary>
        public ButtonState LeftButton
        {
            get { return IsButtonDown(MouseButton.Left) ? ButtonState.Pressed : ButtonState.Released; }
        }

        /// <summary>
        /// Gets a <see cref="System.Boolean"/> indicating whether the middle mouse button is pressed.
        /// This property is intended for XNA compatibility.
        /// </summary>
        public ButtonState MiddleButton
        {
            get { return IsButtonDown(MouseButton.Middle) ? ButtonState.Pressed : ButtonState.Released; }
        }

        /// <summary>
        /// Gets a <see cref="System.Boolean"/> indicating whether the right mouse button is pressed.
        /// This property is intended for XNA compatibility.
        /// </summary>
        public ButtonState RightButton
        {
            get { return IsButtonDown(MouseButton.Right) ? ButtonState.Pressed : ButtonState.Released; }
        }

        /// <summary>
        /// Gets a <see cref="System.Boolean"/> indicating whether the first extra mouse button is pressed.
        /// This property is intended for XNA compatibility.
        /// </summary>
        public ButtonState XButton1
        {
            get { return IsButtonDown(MouseButton.Button1) ? ButtonState.Pressed : ButtonState.Released; }
        }

        /// <summary>
        /// Gets a <see cref="System.Boolean"/> indicating whether the second extra mouse button is pressed.
        /// This property is intended for XNA compatibility.
        /// </summary>
        public ButtonState XButton2
        {
            get { return IsButtonDown(MouseButton.Button2) ? ButtonState.Pressed : ButtonState.Released; }
        }

        /// <summary>
        /// Gets the absolute wheel position in integer units. This property is intended for XNA compatibility.
        /// To support high-precision mice, it is recommended to use <see cref="WheelPrecise"/> instead.
        /// </summary>
        public int ScrollWheelValue
        {
            get { return Wheel; }
        }

        public bool IsConnected
        {
            get { return is_connected; }
            internal set { is_connected = value; }
        }

        /// <summary>
        /// Checks whether two <see cref="MouseState" /> instances are equal.
        /// </summary>
        /// <param name="left">
        /// A <see cref="MouseState"/> instance.
        /// </param>
        /// <param name="right">
        /// A <see cref="MouseState"/> instance.
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
        /// A <see cref="MouseState"/> instance.
        /// </param>
        /// <param name="right">
        /// A <see cref="MouseState"/> instance.
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
        /// The <see cref="System.Object"/> to compare to.
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
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Generates a hashcode for the current instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.Int32"/> represting the hashcode for this instance.
        /// </returns>
        public override int GetHashCode()
        {
            unsafe
            {
                fixed (int* b = Buttons)
                {
                    return b->GetHashCode() ^ X.GetHashCode() ^ Y.GetHashCode() ^ WheelPrecise.GetHashCode();
                }
            }
        }

        #endregion

        #region Internal Members

        internal bool ReadBit(int offset)
        {
            ValidateOffset(offset);

            int int_offset = offset / 32;
            int bit_offset = offset % 32;
            unsafe
            {
                fixed (int* b = Buttons)
                {
                    return (*(b + int_offset) & (1 << bit_offset)) != 0u;
                }
            }
        }

        internal void EnableBit(int offset)
        {
            ValidateOffset(offset);

            int int_offset = offset / 32;
            int bit_offset = offset % 32;
            unsafe
            {
                fixed (int* b = Buttons)
                {
                    *(b + int_offset) |= 1 << bit_offset;
                }
            }
        }

        internal void DisableBit(int offset)
        {
            ValidateOffset(offset);

            int int_offset = offset / 32;
            int bit_offset = offset % 32;
            unsafe
            {
                fixed (int* b = Buttons)
                {
                    *(b + int_offset) &= ~(1 << bit_offset);
                }
            }
        }

        internal void MergeBits(MouseState other)
        {
            unsafe
            {
                int* b2 = other.Buttons;
                fixed (int* b1 = Buttons)
                {
                    for (int i = 0; i < NumInts; i++)
                        *(b1 + i) |= *(b2 + i);
                }

                WheelPrecise += other.WheelPrecise;
                X += other.X;
                Y += other.Y;
                IsConnected |= other.IsConnected;
            }
        }

        #endregion

        #region Private Members

        static void ValidateOffset(int offset)
        {
            if (offset < 0 || offset >= NumInts * IntSize)
                throw new ArgumentOutOfRangeException("offset");
        }

        #endregion

        #region IEquatable<MouseState> Members

        /// <summary>
        /// Compares two MouseState instances.
        /// </summary>
        /// <param name="other">The instance to compare two.</param>
        /// <returns>True, if both instances are equal; false otherwise.</returns>
        public bool Equals(MouseState other)
        {
            bool equal = true;
            unsafe
            {
                int* b2 = other.Buttons;
                fixed (int* b1 = Buttons)
                {
                    for (int i = 0; equal && i < NumInts; i++)
                        equal &= *(b1 + i) == *(b2 + i);
                }
                equal &= X == other.X && Y == other.Y && WheelPrecise == other.WheelPrecise;
            }
            return equal;
        }

        #endregion
    }
}
