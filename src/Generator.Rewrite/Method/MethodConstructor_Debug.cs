using Mono.Cecil;
using Mono.Cecil.Cil;
using Mono.Cecil.Rocks;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenTK.Rewrite.Method
{
    public partial class MethodConstructor
    {
        private readonly IReadOnlyList<string> _graphicsModules = new List<string>
        {
            "OpenTK.Graphics.OpenGL4",
            "OpenTK.Graphics.OpenGL",
            "OpenTK.Graphics.ES10",
            "OpenTK.Graphics.ES11",
            "OpenTK.Graphics.ES20",
            "OpenTK.Graphics.ES30",
        };

        private class DebugVariables
        {
            public Instruction BeginTry;
            public VariableDefinition ErrorHelperLocal;
            public TypeDefinition ErrorHelperType;
            public MethodReference Get_CurrentContext;
            public MethodReference Set_ErrorChecking;
        }

        private DebugVariables EmitDebugPrologue()
        {
            if (_ilProcessor.Body.Method.Name == "GetError")
            {
                return null;
            }

            string moduleName = _ilProcessor.Body.Method.FullName;
            moduleName = moduleName.Substring(moduleName.IndexOf(' ') + 1);
            moduleName = moduleName.Remove(moduleName.IndexOf("::", StringComparison.Ordinal));
            moduleName = moduleName.Remove(moduleName.LastIndexOf('.'));

            // only works for graphics modules due to hardcoded GraphicsContext usage
            if (!_graphicsModules.Contains(moduleName))
            {
                return null;
            }

            var errorHelperType = _wrapper.Module.GetType(moduleName, "ErrorHelper");
            if (errorHelperType == null)
            {
                return null;
            }

            var graphicsContext = _wrapper.Module.GetType("OpenTK.Graphics.GraphicsContext");
            var iGraphicsContext = _wrapper.Module.GetType("OpenTK.Graphics.IGraphicsContext");

            // Get the constructor that takes a GraphicsContext parameter
            var ctor = errorHelperType.GetConstructors().FirstOrDefault(c =>
                c.Parameters.Count == 1 &&
                c.Parameters[0].ParameterType.FullNameEquals(iGraphicsContext));

            if (ctor == null)
            {
                throw new InvalidOperationException($"{errorHelperType} needs a constructor taking {graphicsContext}!");
            }

            var debugVars = new DebugVariables
            {
                ErrorHelperType = errorHelperType,
                Get_CurrentContext = graphicsContext.GetMethod("get_CurrentContext"),
                Set_ErrorChecking = graphicsContext.GetMethod("set_ErrorChecking"),
                ErrorHelperLocal = new VariableDefinition(errorHelperType),
                BeginTry = Instruction.Create(OpCodes.Nop),
            };

            // using (new ErrorHelper(GraphicsContext.CurrentContext)) { ...
            _ilProcessor.Body.Variables.Add(debugVars.ErrorHelperLocal);
            _ilProcessor.Emit(OpCodes.Ldloca, debugVars.ErrorHelperLocal);
            _ilProcessor.Emit(OpCodes.Call, debugVars.Get_CurrentContext);
            _ilProcessor.Emit(OpCodes.Call, ctor);
            _ilProcessor.Append(debugVars.BeginTry);

            // Special case Begin to turn off error checking.
            if (_ilProcessor.Body.Method.Name == "Begin")
            {
                _ilProcessor.Emit(OpCodes.Call, debugVars.Get_CurrentContext);
                _ilProcessor.Emit(OpCodes.Ldc_I4_0);
                _ilProcessor.Emit(OpCodes.Conv_I1);
                _ilProcessor.Emit(OpCodes.Call, debugVars.Set_ErrorChecking);
            }

            return debugVars;
        }

        private void EmitDebugEpilogue(DebugVariables debugVars)
        {
            if (debugVars == null)
            {
                return;
            }

            var disposeMethod = debugVars.ErrorHelperType.GetMethod("Dispose");

            // Store then reload the result from the call
            var resultLocal = new VariableDefinition(_wrapper.ReturnType);
            if (!resultLocal.VariableType.FullNameEquals(_voidType))
            {
                _ilProcessor.Body.Variables.Add(resultLocal);
                _ilProcessor.Emit(OpCodes.Stloc, resultLocal);
            }

            // Special case End to turn on error checking.
            if (_ilProcessor.Body.Method.Name == "End")
            {
                _ilProcessor.Emit(OpCodes.Call, debugVars.Get_CurrentContext);
                _ilProcessor.Emit(OpCodes.Ldc_I4_1);
                _ilProcessor.Emit(OpCodes.Conv_I1);
                _ilProcessor.Emit(OpCodes.Call, debugVars.Set_ErrorChecking);
            }

            // We need a NOP to set up the finally handler range correctly.
            var nopInstruction = Instruction.Create(OpCodes.Nop);
            var endTryInstruction = Instruction.Create(OpCodes.Leave, nopInstruction);
            var loadInstruction = Instruction.Create(OpCodes.Ldloca, debugVars.ErrorHelperLocal);
            var disposeInstruction = Instruction.Create(OpCodes.Call, disposeMethod);
            var endFinallyInstruction = Instruction.Create(OpCodes.Endfinally);

            _ilProcessor.Append(endTryInstruction);
            _ilProcessor.Append(loadInstruction);
            _ilProcessor.Append(disposeInstruction);
            _ilProcessor.Append(endFinallyInstruction);
            _ilProcessor.Append(nopInstruction);

            var finallyHandler = new ExceptionHandler(ExceptionHandlerType.Finally)
            {
                TryStart = debugVars.BeginTry,
                TryEnd = loadInstruction,
                HandlerStart = loadInstruction,
                HandlerEnd = nopInstruction
            };

            _ilProcessor.Body.ExceptionHandlers.Add(finallyHandler);

            if (!resultLocal.VariableType.FullNameEquals(_voidType))
            {
                _ilProcessor.Emit(OpCodes.Ldloc, resultLocal);
            }
        }
    }
}
