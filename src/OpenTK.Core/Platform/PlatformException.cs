using System;

namespace OpenTK.Core.Platform
{
    /// <summary>
    /// Defines a platform-specific exception.
    /// </summary>
    public class PlatformException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlatformException"/> class.
        /// </summary>
        public PlatformException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlatformException"/> class.
        /// </summary>
        /// <param name="message">A message explaining the cause for this exception.</param>
        public PlatformException(string message)
            : base(message)
        {
        }
    }
}
