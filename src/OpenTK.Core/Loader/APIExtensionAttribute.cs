using System;

namespace OpenTK.Core.Loader
{
    /// <summary>
    /// Provides metadata for API extensions.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class APIExtensionAttribute : Attribute
    {
        /// <summary>
        /// Gets or sets the name of the extension.
        /// </summary>
        public string ExtensionName { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="APIExtensionAttribute"/> class.
        /// </summary>
        /// <param name="extensionName">The extension name.</param>
        public APIExtensionAttribute(string extensionName)
        {
            ExtensionName = extensionName;
        }
    }
}
