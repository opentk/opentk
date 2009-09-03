using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Input
{
    /// <summary>
    /// Encapsulates the state of a keyboard device.
    /// </summary>
    public struct KeyboardState : IEquatable<KeyboardState>
    {
        #region Constructors

        internal KeyboardState(Key[] keys)
        {
        }

        #endregion

        #region Public Members

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
