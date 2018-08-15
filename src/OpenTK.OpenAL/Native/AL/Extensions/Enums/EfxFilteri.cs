/* EfxFilteri.cs
 * C headers: \OpenAL 1.1 SDK\include\ "efx.h", "efx-creative.h", "Efx-Util.h"
 * Spec: Effects Extension Guide.pdf (bundled with OpenAL SDK)
 * Copyright (c) 2008 Christoph Brandtner and Stefanos Apostolopoulos
 * See license.txt for license details
 * http://www.OpenTK.net */

namespace OpenTK.OpenAL.Native
{
    /// <summary>
    /// A list of valid Int32 Filter/GetFilter parameters.
    /// </summary>
    public enum EfxFilteri
    {
        /// <summary>
        /// Used with the enum EfxFilterType as Parameter to select a filter logic.
        /// </summary>
        FilterType = 0x8001,
    }
}
