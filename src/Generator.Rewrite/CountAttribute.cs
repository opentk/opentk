namespace OpenToolkit.Rewrite
{
    /// <summary>
    /// A copy of OpenToolkit.CountAttribute. Only for internal use.
    /// </summary>
    internal sealed class CountAttribute
    {
        /// <summary>
        /// Gets or sets a computed count based on other parameters.
        /// </summary>
        public string Computed { get; set; }

        /// <summary>
        /// Gets or sets a fixed count.
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// Gets or sets another parameter to look at for the count of this parameter.
        /// </summary>
        public string Parameter { get; set; }
    }
}
