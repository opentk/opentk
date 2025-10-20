using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Platform
{
    [Flags]
    public enum HatState : byte
    {
        Centered = 0,
        Left = 0b0001,
        Right = 0b0010,
        Up = 0b0100,
        Down = 0b1000,
        LeftUp = Left | Up,
        LeftDown = Left | Down,
        RightUp = Right | Up,
        RightDown = Right | Down,
    }

    public enum JoystickType
    {
        Unknown,
        Gamepad,
        Wheel,
        ArcadeStick,
        FlightStick,
        DancePad,
        Guitar,
        DrumKit,
        ArcadePad,
        Throttle,
    }

    public enum JoystickCapabilities
    {
        Rumble,
    }

    /// <summary>
    /// Interface for interacting with joysticks.
    /// </summary>
    /// <seealso cref="Toolkit.Joystick"/>
    public interface IJoystickComponent : IPalComponent
    {
        public int GetJoystickCount();
        public JoystickHandle Open(int index);
        public void Close(JoystickHandle joystick);

        public Guid GetGuid(JoystickHandle joystick);
        public string GetName(JoystickHandle joystick);
        public bool TryGetBatteryInfo(JoystickHandle joystick, out GamepadBatteryInfo batteryInfo);
        public JoystickCapabilities GetCapabilities(JoystickHandle joystick);

        public int GetNumberOfAxes(JoystickHandle joystick);
        public float GetAxis(JoystickHandle joystick, int axis);

        public int GetNumberOfButtons(JoystickHandle joystick);
        public bool GetButton(JoystickHandle joystick, int button);

        public int GetNumberOfHats(JoystickHandle joystick);
        public HatState GetHat(JoystickHandle joystick, int hat);

        // FIXME: Maybe add a duration as that might be useful for some people...?
        public bool SetRumble(JoystickHandle joystick, float lowFrequencyIntensity, float highFrequencyIntensity);

        // FIXME: Maybe add this?
        //public int GetNumberOfLEDs(JoystickHandle joystick);
        //public void SetLED(JoystickHandle joystick, int index, Color3<Rgb> color);
    }
}
