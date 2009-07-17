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
using System.Diagnostics;

namespace OpenTK.Audio
{

    /// <summary>
    /// Provides methods to instantiate, use and destroy an audio device for recording.
    /// Static methods are provided to list available devices known by the driver.
    /// </summary>
    public sealed class AudioCapture : IDisposable
    {
        #region private fields
        /// <summary>This must stay private info so the end-user cannot call any Alc commands for the recording device.</summary>
        private IntPtr Handle;

        /// <summary>Alc.CaptureStop should be called prior to device shutdown, this keeps track of Alc.CaptureStart/Stop calls.</summary>
        private bool _isrecording = false;
        #endregion private fields

        #region Device Name
        private string device_name;
        /// <summary>The name of the device associated with this instance.</summary>
        public string CurrentDeviceName
        {
            get
            {
                return device_name;
            }
        }
        #endregion Device Name

        #region public static properties
        /// <summary>Returns a list of strings containing all known recording devices.</summary>
        public static IList<string> AvailableDevices
        {
            get
            {
                return AudioDeviceEnumerator.AvailableRecordingDevices;
            }
        }

        /// <summary>Returns the name of the device that will be used as recording default.</summary>
        public static string Default
        {
            get
            {
                return AudioDeviceEnumerator.DefaultRecordingDevice;
            }
        }
        #endregion public static properties

        #region Constructor

        static AudioCapture()
        {
            if (AudioDeviceEnumerator.IsOpenALSupported) // forces enumeration
            {
            }
        }

        #region Internal Error handling
        private string ErrorMessage(string devicename, uint frequency, ALFormat bufferformat, int buffersize)
        {
            string alcerrmsg;
            AlcError alcerrcode = Alc.GetError(IntPtr.Zero);
            switch (alcerrcode)
            {
                case AlcError.OutOfMemory:
                    alcerrmsg = alcerrcode.ToString() + ": The specified device is invalid, or can not capture audio.";
                    break;
                case AlcError.InvalidValue:
                    alcerrmsg = alcerrcode.ToString() + ": One of the parameters has an invalid value.";
                    break;
                default:
                    alcerrmsg = alcerrcode.ToString();
                    break;
            }
            return "The handle returned by Alc.CaptureOpenDevice is null." +
                   "\nAlc Error: " + alcerrmsg +
                   "\nDevice Name: " + devicename +
                   "\nCapture frequency: " + frequency +
                   "\nBuffer format: " + bufferformat +
                   "\nBuffer Size: " + buffersize;
        }

        private List<string> ErrorMessages = new List<string>();
        #endregion Internal Error handling

        /// <summary>
        /// Opens the default device for audio recording.
        /// Implicitly set parameters are: 22050Hz, 16Bit Mono, 4096 samples ringbuffer.
        /// </summary>
        public AudioCapture():this(AudioCapture.Default, 22050, ALFormat.Mono16, 4096)
        {
        }

        /// <summary>Opens a device for audio recording.</summary>
        /// <param name="devicename">The device name.</param>
        /// <param name="frequency">The frequency that the data should be captured at.</param>
        /// <param name="bufferformat">The requested capture buffer format.</param>
        /// <param name="buffersize">The size of OpenAL's capture internal ring-buffer. This value expects number of samples, not bytes.</param>
        public AudioCapture(string devicename, int frequency, ALFormat bufferformat, int buffersize)
            : this(devicename, (uint)frequency, bufferformat, buffersize)
        {
        }

        /// <summary>Opens a device for audio recording.</summary>
        /// <param name="devicename">The device name.</param>
        /// <param name="frequency">The frequency that the data should be captured at.</param>
        /// <param name="bufferformat">The requested capture buffer format.</param>
        /// <param name="buffersize">The size of OpenAL's capture internal ring-buffer. This value expects number of samples, not bytes.</param>
        [CLSCompliant(false)]
        public AudioCapture(string devicename, uint frequency, ALFormat bufferformat, int buffersize)
        {
            if (!AudioDeviceEnumerator.IsOpenALSupported)
                throw new DllNotFoundException("openal32.dll");

            device_name = devicename;
            Handle = Alc.CaptureOpenDevice(devicename, frequency, bufferformat, buffersize);
            if (Handle == IntPtr.Zero)
            {
                ErrorMessages.Add(ErrorMessage(devicename, frequency, bufferformat, buffersize));
                device_name = "IntPtr.Zero";
                Handle = Alc.CaptureOpenDevice(null, frequency, bufferformat, buffersize);
            }
            if (Handle == IntPtr.Zero)
            {
                ErrorMessages.Add(ErrorMessage("IntPtr.Zero", frequency, bufferformat, buffersize));
                device_name = AudioDeviceEnumerator.DefaultRecordingDevice;
                Handle = Alc.CaptureOpenDevice(AudioDeviceEnumerator.DefaultRecordingDevice, frequency, bufferformat, buffersize);
            }
            if (Handle == IntPtr.Zero)
            {
                ErrorMessages.Add(ErrorMessage(AudioDeviceEnumerator.DefaultRecordingDevice, frequency, bufferformat, buffersize));
                // everything failed 
                device_name = "None";
                foreach (string s in ErrorMessages)
                    Debug.WriteLine(s);
                throw new AudioDeviceException("All attempts to open capture devices returned IntPtr.Zero. See debug log for verbose list.");
            }

            // handle is not null, check for some Alc Error
            AlcError err = this.CurrentAlcError;
            switch (err)
            {
                case AlcError.NoError:
                    // everything went fine, do nothing
                    break;
                case AlcError.OutOfMemory:
                    throw new AudioDeviceException("Alc.CaptureOpenDevice (Handle: " + Handle + ") reports Alc Error (" + err.ToString() + ") The specified device is invalid, or can not capture audio.");
                case AlcError.InvalidValue:
                    throw new AudioDeviceException("Alc.CaptureOpenDevice (Handle: " + Handle + ") reports Alc Error (" + err.ToString() + ") One of the parameters has an invalid value.");
                default:
                    throw new AudioDeviceException("Alc.CaptureOpenDevice (Handle: " + Handle + ") reports Alc Error: " + err.ToString());
            }
        }

        #endregion Constructor

        #region Destructor

        ~AudioCapture()
        {
            Dispose();
        }

        private bool IsDisposed;

        /// <summary>Closes the device and disposes the instance.</summary>
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool manual)
        {
            if (!this.IsDisposed)
            {
                if (this.Handle != IntPtr.Zero)
                {
                    if (this._isrecording)
                        this.Stop();

                    Alc.CaptureCloseDevice(this.Handle);
                }
                this.IsDisposed = true;
            }
        }

        #endregion Destructor

        #region Error Checking

        /// <summary>Returns the first encountered Alc Error by this device.</summary>
        public AlcError CurrentAlcError
        {
            get
            {
                return Alc.GetError(Handle);
            }
        }

        #endregion Error Checking

        #region Start & Stop Capture

        /// <summary>
        /// Start recording samples.
        /// The number of available samples can be obtained through the AvailableSamples property.
        /// The data can be queried with any GetSamples() method.
        /// </summary>
        public void Start()
        {
            Alc.CaptureStart(Handle);
            _isrecording = true;
        }

        /// <summary>Stop recording samples. This will not clear previously recorded samples.</summary>
        public void Stop()
        {
            Alc.CaptureStop(Handle);
            _isrecording = false;
        }

        #endregion Start & Stop Capture

        #region Available samples property

        /// <summary>Returns the number of available samples for capture.</summary>
        public int AvailableSamples
        {
            get
            {
                // TODO: Investigate inconsistency between documentation and actual usage.
                // Doc claims the 3rd param is Number-of-Bytes, but it appears to be Number-of-Int32s
                int result;
                Alc.GetInteger(Handle, AlcGetInteger.CaptureSamples, 1, out result);
                return result;
            }
        }

        #endregion Available samples property

        #region Capture previously recorded samples

        /// <summary>This function will write previously recorded samples to a location in memory. It does not block.</summary>
        /// <param name="buffer">A pointer to a previously initialized and pinned array.</param>
        /// <param name="samplecount">The number of samples to be written to the buffer.</param>
        public void GetSamples(IntPtr buffer, int samplecount)
        {
            Alc.CaptureSamples(Handle, buffer, samplecount);
        }

        #endregion Capture previously recorded samples
    }
}
