using System;

namespace OpenTK.Graphics
{
    /// <summary>
    /// Represents errors related to unavailable graphics parameters.
    /// </summary>
    public class GraphicsModeException : Exception
    {
        /// <summary>
        /// Constructs a new GraphicsModeException.
        /// </summary>
        public GraphicsModeException() : base() { }
        /// <summary>
        /// Constructs a new GraphicsModeException with the given error message.
        /// </summary>
        public GraphicsModeException(string message) : base(message) { }
    }
}
