using System;
using System.Collections.Generic;
using System.Linq;
using Mono.Cecil;
using Mono.Cecil.Cil;
using Mono.Cecil.Rocks;
using OpenTK.Rewrite.Extensions;

namespace OpenTK.Rewrite.Methods.Processors
{
    /// <summary>
    /// Rewrites wrapper method IL to include the prologue for the debug configuration.
    /// </summary>
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

        /// <summary>
        /// Initializes a new instance of the <see cref="DebugPrologueProcessor"/> class
        /// with a given mscorlib assembly definition.
        /// </summary>
        /// <param name="mscorlib">The assembly definition used for setting up the epilogue processor.</param>
        public DebugPrologueProcessor(AssemblyDefinition mscorlib)
            : base(new DebugEpilogueProcessor(mscorlib))
        {
        }

        /// <inheritdoc/>
        public override void Process(ILProcessor cilProcessor, MethodDefinition wrapper, MethodDefinition native)
        {
            if (cilProcessor.Body.Method.Name == "GetError")
            {
                return;
            }

            string moduleName = cilProcessor.Body.Method.FullName;
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
            cilProcessor.Body.Variables.Add(debugVariables.ErrorHelperLocal);
            cilProcessor.Emit(OpCodes.Ldloca, debugVariables.ErrorHelperLocal);
            cilProcessor.Emit(OpCodes.Call, debugVariables.Get_CurrentContext);
            cilProcessor.Emit(OpCodes.Call, ctor);
            cilProcessor.Append(debugVariables.BeginTry);

            // Special case Begin to turn off error checking.
            if (cilProcessor.Body.Method.Name == "Begin")
            {
                cilProcessor.Emit(OpCodes.Call, debugVariables.Get_CurrentContext);
                cilProcessor.Emit(OpCodes.Ldc_I4_0);
                cilProcessor.Emit(OpCodes.Conv_I1);
                cilProcessor.Emit(OpCodes.Call, debugVariables.Set_ErrorChecking);
            }

            EpilogueProcessor.RewriteVariables.TryAdd(wrapper, debugVariables);
        }
    }
}
