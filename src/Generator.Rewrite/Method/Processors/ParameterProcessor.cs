using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Mono.Cecil;
using Mono.Cecil.Cil;
using Mono.Cecil.Rocks;
using OpenTK.Rewrite.Extensions;

namespace OpenTK.Rewrite.Method.Processors
{
    public class ParameterProcessor : IMethodProcessorWithEpilogue
    {
        private readonly List<VariableIdentifier> _generatedVariables = new List<VariableIdentifier>();

        private readonly TypeDefinition _bindingsBaseType;

        private readonly TypeDefinition _arrayType;
        private readonly TypeDefinition _int32Type;
        private readonly TypeDefinition _intPtrType;
        private readonly TypeDefinition _marshalType;

        private ILProcessor _ilProcessor;
        private MethodDefinition _wrapper;
        private MethodDefinition _native;

        public IMethodProcessor EpilogueProcessor { get; }

        public ParameterProcessor(AssemblyDefinition mscorlib, TypeDefinition bindingsBaseType)
        {
            EpilogueProcessor = new ParameterEpilogueProcessor(mscorlib, bindingsBaseType, _generatedVariables);

            _bindingsBaseType = bindingsBaseType ?? throw new ArgumentNullException(nameof(bindingsBaseType));

            _arrayType = mscorlib.MainModule.GetType(typeof(Array).FullName);
            _int32Type = mscorlib.MainModule.GetType(typeof(int).FullName);
            _intPtrType = mscorlib.MainModule.GetType(typeof(IntPtr).FullName);
            _marshalType = mscorlib.MainModule.GetType(typeof(Marshal).FullName);
        }

        public void Process(ILProcessor ilProcessor, MethodDefinition wrapper, MethodDefinition native)
        {
            _ilProcessor = ilProcessor;
            _wrapper = wrapper;
            _native = native;

            int paramCountDifference = native.Parameters.Count - wrapper.Parameters.Count;
            if (paramCountDifference == 0)
            {
                EmitParameters();
            }
            else
            {
                EmitConvenienceWrapper(paramCountDifference);
            }
        }

        private List<VariableIdentifier> EmitParameters()
        {
            for (int i = 0; i < _wrapper.Parameters.Count; i++)
            {
                var parameter = _wrapper.Parameters[i];
                var paramType = _wrapper.Module.ImportReference(parameter.ParameterType);
                _ilProcessor.Emit(OpCodes.Ldarg, i);

                if (paramType.FullNameEquals<int>() && _native.Parameters[i].ParameterType.FullNameEquals<IntPtr>())
                {
                    // This is a convenience Int32 overload for an IntPtr (size_t) parameter.
                    // We need to convert the loaded argument to IntPtr.
                    _ilProcessor.Emit(OpCodes.Conv_I);
                }
                else if (paramType.Name == "String&" && !paramType.IsArray)
                {
                    _generatedVariables.Add(EmitStringOutParameter(parameter));
                }
                else if (paramType.FullNameEquals<string>() && !paramType.IsArray)
                {
                    _generatedVariables.Add(EmitStringParameter(parameter));
                }
                else if (paramType.IsByReference)
                {
                    _wrapper.Body.Variables.Add(new VariableDefinition(new PinnedType(paramType)));
                    var index = _wrapper.Body.Variables.Count - 1;
                    _ilProcessor.Emit(OpCodes.Stloc, index);
                    _ilProcessor.Emit(OpCodes.Ldloc, index);
                    _ilProcessor.Emit(OpCodes.Conv_I);
                }
                else if (paramType.IsArray)
                {
                    if (paramType.FullNameEquals<string[]>())
                    {
                        _generatedVariables.Add(EmitStringParameter(parameter, isArray: true));
                        continue;
                    }

                    // .Net treats 1d arrays differently than higher rank arrays.
                    // 1d arrays are directly supported by instructions such as ldlen and ldelema.
                    // Higher rank arrays must be accessed through System.Array methods such as get_Length.
                    // 1d array:
                    //    check array is not null
                    //    check ldlen array > 0
                    //    ldc.i4.0
                    //    ldelema
                    // 2d array:
                    //    check array is not null
                    //    check array.get_Length() > 0
                    //    ldc.i4.0
                    //    ldc.i4.0
                    //    call instance T& T[0..., 0...]::Address(int32, int32)
                    // Mono treats everything as a 1d array.
                    // Interestingly, the .Net approach works on both Mono and .Net.
                    // The Mono approach fails when using high-rank arrays on .Net.
                    // We should report a bug to http://bugzilla.xamarin.com

                    // Pin the array and pass the address
                    // of its first element.
                    var arrayType = (ArrayType)paramType;
                    var elementType = paramType.GetElementType();
                    _wrapper.Body.Variables.Add(new VariableDefinition(new PinnedType(new ByReferenceType(elementType))));
                    int pinnedIndex = _wrapper.Body.Variables.Count - 1;

                    var empty = _ilProcessor.Create(OpCodes.Ldc_I4, 0);
                    var pin = _ilProcessor.Create(OpCodes.Ldarg, i);
                    var end = _ilProcessor.Create(OpCodes.Stloc, pinnedIndex);

                    // if (arrayTypeType == null) goto empty
                    _ilProcessor.Emit(OpCodes.Brfalse, empty);

                    // else if (arrayType.Length != 0) goto pin
                    _ilProcessor.Emit(OpCodes.Ldarg, i);
                    if (arrayType.Rank == 1)
                    {
                        _ilProcessor.Emit(OpCodes.Ldlen);
                        _ilProcessor.Emit(OpCodes.Conv_I4);
                    }
                    else
                    {
                        var getLength = _wrapper.Module.ImportReference(_arrayType.GetMethod("get_Length"));
                        _ilProcessor.Emit(OpCodes.Callvirt, getLength);
                    }

                    _ilProcessor.Emit(OpCodes.Brtrue, pin);

                    // empty: IntPtr ptr = IntPtr.Zero
                    _ilProcessor.Append(empty);
                    _ilProcessor.Emit(OpCodes.Conv_U);
                    _ilProcessor.Emit(OpCodes.Br, end);

                    // pin: &arrayType[0]
                    _ilProcessor.Append(pin);
                    if (arrayType.Rank == 1)
                    {
                        // 1d arrayType (vector), address is taken by ldelema
                        _ilProcessor.Emit(OpCodes.Ldc_I4, 0);
                        _ilProcessor.Emit(OpCodes.Ldelema, elementType);
                    }
                    else
                    {
                        // 2d-3d arrayType, address must be taken as follows:
                        // call instance T& T[0..., 0..., 0...]::Address(int, int, int)
                        var byRefType = arrayType.ElementType.MakeByReferenceType();
                        var getAddress = new MethodReference("Address", byRefType, arrayType);
                        for (var r = 0; r < arrayType.Rank; r++)
                        {
                            getAddress.Parameters.Add(new ParameterDefinition(_int32Type));
                        }

                        getAddress.HasThis = true;

                        // emit the get_address call
                        for (int r = 0; r < arrayType.Rank; r++)
                        {
                            _ilProcessor.Emit(OpCodes.Ldc_I4, 0);
                        }

                        _ilProcessor.Emit(OpCodes.Call, getAddress);
                    }

                    // end: fixed (IntPtr ptr = &arrayType[0])
                    _ilProcessor.Append(end);
                    _ilProcessor.Emit(OpCodes.Ldloc, pinnedIndex);
                    _ilProcessor.Emit(OpCodes.Conv_I);
                }
            }

            return _generatedVariables;
        }

        private VariableIdentifier EmitStringParameter(ParameterDefinition parameter, bool isArray = false)
        {
            string marshalToPtrName = isArray ? "MarshalStringArrayToPtr" : "MarshalStringToPtr";
            string paramNameSuffix = isArray ? "_string_array_ptr" : "_string_ptr";

            // string marshaling:
            // IntPtr ptr = MarshalStringToPtr(str);
            // try { calli }
            // finally { Marshal.FreeHGlobal(ptr); }
            var marshalStringToPtr = _wrapper.Module.ImportReference(_bindingsBaseType.GetMethod(marshalToPtrName));

            // IntPtr ptr;
            var variableDefinition = new VariableDefinition(_intPtrType);
            _wrapper.Body.Variables.Add(variableDefinition);
            int generatedPointerVarIndex = _wrapper.Body.Variables.Count - 1;

            var stringPtrVar = new VariableIdentifier
            (
                _wrapper.Body,
                variableDefinition,
                parameter.Name + paramNameSuffix
            );

            // ptr = Marshal.StringToHGlobalAnsi(str);
            _ilProcessor.Emit(OpCodes.Call, marshalStringToPtr);
            _ilProcessor.Emit(OpCodes.Stloc, generatedPointerVarIndex);
            _ilProcessor.Emit(OpCodes.Ldloc, generatedPointerVarIndex);

            // The finally block will be emitted in the function epilogue
            return stringPtrVar;
        }

        private VariableIdentifier EmitStringOutParameter(ParameterDefinition parameter)
        {
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

            // Pop off the string parameter that would of just been loaded
            _ilProcessor.Emit(OpCodes.Pop);

            // Make sure we have imported Marshal::AllocHGlobal
            var allocHGlobal = _wrapper.Module.ImportReference(_marshalType.GetMethod(nameof(Marshal.AllocHGlobal)));

            // IntPtr ptr;
            var variableDefinition = new VariableDefinition(_intPtrType);
            _wrapper.Body.Variables.Add(variableDefinition);
            var stringPtrIndex = _wrapper.Body.Variables.Count - 1;

            var stringPtrVar = new VariableIdentifier
            (
                _wrapper.Body,
                variableDefinition,
                parameter.Name + "_string_ptr"
            );

            // ptr = Marshal.AllocHGlobal(count + 1);
            var count = GetCountAttribute(parameter);
            if (count == null)
            {
                // We need a count attribute so we know what size to make the
                // string buffer. Currently every string out parameter has a
                // count attribute but this check is in place to make things
                // clearer if this case is ever hit.
                throw new InvalidOperationException
                (
                    $"{_wrapper.Name} ({parameter.Name}) doesn't have a count attribute."
                );
            }

            if (count.Count != 0)
            {
                // Fixed size
                _ilProcessor.Emit(OpCodes.Ldc_I4, count.Count);
            }
            else if (count.Parameter != null)
            {
                // Parameter sized
                var countVariable = EmitCountVariable(count.Parameter);
                _ilProcessor.Emit(OpCodes.Ldloc, countVariable.Index);
            }
            else if (count.Computed != null)
            {
                if (_wrapper.Name == "GetActiveVarying")
                {
                    // GetActiveVaryingNV's name parameter has a count of "COMPSIZE(program,index,bufSize)"
                    // but really it should be bufSize.
                    var countVariable = EmitCountVariable("bufSize");
                    _ilProcessor.Emit(OpCodes.Ldloc, countVariable.Index);
                }
                else
                {
                    // Computed counts are hard and require manual reading of the specification for each one.
                    throw new NotSupportedException
                    (
                        $"{_wrapper.Name} ({parameter.Name}) requires a computed count: {count.Computed}."
                    );
                }
            }

            _ilProcessor.Emit(OpCodes.Ldc_I4, 1);
            _ilProcessor.Emit(OpCodes.Add);
            _ilProcessor.Emit(OpCodes.Call, allocHGlobal);
            _ilProcessor.Emit(OpCodes.Stloc, stringPtrIndex);
            _ilProcessor.Emit(OpCodes.Ldloc, stringPtrIndex);

            // We'll emit the try-finally block in the epilogue implementation,
            // because we haven't yet emitted all necessary instructions here.

            return stringPtrVar;
        }

        private VariableDefinition EmitCountVariable(string countParameter)
        {
            var countVariable = new VariableDefinition(_int32Type);
            _wrapper.Body.Variables.Add(countVariable);

            // Parameter will either by a simple name, a dereference of a name
            // like "*name" or an expression like "name*5"
            var parameter = _wrapper.GetParameter(countParameter, throwIfNoneFound: false);
            if (parameter != null)
            {
                _ilProcessor.Emit(OpCodes.Ldarg, parameter.Index);
                _ilProcessor.Emit(OpCodes.Stloc, countVariable.Index);
            }
            else if (countParameter[0] == '*')
            {
                var pointerParam = _wrapper.GetParameter(countParameter.Substring(1));

                _ilProcessor.Emit(OpCodes.Ldarg, pointerParam.Index);
                _ilProcessor.Emit(OpCodes.Ldind_I4);
            }
            else
            {
                var operands = countParameter.Split('*');
                parameter = _wrapper.GetParameter(operands[0]);
                var scale = int.Parse(operands[1]);

                _ilProcessor.Emit(OpCodes.Ldarg, parameter.Index);
                _ilProcessor.Emit(OpCodes.Ldc_I4, scale);
                _ilProcessor.Emit(OpCodes.Mul);
                _ilProcessor.Emit(OpCodes.Stloc, countVariable.Index);
            }

            return countVariable;
        }

        private IEnumerable<VariableIdentifier> EmitConvenienceWrapper(int difference)
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
                    _wrapper.Body.Variables.Add(new VariableDefinition(_wrapper.ReturnType));

                    var generatedVariables = EmitParameters();
                    _ilProcessor.Emit(OpCodes.Ldloca, _wrapper.Body.Variables.Count - 1);
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
                _wrapper.Body.Variables.Add(new VariableDefinition(_wrapper.ReturnType));
                _ilProcessor.Emit(OpCodes.Ldc_I4, 1); // const int n = 1
                _ilProcessor.Emit(OpCodes.Ldloca, _wrapper.Body.Variables.Count - 1); // &buffers
            }
            else
            {
                Console.Error.WriteLine($"Unknown wrapper type for {_native.Name}.");
            }

            return Enumerable.Empty<VariableIdentifier>();
        }

        private T GetAttributeField<T>(CustomAttribute attribute, string name)
        {
            return (T)(attribute.Fields.FirstOrDefault(f => f.Name == name).Argument.Value ?? default(T));
        }

        private CountAttribute GetCountAttribute(ParameterDefinition parameter)
        {
            var attribute = parameter.GetCustomAttribute(AttributeNames.Count, throwIfNoneFound: false);

            if (attribute == null)
            {
                return null;
            }

            return new CountAttribute
            {
                Count = GetAttributeField<int>(attribute, nameof(CountAttribute.Count)),
                Parameter = GetAttributeField<string>(attribute, nameof(CountAttribute.Parameter)),
                Computed = GetAttributeField<string>(attribute, nameof(CountAttribute.Computed))
            };
        }
    }
}
