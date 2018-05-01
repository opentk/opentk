namespace OpenTK.OpenAL.Native
{
    /// <summary>
    /// A list of valid 3x Int32 Source/GetSource parameters
    /// </summary>
    public enum ALSource3i
    {
        /// <summary>
        /// (EFX Extension) This Source property is used to establish connections between Sources and Auxiliary Effect
        /// Slots. For a Source to feed an Effect that has been loaded into an Auxiliary Effect Slot the application must
        /// configure one of the Source’s auxiliary sends. This process involves setting 3 variables – the destination
        /// Auxiliary Effect Slot ID, the Auxiliary Send number, and an optional Filter ID. Type: uint Range: any valid Filter
        /// Handle.
        /// </summary>
        EfxAuxiliarySendFilter = 0x20006
    }
}
