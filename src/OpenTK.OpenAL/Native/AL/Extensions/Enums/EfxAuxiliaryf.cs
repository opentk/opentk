/* EfxAuxiliaryf.cs
 * C headers: \OpenAL 1.1 SDK\include\ "efx.h", "efx-creative.h", "Efx-Util.h"
 * Spec: Effects Extension Guide.pdf (bundled with OpenAL SDK)
 * Copyright (c) 2008 Christoph Brandtner and Stefanos Apostolopoulos
 * See license.txt for license details
 * http://www.OpenTK.net */

namespace OpenTK.OpenAL.Native
{
    /// <summary>
    /// A list of valid 32-bits Float AuxiliaryEffectSlot/GetAuxiliaryEffectSlot parameters.
    /// </summary>
    public enum EfxAuxiliaryf
    {
        /// <summary>
        /// This property is used to specify an output level for the Auxiliary Effect Slot. Setting the gain to 0.0f mutes
        /// the output. Range [0.0f .. 1.0f] Default: 1.0f
        /// </summary>
        EffectslotGain = 0x0002,
    }
}
