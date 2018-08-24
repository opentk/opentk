using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using AdvancedDLSupport;
using OpenTK.OpenAL.Extensions.EXT.Capture;
using OpenTK.OpenAL.Native;
using OpenTK.OpenAL.Native.Attributes;
using OpenTK.OpenAL.Native.Extensions;

namespace OpenTK.OpenAL.Extensions.Enumeration
{
    /// <summary>
    /// Exposes the API in the Capture extension.
    /// </summary>
    public abstract class Capture : ExtensionBase, ICaptureContextState, ICaptureContext
    {
        /// <inheritdoc cref="ExtensionBase"/>
        protected Capture(string path, ImplementationOptions options) : base(path, options)
        {
        }

        /// <inheritdoc />
        public abstract unsafe char* GetString(void* device, GetCaptureContextString param);

        /// <inheritdoc cref="GetString(void*, GetCaptureContextString)"/>
        public string GetString(IntPtr device, GetCaptureContextString param)
        {
            unsafe
            {
                var result = GetString(device.ToPointer(), param);
                if (result != (char*)0)
                {
                    return Marshal.PtrToStringAnsi(new IntPtr(result));
                }
            }

            return string.Empty;
        }

        /// <inheritdoc />
        public abstract unsafe char* GetStringList(void* device, GetCaptureContextStringList param);

        /// <inheritdoc cref="GetString(void*, GetCaptureContextStringList)"/>
        public IEnumerable<string> GetStringList(GetCaptureContextStringList param)
        {
            unsafe
            {
                var result = GetStringList(null, param);
                if (result == (char*)0)
                {
                    return new List<string>();
                }

                var strings = new List<string>();

                var currentPos = result;
                while (true)
                {
                    var currentString = Marshal.PtrToStringAnsi(new IntPtr(currentPos));
                    if (currentString is null)
                    {
                        break;
                    }

                    strings.Add(currentString);
                    currentPos += currentString.Length + 1;
                }

                return strings;
            }
        }

        /// <inheritdoc />
        public abstract unsafe void* CaptureOpenDevice(string deviceName, uint frequency, BufferFormat format, int size);

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
        public TManagedFormat[] CaptureSamples<TManagedFormat, TBufferFormat>
        (
            IntPtr device,
            TBufferFormat bufferFormat,
            int sampleCount
        )
            where TBufferFormat : struct, Enum
            where TManagedFormat : unmanaged
        {
            var formatSize = FormatHelpers.GetFormatSize(bufferFormat);

            unsafe
            {
                var managedFormatSize = sizeof(TManagedFormat);
                var internalBufferSize = sampleCount * formatSize;
                var managedBufferElementCount = internalBufferSize / managedFormatSize;

                var resizeBuffer = new TManagedFormat[managedBufferElementCount];
                fixed (void* ptr = resizeBuffer)
                {
                    CaptureSamples(device.ToPointer(), ptr, sampleCount);
                }

                return resizeBuffer;
            }
        }
    }
}
