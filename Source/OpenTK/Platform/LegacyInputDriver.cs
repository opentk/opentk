#region License
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
    [Obsolete]
    class LegacyInputDriver : IInputDriver
    {
        List<KeyboardDevice> dummy_keyboard_list = new List<KeyboardDevice>(1);
        List<MouseDevice> dummy_mice_list = new List<MouseDevice>(1);

        readonly LegacyJoystickDriver JoystickDriver = new LegacyJoystickDriver();

        internal LegacyInputDriver(INativeWindow window)
        {
            if (window == null)
                throw new ArgumentNullException();

            var mouse = new MouseDevice();
            mouse.Description = "Standard Mouse";
            mouse.NumberOfButtons = 3;
            mouse.NumberOfWheels = 1;
            dummy_mice_list.Add(mouse);

            var keyboard = new KeyboardDevice();
            keyboard.Description = "Standard Keyboard";
            keyboard.NumberOfKeys = 101;
            keyboard.NumberOfLeds = 3;
            keyboard.NumberOfFunctionKeys = 12;
            dummy_keyboard_list.Add(keyboard);

            // Hook mouse events
            window.MouseDown += mouse.HandleMouseDown;
            window.MouseUp += mouse.HandleMouseUp;
            window.MouseMove += mouse.HandleMouseMove;
            window.MouseWheel += mouse.HandleMouseWheel;

            // Hook keyboard events
            window.KeyDown += keyboard.HandleKeyDown;
            window.KeyUp += keyboard.HandleKeyUp;
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

