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
            public bool IsConnected { get; set; }
        }

        readonly List<JoystickDevice> joysticks = new List<JoystickDevice>();
        IList<JoystickDevice> joysticks_readonly;
        bool disposed = false;

        public Sdl2JoystickDriver()
        {
            joysticks_readonly = joysticks.AsReadOnly();
        }

        #region Private Members

        JoystickDevice<Sdl2JoystickDetails> OpenJoystick(int id)
        {
            JoystickDevice<Sdl2JoystickDetails> joystick = null;
            int num_axes = 0;
            int num_buttons = 0;
            int num_hats = 0;
            int num_balls = 0;

            IntPtr handle = SDL.JoystickOpen(id);
            if (handle != IntPtr.Zero)
            {
                num_axes = SDL.JoystickNumAxes(handle);
                num_buttons = SDL.JoystickNumButtons(handle);
                num_hats = SDL.JoystickNumHats(handle);
                num_balls = SDL.JoystickNumBalls(handle);

                joystick = new JoystickDevice<Sdl2JoystickDetails>(id, num_axes, num_buttons);
                joystick.Description = SDL.JoystickName(handle);
                joystick.Details.Handle = handle;
                joystick.Details.HatCount = num_hats;
                joystick.Details.BallCount = num_balls;

                Debug.Print("[SDL2] Joystick device {0} opened successfully. ", id);
                Debug.Print("\t\t'{0}' has {1} axes, {2} buttons, {3} hats, {4} balls",
                    joystick.Description, joystick.Axis.Count, joystick.Button.Count,
                    joystick.Details.HatCount, joystick.Details.BallCount);
            }
            else
            {
                Debug.Print("[SDL2] Failed to open joystick device {0}", id);
            }

            return joystick;
        }

        bool IsJoystickValid(int id)
        {
            return id >= 0 && id < joysticks.Count;
        }

        #endregion

        #region Public Members

        public void ProcessJoystickEvent(JoyDeviceEvent ev)
        {
            int id = ev.Which;
            if (id < 0)
            {
                Debug.Print("[SDL2] Invalid joystick id {0} in {1}", id, ev.Type);
                return;
            }

            switch (ev.Type)
            {
                case EventType.JOYDEVICEADDED:
                    {
                        // Make sure we have enough space to store this instance
                        if (joysticks.Count <= id)
                        {
                            joysticks.Capacity = OpenTK.MathHelper.NextPowerOfTwo(id);
                        }

                        IntPtr handle = SDL.JoystickOpen(id);
                        if (handle != IntPtr.Zero)
                        {
                            JoystickDevice<Sdl2JoystickDetails> joystick = OpenJoystick(id);
                            if (joysticks != null)
                            {
                                joystick.Details.IsConnected = true;
                                joysticks[id] = joystick;
                            }
                        }
                    }
                    break;

                case EventType.JOYDEVICEREMOVED:
                    {
                        JoystickDevice<Sdl2JoystickDetails> joystick = (JoystickDevice<Sdl2JoystickDetails>)joysticks[id];
                        joystick.Details.IsConnected = false;
                    }
                    break;
            }
        }

        public void ProcessJoystickEvent(JoyAxisEvent ev)
        {
            int id = ev.Which;
            if (IsJoystickValid(id))
            {
                JoystickDevice<Sdl2JoystickDetails> joystick = (JoystickDevice<Sdl2JoystickDetails>)joysticks[id];
                float value = ev.Value * joystick.Details.RangeMultiplier;
                joystick.SetAxis((JoystickAxis)ev.Axis, value);
            }
            else
            {
                Debug.Print("[SDL2] Invalid joystick id {0} in {1}", id, ev.Type);
            }
        }

        public void ProcessJoystickEvent(JoyBallEvent ev)
        {
            int id = ev.Which;
            if (IsJoystickValid(id))
            {
                JoystickDevice<Sdl2JoystickDetails> joystick = (JoystickDevice<Sdl2JoystickDetails>)joysticks[id];
                // Todo: does it make sense to support balls?
            }
            else
            {
                Debug.Print("[SDL2] Invalid joystick id {0} in {1}", id, ev.Type);
            }
        }

        public void ProcessJoystickEvent(JoyButtonEvent ev)
        {
            int id = ev.Which;
            if (IsJoystickValid(id))
            {
                JoystickDevice<Sdl2JoystickDetails> joystick = (JoystickDevice<Sdl2JoystickDetails>)joysticks[id];
                joystick.SetButton((JoystickButton)ev.Button, ev.State == State.Pressed);
            }
            else
            {
                Debug.Print("[SDL2] Invalid joystick id {0} in {1}", id, ev.Type);
            }
        }

        public void ProcessJoystickEvent(JoyHatEvent ev)
        {
            int id = ev.Which;
            if (IsJoystickValid(id))
            {
                JoystickDevice<Sdl2JoystickDetails> joystick = (JoystickDevice<Sdl2JoystickDetails>)joysticks[id];
                // Todo: map hat to an extra axis
            }
            else
            {
                Debug.Print("[SDL2] Invalid joystick id {0} in {1}", id, ev.Type);
            }
        }

        public void ProcessControllerEvent(ControllerDeviceEvent ev)
        {
            int id = ev.Which;

            switch (ev.Type)
            {
                case EventType.CONTROLLERDEVICEADDED:
                    break;

                case EventType.CONTROLLERDEVICEREMOVED:
                    break;

                case EventType.CONTROLLERDEVICEREMAPPED:
                    break;
            }
         }

        public void ProcessControllerEvent(ControllerAxisEvent ev)
        {
            int id = ev.Which;


        }

        public void ProcessControllerEvent(ControllerButtonEvent ev)
        {
            int id = ev.Which;


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
            // Do nothing
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
                        SDL.JoystickClose(handle);
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

