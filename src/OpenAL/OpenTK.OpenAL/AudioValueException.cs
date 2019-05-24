﻿//
// AudioValueException.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace OpenToolkit.OpenAL
{
    /// <summary>
    /// Represents exceptions related to invalid values.
    /// </summary>
    public class AudioValueException : AudioException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AudioValueException"/> class.
        /// </summary>
        public AudioValueException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioValueException"/> class.
        /// </summary>
        /// <param name="message">The error message of the AudioContextException.</param>
        public AudioValueException(string message)
            : base(message)
        {
        }
    }
}
