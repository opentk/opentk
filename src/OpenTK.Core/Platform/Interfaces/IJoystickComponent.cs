using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Core.Platform
{
    /// <summary>
    /// Interface for interacting with joysticks.
    /// </summary>
    public interface IJoystickComponent : IPalComponent
    {
        // FIXME: Add some way to query if joysticks are connected or not?

        /// <summary>
        /// The recommended deadzone value for the left analog stick.
        /// </summary>
        public float LeftDeadzone { get; }

        /// <summary>
        /// The recommended deadzone value for the right analog stick.
        /// </summary>
        public float RightDeadzone { get; }

        /// <summary>
        /// The recommended threshold for considering the left or right trigger pressed.
        /// </summary>
        public float TriggerThreshold { get; }

        /// <summary>
        /// Opens a handle to a specific joystick.
        /// </summary>
        /// <param name="index">The player index of the joystick to open.</param>
        /// <returns>The opened joystick handle.</returns>
        public JoystickHandle Open(int index);

        /// <summary>
        /// Closes a handle to a joystick.
        /// </summary>
        /// <param name="handle">The joystick handle.</param>
        public void Close(JoystickHandle handle);

        public Guid GetGuid(JoystickHandle handle);

        public string GetName(JoystickHandle handle);

        /// <summary>
        /// Gets the value of a specific joystick axis.
        /// This value is in the range [-1, 1] for analog sticks, and [0, 1] for triggers.
        /// </summary>
        /// <param name="handle">A handle to a joystick.</param>
        /// <param name="axis">The joystick axis to get.</param>
        /// <returns>The joystick axis value.</returns>
        public float GetAxis(JoystickHandle handle, JoystickAxis axis);

        /// <summary>
        /// Get the pressed state of a specific joystick button.
        /// </summary>
        /// <param name="handle">A handle to a joystick.</param>
        /// <param name="button">The joystick button to get.</param>
        /// <returns>True if the specified button is pressed or false if the button is released.</returns>
        public bool GetButton(JoystickHandle handle, JoystickButton button);

        public bool SetVibration(JoystickHandle handle, float lowFreqIntensity, float highFreqIntensity);

        public bool TryGetBatteryInfo(JoystickHandle handle, out GamepadBatteryInfo batteryInfo);
    }
}
