namespace Bind.XML.Overrides.Functions
{
    /// <summary>
    /// Represents a function removal override.
    /// </summary>
    public class RemoveOverride
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveOverride"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="type">The name type.</param>
        public RemoveOverride(string name, OverrideNameType type)
        {
            Name = name;
            NameType = type;
        }

        /// <summary>
        /// Gets the name or entrypoint of the function to remove.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets an enumeration indicating whether the <see cref="Name"/> property is a function name or entrypoint.
        /// </summary>
        public OverrideNameType NameType { get; }
    }
}
