// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Audio
{
    /// <summary>Represents exceptions related to OpenTK.Audio.AudioReader objects.</summary>
    public class AudioReaderException : AudioException
    {
        /// <summary>Constructs a new AudioReaderException.</summary>
        public AudioReaderException() : base() { }
        /// <summary>Constructs a new AudioReaderException with the specified error message.</summary>
        /// <param name="message">The error message of the AudioReaderException.</param>
        public AudioReaderException(string message) : base(message) { } 
    }
}
