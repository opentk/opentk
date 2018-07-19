using System;
using Mono.Cecil;

namespace OpenTK.Rewrite.Method
{
    public class MethodProcessingInfo
    {
        public MethodProcessingInfo
        (
            AssemblyDefinition mscorlib,
            RewriteOptions options,
            TypeDefinition bindingsBaseType
        )
        {
            Mscorlib = mscorlib ?? throw new ArgumentNullException(nameof(mscorlib));
            Options = options ?? throw new ArgumentNullException(nameof(options));
            BindingsBaseType = bindingsBaseType ?? throw new ArgumentNullException(nameof(bindingsBaseType));
        }

        public AssemblyDefinition Mscorlib { get; }

        public RewriteOptions Options { get; }

        public TypeDefinition BindingsBaseType { get; }
    }
}
