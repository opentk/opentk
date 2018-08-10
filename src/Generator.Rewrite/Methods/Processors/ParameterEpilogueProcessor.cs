using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Mono.Cecil;
using Mono.Cecil.Cil;
using OpenTK.Rewrite.Extensions;

namespace OpenTK.Rewrite.Methods.Processors
{
    /// <summary>
    /// Rewrites wrapper method IL to include the epilogue for the wrapper method parameters.
    /// </summary>
    public sealed class ParameterEpilogueProcessor : EpilogueProcessor<IEnumerable<VariableIdentifier>>
    {
        private readonly TypeDefinition _bindingsBaseType;

        private readonly TypeDefinition _marshalType;

        private ILProcessor _ilProcessor;
        private MethodDefinition _wrapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterEpilogueProcessor"/> class with a given mscorlib
        /// definition and bindings base type definition.
        /// </summary>
        /// <param name="mscorlib">The mscorlib assembly definition to set up this processor.</param>
        /// <param name="bindingsBaseType">The 'BindingsBase' type used for some helper definitions.</param>
        public ParameterEpilogueProcessor
        (
            AssemblyDefinition mscorlib,
            TypeDefinition bindingsBaseType
        )
        {
            _bindingsBaseType = bindingsBaseType ?? throw new ArgumentNullException(nameof(bindingsBaseType));
            _marshalType = mscorlib.MainModule.GetType(typeof(Marshal).FullName);
        }

        /// <inheritdoc/>
        protected override void ProcessEpilogue
        (
            ILProcessor cilProcessor,
            MethodDefinition wrapper,
            MethodDefinition native,
            IEnumerable<VariableIdentifier> generatedVariables
        )
        {
            _ilProcessor = cilProcessor;
            _wrapper = wrapper;

            foreach (var param in wrapper.Parameters)
            {
                string name = param.Name + (param.ParameterType.IsArray ? "_string_array_ptr" : "_string_ptr");
                var generatedVariable = GetGeneratedVariable(generatedVariables, name);

                if (param.ParameterType.Name == "String&")
                {
                    EmitStringOutEpilogue(param, generatedVariable);
                }
                else if (param.ParameterType.GetElementType().FullNameEquals<string>())
                {
                    // if ParameterType is not an array type, GetElementType() just returns the same type
                    // so this checks for a string or string array type
                    // everything else will be handled by EmitStringEpilogue
                    EmitStringEpilogue(param, generatedVariable, param.ParameterType.IsArray);
                }
            }
        }

        private void EmitStringOutEpilogue(ParameterDefinition parameter, VariableIdentifier generatedPtrVar)
        {
            if (generatedPtrVar is null)
            {
                throw new ArgumentNullException(nameof(generatedPtrVar));
            }

            // void GetShaderInfoLog(..., out String foo)
            // IntPtr foo_string_ptr;
            // try {
            //  foo_string_ptr = Marshal.AllocHGlobal(count + 1);
            //  glGetShaderInfoLog(..., foo_string_ptr);
            //  foo = MarshalPtrToString(foo_string_ptr);
            // }
            // finally {
            //  Marshal.FreeHGlobal(foo_string_ptr);
            // }

            // Make sure we have imported BindingsBase::MarshalPtrToString and Marshal::FreeHGlobal
            var ptrToString = _wrapper.Module.ImportReference(_bindingsBaseType.GetMethod("MarshalPtrToString"));
            var freeHGlobal = _wrapper.Module.ImportReference(_marshalType.GetMethod(nameof(Marshal.FreeHGlobal)));

            var block = new ExceptionHandler(ExceptionHandlerType.Finally)
            {
                TryStart = _wrapper.Body.Instructions[0]
            };

            _ilProcessor.Emit(OpCodes.Ldarg, parameter.Index);
            _ilProcessor.Emit(OpCodes.Ldloc, generatedPtrVar.Definition.Index);
            _ilProcessor.Emit(OpCodes.Call, ptrToString);
            _ilProcessor.Emit(OpCodes.Stind_Ref);

            block.TryEnd = _wrapper.Body.Instructions.Last();
            block.HandlerStart = _wrapper.Body.Instructions.Last();

            _ilProcessor.Emit(OpCodes.Ldloc, generatedPtrVar.Definition.Index);
            _ilProcessor.Emit(OpCodes.Call, freeHGlobal);

            block.HandlerEnd = _wrapper.Body.Instructions.Last();
        }

        private void EmitStringEpilogue
        (
            ParameterDefinition parameter,
            VariableIdentifier generatedPtrVar,
            bool isArray = false
        )
        {
            string freePtrName = isArray ? "FreeStringArrayPtr" : "FreeStringPtr";

            var free = _wrapper.Module.ImportReference(_bindingsBaseType.GetMethod(freePtrName));

            // load ptr
            _ilProcessor.Emit(OpCodes.Ldloc, generatedPtrVar.Definition.Index);

            if (isArray)
            {
                // load stringArray.Length
                _ilProcessor.Emit(OpCodes.Ldarg, parameter.Index);
                _ilProcessor.Emit(OpCodes.Ldlen);
                _ilProcessor.Emit(OpCodes.Conv_I4);
            }

            // call FreeString[Array]Ptr
            _ilProcessor.Emit(OpCodes.Call, free);
        }

        private VariableIdentifier GetGeneratedVariable(IEnumerable<VariableIdentifier> identifiers, string name)
        {
            return identifiers.FirstOrDefault(v =>
            {
                return v.Name == name &&
                    v.Body == _wrapper.Body &&
                    _wrapper.Body.Variables.Contains(v.Definition);
            });
        }
    }
}
