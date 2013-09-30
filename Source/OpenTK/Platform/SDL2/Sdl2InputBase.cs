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
using System.Runtime.InteropServices;
using System.Threading;
using OpenTK.Input;

namespace OpenTK.Platform.SDL2
{
    class Sdl2InputBase : IInputDriver2
    {
        readonly Sdl2Keyboard keyboard_driver = new Sdl2Keyboard();
        readonly Sdl2Mouse mouse_driver = new Sdl2Mouse();
        readonly SDL.SDL_EventFilter EventFilterDelegate;

        public Sdl2InputBase()
        {
            EventFilterDelegate = FilterInputEvents;
            SDL.SDL_AddEventWatch(EventFilterDelegate, IntPtr.Zero);
        }

        #region Private Members

        int FilterInputEvents(IntPtr user_data, IntPtr e)
        {
            SDL.SDL_Event ev;
            unsafe
            {
                ev = *(SDL.SDL_Event*)e;
            }

            var type = (SDL.SDL_EventType)Marshal.ReadInt32(e);
            switch (type)
            {
                case SDL.SDL_EventType.SDL_KEYDOWN:
                case SDL.SDL_EventType.SDL_KEYUP:
                    keyboard_driver.ProcessKeyboardEvent(ev.key);
                    break;

                case SDL.SDL_EventType.SDL_MOUSEBUTTONDOWN:
                case SDL.SDL_EventType.SDL_MOUSEBUTTONUP:
                    mouse_driver.ProcessMouseEvent(ev.button);
                    break;

                case SDL.SDL_EventType.SDL_MOUSEMOTION:
                    mouse_driver.ProcessMouseEvent(ev.motion);
                    break;

                case SDL.SDL_EventType.SDL_MOUSEWHEEL:
                    mouse_driver.ProcessWheelEvent(ev.wheel);
                    break;
            }

            return 0;
        }

        #endregion

        #region IInputDriver2 Members

        public IMouseDriver2 MouseDriver
        {
            get
            {
                return mouse_driver;
            }
        }

        public IKeyboardDriver2 KeyboardDriver
        {
            get
            {
                return keyboard_driver;
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

