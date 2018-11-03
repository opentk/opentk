using Mono.Cecil;

namespace OpenToolkit.Rewrite.Methods
{
    /// <summary>
    /// Provides an interface to rewrite method definitions.
    /// </summary>
    public interface IMethodRewriter
    {
        /// <summary>
        /// Rewrite a given wrapper method definition to call a given native function call.
        /// </summary>
        /// <param name="wrapper">The wrapper method definition that should be rewritten.</param>
        /// <param name="native">The native function that should be called by the wrapper.</param>
        /// <returns>The rewritten wrapper method definition.</returns>
        MethodDefinition Rewrite(MethodDefinition wrapper, MethodDefinition native);
    }
}
