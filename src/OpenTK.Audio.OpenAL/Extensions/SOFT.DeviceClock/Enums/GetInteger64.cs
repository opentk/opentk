using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Audio.OpenAL.Extensions.SOFT.DeviceClock
{
    public enum GetInteger64
    {
        /// <summary>
        /// The audio device clock time, expressed
        /// in nanoseconds.
        /// NULL is an invalid device.
        /// ALC_DEVICE_CLOCK_SOFT
        /// </summary>
        DeviceClock = 0x1600,

        /// <summary>
        /// The current audio device latency, in nanoseconds.
        /// This is effectively the delay for the samples rendered at the the device's current clock time from reaching the physical output.
        /// NULL is an invalid device.
        /// ALC_DEVICE_LATENCY_SOFT
        /// </summary>
        DeviceLatency = 0x1601,

        /// <summary>
        /// Expects a destination size of 2, and provides both the audio device clock time and latency, both in nanoseconds.
        /// The two values are measured atomically with respect to one another (i.e. the latency value was measured at the same time the device clock value was retrieved).
        /// NULL is an invalid device.
        /// ALC_DEVICE_CLOCK_LATENCY_SOFT
        /// </summary>
        DeviceClockLatency = 0x1602,
    }
}
