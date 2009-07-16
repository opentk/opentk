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
