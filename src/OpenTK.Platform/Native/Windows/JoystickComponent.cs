using OpenTK.Core;
using OpenTK.Core.Utility;
using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static OpenTK.Platform.Native.Windows.DirectInput;
using static OpenTK.Platform.Native.Windows.XInput;

namespace OpenTK.Platform.Native.Windows
{
    // FIXME: To deal with different kinds of joysticks and the like it might make sense
    // for each joystick instance to contain the implementation itself.
    // For example if we are going to support direct HID operation for special controllers
    // then we are going to want some joysticks to have their own implementation
    // which is going to get complicated if they are doing to be per-platform
    // and all in the same file.
    // - Noggin_bops 2025-10-12

    internal enum JoyObjectType
    {
        Axis,
        Slider,
        Button,
        Pov,
    }

    internal struct JoyObject
    {
        public int Offset;
        public JoyObjectType Type;

        public override string ToString()
        {
            return $"Offset: {Offset}, Type: {Type}";
        }
    }

    internal enum HardwareBusType
    {
        Unknown = 0x00,
        Usb = 0x03,
        Bluetooth = 0x05,
        Virtual = 0xFF,
    }

    /// <summary>
    /// Guid structure that is SDL compatible.
    /// </summary>
    /// <remarks>
    /// The standard library <see cref="Guid"/> has mixed-endianness which makes it more complcated to generate SDL compatible guids.
    /// </remarks>
    internal struct SdlGuid
    {
        public ushort Bus;
        public ushort Crc;
        public ushort Vendor;
        private ushort Reserved0;
        public ushort Product;
        private ushort Reserved1;
        public ushort Version;
        public ushort DriverSignatureAndData;

        public unsafe SdlGuid(ReadOnlySpan<ushort> data)
        {
            if (data.Length != 8)
                throw new ArgumentException("The span must be exactly 16 bytes (8 ushorts) long");

            fixed(SdlGuid* guid = &this)
            fixed(ushort* src = data)
            {
                NativeMemory.Copy(src, (ushort*)guid, 16);
            }
        }

        public unsafe override string ToString()
        {
            const string ByteToHex = "0123456789ABCDEF";

            StringBuilder sb = new StringBuilder(32);

            SdlGuid guid = this;
            ReadOnlySpan<byte> data = new ReadOnlySpan<byte>(&guid, 16);
            for (int i = 0; i < data.Length; i++)
            {
                byte d = data[i];
                sb.Append(ByteToHex[(d >> 4) & 0xF]);
                sb.Append(ByteToHex[(d >> 0) & 0xF]);
            }

            return sb.ToString();
        }

        public Guid ToGuid()
        {
            return new Guid((uint)Bus << 16 | Crc, Vendor, Reserved0, (byte)(Product >> 8), (byte)(Product >> 0), (byte)(Reserved1 >> 8), (byte)(Reserved1 >> 0), (byte)(Version >> 8), (byte)(Version >> 0), (byte)(DriverSignatureAndData >> 8), (byte)(DriverSignatureAndData >> 0));
        }
    }

    public unsafe class JoystickComponent : IJoystickComponent
    {
        /// <inheritdoc/>
        public string Name => "Win32JoystickComponent";

        /// <inheritdoc/>
        public PalComponents Provides => PalComponents.Joystick;

        /// <inheritdoc/>
        public ILogger? Logger { get; set; }

        private DirectInput.IDirectInput8 _directInput8;

        private List<WinJoystick> _joysticks = new List<WinJoystick>();

        /// <inheritdoc/>
        private float _leftDeadzone => 7849 / 32767.0f;

        /// <inheritdoc/>
        private float _rightDeadzone => 8689 / 32767.0f;

        /// <inheritdoc/>
        private float _triggerThreshold => 30 / 255.0f;

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

            _directInput8 = (IDirectInput8)directInput8IUnk;

            _directInput8.Initialize(WindowComponent.HInstance, 0x0800);

            unsafe
            {
                _directInput8.EnumDevices(DevType.ClassGameCtrl, (lpddi, _) => {
                    string instanceName = Utils.FromTszString(lpddi->tszInstanceName, MAX_PATH);
                    string productName = Utils.FromTszString(lpddi->tszProductName, MAX_PATH);

                    Logger?.LogDebug($"Type: {lpddi->dwDevType & (DevType)0xFF}, Instance Name: {instanceName}, ProductName: {productName}, GUID Instance: {lpddi->guidInstance}, GUID Product: {lpddi->guidProduct}, Is HID: {lpddi->dwDevType.HasFlag(DevType.Hid)}");

                    _directInput8.CreateDevice(lpddi->guidInstance, out IDirectInputDevice8 device, IUnknown.Null);
                    
                    device.Initialize(WindowComponent.HInstance, 0x0800, ref lpddi->guidInstance);

                    device.GetCapabilities(out DIDEVCAPS capabilities);

                    Logger?.LogDebug($"  Capabilities: Flags: {capabilities.dwFlags}, Axes: {capabilities.dwAxes}, Buttons: {capabilities.dwButtons}, POVs: {capabilities.dwPOVs}, FFSamplePeriod: {capabilities.dwFFSamplePeriod}, FFMinTimeResolution: {capabilities.dwFFMinTimeResolution}");

                    // Set the format to c_dfDIJoystick2, we can get the definition from here.
                    // http://docs.ros.org/en/kinetic/api/librealsense2/html/win32__joystick_8c_source.html
                    // https://github.com/elmindreda/c_dfDIJoystick2

                    device.SetDataFormat(ref c_dfDIJoystick);
                    device.SetCooperativeLevel(WindowComponent.HelperHWnd, DISCL.Exclusive | DISCL.Background);

                    DIPROPDWORD dipd = default;
                    dipd.diph.dwSize = (uint)Unsafe.SizeOf<DIPROPDWORD>();
                    dipd.diph.dwHeaderSize = (uint)Unsafe.SizeOf<DIPROPHEADER>();
                    dipd.diph.dwHow = DIPHHow.Device;
                    dipd.diph.dwObj = 0;
                    dipd.dwData = (uint)DIPropAxisMode.Abs;
                    device.SetProperty(DIPROP_AXISMODE, &dipd.diph);

                    // FIXME: Set the buffer size!

                    int sliderCount = 0;
                    int axisCount = 0;
                    int buttonCount = 0;
                    int povCount = 0;

                    int objectCount = 0;

                    JoyObject[] objects = new JoyObject[capabilities.dwAxes + capabilities.dwButtons + capabilities.dwPOVs];

                    device.EnumObjects((ddoi, _) => {

                        ref JoyObject obj = ref objects[objectCount];

                        if ((ddoi->dwType.GetType2() & DIDFT.Axis) != 0)
                        {
                            if (ddoi->guidType == GUID_Slider)
                                obj.Offset = DIJOFS_SLIDER(sliderCount);
                            else if (ddoi->guidType == GUID_XAxis)
                                obj.Offset = DIJOFS_X;
                            else if (ddoi->guidType == GUID_YAxis)
                                obj.Offset = DIJOFS_Y;
                            else if (ddoi->guidType == GUID_ZAxis)
                                obj.Offset = DIJOFS_Z;
                            else if (ddoi->guidType == GUID_RxAxis)
                                obj.Offset = DIJOFS_RX;
                            else if (ddoi->guidType == GUID_RyAxis)
                                obj.Offset = DIJOFS_RY;
                            else if (ddoi->guidType == GUID_RzAxis)
                                obj.Offset = DIJOFS_RZ;
                            else
                            {
                                return true;
                            }

                            DIPROPRANGE dipr = default;
                            dipr.diph.dwSize = (uint)Unsafe.SizeOf<DIPROPRANGE>();
                            dipr.diph.dwHeaderSize = (uint)Unsafe.SizeOf<DIPROPHEADER>();
                            dipr.diph.dwObj = (uint)ddoi->dwType;
                            dipr.diph.dwHow = DIPHHow.ByID;
                            dipr.lMin = -32768;
                            dipr.lMax = 32767;

                            device.SetProperty(DIPROP_RANGE, &dipr.diph);

                            // FIXME: Set deadzone?

                            // FIXME
                            if (ddoi->guidType == GUID_Slider)
                            {
                                obj.Type = JoyObjectType.Slider;
                                sliderCount++;
                            }
                            else
                            {
                                obj.Type = JoyObjectType.Axis;
                                axisCount++;
                            }
                        }
                        else if ((ddoi->dwType.GetType2() & DIDFT.Button) != 0)
                        {
                            obj.Offset = DIJOFS_BUTTON(buttonCount);
                            obj.Type = JoyObjectType.Button;
                            buttonCount++;
                        }
                        else if ((ddoi->dwType.GetType2() & DIDFT.Pov) != 0)
                        {
                            obj.Offset = DIJOFS_POV(povCount);
                            obj.Type = JoyObjectType.Pov;
                            povCount++;
                        }

                        objectCount++;

                        return true;
                    }, 0, DIDFT.Axis | DIDFT.Button | DIDFT.Pov);

                    // Sort objects to get consistent ordering
                    Array.Sort(objects, (o1, o2) =>
                    {
                        if (o1.Type != o2.Type)
                        {
                            return ((int)o1.Type).CompareTo((int)o2.Type);
                        }
                        else
                        {
                            return o1.Offset.CompareTo(o2.Offset);
                        }
                    });

                    QueryVidPid(device, out ushort vendorID, out ushort productID);
                    QueryProductString(device, out string productString);
                    ushort version = 0;

                    SdlGuid sdlGuid;
                    if (vendorID != 0 && productID != 0)
                    {
                        sdlGuid = SDL_CreateJoystickGUID((ushort)HardwareBusType.Usb, vendorID, productID, version, [], Encoding.UTF8.GetBytes(productString), 0, 0);
                    }
                    else
                    {
                        sdlGuid = SDL_CreateJoystickGUID((ushort)HardwareBusType.Bluetooth, vendorID, productID, version, [], Encoding.UTF8.GetBytes(productString), 0, 0);
                    }
                    
                    Logger?.LogDebug($"  SDL compatible guid: {sdlGuid:N}");

                    WinJoystick joystick = new WinJoystick(device, lpddi->guidInstance, instanceName, sdlGuid, objects);
                    joystick.Axes = new short[capabilities.dwAxes];
                    joystick.Buttons = new bool[capabilities.dwButtons];
                    joystick.Hats = new HatState[capabilities.dwPOVs];
                    _joysticks.Add(joystick);

                    int result = joystick.Device.Poll();
                    if (result == DIERR_INPUTLOST || result == DIERR_NOTACQUIRED)
                    {
                        joystick.Device.Acquire();
                        joystick.Device.Poll();
                    }
                    
                    return 1;
                }, IntPtr.Zero, DIEDFL.AttachedOnly);
            }
        }

        static void QueryVidPid(IDirectInputDevice8 device, out ushort vendorID, out ushort productID)
        {
            DIPROPDWORD dipdw = default;
            dipdw.diph.dwSize = (uint)Unsafe.SizeOf<DIPROPDWORD>();
            dipdw.diph.dwHeaderSize = (uint)Unsafe.SizeOf<DIPROPHEADER>();
            dipdw.diph.dwHow = DIPHHow.Device;
            dipdw.diph.dwObj = 0;
            dipdw.dwData = 0;

            device.GetProperty(DIPROP_VIDPID, &dipdw.diph);

            vendorID = (ushort)(dipdw.dwData >>  0);
            productID = (ushort)(dipdw.dwData >> 16);
        }

        static void QueryProductString(IDirectInputDevice8 device, out string productString)
        {
            DIPROPSTRING dipstr = default;
            dipstr.diph.dwSize = (uint)Unsafe.SizeOf<DIPROPSTRING>();
            dipstr.diph.dwHeaderSize = (uint)Unsafe.SizeOf<DIPROPHEADER>();
            dipstr.diph.dwHow = DIPHHow.Device;
            dipstr.diph.dwObj = 0;

            device.GetProperty(DIPROP_PRODUCTNAME, &dipstr.diph);

            ReadOnlySpan<char> str = new ReadOnlySpan<char>(dipstr.wsz, MAX_PATH);
            str = str.Slice(0, str.IndexOf('\0'));
            productString = str.ToString();
        }

        // This implementation is ported directly from SDL to generate Guids that are compatible with the gamecontroller database.
        // - Noggin_bops 2025-10-20
        static SdlGuid SDL_CreateJoystickGUID(ushort bus, ushort vendor, ushort product, ushort version, ReadOnlySpan<byte> vendor_name, ReadOnlySpan<byte> product_name, byte driver_signature, byte driver_data)
        {
            SdlGuid guid = default;
            //ushort* guid16 = (ushort*)&guid;
            Span<byte> guid16 = new Span<byte>(&guid, 16);
            ushort crc = 0;

            if (vendor_name.Length > 0 && product_name.Length > 0) {
                crc = Crc16(crc, vendor_name);
                crc = Crc16(crc, " "u8);
                crc = Crc16(crc, product_name);
            } else if (product_name.Length > 0) {
                crc = Crc16(crc, product_name);
            }

            // FIXME: Figure out the endian stuff that is going on here...
            // we want to easily match the 
            BinaryPrimitives.WriteUInt16LittleEndian(guid16, bus);
            guid16 = guid16.Slice(2);
            BinaryPrimitives.WriteUInt16LittleEndian(guid16, crc);
            guid16 = guid16.Slice(2);

            if (vendor != 0)
            {
                BinaryPrimitives.WriteUInt16LittleEndian(guid16, vendor);
                guid16 = guid16.Slice(2);
                guid16 = guid16.Slice(2);

                BinaryPrimitives.WriteUInt16LittleEndian(guid16, product);
                guid16 = guid16.Slice(2);
                guid16 = guid16.Slice(2);
                BinaryPrimitives.WriteUInt16LittleEndian(guid16, version);
                guid16 = guid16.Slice(2);
                guid16[0] = driver_signature;
                guid16[1] = driver_data;
            }
            else
            {
                if (driver_signature != 0)
                {
                    guid16[^2] = driver_signature;
                    guid16[^1] = driver_data;
                    guid16 = guid16.Slice(0, guid16.Length - 2);
                }
                if (product_name.Length > 0)
                {
                    product_name.Slice(0, guid16.Length).CopyTo(guid16);
                }
            }
            return guid;

            static ushort crc16_for_byte(byte r)
            {
                ushort crc = 0;
                int i;
                for (i = 0; i < 8; ++i)
                {
                    crc = (ushort)((((crc ^ r) & 1) != 0 ? 0xA001u : 0u) ^ (ushort)(crc >> 1));
                    r >>= 1;
                }
                return crc;
            }

            static ushort Crc16(ushort crc, ReadOnlySpan<byte> data)
            {
                // As an optimization we can precalculate a 256 entry table for each byte
                int i;
                for (i = 0; i < data.Length; ++i)
                {
                    crc = crc16_for_byte((byte)(crc ^ data[i] ^ crc >> 8));
                }
                return crc;
            }
        }

        /// <inheritdoc/>
        public void Uninitialize()
        {
            // FIXME: Unititialize all of the data.
        }

        internal void Update()
        {
            // FIXME: Only loop through the currently open joysticks?
            for (int joy = 0; joy < _joysticks.Count; joy++)
            {
                WinJoystick joystick = _joysticks[joy];

                int result = joystick.Device.Poll();
                if (result == DIERR_INPUTLOST || result == DIERR_NOTACQUIRED)
                {
                    joystick.Device.Acquire();
                    joystick.Device.Poll();
                }

                DIJOYSTATE state = default;
                result = joystick.Device.GetDeviceState((uint)sizeof(DIJOYSTATE), &state);
                if (result == DIERR_INPUTLOST || result == DIERR_NOTACQUIRED)
                {
                    joystick.Device.Acquire();
                    result = joystick.Device.GetDeviceState((uint)sizeof(DIJOYSTATE), &state);
                }

                int axisIdx = 0;
                int buttonIdx = 0;
                int hatIdx = 0;
                for (int i = 0; i < joystick.Objects.Length; i++)
                {
                    JoyObject obj = joystick.Objects[i];

                    byte* data = ((byte*)&state) + obj.Offset;

                    switch (obj.Type)
                    {
                        case JoyObjectType.Axis:
                        case JoyObjectType.Slider:
                            {
                                int value = *(int*)data;
                                joystick.Axes[axisIdx] = (short)value;
                                axisIdx++;
                                break;
                            }
                        case JoyObjectType.Button:
                            {
                                bool value = (*data & 0x80) != 0;
                                joystick.Buttons[buttonIdx] = value;
                                buttonIdx++;
                                break;
                            }
                        case JoyObjectType.Pov:
                            {
                                ushort value = *(ushort*)data;
                                joystick.Hats[hatIdx] = TranslatePOV(value);
                                hatIdx++;
                                break;

                                static HatState TranslatePOV(uint value)
                                {
                                    ReadOnlySpan<HatState> HatValues = [
                                        HatState.Up,
                                        HatState.RightUp,
                                        HatState.Right,
                                        HatState.RightDown,
                                        HatState.Down,
                                        HatState.LeftDown,
                                        HatState.Left,
                                        HatState.LeftUp,
                                    ];

                                    if (((ushort)value) == 0xFFFFu)
                                    {
                                        return HatState.Centered;
                                    }

                                    value += 4500 / 2;
                                    value %= 36000;
                                    value /= 4500;

                                    return HatValues[(int)value];
                                }
                            }
                    }
                }
            }
        }

        /// <inheritdoc/>
        public int GetJoystickCount()
        {
            return _joysticks.Count;
        }

        /// <inheritdoc/>
        public JoystickHandle Open(int index)
        {
            return _joysticks[index];
        }

        /// <inheritdoc/>
        public void Close(JoystickHandle joystick)
        {
            WinJoystick winjoystick = joystick.As<WinJoystick>(this);
            // FIXME: Deallocate resources...
        }

        /// <inheritdoc/>
        public Guid GetGuid(JoystickHandle joystick)
        {
            WinJoystick winjoystick = joystick.As<WinJoystick>(this);
            return winjoystick.SdlGuid.ToGuid();
        }

        /// <inheritdoc/>
        public string GetName(JoystickHandle joystick)
        {
            WinJoystick winjoystick = joystick.As<WinJoystick>(this);
            winjoystick.Device.GetDeviceInfo(out var info);
            return Utils.FromTszString(info.tszInstanceName, DirectInput.MAX_PATH);
        }

        /// <inheritdoc/>
        public bool TryGetBatteryInfo(JoystickHandle joystick, out GamepadBatteryInfo batteryInfo)
        {
            WinJoystick winjoystick = joystick.As<WinJoystick>(this);

            uint result = XInputGetBatteryInformation((uint)winjoystick.XInputIndex, DeviceType.Gamepad, out XINPUT_BATTERY_INFORMATION batteryInformation);
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
                    case BatteryLevel.Empty: charge = 0; break;
                    case BatteryLevel.Low: charge = 1 / 3.0f; break;
                    case BatteryLevel.Medium: charge = 2 / 3.0f; break;
                    case BatteryLevel.Full: charge = 1; break;
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

        /// <inheritdoc/>
        public JoystickCapabilities GetCapabilities(JoystickHandle joystick)
        {
            WinJoystick winjoystick = joystick.As<WinJoystick>(this);
            winjoystick.Device.GetCapabilities(out DIDEVCAPS joystickCaps);

            JoystickCapabilities capabilities = 0;
            if (joystickCaps.dwFlags.HasFlag(DIDC.ForceFeedback))
                capabilities |= JoystickCapabilities.Rumble;
            return capabilities;
        }

        /// <inheritdoc/>
        public int GetNumberOfAxes(JoystickHandle joystick)
        {
            WinJoystick winjoystick = joystick.As<WinJoystick>(this);
            winjoystick.Device.GetCapabilities(out DIDEVCAPS capabilities);
            return (int)capabilities.dwAxes;
        }

        /// <inheritdoc/>
        public float GetAxis(JoystickHandle joystick, int axis)
        {
            WinJoystick winjoystick = joystick.As<WinJoystick>(this);
            return (winjoystick.Axes[axis] + 0.5f) / 32767.5f;
        }

        /// <inheritdoc/>
        public int GetNumberOfButtons(JoystickHandle joystick)
        {
            WinJoystick winjoystick = joystick.As<WinJoystick>(this);
            winjoystick.Device.GetCapabilities(out DIDEVCAPS capabilities);
            return (int)capabilities.dwButtons;
        }

        /// <inheritdoc/>
        public bool GetButton(JoystickHandle joystick, int button)
        {
            WinJoystick winjoystick = joystick.As<WinJoystick>(this);
            return winjoystick.Buttons[button];
        }

        /// <inheritdoc/>
        public int GetNumberOfHats(JoystickHandle joystick)
        {
            WinJoystick winjoystick = joystick.As<WinJoystick>(this);
            winjoystick.Device.GetCapabilities(out DIDEVCAPS capabilities);
            return (int)capabilities.dwPOVs;
        }

        /// <inheritdoc/>
        public HatState GetHat(JoystickHandle joystick, int hat)
        {
            WinJoystick winjoystick = joystick.As<WinJoystick>(this);
            return winjoystick.Hats[hat];
        }

        /// <inheritdoc/>
        public unsafe bool SetRumble(JoystickHandle joystick, float lowFrequencyIntensity, float highFrequencyIntensity)
        {
            WinJoystick winjoystick = joystick.As<WinJoystick>(this);

            lowFrequencyIntensity = Math.Clamp(lowFrequencyIntensity, 0, 1);
            highFrequencyIntensity = Math.Clamp(highFrequencyIntensity, 0, 1);

            uint magnitude = (uint)float.Clamp((lowFrequencyIntensity + highFrequencyIntensity) * 0.5f * 10_000, 0, 10_000);

            winjoystick.Device.GetCapabilities(out DIDEVCAPS joystickCaps);
            if (joystickCaps.dwFlags.HasFlag(DIDC.ForceFeedback) == false)
                return false;

            // FIXME: Check that FF is supported.

            int result = winjoystick.Device.SendForceFeedbackCommand(DISFFC.Reset);
            if (result == DIERR_INPUTLOST || result == DIERR_NOTEXCLUSIVEACQUIRED)
            {
                winjoystick.Device.Acquire();
                result = winjoystick.Device.SendForceFeedbackCommand(DISFFC.Reset);
            }
            if (result < 0)
            {
                Logger?.LogError($"SendForceFeedbackCommand(Reset) failed with: {result}");
                return false;
            }

            result = winjoystick.Device.SendForceFeedbackCommand(DISFFC.SetActuatorsOn);
            if (result < 0)
            {
                Logger?.LogError($"SendForceFeedbackCommand(SetActuatorsOn) failed with: {result}");
                return false;
            }

            if (winjoystick.FFEffect == IDirectInputEffect.Null)
            {
                winjoystick.DIEffect = (DIEFFECT*)NativeMemory.AllocZeroed((uint)sizeof(DIEFFECT));
                winjoystick.DIPeriodic = (DIPERIODIC*)NativeMemory.AllocZeroed((uint)sizeof(DIPERIODIC));

                winjoystick.DIEffect->dwSize = (uint)sizeof(DIEFFECT);
                winjoystick.DIEffect->dwFlags = DIEFF.ObjectOffsets;
                winjoystick.DIEffect->dwDuration = 60 * 1000 * 1000; // 1 minute
                winjoystick.DIEffect->dwSamplePeriod = 0;
                winjoystick.DIEffect->dwGain = 10000;
                winjoystick.DIEffect->dwTriggerButton = (uint)DIEB.NoTrigger;
                winjoystick.DIEffect->cAxes = 2;
                winjoystick.DIEffect->rgdwAxes = (uint*)NativeMemory.AllocZeroed(2, sizeof(uint));
                winjoystick.DIEffect->dwFlags |= DIEFF.Cartesian;
                winjoystick.DIEffect->rglDirection = (int*)NativeMemory.AllocZeroed(2, sizeof(int));

                winjoystick.DIPeriodic->dwMagnitude = magnitude;
                winjoystick.DIPeriodic->lOffset = 0;
                winjoystick.DIPeriodic->dwPhase = 0;
                winjoystick.DIPeriodic->dwPeriod = 1_000_000; // 1 second

                winjoystick.DIEffect->cbTypeSpecificParams = (uint)sizeof(DIPERIODIC);
                winjoystick.DIEffect->lpvTypeSpecificParams = winjoystick.DIPeriodic;

                result = winjoystick.Device.CreateEffect(ref Unsafe.AsRef(in GUID_Sine), winjoystick.DIEffect, out IDirectInputEffect diEffect, IUnknown.Null);
                if (result < 0)
                {
                    Logger?.LogError($"CreateEffect failed with: {result}");
                    return false;
                }
                winjoystick.FFEffect = diEffect;
            }
            else
            {
                winjoystick.DIPeriodic->dwMagnitude = magnitude;

                result = winjoystick.FFEffect.SetParameters(winjoystick.DIEffect, DIEP.Duration | DIEP.TypeSpecificParams);
                if (result == DIERR_INPUTLOST)
                {
                    winjoystick.Device.Acquire();
                    result = winjoystick.FFEffect.SetParameters(winjoystick.DIEffect, DIEP.Duration | DIEP.TypeSpecificParams);
                }
                if (result < 0)
                {
                    Logger?.LogError($"IDirectInputEffect.SetParameters failed with: {result}");
                    return false;
                }
            }

            result = winjoystick.FFEffect.Start(1, 0);
            if (result == DIERR_INPUTLOST || result == DIERR_NOTACQUIRED)
            {
                winjoystick.Device.Acquire();
                result = winjoystick.FFEffect.Start(1, 0);
            }
            if (result < 0)
            {
                Logger?.LogError($"IDirectInputEffect.Start failed with: {result}");
                return false;
            }

            return true;
        }
    }
}
