using Mono.Cecil;

namespace OpenToolkit.Rewrite.Types
{
    /// <summary>
    /// Provides functionality to rewrite a type definition.
    /// </summary>
    public interface ITypeRewriter
    {
        /// <summary>
        /// Rewrites a given type definition.
        /// </summary>
        /// <param name="type">The type definition to rewrite.</param>
        /// <returns>The rewritten type definition.</returns>
        TypeDefinition Rewrite(TypeDefinition type);
    }
}
