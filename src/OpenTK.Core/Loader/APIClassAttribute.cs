using System;

namespace OpenTK.Core.Loader
{
    /// <summary>
    /// Provides metadata for API classes.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class APIClassAttribute : Attribute
    {
        /// <summary>
        /// Gets or sets the name of the native library.
        /// </summary>
        public string Library { get; set; }

        /// <summary>
        /// Gets or sets the native size of the buffer format. Defaults to one byte.
        /// </summary>
        public Type InterfaceType { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="APIClassAttribute"/> class.
        /// </summary>
        /// <param name="library">The library name.</param>
        /// <param name="interfaceType">The interface type.</param>
        public APIClassAttribute(string library, Type interfaceType)
        {
            InterfaceType = interfaceType;
            Library = library;
        }
    }
}
