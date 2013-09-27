using System;
using OpenTK.Input;

namespace OpenTK.Platform.SDL2
{
    class Sdl2Mouse : IMouseDriver2
    {
        public Sdl2Mouse()
        {
        }

        #region IMouseDriver2 Members

        public MouseState GetState()
        {
            int x, y;
            uint b = SDL.SDL_GetMouseState(out x, out y);
            return new MouseState();
        }

        public MouseState GetState(int index)
        {
            return new MouseState();
        }

        public void SetPosition(double x, double y)
        {
            //SDL2.mouse
        }

        #endregion
    }
}

