using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Platform
{
    /// <summary>
    /// Whether the computer has a battery or if it doesn't, or if the computers battery status is unknown.
    /// </summary>
    public enum BatteryStatus
    {
        /// <summary>
        /// The battery status of the computer is indeterminable.
        /// </summary>
        Unknown,

        /// <summary>
        /// The computer does not have a battery.
        /// </summary>
        NoSystemBattery,

        /// <summary>
        /// The computer has a battery, for more information see <see cref="BatteryInfo"/>.
        /// </summary>
        HasSystemBattery,
    }
}
