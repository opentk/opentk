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
    class Sdl2JoystickDriver : IJoystickDriver2, IGamePadDriver, IDisposable
    {
        const float RangeMultiplier =  1.0f / 32768.0f;
        readonly MappedGamePadDriver gamepad_driver = new MappedGamePadDriver();
        bool disposed;

        class Sdl2JoystickDetails
        {
            public IntPtr Handle { get; set; }
            public Guid Guid { get; set; }
            public int PacketNumber { get; set; }
            public int HatCount { get; set; }
            public int BallCount { get; set; }
            public bool IsConnected { get; set; }
            public readonly JoystickHatState[] Hat =
                new JoystickHatState[JoystickState.MaxHats];
        }

        // For IJoystickDriver2 implementation
        int last_joystick_instance = 0;
        readonly List<JoystickDevice> joysticks = new List<JoystickDevice>(4);
        readonly Dictionary<int, int> sdl_instanceid_to_joysticks = new Dictionary<int, int>();

#if USE_SDL2_GAMECONTROLLER
        class Sdl2GamePad
        {
            public IntPtr Handle { get; private set; }
            public GamePadState State;
            public GamePadCapabilities Capabilities;

            public Sdl2GamePad(IntPtr handle)
            {
                Handle = handle;
            }
        }

        int last_controllers_instance = 0;
        readonly List<Sdl2GamePad> controllers = new List<Sdl2GamePad>(4);
        readonly Dictionary<int, int> sdl_instanceid_to_controllers = new Dictionary<int, int>();
#endif

        public Sdl2JoystickDriver()
        {
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
                joystick.Details.Guid = SDL.JoystickGetGUID(handle).ToGuid();
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

        bool IsJoystickInstanceValid(int instance_id)
        {
            return sdl_instanceid_to_joysticks.ContainsKey(instance_id);
        }

        OpenTK.Input.HatPosition TranslateHat(HatPosition value)
        {
            if ((value & HatPosition.LeftUp) == value)
                return OpenTK.Input.HatPosition.UpLeft;

            if ((value & HatPosition.RightUp) == value)
                return OpenTK.Input.HatPosition.UpRight;

            if ((value & HatPosition.LeftDown) == value)
                return OpenTK.Input.HatPosition.DownLeft;

            if ((value & HatPosition.RightDown) == value)
                return OpenTK.Input.HatPosition.DownRight;

            if ((value & HatPosition.Up) == value)
                return OpenTK.Input.HatPosition.Up;

            if ((value & HatPosition.Right) == value)
                return OpenTK.Input.HatPosition.Right;

            if ((value & HatPosition.Down) == value)
                return OpenTK.Input.HatPosition.Down;

            if ((value & HatPosition.Left) == value)
                return OpenTK.Input.HatPosition.Left;

            return OpenTK.Input.HatPosition.Centered;
        }

#if USE_SDL2_GAMECONTROLLER
        bool IsControllerValid(int id)
        {
            return id >= 0 && id < controllers.Count;
        }

        bool IsControllerInstanceValid(int instance_id)
        {
            return sdl_instanceid_to_controllers.ContainsKey(instance_id);
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

        Buttons TranslateButton(GameControllerButton button)
        {
            switch (button)
            {
                case GameControllerButton.A:
                    return Buttons.A;

                case GameControllerButton.B:
                    return Buttons.B;

                case  GameControllerButton.X:
                    return Buttons.X;

                case GameControllerButton.Y:
                    return Buttons.Y;

                case GameControllerButton.LEFTSHOULDER:
                    return Buttons.LeftShoulder;

                case GameControllerButton.RIGHTSHOULDER:
                    return Buttons.RightShoulder;

                case GameControllerButton.LEFTSTICK:
                    return Buttons.LeftStick;

                case GameControllerButton.RIGHTSTICK:
                    return Buttons.RightStick;

                case GameControllerButton.DPAD_UP:
                    return Buttons.DPadUp;

                case GameControllerButton.DPAD_DOWN:
                    return Buttons.DPadDown;

                case GameControllerButton.DPAD_LEFT:
                    return Buttons.DPadLeft;

                case GameControllerButton.DPAD_RIGHT:
                    return Buttons.DPadRight;

                case GameControllerButton.BACK:
                    return Buttons.Back;

                case GameControllerButton.START:
                    return Buttons.Start;

                case GameControllerButton.GUIDE:
                    return Buttons.BigButton;

                default:
                    Debug.Print("[SDL2] Unknown button {0}", button);
                    return 0;
            }
        }
#endif

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
                            int device_id = id;
                            int instance_id = last_joystick_instance++;

                            JoystickDevice<Sdl2JoystickDetails> joystick = OpenJoystick(id);
                            if (joystick != null)
                            {
                                joystick.Details.IsConnected = true;
                                if (device_id < joysticks.Count)
                                {
                                    joysticks[device_id] = joystick;
                                }
                                else
                                {
                                    joysticks.Add(joystick);
                                }

                                sdl_instanceid_to_joysticks.Add(instance_id, device_id);
                            }
                        }
                    }
                    break;

                case EventType.JOYDEVICEREMOVED:
                    if (IsJoystickInstanceValid(id))
                    {
                        int instance_id = id;
                        int device_id = sdl_instanceid_to_joysticks[instance_id];

                        JoystickDevice<Sdl2JoystickDetails> joystick = (JoystickDevice<Sdl2JoystickDetails>)joysticks[device_id];
                        joystick.Details.IsConnected = false;

                        sdl_instanceid_to_joysticks.Remove(instance_id);
                    }
                    else
                    {
                        Debug.Print("[SDL2] Invalid joystick id {0} in {1}", id, ev.Type);
                    }
                    break;
            }
        }

        public void ProcessJoystickEvent(JoyAxisEvent ev)
        {
            int id = ev.Which;
            if (IsJoystickInstanceValid(id))
            {
                int index = sdl_instanceid_to_joysticks[id];
                JoystickDevice<Sdl2JoystickDetails> joystick = (JoystickDevice<Sdl2JoystickDetails>)joysticks[index];
                float value = ev.Value * RangeMultiplier;
                joystick.SetAxis((JoystickAxis)ev.Axis, value);
                joystick.Details.PacketNumber = Math.Max(0, unchecked(joystick.Details.PacketNumber + 1));
            }
            else
            {
                Debug.Print("[SDL2] Invalid joystick id {0} in {1}", id, ev.Type);
            }
        }

        public void ProcessJoystickEvent(JoyBallEvent ev)
        {
            int id = ev.Which;
            if (IsJoystickInstanceValid(id))
            {
                int index = sdl_instanceid_to_joysticks[id];
                JoystickDevice<Sdl2JoystickDetails> joystick = (JoystickDevice<Sdl2JoystickDetails>)joysticks[index];
                // Todo: does it make sense to support balls?
                joystick.Details.PacketNumber = Math.Max(0, unchecked(joystick.Details.PacketNumber + 1));
            }
            else
            {
                Debug.Print("[SDL2] Invalid joystick id {0} in {1}", id, ev.Type);
            }
        }

        public void ProcessJoystickEvent(JoyButtonEvent ev)
        {
            int id = ev.Which;
            if (IsJoystickInstanceValid(id))
            {
                int index = sdl_instanceid_to_joysticks[id];
                JoystickDevice<Sdl2JoystickDetails> joystick = (JoystickDevice<Sdl2JoystickDetails>)joysticks[index];
                joystick.SetButton((JoystickButton)ev.Button, ev.State == State.Pressed);
                joystick.Details.PacketNumber = Math.Max(0, unchecked(joystick.Details.PacketNumber + 1));
            }
            else
            {
                Debug.Print("[SDL2] Invalid joystick id {0} in {1}", id, ev.Type);
            }
        }

        public void ProcessJoystickEvent(JoyHatEvent ev)
        {
            int id = ev.Which;
            if (IsJoystickInstanceValid(id))
            {
                int index = sdl_instanceid_to_joysticks[id];
                JoystickDevice<Sdl2JoystickDetails> joystick = (JoystickDevice<Sdl2JoystickDetails>)joysticks[index];
                if (ev.Hat >= 0 && ev.Hat < JoystickState.MaxHats)
                {
                    joystick.Details.Hat[ev.Hat] = new JoystickHatState(TranslateHat(ev.Value));
                }
                else
                {
                    Debug.Print("[SDL2] Hat {0} out of range [0, {1}]", ev.Hat, JoystickState.MaxHats);
                }
                joystick.Details.PacketNumber = Math.Max(0, unchecked(joystick.Details.PacketNumber + 1));
            }
            else
            {
                Debug.Print("[SDL2] Invalid joystick id {0} in {1}", id, ev.Type);
            }
        }

#if USE_SDL2_GAMECONTROLLER
        public void ProcessControllerEvent(ControllerDeviceEvent ev)
        {
            int id = ev.Which;
            if (id < 0)
            {
                Debug.Print("[SDL2] Invalid controller id {0} in {1}", id, ev.Type);
                return;
            }

            switch (ev.Type)
            {
                case EventType.CONTROLLERDEVICEADDED:
                    IntPtr handle = SDL.GameControllerOpen(id);
                    if (handle != IntPtr.Zero)
                    {
                        // The id variable here corresponds to a device_id between 0 and Sdl.NumJoysticks().
                        // It is only used in the ADDED event. All other events use an instance_id which increases
                        // monotonically in each ADDED event.
                        // The idea is that device_id refers to the n-th connected joystick, whereas instance_id
                        // refers to the actual hardware device behind the n-th joystick.
                        // Yes, it's confusing.
                        int device_id = id;
                        int instance_id = last_controllers_instance++;

                        Sdl2GamePad pad = new Sdl2GamePad(handle);

                        IntPtr joystick = SDL.GameControllerGetJoystick(handle);
                        if (joystick != IntPtr.Zero)
                        {
                            pad.Capabilities = new GamePadCapabilities(
                                GamePadType.GamePad,
                                GetBoundAxes(joystick),
                                GetBoundButtons(joystick),
                                true);
                            pad.State.SetConnected(true);

                            // Connect this device and add the relevant device index
                            if (controllers.Count <= id)
                            {
                                controllers.Add(pad);
                            }
                            else
                            {
                                controllers[device_id] = pad;
                            }

                            sdl_instanceid_to_controllers.Add(instance_id, device_id);
                        }
                        else
                        {
                            Debug.Print("[SDL2] Failed to retrieve joystick from game controller. Error: {0}", SDL.GetError());
                        }
                    }
                    break;

                case EventType.CONTROLLERDEVICEREMOVED:
                    if (IsControllerInstanceValid(id))
                    {
                        int instance_id = id;
                        int device_id = sdl_instanceid_to_controllers[instance_id];

                        controllers[device_id].State.SetConnected(false);
                        sdl_instanceid_to_controllers.Remove(device_id);
                    }
                    else
                    {
                        Debug.Print("[SDL2] Invalid game controller instance {0} in {1}", id, ev.Type);
                    }
                    break;

                case EventType.CONTROLLERDEVICEREMAPPED:
                    if (IsControllerInstanceValid(id))
                    {
                        // Todo: what should we do in this case?
                    }
                    else
                    {
                        Debug.Print("[SDL2] Invalid game controller instance {0} in {1}", id, ev.Type);
                    }
                    break;
            }
         }

        public void ProcessControllerEvent(ControllerAxisEvent ev)
        {
            int instance_id = ev.Which;
            if (IsControllerInstanceValid(instance_id))
            {
                int id = sdl_instanceid_to_controllers[instance_id];
                controllers[id].State.SetAxis(TranslateAxis(ev.Axis), ev.Value);
            }
            else
            {
                Debug.Print("[SDL2] Invalid game controller instance {0} in {1}", instance_id, ev.Type);
            }
        }

        public void ProcessControllerEvent(ControllerButtonEvent ev)
        {
            int instance_id = ev.Which;
            if (IsControllerInstanceValid(instance_id))
            {
                int id = sdl_instanceid_to_controllers[instance_id];
                controllers[id].State.SetButton(TranslateButton(ev.Button), ev.State == State.Pressed);
            }
            else
            {
                Debug.Print("[SDL2] Invalid game controller instance {0} in {1}", instance_id, ev.Type);
            }
        }
#endif

        #endregion

        #region IGamePadDriver Members

#if USE_SDL2_GAMECONTOLLER
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
#else
        public GamePadCapabilities GetCapabilities(int index)
        {
            return gamepad_driver.GetCapabilities(index);
        }

        public GamePadState GetState(int index)
        {
            return gamepad_driver.GetState(index);
        }

        public string GetName(int index)
        {
            return gamepad_driver.GetName(index);
        }

        public bool SetVibration(int index, float left, float right)
        {
            return false;
        }
#endif

        #endregion

        #region IJoystickDriver2 Members

        JoystickState IJoystickDriver2.GetState(int index)
        {
            JoystickState state = new JoystickState();
            if (IsJoystickValid(index))
            {
                JoystickDevice<Sdl2JoystickDetails> joystick =
                    (JoystickDevice<Sdl2JoystickDetails>)joysticks[index];

                for (int i = 0; i < joystick.Axis.Count; i++)
                {
                    state.SetAxis(JoystickAxis.Axis0 + i, (short)(joystick.Axis[i] * short.MaxValue + 0.5f));
                }

                for (int i = 0; i < joystick.Button.Count; i++)
                {
                    state.SetButton(JoystickButton.Button0 + i, joystick.Button[i]);
                }

                for (int i = 0; i < joystick.Details.HatCount; i++)
                {
                    state.SetHat(JoystickHat.Hat0 + i, joystick.Details.Hat[i]);
                }

                state.SetIsConnected(joystick.Details.IsConnected);
                state.SetPacketNumber(joystick.Details.PacketNumber);
            }

            return state;
        }

        JoystickCapabilities IJoystickDriver2.GetCapabilities(int index)
        {
            if (IsJoystickValid(index))
            {
                JoystickDevice<Sdl2JoystickDetails> joystick =
                    (JoystickDevice<Sdl2JoystickDetails>)joysticks[index];

                return new JoystickCapabilities(
                    joystick.Axis.Count,
                    joystick.Button.Count,
                    joystick.Details.HatCount,
                    joystick.Details.IsConnected);
            }
            return new JoystickCapabilities();
        }

        Guid IJoystickDriver2.GetGuid(int index)
        {
            Guid guid = new Guid();
            if (IsJoystickValid(index))
            {
                JoystickDevice<Sdl2JoystickDetails> joystick =
                    (JoystickDevice<Sdl2JoystickDetails>)joysticks[index];

                return joystick.Details.Guid;
            }
            return guid;
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

