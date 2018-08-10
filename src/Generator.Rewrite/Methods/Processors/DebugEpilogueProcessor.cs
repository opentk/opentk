using Mono.Cecil;
using Mono.Cecil.Cil;
using OpenTK.Rewrite.Extensions;

namespace OpenTK.Rewrite.Methods.Processors
{
    /// <summary>
    /// Rewrites wrapper method IL to include the epilogue for the debug configuration.
    /// </summary>
    public sealed class DebugEpilogueProcessor : EpilogueProcessor<DebugVariables>
    {
        private readonly TypeDefinition _voidType;

        /// <summary>
        /// Initializes a new instance of the <see cref="DebugEpilogueProcessor"/> class
        /// with a given mscorlib assembly definition.
        /// </summary>
        /// <param name="mscorlib">The mscorlib assembly definition to set up this processor.</param>
        public DebugEpilogueProcessor(AssemblyDefinition mscorlib)
        {
            _voidType = mscorlib.MainModule.GetType(typeof(void).FullName);
        }

        /// <inheritdoc/>
        protected override void ProcessEpilogue
        (
            ILProcessor cilProcessor,
            MethodDefinition wrapper,
            MethodDefinition native,
            DebugVariables debugVariables
        )
        {
            if (debugVariables is null)
            {
                return;
            }

            var disposeMethod = debugVariables.ErrorHelperType.GetMethod("Dispose");

            // Store then reload the result from the call
            var resultLocal = new VariableDefinition(wrapper.ReturnType);
            if (!resultLocal.VariableType.FullNameEquals(_voidType))
            {
                cilProcessor.Body.Variables.Add(resultLocal);
                cilProcessor.Emit(OpCodes.Stloc, resultLocal);
            }

            // Special case End to turn on error checking.
            if (cilProcessor.Body.Method.Name == "End")
            {
                cilProcessor.Emit(OpCodes.Call, debugVariables.Get_CurrentContext);
                cilProcessor.Emit(OpCodes.Ldc_I4_1);
                cilProcessor.Emit(OpCodes.Conv_I1);
                cilProcessor.Emit(OpCodes.Call, debugVariables.Set_ErrorChecking);
            }

            // We need a NOP to set up the finally handler range correctly.
            var nopInstruction = Instruction.Create(OpCodes.Nop);
            var endTryInstruction = Instruction.Create(OpCodes.Leave, nopInstruction);
            var loadInstruction = Instruction.Create(OpCodes.Ldloca, debugVariables.ErrorHelperLocal);
            var disposeInstruction = Instruction.Create(OpCodes.Call, disposeMethod);
            var endFinallyInstruction = Instruction.Create(OpCodes.Endfinally);

            cilProcessor.Append(endTryInstruction);
            cilProcessor.Append(loadInstruction);
            cilProcessor.Append(disposeInstruction);
            cilProcessor.Append(endFinallyInstruction);
            cilProcessor.Append(nopInstruction);

            var finallyHandler = new ExceptionHandler(ExceptionHandlerType.Finally)
            {
                TryStart = debugVariables.BeginTry,
                TryEnd = loadInstruction,
                HandlerStart = loadInstruction,
                HandlerEnd = nopInstruction
            };

            cilProcessor.Body.ExceptionHandlers.Add(finallyHandler);

            if (!resultLocal.VariableType.FullNameEquals(_voidType))
            {
                cilProcessor.Emit(OpCodes.Ldloc, resultLocal);
            }
        }
    }
}
