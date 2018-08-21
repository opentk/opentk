/* EfxFilterf.cs
 * C headers: \OpenAL 1.1 SDK\include\ "efx.h", "efx-creative.h", "Efx-Util.h"
 * Spec: Effects Extension Guide.pdf (bundled with OpenAL SDK)
 * Copyright (c) 2008 Christoph Brandtner and Stefanos Apostolopoulos
 * See license.txt for license details
 * http://www.OpenTK.net */

namespace OpenTK.OpenAL.Native
{
    /// <summary>
    /// A list of valid 32-bits Float Filter/GetFilter parameters.
    /// </summary>
    public enum EfxFilterf
    {
        /// <summary>
        /// Range [0.0f .. 1.0f] Default: 1.0f
        /// </summary>
        LowpassGain = 0x0001,

        /// <summary>
        /// Range [0.0f .. 1.0f] Default: 1.0f
        /// </summary>
        LowpassGainHf = 0x0002,

        /// <summary>
        /// Range [0.0f .. 1.0f] Default: 1.0f
        /// </summary>
        HighpassGain = 0x0001,

        /// <summary>
        /// Range [0.0f .. 1.0f] Default: 1.0f
        /// </summary>
        HighpassGainLf = 0x0002,

        /// <summary>
        /// Range [0.0f .. 1.0f] Default: 1.0f
        /// </summary>
        BandpassGain = 0x0001,

        /// <summary>
        /// Range [0.0f .. 1.0f] Default: 1.0f
        /// </summary>
        BandpassGainLf = 0x0002,

        /// <summary>
        /// Range [0.0f .. 1.0f] Default: 1.0f
        /// </summary>
        BandpassGainHf = 0x0003,
    }
}
