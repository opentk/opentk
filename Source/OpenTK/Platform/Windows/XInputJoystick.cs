#region License
//
// XInputJoystick.cs
//
// Author:
//       Stefanos A. <stapostol@gmail.com>
//
// Copyright (c) 2006-2013 Stefanos Apostolopoulos
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using OpenTK.Input;
using System.Runtime.InteropServices;
using System.Security;

namespace OpenTK.Platform.Windows
{
    class XInputJoystick : IGamePadDriver
    {
        #region IGamePadDriver Members

        public GamePadState GetState(int index)
        {
            XInputState xstate;
            XInput910.GetState((XInputUserIndex)index, out xstate);

            GamePadState state = new GamePadState();
            state.SetButton(Buttons.A, (xstate.GamePad.Buttons & XInputButtons.A) != 0);
            state.SetButton(Buttons.B, (xstate.GamePad.Buttons & XInputButtons.B) != 0);
            state.SetButton(Buttons.X, (xstate.GamePad.Buttons & XInputButtons.X) != 0);
            state.SetButton(Buttons.Y, (xstate.GamePad.Buttons & XInputButtons.Y) != 0);
            state.SetButton(Buttons.Start, (xstate.GamePad.Buttons & XInputButtons.Start) != 0);
            state.SetButton(Buttons.Back, (xstate.GamePad.Buttons & XInputButtons.Back) != 0);
            //state.SetButton(Buttons.BigButton, (xstate.GamePad.Buttons & XInputButtons.???) != 0);
            state.SetButton(Buttons.LeftShoulder, (xstate.GamePad.Buttons & XInputButtons.LeftShoulder) != 0);
            state.SetButton(Buttons.RightShoulder, (xstate.GamePad.Buttons & XInputButtons.RightShoulder) != 0);
            state.SetButton(Buttons.LeftStick, (xstate.GamePad.Buttons & XInputButtons.LeftThumb) != 0);
            state.SetButton(Buttons.RightStick, (xstate.GamePad.Buttons & XInputButtons.RightThumb) != 0);
            state.SetButton(Buttons.DPadDown, (xstate.GamePad.Buttons & XInputButtons.DPadDown) != 0);
            state.SetButton(Buttons.DPadUp, (xstate.GamePad.Buttons & XInputButtons.DPadUp) != 0);
            state.SetButton(Buttons.DPadLeft, (xstate.GamePad.Buttons & XInputButtons.DPadLeft) != 0);
            state.SetButton(Buttons.DPadRight, (xstate.GamePad.Buttons & XInputButtons.DPadRight) != 0);

            return state;
        }

        public GamePadCapabilities GetCapabilities(int index)
        {
            throw new NotImplementedException();
        }

        public string GetName(int index)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Private Members

        enum XInputErrorCode
        {
            Success = 0,
            DeviceNotConnected
        }

        enum XInputType
        {
            GamePad
        }

        enum XInputSubType
        {
            Unknown = 0,
            GamePad = 1,
            Wheel = 2,
            ArcadeStick = 3,
            FlightStick = 4,
            DancePad = 5,
            Guitar = 6,
            GuitarAlternate = 7,
            DrumKit = 8,
            GuitarBass = 0xb,
            ArcadePad = 0x13
        }

        enum XInputCapabilities
        {
            Ffb = 0x0001,
            Wireless = 0x0002,
            Voice = 0x0004,
            Pmd = 0x0008,
            NoNavigation = 0x0010,
        }

        enum XInputButtons : ushort
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
            Y = 0x8000
        }

        [Flags]
        enum XInputCapabilitiesFlags
        {
            Default = 0,
            GamePadOnly = 1
        }

        enum XInputBatteryType : byte
        {
            Disconnected = 0x00,
            Wired = 0x01,
            Alkaline = 0x02,
            NiMH = 0x03,
            Unknown = 0xff
        }

        enum XInputBatteryLevel : byte
        {
            Empty = 0x00,
            Low = 0x01,
            Medium = 0x02,
            Full = 0x03
        }

        enum XInputUserIndex
        {
            First = 0,
            Second,
            Third,
            Fourth,
            Any = 0xff
        }

        struct XInputThresholds
        {
            public const int LeftThumbDeadzone = 7849;
            public const int RightThumbDeadzone = 8689;
            public const int TriggerThreshold = 30;
        }

        struct XInputGamePad
        {
            public XInputButtons Buttons;
            public byte LeftTrigger;
            public byte RightTrigger;
            public short ThumbLX;
            public short ThumbLY;
            public short ThumbRX;
            public short ThumbRY;
        }

        struct XInputState
        {
            public int PacketNumber;
            public XInputGamePad GamePad;
        }

        struct XInputVibration
        {
            public short LeftMotorSpeed;
            public short RightMotorSpeed;
        }

        struct XInputDeviceCapabilities
        {
            public byte Type;
            public byte SubType;
            public short Flags;
            public XInputGamePad GamePad;
            public XInputVibration Vibration;
        }

        struct XInputBatteryInformation
        {
            public XInputBatteryType Type;
            public XInputBatteryLevel Level;
        }

        static class XInput910
        {
            const string dll = "XINPUT9_1_0";

            [SuppressUnmanagedCodeSecurity]
            [DllImport(dll, EntryPoint = "XInputGetCapabilities", ExactSpelling = true, SetLastError = false)]
            public static extern XInputErrorCode GetCapabilities(
                XInputUserIndex dwUserIndex,
                XInputCapabilitiesFlags dwFlags,
                ref XInputDeviceCapabilities pCapabilities);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(dll, EntryPoint = "XInputGetState", ExactSpelling = true, SetLastError = false)]
            public static extern XInputErrorCode GetState
            (
                XInputUserIndex dwUserIndex,
                out XInputState pState
            );

            [SuppressUnmanagedCodeSecurity]
            [DllImport(dll, EntryPoint = "XInputSetState", ExactSpelling = true, SetLastError = false)]
            public static extern XInputErrorCode SetState
            (
                XInputUserIndex dwUserIndex,
                ref XInputVibration pVibration
            );
        }

        static class XInput13
        {
            const string dll = "XINPUT1_3";

            [SuppressUnmanagedCodeSecurity]
            [DllImport(dll, EntryPoint = "XInputGetCapabilities", ExactSpelling = true, SetLastError = false)]
            public static extern XInputErrorCode GetCapabilities(
                XInputUserIndex dwUserIndex,
                XInputCapabilitiesFlags dwFlags,
                ref XInputDeviceCapabilities pCapabilities);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(dll, EntryPoint = "XInputGetState", ExactSpelling = true, SetLastError = false)]
            public static extern XInputErrorCode GetState
            (
                XInputUserIndex dwUserIndex,
                out XInputState pState
            );

            [SuppressUnmanagedCodeSecurity]
            [DllImport(dll, EntryPoint = "XInputSetState", ExactSpelling = true, SetLastError = false)]
            public static extern XInputErrorCode SetState
            (
                XInputUserIndex dwUserIndex,
                ref XInputVibration pVibration
            );
        }

        static class XInput14
        {
            const string dll = "XINPUT1_4";

            [SuppressUnmanagedCodeSecurity]
            [DllImport(dll, EntryPoint = "XInputGetCapabilities", ExactSpelling = true, SetLastError = false)]
            public static extern XInputErrorCode GetCapabilities(
                XInputUserIndex dwUserIndex,
                XInputCapabilitiesFlags dwFlags,
                ref XInputDeviceCapabilities pCapabilities);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(dll, EntryPoint = "XInputGetState", ExactSpelling = true, SetLastError = false)]
            public static extern XInputErrorCode GetState
            (
                XInputUserIndex dwUserIndex,
                out XInputState pState
            );

            [SuppressUnmanagedCodeSecurity]
            [DllImport(dll, EntryPoint = "XInputSetState", ExactSpelling = true, SetLastError = false)]
            public static extern XInputErrorCode SetState
            (
                XInputUserIndex dwUserIndex,
                ref XInputVibration pVibration
            );
        }

        #endregion
    }
}
