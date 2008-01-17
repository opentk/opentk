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

namespace OpenTK.Audio
{
    /// <summary>
    /// Provides methods to create and use an audio context.
    /// </summary>
    public sealed class AudioContext : IDisposable
    {
        #region --- Fields ---

        bool disposed;
        static List<string> available_devices;
        IntPtr device_handle, context_handle;
        static object audio_context_lock = new object();

        #endregion

        #region --- Constructors ---

        // Runs before the actual class constructor, to load available devices.
        static AudioContext()
        {
            LoadAvailableDevices();
        }

        /// <summary>Constructs a new AudioContext, using the default audio device.</summary>
        /// <exception cref="NotSupportedException">Occurs when no audio devices are available.</exception>
        public AudioContext()
        {
            if (available_devices.Count == 0)
                throw new NotSupportedException("No audio hardware is available.");
            CreateContext(available_devices[0], 44100, 0, false);
        }

        /// <summary>Constructs a new AudioContext, using the specified audio device.</summary>
        /// <param name="device">The name of the audio device to use.</param>
        /// <remarks>
        /// Use AudioContext.AvailableDevices to obtain a list of all available audio
        /// devices.
        /// </remarks>
        public AudioContext(string device)
        {
            
        }

        #endregion

        #region --- Private Members ---

        #region static void LoadAvailableDevices()

        // Loads all available audio devices into the available_devices array.
        static void LoadAvailableDevices()
        {
            lock (audio_context_lock)
            {
                if (available_devices == null)
                {
                    available_devices = new List<string>();
                    available_devices.AddRange(Alc.GetString(IntPtr.Zero, OpenTK.OpenAL.Enums.AlcGetStringList.AllDevicesSpecifier));
                }
            }
        }

        #endregion

        #region void CreateContext(string device)

        /// <private />
        /// <summary>Creates the audio context using the specified device.</summary>
        /// <param name="device">The device descriptor obtained through AudioContext.AvailableDevices.</param>
        /// <param name="freq">Frequency for mixing output buffer, in units of Hz. </param>
        /// <param name="refresh">Refresh intervalls, in units of Hz.</param>
        /// <param name="sync">Flag, indicating a synchronous context.</param>
        /// <exception cref="InvalidAudioDeviceException">
        /// Occurs when the specified device is not available, or is in use by another program.
        /// </exception>
        /// <exception cref="InvalidAudioContextException">
        /// Occurs when an audio context could not be created with the specified parameters.
        /// </exception>
        void CreateContext(string device, int freq, int refresh, bool sync)
        {
            if (String.IsNullOrEmpty(device)) throw new ArgumentNullException("device");
            if (freq < 0) throw new ArgumentOutOfRangeException("freq", freq, "Should be greater than zero");
            if (refresh < 0) throw new ArgumentOutOfRangeException("refresh", refresh, "Should be greater than zero");

            device_handle = Alc.OpenDevice(device);
            if (device_handle == IntPtr.Zero)
                throw new InvalidAudioDeviceException();

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

            context_handle = Alc.CreateContext(device_handle, attributes.ToArray());
            if (context_handle == IntPtr.Zero)
            {
                Alc.CloseDevice(device_handle);
                throw new InvalidAudioContextException();
            }
        }


        #endregion

        #endregion

        #region --- Public Members ---

        #region public static string[] AvailableDevices

        /// <summary>
        /// Gets a System.String array containing all available audio devices.
        /// </summary>
        public static IEnumerable<string> AvailableDevices
        {
            get
            {
                return (IEnumerable<string>)available_devices;
            }
        }

        #endregion

        #endregion

        #region --- IDisposable Members ---

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        void Dispose(bool manual)
        {
            if (!disposed)
            {
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
    }

    #region --- Exceptions ---

    public class InvalidAudioDeviceException : Exception
    {
        public InvalidAudioDeviceException() : base("The specified audio device does not exist or is tied up by another application.") { }
    }

    public class InvalidAudioContextException : Exception
    {
        public InvalidAudioContextException() : base("The audio context could not be created with the specified parameters.") { }
    }

    #endregion
}
