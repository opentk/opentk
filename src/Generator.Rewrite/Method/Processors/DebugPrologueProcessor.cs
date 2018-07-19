using System;
using System.Collections.Generic;
using System.Linq;
using Mono.Cecil;
using Mono.Cecil.Cil;
using Mono.Cecil.Rocks;
using OpenTK.Rewrite.Extensions;

namespace OpenTK.Rewrite.Method.Processors
{
    public class DebugPrologueProcessor : IMethodProcessorWithEpilogue
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

        private DebugVariables _debugVariables;

        public IMethodProcessor EpilogueProcessor => throw new System.NotImplementedException();

        public void Process(ILProcessor ilProcessor, MethodDefinition wrapper, MethodDefinition native)
        {
            if (ilProcessor.Body.Method.Name == "GetError")
            {
                return;
            }

            string moduleName = ilProcessor.Body.Method.FullName;
            moduleName = moduleName.Substring(moduleName.IndexOf(' ') + 1);
            moduleName = moduleName.Remove(moduleName.IndexOf("::", StringComparison.Ordinal));
            moduleName = moduleName.Remove(moduleName.LastIndexOf('.'));

            // only works for graphics modules due to hardcoded GraphicsContext usage
            if (!_graphicsModules.Contains(moduleName))
            {
                return;
            }

            var errorHelperType = wrapper.Module.GetType(moduleName, "ErrorHelper");
            if (errorHelperType == null)
            {
                return;
            }

            var graphicsContext = wrapper.Module.GetType("OpenTK.Graphics.GraphicsContext");
            var graphicsContextInterface = wrapper.Module.GetType("OpenTK.Graphics.IGraphicsContext");

            // Get the constructor that takes a GraphicsContext parameter
            var ctor = errorHelperType.GetConstructors().FirstOrDefault(c =>
            {
                return c.Parameters.Count == 1 &&
                    c.Parameters[0].ParameterType.FullNameEquals(graphicsContextInterface);
            });

            if (ctor == null)
            {
                throw new InvalidOperationException
                (
                    $"{errorHelperType} needs a constructor taking {graphicsContext}!"
                );
            }

            _debugVariables = new DebugVariables
            (
                Instruction.Create(OpCodes.Nop),
                errorHelperType,
                graphicsContext.GetMethod("get_CurrentContext"),
                graphicsContext.GetMethod("set_ErrorChecking")
            );

            // using (new ErrorHelper(GraphicsContext.CurrentContext)) { ...
            ilProcessor.Body.Variables.Add(_debugVariables.ErrorHelperLocal);
            ilProcessor.Emit(OpCodes.Ldloca, _debugVariables.ErrorHelperLocal);
            ilProcessor.Emit(OpCodes.Call, _debugVariables.Get_CurrentContext);
            ilProcessor.Emit(OpCodes.Call, ctor);
            ilProcessor.Append(_debugVariables.BeginTry);

            // Special case Begin to turn off error checking.
            if (ilProcessor.Body.Method.Name == "Begin")
            {
                ilProcessor.Emit(OpCodes.Call, _debugVariables.Get_CurrentContext);
                ilProcessor.Emit(OpCodes.Ldc_I4_0);
                ilProcessor.Emit(OpCodes.Conv_I1);
                ilProcessor.Emit(OpCodes.Call, _debugVariables.Set_ErrorChecking);
            }
        }
    }
}
