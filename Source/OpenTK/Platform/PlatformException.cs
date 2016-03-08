// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
n.
 * See license.txt for licensing detailed licensing details.
 */
#endregion

using System;

namespace OpenTK
{
    /// <summary>
    /// Defines a plaftorm-specific exception.
    /// </summary>
    public class PlatformException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OpenTK.PlatformException"/> class.
        /// </summary>
        public PlatformException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenTK.PlatformException"/> class.
        /// </summary>
        /// <param name="message">A message explaining the cause for this exception.</param>
        public PlatformException(string message) : base(message) { }
    }
}