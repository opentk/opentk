﻿namespace OpenTK.OpenAL.Native
{
    /// <summary>
    /// Defines available parameters for <see cref="Alc.GetInteger(System.IntPtr,OpenTK.OpenAL.Native.AlcGetInteger,int,int[])" />.
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
    }
}