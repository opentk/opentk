using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Audio
{
    /// <summary>Represents exceptions related to an OpenTK.Audio device.</summary>
    public class AudioDeviceException : AudioException
    {
        /// <summary>Constructs a new AudioDeviceException.</summary>
        public AudioDeviceException() : base() { }
        /// <summary>Constructs a new AudioDeviceException with the specified error message.</summary>
        /// <param name="message">The error message of the AudioDeviceException.</param>
        public AudioDeviceException(string message) : base(message) { }
    }
}
