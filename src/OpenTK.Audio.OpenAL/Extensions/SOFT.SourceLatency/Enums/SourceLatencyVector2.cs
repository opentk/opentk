using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Audio.OpenAL.Extensions.SOFT.SourceLatency
{
    public enum SourceLatencyVector2i
    {
        /// <summary>
        /// The playback position, expressed in fixed-point samples,
        /// along with the playback latency, expressed in nanoseconds (1/1000000000ths
        /// of a second). This attribute is read-only.
        /// AL_SAMPLE_OFFSET_LATENCY_SOFT
        /// </summary>
        SampleOffsetLatency = 0x1200,
    }

#pragma warning disable SA1402 // File may only contain a single type
    public enum SourceLatencyVector2d
#pragma warning restore SA1402 // File may only contain a single type
    {
        /// <summary>
        /// The playback position, along with the playback latency, both
        /// expressed in seconds. This attribute is read-only.
        /// AL_SEC_OFFSET_LATENCY_SOFT
        /// </summary>
        SecOffsetLatency = 0x1201,
    }
}
