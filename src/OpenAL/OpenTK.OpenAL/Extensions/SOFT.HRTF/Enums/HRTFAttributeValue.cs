using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Audio.OpenAL.Extensions.SOFT.HRTF
{
    /// <summary>
    /// Attribute value used to indicate whether HRTF mixing should be enabled.
    /// </summary>
    public enum HRTFAttributeValue
    {
        /// <summary>
        /// Indicates that no HRTF mixing should occur.
        /// ALC_FALSE
        /// </summary>
        False = 0x0000,

        /// <summary>
        /// Indicates that HRTF mixing is requested.
        /// ALC_TRUE
        /// </summary>
        True = 0x0001,

        /// <summary>
        /// Indicates that the the application does't care about HRTF mixing and that AL can decide if HRTF mixing should occur.
        /// ALC_DONT_CARE_SOFT
        /// </summary>
        DontCare = 0x0002,
    }
}
