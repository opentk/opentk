// #region License
//
// GamePadCapabilities.cs
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

    public struct GamePadCapabilities : IEquatable<GamePadCapabilities>
    {
        byte axis_count;
        byte button_count;
        byte dpad_count;
        byte trackball_count;

        public int AxisCount
        {
            get { return axis_count; }
            internal set { axis_count = (byte)value; }
        }

        public int ButtonCount
        {
            get { return button_count; }
            internal set { button_count = (byte)value; }
        }

        public int DPadCount
        {
            get { return dpad_count; }
            internal set { dpad_count = (byte)value; }
        }

        public int TrackballCount
        {
            get { return trackball_count; }
            internal set { trackball_count = (byte)value; }
        }

        public static bool operator ==(GamePadCapabilities left, GamePadCapabilities right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(GamePadCapabilities left, GamePadCapabilities right)
        {
            return !left.Equals(right);
        }

        public override string ToString()
        {
            return String.Format(
                "{{Axes: {0}; Buttons: {1}; DPads: {2}; Trackballs: {3}}}",
                AxisCount, ButtonCount, DPadCount, TrackballCount);
        }

        public override int GetHashCode()
        {
            return
                AxisCount.GetHashCode() ^ ButtonCount.GetHashCode() ^
                DPadCount.GetHashCode() ^ TrackballCount.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return
                obj is GamePadCapabilities &&
                Equals((GamePadCapabilities)obj);
        }

        #region IEquatable<GamePadCapabilities> Members

        public bool Equals(GamePadCapabilities other)
        {
            return
                AxisCount == other.AxisCount &&
                ButtonCount == other.ButtonCount &&
                DPadCount == other.DPadCount &&
                TrackballCount == other.TrackballCount;
        }

        #endregion
    }
}

