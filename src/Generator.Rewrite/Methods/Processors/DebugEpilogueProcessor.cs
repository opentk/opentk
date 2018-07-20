using Mono.Cecil;
using Mono.Cecil.Cil;
using OpenTK.Rewrite.Extensions;

namespace OpenTK.Rewrite.Methods.Processors
{
    public sealed class DebugEpilogueProcessor : IMethodProcessor
    {
        private readonly DebugVariables _debugVariables;
        private readonly TypeDefinition _voidType;

        public DebugEpilogueProcessor(AssemblyDefinition mscorlib, DebugVariables debugVariables)
        {
            _voidType = mscorlib.MainModule.GetType(typeof(void).FullName);
            _debugVariables = debugVariables;
        }

        public void Process(ILProcessor ilProcessor, MethodDefinition wrapper, MethodDefinition native)
        {
            if (_debugVariables == null)
            {
                return;
            }

            var disposeMethod = _debugVariables.ErrorHelperType.GetMethod("Dispose");

            // Store then reload the result from the call
            var resultLocal = new VariableDefinition(wrapper.ReturnType);
            if (!resultLocal.VariableType.FullNameEquals(_voidType))
            {
                ilProcessor.Body.Variables.Add(resultLocal);
                ilProcessor.Emit(OpCodes.Stloc, resultLocal);
            }

            // Special case End to turn on error checking.
            if (ilProcessor.Body.Method.Name == "End")
            {
                ilProcessor.Emit(OpCodes.Call, _debugVariables.Get_CurrentContext);
                ilProcessor.Emit(OpCodes.Ldc_I4_1);
                ilProcessor.Emit(OpCodes.Conv_I1);
                ilProcessor.Emit(OpCodes.Call, _debugVariables.Set_ErrorChecking);
            }

            // We need a NOP to set up the finally handler range correctly.
            var nopInstruction = Instruction.Create(OpCodes.Nop);
            var endTryInstruction = Instruction.Create(OpCodes.Leave, nopInstruction);
            var loadInstruction = Instruction.Create(OpCodes.Ldloca, _debugVariables.ErrorHelperLocal);
            var disposeInstruction = Instruction.Create(OpCodes.Call, disposeMethod);
            var endFinallyInstruction = Instruction.Create(OpCodes.Endfinally);

            ilProcessor.Append(endTryInstruction);
            ilProcessor.Append(loadInstruction);
            ilProcessor.Append(disposeInstruction);
            ilProcessor.Append(endFinallyInstruction);
            ilProcessor.Append(nopInstruction);

            var finallyHandler = new ExceptionHandler(ExceptionHandlerType.Finally)
            {
                TryStart = _debugVariables.BeginTry,
                TryEnd = loadInstruction,
                HandlerStart = loadInstruction,
                HandlerEnd = nopInstruction
            };

            ilProcessor.Body.ExceptionHandlers.Add(finallyHandler);

            if (!resultLocal.VariableType.FullNameEquals(_voidType))
            {
                ilProcessor.Emit(OpCodes.Ldloc, resultLocal);
            }
        }
    }
}
