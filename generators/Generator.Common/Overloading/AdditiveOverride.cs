using System.Collections.Generic;
using Generator.Common.Enums;

namespace Generator.Common.Overloading
{
    /// <summary>
    /// Represents an override that adds enums.
    /// </summary>
    public class AdditiveOverride
    {
        /// <summary>
        /// Gets or sets the enums added in this override.
        /// </summary>
        public List<Enum> Enums { get; set; }
    }
}
