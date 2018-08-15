namespace OpenTK.OpenAL.Native
{
    /// <summary>
    /// A list of valid Int32 AuxiliaryEffectSlot/GetAuxiliaryEffectSlot parameters
    /// </summary>
    public enum EfxAuxiliaryi
    {
        /// <summary>
        /// This property is used to attach an Effect object to the Auxiliary Effect Slot object. After the attachment,
        /// the Auxiliary Effect Slot object will contain the effect type and have the same effect parameters that were stored
        /// in the Effect object. Any Sources feeding the Auxiliary Effect Slot will immediate feed the new effect type and new
        /// effect parameters.
        /// </summary>
        EffectslotEffect = 0x0001,

        /// <summary>
        /// This property is used to enable or disable automatic send adjustments based on the physical positions of the
        /// sources and the listener. This property should be enabled when an application wishes to use a reverb effect to
        /// simulate the environment surrounding a listener or a collection of Sources. Range [False, True] Default: True
        /// </summary>
        EffectslotAuxiliarySendAuto = 0x0003
    }
}