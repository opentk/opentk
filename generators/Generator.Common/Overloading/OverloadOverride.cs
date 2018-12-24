using Generator.Common.Functions;

namespace Generator.Common.Overloading
{
    /// <summary>
    /// Represents an override which provides a method overload.
    /// </summary>
    public class OverloadOverride
    {
        /// <summary>
        /// Gets or sets the overload to be added.
        /// </summary>
        public Function Function { get; set; }

        /// <summary>
        /// Gets or sets the category in which the function is contained.
        /// </summary>
        public string Category { get; set; }
    }
}
