using System;
using System.Collections.Generic;
using System.Threading;
using OpenTK.Input;

namespace OpenTK.Platform.SDL2
{
    class Sdl2InputBase : IInputDriver2
    {
        Sdl2WindowInfo window;
        readonly Thread thread;
        readonly AutoResetEvent ready = new AutoResetEvent(false); 

        public Sdl2InputBase()
        {
            window = new Sdl2WindowInfo(
                SDL.SDL_CreateWindow("Hidden Input Window", 0, 0, 1, 1,
                    SDL.SDL_WindowFlags.SDL_WINDOW_HIDDEN),
                null);
        }

        #region Private Members

        void ProcessEvents()
        {
            SDL.SDL_Event e;
            while (SDL.SDL_WaitEvent(out e) != 0)
            {
            }
        }

        #endregion

        #region IInputDriver2 Members

        public IMouseDriver2 MouseDriver
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IKeyboardDriver2 KeyboardDriver
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IGamePadDriver GamePadDriver
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        #endregion
    }
}

