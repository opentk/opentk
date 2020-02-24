//
// Capture.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using System.Runtime.InteropServices;
using AdvancedDLSupport;
using OpenToolkit.Core.Extensions;
using OpenToolkit.Core.Loader;
using OpenToolkit.OpenAL.Attributes;

namespace OpenToolkit.Audio.OpenAL.Extensions.EXT.Capture
{
    /// <summary>
    /// Exposes the API in the Capture extension.
    /// </summary>
    [Api(ALC.Lib, typeof(OpenALLibraryNameContainer))]
    public class Capture : ApiContainer<Capture>
    {
        /// <summary>
        /// The name of this AL extension.
        /// </summary>
        public const string ExtensionName = "ALC_EXT_CAPTURE";

        static Capture()
        {
            _ = ApiContainer<Capture>.StaticConstructorTrigger;
        }

        private Capture()
        {
        }

        /// <summary>
        /// Checks whether the extension is present.
        /// </summary>
        /// <returns>Whether the extension was present or not.</returns>
        public static bool IsExtensionPresent()
        {
            return ALC.IsExtensionPresent(ALDevice.Null, ExtensionName);
        }

        /// <summary>
        /// Checks whether the extension is present.
        /// </summary>
        /// <param name="device">The device to be queried.</param>
        /// <returns>Whether the extension was present or not.</returns>
        public static bool IsExtensionPresent(ALDevice device)
        {
            return ALC.IsExtensionPresent(device, ExtensionName);
        }

        /// <summary>
        /// Opens a capture device by name.
        /// </summary>
        /// <param name="deviceName">The name of the device.</param>
        /// <param name="frequency">The frequency data should be captured at.</param>
        /// <param name="format">The requested capture buffer format.</param>
        /// <param name="size">The size of the capture buffer.</param>
        /// <returns>The device pointer, or null.</returns>
        [DllImport(ALC.Lib, EntryPoint = "alcCaptureOpenDevice", ExactSpelling = true, CallingConvention = ALC.AlcCalliningConv)]
        public static extern ALCaptureDevice CaptureOpenDevice(string deviceName, uint frequency, ALFormat format, int size);

        /// <summary>
        /// Opens a capture device by name.
        /// </summary>
        /// <param name="deviceName">The name of the device.</param>
        /// <param name="frequency">The frequency data should be captured at.</param>
        /// <param name="format">The requested capture buffer format.</param>
        /// <param name="size">The size of the capture buffer.</param>
        /// <returns>The device pointer, or null.</returns>
        [DllImport(ALC.Lib, EntryPoint = "alcCaptureOpenDevice", ExactSpelling = true, CallingConvention = ALC.AlcCalliningConv)]
        public static extern ALCaptureDevice CaptureOpenDevice(string deviceName, int frequency, ALFormat format, int size);

        /// <summary>
        /// Closes the specified capture device.
        /// </summary>
        /// <param name="device">The device.</param>
        /// <returns>true if the device was closed; otherwise, false.</returns>
        [DllImport(ALC.Lib, EntryPoint = "alcCaptureCloseDevice", ExactSpelling = true, CallingConvention = ALC.AlcCalliningConv)]
        public static extern bool CaptureCloseDevice(ALCaptureDevice device);

        /// <summary>
        /// Begins a capture operation.
        ///
        /// CaptureStart will begin recording to an internal ring buffer of the size specified when opening the capture
        /// device. The application can then retrieve the number of samples currently available using
        /// <see cref="GetCaptureContextInteger.CaptureSamples"/> with <see cref="Capture.GetContextProperty(ALCaptureDevice, GetCaptureContextInteger, int, out int)"/>
        ///
        /// When the application determines that enough samples are available for processing, then it can obtain them
        /// with a call to <see cref="CaptureSamples{TBuffer}(ALCaptureDevice, TBuffer[], int)"/>.
        ///
        /// </summary>
        /// <param name="device">The device.</param>
        [DllImport(ALC.Lib, EntryPoint = "alcCaptureStart", ExactSpelling = true, CallingConvention = ALC.AlcCalliningConv)]
        public static extern void CaptureStart(ALCaptureDevice device);

        /// <summary>
        /// Stops a capture operation.
        /// </summary>
        /// <param name="device">The device.</param>
        [DllImport(ALC.Lib, EntryPoint = "alcCaptureStop", ExactSpelling = true, CallingConvention = ALC.AlcCalliningConv)]
        public static extern void CaptureStop(ALCaptureDevice device);

        /// <summary>
        /// Completes a capture operation. This call does not block.
        /// </summary>
        /// <param name="device">The device.</param>
        /// <param name="buffer">The buffer to fill with data.</param>
        /// <param name="sampleCount">The number of samples to retrieve.</param>
        [DllImport(ALC.Lib, EntryPoint = "alcCaptureSamples", ExactSpelling = true, CallingConvention = ALC.AlcCalliningConv)]
        public static extern void CaptureSamples(ALCaptureDevice device, IntPtr buffer, int sampleCount);

        /// <summary>
        /// Completes a capture operation. This call does not block.
        /// </summary>
        /// <param name="device">The device.</param>
        /// <param name="buffer">The buffer to fill with data.</param>
        /// <param name="sampleCount">The number of samples to retrieve.</param>
        [DllImport(ALC.Lib, EntryPoint = "alcCaptureSamples", ExactSpelling = true, CallingConvention = ALC.AlcCalliningConv)]
        public static extern unsafe void CaptureSamples(ALCaptureDevice device, void* buffer, int sampleCount);

        /// <summary>
        /// Completes a capture operation. This call does not block.
        /// </summary>
        /// <param name="device">The device.</param>
        /// <param name="buffer">The buffer to fill with data.</param>
        /// <param name="sampleCount">The number of samples to retrieve.</param>
        [DllImport(ALC.Lib, EntryPoint = "alcCaptureSamples", ExactSpelling = true, CallingConvention = ALC.AlcCalliningConv)]
        public static extern void CaptureSamples(ALCaptureDevice device, ref byte buffer, int sampleCount);

        /// <summary>
        /// Completes a capture operation. This call does not block.
        /// </summary>
        /// <param name="device">The device.</param>
        /// <param name="buffer">The buffer to fill with data.</param>
        /// <param name="sampleCount">The number of samples to retrieve.</param>
        [DllImport(ALC.Lib, EntryPoint = "alcCaptureSamples", ExactSpelling = true, CallingConvention = ALC.AlcCalliningConv)]
        public static extern void CaptureSamples(ALCaptureDevice device, ref short buffer, int sampleCount);

        /// <summary>
        /// Completes a capture operation. This call does not block.
        /// </summary>
        /// <typeparam name="TBuffer">The buffer array type.</typeparam>
        /// <param name="device">The device.</param>
        /// <param name="buffer">The buffer to fill with data.</param>
        /// <param name="sampleCount">The number of samples to retrieve.</param>
        public static void CaptureSamples<TBuffer>(ALCaptureDevice device, TBuffer[] buffer, int sampleCount)
            where TBuffer : unmanaged
        {
            GCHandle handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
            try
            {
                CaptureSamples(device, handle.AddrOfPinnedObject(), sampleCount);
            }
            finally
            {
                handle.Free();
            }
        }

#if NETCOREAPP3_1
        /// <summary>
        /// Completes a capture operation. This call does not block.
        /// </summary>
        /// <typeparam name="TBuffer">The buffer array type.</typeparam>
        /// <param name="device">The device.</param>
        /// <param name="buffer">The buffer to fill with data.</param>
        /// <param name="sampleCount">The number of samples to retrieve.</param>
        public static void CaptureSamples<TBuffer>(ALCaptureDevice device, Span<TBuffer> buffer, int sampleCount)
            where TBuffer : unmanaged
        {
            // This is the only reason this is NETCOREAPP3_1 dependent
            var bytes = MemoryMarshal.AsBytes(buffer);
            CaptureSamples(device, ref bytes[0], sampleCount);
        }
#endif

        /// <summary>
        /// Gets a named value from the state.
        /// </summary>
        /// <param name="device">The device.</param>
        /// <param name="param">The name of the value to retrieve.</param>
        /// <param name="count">The size of the output buffer.</param>
        /// <param name="data">The output buffer.</param>
        // FXIME!!! Should this function really be called "GetContextProperty" and not just "Get" like in AL.cs
        [DllImport(ALC.Lib, EntryPoint = "alcGetIntegerv", ExactSpelling = true, CallingConvention = ALC.AlcCalliningConv)]
        public static extern unsafe void GetContextProperty(ALCaptureDevice device, GetCaptureContextInteger param, int count, int* data);

        /// <summary>
        /// Gets a named value from the state.
        /// </summary>
        /// <param name="device">The device.</param>
        /// <param name="param">The name of the value to retrieve.</param>
        /// <param name="count">The size of the output buffer.</param>
        /// <param name="data">The output buffer.</param>
        // FXIME!!! Should this function really be called "GetContextProperty" and not just "Get" like in AL.cs
        [DllImport(ALC.Lib, EntryPoint = "alcGetIntegerv", ExactSpelling = true, CallingConvention = ALC.AlcCalliningConv)]
        public static extern void GetContextProperty(ALCaptureDevice device, GetCaptureContextInteger param, int count, out int data);

        /// <inheritdoc cref="GetContextProperty(ALCaptureDevice, GetCaptureContextInteger, int, out int)"/>
        public static int GetAvailableSamples(ALCaptureDevice device)
        {
            GetContextProperty(device, GetCaptureContextInteger.CaptureSamples, 1, out int result);
            return result;
        }
    }
}
