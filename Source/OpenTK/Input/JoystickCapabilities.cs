#region License
//
// JoystickCapabilities.cs
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
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Input
{
    public struct JoystickCapabilities : IEquatable<JoystickCapabilities>
    {
        byte axis_count;
        byte button_count;
        byte dpad_count;
        bool is_connected;

        #region Constructors

        public JoystickCapabilities(int axis_count, int button_count, bool is_connected)
        {
            if (axis_count < 0 || axis_count >= JoystickState.MaxAxes)
                throw new ArgumentOutOfRangeException("axis_count");
            if (button_count < 0 || button_count >= JoystickState.MaxButtons)
                throw new ArgumentOutOfRangeException("axis_count");

            this.axis_count = (byte)axis_count;
            this.button_count = (byte)button_count;
            this.dpad_count = 0; // Todo: either remove dpad_count or add it as a parameter
            this.is_connected = is_connected;
        }

        #endregion

        #region Public Members

        public int AxisCount
        {
            get { return axis_count; }
        }

        public int ButtonCount
        {
            get { return button_count; }
        }

        public bool IsConnected
        {
            get { return is_connected; }
        }

        public override string ToString()
        {
            return String.Format(
                "{{Axes: {0}; Buttons: {1}; IsConnected: {2}}}",
                AxisCount, ButtonCount, IsConnected);
        }

        public override int GetHashCode()
        {
            return
                AxisCount.GetHashCode() ^
                ButtonCount.GetHashCode() ^
                IsConnected.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return
                obj is JoystickCapabilities &&
                Equals((JoystickCapabilities)obj);
        }

        #endregion

        #region Private Members

        int DPadCount
        {
            get { return dpad_count; }
        }

        #endregion

        #region IEquatable<JoystickCapabilities> Members

        public bool Equals(JoystickCapabilities other)
        {
            return
                AxisCount == other.AxisCount &&
                ButtonCount == other.ButtonCount &&
                IsConnected == other.IsConnected;
        }

        #endregion
    }
}
