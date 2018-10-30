﻿//
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
using System.Collections.Generic;
using System.Linq;
using OpenTK.Core;
using OpenTK.Core.Loader;

namespace OpenTK.OpenAL
{
    /// <summary>
    /// Provides methods to instantiate, use and destroy an audio context for playback.
    /// Static methods are provided to list available devices known by the driver.
    /// </summary>
    public sealed class AudioContext : IDisposable
    {
        private static readonly ALContext ContextAPI = APILoader.Load<ALContext, OpenALLibraryNameContainer>();

        private static readonly object AudioContextLock = new object();

        private static readonly Dictionary<ContextHandle, AudioContext> AvailableContexts =
            new Dictionary<ContextHandle, AudioContext>();

        private bool _contextExists;
        private ContextHandle _contextHandle;

        private string _deviceName;
        private bool _disposed;
        private bool _isProcessing;
        private bool _isSynchronized;

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioContext"/> class using the default audio device.
        /// </summary>
        public AudioContext()
            : this(null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioContext"/> class using the specified audio device and
        /// device parameters.
        /// </summary>
        /// <param name="device">The name of the audio device to use.</param>
        /// <param name="freq">Frequency for mixing output buffer, in units of Hz. Pass 0 for driver default.</param>
        /// <remarks>
        /// Use AudioContext.AvailableDevices to obtain a list of all available audio devices.
        /// devices.
        /// </remarks>
        public AudioContext(string device, int freq)
            : this(device, freq, 0, false)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioContext"/> class using the specified audio device and
        /// device parameters.
        /// </summary>
        /// <param name="device">The name of the audio device to use.</param>
        /// <param name="freq">Frequency for mixing output buffer, in units of Hz. Pass 0 for driver default.</param>
        /// <param name="refresh">Refresh intervals, in units of Hz. Pass 0 for driver default.</param>
        /// <remarks>
        /// Use AudioContext.AvailableDevices to obtain a list of all available audio devices.
        /// devices.
        /// </remarks>
        public AudioContext(string device, int freq, int refresh)
            : this(device, freq, refresh, false)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioContext"/> class using the specified audio device and
        /// device parameters.
        /// </summary>
        /// <param name="device">The device descriptor obtained through AudioContext.AvailableDevices.</param>
        /// <param name="freq">Frequency for mixing output buffer, in units of Hz. Pass 0 for driver default.</param>
        /// <param name="refresh">Refresh intervals, in units of Hz. Pass 0 for driver default.</param>
        /// <param name="sync">Flag, indicating a synchronous context.</param>
        /// <exception cref="ArgumentNullException">Occurs when the device string is invalid.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Occurs when a specified parameter is invalid.</exception>
        /// <exception cref="AudioDeviceException">
        /// Occurs when the specified device is not available, or is in use by another program.
        /// </exception>
        /// <exception cref="AudioContextException">
        /// Occurs when an audio context could not be created with the specified parameters.
        /// </exception>
        /// <exception cref="NotSupportedException">
        /// Occurs when an AudioContext already exists.
        /// </exception>
        /// <remarks>
        ///  <para>For maximum compatibility, you are strongly recommended to use the default constructor.</para>
        ///  <para>Multiple AudioContexts are not supported at this point.</para>
        ///  <para>
        /// The number of auxiliary EFX sends depends on the audio hardware and drivers. Most Realtek devices, as well
        /// as the Creative SB Live!, support 1 auxiliary send. Creative's Audigy and X-Fi series support 4 sends.
        /// Values higher than supported will be clamped by the driver.
        ///  </para>
        /// </remarks>
        public AudioContext(string device, int freq = 0, int refresh = 0, bool sync = false)
        {
            CreateContext(device, freq, refresh, sync);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioContext"/> class using the specified audio device and
        /// device parameters.
        /// </summary>
        /// <param name="device">The device descriptor obtained through AudioContext.AvailableDevices.</param>
        /// <param name="attributes">The context attributes to use.</param>
        /// <exception cref="ArgumentNullException">Occurs when the device string is invalid.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Occurs when a specified parameter is invalid.</exception>
        /// <exception cref="AudioDeviceException">
        /// Occurs when the specified device is not available, or is in use by another program.
        /// </exception>
        /// <exception cref="AudioContextException">
        /// Occurs when an audio context could not be created with the specified parameters.
        /// </exception>
        /// <exception cref="NotSupportedException">
        /// Occurs when an AudioContext already exists.
        /// </exception>
        /// <remarks>
        /// For maximum compatibility, you are strongly recommended to use the default constructor.<para/>
        /// Multiple AudioContexts are not supported at this point.<para/>
        /// </remarks>
        public AudioContext
        (
            string device,
            IEnumerable<int> attributes
        )
        {
            CreateContext(device, attributes);
        }

        /// <summary>
        /// Gets or sets a value indicating whether the <see cref="AudioContext"/> is current.
        /// </summary>
        /// <remarks>
        /// Only one <see cref="AudioContext"/> can be current in the application at any time,
        /// <b>regardless of the number of threads</b>.
        /// </remarks>
        internal bool IsCurrent
        {
            get
            {
                lock (AudioContextLock)
                {
                    if (AvailableContexts.Count == 0)
                    {
                        return false;
                    }

                    return CurrentContext == this;
                }
            }

            set => MakeCurrent(value ? this : null);
        }

        private unsafe Device* Device { get; set; }

        /// <summary>
        /// Gets the ALC error code for this instance.
        /// </summary>
        public ContextError CurrentError
        {
            get
            {
                if (_disposed)
                {
                    throw new ObjectDisposedException(GetType().FullName);
                }

                unsafe
                {
                    return ContextAPI.GetError(Device);
                }
            }
        }

        /// <summary>
        /// Gets a value indicating whether the AudioContext is
        /// currently processing audio events.
        /// </summary>
        /// <seealso cref="Process" />
        /// <seealso cref="Suspend" />
        public bool IsProcessing
        {
            get
            {
                if (_disposed)
                {
                    throw new ObjectDisposedException(GetType().FullName);
                }

                return _isProcessing;
            }
            private set => _isProcessing = value;
        }

        /// <summary>
        /// Gets a value indicating whether the AudioContext is
        /// synchronized.
        /// </summary>
        /// <seealso cref="Process" />
        public bool IsSynchronized
        {
            get
            {
                if (_disposed)
                {
                    throw new ObjectDisposedException(GetType().FullName);
                }

                return _isSynchronized;
            }
            private set => _isSynchronized = value;
        }

        /// <summary>
        /// Gets a System.String with the name of the device used in this context.
        /// </summary>
        public string CurrentDevice
        {
            get
            {
                if (_disposed)
                {
                    throw new ObjectDisposedException(GetType().FullName);
                }

                return _deviceName;
            }
        }

        /// <summary>
        /// Gets the OpenTK.Audio.AudioContext which is current in the application.
        /// </summary>
        /// <remarks>
        /// Only one AudioContext can be current in the application at any time,
        ///  <b>regardless of the number of threads</b>.
        /// </remarks>
        public static AudioContext CurrentContext
        {
            get
            {
                lock (AudioContextLock)
                {
                    if (AvailableContexts.Count == 0)
                    {
                        return null;
                    }

                    AvailableContexts.TryGetValue(ContextAPI.GetCurrentContextHandle(), out var context);
                    return context;
                }
            }
        }

        /// <summary>
        /// Creates the audio context using the specified device.
        /// </summary>
        /// <param name="device">
        /// The device descriptor obtained through AudioContext.AvailableDevices, or null for the default
        /// device.
        /// </param>
        /// <param name="frequency">Frequency for mixing output buffer, in units of Hz. Pass 0 for driver default.</param>
        /// <param name="refreshRate">Refresh intervals, in units of Hz. Pass 0 for driver default.</param>
        /// <param name="isSynchronous">Flag, indicating a synchronous context.</param>
        /// <exception cref="ArgumentOutOfRangeException">Occurs when a specified parameter is invalid.</exception>
        /// <exception cref="AudioDeviceException">
        /// Occurs when the specified device is not available, or is in use by another program.
        /// </exception>
        /// <exception cref="AudioContextException">
        /// Occurs when an audio context could not be created with the specified parameters.
        /// </exception>
        /// <exception cref="NotSupportedException">
        /// Occurs when an AudioContext already exists.
        /// </exception>
        /// <remarks>
        ///  <para>For maximum compatibility, you are strongly recommended to use the default constructor.</para>
        ///  <para>Multiple AudioContexts are not supported at this point.</para>
        /// </remarks>
        private void CreateContext(string device, int frequency, int refreshRate, bool isSynchronous)
        {
            if (frequency < 0)
            {
                throw new ArgumentOutOfRangeException
                (
                    nameof(frequency),
                    frequency,
                    "The frequency must be greater than zero"
                );
            }

            if (refreshRate < 0)
            {
                throw new ArgumentOutOfRangeException
                (
                    nameof(refreshRate),
                    refreshRate,
                    "The refresh rate must be greater than zero."
                );
            }

            // Build the attribute list
            var attributes = new List<int>();

            if (frequency != 0)
            {
                attributes.Add((int)ContextAttributes.Frequency);
                attributes.Add(frequency);
            }

            if (refreshRate != 0)
            {
                attributes.Add((int)ContextAttributes.Refresh);
                attributes.Add(refreshRate);
            }

            attributes.Add((int)ContextAttributes.Sync);
            attributes.Add(isSynchronous ? 1 : 0);

            attributes.Add(0);

            CreateContext(device, attributes);
        }

        /// <summary>
        /// Creates the audio context using the specified device.
        /// </summary>
        /// <param name="device">
        /// The device descriptor obtained through AudioContext.AvailableDevices, or null for the default
        /// device.
        /// </param>
        /// <param name="attributes">The attributes to use.</param>
        /// <exception cref="ArgumentOutOfRangeException">Occurs when a specified parameter is invalid.</exception>
        /// <exception cref="AudioDeviceException">
        /// Occurs when the specified device is not available, or is in use by another program.
        /// </exception>
        /// <exception cref="AudioContextException">
        /// Occurs when an audio context could not be created with the specified parameters.
        /// </exception>
        /// <exception cref="NotSupportedException">
        /// Occurs when an AudioContext already exists.
        /// </exception>
        /// <remarks>
        ///  <para>For maximum compatibility, you are strongly recommended to use the default constructor.</para>
        ///  <para>Multiple AudioContexts are not supported at this point.</para>
        /// </remarks>
        private unsafe void CreateContext
        (
            string device,
            IEnumerable<int> attributes
        )
        {
            if (_contextExists)
            {
                throw new NotSupportedException("Multiple AudioContexts are not supported.");
            }

            if (!string.IsNullOrEmpty(device))
            {
                _deviceName = device;
                Device = ContextAPI.OpenDevice(device); // try to open device by name
            }

            if (Device == null)
            {
                _deviceName = "IntPtr.Zero (null string)";
                Device = ContextAPI.OpenDevice(null); // try to open unnamed default device
            }

            if (Device == null)
            {
                _deviceName = "None";
                throw new AudioDeviceException
                (
                    $"Audio device '{(string.IsNullOrEmpty(device) ? "default" : device)}' does not exist or" +
                    "is tied up by another application."
                );
            }

            CheckErrors();

            fixed (int* ptr = attributes.ToArray())
            {
                _contextHandle = ContextAPI.CreateContextHandle(Device, ptr);
            }

            if (_contextHandle == ContextHandle.Zero)
            {
                ContextAPI.CloseDevice(Device);
                throw new AudioContextException
                (
                    "The audio context could not be created with the specified parameters."
                );
            }

            CheckErrors();

            MakeCurrent();

            CheckErrors();

            _deviceName = ContextAPI.GetContextProperty(Device, GetContextString.DeviceSpecifier);

            lock (AudioContextLock)
            {
                AvailableContexts.Add(_contextHandle, this);
                _contextExists = true;
            }
        }

        /// \internal
        /// <summary>
        /// Makes the specified AudioContext current in the calling thread.
        /// </summary>
        /// <param name="context">The OpenTK.Audio.AudioContext to make current, or null.</param>
        /// <exception cref="ObjectDisposedException">
        /// Occurs if this function is called after the AudioContext has been disposed.
        /// </exception>
        /// <exception cref="AudioContextException">
        /// Occurs when the AudioContext could not be made current.
        /// </exception>
        private static void MakeCurrent(AudioContext context)
        {
            lock (AudioContextLock)
            {
                unsafe
                {
                    var contextHandle = context?._contextHandle ?? ContextHandle.Zero;
                    if (!ContextAPI.MakeContextCurrent(contextHandle))
                    {
                        var contextPtr = (Context*)contextHandle.Handle;
                        var deviceHandle = ContextAPI.GetContextsDevice(contextPtr);
                        var error = ContextAPI.GetError(deviceHandle);

                        throw new AudioContextException
                        (
                            $"ALC {error} error detected at {(context != null ? context.ToString() : "null")}."
                        );
                    }
                }
            }
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
            if (_disposed)
            {
                throw new ObjectDisposedException(GetType().FullName);
            }

            unsafe
            {
                new AudioDeviceErrorChecker(Device).Dispose();
            }
        }

        /// <summary>
        /// Makes the AudioContext current in the calling thread.
        /// </summary>
        /// <exception cref="ObjectDisposedException">
        /// Occurs if this function is called after the AudioContext has been disposed.
        /// </exception>
        /// <exception cref="AudioContextException">
        /// Occurs when the AudioContext could not be made current.
        /// </exception>
        /// <remarks>
        /// Only one AudioContext can be current in the application at any time,
        ///  <b>regardless of the number of threads</b>.
        /// </remarks>
        public void MakeCurrent()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(GetType().FullName);
            }

            MakeCurrent(this);
        }

        /// <summary>
        /// Processes queued audio events.
        /// </summary>
        /// <remarks>
        ///  <para>
        /// If AudioContext.IsSynchronized is true, this function will resume
        /// the internal audio processing thread. If AudioContext.IsSynchronized is false,
        /// you will need to call this function multiple times per second to process
        /// audio events.
        ///  </para>
        ///  <para>
        /// In some implementations this function may have no effect.
        ///  </para>
        /// </remarks>
        /// <exception cref="ObjectDisposedException">Occurs when this function is called after the AudioContext had been disposed.</exception>
        /// <seealso cref="Suspend" />
        /// <seealso cref="IsProcessing" />
        /// <seealso cref="IsSynchronized" />
        public void Process()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(GetType().FullName);
            }

            unsafe
            {
                ContextAPI.ProcessContext((Context*)_contextHandle.Handle);
            }

            IsProcessing = true;
        }

        /// <summary>
        /// Suspends processing of audio events.
        /// </summary>
        /// <remarks>
        ///  <para>
        /// To avoid audio artifacts when calling this function, set audio gain to zero before
        /// suspending an AudioContext.
        ///  </para>
        ///  <para>
        /// In some implementations, it can be faster to suspend processing before changing
        /// AudioContext state.
        ///  </para>
        ///  <para>
        /// In some implementations this function may have no effect.
        ///  </para>
        /// </remarks>
        /// <exception cref="ObjectDisposedException">Occurs when this function is called after the AudioContext had been disposed.</exception>
        /// <seealso cref="Process" />
        /// <seealso cref="IsProcessing" />
        /// <seealso cref="IsSynchronized" />
        public void Suspend()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(GetType().FullName);
            }

            unsafe
            {
                ContextAPI.SuspendContext((Context*)_contextHandle.Handle);
            }

            IsProcessing = false;
        }

        /// <summary>
        /// Checks whether the specified OpenAL extension is supported.
        /// </summary>
        /// <param name="extension">The name of the extension to check (e.g. "ALC_EXT_EFX").</param>
        /// <returns>true if the extension is supported; false otherwise.</returns>
        public bool SupportsExtension(string extension)
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(GetType().FullName);
            }

            unsafe
            {
                return ContextAPI.IsExtensionPresent(Device, extension);
            }
        }

        /// <inheritdoc />
        public void Dispose()
        {
            if (!_disposed)
            {
                if (IsCurrent)
                {
                    IsCurrent = false;
                }

                if (_contextHandle != ContextHandle.Zero)
                {
                    AvailableContexts.Remove(_contextHandle);

                    unsafe
                    {
                        ContextAPI.DestroyContext((Context*)_contextHandle.Handle);
                    }
                }

                unsafe
                {
                    if (Device != null)
                    {
                        ContextAPI.CloseDevice(Device);
                    }
                }
                _disposed = true;
            }
        }

        /// <summary>
        /// Finalizes an instance of the <see cref="AudioContext"/> class.
        /// </summary>
        ~AudioContext()
        {
            Dispose();
        }

        /// <summary>
        /// Returns a <see cref="string" /> that desrcibes this instance.
        /// </summary>
        /// <returns>A <see cref="string" /> that desrcibes this instance.</returns>
        public override string ToString()
        {
            unsafe
            {
                return $"{_deviceName} (handle: {_contextHandle}, device: {(long)Device})";
            }
        }
    }
}
