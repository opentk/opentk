// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.

using System;

namespace OpenTK.Input
{
    /// <summary>
    /// Represents the state of a mouse wheel.
    /// </summary>
    public struct MouseScroll : IEquatable<MouseScroll>
    {
        #region Public Members

        /// <summary>
        /// Gets the absolute horizontal offset of the wheel,
        /// or 0 if no horizontal scroll wheel exists.
        /// </summary>
        /// <value>The x.</value>
        public float X { get; internal set; }

        /// <summary>
        /// Gets the absolute vertical offset of the wheel,
        /// or 0 if no vertical scroll wheel exists.
        /// </summary>
        /// <value>The y.</value>
        public float Y { get; internal set; }

        /// <param name="left">A <see cref="MouseScroll"/> instance to test for equality.</param>
        /// <param name="right">A <see cref="MouseScroll"/> instance to test for equality.</param>
        public static bool operator ==(MouseScroll left, MouseScroll right)
        {
            return left.Equals(right);
        }

        /// <param name="left">A <see cref="MouseScroll"/> instance to test for inequality.</param>
        /// <param name="right">A <see cref="MouseScroll"/> instance to test for inequality.</param>
        public static bool operator !=(MouseScroll left, MouseScroll right)
        {
            return !left.Equals(right);
        }

        /// <summary>
        /// Returns a <see cref="System.String"/> that represents the current <see cref="OpenTK.Input.MouseScroll"/>.
        /// </summary>
        /// <returns>A <see cref="System.String"/> that represents the current <see cref="OpenTK.Input.MouseScroll"/>.</returns>
        public override string ToString()
        {
            return string.Format("[X={0:0.00}, Y={1:0.00}]", X, Y);
        }

        /// <summary>
        /// Serves as a hash function for a <see cref="OpenTK.Input.MouseScroll"/> object.
        /// </summary>
        /// <returns>A hash code for this instance that is suitable for use in hashing algorithms and data structures such as a
        /// hash table.</returns>
        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode();
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object"/> is equal to the current <see cref="OpenTK.Input.MouseScroll"/>.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object"/> to compare with the current <see cref="OpenTK.Input.MouseScroll"/>.</param>
        /// <returns><c>true</c> if the specified <see cref="System.Object"/> is equal to the current
        /// <see cref="OpenTK.Input.MouseScroll"/>; otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            return
                obj is MouseScroll &&
                Equals((MouseScroll)obj);
        }

        #endregion

        #region IEquatable Members

        /// <summary>
        /// Determines whether the specified <see cref="OpenTK.Input.MouseScroll"/> is equal to the current <see cref="OpenTK.Input.MouseScroll"/>.
        /// </summary>
        /// <param name="other">The <see cref="OpenTK.Input.MouseScroll"/> to compare with the current <see cref="OpenTK.Input.MouseScroll"/>.</param>
        /// <returns><c>true</c> if the specified <see cref="OpenTK.Input.MouseScroll"/> is equal to the current
        /// <see cref="OpenTK.Input.MouseScroll"/>; otherwise, <c>false</c>.</returns>
        public bool Equals(MouseScroll other)
        {
            return X == other.X && Y == other.Y;
        }

        #endregion
    }
}

