// #region License
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
// #endregion


using System;

namespace OpenTK.Input
{
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

        public Vector2 Left
        {
            get { return new Vector2(left_x * ConversionFactor, left_y * ConversionFactor); }
        }

        public Vector2 Right
        {
            get { return new Vector2(right_x * ConversionFactor, right_y * ConversionFactor); }
        }

        public static bool operator ==(GamePadThumbSticks left, GamePadThumbSticks right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(GamePadThumbSticks left, GamePadThumbSticks right)
        {
            return !left.Equals(right);
        }

        public override string ToString()
        {
            return String.Format(
                "{{Left: {0}; Right: {1}}}",
                Left, Right);
        }

        public override int GetHashCode()
        {
            return
                left_x.GetHashCode() ^ left_y.GetHashCode() ^
                right_x.GetHashCode() ^ right_y.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return
                obj is GamePadThumbSticks &&
                Equals((GamePadThumbSticks)obj);
        }

        #endregion

        #region IEquatable<GamePadThumbSticks> Members

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
