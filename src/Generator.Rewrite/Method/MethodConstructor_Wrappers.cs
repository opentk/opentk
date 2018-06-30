using Mono.Cecil.Cil;
using Mono.Cecil.Rocks;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenTK.Rewrite.Method
{
    public partial class MethodConstructor
    {
        private void EmitReturnTypeWrapper()
        {
            if (_wrapper.Parameters.Count < _native.Parameters.Count)
            {
                // Convenience wrapper. The result is stored in the last local variable
                _ilProcessor.Emit(OpCodes.Ldloc, _body.Variables.Count - 1);
                return;
            }
            if (_wrapper.ReturnType == _native.ReturnType)
            {
                return;
            }
            if (_wrapper.ReturnType.Resolve().IsEnum)
            {
                // Nothing to do
                return;
            }
            if (_wrapper.ReturnType.FullNameEquals<bool>() && _native.ReturnType.FullNameEquals<byte>())
            {
                // It appears that a byte with 1 = true (GL_TRUE) and 0 = false (GL_FALSE)
                // can be reinterpreted as a bool without a problem.
                return;
            }

            if (_wrapper.ReturnType.FullNameEquals<string>())
            {
                // String return-type wrapper
                // return new string((sbyte*)((void*)GetString()));
                var opExplicit = _intPtrType.GetMethod("op_Explicit");
                if (!opExplicit.ReturnType.FullNameEquals(typeof(void*)))
                {
                    throw new InvalidOperationException();
                }

                var stringConstructor = _wrapper.Module.ImportReference(_stringType
                    .GetConstructors()
                    .First(m =>
                    {
                        var p = m.Parameters;
                        return p.Count > 0 && p[0].ParameterType.FullNameEquals(typeof(sbyte*));
                    }));

                _ilProcessor.Emit(OpCodes.Call, opExplicit);
                _ilProcessor.Emit(OpCodes.Newobj, stringConstructor);
            }
            else
            {
                Console.Error.WriteLine($"Return wrapper for '{_wrapper.ReturnType.FullName}' not implemented yet ({_native.Name}).");
            }
        }

        private IEnumerable<GeneratedVariableIdentifier> EmitConvenienceWrapper(int difference)
        {
            if (_wrapper.Parameters.Count > 2)
            {
                // Todo: emit all parameters bar the last two
                throw new NotImplementedException();
            }

            bool returnsVoid = _wrapper.ReturnType.FullNameEquals(typeof(void));

            if (difference == 1)
            {
                if (returnsVoid)
                {
                    // Convert in-array/reference to single element, for example:
                    // void DeleteTextures(int n, ref int textures) -> void DeleteTexture(int texture)
                    // {
                    //   const int n = 1;
                    //   calli DeleteTextures(n, &textures);
                    // }
                    _ilProcessor.Emit(OpCodes.Ldc_I4, 1); // const int n = 1
                    _ilProcessor.Emit(OpCodes.Ldarga, _wrapper.Parameters.Last()); // &textures
                }
                else
                {
                    // Convert unsized out-array/reference to return value, for example:
                    // void GetBoolean(GetPName pname, out bool data) -> bool GetBoolean(GetPName pname)
                    // {
                    //   bool result;
                    //   GetBooleanv(pname, &result);
                    //   return result;
                    // }
                    _body.Variables.Add(new VariableDefinition(_wrapper.ReturnType));

                    var generatedVariables = EmitParameters();
                    _ilProcessor.Emit(OpCodes.Ldloca, _body.Variables.Count - 1);
                    return generatedVariables;
                }
            }
            else if (difference == 2 && !returnsVoid)
            {
                // Convert sized out-array/reference to return value, for example:
                // void GenTextures(int n, int[] textures) -> int GenTexture()
                // {
                //  const int n = 1;
                //  int buffers;
                //  calli GenTextures(n, &textures);
                //  return result;
                // }
                _body.Variables.Add(new VariableDefinition(_wrapper.ReturnType));
                _ilProcessor.Emit(OpCodes.Ldc_I4, 1); // const int n = 1
                _ilProcessor.Emit(OpCodes.Ldloca, _body.Variables.Count - 1); // &buffers
            }
            else
            {
                Console.Error.WriteLine($"Unknown wrapper type for {_native.Name}.");
            }

            return Enumerable.Empty<GeneratedVariableIdentifier>();
        }
    }
}
