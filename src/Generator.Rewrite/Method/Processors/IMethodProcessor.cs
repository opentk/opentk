using Mono.Cecil;
using Mono.Cecil.Cil;

namespace OpenTK.Rewrite.Method.Processors
{
    public interface IMethodProcessor
    {
        void Process(ILProcessor ilProcessor, MethodDefinition wrapper, MethodDefinition native);
    }
}
