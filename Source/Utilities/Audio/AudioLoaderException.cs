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
    /// <summary>Represents exceptions related to OpenTK.Audio.AudioLoader objects.</summary>
    public class AudioLoaderException : AudioException
    {
        /// <summary>Constructs a new AudioLoaderException.</summary>
        public AudioLoaderException() : base() { }
        /// <summary>Constructs a new AudioLoaderException with the specified error message.</summary>
        /// <param name="message">The error message of the AudioLoaderException.</param>
        public AudioLoaderException(string message) : base(message) { } 
    }
}
