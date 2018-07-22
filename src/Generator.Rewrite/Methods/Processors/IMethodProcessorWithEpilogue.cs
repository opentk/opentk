using Mono.Cecil;
using Mono.Cecil.Cil;

namespace OpenTK.Rewrite.Methods.Processors
{
    public interface IMethodProcessorWithEpilogue : IMethodProcessor
    {
        void ProcessEpilogue(ILProcessor ilProcessor, MethodDefinition wrapper, MethodDefinition native);
    }
}
