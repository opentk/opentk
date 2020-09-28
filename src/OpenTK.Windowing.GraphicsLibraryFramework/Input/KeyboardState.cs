//
// KeyboardState.cs
//
// Copyright (C) 2018 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using System.Collections;
using System.Diagnostics;
using System.Text;
using OpenTK.Windowing.Common;

namespace OpenTK.Windowing.GraphicsLibraryFramework
{
    /// <summary>
    /// Encapsulates the state of a Keyboard device.
    /// </summary>
    public sealed class KeyboardState
    {
	    // These arrays will mostly be empty since the last integer used is 384. That's only 48 bytes though.
        private BitArray _keys = new BitArray((int)Keys.LastKey);
        private BitArray _keysPrevious = new BitArray((int)Keys.LastKey);

        private static readonly Keys[] KeyValues;

        private KeyboardState(KeyboardState source)
        {
	        _keys = (BitArray)source._keys.Clone();
	        _keysPrevious = (BitArray)source._keysPrevious.Clone();
        }

        internal KeyboardState()
        {
        }

        static KeyboardState()
        {
	        // All this really does is copy the clumsy Array of objects
	        // with no indexer into a strongly typed array with an indexer.
	        Array enumValues = Enum.GetValues(typeof(Keys));
	        KeyValues = new Keys[enumValues.Length];
	        Array.Copy(enumValues, KeyValues, enumValues.Length);
        }

        /// <summary>
        /// Gets a <see cref="bool" /> indicating whether the specified
        ///  <see cref="Key" /> is currently down.
        /// </summary>
        /// <param name="key">The <see cref="Key" /> to check.</param>
        /// <returns><c>true</c> if key is down; <c>false</c> otherwise.</returns>
        public bool this[Keys key]
        {
            get => IsKeyDown(key);
            private set => SetKeyState(key, value);
        }

        /// <summary>
        /// Gets a <see cref="bool" /> indicating whether this key is currently down.
        /// </summary>
        /// <param name="key">The <see cref="Key" /> to check.</param>
        /// <returns><c>true</c> if <paramref name="key"/> is in the down state; otherwise, <c>false</c>.</returns>
        public bool IsKeyDown(Keys key)
        {
	        return _keys[(int)key];
        }

        /// <summary>
        /// Gets a value indicating whether any key is currently down.
        /// </summary>
        /// <value><c>true</c> if any key is down; otherwise, <c>false</c>.</value>
        public bool IsAnyKeyDown
        {
            get
            {
                for (var i = 0; i < _keys.Length; ++i)
                {
	                if (_keys[i])
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
        internal void SetKeyState(Keys key, bool down)
        {
	        _keys[(int)key] = down;
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

        /// <inheritdoc />
        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.Append('{');
            var first = true;

            foreach (Keys key in KeyValues)
            {
                if (IsKeyDown(key))
                {
                    builder.AppendFormat("{0}{1}", key, !first ? ", " : string.Empty);
                }
            }

            builder.Append('}');

            return builder.ToString();
        }

        internal void Update()
        {
	        Utils.Swap(ref _keys, ref _keysPrevious);
        }

        /// <summary>
        /// Gets a <see cref="bool" /> indicating whether this key was down in the previous frame.
        /// </summary>
        /// <param name="key">The <see cref="Key" /> to check.</param>
        /// <returns><c>true</c> if <paramref name="key"/> was in the down state; otherwise, <c>false</c>.</returns>
        public bool WasKeyDown(Keys key)
        {
	        return _keysPrevious[(int)key];
        }

        /// <summary>
        /// Gets an immutable snapshot of this KeyboardState.
        /// </summary>
        /// <returns>Returns an immutable snapshot of this KeyboardState.
        /// This can be used to save the current keyboard state for comparison later on.</returns>
        public KeyboardState GetSnapshot() => new KeyboardState(this);
    }
}
