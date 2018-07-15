using System;
using System.Collections.Generic;
using Bind.XML;
using Bind.XML.Signatures;
using JetBrains.Annotations;

namespace Bind.Extensions
{
    /// <summary>
    /// Extension methods for the <see cref="ApiProfile"/> class.
    /// </summary>
    public static class ApiProfileExtensions
    {
        private static IDictionary<string, string> FriendlyNames = new Dictionary<string, string>
        {
            { "gl", "OpenGL (Compatibility Profile)" },
            { "glcore", "OpenGL (Core Profile)" },
            { "gles1", "OpenGL ES 1.0" },
            { "gles2", "OpenGL ES 2.0" },
            { "glsc2", "OpenGL SC 2.0" }
        };

        /// <summary>
        /// Gets the friendly name of the given profile.
        /// </summary>
        /// <param name="profile">The profile.</param>
        /// <returns>The friendly name.</returns>
        /// <exception cref="InvalidOperationException">Thrown if no friendly name is available.</exception>
        [NotNull]
        public static string GetFriendlyName([NotNull] this ApiProfile profile)
        {
            if (FriendlyNames.TryGetValue(profile.Name, out var value))
            {
                return value;
            }

            return "Unknown";
        }
    }
}
