using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Input
{
    /// <summary>
    /// Encapsulates the state of a Keyboard device.
    /// </summary>
    public struct KeyboardState : IEquatable<KeyboardState>
    {
        #region Fields

        const int NumKeys = ((int)Key.LastKey + 16) / 32;
        unsafe fixed int Keys[NumKeys];

        #endregion

        #region Constructors

        #endregion

        #region Public Members

        /// <summary>
        /// Gets a <see cref="System.Boolean"/> indicating whether this key is down.
        /// </summary>
        /// <param name="key">The <see cref="OpenTK.Input.Key"/> to check.</param>
        public bool IsKeyDown(Key key)
        {
            return ReadBit((int)key) != 0;
        }

        /// <summary>
        /// Gets a <see cref="System.Boolean"/> indicating whether this key is up.
        /// </summary>
        /// <param name="key">The <see cref="OpenTK.Input.Key"/> to check.</param>
        public bool IsKeyUp(Key key)
        {
            return ReadBit((int)key) == 0;
        }

        #endregion

        #region Internal Members

        internal int ReadBit(int offset)
        {
            return 0;
            //unsafe { return (Keys[(offset / 32)] & (1 << (offset % 32))); }
        }

        internal enum BitValue { Zero = 0, One = 1 }
        internal void WriteBit(int offset, BitValue bit)
        {
            // Todo: this is completely broken.
            //unsafe { Keys[offset / 32] = Keys[offset / 32] ^ (~(int)bit << (offset % 32)); }
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
            throw new NotImplementedException();
        }

        #endregion
    }
}
