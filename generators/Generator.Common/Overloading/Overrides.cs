using System.Collections.Generic;

namespace Generator.Common.Overloading
{
    /// <summary>
    /// A class containing overrides.
    /// </summary>
    public class Overrides
    {
        /// <summary>
        /// Gets or sets a collection of additive overrides.
        /// </summary>
        public List<AdditiveOverride> Add { get; set; }

        /// <summary>
        /// Gets or sets a collection of replacement overrides.
        /// </summary>
        public List<ReplacementOverride> Replace { get; set; }

        /// <summary>
        /// Gets or sets a collection of overloads.
        /// </summary>
        public List<OverloadOverride> Overloads { get; set; }
    }
}
