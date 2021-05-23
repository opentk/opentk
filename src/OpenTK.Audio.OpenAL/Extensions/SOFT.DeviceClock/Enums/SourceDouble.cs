using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Audio.OpenAL.Extensions.SOFT.DeviceClock
{
    public enum SourceDouble
    {
        /// <summary>
        /// AL_SEC_OFFSET_LATENCY_SOFT
        /// <br/>
        /// The playback position, along with the device clock, both expressed in seconds.
        /// This attribute is read-only.
        /// <br/>
        /// The first value in the returned vector is the offset in seconds.
        /// The value is similar to that returned by <see cref="ALSourcef.SecOffset"/>, just with more precision.
        /// <br/>
        /// The second value is the device clock, in seconds.
        /// This updates at the same rate as the offset, and both are measured atomically with respect to one another.
        /// Be aware that this value may be subtly different from the other device clock queries due to the variable precision of floating-point values.
        /// </summary>
        SecOffsetClock = 0x1203,
    }
}
