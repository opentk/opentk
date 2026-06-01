using OpenTK.Platform;
using OpenTK.Core.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static OpenTK.Platform.Native.SDL.SDL;

namespace OpenTK.Platform.Native.SDL
{
    public unsafe class SDLJoystickComponent : IJoystickComponent
    {
        /// <inheritdoc/>
        public string Name => nameof(SDLJoystickComponent);

        /// <inheritdoc/>
        public PalComponents Provides => PalComponents.Joystick;

        /// <inheritdoc/>
        public ILogger? Logger { get; set; }

        internal List<SDLJoystick> Joysticks = new List<SDLJoystick>();

        /// <inheritdoc/>
        public void Initialize(ToolkitOptions options)
        {
            //SDL_JoystickUpdate();
            SDL_JoystickEventState(1);
            //SDL_SetHint("SDL_JOYSTICK_ALLOW_BACKGROUND_EVENTS", "1");
            Logger?.LogDebug($"{SDL_NumJoysticks()} joysticks connected.");
        }

        /// <inheritdoc/>
        public void Uninitialize()
        {
            // FIXME: Do cleanup..
        }

        internal void JoystickAddedOrRemoved(SDL_JoyDeviceEvent deviceEvent)
        {
            if (deviceEvent.type == SDL_EventType.SDL_JOYDEVICEADDED)
            {
                // FIXME: Rebuild the entire list?
                SDL_Joystick* joystick = SDL_JoystickOpen(deviceEvent.which);
                SDL_JoystickID instanceID = SDL_JoystickInstanceID(joystick);
                Joysticks.Add(new SDLJoystick(joystick, instanceID));
            }
            else if (deviceEvent.type == SDL_EventType.SDL_JOYDEVICEREMOVED)
            {
                SDL_JoystickID instanceID = (SDL_JoystickID)deviceEvent.which;
                var joystick = Joysticks.Find(j => j.InstanceID == instanceID);
                Joysticks.Remove(joystick);
                joystick.InstanceID = (SDL_JoystickID)0;
                joystick.Joystick = null;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        /// <inheritdoc/>
        public int GetJoystickCount()
        {
            return SDL_NumJoysticks();
        }
        
        /// <inheritdoc/>
        public JoystickHandle Open(int index)
        {
            // FIXME: Error check so we don't open a game controller that is outside of the range.

            return Joysticks[index];
        }

        /// <inheritdoc/>
        public void Close(JoystickHandle joystick)
        {
            SDLJoystick sdljoystick = joystick.As<SDLJoystick>(this);

            
        }

        /// <inheritdoc/>
        public Guid GetGuid(JoystickHandle joystick)
        {
            SDLJoystick sdljoystick = joystick.As<SDLJoystick>(this);

            SDL_JoystickGUID guid = SDL_JoystickGetGUID(sdljoystick.Joystick);

            // FIXME: Is the endianness correct here??
            return new Guid(new ReadOnlySpan<byte>(guid.data, 16));
        }

        /// <inheritdoc/>
        public string GetName(JoystickHandle joystick)
        {
            SDLJoystick sdljoystick = joystick.As<SDLJoystick>(this);

            char* name = SDL_JoystickName(sdljoystick.Joystick);
            if (name == null)
            {
                string error = SDL_GetError();
                throw new PalException(this, $"SDL could not get joystick name: {error}");
            }

            return Marshal.PtrToStringUTF8((IntPtr)name)!;
        }

        /// <inheritdoc/>
        public bool TryGetBatteryInfo(JoystickHandle joystick, out GamepadBatteryInfo batteryInfo)
        {
            SDLJoystick sdljoystick = joystick.As<SDLJoystick>(this);

            SDL_JoystickPowerLevel level = SDL_JoystickCurrentPowerLevel(sdljoystick.Joystick);

            batteryInfo.BatteryType = GamepadBatteryType.Unknown;

            if (level == SDL_JoystickPowerLevel.SDL_JOYSTICK_POWER_UNKNOWN)
            {
                batteryInfo.ChargeLevel = -1;
                return false;
            }

            switch (level)
            {
                case SDL_JoystickPowerLevel.SDL_JOYSTICK_POWER_EMPTY:
                    batteryInfo.ChargeLevel = 0.05f;
                    break;
                case SDL_JoystickPowerLevel.SDL_JOYSTICK_POWER_LOW:
                    batteryInfo.ChargeLevel = 0.2f;
                    break;
                case SDL_JoystickPowerLevel.SDL_JOYSTICK_POWER_MEDIUM:
                    batteryInfo.ChargeLevel = 0.7f;
                    break;
                case SDL_JoystickPowerLevel.SDL_JOYSTICK_POWER_FULL:
                    batteryInfo.ChargeLevel = 1.0f;
                    break;
                case SDL_JoystickPowerLevel.SDL_JOYSTICK_POWER_WIRED:
                    batteryInfo.ChargeLevel = 1.0f;
                    batteryInfo.BatteryType = GamepadBatteryType.Wired;
                    break;
                default:
                    throw new PalException(this, $"Got unknown power level from SDL: {level}");
            }

            return true;
        }

        /// <inheritdoc/>
        public JoystickCapabilities GetCapabilities(JoystickHandle joystick)
        {
            SDLJoystick sdljoystick = joystick.As<SDLJoystick>(this);

            JoystickCapabilities caps = 0;

            if (SDL_JoystickHasRumble(sdljoystick.Joystick))
                caps |= JoystickCapabilities.Rumble;

            return caps;
        }

        /// <inheritdoc/>
        public int GetNumberOfAxes(JoystickHandle joystick)
        {
            SDLJoystick sdljoystick = joystick.As<SDLJoystick>(this);

            return SDL_JoystickNumAxes(sdljoystick.Joystick);
        }

        /// <inheritdoc/>
        public float GetAxis(JoystickHandle joystick, int axis)
        {
            SDLJoystick sdljoystick = joystick.As<SDLJoystick>(this);

            short value = SDL_JoystickGetAxis(sdljoystick.Joystick, axis);

            // [-32768, 32767] -> [-32767.5, 32767.5] -> [-1, 1]
            return (value + 0.5f) / 32767.5f;
        }

        /// <inheritdoc/>
        public int GetNumberOfButtons(JoystickHandle joystick)
        {
            SDLJoystick sdljoystick = joystick.As<SDLJoystick>(this);

            return SDL_JoystickNumButtons(sdljoystick.Joystick);
        }

        /// <inheritdoc/>
        public bool GetButton(JoystickHandle joystick, int button)
        {
            SDLJoystick sdljoystick = joystick.As<SDLJoystick>(this);

            byte value = SDL_JoystickGetButton(sdljoystick.Joystick, button);

            return value == 1;
        }

        /// <inheritdoc/>
        public int GetNumberOfHats(JoystickHandle joystick)
        {
            SDLJoystick sdljoystick = joystick.As<SDLJoystick>(this);

            return SDL_JoystickNumHats(sdljoystick.Joystick);
        }

        /// <inheritdoc/>
        public HatState GetHat(JoystickHandle joystick, int hat)
        {
            SDLJoystick sdljoystick = joystick.As<SDLJoystick>(this);

            int value = SDL_JoystickGetHat(sdljoystick.Joystick, hat);

            switch (value)
            {
                case SDL_HAT_CENTERED:
                    return HatState.Centered;
                case SDL_HAT_UP:
                    return HatState.Up;
                case SDL_HAT_RIGHT:
                    return HatState.Right;
                case SDL_HAT_DOWN:
                    return HatState.Down;
                case SDL_HAT_LEFT:
                    return HatState.Left;
                case SDL_HAT_RIGHTUP:
                    return HatState.RightUp;
                case SDL_HAT_RIGHTDOWN:
                    return HatState.RightDown;
                case SDL_HAT_LEFTUP:
                    return HatState.LeftUp;
                case SDL_HAT_LEFTDOWN:
                    return HatState.LeftDown;
                default:
                    Logger?.LogWarning($"SDL returned {value} as the hat state, this is not documented behaviour.");
                    return 0;
            }
        }

        /// <inheritdoc/>
        public bool SetRumble(JoystickHandle joystick, float lowFreqIntensity, float highFreqIntensity)
        {
            SDLJoystick sdljoystick = joystick.As<SDLJoystick>(this);

            ushort low = (ushort)(lowFreqIntensity * 0xFFFF);
            ushort high = (ushort)(highFreqIntensity * 0xFFFF);

            // FIXME: Maybe we should do like SDL and add a time to the rumble.
            // For now we just do the max time, which is about 49 days, should be enough.
            // - 2023-04-18 Noggin_bops
            int result = SDL_JoystickRumble(sdljoystick.Joystick, low, high, uint.MaxValue);

            return result == 0;
        }
    }
}
