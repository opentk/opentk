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
using System.Text;

namespace OpenTK.Windowing.GraphicsLibraryFramework
{
    /// <summary>
    ///     Encapsulates the state of a Keyboard device.
    /// </summary>
    public class KeyboardState
    {
        // These arrays will mostly be empty since the last integer used is 384. That's only 48 bytes though.
        private readonly BitArray _keys = new BitArray((int)Keys.LastKey + 1);
        private readonly BitArray _keysPrevious = new BitArray((int)Keys.LastKey + 1);

        private KeyboardState(KeyboardState source)
        {
            _keys = (BitArray)source._keys.Clone();
            _keysPrevious = (BitArray)source._keysPrevious.Clone();
        }

        internal KeyboardState()
        {
        }

        /// <summary>
        ///     Gets a <see cref="bool" /> indicating whether the specified
        ///     <see cref="Key" /> is currently down.
        /// </summary>
        /// <param name="key">The <see cref="Key" /> to check.</param>
        /// <returns><c>true</c> if key is down; <c>false</c> otherwise.</returns>
        public bool this[Keys key]
        {
            get => IsKeyDown(key);
            private set => SetKeyState(key, value);
        }

        /// <summary>
        ///     Gets a value indicating whether any key is currently down.
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
        ///     Gets a <see cref="bool" /> indicating whether this key is currently down.
        /// </summary>
        /// <param name="key">The <see cref="Key" /> to check.</param>
        /// <returns><c>true</c> if <paramref name="key" /> is in the down state; otherwise, <c>false</c>.</returns>
        public bool IsKeyDown(Keys key) => _keys[(int)key];

        /// <summary>
        ///     Sets the key state of the <paramref name="key" /> depending on the given <paramref name="down" /> value.
        /// </summary>
        /// <param name="key">The <see cref="Key" /> which state should be changed.</param>
        /// <param name="down">The new state the key should be changed to.</param>
        internal void SetKeyState(Keys key, bool down)
        {
            _keys[(int)key] = down;
        }

        /// <inheritdoc />
        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.Append('{');
            var first = true;

            for (Keys key = 0; key <= Keys.LastKey; key++)
            {
                if (IsKeyDown(key))
                {
                    builder.AppendFormat("{0}{1}", key, !first ? ", " : string.Empty);
                    first = false;
                }
            }

            builder.Append('}');

            return builder.ToString();
        }

        internal void Update()
        {
            _keysPrevious.SetAll(false);
            _keysPrevious.Or(_keys);
        }

        /// <summary>
        ///     Gets a <see cref="bool" /> indicating whether this key was down in the previous frame.
        /// </summary>
        /// <param name="key">The <see cref="Key" /> to check.</param>
        /// <returns><c>true</c> if <paramref name="key" /> was in the down state; otherwise, <c>false</c>.</returns>
        public bool WasKeyDown(Keys key) => _keysPrevious[(int)key];

        /// <summary>
        ///     Gets an immutable snapshot of this KeyboardState.
        ///     This can be used to save the current keyboard state for comparison later on.
        /// </summary>
        /// <returns>Returns an immutable snapshot of this KeyboardState.</returns>
        public KeyboardState GetSnapshot() => new KeyboardState(this);
    }
}
