using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Audio.OpenAL.Extensions.SOFT.HRTF
{
    public enum HRTFStatus
    {
        /// <summary>
        /// ALC_HRTF_DISABLED_SOFT
        /// </summary>
        Disabled = 0x0000,

        /// <summary>
        /// ALC_HRTF_ENABLED_SOFT
        /// </summary>
        Enabled = 0x0001,

        /// <summary>
        /// ALC_HRTF_DENIED_SOFT
        /// </summary>
        Denied = 0x0002,

        /// <summary>
        /// ALC_HRTF_REQUIRED_SOFT
        /// </summary>
        Required = 0x0003,

        /// <summary>
        /// ALC_HRTF_HEADPHONES_DETECTED_SOFT
        /// </summary>
        HeadphonesDetected = 0x0004,

        /// <summary>
        /// ALC_HRTF_UNSUPPORTED_FORMAT_SOFT
        /// </summary>
        UnsupportedFormat = 0x0005,
    }
}
