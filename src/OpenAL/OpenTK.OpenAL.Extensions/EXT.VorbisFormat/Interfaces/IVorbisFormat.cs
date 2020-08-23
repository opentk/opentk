//
// IVorbisFormat.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using AdvancedDLSupport;

namespace OpenTK.OpenAL.Extensions.EXT.VorbisFormat
{
    /// <summary>
    /// Defines the public interface for buffer-related functions of the multi-channel buffers extension.
    /// </summary>
    [NativeSymbols(Prefix = "al")]
    internal interface IVorbisFormat
    {
        /// <summary>
        /// Fills a buffer with audio data.
        /// </summary>
        /// <param name="buffer">The buffer to fill.</param>
        /// <param name="format">The format of the data.</param>
        /// <param name="data">A pointer to the data.</param>
        /// <param name="size">The size of the data in bytes.</param>
        /// <param name="frequency">The frequency of the data.</param>
        unsafe void BufferData(uint buffer, VorbisBufferFormat format, void* data, int size, int frequency);
    }
}
