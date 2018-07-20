using System;
using System.Linq;
using Mono.Cecil;
using Mono.Cecil.Cil;
using Mono.Cecil.Rocks;
using OpenTK.Rewrite.Extensions;

namespace OpenTK.Rewrite.Method.Processors
{
    public sealed class ReturnTypeProcessor : IMethodProcessor
    {
        private readonly TypeDefinition _intPtrType;
        private readonly TypeDefinition _stringType;

        public ReturnTypeProcessor(AssemblyDefinition mscorlib)
        {
            if (mscorlib == null)
            {
                throw new ArgumentNullException(nameof(mscorlib));
            }

            _intPtrType = mscorlib.MainModule.GetType(typeof(IntPtr).FullName);
            _stringType = mscorlib.MainModule.GetType(typeof(string).FullName);
        }

        public void Process(ILProcessor ilProcessor, MethodDefinition wrapper, MethodDefinition native)
        {
            if (wrapper.ReturnType.FullNameEquals(typeof(void)) ||
                wrapper.ReturnType == native.ReturnType ||
                wrapper.ReturnType.Resolve().IsEnum ||
                (wrapper.ReturnType.FullNameEquals<bool>() && native.ReturnType.FullNameEquals<byte>()))
            {
                // Nothing to do
                return;
            }

            if (wrapper.Parameters.Count < native.Parameters.Count)
            {
                // Convenience wrapper. The result is stored in the last local variable
                ilProcessor.Emit(OpCodes.Ldloc, wrapper.Body.Variables.Count - 1);
                return;
            }

            if (wrapper.ReturnType.FullNameEquals<string>())
            {
                // String return-type wrapper
                // return new string((sbyte*)((void*)GetString()));
                var explicitOperator = wrapper.Module.ImportReference
                (
                    _intPtrType.Methods.First(m =>
                    {
                        return m.Name == "op_Explicit" && m.ReturnType.FullNameEquals(typeof(void*));
                    })
                );

                var stringConstructor = wrapper.Module.ImportReference
                (
                    _stringType
                    .GetConstructors()
                    .First(m =>
                    {
                        var p = m.Parameters;
                        return p.Count > 0 && p[0].ParameterType.FullNameEquals(typeof(sbyte*));
                    })
                );

                ilProcessor.Emit(OpCodes.Call, explicitOperator);
                ilProcessor.Emit(OpCodes.Newobj, stringConstructor);
            }
            else
            {
                Console.Error.WriteLine
                (
                    $"No return wrapper for '{wrapper.ReturnType.FullName}' is implemented yet ({native.Name})."
                );
            }
        }
    }
}
