#region --- License ---
/* Licensed under the MIT/X11 license.
 * Copyright (c) 2006-2008 the OpenTK Team.
 * This notice may not be removed from any source distribution.
 * See license.txt for licensing detailed licensing details.
 */
#endregion

using System;

namespace OpenTK
{
    /// <summary>Defines a plaftorm specific exception.</summary>
    public class PlatformException : Exception
    {
        /// <summary>Constructs a new PlatformException.</summary>
        public PlatformException(string s) : base(s) { }
    }
}