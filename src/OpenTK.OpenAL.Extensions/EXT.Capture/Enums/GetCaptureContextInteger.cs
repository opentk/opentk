//
// GetCaptureContextInteger.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using OpenTK.OpenAL.Extensions.EXT.Capture.Interfaces;

namespace OpenTK.OpenAL.Extensions.EXT.Capture.Enums
{
    /// <summary>
    /// Defines valid values for the <see cref="ICaptureContextState.GetContextProperty"/> method.
    /// </summary>
    public enum GetCaptureContextInteger
    {
        /// <summary>
        /// The number of capture samples available. NULL is an invalid device.
        /// </summary>
        CaptureSamples = 0x312,
    }
}
