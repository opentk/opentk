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
using static OpenTK.Platform.Native.Windows.JoystickComponent;
using static OpenTK.Platform.Native.Windows.XInput;

namespace OpenTK.Platform.Native.Windows
{
    /// <summary>
    /// Win32 implementation of <see cref="IJoystickComponent"/>.
    /// </summary>
    public class JoystickComponent : IJoystickComponent
    {
        /// <inheritdoc/>
        public string Name => "Win32JoystickComponent";

        /// <inheritdoc/>
        public PalComponents Provides => PalComponents.Joystick;

        /// <inheritdoc/>
        public ILogger? Logger { get; set; }

        private DirectInput.IDirectInput8 DirectInput8;

        private List<Joystick> Joysticks = new List<Joystick>();

        /// <inheritdoc/>
        public float LeftDeadzone => 7849 / 32767.0f;

        /// <inheritdoc/>
        public float RightDeadzone => 8689 / 32767.0f;

        /// <inheritdoc/>
        public float TriggerThreshold => 30 / 255.0f;

        /// <inheritdoc/>
        public void Initialize(ToolkitOptions options)
        {
            // We don't need to call CoInitializeEx as the CLR already does that for all threads.
            Guid CLSID_DirectInput = DirectInput.CLSID_DirectInput;
            Guid IID_IDirectInputW = DirectInput.IID_IDirectInputW;
            CoCreateInstance(
                ref CLSID_DirectInput,
                IUnknown.Null,
                CLSCTX.INPROC_SERVER,
                ref IID_IDirectInputW,
                out IUnknown directInput8IUnk);

            DirectInput8 = (IDirectInput8)directInput8IUnk;

            DirectInput8.Initialize(WindowComponent.HInstance, 0x0800);

            unsafe int DeviceEnumCallback(DIDEVICEINSTANCE* lpddi, IntPtr pvRef)
            {
                string instanceName = Utils.FromTszString(lpddi->tszInstanceName, MAX_PATH);
                string productName = Utils.FromTszString(lpddi->tszProductName, MAX_PATH);

                Console.WriteLine($"Type: {lpddi->dwDevType & (DevType)0xFF}, Instance Name: {instanceName}, ProductName: {productName}, GUID Instance: {lpddi->guidInstance}, GUID Product: {lpddi->guidProduct}");

                DirectInput8.CreateDevice(lpddi->guidInstance, out IDirectInputDevice8 device, IUnknown.Null);

                device.Initialize(WindowComponent.HInstance, 0x0800, ref lpddi->guidInstance);

                device.GetCapabilities(out DIDEVCAPS capabilities);

                Console.WriteLine($"  Capabilities: Flags: {capabilities.dwFlags}, Axes: {capabilities.dwAxes}, Buttons: {capabilities.dwButtons}, POVs: {capabilities.dwPOVs}, FFSamplePeriod: {capabilities.dwFFSamplePeriod}, FFMinTimeResolution: {capabilities.dwFFMinTimeResolution}");

                Joysticks.Add(new Joystick(device, lpddi->guidInstance, instanceName));

                // Set the format to c_dfDIJoystick2, we can get the definition from here.
                // http://docs.ros.org/en/kinetic/api/librealsense2/html/win32__joystick_8c_source.html
                // https://github.com/elmindreda/c_dfDIJoystick2

                device.SetDataFormat(ref c_dfDIJoystick);

                // FIXME: Set the buffer size!

                device.Acquire();

                // FIXME: Get the data

                device.Unacquire();

                return 1;
            }

            unsafe
            {
                DirectInput8.EnumDevices(DevType.ClassGameCtrl, DeviceEnumCallback, IntPtr.Zero, DIEDFL.AttachedOnly);
            }

            // FIXME!!
            while (Joysticks.Count < 4)
            {
                Joysticks.Add(new Joystick(default, default, null!));
            }
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
            Joystick joystick = handle.As<Joystick>(this);
        }


        public bool SupportsVibration(JoystickHandle handle)
        {
            Joystick joystick = handle.As<Joystick>(this);

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
            Joystick joystick = handle.As<Joystick>(this);

            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public unsafe string GetName(JoystickHandle handle)
        {
            Joystick joystick = handle.As<Joystick>(this);
            joystick.Device.GetDeviceInfo(out var info);
            return Utils.FromTszString(info.tszInstanceName, DirectInput.MAX_PATH);
        }

        public int GetNumberOfButtons(JoystickHandle handle)
        {
            Joystick joystick = handle.As<Joystick>(this);
            joystick.Device.GetCapabilities(out DIDEVCAPS capabilities);
            return (int)capabilities.dwButtons;
        }

        public int GetNumberOfAxes(JoystickHandle handle)
        {
            Joystick joystick = handle.As<Joystick>(this);
            joystick.Device.GetCapabilities(out DIDEVCAPS capabilities);
            return (int)capabilities.dwAxes;
        }

        public bool SupportsForceFeedback(JoystickHandle handle)
        {
            Joystick joystick = handle.As<Joystick>(this);
            joystick.Device.GetCapabilities(out DIDEVCAPS capabilities);
            return capabilities.dwFlags.HasFlag(DIDC.ForceFeedback);
        }

        /// <inheritdoc/>
        public float GetAxis(JoystickHandle handle, JoystickAxis axis)
        {
            Joystick joystick = handle.As<Joystick>(this);

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
            Joystick joystick = handle.As<Joystick>(this);

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
            Joystick joystick = handle.As<Joystick>(this);

            lowFrequenzyIntensity = Math.Clamp(lowFrequenzyIntensity, 0, 1);
            highFrequenzyIntensity = Math.Clamp(highFrequenzyIntensity, 0, 1);

            XINPUT_VIBRATION vibration;
            vibration.wLeftMotorSpeed = (ushort)(lowFrequenzyIntensity * ushort.MaxValue);
            vibration.wRightMotorSpeed = (ushort)(highFrequenzyIntensity * ushort.MaxValue);

            uint result = XInputSetState((uint)joystick.XInputIndex, in vibration);
            return result == ERROR_SUCCESS;
        }

        public bool TryGetBatteryInfo(JoystickHandle handle, out GamepadBatteryInfo batteryInfo)
        {
            Joystick joystick = handle.As<Joystick>(this);

            uint result = XInputGetBatteryInformation((uint)joystick.XInputIndex, DeviceType.Gamepad, out XINPUT_BATTERY_INFORMATION batteryInformation);
            if (result == ERROR_SUCCESS)
            {
                GamepadBatteryType type;
                switch (batteryInformation.BatteryType)
                {
                    case BatteryType.Wired: type = GamepadBatteryType.Wired; break;
                    case BatteryType.Alkaline: type = GamepadBatteryType.Alkaline; break;
                    case BatteryType.NiMH: type = GamepadBatteryType.NiMH; break;
                    case BatteryType.Unknown: type = GamepadBatteryType.Unknown; break;

                    case BatteryType.Disconnected:
                        batteryInfo = default;
                        return false;

                    default:
                        Logger?.LogWarning($"Got unknown battery type {batteryInformation.BatteryType}");
                        batteryInfo = default;
                        return false;
                }

                float charge;
                switch (batteryInformation.BatteryLevel)
                {
                    case BatteryLevel.Empty:  charge = 0;      break;
                    case BatteryLevel.Low:    charge = 1/3.0f; break;
                    case BatteryLevel.Medium: charge = 2/3.0f; break;
                    case BatteryLevel.Full:   charge = 1;      break;
                    default: throw new InvalidEnumArgumentException(nameof(batteryInformation.BatteryLevel), (int)batteryInformation.BatteryLevel, typeof(BatteryLevel));
                }

                batteryInfo = new GamepadBatteryInfo(type, charge);
                return true;
            }
            else
            {
                batteryInfo = default;
                return false;
            }
        }
    }
}
