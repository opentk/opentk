#region --- License ---
/* Copyright (c) 2008 the OpenTK team
 * See license.txt for license details
 * http://www.opentk.com
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;

using OpenTK.OpenAL;
using OpenTK.OpenAL.Enums;
using System.Diagnostics;

namespace OpenTK.Audio
{
    /// <summary>
    /// Provides methods to create and use an audio context.
    /// </summary>
    public sealed class AudioContext : IDisposable
    {
        #region --- Fields ---

        bool disposed;
        ContextHandle device_handle, context_handle;
        string device_name;
        static object audio_context_lock = new object();
        static List<string> available_devices = new List<string>();
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
            LoadAvailableDevices();
        }

        #endregion

        #region public AudioContext()

        /// <summary>Constructs a new AudioContext, using the default audio device.</summary>
        /// <exception cref="NotSupportedException">Occurs when no audio devices are available.</exception>
        public AudioContext() : this(available_devices[0], 0, 0, false, 0) { }

        #endregion

        #region public AudioContext(string device)

        /// <summary>Constructs a new AudioContext, using the specified audio device.</summary>
        /// <param name="device">The name of the audio device to use.</param>
        /// <remarks>
        /// Use AudioContext.AvailableDevices to obtain a list of all available audio devices.
        /// devices.
        /// </remarks>
        public AudioContext(string device) : this(device, 0, 0, false, 0) { }

        #endregion

        #region public AudioContext(string device, int freq)

        /// <summary>Constructs a new AudioContext, using the specified audio device and device parameters.</summary>
        /// <param name="device">The name of the audio device to use.</param>
        /// <param name="freq">Frequency for mixing output buffer, in units of Hz. Pass 0 for driver default.</param>
        /// <remarks>
        /// Use AudioContext.AvailableDevices to obtain a list of all available audio devices.
        /// devices.
        /// </remarks>
        /// <see cref="AudioContext(string device, int freq, int refresh, bool sync, int maxEfxSends)"/>
        public AudioContext(string device, int freq) : this(device, freq, 0, false, 0) { }

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
        /// <see cref="AudioContext(string device, int freq, int refresh, bool sync, int maxEfxSends)"/>
        public AudioContext(string device, int freq, int refresh)
            : this(device, freq, refresh, false, 0) { }

        #endregion

        #region public AudioContext(string device)

        /// <summary>Constructs a new AudioContext, using the specified audio device and device parameters.</summary>
        /// <param name="device">The name of the audio device to use.</param>
        /// <param name="freq">Frequency for mixing output buffer, in units of Hz. Pass 0 for driver default.</param>
        /// <param name="refresh">Refresh intervals, in units of Hz. Pass 0 for driver default.</param>
        /// <param name="sync">Flag, indicating a synchronous context.</param>
        /// <remarks>
        /// Use AudioContext.AvailableDevices to obtain a list of all available audio devices.
        /// devices.
        /// </remarks>
        /// <see cref="AudioContext(string device, int freq, int refresh, bool sync, int maxEfxSends)"/>
        public AudioContext(string device, int freq, int refresh, bool sync)
            : this(available_devices[0], freq, refresh, sync, 0) { }

        #endregion

        #region public AudioContext(string device, int freq, int refresh, bool sync, int maxEfxSends)

        /// <summary>Creates the audio context using the specified device and device parameters.</summary>
        /// <param name="device">The device descriptor obtained through AudioContext.AvailableDevices.</param>
        /// <param name="freq">Frequency for mixing output buffer, in units of Hz. Pass 0 for driver default.</param>
        /// <param name="refresh">Refresh intervals, in units of Hz. Pass 0 for driver default.</param>
        /// <param name="sync">Flag, indicating a synchronous context.</param>
        /// <param name="maxEfxSends">Number of auxilliary send slots for the EFX extensions. Can be 0 (use driver default) or higher.</param>
        /// <exception cref="ArgumentNullException">Occurs when the device string is invalid.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Occurs when a specified parameter is invalid.</exception>
        /// <exception cref="InvalidAudioDeviceException">
        /// Occurs when the specified device is not available, or is in use by another program.
        /// </exception>
        /// <exception cref="InvalidAudioContextException">
        /// Occurs when an audio context could not be created with the specified parameters.
        /// </exception>
        /// <remarks>
        /// <para>
        /// Use AudioContext.AvailableDevices to obtain a list of all available audio devices.
        /// </para>
        /// <para>
        /// The number of auxilliary EFX sends depends on the audio hardware and drivers. Most Realtek devices, as well
        /// as the Creative SB Live!, support 1 auxilliary send. Creative's Audigy and X-Fi series support 4 sends.
        /// Values not supported will be clamped by the driver.
        /// </para>
        /// </remarks>
        public AudioContext(string device, int freq, int refresh, bool sync, int maxEfxSends)
        {
            CreateContext(device, freq, refresh, sync, maxEfxSends);
        }

        #endregion

        #endregion

        #region --- Private Members ---

        #region static void LoadAvailableDevices()

        /// <private />
        /// <static />
        /// <summary>
        /// Loads all available audio devices into the available_devices array.
        /// </summary>
        /// <remarks>
        /// Only called by the static AudioContext constructor.
        /// </remarks>
        static void LoadAvailableDevices()
        {
            lock (audio_context_lock)
            {
                if (available_devices.Count == 0)
                {
                    if (Alc.IsExtensionPresent(IntPtr.Zero, "ALC_ENUMERATION_EXT"))
                    {
                        available_devices = new List<string>();
                        available_devices.AddRange(Alc.GetString(IntPtr.Zero, AlcGetStringList.AllDevicesSpecifier));
                    }
                }
            }
        }

        #endregion

        #region void CreateContext(string device)

        /// <private />
        /// <summary>Creates the audio context using the specified device.</summary>
        /// <param name="device">The device descriptor obtained through AudioContext.AvailableDevices.</param>
        /// <param name="freq">Frequency for mixing output buffer, in units of Hz. Pass 0 for driver default.</param>
        /// <param name="refresh">Refresh intervals, in units of Hz. Pass 0 for driver default.</param>
        /// <param name="sync">Flag, indicating a synchronous context.</param>
        /// <param name="maxEfxSends">Number of auxilliary send slots for the EFX extensions. Can be 0 (use driver default) or higher.</param>
        /// <exception cref="ArgumentNullException">Occurs when the device string is invalid.</exception>
        /// /// <exception cref="ArgumentOutOfRangeException">Occurs when a specified parameter is invalid.</exception>
        /// <exception cref="InvalidAudioDeviceException">
        /// Occurs when the specified device is not available, or is in use by another program.
        /// </exception>
        /// <exception cref="InvalidAudioContextException">
        /// Occurs when an audio context could not be created with the specified parameters.
        /// </exception>
        /// <remarks>
        /// The number of auxilliary EFX sends depends on the audio hardware and drivers. Most Realtek devices, as well
        /// as the Creative SB Live!, support 1 auxilliary send. Creative's Audigy and X-Fi series support 4 sends.
        /// Values higher than supported will be clamped by the driver.
        /// </remarks>
        void CreateContext(string device, int freq, int refresh, bool sync, int maxEfxSends)
        {
            if (String.IsNullOrEmpty(device)) throw new ArgumentNullException("device");
            if (freq < 0) throw new ArgumentOutOfRangeException("freq", freq, "Should be greater than zero.");
            if (refresh < 0) throw new ArgumentOutOfRangeException("refresh", refresh, "Should be greater than zero.");
            if (maxEfxSends < 0) throw new ArgumentOutOfRangeException("maxEfxSends", maxEfxSends, "Should be greater than zero.");
            if (available_devices.Count == 0) throw new NotSupportedException("No audio hardware is available.");

            device_handle = Alc.OpenDevice(device);
            if (device_handle == IntPtr.Zero)
                throw new AudioDeviceException("The specified audio device does not exist or is tied up by another application.");

            device_name = device;

            // Build the attribute liist
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
            
            attributes.Add((int)AlcContextAttributes.Frequency);
            attributes.Add(sync ? 1 : 0);

            if (maxEfxSends > 0)
            {
                throw new NotImplementedException();
                //if (Alc.IsExtensionPresent(device_handle, "ALC_EXT_EFX"))
                //attributes.Add((int)AlcContextAttributes.MaxAuxilliarySends);
                //attributes.Add(maxEfxSends);
            }

            context_handle = Alc.CreateContext(device_handle, attributes.ToArray());
            if (context_handle == IntPtr.Zero)
            {
                Alc.CloseDevice(device_handle);
                throw new AudioContextException("The audio context could not be created with the specified parameters.");
            }

            MakeCurrent();

            //device_name = Alc.GetString(device_handle, AlcGetString.DeviceSpecifier);
            //Debug.Print(device_name);
            lock (audio_context_lock)
            {
                available_contexts.Add(this.context_handle, this);
            }
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
                //if (context != null && context.disposed)
                //    throw new ObjectDisposedException("OpenTK.Audio.AudioContext");
                if (!Alc.MakeContextCurrent(context != null ? (IntPtr)context.context_handle : IntPtr.Zero))
                    throw new AudioContextException(
                        Alc.GetError(context != null ? (IntPtr)context.context_handle : IntPtr.Zero).ToString());
            }
        }

        #endregion

        #endregion

        #region --- Public Members ---

        #region public static string[] AvailableDevices

        /// <summary>
        /// Gets a System.String array containing all available audio devices.
        /// </summary>
        /// <remarks>This property allocates memory.</remarks>
        public static string[] AvailableDevices
        {
            get
            {
                return available_devices.ToArray();
            }
        }

        #endregion

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

        #region public bool IsCurrent

        /// <summary>
        /// Gets or sets a System.Boolean indicating whether the AudioContext
        /// is current.
        /// </summary>
        /// <remarks>
        /// Only one AudioContext can be current in the application at any time,
        /// <b>regardless of the number of threads</b>.
        /// </remarks>
        public bool IsCurrent
        {
            get
            {
                lock (audio_context_lock)
                {
                    if (available_contexts.Count == 0)
                        return false;
                    else
                        return AudioContext.available_contexts[(ContextHandle)Alc.GetCurrentContext()] == this;
                }
            }
            set
            {
                if (value) AudioContext.MakeCurrent(this);
                else AudioContext.MakeCurrent(null);
            }
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
        /// <seealso cref="IsSuspended"/>
        /// <seealso cref="IsSynchronized"/>
        public void Process()
        {
            if (disposed) throw new ObjectDisposedException(this.ToString());
            Alc.ProcessContext(this.context_handle);
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
        /// <seealso cref="IsSuspended"/>
        /// <seealso cref="IsSynchronized"/>
        public void Suspend()
        {
            if (disposed) throw new ObjectDisposedException(this.ToString());
            Alc.SuspendContext(this.context_handle);
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

        #endregion

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
                available_contexts.Remove(this.context_handle);

                if (this.IsCurrent)
                    this.IsCurrent = false;

                if (context_handle != IntPtr.Zero)
                    Alc.DestroyContext(context_handle);

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

    #region --- Exceptions ---

    /// <summary>Represents errors related to an Audio device.</summary>
    public class AudioDeviceException : Exception
    {
        public AudioDeviceException() : base() { }
        public AudioDeviceException(string message) : base(message) { }
    }

    /// <summary>Represents errors related to an AudioContext.</summary>
    public class AudioContextException : Exception
    {
        public AudioContextException() : base() { }
        public AudioContextException(string message) : base(message) { }
    }

    #endregion
}
