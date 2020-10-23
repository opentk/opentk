using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Audio.OpenAL.Extensions.SOFT.HRTF
{
    /// <summary>
    /// Attribute keys related to HRTF.
    /// </summary>
    public enum HRTFAttribute
    {
        /// <summary>
        /// An attribute used to control HRTF mixing.
        /// ALC_HRTF_SOFT
        /// </summary>
        HRTF = 0x1992,

        /// <summary>
        /// An attribute used to control which HRTF to use for mixing.
        /// ALC_HRTF_ID_SOFT
        /// </summary>
        HRTF_ID = 0x1996,
    }
}
