// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Audio
{
    /// <summary>Represents exceptions related to invalid values.</summary>
    public class AudioValueException : AudioException
    {
        /// <summary>Constructs a new instance.</summary>
        public AudioValueException() : base() { }
        /// <summary>Constructs a new instance with the specified error message.</summary>
        /// <param name="message">The error message of the AudioContextException.</param>
        public AudioValueException(string message) : base(message) { }
    }
}
