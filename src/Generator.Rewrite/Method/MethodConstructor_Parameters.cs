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
        private IEnumerable<GeneratedVariableIdentifier> EmitParameters()
        {
            var generatedVariables = new List<GeneratedVariableIdentifier>();
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
                    generatedVariables.Add(EmitStringOutParameter(parameter));
                }
                else if (paramType.FullNameEquals<string>() && !paramType.IsArray)
                {
                    generatedVariables.Add(EmitStringParameter(parameter));
                }
                else if (paramType.IsByReference)
                {
                    _body.Variables.Add(new VariableDefinition(new PinnedType(paramType)));
                    var index = _body.Variables.Count - 1;
                    _ilProcessor.Emit(OpCodes.Stloc, index);
                    _ilProcessor.Emit(OpCodes.Ldloc, index);
                    _ilProcessor.Emit(OpCodes.Conv_I);
                }
                else if (paramType.IsArray)
                {
                    if (paramType.FullNameEquals<string[]>())
                    {
                        generatedVariables.Add(EmitStringParameter(parameter, isArray: true));
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
                    _body.Variables.Add(new VariableDefinition(new PinnedType(new ByReferenceType(elementType))));
                    int pinnedIndex = _body.Variables.Count - 1;

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

            return generatedVariables;
        }

        private GeneratedVariableIdentifier EmitStringParameter(ParameterDefinition parameter, bool isArray = false)
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
            _body.Variables.Add(variableDefinition);
            int generatedPointerVarIndex = _body.Variables.Count - 1;

            var stringPtrVar = new GeneratedVariableIdentifier(_body, variableDefinition, parameter.Name + paramNameSuffix);

            // ptr = Marshal.StringToHGlobalAnsi(str);
            _ilProcessor.Emit(OpCodes.Call, marshalStringToPtr);
            _ilProcessor.Emit(OpCodes.Stloc, generatedPointerVarIndex);
            _ilProcessor.Emit(OpCodes.Ldloc, generatedPointerVarIndex);

            // The finally block will be emitted in the function epilogue
            return stringPtrVar;
        }

        private GeneratedVariableIdentifier EmitStringOutParameter(ParameterDefinition parameter)
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
            var allocHGlobal = _wrapper.Module.ImportReference(_marshalType.GetMethod("AllocHGlobal"));

            // IntPtr ptr;
            var variableDefinition = new VariableDefinition(_intPtrType);
            _body.Variables.Add(variableDefinition);
            var stringPtrIndex = _body.Variables.Count - 1;

            var stringPtrVar = new GeneratedVariableIdentifier(_body, variableDefinition, parameter.Name + "_string_ptr");

            // ptr = Marshal.AllocHGlobal(count + 1);
            var count = GetCountAttribute(parameter);
            if (count == null)
            {
                // We need a count attribute so we know what size to make the
                // string buffer. Currently every string out parameter has a
                // count attribute but this check is in place to make things
                // clearer if this case is ever hit.
                throw new InvalidOperationException($"{_wrapper.Name} ({parameter.Name}) doesn't have a count attribute.");
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
                    // GetActiveVaryingNV's name parameter has a count of "COMPSIZE(program,index,bufSize)" but really it should be bufSize.
                    var countVariable = EmitCountVariable("bufSize");
                    _ilProcessor.Emit(OpCodes.Ldloc, countVariable.Index);
                }
                else
                {
                    // Computed counts are hard and require manual reading of the specification for each one.
                    throw new NotSupportedException($"{_wrapper.Name} ({parameter.Name}) requires a computed count: {count.Computed}.");
                }
            }

            _ilProcessor.Emit(OpCodes.Ldc_I4, 1);
            _ilProcessor.Emit(OpCodes.Add);
            _ilProcessor.Emit(OpCodes.Call, allocHGlobal);
            _ilProcessor.Emit(OpCodes.Stloc, stringPtrIndex);
            _ilProcessor.Emit(OpCodes.Ldloc, stringPtrIndex);

            // We'll emit the try-finally block in the ep_ilProcessorogue implementation,
            // because we haven't yet emitted all necessary instructions here.

            return stringPtrVar;
        }

        private void EmitStringOutEpilogue(ParameterDefinition parameter, GeneratedVariableIdentifier generatedPtrVar)
        {
            if (generatedPtrVar == null)
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
            var freeHGlobal = _wrapper.Module.ImportReference(_marshalType.GetMethod("FreeHGlobal"));

            var block = new ExceptionHandler(ExceptionHandlerType.Finally)
            {
                TryStart = _body.Instructions[0]
            };

            _ilProcessor.Emit(OpCodes.Ldarg, parameter.Index);
            _ilProcessor.Emit(OpCodes.Ldloc, generatedPtrVar.Definition.Index);
            _ilProcessor.Emit(OpCodes.Call, ptrToString);
            _ilProcessor.Emit(OpCodes.Stind_Ref);

            block.TryEnd = _body.Instructions.Last();
            block.HandlerStart = _body.Instructions.Last();

            _ilProcessor.Emit(OpCodes.Ldloc, generatedPtrVar.Definition.Index);
            _ilProcessor.Emit(OpCodes.Call, freeHGlobal);

            block.HandlerEnd = _body.Instructions.Last();
        }

        private VariableDefinition EmitCountVariable(string countParameter)
        {
            var countVariable = new VariableDefinition(_int32Type);
            _body.Variables.Add(countVariable);

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

        private GeneratedVariableIdentifier GetGeneratedVariable(IEnumerable<GeneratedVariableIdentifier> identifiers, string name)
        {
            return identifiers.FirstOrDefault(v => v.Name == name && v.Body == _body && _body.Variables.Contains(v.Definition));
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

        private void EmitParameterEpilogues(IEnumerable<GeneratedVariableIdentifier> generatedVariables)
        {
            foreach (var param in _wrapper.Parameters)
            {
                string name = param.Name + (param.ParameterType.IsArray ? "_string_array_ptr" : "_string_ptr");
                var generatedVariable = GetGeneratedVariable(generatedVariables, name);

                if (param.ParameterType.Name == "String&")
                {
                    EmitStringOutEpilogue(param, generatedVariable);
                }
                // if ParameterType is not an array type, GetElementType() just returns the same type
                // so this checks for a string or string array type
                // everything else will be handled by EmitStringEpilogue
                else if (param.ParameterType.GetElementType().FullNameEquals<string>())
                {
                    EmitStringEpilogue(param, generatedVariable, param.ParameterType.IsArray);
                }
            }
        }

        private void EmitStringEpilogue(ParameterDefinition parameter, GeneratedVariableIdentifier generatedPtrVar, bool isArray = false)
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
    }
}
