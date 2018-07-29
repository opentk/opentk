using System;
using System.Collections.Generic;
using System.Linq;
using Mono.Cecil;
using Mono.Cecil.Cil;
using Mono.Cecil.Rocks;
using OpenTK.Rewrite.Extensions;

namespace OpenTK.Rewrite.Methods.Processors
{
    public sealed class DebugPrologueProcessor : MethodProcessorWithEpilogue<DebugVariables>
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

        public DebugPrologueProcessor(AssemblyDefinition mscorlib)
            : base(new DebugEpilogueProcessor(mscorlib))
        {
        }

        public override void Process(ILProcessor ilProcessor, MethodDefinition wrapper, MethodDefinition native)
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
            if (errorHelperType is null)
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

            if (ctor is null)
            {
                throw new InvalidOperationException
                (
                    $"{errorHelperType} needs a constructor taking {graphicsContext}!"
                );
            }

            var debugVariables = new DebugVariables
            (
                Instruction.Create(OpCodes.Nop),
                errorHelperType,
                graphicsContext.GetMethod("get_CurrentContext"),
                graphicsContext.GetMethod("set_ErrorChecking")
            );

            // using (new ErrorHelper(GraphicsContext.CurrentContext)) { ...
            ilProcessor.Body.Variables.Add(debugVariables.ErrorHelperLocal);
            ilProcessor.Emit(OpCodes.Ldloca, debugVariables.ErrorHelperLocal);
            ilProcessor.Emit(OpCodes.Call, debugVariables.Get_CurrentContext);
            ilProcessor.Emit(OpCodes.Call, ctor);
            ilProcessor.Append(debugVariables.BeginTry);

            // Special case Begin to turn off error checking.
            if (ilProcessor.Body.Method.Name == "Begin")
            {
                ilProcessor.Emit(OpCodes.Call, debugVariables.Get_CurrentContext);
                ilProcessor.Emit(OpCodes.Ldc_I4_0);
                ilProcessor.Emit(OpCodes.Conv_I1);
                ilProcessor.Emit(OpCodes.Call, debugVariables.Set_ErrorChecking);
            }

            EpilogueProcessor.RewriteVariables.TryAdd(wrapper, debugVariables);
        }
    }
}
