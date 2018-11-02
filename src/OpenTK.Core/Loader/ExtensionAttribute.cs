using System;

namespace OpenToolkit.Core.Loader
{
    /// <summary>
    /// Provides metadata for API extensions.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class ExtensionAttribute : Attribute
    {
        /// <summary>
        /// Gets or sets the name of the extension.
        /// </summary>
        public string ExtensionName { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensionAttribute"/> class.
        /// </summary>
        /// <param name="extensionName">The extension name.</param>
        public ExtensionAttribute(string extensionName)
        {
            ExtensionName = extensionName;
        }
    }
}
