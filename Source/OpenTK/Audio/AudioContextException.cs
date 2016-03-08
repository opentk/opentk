// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Audio
{
    /// <summary>Represents exceptions related to an OpenTK.Audio.AudioContext.</summary>
    public class AudioContextException : AudioException
    {
        /// <summary>Constructs a new AudioContextException.</summary>
        public AudioContextException() : base() { }
        /// <summary>Constructs a new AudioContextException with the specified error message.</summary>
        /// <param name="message">The error message of the AudioContextException.</param>
        public AudioContextException(string message) : base(message) { }
    }
}
