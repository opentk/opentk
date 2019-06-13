//
// KeyboardState.cs
//
// Copyright (C) 2018 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using System.Diagnostics;
using System.Text;

namespace OpenToolkit.Windowing.Common.Input
{
    /// <summary>
    /// Encapsulates the state of a Keyboard device.
    /// </summary>
    public struct KeyboardState : IEquatable<KeyboardState>
    {
        // Allocate enough ints to store all keyboard keys
        private const int ByteSize = 8;

        private const int NumBytes = ((int)Key.LastKey + ByteSize) / ByteSize;

        private unsafe fixed int _keys[NumBytes];

        /// <summary>
        /// Gets a <see cref="bool" /> indicating whether the specified
        ///  <see cref="Key" /> is currently down.
        /// </summary>
        /// <param name="key">The <see cref="Key" /> to check.</param>
        /// <returns><c>true</c> if key is down; <c>false</c> otherwise.</returns>
        public bool this[Key key]
        {
            get => IsKeyDown(key);
            set => SetKeyState(key, value);
        }

        /// <summary>
        /// Gets a <see cref="bool" /> indicating whether this key is currently down.
        /// </summary>
        /// <param name="key">The <see cref="Key" /> to check.</param>
        /// <returns><c>true</c> if <paramref name="key"/> is in the down state; otherwise, <c>false</c>.</returns>
        public unsafe bool IsKeyDown(Key key)
        {
            if (key <= Key.Unknown || key > Key.LastKey)
            {
                throw new ArgumentOutOfRangeException(nameof(key), "Invalid key");
            }

            var offset = (int)key;
            ValidateOffset(offset);

            var intOffset = offset / ByteSize;
            var bitOffset = offset % ByteSize;
            return (this._keys[intOffset] & (1 << bitOffset)) != 0;
        }

        /// <summary>
        /// Gets a <see cref="bool" /> indicating whether this key is currently up.
        /// </summary>
        /// <param name="key">The <see cref="Key" /> to check.</param>
        /// <returns><c>true</c> if <paramref name="key"/> is in the up state; otherwise, <c>false</c>.</returns>
        public bool IsKeyUp(Key key)
        {
            return !IsKeyDown(key);
        }

        /// <summary>
        /// Gets a value indicating whether any key is currently down.
        /// </summary>
        /// <value><c>true</c> if any key is down; otherwise, <c>false</c>.</value>
        public unsafe bool IsAnyKeyDown
        {
            get
            {
                for (var i = 0; i < NumBytes; ++i)
                {
                    if (this._keys[i] != 0)
                    {
                        return true;
                    }
                }

                return false;
            }
        }

        /// <summary>
        /// Sets the key state of the <paramref name="key"/> depending on the given <paramref name="down"/> value.
        /// </summary>
        /// <param name="key">The <see cref="Key"/> which state should be changed.</param>
        /// <param name="down">The new state the key should be changed to.</param>
        public unsafe void SetKeyState(Key key, bool down)
        {
            if (key <= Key.Unknown || key > Key.LastKey)
            {
                throw new ArgumentOutOfRangeException(nameof(key), "Invalid key");
            }

            var offset = (int)key;
            ValidateOffset(offset);

            var intOffset = offset / ByteSize;
            var bitOffset = offset % ByteSize;

            if (down)
            {
                this._keys[intOffset] |= 1 << bitOffset;
            }
            else
            {
                this._keys[intOffset] &= ~(1 << bitOffset);
            }
        }

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
            if (obj is KeyboardState state)
            {
                return Equals(state);
            }

            return false;
        }

        /// <summary>
        /// Compares two KeyboardState instances.
        /// </summary>
        /// <param name="other">The instance to compare two.</param>
        /// <returns><c>true</c>, if both instances are equal; <c>false</c> otherwise.</returns>
        public unsafe bool Equals(KeyboardState other)
        {
            for (var i = 0; i < NumBytes; i++)
            {
                if (this._keys[i] != other._keys[i])
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Generates a hashcode for the current instance.
        /// </summary>
        /// <returns>
        /// A <see cref="int" /> representing the hashcode for this instance.
        /// </returns>
        public override unsafe int GetHashCode()
        {
            var hashcode = 0;
            for (var i = 0; i < NumBytes; i++)
            {
                hashcode ^= 397 * this._keys[i];
            }

            return hashcode;
        }

        /// <inheritdoc />
        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.Append('{');
            var first = true;

            for (var key = (Key)1; key <= Key.LastKey; ++key)
            {
                if (IsKeyDown(key))
                {
                    if (!first)
                    {
                        builder.Append(',');
                    }
                    else
                    {
                        first = false;
                    }

                    builder.Append(key);
                }
            }

            builder.Append('}');

            return builder.ToString();
        }

        // This shouldn't be necessary but I'll keep it in just in case.
        [Conditional("DEBUG")]
        private static void ValidateOffset(int offset)
        {
            if (offset < 0 || offset >= NumBytes * ByteSize)
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}
