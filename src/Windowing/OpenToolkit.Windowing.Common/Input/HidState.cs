//
// HidState.cs
//
// Copyright (C) 2018 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using System.Collections.Generic;
using System.Text;

namespace OpenToolkit.Windowing.Common.Input
{
    /// <summary>
    /// Encapsulates the state of a HID device.
    /// </summary>
    public struct HidState : IEquatable<HidState>
    {
        private unsafe fixed float _axes[6];

        /// <summary>
        /// Gets a <see cref="float"/> between -1 and 1 describing the position of the axis.
        /// </summary>
        /// <param name="axis">The axis to check.</param>
        /// <returns>A float between -1 and 1 describing the position of the axis.</returns>
        public float this[int axis]
        {
            get => GetAxis(axis);
            internal set => SetAxis(axis, value);
        }

        /// <summary>
        /// Gets a <see cref="float"/> between -1 and 1 describing the position of the axis.
        /// </summary>
        /// <param name="axis">The axis to check.</param>
        /// <returns>A float between -1 and 1 describing the position of the axis.</returns>
        public float GetAxis(int axis)
        {
            unsafe
            {
                return _axes[axis];
            }
        }

        /// <summary>
        /// Sets the state of the <paramref name="axis"/> depending on the given <paramref name="value"/> value.
        /// </summary>
        /// <param name="axis">The <see cref="float"/> axis which position should be changed.</param>
        /// <param name="value">The new state the key should be changed to.</param>
        internal void SetAxis(int axis, float value)
        {
            unsafe
            {
                _axes[axis] = value < -1 ? -1 : (value > 1 ? 1 : value);
            }
        }

        /// <summary>
        /// Checks wether two <see cref="HidState"/> instances are equal.
        /// </summary>
        /// <param name="left">The first <see cref="HidState"/> instance to compare.</param>
        /// <param name="right">The second <see cref="HidState"/> instance to compare.</param>
        /// <returns><c>true</c> if both left is equal to right; <c>false</c>otherwise.</returns>
        public static bool operator ==(HidState left, HidState right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// Checks wether two <see cref="HidState"/> instances are not equal.
        /// </summary>
        /// <param name="left">The first <see cref="HidState"/> instance to compare.</param>
        /// <param name="right">The second <see cref="HidState"/> instance to compare.</param>
        /// <returns><c>true</c> if both left is not equal to right; <c>false</c> otherwise.</returns>
        public static bool operator !=(HidState left, HidState right)
        {
            return !left.Equals(right);
        }

        /// <summary>
        /// Compares to an object instance for equality.
        /// </summary>
        /// <param name="obj">The <see cref="object"/> to compare to.</param>
        /// <returns><c>true</c> if this instance is equal to obj; <c>false</c> otherwise.</returns>
        public override bool Equals(object obj)
        {
            if (obj is HidState state)
            {
                return Equals(state);
            }
            return false;
        }

        /// <summary>
        /// Compares to <see cref="HidState"/> instances.
        /// </summary>
        /// <param name="other">The instance to compare to.</param>
        /// <returns><c>true</c> if both instances are equal; <c>false</c> otherwise.</returns>
        public bool Equals(HidState other)
        {
            for (int i = 0; i < 6; i++)
            {
                unsafe
                {
                    if (other._axes[i] != _axes[i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// Generates a hashcode for the current instance.
        /// </summary>
        /// <returns>A <see cref="int"/> representing the hashcode for this instance.</returns>
        public override int GetHashCode()
        {
            var hashcode = 0;
            for (int i = 0; i < 6; i++)
            {
                unsafe
                {
                    hashcode = (hashcode * 397) ^ _axes[i].GetHashCode();
                }
            }

            return hashcode;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            unsafe
            {
                return string.Format("{{0}, {1}, {2}, {3}, {4}, {5}", _axes[0], _axes[1], _axes[2], _axes[3], _axes[4], _axes[5]);
            }
        }
    }
}
