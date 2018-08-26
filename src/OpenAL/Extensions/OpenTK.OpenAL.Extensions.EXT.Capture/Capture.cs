using System;
using AdvancedDLSupport;
using OpenTK.OpenAL.Attributes;

namespace OpenTK.OpenAL.Extensions.EXT.Capture
{
    /// <summary>
    /// Exposes the API in the Capture extension.
    /// </summary>
    public abstract class Capture : ContextExtensionBase, ICaptureContext, ICaptureContextState
    {
        /// <inheritdoc cref="ExtensionBase"/>
        protected Capture(string path, ImplementationOptions options) : base(path, options)
        {
        }

        /// <inheritdoc />
        public abstract unsafe void* CaptureOpenDevice(string deviceName, uint frequency, BufferFormat format, int size);

        /// <inheritdoc cref="CaptureOpenDevice"/>
        public unsafe void* CaptureOpenDevice<TBufferFormat>
        (
            string deviceName,
            uint frequency,
            TBufferFormat format,
            int size
        )
            where TBufferFormat : struct, Enum
        {
            return CaptureOpenDevice(deviceName, frequency,(BufferFormat)(object)format, size);
        }

        /// <inheritdoc />
        public abstract unsafe bool CaptureCloseDevice(void* device);

        /// <inheritdoc />
        public abstract unsafe void CaptureStart(void* device);

        /// <inheritdoc />
        public abstract unsafe void CaptureStop(void* device);

        /// <inheritdoc />
        public abstract unsafe void CaptureSamples(void* device, void* buffer, int sampleCount);

        /// <summary>
        /// Completes a capture operation. This call does not block.
        /// </summary>
        /// <param name="device">The device.</param>
        /// <param name="bufferFormat">The data format of the buffer.</param>
        /// <param name="sampleCount">The number of samples to retrieve.</param>
        public unsafe TManagedFormat[] CaptureSamples<TManagedFormat, TBufferFormat>
        (
            void* device,
            TBufferFormat bufferFormat,
            int sampleCount
        )
            where TBufferFormat : struct, Enum
            where TManagedFormat : unmanaged
        {
            var formatSize = FormatHelpers.GetFormatSize(bufferFormat);

            var managedFormatSize = sizeof(TManagedFormat);
            var internalBufferSize = sampleCount * formatSize;
            var managedBufferElementCount = internalBufferSize / managedFormatSize;

            var resizeBuffer = new TManagedFormat[managedBufferElementCount];
            CaptureSamples(device, bufferFormat, sampleCount, ref resizeBuffer);

            return resizeBuffer;
        }

        /// <summary>
        /// Completes a capture operation. This call does not block.
        /// </summary>
        /// <param name="device">The device.</param>
        /// <param name="bufferFormat">The data format of the buffer.</param>
        /// <param name="sampleCount">The number of samples to retrieve.</param>
        /// <param name="buffer">The buffer to fill. </param>
        public unsafe void CaptureSamples<TManagedFormat, TBufferFormat>
        (
            void* device,
            TBufferFormat bufferFormat,
            int sampleCount,
            ref TManagedFormat[] buffer
        )
            where TBufferFormat : struct, Enum
            where TManagedFormat : unmanaged
        {
            var formatSize = FormatHelpers.GetFormatSize(bufferFormat);

            var managedFormatSize = sizeof(TManagedFormat);
            var internalBufferSize = sampleCount * formatSize;
            var managedBufferElementCount = internalBufferSize / managedFormatSize;

            if (buffer.Length < managedBufferElementCount)
            {
                throw new ArgumentException
                (
                    "The buffer wasn't large enough to contain all of the requested samples.",
                    nameof(buffer)
                );
            }

            fixed (void* ptr = buffer)
            {
                CaptureSamples(device, ptr, sampleCount);
            }
        }

        /// <inheritdoc />
        public abstract unsafe void GetContextProperty(void* device, GetCaptureContextInteger param, int count, void* data);

        /// <inheritdoc cref="GetContextProperty"/>
        public unsafe int GetAvailableSamples(void* device)
        {
            var result = 0;
            GetContextProperty(device, GetCaptureContextInteger.CaptureSamples, 1, &result);

            return result;
        }
    }
}
