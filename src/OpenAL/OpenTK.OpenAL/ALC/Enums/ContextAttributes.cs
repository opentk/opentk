/* AlcTokens.cs
 * C header: \OpenAL 1.1 SDK\include\Alc.h
 * Spec: http://www.openal.org/openal_webstf/specs/OpenAL11Specification.pdf
 * Copyright (c) 2008 Christoph Brandtner and Stefanos Apostolopoulos
 * See license.txt for license details
 * http://www.OpenTK.net */

namespace OpenToolkit.OpenAL
{
    /// <summary>
    /// Defines available context attributes.
    /// </summary>
    public enum ContextAttributes
    {
        /// <summary>
        /// Followed by System.Int32 Hz
        /// </summary>
        Frequency = 0x1007,

        /// <summary>
        /// Followed by System.Int32 Hz
        /// </summary>
        Refresh = 0x1008,

        /// <summary>
        /// Followed by AlBoolean.True, or AlBoolean.False
        /// </summary>
        Sync = 0x1009,

        /// <summary>
        /// Followed by System.Int32 Num of requested Mono (3D) Sources
        /// </summary>
        MonoSources = 0x1010,

        /// <summary>
        /// Followed by System.Int32 Num of requested Stereo Sources
        /// </summary>
        StereoSources = 0x1011,
    }
}
