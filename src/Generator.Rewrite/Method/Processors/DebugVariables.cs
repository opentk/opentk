using Mono.Cecil;
using Mono.Cecil.Cil;

namespace OpenTK.Rewrite.Method.Processors
{
    public sealed class DebugVariables
    {
        public DebugVariables
        (
            Instruction beginTry,
            TypeDefinition errorHelperType,
            MethodReference get_currentContext,
            MethodReference set_errorChecking
        )
        {
            BeginTry = beginTry;
            ErrorHelperType = errorHelperType;
            ErrorHelperLocal = new VariableDefinition(errorHelperType);
            Get_CurrentContext = get_currentContext;
            Set_ErrorChecking = set_errorChecking;
        }

        public Instruction BeginTry { get; }

        public TypeDefinition ErrorHelperType { get; }

        public VariableDefinition ErrorHelperLocal { get; }

        public MethodReference Get_CurrentContext { get; }

        public MethodReference Set_ErrorChecking { get; }
    }
}
