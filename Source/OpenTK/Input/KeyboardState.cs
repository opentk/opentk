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
using System.Collections.Specialized;
using System.Text;

namespace OpenTK.Input
{
    /// <summary>
    /// Encapsulates the state of a Keyboard device.
    /// </summary>
    public struct KeyboardState : IEquatable<KeyboardState>
    {
        #region Fields

        // Allocate enough ints to store all keyboard keys
        const int IntSize = sizeof(int);
        const int NumInts = ((int)Key.LastKey + IntSize - 1) / IntSize;
        // The following line triggers bogus CS0214 in gmcs 2.0.1, sigh...
        unsafe fixed int Keys[NumInts];
        bool is_connected;

        #endregion

        #region Public Members

        /// <summary>
        /// Gets a <see cref="System.Boolean"/> indicating whether the specified
        /// <see cref="OpenTK.Input.Key"/> is pressed.
        /// </summary>
        /// <param name="key">The <see cref="OpenTK.Input.Key"/> to check.</param>
        /// <returns>True if key is pressed; false otherwise.</returns>
        public bool this[Key key]
        {
            get { return IsKeyDown(key); }
            internal set { SetKeyState(key, value); }
        }

        /// <summary>
        /// Gets a <see cref="System.Boolean"/> indicating whether the specified
        /// <see cref="OpenTK.Input.Key"/> is pressed.
        /// </summary>
        /// <param name="code">The scancode to check.</param>
        /// <returns>True if code is pressed; false otherwise.</returns>
        public bool this[short code]
        {
            get { return IsKeyDown((Key)code); }
        }

        /// <summary>
        /// Gets a <see cref="System.Boolean"/> indicating whether this key is down.
        /// </summary>
        /// <param name="key">The <see cref="OpenTK.Input.Key"/> to check.</param>
        public bool IsKeyDown(Key key)
        {
            return ReadBit((int)key);
        }

        /// <summary>
        /// Gets a <see cref="System.Boolean"/> indicating whether this scan code is down.
        /// </summary>
        /// <param name="code">The scan code to check.</param>
        public bool IsKeyDown(short code)
        {
            return code >= 0 && code < (short)Key.LastKey && ReadBit(code);
        }

        /// <summary>
        /// Gets a <see cref="System.Boolean"/> indicating whether this key is up.
        /// </summary>
        /// <param name="key">The <see cref="OpenTK.Input.Key"/> to check.</param>
        public bool IsKeyUp(Key key)
        {
            return !ReadBit((int)key);
        }

        /// <summary>
        /// Gets a <see cref="System.Boolean"/> indicating whether this scan code is down.
        /// </summary>
        /// <param name="code">The scan code to check.</param>
        public bool IsKeyUp(short code)
        {
            return !IsKeyDown(code);
        }

        /// <summary>
        /// Gets a <see cref="System.Boolean"/> indicating whether this keyboard
        /// is connected.
        /// </summary>
        public bool IsConnected
        {
            get { return is_connected; }
            internal set { is_connected = value; }
        }

#if false
        // Disabled until the correct cross-platform API can be determined.
        public bool IsLedOn(KeyboardLeds led)
        {
            return false;
        }

        public bool IsLedOff(KeyboardLeds led)
        {
            return false;
        }
#endif

        /// <summary>
        /// Checks whether two <see cref="KeyboardState" /> instances are equal.
        /// </summary>
        /// <param name="left">
        /// A <see cref="KeyboardState"/> instance.
        /// </param>
        /// <param name="right">
        /// A <see cref="KeyboardState"/> instance.
        /// </param>
        /// <returns>
        /// True if both left is equal to right; false otherwise.
        /// </returns>
        public static bool operator ==(KeyboardState left, KeyboardState right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// Checks whether two <see cref="KeyboardState" /> instances are not equal.
        /// </summary>
        /// <param name="left">
        /// A <see cref="KeyboardState"/> instance.
        /// </param>
        /// <param name="right">
        /// A <see cref="KeyboardState"/> instance.
        /// </param>
        /// <returns>
        /// True if both left is not equal to right; false otherwise.
        /// </returns>
        public static bool operator !=(KeyboardState left, KeyboardState right)
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
            if (obj is KeyboardState)
            {
                return this == (KeyboardState)obj;
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
                fixed (int* k = Keys)
                {
                    int hashcode = 0;
                    for (int i = 0; i < NumInts; i++)
                        hashcode ^= (k + i)->GetHashCode();
                    return hashcode;
                }
            }
        }

        #endregion

        #region Internal Members

        internal void SetKeyState(Key key, bool down)
        {
            if (down)
            {
                EnableBit((int)key);
            }
            else
            {
                DisableBit((int)key);
            }
        }

        internal bool ReadBit(int offset)
        {
            ValidateOffset(offset);

            int int_offset = offset / 32;
            int bit_offset = offset % 32;
            unsafe
            {
                fixed (int* k = Keys) { return (*(k + int_offset) & (1 << bit_offset)) != 0u; }
            }
        }

        internal void EnableBit(int offset)
        {
            ValidateOffset(offset);

            int int_offset = offset / 32;
            int bit_offset = offset % 32;
            unsafe
            {
                fixed (int* k = Keys) { *(k + int_offset) |= 1 << bit_offset; }
            }
        }

        internal void DisableBit(int offset)
        {
            ValidateOffset(offset);

            int int_offset = offset / 32;
            int bit_offset = offset % 32;
            unsafe
            {
                fixed (int* k = Keys) { *(k + int_offset) &= ~(1 << bit_offset); }
            }
        }

        internal void MergeBits(KeyboardState other)
        {
            unsafe
            {
                int* k2 = other.Keys;
                fixed (int* k1 = Keys)
                {
                    for (int i = 0; i < NumInts; i++)
                        *(k1 + i) |= *(k2 + i);
                }
            }
            IsConnected |= other.IsConnected;
        }

        internal void SetIsConnected(bool value)
        {
            IsConnected = value;
        }

        #endregion

        #region Private Members

        static void ValidateOffset(int offset)
        {
            if (offset < 0 || offset >= NumInts * IntSize)
                throw new ArgumentOutOfRangeException();
        }

        #endregion

        #region IEquatable<KeyboardState> Members

        /// <summary>
        /// Compares two KeyboardState instances.
        /// </summary>
        /// <param name="other">The instance to compare two.</param>
        /// <returns>True, if both instances are equal; false otherwise.</returns>
        public bool Equals(KeyboardState other)
        {
            bool equal = true;
            unsafe
            {
                int* k2 = other.Keys;
                fixed (int* k1 = Keys)
                {
                    for (int i = 0; equal && i < NumInts; i++)
                        equal &= *(k1 + i) == *(k2 + i);
                }
            }
            return equal;
        }

        #endregion
    }
}
