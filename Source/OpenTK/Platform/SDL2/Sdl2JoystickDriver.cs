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
using System.Diagnostics;
using OpenTK.Input;

namespace OpenTK.Platform.SDL2
{
    class Sdl2JoystickDriver : IJoystickDriver, IGamePadDriver, IDisposable
    {
        struct Sdl2JoystickDetails
        {
            public IntPtr Handle { get; set; }
            public float RangeMultiplier { get { return 1.0f / 32768.0f; } }
            public int HatCount { get; set; }
            public int BallCount { get; set; }
        }

        readonly List<JoystickDevice> joysticks = new List<JoystickDevice>();
        IList<JoystickDevice> joysticks_readonly;
        bool disposed = false;

        public Sdl2JoystickDriver()
        {
            joysticks_readonly = joysticks.AsReadOnly();

            RefreshJoysticks();

        }

        #region Private Members

        void RefreshJoysticks()
        {
            joysticks.Clear();

            int count = SDL.SDL_NumJoysticks();
            for (int i = 0; i < count; i++)
            {
                JoystickDevice<Sdl2JoystickDetails> joystick = null;
                int num_axes = 0;
                int num_buttons = 0;
                int num_hats = 0;
                int num_balls = 0;

                IntPtr handle = SDL.SDL_JoystickOpen(i);
                if (handle != IntPtr.Zero)
                {
                    num_axes = SDL.SDL_JoystickNumAxes(handle);
                    num_buttons = SDL.SDL_JoystickNumButtons(handle);
                    num_hats = SDL.SDL_JoystickNumHats(handle);
                    num_balls = SDL.SDL_JoystickNumBalls(handle);

                    joystick = new JoystickDevice<Sdl2JoystickDetails>(i, num_axes, num_buttons);
                    joystick.Description = SDL.SDL_JoystickName(handle);
                    joystick.Details.Handle = handle;
                    joystick.Details.HatCount = num_hats;
                    joystick.Details.BallCount = num_balls;
                    joysticks.Add(joystick);
                }
            }
        }

        #endregion

        #region IJoystickDriver Members

        public IList<JoystickDevice> Joysticks
        {
            get
            {
                return joysticks_readonly;
            }
        }

        public void Poll()
        {
            SDL.SDL_JoystickUpdate();
            foreach (var j in joysticks)
            {
                var joystick = (JoystickDevice<Sdl2JoystickDetails>)j;
                IntPtr handle = joystick.Details.Handle;
                
                for (int i = 0; i < joystick.Axis.Count; i++)
                {
                    var axis = JoystickAxis.Axis0 + i;
                    joystick.SetAxis(axis, SDL.SDL_JoystickGetAxis(handle, i) * joystick.Details.RangeMultiplier);
                }

                for (int i = 0; i < joystick.Button.Count; i++)
                {
                    var button = JoystickButton.Button0 + i;
                    joystick.SetButton(button, SDL.SDL_JoystickGetButton(handle, i) != 0);
                }
            }
        }

        #endregion

        #region IGamePadDriver Members

        public GamePadState GetState()
        {
            return new GamePadState();
        }

        public GamePadState GetState(int index)
        {
            if (joysticks.Count >= index)
            {

            }

            return new GamePadState();
        }

        public string GetDeviceName(int index)
        {
            return String.Empty;
        }

        #endregion

        #region IDisposable Members

        void Dispose(bool manual)
        {
            if (!disposed)
            {
                if (manual)
                {
                    Debug.Print("Disposing {0}", GetType());

                    foreach (var j in joysticks)
                    {
                        var joystick = (JoystickDevice<Sdl2JoystickDetails>)j;
                        IntPtr handle = joystick.Details.Handle;
                        SDL.SDL_JoystickClose(handle);
                    }

                    joysticks.Clear();
                }
                else
                {
                    Debug.Print("{0} leaked, did you forget to call Dispose()?", GetType());
                }
                disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~Sdl2JoystickDriver()
        {
            Dispose(false);
        }

        #endregion
    }
}

