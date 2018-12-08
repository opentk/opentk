using System.Collections.Generic;

namespace Bind.Writers.Structure.Projects
{
    /// <summary>
    /// Represents a C# attribute.
    /// </summary>
    public class Attribute
    {
        /// <summary>
        /// Gets or sets the class of the attribute.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets arguments to be added to this <see cref="Attribute"/>'s constructors.
        /// </summary>
        public List<string> Arguments { get; set; }
    }
}
