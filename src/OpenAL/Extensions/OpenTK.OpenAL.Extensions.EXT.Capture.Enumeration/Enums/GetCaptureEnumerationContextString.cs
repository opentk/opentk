﻿using OpenTK.OpenAL.Native;

namespace OpenTK.OpenAL.Extensions.Enumeration
{
    /// <summary>
    /// Defines available parameters for <see cref="ALContext.GetString(System.IntPtr,GetCaptureContextString)" />.
    /// </summary>
    public enum GetCaptureContextString
    {
        /// <summary>
        /// Gets the name of the default capture device
        /// </summary>
        DefaultCaptureDeviceSpecifier = 0x311,

        /// <summary>
        /// Gets the first available capture device specifier.
        /// </summary>
        CaptureDeviceSpecifier = 0x310,
    }
}