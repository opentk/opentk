#region License
//
// JoystickState.cs
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
using System.Diagnostics;
using System.Text;

namespace OpenTK.Input
{
    public struct JoystickState : IEquatable<JoystickState>
    {
        // If we ever add more values to JoystickAxis or JoystickButton
        // then we'll need to increase these limits.
        internal const int MaxAxes = 10;
        internal const int MaxButtons = 32;

        const float ConversionFactor = 1.0f / (short.MaxValue + 0.5f);

        unsafe fixed short axes[MaxAxes];
        int buttons;
        bool is_connected;

        #region Public Members

        public float GetAxis(JoystickAxis axis)
        {
            return GetAxis((int)axis);
        }

        public float GetAxis(int axis)
        {
            return GetAxisRaw(axis) * ConversionFactor;
        }

        public ButtonState GetButton(JoystickButton button)
        {
            return (buttons & (1 << (int)button)) != 0 ? ButtonState.Pressed : ButtonState.Released;
        }

        public bool IsButtonDown(JoystickButton button)
        {
            return (buttons & (1 << (int)button)) != 0;
        }

        public bool IsButtonUp(JoystickButton button)
        {
            return (buttons & (1 << (int)button)) == 0;
        }

        public bool IsConnected
        {
            get { return is_connected; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < MaxAxes; i++)
            {
                sb.Append(" ");
                sb.Append(String.Format("{0:f4}", GetAxis(i)));
            }
            return String.Format(
                "{{Axes:{0}; Buttons: {1}; IsConnected: {2}}}",
                sb.ToString(),
                Convert.ToString((int)buttons, 2).PadLeft(16, '0'),
                IsConnected);
        }

        public override int GetHashCode()
        {
            int hash = buttons.GetHashCode() ^ IsConnected.GetHashCode();
            for (int i = 0; i < MaxAxes; i++)
            {
                hash ^= GetAxisUnsafe(i).GetHashCode();
            }
            return hash;
        }

        public override bool Equals(object obj)
        {
            return
                obj is JoystickState &&
                Equals((JoystickState)obj);
        }

        #endregion

        #region Internal Members

        internal short GetAxisRaw(JoystickAxis axis)
        {
            return GetAxisRaw((int)axis);
        }

        internal short GetAxisRaw(int axis)
        {
            short value = 0;
            if (axis >= 0 && axis < MaxAxes)
            {
                value = GetAxisUnsafe(axis);
            }
            else
            {
                Debug.Print("[Joystick] Invalid axis {0}", axis);
            }
            return value;
        }

        internal void SetAxis(JoystickAxis axis, short value)
        {
            int index = (int)axis;
            if (index < 0 || index >= MaxAxes)
                throw new ArgumentOutOfRangeException("axis");

            unsafe
            {
                fixed (short* paxes = axes)
                {
                    *(paxes + index) = value;
                }
            }
        }

        internal void SetButton(JoystickButton button, bool value)
        {
            int index = 1 << (int)button;
            if (value)
            {
                buttons |= index;
            }
            else
            {
                buttons &= ~index;
            }
        }

        internal void SetIsConnected(bool value)
        {
            is_connected = value;
        }

        #endregion

        #region Private Members

        short GetAxisUnsafe(int index)
        {
            unsafe
            {
                fixed (short* paxis = axes)
                {
                    return *(paxis + index);
                }
            }
        }

        #endregion

        #region IEquatable<JoystickState> Members

        public bool Equals(JoystickState other)
        {
            bool equals =
                buttons == other.buttons &&
                IsConnected == other.IsConnected;
            for (int i = 0; equals && i < MaxAxes; i++)
            {
                equals &= GetAxisUnsafe(i) == other.GetAxisUnsafe(i);
            }
            return equals;
        }

        #endregion
    }
}
