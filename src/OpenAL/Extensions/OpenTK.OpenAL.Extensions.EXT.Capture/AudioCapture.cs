//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2009 the Open Toolkit library.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//

using System;

namespace OpenTK.OpenAL.Extensions.EXT.Capture
{
    /// <summary>
    /// Provides methods to instantiate, use and destroy an audio device for recording.
    /// </summary>
    /// <typeparam name="TBufferFormat">The buffer format of the capture.</typeparam>
    public sealed class AudioCapture<TBufferFormat> : IDisposable
        where TBufferFormat : struct, Enum
    {
        private readonly unsafe Device* _handle;

        private readonly Capture _captureAPI;

        private bool _isDisposed;

        /// <summary>
        /// Gets the name of the device associated with this instance.
        /// </summary>
        public string CurrentDevice { get; }

        /// <summary>
        /// Gets the number of available samples for capture.
        /// </summary>
        public int AvailableSamples
        {
            get
            {
                unsafe
                {
                    return _captureAPI.GetAvailableSamples(_handle);
                }
            }
        }

        /// <summary>
        /// Gets the OpenTK.Audio.BufferFormat for this instance.
        /// </summary>
        public TBufferFormat SampleFormat { get; }

        /// <summary>
        /// Gets the sampling rate for this instance.
        /// </summary>
        public uint SampleFrequency { get; }

        /// <summary>
        /// Gets a value indicating whether this instance is currently capturing samples.
        /// </summary>
        public bool IsRunning { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioCapture{TBufferFormat}"/> class that opens a device for audio recording.
        /// </summary>
        /// <param name="captureAPI">The capture API instance to use.</param>
        /// <param name="deviceName">The device name.</param>
        /// <param name="frequency">The frequency that the data should be captured at.</param>
        /// <param name="sampleFormat">The requested capture buffer format.</param>
        /// <param name="bufferSize">
        /// The size of OpenAL's capture internal ring-buffer. This value expects number of samples, not
        /// bytes.
        /// </param>
        public unsafe AudioCapture
        (
            Capture captureAPI,
            string deviceName = null,
            uint frequency = 22050,
            TBufferFormat? sampleFormat = null,
            int bufferSize = 4096
        )
        {
            if (frequency <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(frequency));
            }

            if (bufferSize <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(bufferSize));
            }

            var actualSampleFormat = sampleFormat ?? (TBufferFormat)(object)BufferFormat.Mono16;

            _captureAPI = captureAPI;

            // Try to open specified device. If it fails, try to open default device.
            CurrentDevice = deviceName;

            _handle = _captureAPI.CaptureOpenDevice(deviceName, frequency, actualSampleFormat, bufferSize);

            if (_handle == null)
            {
                CurrentDevice = "IntPtr.Zero";
                _handle = _captureAPI.CaptureOpenDevice(null, frequency, actualSampleFormat, bufferSize);
            }

            if (_handle == null)
            {
                // Everything we tried failed. Capture may not be supported, bail out.
                CurrentDevice = "None";

                throw new AudioDeviceException
                (
                    "All attempts to open capture devices returned IntPtr.Zero. See debug log for verbose list."
                );
            }

            // handle is not null, check for some Alc Error
            CheckErrors();

            SampleFormat = actualSampleFormat;
            SampleFrequency = frequency;
        }

        /// <summary>
        /// Checks for ALC error conditions.
        /// </summary>
        /// <exception cref="OutOfMemoryException">Raised when an out of memory error is detected.</exception>
        /// <exception cref="AudioValueException">Raised when an invalid value is detected.</exception>
        /// <exception cref="AudioDeviceException">Raised when an invalid device is detected.</exception>
        /// <exception cref="AudioContextException">Raised when an invalid context is detected.</exception>
        public void CheckErrors()
        {
            unsafe
            {
                new AudioDeviceErrorChecker(_handle).Dispose();
            }
        }

        /// <summary>
        /// Start recording samples.
        /// The number of available samples can be obtained through the <see cref="AvailableSamples" /> property.
        /// The data can be queried with any <see cref="CaptureSamples" /> method.
        /// </summary>
        public void Start()
        {
            unsafe
            {
                _captureAPI.CaptureStart(_handle);
            }

            IsRunning = true;
        }

        /// <summary>
        /// Stop recording samples. This will not clear previously recorded samples.
        /// </summary>
        public void Stop()
        {
            unsafe
            {
                _captureAPI.CaptureStop(_handle);
            }

            IsRunning = false;
        }

        /// <summary>
        /// Fills the specified buffer with samples from the internal capture ring-buffer. This method does not block: it
        /// is an error to specify a sampleCount larger than AvailableSamples.
        /// </summary>
        /// <param name="buffer">A pointer to a previously initialized and pinned array.</param>
        /// <param name="sampleCount">The number of samples to be written to the buffer.</param>
        public unsafe void CaptureSamples(void* buffer, int sampleCount)
        {
            _captureAPI.CaptureSamples(_handle, buffer, sampleCount);
        }

        /// <summary>
        /// Fills the specified buffer with samples from the internal capture ring-buffer. This method does not block:
        /// it is an error to specify a sampleCount larger than AvailableSamples.
        /// </summary>
        /// <typeparam name="TManagedFormat">The type of the buffer.</typeparam>
        /// <param name="sampleCount">The number of samples to be written to the buffer.</param>
        /// <param name="buffer">The buffer to fill.</param>
        /// <exception cref="ArgumentNullException">Raised when buffer is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Raised when sampleCount is larger than the buffer.</exception>
        public void CaptureSamples<TManagedFormat>(int sampleCount, in TManagedFormat[] buffer)
            where TManagedFormat : unmanaged
        {
            if (buffer == null)
            {
                throw new ArgumentNullException(nameof(buffer));
            }

            unsafe
            {
                _captureAPI.CaptureSamples(_handle, SampleFormat, sampleCount, in buffer);
            }
        }

        /// <summary>
        /// Finalizes an instance of the <see cref="AudioCapture{T}"/> class.
        /// </summary>
        ~AudioCapture()
        {
            Dispose();
        }

        /// <inheritdoc />
        public void Dispose()
        {
            if (_isDisposed)
            {
                return;
            }

            unsafe
            {
                if (_handle != null)
                {
                    if (IsRunning)
                    {
                        Stop();
                    }

                    _captureAPI.CaptureCloseDevice(_handle);
                }
            }

            _isDisposed = true;
        }
    }
}
