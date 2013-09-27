using System;
using OpenTK.Input;

namespace OpenTK.Platform.SDL2
{
    class Sdl2Keyboard : IKeyboardDriver2
    {
        public Sdl2Keyboard()
        {
        }

        #region IKeyboardDriver2 Members

        public KeyboardState GetState()
        {
            return new KeyboardState();
        }

        public KeyboardState GetState(int index)
        {
            return new KeyboardState();
        }

        public string GetDeviceName(int index)
        {
            return String.Empty;
        }

        #endregion
    }
}

