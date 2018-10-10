using Mono.Cecil;
using Mono.Cecil.Cil;

namespace OpenTK.Rewrite.Methods.Processors
{
    /// <summary>
    /// A class containing properties to pass between the debug prologue and epilogue IL rewriting step.
    /// </summary>
    public sealed class DebugVariables
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DebugVariables"/> class.
        /// </summary>
        /// <param name="beginTry">The instruction for the try-statement.</param>
        /// <param name="errorHelperType">The 'ErrorHelper' type definition.</param>
        /// <param name="get_currentContext">The 'get_CurrentContext' method definition.</param>
        /// <param name="set_errorChecking">The 'set_ErrorChecking' method definition.</param>
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

        /// <summary>
        /// Gets the instruction for the try-statement.
        /// </summary>
        public Instruction BeginTry { get; }

        /// <summary>
        /// Gets the 'ErrorHelper' type definition.
        /// </summary>
        public TypeDefinition ErrorHelperType { get; }

        /// <summary>
        /// Gets a variable definition of type 'ErrorHelper' (<see cref="ErrorHelperType"/>).
        /// </summary>
        public VariableDefinition ErrorHelperLocal { get; }

        /// <summary>
        /// Gets the 'get_CurrentContext' method definition.
        /// </summary>
        public MethodReference Get_CurrentContext { get; }

        /// <summary>
        /// Gets the 'set_ErrorChecking' method definition.
        /// </summary>
        public MethodReference Set_ErrorChecking { get; }
    }
}
