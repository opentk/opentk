//
// EXTFloat32.cs
//
// Copyright (C) 2020 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using OpenTK.Audio.OpenAL;
using OpenTK.Audio.OpenAL.Extensions.EXT.FloatFormat;

namespace OpenTK.Audio.OpenAL.Extensions.EXT.Float32
{
    public class EXTFloat32 : ALBase
    {
        /// <summary>
        /// The name of this AL extension.
        /// </summary>
        public const string ExtensionName = "AL_EXT_float32";

        static EXTFloat32()
        {
            // We need to register the resolver for OpenAL before we can DllImport functions.
            ALBase.RegisterOpenALResolver();
        }

        private EXTFloat32()
        {
        }

        /// <summary>
        /// Checks if this extension is present.
        /// </summary>
        /// <returns>Whether the extension was present or not.</returns>
        public static bool IsExtensionPresent()
        {
            return AL.IsExtensionPresent(ExtensionName);
        }

        /// <summary>This function fills a buffer with audio buffer. All the pre-defined formats are PCM buffer, but this function may be used by extensions to load other buffer types as well.</summary>
        /// <param name="bid">buffer Handle/Name to be filled with buffer.</param>
        /// <param name="format">Format type from among the following: FloatBufferFormat.Mono, FloatBufferFormat.Stereo.</param>
        /// <param name="buffer">Pointer to a pinned audio buffer.</param>
        /// <param name="bytes">The size of the audio buffer in bytes.</param>
        /// <param name="freq">The frequency of the audio buffer.</param>
        [DllImport(AL.Lib, EntryPoint = "alBufferData", ExactSpelling = true, CallingConvention = AL.ALCallingConvention)]
        public static unsafe extern void BufferData(int bid, FloatBufferFormat format, float* buffer, int bytes, int freq);
        // AL_API void AL_APIENTRY alBufferData( ALuint bid, ALenum format, const ALvoid* buffer, ALsizei size, ALsizei freq );

        /// <summary>This function fills a buffer with audio buffer. All the pre-defined formats are PCM buffer, but this function may be used by extensions to load other buffer types as well.</summary>
        /// <param name="bid">buffer Handle/Name to be filled with buffer.</param>
        /// <param name="format">Format type from among the following: FloatBufferFormat.Mono, FloatBufferFormat.Stereo.</param>
        /// <param name="buffer">Pointer to a pinned audio buffer.</param>
        /// <param name="bytes">The size of the audio buffer in bytes.</param>
        /// <param name="freq">The frequency of the audio buffer.</param>
        [DllImport(AL.Lib, EntryPoint = "alBufferData", ExactSpelling = true, CallingConvention = AL.ALCallingConvention)]
        public static extern void BufferData(int bid, FloatBufferFormat format, ref float buffer, int bytes, int freq);
        // AL_API void AL_APIENTRY alBufferData( ALuint bid, ALenum format, const ALvoid* buffer, ALsizei size, ALsizei freq );

        /// <summary>This function fills a buffer with audio buffer. All the pre-defined formats are PCM buffer, but this function may be used by extensions to load other buffer types as well.</summary>
        /// <param name="bid">buffer Handle/Name to be filled with buffer.</param>
        /// <param name="format">Format type from among the following: FloatBufferFormat.Mono, FloatBufferFormat.Stereo.</param>
        /// <param name="buffer">The audio buffer.</param>
        /// <param name="freq">The frequency of the audio buffer.</param>
        /// FIXME: Should "size" be changed to "elements"?
        public static unsafe void BufferData(int bid, FloatBufferFormat format, float[] buffer, int freq)
        {
            BufferData(bid, format, ref buffer[0], buffer.Length * sizeof(float), freq);
        }

        /// <summary>This function fills a buffer with audio buffer. All the pre-defined formats are PCM buffer, but this function may be used by extensions to load other buffer types as well.</summary>
        /// <param name="bid">buffer Handle/Name to be filled with buffer.</param>
        /// <param name="format">Format type from among the following: FloatBufferFormat.Mono, FloatBufferFormat.Stereo.</param>
        /// <param name="buffer">Span representing the audio buffer.</param>
        /// <param name="freq">The frequency of the audio buffer.</param>
        public static unsafe void BufferData(int bid, FloatBufferFormat format, Span<float> buffer, int freq)
        {
            BufferData(bid, format, ref buffer[0], buffer.Length * sizeof(float), freq);
        }
    }
}
