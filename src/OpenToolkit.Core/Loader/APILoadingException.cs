using System;

namespace OpenToolkit.Core.Loader
{
    /// <summary>
    /// Defines an exception which occurs on errors while loading an API.
    /// </summary>
    public class APILoadingException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="APILoadingException"/> class.
        /// </summary>
        public APILoadingException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APILoadingException"/> class.
        /// </summary>
        /// <param name="message">A message explaining the cause for this exception.</param>
        public APILoadingException(string message)
            : base(message)
        {
        }
    }
}
