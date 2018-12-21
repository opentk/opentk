using System.Collections.Generic;

namespace Generator.Common.Baking
{
    public class BakedProfile
    {
        /// <summary>
        /// Gets or sets the profile represented by this instance.
        /// </summary>
        public Profile Profile { get; set; }

        /// <summary>
        /// Gets or sets a list of package IDs the Core project should reference.
        /// </summary>
        public List<string> PackageReferences { get; set; }
    }
}
