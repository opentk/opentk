using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Audio.OpenAL.Extensions.SOFT.DeviceClock
{
    public enum SourceInteger64
    {
        /// <summary>
        /// AL_SAMPLE_OFFSET_CLOCK_SOFT
        /// <br/>
        /// The playback position, expressed in fixed-point samples, along with the device clock, expressed in nanoseconds.
        /// This attribute is read-only.
        /// <br/>
        /// The first value in the returned vector is the sample offset, which is a 32.32 fixed-point value.
        /// The whole number is stored in the upper 32 bits and the fractional component is in the lower 32 bits.
        /// The value is similar to that returned by <see cref="ALSourcei.SampleOffset"/>, just with more precision.
        /// <br/>
        /// The second value is the device clock, in nanoseconds.
        /// This updates at the same rate as the offset, and both are measured atomically with respect to one another.
        /// </summary>
        SampleOffsetClock = 0x1202,
    }
}
