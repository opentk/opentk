﻿/* EfxFilterType.cs
 * C headers: \OpenAL 1.1 SDK\include\ "efx.h", "efx-creative.h", "Efx-Util.h"
 * Spec: Effects Extension Guide.pdf (bundled with OpenAL SDK)
 * Copyright (c) 2008 Christoph Brandtner and Stefanos Apostolopoulos
 * See license.txt for license details
 * http://www.OpenTK.net */

namespace OpenTK.OpenAL.Native
{
    /// <summary>
    /// Filter type definitions to be used with EfxFilteri.FilterType.
    /// </summary>
    public enum EfxFilterType
    {
        /// <summary>
        /// No Filter, disable. This Filter type is used when a Filter object is initially created.
        /// </summary>
        Null = 0x0000,

        /// <summary>
        /// A low-pass filter is used to remove high frequency content from a signal.
        /// </summary>
        Lowpass = 0x0001,

        /// <summary>
        /// Currently not implemented. A high-pass filter is used to remove low frequency content from a signal.
        /// </summary>
        Highpass = 0x0002,

        /// <summary>
        /// Currently not implemented. A band-pass filter is used to remove high and low frequency content from a signal.
        /// </summary>
        Bandpass = 0x0003,
    }
}
