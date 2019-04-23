using System.Collections.Generic;
using Bind.XML.Signatures.Enumerations;

namespace Bind.Structure
{
    /// <summary>
    /// Represents a bindings project.
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Project" /> class.
        /// </summary>
        /// <param name="extension">The extension to which this project belongs.</param>
        /// <param name="interfaces">The interfaces within this project.</param>
        /// <param name="enums">The enums within this project.</param>
        public Project(string extension, IEnumerable<Interface> interfaces, IEnumerable<EnumerationSignature> enums)
        {
            Extension = extension;
            Interfaces = interfaces;
            Enums = enums;
        }
        
        /// <summary>
        /// Gets or sets the extension to which this project belongs.
        /// </summary>
        public string Extension { get; set; }

        /// <summary>
        /// Gets or sets the enumerations within this project.
        /// </summary>
        public IEnumerable<EnumerationSignature> Enums { get; set; }

        /// <summary>
        /// Gets or sets the interfaces within this project.
        /// </summary>
        public IEnumerable<Interface> Interfaces { get; set; }
    }
}
