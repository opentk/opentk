// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.


using System;

namespace OpenTK.Input
{
    /// <summary>
    /// Describes the state of a <see cref="GamePad"/> trigger buttons.
    /// </summary>
    public struct GamePadTriggers : IEquatable<GamePadTriggers>
    {
        const float ConversionFactor = 1.0f / byte.MaxValue;
        byte left;
        byte right;

        internal GamePadTriggers(byte left, byte right)
        {
            this.left = left;
            this.right = right;
        }

        #region Public Members

        /// <summary>
        /// Gets the offset of the left trigger button, between 0.0 and 1.0.
        /// </summary>
        public float Left
        {
            get { return left * ConversionFactor; }
        }

        /// <summary>
        /// Gets the offset of the left trigger button, between 0.0 and 1.0.
        /// </summary>
        public float Right
        {
            get { return right * ConversionFactor; }
        }

        /// <param name="left">A <see cref="GamePadTriggers"/> instance to test for equality.</param>
        /// <param name="right">A <see cref="GamePadTriggers"/> instance to test for equality.</param>
        public static bool operator ==(GamePadTriggers left, GamePadTriggers right)
        {
            return left.Equals(right);
        }

        /// <param name="left">A <see cref="GamePadTriggers"/> instance to test for equality.</param>
        /// <param name="right">A <see cref="GamePadTriggers"/> instance to test for equality.</param>
        public static bool operator !=(GamePadTriggers left, GamePadTriggers right)
        {
            return !left.Equals(right);
        }

        /// <summary>
        /// Returns a <see cref="System.String"/> that represents the current <see cref="OpenTK.Input.GamePadTriggers"/>.
        /// </summary>
        /// <returns>A <see cref="System.String"/> that represents the current <see cref="OpenTK.Input.GamePadTriggers"/>.</returns>
        public override string ToString()
        {
            return String.Format(
                "({0:f2}; {1:f2})",
                Left, Right);
        }

        /// <summary>
        /// Serves as a hash function for a <see cref="OpenTK.Input.GamePadTriggers"/> object.
        /// </summary>
        /// <returns>A hash code for this instance that is suitable for use in hashing algorithms and data structures such as a
        /// hash table.</returns>
        public override int GetHashCode()
        {
            return
                left.GetHashCode() ^ right.GetHashCode();
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object"/> is equal to the current <see cref="OpenTK.Input.GamePadTriggers"/>.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object"/> to compare with the current <see cref="OpenTK.Input.GamePadTriggers"/>.</param>
        /// <returns><c>true</c> if the specified <see cref="System.Object"/> is equal to the current
        /// <see cref="OpenTK.Input.GamePadTriggers"/>; otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            return
                obj is GamePadTriggers &&
                Equals((GamePadTriggers)obj);
        }

        #endregion

        #region IEquatable<GamePadTriggers> Members

        /// <summary>
        /// Determines whether the specified <see cref="OpenTK.Input.GamePadTriggers"/> is equal to the current <see cref="OpenTK.Input.GamePadTriggers"/>.
        /// </summary>
        /// <param name="other">The <see cref="OpenTK.Input.GamePadTriggers"/> to compare with the current <see cref="OpenTK.Input.GamePadTriggers"/>.</param>
        /// <returns><c>true</c> if the specified <see cref="OpenTK.Input.GamePadTriggers"/> is equal to the current
        /// <see cref="OpenTK.Input.GamePadTriggers"/>; otherwise, <c>false</c>.</returns>
        public bool Equals(GamePadTriggers other)
        {
            return
                left == other.left &&
                right == other.right;
        }

        #endregion
    }
}
