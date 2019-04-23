using System.Collections.Generic;
using Bind.XML.Signatures.Functions;

namespace Bind.Structure
{
    /// <summary>
    /// Represents an interfaces to which native signatures are contained.
    /// </summary>
    public class Interface
    {
        public Interface(string name, IEnumerable<FunctionSignature> signatures)
        {
            InterfaceName = name;
            Functions = signatures;
        }
        
        /// <summary>
        /// Gets or sets the name of this interface.
        /// </summary>
        public string InterfaceName { get; set; }

        /// <summary>
        /// Gets or sets the functions contained within this interface.
        /// </summary>
        public IEnumerable<FunctionSignature> Functions { get; set; }
    }
}
