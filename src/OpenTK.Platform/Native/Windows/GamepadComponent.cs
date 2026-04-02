using OpenTK.Core;
using OpenTK.Platform;
using OpenTK.Core.Utility;
using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using static OpenTK.Platform.Native.Windows.DirectInput;
using static OpenTK.Platform.Native.Windows.XInput;

namespace OpenTK.Platform.Native.Windows
{
    /// <summary>
    /// Win32 implementation of <see cref="IJoystickComponent"/>.
    /// </summary>
    public class GamepadComponent : IGamepadComponent
    {
        /// <inheritdoc/>
        public string Name => "Win32GamepadComponent";

        /// <inheritdoc/>
        public PalComponents Provides => PalComponents.Gamepad;

        /// <inheritdoc/>
        public ILogger? Logger { get; set; }

        private DirectInput.IDirectInput8 DirectInput8;

        private List<WinJoystick> Joysticks = new List<WinJoystick>();

        /// <inheritdoc/>
        public float LeftDeadzone => 7849 / 32767.0f;

        /// <inheritdoc/>
        public float RightDeadzone => 8689 / 32767.0f;

        /// <inheritdoc/>
        public float TriggerThreshold => 30 / 255.0f;

        /// <inheritdoc/>
        public void Initialize(ToolkitOptions options)
        {

        }

        /// <inheritdoc/>
        public void Uninitialize()
        {
            // FIXME: Unititialize all of the data.
        }

        /// <inheritdoc/>
        public bool IsConnected(int deviceIndex)
        {
            uint result = XInputGetCapabilities((uint)deviceIndex, 0, out _);
            return result == ERROR_SUCCESS;
        }

        /// <inheritdoc/>
        public JoystickHandle Open(int deviceIndex)
        {
            // FIXME: Reference count??
            Joysticks[deviceIndex].XInputIndex = deviceIndex;
            return Joysticks[deviceIndex];
        }

        /// <inheritdoc/>
        public void Close(JoystickHandle handle)
        {
        }


        public bool SupportsVibration(JoystickHandle handle)
        {
            WinJoystick joystick = handle.As<WinJoystick>(this);

            uint result = XInputGetCapabilities((uint)joystick.XInputIndex, 0, out XINPUT_CAPABILITIES capabilities);
            if (result == ERROR_SUCCESS)
            {
                Console.WriteLine($"Vibration cap Left: {capabilities.Vibration.wLeftMotorSpeed}, Right: {capabilities.Vibration.wRightMotorSpeed}");

                Console.WriteLine($"Flags: {capabilities.Flags}");

                return capabilities.Flags.HasFlag(Caps.FFBSupported);
            }
            else
            {
                return false;
            }
        }

        /// <inheritdoc/>
        public Guid GetGuid(JoystickHandle handle)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public unsafe string GetName(JoystickHandle handle)
        {
            throw new NotImplementedException();
        }

        public bool SupportsForceFeedback(JoystickHandle handle)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public float GetAxis(JoystickHandle handle, JoystickAxis axis)
        {
            WinJoystick joystick = handle.As<WinJoystick>(this);

            uint result = XInputGetState((uint)joystick.XInputIndex, out XINPUT_STATE state);
            if (result == ERROR_SUCCESS)
            {
                float value;
                switch (axis)
                {
                    case JoystickAxis.LeftXAxis:
                        value = (state.Gamepad.sThumbLX + 0.5f) / 32767.5f;
                        break;
                    case JoystickAxis.LeftYAxis:
                        value = (state.Gamepad.sThumbLY + 0.5f) / 32767.5f;
                        break;
                    case JoystickAxis.RightYAxis:
                        value = (state.Gamepad.sThumbRX + 0.5f) / 32767.5f;
                        break;
                    case JoystickAxis.RightXAxis:
                        value = (state.Gamepad.sThumbRY + 0.5f) / 32767.5f;
                        break;
                    case JoystickAxis.LeftTrigger:
                        value = state.Gamepad.bLeftTrigger / 255.0f;
                        break;
                    case JoystickAxis.RightTrigger:
                        value = state.Gamepad.bRightTrigger / 255.0f;
                        break;
                    default:
                        throw new InvalidEnumArgumentException(nameof(axis), (int)axis, typeof(JoystickAxis));
                }

                return value;
            }
            else
            {
                // No gamepad is connected here
                return 0;
            }
        }

        /// <inheritdoc/>
        public bool GetButton(JoystickHandle handle, JoystickButton button)
        {
            WinJoystick joystick = handle.As<WinJoystick>(this);

            uint result = XInputGetState((uint)joystick.XInputIndex, out XINPUT_STATE state);
            if (result == ERROR_SUCCESS)
            {
                XInputGamepadButton xButton;
                switch (button)
                {
                    case JoystickButton.A: xButton = XInputGamepadButton.A; break;
                    case JoystickButton.B: xButton = XInputGamepadButton.B; break;
                    case JoystickButton.X: xButton = XInputGamepadButton.X; break;
                    case JoystickButton.Y: xButton = XInputGamepadButton.Y; break;
                    case JoystickButton.Start: xButton = XInputGamepadButton.Start; break;
                    case JoystickButton.Back:  xButton = XInputGamepadButton.Back; break; 
                    case JoystickButton.LeftThumb:     xButton = XInputGamepadButton.LeftThumb; break;
                    case JoystickButton.RightThumb:    xButton = XInputGamepadButton.RightThumb; break;
                    case JoystickButton.LeftShoulder:  xButton = XInputGamepadButton.LeftShoulder; break;
                    case JoystickButton.RightShoulder: xButton = XInputGamepadButton.RightShoulder; break;
                    case JoystickButton.DPadUp:    xButton = XInputGamepadButton.DPadUp; break;
                    case JoystickButton.DPadDown:  xButton = XInputGamepadButton.DPadDown; break;
                    case JoystickButton.DPadLeft:  xButton = XInputGamepadButton.DPadLeft; break;
                    case JoystickButton.DPadRight: xButton = XInputGamepadButton.DPadRight; break;
                    default: throw new InvalidEnumArgumentException(nameof(button), (int)button, typeof(JoystickButton));
                }

                return state.Gamepad.wButtons.HasFlag(xButton);
            }
            else
            {
                return false;
            }
        }

        /// <inheritdoc/>
        public bool SetVibration(JoystickHandle handle, float lowFrequenzyIntensity, float highFrequenzyIntensity)
        {
            throw new NotImplementedException();

        }

        public bool TryGetBatteryInfo(JoystickHandle handle, out GamepadBatteryInfo batteryInfo)
        {
            throw new NotImplementedException();

        }
    }
}
