#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2013 Stefanos Apostolopoulos for the Open Toolkit library.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to 
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//
#endregion

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

