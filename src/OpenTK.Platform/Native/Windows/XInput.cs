using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace OpenTK.Platform.Native.Windows
{
    
    internal static unsafe class XInput
    {
        internal const int ERROR_SUCCESS = 0;

        internal enum DeviceType : byte
        {
            Gamepad = 0x00,
            Headset = 0x01,
        }

        internal enum DeviceSubType : byte
        {
            Gamepad = 0x01,
            Unknown = 0x00,
            Wheel = 0x02,
            ArcadeStick = 0x03,
            FlightStick = 0x04,
            DancePad = 0x05,
            Guitar = 0x06,
            GuitarAlternate = 0x07,
            DrumKit = 0x08,
            GuitarBass = 0x0B,
            ArcadePad = 0x13,
        }

        [Flags]
        internal enum Caps : ushort
        {
            VoiceSupported = 0x0004,
            FFBSupported = 0x0001,
            Wireless = 0x0002,
            PMDSupported = 0x0008,
            NoNaviagtion = 0x0010,
        }

        [Flags]
        internal enum XInputGamepadButton : ushort
        {
            DPadUp = 0x0001,
            DPadDown = 0x0002,
            DPadLeft = 0x0004,
            DPadRight = 0x0008,
            Start = 0x0010,
            Back = 0x0020,
            LeftThumb = 0x0040,
            RightThumb = 0x0080,
            LeftShoulder = 0x0100,
            RightShoulder = 0x0200,
            A = 0x1000,
            B = 0x2000,
            X = 0x4000,
            Y = 0x8000,
        }

        internal enum BatteryType : byte
        {
            Disconnected = 0x00,
            Wired = 0x01,
            Alkaline = 0x02,
            NiMH = 0x03,
            Unknown = 0xFF,
        }

        internal enum BatteryLevel : byte
        {
            Empty = 0x00,
            Low = 0x01,
            Medium= 0x02,
            Full = 0x03,
        }

        [Flags]
        internal enum KeystrokeFlags : ushort
        {
            KeyDown = 0x0001,
            KeyUp = 0x0002,
            Repeat = 0x0004,
        }

#pragma warning disable CS0649 // Field '' is never assigned to, and will always have its default value 0
        public struct XINPUT_STATE
        {
            public uint dwPacketNumber;
            public XINPUT_GAMEPAD Gamepad;
        }

        public struct XINPUT_GAMEPAD
        {
            public XInputGamepadButton wButtons;
            public byte bLeftTrigger;
            public byte bRightTrigger;
            public short sThumbLX;
            public short sThumbLY;
            public short sThumbRX;
            public short sThumbRY;
        }

        public struct XINPUT_VIBRATION
        {
            public ushort wLeftMotorSpeed;
            public ushort wRightMotorSpeed;
        }

        public struct XINPUT_CAPABILITIES
        {
            public DeviceType Type;
            public DeviceSubType SubType;
            public Caps Flags;
            public XINPUT_GAMEPAD Gamepad;
            public XINPUT_VIBRATION Vibration;
        }

        public struct XINPUT_BATTERY_INFORMATION
        {
            public BatteryType BatteryType;
            public BatteryLevel BatteryLevel;
        }

        public struct XINPUT_KEYSTROKE
        {
            // FIXME: There are a few XInput specific VKs that we probably don't have in the enum!
            public VK VirtualKey;
            public ushort Unicode;
            public KeystrokeFlags Flags;
            public byte UserIndex;
            public byte HidCode;
        }
#pragma warning restore CS0649 // Field '' is never assigned to, and will always have its default value 0

        // FIXME: Import xinput 1.3 or ximport 1.4 whatever is available.

        [DllImport("xinput1_4")]
        public static extern uint XInputGetState(uint dwUserIndex, out XINPUT_STATE pState);

        [DllImport("xinput1_4")]
        public static extern uint XInputSetState(uint dwUserIndex, in XINPUT_VIBRATION pVibration);

        [DllImport("xinput1_4")]
        public static extern uint XInputGetCapabilities(uint dwUserIndex,  uint dwFlags, out XINPUT_CAPABILITIES pCapabilities);

        [DllImport("xinput1_4")]
        public static extern void XInputEnable(int enable);

        [DllImport("xinput1_4")]
        public static extern uint XInputGetAudioDeviceIds( uint dwUserIndex, ushort* pRenderDeviceId, uint* pRenderCount, ushort* pCaptureDeviceId, uint* pCaptureCount);

        [DllImport("xinput1_4")]
        public static extern uint XInputGetBatteryInformation(uint dwUserIndex, DeviceType devType, out XINPUT_BATTERY_INFORMATION pBatteryInformation);

        [DllImport("xinput1_4")]
        public static extern uint XInputGetKeystroke(uint dwUserIndex, uint dwReserved, XINPUT_KEYSTROKE* pKeystroke);
    }
}
