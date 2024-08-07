using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Platform
{
    /// <summary>
    /// A struct containing information about the battery status of the computer.
    /// </summary>
    public struct BatteryInfo
    {
        /// <summary>
        /// Whether the computer is running on AC power.
        /// </summary>
        public bool OnAC;

        /// <summary>
        /// Whether the battery is charging or not.
        /// </summary>
        public bool Charging;

        /// <summary>
        /// Whether battery saver is on or not.
        /// If on, try to conserve power.
        /// </summary>
        public bool PowerSaver;

        /// <summary>
        /// A percentage value (in the range [0, 100])
        /// describing how many percent of full charge is left,
        /// or null if no such value is available.
        /// </summary>
        public float? BatteryPercent;

        /// <summary>
        /// An estimate in seconds of how much battery charge is left,
        /// or null if no such value is available.
        /// </summary>
        public float? BatteryTime;

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"Percentage: {BatteryPercent}%, Time left: {BatteryTime ?? -1}s, OnAC: {OnAC}, Charging: {Charging}, PowerSaver: {PowerSaver}";
        }
    }
}
