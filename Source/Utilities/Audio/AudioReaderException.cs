#region --- License ---
/* Licensed under the MIT/X11 license.
 * Copyright (c) 2006-2008 the OpenTK Team.
 * This notice may not be removed from any source distribution.
 * See license.txt for licensing details.
 */
#endregion

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
