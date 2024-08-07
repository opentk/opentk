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

        /// <inheritdoc/>
        public void Initialize(ToolkitOptions options)
        {
            SDL_JoystickUpdate();
            Console.WriteLine( $"{SDL_NumJoysticks()} joysticks connected." );
        }

        // FIXME: 0 is probably not a good value to have here?
        // Should we copy the XInput values from the windows backend?
        /// <inheritdoc/>
        public float LeftDeadzone => 0;
        /// <inheritdoc/>
        public float RightDeadzone => 0;
        /// <inheritdoc/>
        public float TriggerThreshold => 0;

        /// <inheritdoc/>
        public bool IsConnected(int index)
        {
            // FIXME: This is probably the wrong check
            return SDL_IsGameController(index);
        }

        /// <inheritdoc/>
        public JoystickHandle Open(int index)
        {
            // FIXME: Error check so we don't open a game controller that is outside of the range.

            // FIXME: What does index mean here? Do we really mean player index instead of index?
            SDL_GameController* gameController = SDL_GameControllerOpen(index);
            if (gameController == null)
            {
                string error = SDL_GetError();
                throw new PalException(this, $"SDL failed to open game controller with index {index}: {error}");
            }

            return new SDLJoystick(gameController);
        }

        /// <inheritdoc/>
        public void Close(JoystickHandle handle)
        {
            SDLJoystick joystick = handle.As<SDLJoystick>(this);

            SDL_GameControllerClose(joystick.GameController);
            joystick.GameController = null;
        }

        /// <inheritdoc/>
        public Guid GetGuid(JoystickHandle handle)
        {
            SDLJoystick joystick = handle.As<SDLJoystick>(this);

            SDL_Joystick* stick = SDL_GameControllerGetJoystick(joystick.GameController);

            SDL_JoystickGUID guid = SDL_JoystickGetGUID(stick);

            // FIXME: Is the endianness correct here??
            return new Guid(new ReadOnlySpan<byte>(guid.data, 16));
        }

        /// <inheritdoc/>
        public string GetName(JoystickHandle handle)
        {
            SDLJoystick joystick = handle.As<SDLJoystick>(this);

            char* name = SDL_GameControllerName(joystick.GameController);
            if (name == null)
            {
                string error = SDL_GetError();
                throw new PalException(this, $"SDL could not get joystick name: {error}");
            }

            return Marshal.PtrToStringUTF8((IntPtr)name)!;
        }

        /// <inheritdoc/>
        public float GetAxis(JoystickHandle handle, JoystickAxis axis)
        {
            SDLJoystick joystick = handle.As<SDLJoystick>(this);

            SDL_GameControllerAxis sdlAxis;
            switch (axis)
            {
                case JoystickAxis.LeftXAxis:
                    sdlAxis = SDL_GameControllerAxis.SDL_CONTROLLER_AXIS_LEFTX;
                    break;
                case JoystickAxis.LeftYAxis:
                    sdlAxis = SDL_GameControllerAxis.SDL_CONTROLLER_AXIS_LEFTY;
                    break;
                case JoystickAxis.RightYAxis:
                    sdlAxis = SDL_GameControllerAxis.SDL_CONTROLLER_AXIS_RIGHTY;
                    break;
                case JoystickAxis.RightXAxis:
                    sdlAxis = SDL_GameControllerAxis.SDL_CONTROLLER_AXIS_RIGHTX;
                    break;
                case JoystickAxis.LeftTrigger:
                    sdlAxis = SDL_GameControllerAxis.SDL_CONTROLLER_AXIS_TRIGGERLEFT;
                    break;
                case JoystickAxis.RightTrigger:
                    sdlAxis = SDL_GameControllerAxis.SDL_CONTROLLER_AXIS_TRIGGERRIGHT;
                    break;
                default:
                    throw new InvalidEnumArgumentException(nameof(axis), (int)axis, axis.GetType());
            }

            short value = SDL_GameControllerGetAxis(joystick.GameController, sdlAxis);

            // [-32768, 32767] -> [-32767.5, 32767.5] -> [-1, 1]
            return (value + 0.5f) / 32767.5f;
        }

        /// <inheritdoc/>
        public bool GetButton(JoystickHandle handle, JoystickButton button)
        {
            SDLJoystick joystick = handle.As<SDLJoystick>(this);

            SDL_GameControllerButton sdlButton;
            switch (button)
            {
                case JoystickButton.A:
                    sdlButton = SDL_GameControllerButton.SDL_CONTROLLER_BUTTON_A;
                    break;
                case JoystickButton.B:
                    sdlButton = SDL_GameControllerButton.SDL_CONTROLLER_BUTTON_B;
                    break;
                case JoystickButton.X:
                    sdlButton = SDL_GameControllerButton.SDL_CONTROLLER_BUTTON_X;
                    break;
                case JoystickButton.Y:
                    sdlButton = SDL_GameControllerButton.SDL_CONTROLLER_BUTTON_Y;
                    break;
                case JoystickButton.Start:
                    sdlButton = SDL_GameControllerButton.SDL_CONTROLLER_BUTTON_START;
                    break;
                case JoystickButton.Back:
                    sdlButton = SDL_GameControllerButton.SDL_CONTROLLER_BUTTON_BACK;
                    break;
                case JoystickButton.LeftThumb:
                    sdlButton = SDL_GameControllerButton.SDL_CONTROLLER_BUTTON_LEFTSTICK;
                    break;
                case JoystickButton.RightThumb:
                    sdlButton = SDL_GameControllerButton.SDL_CONTROLLER_BUTTON_RIGHTSTICK;
                    break;
                case JoystickButton.LeftShoulder:
                    sdlButton = SDL_GameControllerButton.SDL_CONTROLLER_BUTTON_LEFTSHOULDER;
                    break;
                case JoystickButton.RightShoulder:
                    sdlButton = SDL_GameControllerButton.SDL_CONTROLLER_BUTTON_RIGHTSHOULDER;
                    break;
                case JoystickButton.DPadUp:
                    sdlButton = SDL_GameControllerButton.SDL_CONTROLLER_BUTTON_DPAD_UP;
                    break;
                case JoystickButton.DPadDown:
                    sdlButton = SDL_GameControllerButton.SDL_CONTROLLER_BUTTON_DPAD_DOWN;
                    break;
                case JoystickButton.DPadLeft:
                    sdlButton = SDL_GameControllerButton.SDL_CONTROLLER_BUTTON_DPAD_LEFT;
                    break;
                case JoystickButton.DPadRight:
                    sdlButton = SDL_GameControllerButton.SDL_CONTROLLER_BUTTON_DPAD_RIGHT;
                    break;
                default:
                    throw new InvalidEnumArgumentException(nameof(button), (int)button, button.GetType());
            }

            byte value = SDL_GameControllerGetButton(joystick.GameController, sdlButton);

            return value == 1;
        }

        /// <inheritdoc/>
        public bool SetVibration(JoystickHandle handle, float lowFreqIntensity, float highFreqIntensity)
        {
            SDLJoystick joystick = handle.As<SDLJoystick>(this);

            ushort low = (ushort)(lowFreqIntensity * 0xFFFF);
            ushort high = (ushort)(highFreqIntensity * 0xFFFF);

            // FIXME: Maybe we should do like SDL and add a time to the rumble.
            // For now we just do the max time, which is about 49 days, should be enough.
            // - 2023-04-18 Noggin_bops
            int result = SDL_GameControllerRumble(joystick.GameController, low, high, uint.MaxValue);

            return result == 0;
        }

        /// <inheritdoc/>
        public bool TryGetBatteryInfo(JoystickHandle handle, out GamepadBatteryInfo batteryInfo)
        {
            SDLJoystick joystick = handle.As<SDLJoystick>(this);

            SDL_Joystick* stick = SDL_GameControllerGetJoystick(joystick.GameController);
            if (stick == null)
            {
                string error = SDL_GetError();
                throw new PalException(this, $"SDL failed to get joystick: {error}");
            }

            SDL_JoystickPowerLevel level = SDL_JoystickCurrentPowerLevel(stick);

            batteryInfo.BatteryType = GamepadBatteryType.Unknown;

            if (level == SDL_JoystickPowerLevel.SDL_JOYSTICK_POWER_UNKNOWN)
            {
                batteryInfo.ChargeLevel = -1;
                return false;
            }

            switch (level)
            {
                case SDL_JoystickPowerLevel.SDL_JOYSTICK_POWER_EMPTY:
                    batteryInfo.ChargeLevel = 5;
                    break;
                case SDL_JoystickPowerLevel.SDL_JOYSTICK_POWER_LOW:
                    batteryInfo.ChargeLevel = 20;
                    break;
                case SDL_JoystickPowerLevel.SDL_JOYSTICK_POWER_MEDIUM:
                    batteryInfo.ChargeLevel = 70;
                    break;
                case SDL_JoystickPowerLevel.SDL_JOYSTICK_POWER_FULL:
                    batteryInfo.ChargeLevel = 100;
                    break;
                case SDL_JoystickPowerLevel.SDL_JOYSTICK_POWER_WIRED:
                    batteryInfo.ChargeLevel = 100;
                    break;
                default:
                    throw new PalException(this, $"Got unknown power level from SDL: {level}");
            }

            return true;
        }
    }
}
