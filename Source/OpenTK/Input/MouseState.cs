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
        #region Constructors

        internal MouseState(MouseButton[] buttons)
        {
        }

        #endregion

        #region IEquatable<MouseState> Members

        /// <summary>
        /// Compares two MouseState instances for equality.
        /// </summary>
        /// <param name="other">The instance to compare to.</param>
        /// <returns>True, if both instances are equal; false otherwise.</returns>
        public bool Equals(MouseState other)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
