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
    class Sdl2JoystickDriver : IJoystickDriver, IJoystickDriver2, IGamePadDriver, IDisposable
    {
        const float RangeMultiplier =  1.0f / 32768.0f;

        struct Sdl2JoystickDetails
        {
            public IntPtr Handle { get; set; }
            public int HatCount { get; set; }
            public int BallCount { get; set; }
            public bool IsConnected { get; set; }
        }

        class Sdl2GamePad
        {
            public IntPtr Handle { get; private set; }
            public GamePadState State { get; set; }
            public GamePadCapabilities Capabilities { get; set; }

            public Sdl2GamePad(IntPtr handle)
            {
                Handle = handle;
            }
        }

        readonly List<JoystickDevice> joysticks = new List<JoystickDevice>(4);
        readonly Dictionary<int, int> sdl_joyid_to_joysticks = new Dictionary<int, int>();
        readonly Dictionary<int, Sdl2GamePad> controllers = new Dictionary<int, Sdl2GamePad>();

        IList<JoystickDevice> joysticks_readonly;
        bool disposed;

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

        bool IsControllerValid(int id)
        {
            return controllers.ContainsKey(id);
        }

        GamePadAxes GetBoundAxes(IntPtr gamecontroller)
        {
            GamePadAxes axes = 0;
            axes |= IsAxisBind(gamecontroller, GameControllerAxis.LeftX) ? GamePadAxes.LeftX : 0;
            axes |= IsAxisBind(gamecontroller, GameControllerAxis.LeftY) ? GamePadAxes.LeftY : 0;
            axes |= IsAxisBind(gamecontroller, GameControllerAxis.RightX) ? GamePadAxes.RightX : 0;
            axes |= IsAxisBind(gamecontroller, GameControllerAxis.RightY) ? GamePadAxes.RightY : 0;
            axes |= IsAxisBind(gamecontroller, GameControllerAxis.TriggerLeft) ? GamePadAxes.LeftTrigger : 0;
            axes |= IsAxisBind(gamecontroller, GameControllerAxis.TriggerRight) ? GamePadAxes.RightTrigger : 0;
            return axes;
        }

        Buttons GetBoundButtons(IntPtr gamecontroller)
        {
            Buttons buttons = 0;
            buttons |= IsButtonBind(gamecontroller, GameControllerButton.A) ? Buttons.A : 0;
            buttons |= IsButtonBind(gamecontroller, GameControllerButton.B) ? Buttons.B : 0;
            buttons |= IsButtonBind(gamecontroller, GameControllerButton.X) ? Buttons.X : 0;
            buttons |= IsButtonBind(gamecontroller, GameControllerButton.Y) ? Buttons.Y : 0;
            buttons |= IsButtonBind(gamecontroller, GameControllerButton.START) ? Buttons.Start : 0;
            buttons |= IsButtonBind(gamecontroller, GameControllerButton.BACK) ? Buttons.Back : 0;
            buttons |= IsButtonBind(gamecontroller, GameControllerButton.LEFTSHOULDER) ? Buttons.LeftShoulder : 0;
            buttons |= IsButtonBind(gamecontroller, GameControllerButton.RIGHTSHOULDER) ? Buttons.RightShoulder : 0;
            buttons |= IsButtonBind(gamecontroller, GameControllerButton.LEFTSTICK) ? Buttons.LeftStick : 0;
            buttons |= IsButtonBind(gamecontroller, GameControllerButton.RIGHTSTICK) ? Buttons.RightStick : 0;
            buttons |= IsButtonBind(gamecontroller, GameControllerButton.GUIDE) ? Buttons.BigButton : 0;
            buttons |= IsButtonBind(gamecontroller, GameControllerButton.DPAD_DOWN) ? Buttons.DPadDown : 0;
            buttons |= IsButtonBind(gamecontroller, GameControllerButton.DPAD_UP) ? Buttons.DPadUp : 0;
            buttons |= IsButtonBind(gamecontroller, GameControllerButton.DPAD_LEFT) ? Buttons.DPadLeft : 0;
            buttons |= IsButtonBind(gamecontroller, GameControllerButton.DPAD_RIGHT) ? Buttons.DPadRight : 0;
            return buttons;
        }

        bool IsAxisBind(IntPtr gamecontroller, GameControllerAxis axis)
        {
            GameControllerButtonBind bind =
                SDL.GameControllerGetBindForAxis(gamecontroller, axis);
            return bind.BindType == GameControllerBindType.Axis;
        }

        bool IsButtonBind(IntPtr gamecontroller, GameControllerButton button)
        {
            GameControllerButtonBind bind =
                SDL.GameControllerGetBindForButton(gamecontroller, button);
            return bind.BindType == GameControllerBindType.Button;
        }

        GamePadAxes TranslateAxis(GameControllerAxis axis)
        {
            switch (axis)
            {
                case GameControllerAxis.LeftX:
                    return GamePadAxes.LeftX;
                
                case GameControllerAxis.LeftY:
                    return GamePadAxes.LeftY;

                case GameControllerAxis.RightX:
                    return GamePadAxes.RightX;

                case GameControllerAxis.RightY:
                    return GamePadAxes.RightY;

                case GameControllerAxis.TriggerLeft:
                    return GamePadAxes.LeftTrigger;

                case GameControllerAxis.TriggerRight:
                    return GamePadAxes.RightTrigger;

                default:
                    throw new ArgumentOutOfRangeException(
                        String.Format("[SDL] Unknown axis {0}", axis));
            }
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
                        IntPtr handle = SDL.JoystickOpen(id);
                        if (handle != IntPtr.Zero)
                        {
                            JoystickDevice<Sdl2JoystickDetails> joystick = OpenJoystick(id);
                            if (joystick != null)
                            {
                                joystick.Details.IsConnected = true;
                                if (!sdl_joyid_to_joysticks.ContainsKey(id))
                                {
                                    sdl_joyid_to_joysticks.Add(id, joysticks.Count);
                                    joysticks.Add(null);
                                }
                                int index = sdl_joyid_to_joysticks[id];
                                joysticks[index] = joystick;
                            }
                        }
                    }
                    break;

                case EventType.JOYDEVICEREMOVED:
                    {
                        int index = sdl_joyid_to_joysticks[id];
                        JoystickDevice<Sdl2JoystickDetails> joystick = (JoystickDevice<Sdl2JoystickDetails>)joysticks[index];
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
                int index = sdl_joyid_to_joysticks[id];
                JoystickDevice<Sdl2JoystickDetails> joystick = (JoystickDevice<Sdl2JoystickDetails>)joysticks[index];
                float value = ev.Value * RangeMultiplier;
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
                int index = sdl_joyid_to_joysticks[id];
                JoystickDevice<Sdl2JoystickDetails> joystick = (JoystickDevice<Sdl2JoystickDetails>)joysticks[index];
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
                int index = sdl_joyid_to_joysticks[id];
                JoystickDevice<Sdl2JoystickDetails> joystick = (JoystickDevice<Sdl2JoystickDetails>)joysticks[index];
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
                int index = sdl_joyid_to_joysticks[id];
                JoystickDevice<Sdl2JoystickDetails> joystick = (JoystickDevice<Sdl2JoystickDetails>)joysticks[index];
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
                    IntPtr handle = SDL.GameControllerOpen(id);
                    if (handle != IntPtr.Zero)
                    {
                        Sdl2GamePad pad = new Sdl2GamePad(handle);

                        IntPtr joystick = SDL.GameControllerGetJoystick(handle);
                        if (joystick != IntPtr.Zero)
                        {
                            SDL.JoystickNumAxes(joystick);
                            pad.Capabilities = new GamePadCapabilities(
                                GamePadType.GamePad,
                                GetBoundAxes(joystick),
                                GetBoundButtons(joystick),
                                true);
                            pad.State.SetConnected(true);

                            // Check whether the device has ever been connected before
                            if (!controllers.ContainsKey(id))
                                controllers.Add(id, null);
                            controllers[id] = pad;
                        }
                        else
                        {
                            Debug.Print("[SDL2] Failed to retrieve joystick from game controller. Error: {0}", SDL.GetError());
                        }
                    }
                    break;

                case EventType.CONTROLLERDEVICEREMOVED:
                    if (IsControllerValid(id))
                    {
                        controllers[id].State.SetConnected(false);
                    }
                    break;

                case EventType.CONTROLLERDEVICEREMAPPED:
                    // Todo: what should we do in this case?
                    break;
            }
         }

        public void ProcessControllerEvent(ControllerAxisEvent ev)
        {
            int id = ev.Which;
            if (IsControllerValid(id))
            {
                    controllers[id].State.SetAxis(TranslateAxis(ev.Axis), ev.Value);
            }
            else
            {
                Debug.Print("[SDL2] Invalid game controller handle {0} in {1}", id, ev.Type);
            }
        }

        public void ProcessControllerEvent(ControllerButtonEvent ev)
        {
            int id = ev.Which;
            if (IsControllerValid(id))
            {
                controllers[id].State.SetButton((Buttons)ev.Button, ev.State == State.Pressed);
            }
            else
            {
                Debug.Print("[SDL2] Invalid game controller handle {0} in {1}", id, ev.Type);
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
            // Do nothing
        }

        #endregion

        #region IGamePadDriver Members

        public GamePadCapabilities GetCapabilities(int index)
        {
            if (IsControllerValid(index))
            {
                return controllers[index].Capabilities;
            }
            return new GamePadCapabilities();
        }

        public GamePadState GetState(int index)
        {
            if (IsControllerValid(index))
            {
                return controllers[index].State;
            }
            return new GamePadState();
        }

        public string GetName(int index)
        {
            return String.Empty;
        }

        #endregion

        #region IJoystickDriver2 Members

        JoystickState IJoystickDriver2.GetState(int index)
        {
            JoystickState state = new JoystickState();
            if (IsJoystickValid(index))
            {
                JoystickDevice<Sdl2JoystickDetails> joystick =
                    (JoystickDevice<Sdl2JoystickDetails>)joysticks[sdl_joyid_to_joysticks[index]];

                for (int i = 0; i < joystick.Axis.Count; i++)
                {
                    state.SetAxis(JoystickAxis.Axis0 + i, (short)(joystick.Axis[i] * short.MaxValue + 0.5f));
                }

                for (int i = 0; i < joystick.Button.Count; i++)
                {
                    state.SetButton(JoystickButton.Button0 + i, joystick.Button[i]);
                }

                state.SetIsConnected(true);
            }

            return state;
        }

        JoystickCapabilities IJoystickDriver2.GetCapabilities(int index)
        {
            if (IsJoystickValid(index))
            {
                JoystickDevice<Sdl2JoystickDetails> joystick =
                    (JoystickDevice<Sdl2JoystickDetails>)joysticks[sdl_joyid_to_joysticks[index]];

                return new JoystickCapabilities(
                    joystick.Axis.Count,
                    joystick.Button.Count,
                    true);
            }
            return new JoystickCapabilities();
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

