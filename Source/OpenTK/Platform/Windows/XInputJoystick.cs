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
using System.Diagnostics;

namespace OpenTK.Platform.Windows
{
    class XInputJoystick : IGamePadDriver, IDisposable
    {
        XInput xinput = new XInput();

        #region IGamePadDriver Members

        public GamePadState GetState(int index)
        {
            XInputState xstate;
            XInputErrorCode error = xinput.GetState((XInputUserIndex)index, out xstate);

            GamePadState state = new GamePadState();
            if (error == XInputErrorCode.Success)
            {
                state.SetConnected(true);

                state.SetAxis(GamePadAxes.LeftX, xstate.GamePad.ThumbLX);
                state.SetAxis(GamePadAxes.LeftY, xstate.GamePad.ThumbLY);
                state.SetAxis(GamePadAxes.RightX, xstate.GamePad.ThumbRX);
                state.SetAxis(GamePadAxes.RightY, xstate.GamePad.ThumbRY);

                state.SetTriggers(xstate.GamePad.LeftTrigger, xstate.GamePad.RightTrigger);

                state.SetButton(TranslateButtons(xstate.GamePad.Buttons), true);
            }

            return state;
        }

        public GamePadCapabilities GetCapabilities(int index)
        {
            XInputDeviceCapabilities xcaps;
            XInputErrorCode error = xinput.GetCapabilities(
                (XInputUserIndex)index,
                XInputCapabilitiesFlags.Default,
                out xcaps);

            if (error == XInputErrorCode.Success)
            {
                GamePadType type = TranslateSubType(xcaps.SubType);
                Buttons buttons = TranslateButtons(xcaps.GamePad.Buttons);
                GamePadAxes axes = TranslateAxes(ref xcaps.GamePad);

                return new GamePadCapabilities(type, axes, buttons, true);
            }
            return new GamePadCapabilities();
        }

        public string GetName(int index)
        {
            return String.Empty;
        }

        public bool SetVibration(int index, float left, float right)
        {
            return false;
        }

        #endregion

        #region Private Members
        GamePadAxes TranslateAxes(ref XInputGamePad pad)
        {
            GamePadAxes axes = 0;
            axes |= pad.ThumbLX != 0 ? GamePadAxes.LeftX : 0;
            axes |= pad.ThumbLY != 0 ? GamePadAxes.LeftY : 0;
            axes |= pad.LeftTrigger != 0 ? GamePadAxes.LeftTrigger : 0;
            axes |= pad.ThumbRX != 0 ? GamePadAxes.RightX : 0;
            axes |= pad.ThumbRY != 0 ? GamePadAxes.RightY : 0;
            axes |= pad.RightTrigger != 0 ? GamePadAxes.RightTrigger : 0;
            return axes;
        }

        Buttons TranslateButtons(XInputButtons xbuttons)
        {
            Buttons buttons = 0;
            buttons |= (xbuttons & XInputButtons.A) != 0 ? Buttons.A : 0;
            buttons |= (xbuttons & XInputButtons.B) != 0 ? Buttons.B : 0;
            buttons |= (xbuttons & XInputButtons.X) != 0 ? Buttons.X : 0;
            buttons |= (xbuttons & XInputButtons.Y) != 0 ? Buttons.Y : 0;
            buttons |= (xbuttons & XInputButtons.Start) != 0 ? Buttons.Start : 0;
            buttons |= (xbuttons & XInputButtons.Back) != 0 ? Buttons.Back : 0;
            //buttons |= (xbuttons & XInputButtons.BigButton) != 0 ? Buttons.BigButton : 0;
            buttons |= (xbuttons & XInputButtons.LeftShoulder) != 0 ? Buttons.LeftShoulder : 0;
            buttons |= (xbuttons & XInputButtons.RightShoulder) != 0 ? Buttons.RightShoulder : 0;
            buttons |= (xbuttons & XInputButtons.LeftThumb) != 0 ? Buttons.LeftStick : 0;
            buttons |= (xbuttons & XInputButtons.RightThumb) != 0 ? Buttons.RightStick : 0;
            buttons |= (xbuttons & XInputButtons.DPadDown) != 0 ? Buttons.DPadDown : 0;
            buttons |= (xbuttons & XInputButtons.DPadUp) != 0 ? Buttons.DPadUp : 0;
            buttons |= (xbuttons & XInputButtons.DPadLeft) != 0 ? Buttons.DPadLeft : 0;
            buttons |= (xbuttons & XInputButtons.DPadRight) != 0 ? Buttons.DPadRight : 0;
            return buttons;
        }

        GamePadType TranslateSubType(XInputDeviceSubType xtype)
        {
            switch (xtype)
            {
                case XInputDeviceSubType.ArcadePad: return GamePadType.ArcadePad;
                case XInputDeviceSubType.ArcadeStick: return GamePadType.ArcadeStick;
                case XInputDeviceSubType.DancePad: return GamePadType.DancePad;
                case XInputDeviceSubType.DrumKit: return GamePadType.DrumKit;
                case XInputDeviceSubType.FlightStick: return GamePadType.FlightStick;
                case XInputDeviceSubType.GamePad: return GamePadType.GamePad;
                case XInputDeviceSubType.Guitar: return GamePadType.Guitar;
                case XInputDeviceSubType.GuitarAlternate: return GamePadType.AlternateGuitar;
                case XInputDeviceSubType.GuitarBass: return GamePadType.BassGuitar;
                case XInputDeviceSubType.Wheel: return GamePadType.Wheel;
                case XInputDeviceSubType.Unknown:
                default:
                    return GamePadType.Unknown;
            }
        }

        enum XInputErrorCode
        {
            Success = 0,
            DeviceNotConnected
        }

        enum XInputDeviceType : byte
        {
            GamePad
        }

        enum XInputDeviceSubType : byte
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
            ForceFeedback = 0x0001,
            Wireless = 0x0002,
            Voice = 0x0004,
            PluginModules = 0x0008,
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

#pragma warning disable 0649 // field is never assigned

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
            public XInputDeviceType Type;
            public XInputDeviceSubType SubType;
            public short Flags;
            public XInputGamePad GamePad;
            public XInputVibration Vibration;
        }

        struct XInputBatteryInformation
        {
            public XInputBatteryType Type;
            public XInputBatteryLevel Level;
        }

        class XInput : IDisposable
        {
            IntPtr dll;

            internal XInput()
            {
                // Try to load the newest XInput***.dll installed on the system
                // The delegates below will be loaded dynamically from that dll
                dll = Functions.LoadLibrary("XINPUT1_4");
                if (dll == IntPtr.Zero)
                    dll = Functions.LoadLibrary("XINPUT1_3");
                if (dll == IntPtr.Zero)
                    dll = Functions.LoadLibrary("XINPUT1_2");
                if (dll == IntPtr.Zero)
                    dll = Functions.LoadLibrary("XINPUT1_1");
                if (dll == IntPtr.Zero)
                    dll = Functions.LoadLibrary("XINPUT9_1_0");
                if (dll == IntPtr.Zero)
                    throw new NotSupportedException("XInput was not found on this platform");

                // Load the entry points we are interested in from that dll
                GetCapabilities = (XInputGetCapabilities)Load("XInputGetCapabilities", typeof(XInputGetCapabilities));
                GetState = (XInputGetState)Load("XInputGetState", typeof(XInputGetState));
                SetState = (XInputSetState)Load("XInputSetState", typeof(XInputSetState));
            }

            #region Private Members

            Delegate Load(string name, Type type)
            {
                IntPtr pfunc = Functions.GetProcAddress(dll, name);
                if (pfunc != IntPtr.Zero)
                    return Marshal.GetDelegateForFunctionPointer(pfunc, type);
                return null;
            }

            #endregion

            #region Internal Members

            internal XInputGetCapabilities GetCapabilities;
            internal XInputGetState GetState;
            internal XInputSetState SetState;

            [SuppressUnmanagedCodeSecurity]
            internal delegate XInputErrorCode XInputGetCapabilities(
                XInputUserIndex dwUserIndex,
                XInputCapabilitiesFlags dwFlags,
                out XInputDeviceCapabilities pCapabilities);

            [SuppressUnmanagedCodeSecurity]
            internal delegate XInputErrorCode XInputGetState
            (
                XInputUserIndex dwUserIndex,
                out XInputState pState
            );

            [SuppressUnmanagedCodeSecurity]
            internal delegate XInputErrorCode XInputSetState
            (
                XInputUserIndex dwUserIndex,
                ref XInputVibration pVibration
            );

            #endregion

            #region IDisposable Members

            public void Dispose()
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }

            void Dispose(bool manual)
            {
                if (manual)
                {
                    if (dll != IntPtr.Zero)
                    {
                        Functions.FreeLibrary(dll);
                        dll = IntPtr.Zero;
                    }
                }
            }

            #endregion
        }

        #endregion

        #region IDisposable Members

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        void Dispose(bool manual)
        {
            if (manual)
            {
                xinput.Dispose();
            }
            else
            {
                Debug.Print("{0} leaked, did you forget to call Dispose()?", typeof(XInputJoystick).Name);
            }
        }

#if DEBUG
        ~XInputJoystick()
        {
            Dispose(false);
        }
#endif

        #endregion
    }
}
