using System;

namespace OpenTK.Platform
{
    /// <summary>
    /// Exception type for platform abstraction layer drivers.
    /// </summary>
    [Serializable]
    public class PalException : Exception
    {
        /// <summary>
        /// The component which throws the exception.
        /// </summary>
        public IPalComponent Component { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PalException"/> class.
        /// </summary>
        /// <param name="component">The component which throws the exception.</param>
        public PalException(IPalComponent component)
            : base($"Exception in abstraction layer driver \"{component.Name ?? "Null Component"}\".")
        {
            Component = component;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PalException"/> class.
        /// </summary>
        /// <param name="component">The component which throws the exception.</param>
        /// <param name="message">The message for the exception.</param>
        public PalException(IPalComponent component, string message)
            : base($"Exception in abstraction layer driver \"{component.Name ?? "Null Component"}\": {message}")
        {
            Component = component;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PalException"/> class.
        /// </summary>
        /// <param name="component">The component which throws the exception.</param>
        /// <param name="message">The message for the exception.</param>
        /// <param name="innerException">The exception which caused this exception.</param>
        public PalException(IPalComponent component, string message, Exception innerException)
            : base($"Exception in abstraction layer driver \"{component.Name ?? "Null Component"}\": {message}", innerException)
        {
            Component = component;
        }
    }
}
