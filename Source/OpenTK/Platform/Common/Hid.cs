#region License
//
// Hid.cs
//
// Author:
//       Stefanos A. <stapostol@gmail.com>
//
// Copyright (c) 2014 Stefanos Apostolopoulos
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
using System.Diagnostics;
using System.Text;
using OpenTK.Input;

namespace OpenTK.Platform.Common
{
    class HidHelper
    {
        /// <summary>
        /// Scales the specified value linearly between min and max.
        /// </summary>
        /// <param name="value">The value to scale</param>
        /// <param name="value_min">The minimum expected value (inclusive)</param>
        /// <param name="value_max">The maximum expected value (inclusive)</param>
        /// <param name="result_min">The minimum output value (inclusive)</param>
        /// <param name="result_max">The maximum output value (inclusive)</param>
        /// <returns>The value, scaled linearly between min and max</returns>
        public static int ScaleValue(int value, int value_min, int value_max,
            int result_min, int result_max)
        {
            if (value_min >= value_max || result_min >= result_max)
                throw new ArgumentOutOfRangeException();
            MathHelper.Clamp(value, value_min, value_max);
            
            int range = result_max - result_min;
            long temp = (value - value_min) * range; // need long to avoid overflow
            return (int)(temp / (value_max - value_min) + result_min);
        }

        public static JoystickAxis TranslateJoystickAxis(HIDPage page, int usage)
        {
            switch (page)
            {
                case HIDPage.GenericDesktop:
                    switch ((HIDUsageGD)usage)
                    {
                        case HIDUsageGD.X:
                            return JoystickAxis.Axis0;
                        case HIDUsageGD.Y:
                            return JoystickAxis.Axis1;

                        case HIDUsageGD.Z:
                            return JoystickAxis.Axis2;
                        case HIDUsageGD.Rz:
                            return JoystickAxis.Axis3;

                        case HIDUsageGD.Rx:
                            return JoystickAxis.Axis4;
                        case HIDUsageGD.Ry:
                            return JoystickAxis.Axis5;

                        case HIDUsageGD.Slider:
                            return JoystickAxis.Axis6;
                        case HIDUsageGD.Dial:
                            return JoystickAxis.Axis7;
                        case HIDUsageGD.Wheel:
                            return JoystickAxis.Axis8;
                    }
                    break;

                case HIDPage.Simulation:
                    switch ((HIDUsageSim)usage)
                    {
                        case HIDUsageSim.Rudder:
                            return JoystickAxis.Axis9;
                        case HIDUsageSim.Throttle:
                            return JoystickAxis.Axis10;
                    }
                    break;
            }

            Debug.Print("[Input] Unknown axis with HID page/usage {0}/{1}", page, usage);
            return 0;
        }
    }

    enum HIDPage : ushort
    {
        Undefined = 0x00,
        GenericDesktop = 0x01,
        Simulation = 0x02,
        VR = 0x03,
        Sport = 0x04,
        Game = 0x05,
        // Reserved 0x06 
        KeyboardOrKeypad = 0x07, // USB Device Class Definition for Human Interface Devices (HID). Note: the usage type for all key codes is Selector (Sel). 
        LEDs = 0x08,
        Button = 0x09,
        Ordinal = 0x0A,
        Telephony = 0x0B,
        Consumer = 0x0C,
        Digitizer = 0x0D,
        // Reserved 0x0E 
        PID = 0x0F, // USB Physical Interface Device definitions for force feedback and related devices. 
        Unicode = 0x10,
        // Reserved 0x11 - 0x13 
        AlphanumericDisplay = 0x14,
        // Reserved 0x15 - 0x7F 
        // Monitor 0x80 - 0x83   USB Device Class Definition for Monitor Devices 
        // Power 0x84 - 0x87     USB Device Class Definition for Power Devices 
        PowerDevice = 0x84,                // Power Device Page 
        BatterySystem = 0x85,              // Battery System Page 
        // Reserved 0x88 - 0x8B 
        BarCodeScanner = 0x8C, // (Point of Sale) USB Device Class Definition for Bar Code Scanner Devices 
        WeighingDevice = 0x8D, // (Point of Sale) USB Device Class Definition for Weighing Devices 
        Scale = 0x8D, // (Point of Sale) USB Device Class Definition for Scale Devices 
        MagneticStripeReader = 0x8E,
        // ReservedPointofSalepages 0x8F 
        CameraControl = 0x90, // USB Device Class Definition for Image Class Devices 
        Arcade = 0x91, // OAAF Definitions for arcade and coinop related Devices 
        // Reserved 0x92 - 0xFEFF 
        // VendorDefined 0xFF00 - 0xFFFF 
        VendorDefinedStart = 0xFF00
    }

    // Consumer electronic devices
    enum HIDUsageCD
    {
        ACPan = 0x0238
    }

    // Generic desktop usage
    enum HIDUsageGD : ushort
    {
        Pointer = 0x01, // Physical Collection 
        Mouse = 0x02, // Application Collection 
        // 0x03 Reserved 
        Joystick = 0x04, // Application Collection 
        GamePad = 0x05, // Application Collection 
        Keyboard = 0x06, // Application Collection 
        Keypad = 0x07, // Application Collection 
        MultiAxisController = 0x08, // Application Collection 
        // 0x09 - 0x2F Reserved 
        X = 0x30, // Dynamic Value 
        Y = 0x31, // Dynamic Value 
        Z = 0x32, // Dynamic Value 
        Rx = 0x33, // Dynamic Value 
        Ry = 0x34, // Dynamic Value 
        Rz = 0x35, // Dynamic Value 
        Slider = 0x36, // Dynamic Value 
        Dial = 0x37, // Dynamic Value 
        Wheel = 0x38, // Dynamic Value 
        Hatswitch = 0x39, // Dynamic Value 
        CountedBuffer = 0x3A, // Logical Collection 
        ByteCount = 0x3B, // Dynamic Value 
        MotionWakeup = 0x3C, // One-Shot Control 
        Start = 0x3D, // On/Off Control 
        Select = 0x3E, // On/Off Control 
        // 0x3F Reserved 
        Vx = 0x40, // Dynamic Value 
        Vy = 0x41, // Dynamic Value 
        Vz = 0x42, // Dynamic Value 
        Vbrx = 0x43, // Dynamic Value 
        Vbry = 0x44, // Dynamic Value 
        Vbrz = 0x45, // Dynamic Value 
        Vno = 0x46, // Dynamic Value 
        // 0x47 - 0x7F Reserved 
        SystemControl = 0x80, // Application Collection 
        SystemPowerDown = 0x81, // One-Shot Control 
        SystemSleep = 0x82, // One-Shot Control 
        SystemWakeUp = 0x83, // One-Shot Control 
        SystemContextMenu = 0x84, // One-Shot Control 
        SystemMainMenu = 0x85, // One-Shot Control 
        SystemAppMenu = 0x86, // One-Shot Control 
        SystemMenuHelp = 0x87, // One-Shot Control 
        SystemMenuExit = 0x88, // One-Shot Control 
        SystemMenu = 0x89, // Selector 
        SystemMenuRight = 0x8A, // Re-Trigger Control 
        SystemMenuLeft = 0x8B, // Re-Trigger Control 
        SystemMenuUp = 0x8C, // Re-Trigger Control 
        SystemMenuDown = 0x8D, // Re-Trigger Control 
        // 0x8E - 0x8F Reserved 
        DPadUp = 0x90, // On/Off Control 
        DPadDown = 0x91, // On/Off Control 
        DPadRight = 0x92, // On/Off Control 
        DPadLeft = 0x93, // On/Off Control 
        // 0x94 - 0xFFFF Reserved 
        Reserved = 0xFFFF
    }

    enum HIDUsageSim : ushort
    {
        FlightSimulationDevice = 0x01, // Application Collection 
        AutomobileSimulationDevice = 0x02, //             Application Collection 
        TankSimulationDevice = 0x03, //             Application Collection 
        SpaceshipSimulationDevice = 0x04, //             Application Collection 
        SubmarineSimulationDevice = 0x05, //             Application Collection 
        SailingSimulationDevice = 0x06, //             Application Collection 
        MotorcycleSimulationDevice = 0x07, //             Application Collection 
        SportsSimulationDevice = 0x08, //             Application Collection 
        AirplaneSimulationDevice = 0x09, //             Application Collection 
        HelicopterSimulationDevice = 0x0A, //             Application Collection 
        MagicCarpetSimulationDevice = 0x0B, //             Application Collection 
        BicycleSimulationDevice = 0x0C, //             Application Collection 
        // 0x0D - 0x1F Reserved 
        FlightControlStick = 0x20, //             Application Collection 
        FlightStick = 0x21, //             Application Collection 
        CyclicControl = 0x22, //             Physical Collection 
        CyclicTrim = 0x23, //             Physical Collection 
        FlightYoke = 0x24, //             Application Collection 
        TrackControl = 0x25, //             Physical Collection 
        // 0x26 - 0xAF Reserved 
        Aileron = 0xB0, //             Dynamic Value 
        AileronTrim = 0xB1, //             Dynamic Value 
        AntiTorqueControl = 0xB2, //             Dynamic Value 
        AutopilotEnable = 0xB3, //             On/Off Control 
        ChaffRelease = 0xB4, //             One-Shot Control 
        CollectiveControl = 0xB5, //             Dynamic Value 
        DiveBrake = 0xB6, //             Dynamic Value 
        ElectronicCountermeasures = 0xB7, //             On/Off Control 
        Elevator = 0xB8, //             Dynamic Value 
        ElevatorTrim = 0xB9, //             Dynamic Value 
        Rudder = 0xBA, //             Dynamic Value 
        Throttle = 0xBB, //             Dynamic Value 
        FlightCommunications = 0xBC, //             On/Off Control 
        FlareRelease = 0xBD, //             One-Shot Control 
        LandingGear = 0xBE, //             On/Off Control 
        ToeBrake = 0xBF, //             Dynamic Value 
        Trigger = 0xC0, //             Momentary Control 
        WeaponsArm = 0xC1, //             On/Off Control 
        Weapons = 0xC2, //             Selector 
        WingFlaps = 0xC3, //             Dynamic Value 
        Accelerator = 0xC4, //             Dynamic Value 
        Brake = 0xC5, //             Dynamic Value 
        Clutch = 0xC6, //             Dynamic Value 
        Shifter = 0xC7, //             Dynamic Value 
        Steering = 0xC8, //             Dynamic Value 
        TurretDirection = 0xC9, //             Dynamic Value 
        BarrelElevation = 0xCA, //             Dynamic Value 
        DivePlane = 0xCB, //             Dynamic Value 
        Ballast = 0xCC, //             Dynamic Value 
        BicycleCrank = 0xCD, //             Dynamic Value 
        HandleBars = 0xCE, //             Dynamic Value 
        FrontBrake = 0xCF, //             Dynamic Value 
        RearBrake = 0xD0, //             Dynamic Value 
        // 0xD1 - 0xFFFF Reserved 
        Reserved = 0xFFFF
    }
}
