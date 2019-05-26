//
// KeyboardState.cs
//
// Copyright (C) 2018 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;

namespace OpenToolkit.Windowing.Common.Input
{
    /// <summary>
    /// Encapsulates the state of a Keyboard device.
    /// </summary>
    public struct KeyboardState : IEquatable<KeyboardState>
    {
        // Allocate enough ints to store all keyboard keys
        private const int IntSize = sizeof(int) * 8;

        private const int NumInts = ((int)Key.LastKey + IntSize - 1) / IntSize;

        // The following line triggers bogus CS0214 in gmcs 2.0.1, sigh...
        private unsafe fixed int _keys[NumInts];

        /// <summary>
        /// Gets a <see cref="bool" /> indicating whether the specified
        ///  <see cref="Key" /> is pressed.
        /// </summary>
        /// <param name="key">The <see cref="Key" /> to check.</param>
        /// <returns><c>true</c> if key is pressed; <c>false</c> otherwise.</returns>
        public bool this[Key key]
        {
            get => IsKeyDown(key);
            internal set => SetKeyState(key, value);
        }

        /// <summary>
        /// Gets a <see cref="bool" /> indicating whether the specified
        ///  <see cref="OpenToolkit.Windowing.Common.Input.Key" /> is pressed.
        /// </summary>
        /// <param name="code">The scancode to check.</param>
        /// <returns><c>true</c> if code is pressed; <c>false</c> otherwise.</returns>
        public bool this[short code] => IsKeyDown((Key)code);

        /// <summary>
        /// Gets a <see cref="bool" /> indicating whether this key is down.
        /// </summary>
        /// <param name="key">The <see cref="Key" /> to check.</param>
        /// <returns><c>true</c> if <paramref name="key"/> is in the down state; otherwise, <c>false</c>.</returns>
        public bool IsKeyDown(Key key)
        {
            return ReadBit((int)key);
        }

        /// <summary>
        /// Gets a <see cref="bool" /> indicating whether this scan code is down.
        /// </summary>
        /// <param name="code">The scan code to check.</param>
        /// <returns>
        /// <c>true</c> if the key given by the <paramref name="code"/> parameter is in the down state;
        /// otherwise, <c>false</c>.
        /// </returns>
        public bool IsKeyDown(short code)
        {
            return code >= 0 && code < (short)Key.LastKey && ReadBit(code);
        }

        /// <summary>
        /// Gets a <see cref="bool" /> indicating whether this key is up.
        /// </summary>
        /// <param name="key">The <see cref="Key" /> to check.</param>
        /// <returns><c>true</c> if <paramref name="key"/> is in the up state; otherwise, <c>false</c>.</returns>
        public bool IsKeyUp(Key key)
        {
            return !ReadBit((int)key);
        }

        /// <summary>
        /// Gets a <see cref="bool" /> indicating whether this scan code is down.
        /// </summary>
        /// <param name="code">The scan code to check.</param>
        /// <returns>
        /// <c>true</c> if the key given by the <paramref name="code"/> parameter is in the up state;
        /// otherwise, <c>false</c>.
        /// </returns>
        public bool IsKeyUp(short code)
        {
            return !IsKeyDown(code);
        }

        /// <summary>
        /// Gets a value indicating whether any key is down.
        /// </summary>
        /// <value><c>true</c> if any key is down; otherwise, <c>false</c>.</value>
        public bool IsAnyKeyDown
        {
            get
            {
                // If any bit is set then a key is down.
                unsafe
                {
                    fixed (int* k = _keys)
                    {
                        for (var i = 0; i < NumInts; ++i)
                        {
                            if (k[i] != 0)
                            {
                                return true;
                            }
                        }
                    }
                }

                return false;
            }
        }

        /// <summary>
        /// Gets a value indicating whether this keyboard
        /// is connected.
        /// </summary>
        public bool IsConnected { get; internal set; }

        /// <summary>
        /// Checks whether two <see cref="KeyboardState" /> instances are equal.
        /// </summary>
        /// <param name="left">
        /// The first <see cref="KeyboardState" /> instance to compare.
        /// </param>
        /// <param name="right">
        /// The second <see cref="KeyboardState" /> instance to compare.
        /// </param>
        /// <returns>
        /// <c>true</c> if both left is equal to right; <c>false</c> otherwise.
        /// </returns>
        public static bool operator ==(KeyboardState left, KeyboardState right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// Checks whether two <see cref="KeyboardState" /> instances are not equal.
        /// </summary>
        /// <param name="left">
        /// The first <see cref="KeyboardState" /> instance to compare.
        /// </param>
        /// <param name="right">
        /// The second <see cref="KeyboardState" /> instance to compare.
        /// </param>
        /// <returns>
        /// <c>true</c> if both left is not equal to right; <c>false</c> otherwise.
        /// </returns>
        public static bool operator !=(KeyboardState left, KeyboardState right)
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
        /// <c>true</c> if this instance is equal to obj; <c>false</c> otherwise.
        /// </returns>
        public override bool Equals(object obj)
        {
            if (obj is KeyboardState)
            {
                return this == (KeyboardState)obj;
            }

            return false;
        }

        /// <summary>
        /// Generates a hashcode for the current instance.
        /// </summary>
        /// <returns>
        /// A <see cref="int" /> representing the hashcode for this instance.
        /// </returns>
        public override int GetHashCode()
        {
            unsafe
            {
                fixed (int* k = _keys)
                {
                    var hashcode = 0;
                    for (var i = 0; i < NumInts; i++)
                    {
                        hashcode ^= (k + i)->GetHashCode();
                    }

                    return hashcode;
                }
            }
        }

        /// <summary>
        /// Sets the key state of the <paramref name="key"/> depending on the given <paramref name="down"/> value.
        /// </summary>
        /// <param name="key">The <see cref="Key"/> which state should be changed.</param>
        /// <param name="down">The new state the key should be changed to.</param>
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

        /// <summary>
        /// Gets whether a single key is pressed using an offset corresponding to a <see cref="Key"/>.
        /// </summary>
        /// <param name="offset">The offset corresponding to a <see cref="Key"/>.</param>
        /// <returns>
        /// <c>true</c> when the key given by <paramref name="offset"/> is pressed; otherwise, <c>false</c>.
        /// </returns>
        internal bool ReadBit(int offset)
        {
            ValidateOffset(offset);

            var intOffset = offset / IntSize;
            var bitOffset = offset % IntSize;
            unsafe
            {
                fixed (int* k = _keys)
                {
                    return (*(k + intOffset) & (1 << bitOffset)) != 0u;
                }
            }
        }

        /// <summary>
        /// Enable a single key using an offset corresponding to a <see cref="Key"/>.
        /// </summary>
        /// <param name="offset">The offset corresponding to a <see cref="Key"/>.</param>
        internal void EnableBit(int offset)
        {
            ValidateOffset(offset);

            var intOffset = offset / IntSize;
            var bitOffset = offset % IntSize;
            unsafe
            {
                fixed (int* k = _keys)
                {
                    *(k + intOffset) |= 1 << bitOffset;
                }
            }
        }

        /// <summary>
        /// Disables a single key using an offset corresponding to a <see cref="Key"/>.
        /// </summary>
        /// <param name="offset">The offset corresponding to a <see cref="Key"/>.</param>
        internal void DisableBit(int offset)
        {
            ValidateOffset(offset);

            var intOffset = offset / IntSize;
            var bitOffset = offset % IntSize;
            unsafe
            {
                fixed (int* k = _keys)
                {
                    *(k + intOffset) &= ~(1 << bitOffset);
                }
            }
        }

        /// <summary>
        /// Merges this <see cref="KeyboardState"/> with an <paramref name="other"/>.
        /// </summary>
        /// <param name="other">The <paramref name="other"/> <see cref="KeyboardState"/> with which to merge.</param>
        internal void MergeBits(KeyboardState other)
        {
            unsafe
            {
                var k2 = other._keys;
                fixed (int* k1 = _keys)
                {
                    for (var i = 0; i < NumInts; i++)
                    {
                        *(k1 + i) |= *(k2 + i);
                    }
                }
            }

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

        private static void ValidateOffset(int offset)
        {
            if (offset < 0 || offset >= NumInts * IntSize)
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        /// <summary>
        /// Compares two KeyboardState instances.
        /// </summary>
        /// <param name="other">The instance to compare two.</param>
        /// <returns><c>true</c>, if both instances are equal; <c>false</c> otherwise.</returns>
        public bool Equals(KeyboardState other)
        {
            var equal = true;
            unsafe
            {
                var k2 = other._keys;
                fixed (int* k1 = _keys)
                {
                    for (var i = 0; equal && i < NumInts; i++)
                    {
                        equal &= *(k1 + i) == *(k2 + i);
                    }
                }
            }

            return equal;
        }
    }
}
