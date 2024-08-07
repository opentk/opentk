using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Platform
{
    /// <summary>
    /// Represents a type of battery in a gamepad.
    /// </summary>
    public enum GamepadBatteryType
    {
        /// <summary>
        /// The type of battery is unknown.
        /// </summary>
        Unknown,

        /// <summary>
        /// The gamepad is wired.
        /// </summary>
        Wired,

        /// <summary>
        /// The gamepad has an alkaline battery.
        /// </summary>
        Alkaline,

        /// <summary>
        /// The gamepad has a nickel metal hydride battery.
        /// </summary>
        NiMH,
    }

    /// <summary>
    /// Contains information about a gamepads battery.
    /// </summary>
    public struct GamepadBatteryInfo
    {
        /// <summary>
        /// The type of battery contained in the gamepad.
        /// </summary>
        public GamepadBatteryType BatteryType;

        /// <summary>
        /// The level of charge of the gamepad battery. In the range [0, 1], where 0 represents empty and 1 represents full.
        /// </summary>
        /// <remarks>
        /// On Windows this value will only change in four steps, <c>0.0</c>, <c>0.333...</c>, <c>0.666...</c>, and <c>1.0</c>. Representing Empty, Low, Medium, and Full.
        /// </remarks>
        public float ChargeLevel;

        /// <summary>
        /// Initializes a new instance of the <see cref="GamepadBatteryInfo"/> struct.
        /// </summary>
        /// <param name="batteryType">The type of battery contained in the gamepad.</param>
        /// <param name="chargeLevel">The level of charge of the battery.</param>
        public GamepadBatteryInfo(GamepadBatteryType batteryType, float chargeLevel)
        {
            BatteryType = batteryType;
            ChargeLevel = chargeLevel;
        }
    }
}
