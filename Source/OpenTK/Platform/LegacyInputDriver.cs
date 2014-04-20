﻿#region License
//
// LegacyInputDriver.cs
//
// Author:
//       Stefanos A. <stapostol@gmail.com>
//
// Copyright (c) 2006-2014 Stefanos Apostolopoulos
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
using OpenTK.Input;

namespace OpenTK.Platform
{
    // IInputDriver implementation to satisfy INativeWindow
    // while reducing code duplication.
    class LegacyInputDriver : IInputDriver
    {
        List<KeyboardDevice> dummy_keyboard_list = new List<KeyboardDevice>(1);
        List<MouseDevice> dummy_mice_list = new List<MouseDevice>(1);

        readonly LegacyJoystickDriver JoystickDriver = new LegacyJoystickDriver();

        internal LegacyInputDriver()
        {
            dummy_mice_list.Add(new MouseDevice());
            Mouse[0].Description = "Standard Mouse";
            Mouse[0].NumberOfButtons = 3;
            Mouse[0].NumberOfWheels = 1;

            dummy_keyboard_list.Add(new KeyboardDevice());
            Keyboard[0].Description = "Standard Keyboard";
            Keyboard[0].NumberOfKeys = 101;
            Keyboard[0].NumberOfLeds = 3;
            Keyboard[0].NumberOfFunctionKeys = 12;
        }

        #region IInputDriver Members

        public void Poll()
        {
        }

        #endregion

        #region IKeyboardDriver Members

        public IList<KeyboardDevice> Keyboard
        {
            get { return dummy_keyboard_list; }
        }

        #endregion

        #region IMouseDriver Members

        public IList<MouseDevice> Mouse
        {
            get { return dummy_mice_list; }
        }

        #endregion

        #region IJoystickDriver Members

        public IList<JoystickDevice> Joysticks
        {
            get { return JoystickDriver.Joysticks; }
        }

        #endregion

        #region IDisposable Members

        public void Dispose()
        {
        }

        #endregion
    }
}

