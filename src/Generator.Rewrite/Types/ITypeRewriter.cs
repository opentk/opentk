using Mono.Cecil;

namespace OpenTK.Rewrite.Types
{
    public interface ITypeRewriter
    {
        TypeDefinition Rewrite(TypeDefinition type);
    }
}
