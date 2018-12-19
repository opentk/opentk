using System.Collections.Generic;
using Newtonsoft.Json;

namespace OpenTK.BuildTools.Common
{
    /// <summary>
    /// Represents a subsystem as defined in GitHub issue #823.
    /// </summary>
    public class Profile
    {
        /// <summary>
        /// Gets or sets a dictionary where the category names (or "Core", if the project isn't an extension)
        /// are the keys and <see cref="Project"/>s are the values.
        /// </summary>
        public Dictionary<string, Project> Projects { get; set; } = new Dictionary<string, Project>();

        public string Namespace { get; set; }

        public string ExtensionsNamespace { get; set; }

        [JsonIgnore]
        public string OutputFolder { get; set; }

        public string Name { get; set; }

        public string Version { get; set; }

        [JsonIgnore]
        public Dictionary<string, string> TypeMap { get; set; } = new Dictionary<string, string>();
    }
}