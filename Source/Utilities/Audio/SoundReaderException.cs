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
    /// <summary>Represents exceptions related to OpenTK.Audio.SoundReader objects.</summary>
    public class SoundReaderException : AudioException
    {
        /// <summary>Constructs a new SoundReaderException.</summary>
        public SoundReaderException() : base() { }
        /// <summary>Constructs a new SoundReaderException with the specified error message.</summary>
        /// <param name="message">The error message of the SoundReaderException.</param>
        public SoundReaderException(string message) : base(message) { } 
    }
}
