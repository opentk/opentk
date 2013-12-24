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
    public struct JoystickState
    {
        // If we ever add more values to JoystickAxis or JoystickButton
        // then we'll need to increase these limits.
        internal const int MaxAxes = 10;
        internal const int MaxButtons = 32;

        const float ConversionFactor = 1.0f / (short.MaxValue + 1);

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
            float value = 0.0f;
            if (axis >= 0 && axis < MaxAxes)
            {
                unsafe
                {
                    fixed (short* paxis = axes)
                    {
                        value = *(paxis + axis) * ConversionFactor;
                    }
                }
            }
            else
            {
                Debug.Print("[Joystick] Invalid axis {0}", axis);
            }
            return value;
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

        #endregion

        #region Internal Members

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
    }
}
