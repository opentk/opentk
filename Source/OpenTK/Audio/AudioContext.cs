#region License
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
#endregion


using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

using OpenTK.Audio;

namespace OpenTK.Audio
{
    /// <summary>
    /// Provides methods to instantiate, use and destroy an audio context for playback.
    /// Static methods are provided to list available devices known by the driver.
    /// </summary>
    public sealed class AudioContext : IDisposable
    {
        #region --- Fields ---

        bool disposed;
        bool is_processing, is_synchronized;
        IntPtr device_handle;
        ContextHandle context_handle;
        bool context_exists;

        string device_name;
        static object audio_context_lock = new object();
        static Dictionary<ContextHandle, AudioContext> available_contexts = new Dictionary<ContextHandle, AudioContext>();

        #endregion

        #region --- Constructors ---

        #region static AudioContext()

        /// <private />
        /// <static />
        /// <summary>
        /// Runs before the actual class constructor, to load available devices.
        /// </summary>
        static AudioContext()
        {
            if (AudioDeviceEnumerator.IsOpenALSupported) // forces enumeration
            { }
        }

        #endregion static AudioContext()

        #region public AudioContext()

        /// <summary>Constructs a new AudioContext, using the default audio device.</summary>
        public AudioContext()
            : this(null, 0, 0, false, true, MaxAuxiliarySends.UseDriverDefault) { }

        #endregion

        #region public AudioContext(string device)

        public AudioContext(string device) : this(device, 0, 0, false, true, MaxAuxiliarySends.UseDriverDefault) { }

        #endregion

        #region public AudioContext(string device, int freq)

        /// <summary>Constructs a new AudioContext, using the specified audio device and device parameters.</summary>
        /// <param name="device">The name of the audio device to use.</param>
        /// <param name="freq">Frequency for mixing output buffer, in units of Hz. Pass 0 for driver default.</param>
        /// <remarks>
        /// Use AudioContext.AvailableDevices to obtain a list of all available audio devices.
        /// devices.
        /// </remarks>
        public AudioContext(string device, int freq) : this(device, freq, 0, false, true, MaxAuxiliarySends.UseDriverDefault) { }

        #endregion

        #region public AudioContext(string device, int freq, int refresh)

        /// <summary>Constructs a new AudioContext, using the specified audio device and device parameters.</summary>
        /// <param name="device">The name of the audio device to use.</param>
        /// <param name="freq">Frequency for mixing output buffer, in units of Hz. Pass 0 for driver default.</param>
        /// <param name="refresh">Refresh intervals, in units of Hz. Pass 0 for driver default.</param>
        /// <remarks>
        /// Use AudioContext.AvailableDevices to obtain a list of all available audio devices.
        /// devices.
        /// </remarks>
        public AudioContext(string device, int freq, int refresh)
            : this(device, freq, refresh, false, true, MaxAuxiliarySends.UseDriverDefault) { }

        #endregion

        #region public AudioContext(string device, int freq, int refresh, bool sync)

        /// <summary>Constructs a new AudioContext, using the specified audio device and device parameters.</summary>
        /// <param name="device">The name of the audio device to use.</param>
        /// <param name="freq">Frequency for mixing output buffer, in units of Hz. Pass 0 for driver default.</param>
        /// <param name="refresh">Refresh intervals, in units of Hz. Pass 0 for driver default.</param>
        /// <param name="sync">Flag, indicating a synchronous context.</param>
        /// <remarks>
        /// Use AudioContext.AvailableDevices to obtain a list of all available audio devices.
        /// devices.
        /// </remarks>
        public AudioContext(string device, int freq, int refresh, bool sync)
            : this(AudioDeviceEnumerator.AvailablePlaybackDevices[0], freq, refresh, sync, true) { }

        #endregion

        #region public AudioContext(string device, int freq, int refresh, bool sync, bool enableEfx)

        /// <summary>Creates the audio context using the specified device and device parameters.</summary>
        /// <param name="device">The device descriptor obtained through AudioContext.AvailableDevices.</param>
        /// <param name="freq">Frequency for mixing output buffer, in units of Hz. Pass 0 for driver default.</param>
        /// <param name="refresh">Refresh intervals, in units of Hz. Pass 0 for driver default.</param>
        /// <param name="sync">Flag, indicating a synchronous context.</param>
        /// <param name="enableEfx">Indicates whether the EFX extension should be initialized, if present.</param>
        /// <exception cref="ArgumentNullException">Occurs when the device string is invalid.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Occurs when a specified parameter is invalid.</exception>
        /// <exception cref="AudioDeviceException">
        /// Occurs when the specified device is not available, or is in use by another program.
        /// </exception>
        /// <exception cref="AudioContextException">
        /// Occurs when an audio context could not be created with the specified parameters.
        /// </exception>
        /// <exception cref="NotSupportedException">
        /// Occurs when an AudioContext already exists.</exception>
        /// <remarks>
        /// <para>For maximum compatibility, you are strongly recommended to use the default constructor.</para>
        /// <para>Multiple AudioContexts are not supported at this point.</para>
        /// <para>
        /// The number of auxilliary EFX sends depends on the audio hardware and drivers. Most Realtek devices, as well
        /// as the Creative SB Live!, support 1 auxilliary send. Creative's Audigy and X-Fi series support 4 sends.
        /// Values higher than supported will be clamped by the driver.
        /// </para>
        /// </remarks>
        public AudioContext(string device, int freq, int refresh, bool sync, bool enableEfx)
        {
            CreateContext(device, freq, refresh, sync, enableEfx, MaxAuxiliarySends.UseDriverDefault);
        }

        #endregion

        #region public AudioContext(string device, int freq, int refresh, bool sync, bool enableEfx, MaxAuxiliarySends efxMaxAuxSends)

        /// <summary>Creates the audio context using the specified device and device parameters.</summary>
        /// <param name="device">The device descriptor obtained through AudioContext.AvailableDevices.</param>
        /// <param name="freq">Frequency for mixing output buffer, in units of Hz. Pass 0 for driver default.</param>
        /// <param name="refresh">Refresh intervals, in units of Hz. Pass 0 for driver default.</param>
        /// <param name="sync">Flag, indicating a synchronous context.</param>
        /// <param name="enableEfx">Indicates whether the EFX extension should be initialized, if present.</param>
        /// <param name="efxMaxAuxSends">Requires EFX enabled. The number of desired Auxiliary Sends per source.</param>
        /// <exception cref="ArgumentNullException">Occurs when the device string is invalid.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Occurs when a specified parameter is invalid.</exception>
        /// <exception cref="AudioDeviceException">
        /// Occurs when the specified device is not available, or is in use by another program.
        /// </exception>
        /// <exception cref="AudioContextException">
        /// Occurs when an audio context could not be created with the specified parameters.
        /// </exception>
        /// <exception cref="NotSupportedException">
        /// Occurs when an AudioContext already exists.</exception>
        /// <remarks>
        /// <para>For maximum compatibility, you are strongly recommended to use the default constructor.</para>
        /// <para>Multiple AudioContexts are not supported at this point.</para>
        /// <para>
        /// The number of auxilliary EFX sends depends on the audio hardware and drivers. Most Realtek devices, as well
        /// as the Creative SB Live!, support 1 auxilliary send. Creative's Audigy and X-Fi series support 4 sends.
        /// Values higher than supported will be clamped by the driver.
        /// </para>
        /// </remarks>
        public AudioContext(string device, int freq, int refresh, bool sync, bool enableEfx, MaxAuxiliarySends efxMaxAuxSends)
        {
            CreateContext(device, freq, refresh, sync, enableEfx, efxMaxAuxSends);
        }

        #endregion

        #endregion --- Constructors ---

        #region --- Private Methods ---

        #region CreateContext

        /// <summary>May be passed at context construction time to indicate the number of desired auxiliary effect slot sends per source.</summary>
        public enum MaxAuxiliarySends:int
        {
            /// <summary>Will chose a reliably working parameter.</summary>
            UseDriverDefault = 0,
            /// <summary>One send per source.</summary>
            One = 1,
            /// <summary>Two sends per source.</summary>
            Two = 2,
            /// <summary>Three sends per source.</summary>
            Three = 3,
            /// <summary>Four sends per source.</summary>
            Four = 4,
        }

        /// <private />
        /// <summary>Creates the audio context using the specified device.</summary>
        /// <param name="device">The device descriptor obtained through AudioContext.AvailableDevices, or null for the default device.</param>
        /// <param name="freq">Frequency for mixing output buffer, in units of Hz. Pass 0 for driver default.</param>
        /// <param name="refresh">Refresh intervals, in units of Hz. Pass 0 for driver default.</param>
        /// <param name="sync">Flag, indicating a synchronous context.</param>
        /// <param name="enableEfx">Indicates whether the EFX extension should be initialized, if present.</param>
        /// <param name="efxAuxiliarySends">Requires EFX enabled. The number of desired Auxiliary Sends per source.</param>
        /// <exception cref="ArgumentOutOfRangeException">Occurs when a specified parameter is invalid.</exception>
        /// <exception cref="AudioDeviceException">
        /// Occurs when the specified device is not available, or is in use by another program.
        /// </exception>
        /// <exception cref="AudioContextException">
        /// Occurs when an audio context could not be created with the specified parameters.
        /// </exception>
        /// <exception cref="NotSupportedException">
        /// Occurs when an AudioContext already exists.</exception>
        /// <remarks>
        /// <para>For maximum compatibility, you are strongly recommended to use the default constructor.</para>
        /// <para>Multiple AudioContexts are not supported at this point.</para>
        /// <para>
        /// The number of auxilliary EFX sends depends on the audio hardware and drivers. Most Realtek devices, as well
        /// as the Creative SB Live!, support 1 auxilliary send. Creative's Audigy and X-Fi series support 4 sends.
        /// Values higher than supported will be clamped by the driver.
        /// </para>
        /// </remarks>
        void CreateContext(string device, int freq, int refresh, bool sync, bool enableEfx, MaxAuxiliarySends efxAuxiliarySends)
        {
            if (!AudioDeviceEnumerator.IsOpenALSupported)
                throw new DllNotFoundException("openal32.dll");

            if (AudioDeviceEnumerator.Version == AudioDeviceEnumerator.AlcVersion.Alc1_1 && AudioDeviceEnumerator.AvailablePlaybackDevices.Count == 0)    // Alc 1.0 does not support device enumeration.
                throw new NotSupportedException("No audio hardware is available.");
            if (context_exists) throw new NotSupportedException("Multiple AudioContexts are not supported.");
            if (freq < 0) throw new ArgumentOutOfRangeException("freq", freq, "Should be greater than zero.");
            if (refresh < 0) throw new ArgumentOutOfRangeException("refresh", refresh, "Should be greater than zero.");


            if (!String.IsNullOrEmpty(device))
            {
                device_name = device;
                device_handle = Alc.OpenDevice(device); // try to open device by name
            }
            if (device_handle == IntPtr.Zero)
            {
                device_name = "IntPtr.Zero (null string)";
                device_handle = Alc.OpenDevice(null); // try to open unnamed default device
            }
            if (device_handle == IntPtr.Zero)
            {
                device_name = AudioContext.Default;
                device_handle = Alc.OpenDevice(AudioContext.Default); // try to open named default device
            }
            if (device_handle == IntPtr.Zero)
            {
                device_name = "None";
                throw new AudioDeviceException(String.Format("Audio device '{0}' does not exist or is tied up by another application.",
                    String.IsNullOrEmpty(device) ? "default" : device));
            }

            CheckForAlcErrors();

            // Build the attribute list
            List<int> attributes = new List<int>();

            if (freq != 0)
            {
                attributes.Add((int)AlcContextAttributes.Frequency);
                attributes.Add(freq);
            }

            if (refresh != 0)
            {
                attributes.Add((int)AlcContextAttributes.Refresh);
                attributes.Add(refresh);
            }

            attributes.Add((int)AlcContextAttributes.Sync);
            attributes.Add(sync ? 1 : 0);

            if (enableEfx && Alc.IsExtensionPresent(device_handle, "ALC_EXT_EFX"))
            {
                int num_slots;
                switch (efxAuxiliarySends)
                {
                    case MaxAuxiliarySends.One:
                    case MaxAuxiliarySends.Two:
                    case MaxAuxiliarySends.Three:
                    case MaxAuxiliarySends.Four:
                        num_slots = (int)efxAuxiliarySends;
                        break;
                    default:
                    case MaxAuxiliarySends.UseDriverDefault:
                        Alc.GetInteger(device_handle, AlcGetInteger.EfxMaxAuxiliarySends, 1, out num_slots);
                        break;
                }
              
                attributes.Add((int)AlcContextAttributes.EfxMaxAuxiliarySends);
                attributes.Add(num_slots);
            }
            attributes.Add(0);

            context_handle = Alc.CreateContext(device_handle, attributes.ToArray());

            if (context_handle == ContextHandle.Zero)
            {
                Alc.CloseDevice(device_handle);
                throw new AudioContextException("The audio context could not be created with the specified parameters.");
            }

            CheckForAlcErrors();

            // HACK: OpenAL SI on Linux/ALSA crashes on MakeCurrent. This hack avoids calling MakeCurrent when
            // an old OpenAL version is detect - it may affect outdated OpenAL versions different than OpenAL SI,
            // but it looks like a good compromise for now.
            if (AudioDeviceEnumerator.AvailablePlaybackDevices.Count > 0)
                MakeCurrent();

            CheckForAlcErrors();

            device_name = Alc.GetString(device_handle, AlcGetString.DeviceSpecifier);
            int attribute_count;
            Alc.GetInteger(device_handle, AlcGetInteger.AttributesSize, 1, out attribute_count);
            if (attribute_count > 0)
            {
                int[] device_attributes = new int[attribute_count];
                Alc.GetInteger(device_handle, AlcGetInteger.AllAttributes, device_attributes.Length, device_attributes);
                foreach (int attr in device_attributes)
                {
                    switch ((AlcContextAttributes)attr)
                    {
                        case AlcContextAttributes.Sync: IsSynchronized = true; break;
                    }
                }
            }

            lock (audio_context_lock)
            {
                available_contexts.Add(this.context_handle, this);
                context_exists = true;
            }
        }

        #endregion --- Private Methods ---

        #region void CheckForAlcErrors()

        void CheckForAlcErrors()
        {
            AlcError err = Alc.GetError(device_handle);
            if (err != AlcError.NoError)
                throw new AudioContextException("Device (" + device_handle + ") " + err.ToString());
        }

        #endregion

        #region static void MakeCurrent(AudioContext context)

        /// <private />
        /// <summary>Makes the specified AudioContext current in the calling thread.</summary>
        /// <param name="context">The OpenTK.Audio.AudioContext to make current, or null.</param>
        /// <exception cref="ObjectDisposedException">
        /// Occurs if this function is called after the AudioContext has been disposed.
        /// </exception>
        /// <exception cref="AudioContextException">
        /// Occurs when the AudioContext could not be made current.
        /// </exception>
        static void MakeCurrent(AudioContext context)
        {
            lock (audio_context_lock)
            {
                if (!Alc.MakeContextCurrent(context != null ? context.context_handle : ContextHandle.Zero))
                    throw new AudioContextException(String.Format("ALC {0} error detected at {1}.",
                        Alc.GetError(context != null ? (IntPtr)context.context_handle : IntPtr.Zero).ToString(),
                        context != null ? context.ToString() : "null"));
            }
        }

        #endregion

        #region internal bool IsCurrent

        /// <summary>
        /// Gets or sets a System.Boolean indicating whether the AudioContext
        /// is current.
        /// </summary>
        /// <remarks>
        /// Only one AudioContext can be current in the application at any time,
        /// <b>regardless of the number of threads</b>.
        /// </remarks>
        internal bool IsCurrent
        {
            get
            {
                lock (audio_context_lock)
                {
                    if (available_contexts.Count == 0)
                        return false;
                    else
                    {
                        return AudioContext.CurrentContext == this;
                    }
                }
            }
            set
            {
                if (value) AudioContext.MakeCurrent(this);
                else AudioContext.MakeCurrent(null);
            }
        }

        #endregion

        #region IntPtr Device

        IntPtr Device { get { return device_handle; } }

        #endregion

        #endregion

        #region --- Public Members ---

        #region public void MakeCurrent()

        /// <summary>Makes the AudioContext current in the calling thread.</summary>
        /// <exception cref="ObjectDisposedException">
        /// Occurs if this function is called after the AudioContext has been disposed.
        /// </exception>
        /// <exception cref="AudioContextException">
        /// Occurs when the AudioContext could not be made current.
        /// </exception>
        /// <remarks>
        /// Only one AudioContext can be current in the application at any time,
        /// <b>regardless of the number of threads</b>.
        /// </remarks>
        public void MakeCurrent()
        {
            AudioContext.MakeCurrent(this);
        }

        #endregion

        #region public bool IsProcessing

        /// <summary>
        /// Gets a System.Boolean indicating whether the AudioContext is
        /// currently processing audio events.
        /// </summary>
        /// <seealso cref="Process"/>
        /// <seealso cref="Suspend"/>
        public bool IsProcessing
        {
            get { return is_processing; }
            private set { is_processing = value; }
        }

        #endregion

        #region public bool IsProcessing

        /// <summary>
        /// Gets a System.Boolean indicating whether the AudioContext is
        /// synchronized.
        /// </summary>
        /// <seealso cref="Process"/>
        public bool IsSynchronized
        {
            get { return is_synchronized; }
            private set { is_synchronized = value; }
        }

        #endregion

        #region public void Process

        /// <summary>
        /// Processes queued audio events.
        /// </summary>
        /// <remarks>
        /// <para>
        /// If AudioContext.IsSynchronized is true, this function will resume
        /// the internal audio processing thread. If AudioContext.IsSynchronized is false,
        /// you will need to call this function multiple times per second to process
        /// audio events.
        /// </para>
        /// <para>
        /// In some implementations this function may have no effect.
        /// </para>
        /// </remarks>
        /// <exception cref="ObjectDisposedException">Occurs when this function is called after the AudioContext had been disposed.</exception>
        /// <seealso cref="Suspend"/>
        /// <seealso cref="IsProcessing"/>
        /// <seealso cref="IsSynchronized"/>
        public void Process()
        {
            if (disposed) throw new ObjectDisposedException(this.ToString());
            Alc.ProcessContext(this.context_handle);
            IsProcessing = true;
        }

        #endregion

        #region public void Suspend

        /// <summary>
        /// Suspends processing of audio events.
        /// </summary>
        /// <remarks>
        /// <para>
        /// To avoid audio artifacts when calling this function, set audio gain to zero before
        /// suspending an AudioContext.
        /// </para>
        /// <para>
        /// In some implementations, it can be faster to suspend processing before changing
        /// AudioContext state.
        /// </para>
        /// <para>
        /// In some implementations this function may have no effect.
        /// </para>
        /// </remarks>
        /// <exception cref="ObjectDisposedException">Occurs when this function is called after the AudioContext had been disposed.</exception>
        /// <seealso cref="Process"/>
        /// <seealso cref="IsProcessing"/>
        /// <seealso cref="IsSynchronized"/>
        public void Suspend()
        {
            if (disposed) throw new ObjectDisposedException(this.ToString());
            Alc.SuspendContext(this.context_handle);
            IsProcessing = false;
        }

        #endregion

        #region public bool SupportsExtension(string extension)

        /// <summary>
        /// Checks whether the specified OpenAL extension is supported.
        /// </summary>
        /// <param name="extension">The name of the extension to check (e.g. "ALC_EXT_EFX").</param>
        /// <returns>true if the extension is supported; false otherwise.</returns>
        public bool SupportsExtension(string extension)
        {
            if (disposed) throw new ObjectDisposedException(this.GetType().FullName);
            return Alc.IsExtensionPresent(this.Device, extension);
        }

        #endregion

        #region public static AudioContext CurrentContext

        /// <summary>
        /// Gets the OpenTK.Audio.AudioContext which is current in the application.
        /// </summary>
        /// <remarks>
        /// Only one AudioContext can be current in the application at any time,
        /// <b>regardless of the number of threads</b>.
        /// </remarks>
        public static AudioContext CurrentContext
        {
            get
            {
                lock (audio_context_lock)
                {
                    if (available_contexts.Count == 0)
                        return null;
                    else
                    {
                        AudioContext context;
                        AudioContext.available_contexts.TryGetValue(
                            (ContextHandle)Alc.GetCurrentContext(),
                            out context);
                        return context;
                    }
                }
            }
        }

        #endregion

        #region public static IList<string> AvailableDevices
        /// <summary>Returns a list of strings containing all known playback devices.</summary>
        public static IList<string> AvailableDevices
        {
            get
            {
                return AudioDeviceEnumerator.AvailablePlaybackDevices;
            }
        }
        #endregion public static IList<string> AvailablePlaybackDevices

        #region public static string Default
        /// <summary>Returns the name of the device that will be used as playback default.</summary>
        public static string Default
        {
            get
            {
                return AudioDeviceEnumerator.DefaultPlaybackDevice;
            }
        }
        #endregion public static string DefaultPlaybackDevice

        #region public string CurrentDeviceName
        /// <summary>Returns the name of the used device for the current context.</summary>
        public string CurrentDeviceName
        {
            get
            {
                return device_name;
            }
        }
        #endregion public string CurrentDeviceName

        #region public AlcError CurrentAlcError
        /// <summary>Returns the first encountered error by Alc for this device.</summary>
        public AlcError CurrentAlcError
        {
            get
            {
                if (disposed)
                    throw new ObjectDisposedException(this.ToString());

                return Alc.GetError(this.device_handle);
            }
        }
        #endregion public AlcError CurrentAlcError

        #endregion --- Public Members ---

        #region --- IDisposable Members ---

        /// <summary>
        /// Disposes of the AudioContext, cleaning up all resources consumed by it.
        /// </summary>
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        void Dispose(bool manual)
        {
            if (!disposed)
            {
                if (this.IsCurrent)
                    this.IsCurrent = false;

                if (context_handle != ContextHandle.Zero)
                {
                    available_contexts.Remove(context_handle);
                    Alc.DestroyContext(context_handle);
                }

                if (device_handle != IntPtr.Zero)
                    Alc.CloseDevice(device_handle);

                if (manual)
                {
                }
                disposed = true;
            }
        }

        ~AudioContext()
        {
            this.Dispose(false);
        }

        #endregion

        #region --- Overrides ---

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override string ToString()
        {
            return String.Format("{0} (handle: {1}, device: {2})",
                                 this.device_name, this.context_handle, this.device_handle);
        }

        #endregion
    }
}
