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
        const int NumInts = ((int)MouseButton.LastButton + 31) / 32;
        // The following line triggers bogus CS0214 in gmcs 2.0.1, sigh...
        unsafe fixed int Buttons[NumInts];

        #endregion

        #region Public Members

        /// <summary>
        /// Gets a <see cref="System.Boolean"/> indicating whether this button is down.
        /// </summary>
        /// <param name="button">The <see cref="OpenTK.Input.MouseButton"/> to check.</param>
        public bool IsKeyDown(MouseButton button)
        {
            return ReadBit((int)button);
        }

        /// <summary>
        /// Gets a <see cref="System.Boolean"/> indicating whether this button is up.
        /// </summary>
        /// <param name="button">The <see cref="OpenTK.Input.MouseButton"/> to check.</param>
        public bool IsKeyUp(MouseButton button)
        {
            return !ReadBit((int)button);
        }

        #endregion

        #region Internal Members

        internal bool ReadBit(int offset)
        {
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
                fixed (int* b1 = Buttons)
                fixed (int* b2 = other.Buttons)
                {
                    for (int i = 0; equal && i < NumInts; i++)
                        equal &= *(b1 + i) == *(b2 + i);
                }
            }
            return equal;
        }

        #endregion
    }
}
