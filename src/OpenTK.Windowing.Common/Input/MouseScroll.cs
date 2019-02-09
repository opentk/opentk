//
// MouseScroll.cs
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
    /// Represents the state of a mouse wheel.
    /// </summary>
    public struct MouseScroll : IEquatable<MouseScroll>
    {
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

        /// <param name="left">A <see cref="MouseScroll" /> instance to test for equality.</param>
        /// <param name="right">A <see cref="MouseScroll" /> instance to test for equality.</param>
        public static bool operator ==(MouseScroll left, MouseScroll right)
        {
            return left.Equals(right);
        }

        /// <param name="left">A <see cref="MouseScroll" /> instance to test for inequality.</param>
        /// <param name="right">A <see cref="MouseScroll" /> instance to test for inequality.</param>
        public static bool operator !=(MouseScroll left, MouseScroll right)
        {
            return !left.Equals(right);
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents the current <see cref="MouseScroll" />.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents the current <see cref="MouseScroll" />.</returns>
        public override string ToString()
        {
            return $"[X={X:0.00}, Y={Y:0.00}]";
        }

        /// <summary>
        /// Serves as a hash function for a <see cref="MouseScroll" /> object.
        /// </summary>
        /// <returns>
        /// A hash code for this instance that is suitable for use in hashing algorithms and data structures such as a
        /// hash table.
        /// </returns>
        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode();
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object" /> is equal to the current
        ///  <see cref="MouseScroll" />.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object" /> to compare with the current <see cref="MouseScroll" />.</param>
        /// <returns>
        ///  <c>true</c> if the specified <see cref="System.Object" /> is equal to the current
        ///  <see cref="MouseScroll" />; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object obj)
        {
            return
                obj is MouseScroll &&
                Equals((MouseScroll)obj);
        }

        /// <summary>
        /// Determines whether the specified <see cref="MouseScroll" /> is equal to the current
        ///  <see cref="MouseScroll" />.
        /// </summary>
        /// <param name="other">
        /// The <see cref="MouseScroll" /> to compare with the current
        ///  <see cref="MouseScroll" />.
        /// </param>
        /// <returns>
        ///  <c>true</c> if the specified <see cref="MouseScroll" /> is equal to the current
        ///  <see cref="MouseScroll" />; otherwise, <c>false</c>.
        /// </returns>
        public bool Equals(MouseScroll other)
        {
            return X == other.X && Y == other.Y;
        }
    }
}
