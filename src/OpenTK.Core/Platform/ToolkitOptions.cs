using OpenTK.Core.Utility;

namespace OpenTK.Core.Platform
{
    /// <summary>
    /// Options used to initialize OpenTK with.
    /// </summary>
    public sealed class ToolkitOptions
    {
        /// <summary>
        /// The application name.
        /// </summary>
        public string ApplicationName { get; set; } = "OpenTK Application";

        /// <summary>
        /// The logger to send logging to.
        /// Log info can be useful to understand what might be going wrong if something isn't working.
        /// It's also useful to debug OpenTK.
        /// </summary>
        public ILogger? Logger { get; set; } = null;

        // FIXME: Add additional settings such as PreferSDL and PreferANGLE here...
    }
}
