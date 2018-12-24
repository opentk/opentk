using Generator.Common.Functions;

namespace Generator.Common.Overloading
{
    /// <summary>
    /// Gets or sets an override that replaces a function.
    /// </summary>
    public class ReplacementOverride
    {
        /// <summary>
        /// Gets or sets the new function signature.
        /// </summary>
        public Function Function { get; set; }

        /// <summary>
        /// Gets or sets the category in which the function is contained.
        /// </summary>
        public string Category { get; set; }
    }
}
