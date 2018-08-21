namespace OpenTK.OpenAL.Native
{
    /// <summary>
    /// Defines available parameters for <see cref="Alc.GetInteger(System.IntPtr,OpenTK.OpenAL.Native.AlcGetInteger,int,int[])"/>.
    /// </summary>
    public enum AlcGetInteger
    {
        /// <summary>
        /// The specification revision for this implementation (major version). NULL is an acceptable device.
        /// </summary>
        MajorVersion = 0x1000,

        /// <summary>
        /// The specification revision for this implementation (minor version). NULL is an acceptable device.
        /// </summary>
        MinorVersion = 0x1001,

        /// <summary>
        /// The size (number of ALCint values) required for a zero-terminated attributes list, for the current context.
        /// NULL is an invalid device.
        /// </summary>
        AttributesSize = 0x1002,

        /// <summary>
        /// Expects a destination of ALC_ATTRIBUTES_SIZE, and provides an attribute list for the current context of the
        /// specified device. NULL is an invalid device.
        /// </summary>
        AllAttributes = 0x1003,

        /// <summary>
        /// The number of capture samples available. NULL is an invalid device.
        /// </summary>
        CaptureSamples = 0x312,

        /// <summary>
        /// (EFX Extension) This property can be used by the application to retrieve the Major version number of the
        /// Effects Extension supported by this OpenAL implementation. As this is a Context property is should be retrieved
        /// using alcGetIntegerv.
        /// </summary>
        EfxMajorVersion = 0x20001,

        /// <summary>
        /// (EFX Extension) This property can be used by the application to retrieve the Minor version number of the
        /// Effects Extension supported by this OpenAL implementation. As this is a Context property is should be retrieved
        /// using alcGetIntegerv.
        /// </summary>
        EfxMinorVersion = 0x20002,

        /// <summary>
        /// (EFX Extension) This Context property can be passed to OpenAL during Context creation (alcCreateContext) to
        /// request a maximum number of Auxiliary Sends desired on each Source. It is not guaranteed that the desired number of
        /// sends will be available, so an application should query this property after creating the context using
        /// alcGetIntergerv. Default: 2
        /// </summary>
        EfxMaxAuxiliarySends = 0x20003
    }
}
