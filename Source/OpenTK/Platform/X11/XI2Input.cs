// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
using System;
using System.Diagnostics;
using OpenTK.Input;

namespace OpenTK.Platform.X11
{
    class XI2Input : IInputDriver2
    {
        readonly XI2MouseKeyboard mouse_keyboard = new XI2MouseKeyboard();
        readonly Linux.LinuxJoystick joystick = new Linux.LinuxJoystick();
        readonly IGamePadDriver gamepad = new MappedGamePadDriver();

        internal XI2Input()
        {
            Debug.WriteLine("Using XI2 input driver.");
        }

        #region IInputDriver2 Members

        public IMouseDriver2 MouseDriver
        {
            get
            {
                return mouse_keyboard;
            }
        }

        public IKeyboardDriver2 KeyboardDriver
        {
            get
            {
                return mouse_keyboard;
            }
        }

        public IGamePadDriver GamePadDriver
        {
            get
            {
                return gamepad;
            }
        }

        public IJoystickDriver2 JoystickDriver
        {
            get
            {
                return joystick;
            }
        }

        #endregion

        #region IDisposable Members

        public void Dispose()
        {
            mouse_keyboard.Dispose();
            joystick.Dispose();
        }

        #endregion

    }
}

