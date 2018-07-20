using Mono.Cecil;

namespace OpenTK.Rewrite.Methods
{
    public interface IMethodRewriter
    {
        MethodDefinition Rewrite(MethodDefinition wrapper, MethodDefinition native);
    }
}
