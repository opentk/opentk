#region License
//
// GamePadThumbSticks.cs
//
// Author:
//       Stefanos A. <stapostol@gmail.com>
//
// Copyright (c) 2006-2013 Stefanos Apostolopoulos
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//
#endregion

using System;

namespace OpenTK.Input
{
    /// <summary>
    /// Describes the current thumb stick state of a <see cref="GamePad"/> device
    /// </summary>
    public struct GamePadThumbSticks : IEquatable<GamePadThumbSticks>
    {
        const float ConversionFactor = 1.0f / short.MaxValue;
        short left_x, left_y;
        short right_x, right_y;

        internal GamePadThumbSticks(
            short left_x, short left_y,
            short right_x, short right_y)
        {
            this.left_x = left_x;
            this.left_y = left_y;
            this.right_x = right_x;
            this.right_y = right_y;
        }

        #region Public Members

        /// <summary>
        /// Gets a <see cref="Vector2"/> describing the state of the left thumb stick.
        /// </summary>
        public Vector2 Left
        {
            get { return new Vector2(left_x * ConversionFactor, left_y * ConversionFactor); }
        }

        /// <summary>
        /// Gets a <see cref="Vector2"/> describing the state of the right thumb stick.
        /// </summary>
        public Vector2 Right
        {
            get { return new Vector2(right_x * ConversionFactor, right_y * ConversionFactor); }
        }

        /// <param name="left">A <see cref="GamePadThumbSticks"/> instance to test for equality.</param>
        /// <param name="right">A <see cref="GamePadThumbSticks"/> instance to test for equality.</param>
        public static bool operator ==(GamePadThumbSticks left, GamePadThumbSticks right)
        {
            return left.Equals(right);
        }

        /// <param name="left">A <see cref="GamePadThumbSticks"/> instance to test for inequality.</param>
        /// <param name="right">A <see cref="GamePadThumbSticks"/> instance to test for inequality.</param>
        public static bool operator !=(GamePadThumbSticks left, GamePadThumbSticks right)
        {
            return !left.Equals(right);
        }

        /// <summary>
        /// Returns a <see cref="System.String"/> that represents the current <see cref="OpenTK.Input.GamePadThumbSticks"/>.
        /// </summary>
        /// <returns>A <see cref="System.String"/> that represents the current <see cref="OpenTK.Input.GamePadThumbSticks"/>.</returns>
        public override string ToString()
        {
            return String.Format(
                "{{Left: ({0:f4}; {1:f4}); Right: ({2:f4}; {3:f4})}}",
                Left.X, Left.Y, Right.X, Right.Y);
        }

        /// <summary>
        /// Serves as a hash function for a <see cref="OpenTK.Input.GamePadThumbSticks"/> object.
        /// </summary>
        /// <returns>A hash code for this instance that is suitable for use in hashing algorithms and data structures such as a
        /// hash table.</returns>
        public override int GetHashCode()
        {
            return
                left_x.GetHashCode() ^ left_y.GetHashCode() ^
                right_x.GetHashCode() ^ right_y.GetHashCode();
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object"/> is equal to the current <see cref="OpenTK.Input.GamePadThumbSticks"/>.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object"/> to compare with the current <see cref="OpenTK.Input.GamePadThumbSticks"/>.</param>
        /// <returns><c>true</c> if the specified <see cref="System.Object"/> is equal to the current
        /// <see cref="OpenTK.Input.GamePadThumbSticks"/>; otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            return
                obj is GamePadThumbSticks &&
                Equals((GamePadThumbSticks)obj);
        }

        #endregion

        #region IEquatable<GamePadThumbSticks> Members

        /// <summary>
        /// Determines whether the specified <see cref="OpenTK.Input.GamePadThumbSticks"/> is equal to the current <see cref="OpenTK.Input.GamePadThumbSticks"/>.
        /// </summary>
        /// <param name="other">The <see cref="OpenTK.Input.GamePadThumbSticks"/> to compare with the current <see cref="OpenTK.Input.GamePadThumbSticks"/>.</param>
        /// <returns><c>true</c> if the specified <see cref="OpenTK.Input.GamePadThumbSticks"/> is equal to the current
        /// <see cref="OpenTK.Input.GamePadThumbSticks"/>; otherwise, <c>false</c>.</returns>
        public bool Equals(GamePadThumbSticks other)
        {
            return
                left_x == other.left_x &&
                left_y == other.left_y &&
                right_x == other.right_x &&
                right_y == other.right_y;
        }

        #endregion
    }
}
