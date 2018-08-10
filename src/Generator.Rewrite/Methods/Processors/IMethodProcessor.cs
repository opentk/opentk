using Mono.Cecil;
using Mono.Cecil.Cil;

namespace OpenTK.Rewrite.Methods.Processors
{
    /// <summary>
    /// Provides functionality to rewrite a method definition for a managed wrapper method.
    /// </summary>
    public interface IMethodProcessor
    {
        /// <summary>
        /// Processes the IL of a managed wrapper method definition to call a native function.
        /// </summary>
        /// <param name="cilProcessor">The IL processor for the wrapper method definition.</param>
        /// <param name="wrapper">The method definition for the managed wrapper method.</param>
        /// <param name="native">The method definition for the native function.</param>
        void Process(ILProcessor cilProcessor, MethodDefinition wrapper, MethodDefinition native);
    }
}
