//
// EffectSlotBoolean.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace OpenTK.Audio.OpenAL
{
    /// <summary>
    /// A list of valid <see cref="int"/> <see cref="ALC.EFX.AuxiliaryEffectSlot(int, EffectSlotInteger, int)"/>/<see cref="ALC.EFX.GetAuxiliaryEffectSlot(int, EffectSlotInteger)"/> parameters.
    /// </summary>
    public enum EffectSlotBoolean
    {
        /// <summary>
        /// This property is used to enable or disable automatic send adjustments based on the physical positions of the
        /// sources and the listener. This property should be enabled when an application wishes to use a reverb effect
        /// to simulate the environment surrounding a listener or a collection of Sources.
        /// </summary>
        AuxiliarySendAuto = 0x0003,
    }
}
