namespace OpenToolkit.NT.Native
{
    /// <summary>
    /// Specifies a layer type for a <see cref="PixelFormatDescriptor"/>.<para/>
    /// This official documentation states that this type is ignored by OpenGL, so use with care.
    /// </summary>
    public enum PixelFormatDescriptorLayerTypes : byte
    {
        /// <summary>
        /// Undocumented member.
        /// </summary>
        MainPlane = 0,

        /// <summary>
        /// Undocumented member.
        /// </summary>
        OverlayPlane = 1,

        /// <summary>
        /// Undocumented member.
        /// </summary>
        UnderlayPlane = unchecked((byte)(-1))
    }
}
