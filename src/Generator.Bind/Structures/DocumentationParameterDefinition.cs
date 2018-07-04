namespace Bind.Structures
{
    /// <summary>
    /// Holds data for a documentation element for a single parameter.
    /// </summary>
    internal class DocumentationParameterDefinition
    {
        /// <summary>
        /// Gets or sets the name of the documented parameter.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the content of the parameter documentation.
        /// </summary>
        public string Documentation { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentationParameterDefinition"/> class.
        /// </summary>
        /// <param name="name">The name of the parameter.</param>
        /// <param name="doc">The contents of the documentation.</param>
        public DocumentationParameterDefinition(string name, string doc)
        {
            Name = name;
            Documentation = doc;
        }
    }
}
