// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
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

