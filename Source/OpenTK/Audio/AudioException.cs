using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Audio
{
    /// <summary>Represents exceptions related to the OpenTK.Audio subsystem.</summary>
    public class AudioException : Exception
    {
        /// <summary>Constructs a new AudioException.</summary>
        public AudioException() : base() { }
        /// <summary>Constructs a new AudioException with the specified error message.</summary>
        /// <param name="message">The error message of the AudioException.</param>
        public AudioException(string message) : base(message) { } 
    }
}
