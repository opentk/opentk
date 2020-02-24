//
// GetCaptureContextInteger.cs
//
// Copyright (C) 2020 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace OpenToolkit.Audio.OpenAL.Extensions.EXT.Capture
{
    /// <summary>
    /// Defines valid values for the <see cref="Capture.GetContextProperty(ALCaptureDevice, GetCaptureContextInteger, int, out int)"/> method.
    /// </summary>
    public enum GetCaptureContextInteger
    {
        /// <summary>
        /// The number of capture samples available. NULL is an invalid device.
        /// </summary>
        CaptureSamples = 0x312,
    }
}
