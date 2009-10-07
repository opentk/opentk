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
using System.Runtime.InteropServices;

using OpenTK.Audio.OpenAL;

namespace OpenTK.Audio
{

    /// <summary>
    /// Provides methods to instantiate, use and destroy an audio device for recording.
    /// Static methods are provided to list available devices known by the driver.
    /// </summary>
    public sealed class AudioCapture : IDisposable
    {
        #region Fields

        // This must stay private info so the end-user cannot call any Alc commands for the recording device.
        IntPtr Handle;

        // Alc.CaptureStop should be called prior to device shutdown, this keeps track of Alc.CaptureStart/Stop calls.
        bool _isrecording = false;

        ALFormat sample_format;
        int sample_frequency;
        
        #endregion 

        #region Constructors

        static AudioCapture()
        {
            if (AudioDeviceEnumerator.IsOpenALSupported) // forces enumeration
            {
            }
        }

        /// <summary>
        /// Opens the default device for audio recording.
        /// Implicitly set parameters are: 22050Hz, 16Bit Mono, 4096 samples ringbuffer.
        /// </summary>
        public AudioCapture()
            : this(AudioCapture.DefaultDevice, 22050, ALFormat.Mono16, 4096)
        {
        }

        /// <summary>Opens a device for audio recording.</summary>
        /// <param name="deviceName">The device name.</param>
        /// <param name="frequency">The frequency that the data should be captured at.</param>
        /// <param name="sampleFormat">The requested capture buffer format.</param>
        /// <param name="bufferSize">The size of OpenAL's capture internal ring-buffer. This value expects number of samples, not bytes.</param>
        public AudioCapture(string deviceName, int frequency, ALFormat sampleFormat, int bufferSize)
        {
            if (!AudioDeviceEnumerator.IsOpenALSupported)
                throw new DllNotFoundException("openal32.dll");
            if (frequency <= 0)
                throw new ArgumentOutOfRangeException("frequency");
            if (bufferSize <= 0)
                throw new ArgumentOutOfRangeException("bufferSize");

            // Try to open specified device. If it fails, try to open default device.
            device_name = deviceName;
            Handle = Alc.CaptureOpenDevice(deviceName, frequency, sampleFormat, bufferSize);

            if (Handle == IntPtr.Zero)
            {
                Debug.WriteLine(ErrorMessage(deviceName, frequency, sampleFormat, bufferSize));
                device_name = "IntPtr.Zero";
                Handle = Alc.CaptureOpenDevice(null, frequency, sampleFormat, bufferSize);
            }

            if (Handle == IntPtr.Zero)
            {
                Debug.WriteLine(ErrorMessage("IntPtr.Zero", frequency, sampleFormat, bufferSize));
                device_name = AudioDeviceEnumerator.DefaultRecordingDevice;
                Handle = Alc.CaptureOpenDevice(AudioDeviceEnumerator.DefaultRecordingDevice, frequency, sampleFormat, bufferSize);
            }

            if (Handle == IntPtr.Zero)
            {
                // Everything we tried failed. Capture may not be supported, bail out.
                Debug.WriteLine(ErrorMessage(AudioDeviceEnumerator.DefaultRecordingDevice, frequency, sampleFormat, bufferSize));
                device_name = "None";

                throw new AudioDeviceException("All attempts to open capture devices returned IntPtr.Zero. See debug log for verbose list.");
            }

            // handle is not null, check for some Alc Error
            CheckErrors();

            SampleFormat = sampleFormat;
            SampleFrequency = frequency;
        }

        #endregion Constructor

        #region Public Members

        #region CurrentDevice

        private string device_name;

        /// <summary>
        /// The name of the device associated with this instance.
        /// </summary>
        public string CurrentDevice
        {
            get
            {
                return device_name;
            }
        }

        #endregion

        #region AvailableDevices

        /// <summary>
        /// Returns a list of strings containing all known recording devices.
        /// </summary>
        public static IList<string> AvailableDevices
        {
            get
            {
                return AudioDeviceEnumerator.AvailableRecordingDevices;
            }
        }

        #endregion

        #region DefaultDevice

        /// <summary>
        /// Returns the name of the device that will be used as recording default.
        /// </summary>
        public static string DefaultDevice
        {
            get
            {
                return AudioDeviceEnumerator.DefaultRecordingDevice;
            }
        }

        #endregion

        #region CheckErrors

        /// <summary>
        /// Checks for ALC error conditions.
        /// </summary>
        /// <exception cref="OutOfMemoryException">Raised when an out of memory error is detected.</exception>
        /// <exception cref="AudioValueException">Raised when an invalid value is detected.</exception>
        /// <exception cref="AudioDeviceException">Raised when an invalid device is detected.</exception>
        /// <exception cref="AudioContextException">Raised when an invalid context is detected.</exception>
        public void CheckErrors()
        {
            new AudioDeviceErrorChecker(Handle).Dispose();
        }

        #endregion

        #region CurrentError

        /// <summary>Returns the ALC error code for this device.</summary>
        public AlcError CurrentError
        {
            get
            {
                return Alc.GetError(Handle);
            }
        }

        #endregion

        #region Start & Stop

        /// <summary>
        /// Start recording samples.
        /// The number of available samples can be obtained through the <see cref="AvailableSamples"/> property.
        /// The data can be queried with any <see cref="ReadSamples(IntPtr, int)"/> method.
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

        #region AvailableSamples

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

        #region ReadSamples

        /// <summary>Fills the specified buffer with samples from the internal capture ring-buffer. This method does not block: it is an error to specify a sampleCount larger than AvailableSamples.</summary>
        /// <param name="buffer">A pointer to a previously initialized and pinned array.</param>
        /// <param name="sampleCount">The number of samples to be written to the buffer.</param>
        public void ReadSamples(IntPtr buffer, int sampleCount)
        {
            Alc.CaptureSamples(Handle, buffer, sampleCount);
        }

        /// <summary>Fills the specified buffer with samples from the internal capture ring-buffer. This method does not block: it is an error to specify a sampleCount larger than AvailableSamples.</summary>
        /// <param name="buffer">The buffer to fill.</param>
        /// <param name="sampleCount">The number of samples to be written to the buffer.</param>
        /// <exception cref="System.ArgumentNullException">Raised when buffer is null.</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">Raised when sampleCount is larger than the buffer.</exception>
        public void ReadSamples<TBuffer>(TBuffer[] buffer, int sampleCount)
            where TBuffer : struct
        {
            if (buffer == null)
                throw new ArgumentNullException("buffer");

            int buffer_size = BlittableValueType<TBuffer>.Stride * buffer.Length;
            // This is more of a heuristic than a 100% valid check. However, it will work
            // correctly for 99.9% of all use cases.
            // This should never produce a false positive, but a false negative might
            // be produced with compressed sample formats (which are very rare).
            // Still, this is better than no check at all.
            if (sampleCount * GetSampleSize(SampleFormat) > buffer_size)
                throw new ArgumentOutOfRangeException("sampleCount");

            GCHandle buffer_ptr = GCHandle.Alloc(buffer, GCHandleType.Pinned);
            try { ReadSamples(buffer_ptr.AddrOfPinnedObject(), sampleCount); }
            finally { buffer_ptr.Free(); }
        }

        #endregion

        #region SampleFormat & SampleFrequency

        /// <summary>
        /// Gets the OpenTK.Audio.ALFormat for this instance.
        /// </summary>
        public ALFormat SampleFormat
        {
            get { return sample_format; }
            private set { sample_format = value; }
        }

        /// <summary>
        /// Gets the sampling rate for this instance.
        /// </summary>
        public int SampleFrequency
        {
            get { return sample_frequency; }
            private set { sample_frequency = value; }
        }

        #endregion

        #region IsRunning

        /// <summary>
        /// Gets a value indicating whether this instance is currently capturing samples.
        /// </summary>
        public bool IsRunning
        {
            get { return _isrecording; }
        }

        #endregion

        #endregion

        #region Private Members

        // Retrieves the sample size in bytes for various ALFormats.
        // Compressed formats always return 1.
        static int GetSampleSize(ALFormat format)
        {
            switch (format)
            {
                case ALFormat.Mono8: return 1;
                case ALFormat.Mono16: return 2;
                case ALFormat.Stereo8: return 2;
                case ALFormat.Stereo16: return 4;
                case ALFormat.MonoFloat32Ext: return 4;
                case ALFormat.MonoDoubleExt: return 8;
                case ALFormat.StereoFloat32Ext: return 8;
                case ALFormat.StereoDoubleExt: return 16;

                case ALFormat.MultiQuad8Ext: return 4;
                case ALFormat.MultiQuad16Ext: return 8;
                case ALFormat.MultiQuad32Ext: return 16;

                case ALFormat.Multi51Chn8Ext: return 6;
                case ALFormat.Multi51Chn16Ext: return 12;
                case ALFormat.Multi51Chn32Ext: return 24;

                case ALFormat.Multi61Chn8Ext: return 7;
                case ALFormat.Multi71Chn16Ext: return 14;
                case ALFormat.Multi71Chn32Ext: return 28;

                case ALFormat.MultiRear8Ext: return 1;
                case ALFormat.MultiRear16Ext: return 2;
                case ALFormat.MultiRear32Ext: return 4;

                default: return 1; // Unknown sample size.
            }
        }

        // Converts an error code to an error string with additional information.
        string ErrorMessage(string devicename, int frequency, ALFormat bufferformat, int buffersize)
        {
            string alcerrmsg;
            AlcError alcerrcode = CurrentError;
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

        #endregion

        #region IDisposable Members

        /// <summary>
        /// Finalizes this instance.
        /// </summary>
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
    }
}
