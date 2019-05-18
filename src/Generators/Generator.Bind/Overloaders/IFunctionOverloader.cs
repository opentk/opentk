using System.Collections.Generic;
using System.Text;
using Bind.XML.Signatures.Functions;
using JetBrains.Annotations;

namespace Bind.Overloaders
{
    /// <summary>
    /// Represents a class that can create a set of overloads from a given native signature which has already been
    /// passed through the other stages of the binder.
    /// </summary>
    public interface IFunctionOverloader
    {
        /// <summary>
        /// Creates a set of overload signatures from the given function. If no overloads can be generated for this
        /// signature, we return an empty enumerable.
        /// </summary>
        /// <param name="function">The base function.</param>
        /// <returns>A set of overloads.</returns>
        [NotNull]
        [ItemNotNull]
        IEnumerable<(FunctionSignature, StringBuilder)> CreateOverloads([NotNull] FunctionSignature function);
    }
}
