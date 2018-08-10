using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Mono.Cecil;
using Mono.Cecil.Cil;
using Mono.Cecil.Rocks;
using OpenTK.Rewrite.Extensions;

namespace OpenTK.Rewrite.Methods.Processors
{
    /// <summary>
    /// Rewrites wrapper method IL to include the prologue for the wrapper method parameters.
    /// </summary>
    public sealed class ParameterProcessor : MethodProcessorWithEpilogue<IEnumerable<VariableIdentifier>>
    {
        private readonly TypeDefinition _bindingsBaseType;

        private readonly TypeDefinition _arrayType;
        private readonly TypeDefinition _int32Type;
        private readonly TypeDefinition _intPtrType;
        private readonly TypeDefinition _marshalType;

        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterProcessor"/> class.
        /// </summary>
        /// <param name="mscorlib">The mscorlib assembly definition to set up this processor.</param>
        /// <param name="bindingsBaseType">The 'BindingsBase' type used for some helper definitions.</param>
        public ParameterProcessor(AssemblyDefinition mscorlib, TypeDefinition bindingsBaseType)
            : base(new ParameterEpilogueProcessor(mscorlib, bindingsBaseType))
        {
            if (mscorlib is null)
            {
                throw new ArgumentNullException(nameof(mscorlib));
            }

            _bindingsBaseType = bindingsBaseType ?? throw new ArgumentNullException(nameof(bindingsBaseType));

            _arrayType = mscorlib.MainModule.GetType(typeof(Array).FullName);
            _int32Type = mscorlib.MainModule.GetType(typeof(int).FullName);
            _intPtrType = mscorlib.MainModule.GetType(typeof(IntPtr).FullName);
            _marshalType = mscorlib.MainModule.GetType(typeof(Marshal).FullName);
        }

        /// <inheritdoc/>
        public override void Process(ILProcessor cilProcessor, MethodDefinition wrapper, MethodDefinition native)
        {
            IEnumerable<VariableIdentifier> generatedVariables;

            int paramCountDifference = native.Parameters.Count - wrapper.Parameters.Count;
            if (paramCountDifference == 0)
            {
                generatedVariables = EmitParameters(cilProcessor, wrapper, native);
            }
            else
            {
                generatedVariables = EmitConvenienceWrapper(cilProcessor, wrapper, native, paramCountDifference);
            }

            EpilogueProcessor.RewriteVariables.TryAdd(wrapper, generatedVariables);
        }

        private IEnumerable<VariableIdentifier> EmitParameters
        (
            ILProcessor cilProcessor,
            MethodDefinition wrapper,
            MethodDefinition native
        )
        {
            var generatedVariables = new List<VariableIdentifier>();

            for (int i = 0; i < wrapper.Parameters.Count; i++)
            {
                var parameter = wrapper.Parameters[i];
                var paramType = wrapper.Module.ImportReference(parameter.ParameterType);
                cilProcessor.Emit(OpCodes.Ldarg, i);

                if (paramType.FullNameEquals<int>() && native.Parameters[i].ParameterType.FullNameEquals<IntPtr>())
                {
                    // This is a convenience Int32 overload for an IntPtr (size_t) parameter.
                    // We need to convert the loaded argument to IntPtr.
                    cilProcessor.Emit(OpCodes.Conv_I);
                }
                else if (paramType.Name == "String&" && !paramType.IsArray)
                {
                    generatedVariables.Add(EmitStringOutParameter(cilProcessor, wrapper, parameter));
                }
                else if (paramType.FullNameEquals<string>() && !paramType.IsArray)
                {
                    generatedVariables.Add(EmitStringParameter(cilProcessor, wrapper, parameter));
                }
                else if (paramType.IsByReference)
                {
                    wrapper.Body.Variables.Add(new VariableDefinition(new PinnedType(paramType)));
                    var index = wrapper.Body.Variables.Count - 1;
                    cilProcessor.Emit(OpCodes.Stloc, index);
                    cilProcessor.Emit(OpCodes.Ldloc, index);
                    cilProcessor.Emit(OpCodes.Conv_I);
                }
                else if (paramType.IsArray)
                {
                    if (paramType.FullNameEquals<string[]>())
                    {
                        generatedVariables.Add(EmitStringParameter(cilProcessor, wrapper, parameter, isArray: true));
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
                    wrapper.Body.Variables.Add(new VariableDefinition(new PinnedType(new ByReferenceType(elementType))));
                    int pinnedIndex = wrapper.Body.Variables.Count - 1;

                    var empty = cilProcessor.Create(OpCodes.Ldc_I4, 0);
                    var pin = cilProcessor.Create(OpCodes.Ldarg, i);
                    var end = cilProcessor.Create(OpCodes.Stloc, pinnedIndex);

                    // if (arrayTypeType == null) goto empty
                    cilProcessor.Emit(OpCodes.Brfalse, empty);

                    // else if (arrayType.Length != 0) goto pin
                    cilProcessor.Emit(OpCodes.Ldarg, i);
                    if (arrayType.Rank == 1)
                    {
                        cilProcessor.Emit(OpCodes.Ldlen);
                        cilProcessor.Emit(OpCodes.Conv_I4);
                    }
                    else
                    {
                        var getLength = wrapper.Module.ImportReference(_arrayType.GetMethod("get_Length"));
                        cilProcessor.Emit(OpCodes.Callvirt, getLength);
                    }

                    cilProcessor.Emit(OpCodes.Brtrue, pin);

                    // empty: IntPtr ptr = IntPtr.Zero
                    cilProcessor.Append(empty);
                    cilProcessor.Emit(OpCodes.Conv_U);
                    cilProcessor.Emit(OpCodes.Br, end);

                    // pin: &arrayType[0]
                    cilProcessor.Append(pin);
                    if (arrayType.Rank == 1)
                    {
                        // 1d arrayType (vector), address is taken by ldelema
                        cilProcessor.Emit(OpCodes.Ldc_I4, 0);
                        cilProcessor.Emit(OpCodes.Ldelema, elementType);
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
                            cilProcessor.Emit(OpCodes.Ldc_I4, 0);
                        }

                        cilProcessor.Emit(OpCodes.Call, getAddress);
                    }

                    // end: fixed (IntPtr ptr = &arrayType[0])
                    cilProcessor.Append(end);
                    cilProcessor.Emit(OpCodes.Ldloc, pinnedIndex);
                    cilProcessor.Emit(OpCodes.Conv_I);
                }
            }

            return generatedVariables;
        }

        private VariableIdentifier EmitStringParameter
        (
            ILProcessor cilProcessor,
            MethodDefinition wrapper,
            ParameterDefinition parameter,
            bool isArray = false
        )
        {
            string marshalToPtrName = isArray ? "MarshalStringArrayToPtr" : "MarshalStringToPtr";
            string paramNameSuffix = isArray ? "_string_array_ptr" : "_string_ptr";

            // string marshaling:
            // IntPtr ptr = MarshalStringToPtr(str);
            // try { calli }
            // finally { Marshal.FreeHGlobal(ptr); }
            var marshalStringToPtr = wrapper.Module.ImportReference(_bindingsBaseType.GetMethod(marshalToPtrName));

            // IntPtr ptr;
            var variableDefinition = new VariableDefinition(_intPtrType);
            wrapper.Body.Variables.Add(variableDefinition);
            int generatedPointerVarIndex = wrapper.Body.Variables.Count - 1;

            var stringPtrVar = new VariableIdentifier
            (
                wrapper.Body,
                variableDefinition,
                parameter.Name + paramNameSuffix
            );

            // ptr = Marshal.StringToHGlobalAnsi(str);
            cilProcessor.Emit(OpCodes.Call, marshalStringToPtr);
            cilProcessor.Emit(OpCodes.Stloc, generatedPointerVarIndex);
            cilProcessor.Emit(OpCodes.Ldloc, generatedPointerVarIndex);

            // The finally block will be emitted in the function epilogue
            return stringPtrVar;
        }

        private VariableIdentifier EmitStringOutParameter
        (
            ILProcessor cilProcessor,
            MethodDefinition wrapper,
            ParameterDefinition parameter
        )
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
            cilProcessor.Emit(OpCodes.Pop);

            // Make sure we have imported Marshal::AllocHGlobal
            var allocHGlobal = wrapper.Module.ImportReference(_marshalType.GetMethod(nameof(Marshal.AllocHGlobal)));

            // IntPtr ptr;
            var variableDefinition = new VariableDefinition(_intPtrType);
            wrapper.Body.Variables.Add(variableDefinition);
            var stringPtrIndex = wrapper.Body.Variables.Count - 1;

            var stringPtrVar = new VariableIdentifier
            (
                wrapper.Body,
                variableDefinition,
                parameter.Name + "_string_ptr"
            );

            // ptr = Marshal.AllocHGlobal(count + 1);
            var count = GetCountAttribute(parameter);
            if (count is null)
            {
                // We need a count attribute so we know what size to make the
                // string buffer. Currently every string out parameter has a
                // count attribute but this check is in place to make things
                // clearer if this case is ever hit.
                throw new InvalidOperationException
                (
                    $"{wrapper.Name} ({parameter.Name}) doesn't have a count attribute."
                );
            }

            if (count.Count != 0)
            {
                // Fixed size
                cilProcessor.Emit(OpCodes.Ldc_I4, count.Count);
            }
            else if (count.Parameter != null)
            {
                // Parameter sized
                var countVariable = EmitCountVariable(cilProcessor, wrapper, count.Parameter);
                cilProcessor.Emit(OpCodes.Ldloc, countVariable.Index);
            }
            else if (count.Computed != null)
            {
                if (wrapper.Name == "GetActiveVarying")
                {
                    // GetActiveVaryingNV's name parameter has a count of "COMPSIZE(program,index,bufSize)"
                    // but really it should be bufSize.
                    var countVariable = EmitCountVariable(cilProcessor, wrapper, "bufSize");
                    cilProcessor.Emit(OpCodes.Ldloc, countVariable.Index);
                }
                else
                {
                    // Computed counts are hard and require manual reading of the specification for each one.
                    throw new NotSupportedException
                    (
                        $"{wrapper.Name} ({parameter.Name}) requires a computed count: {count.Computed}."
                    );
                }
            }

            cilProcessor.Emit(OpCodes.Ldc_I4, 1);
            cilProcessor.Emit(OpCodes.Add);
            cilProcessor.Emit(OpCodes.Call, allocHGlobal);
            cilProcessor.Emit(OpCodes.Stloc, stringPtrIndex);
            cilProcessor.Emit(OpCodes.Ldloc, stringPtrIndex);

            // We'll emit the try-finally block in the epilogue implementation,
            // because we haven't yet emitted all necessary instructions here.
            return stringPtrVar;
        }

        private VariableDefinition EmitCountVariable
        (
            ILProcessor cilProcessor,
            MethodDefinition wrapper,
            string countParameter
        )
        {
            var countVariable = new VariableDefinition(_int32Type);
            wrapper.Body.Variables.Add(countVariable);

            // Parameter will either by a simple name, a dereference of a name
            // like "*name" or an expression like "name*5"
            var parameter = wrapper.GetParameter(countParameter, throwIfNoneFound: false);
            if (parameter != null)
            {
                cilProcessor.Emit(OpCodes.Ldarg, parameter.Index);
                cilProcessor.Emit(OpCodes.Stloc, countVariable.Index);
            }
            else if (countParameter[0] == '*')
            {
                var pointerParam = wrapper.GetParameter(countParameter.Substring(1));

                cilProcessor.Emit(OpCodes.Ldarg, pointerParam.Index);
                cilProcessor.Emit(OpCodes.Ldind_I4);
            }
            else
            {
                var operands = countParameter.Split('*');
                parameter = wrapper.GetParameter(operands[0]);
                var scale = int.Parse(operands[1]);

                cilProcessor.Emit(OpCodes.Ldarg, parameter.Index);
                cilProcessor.Emit(OpCodes.Ldc_I4, scale);
                cilProcessor.Emit(OpCodes.Mul);
                cilProcessor.Emit(OpCodes.Stloc, countVariable.Index);
            }

            return countVariable;
        }

        private IEnumerable<VariableIdentifier> EmitConvenienceWrapper
        (
            ILProcessor cilProcessor,
            MethodDefinition wrapper,
            MethodDefinition native,
            int difference
        )
        {
            if (wrapper.Parameters.Count > 2)
            {
                // Todo: emit all parameters bar the last two
                throw new NotImplementedException();
            }

            bool returnsVoid = wrapper.ReturnType.FullNameEquals(typeof(void));

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
                    cilProcessor.Emit(OpCodes.Ldc_I4, 1); // const int n = 1
                    cilProcessor.Emit(OpCodes.Ldarga, wrapper.Parameters.Last()); // &textures
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
                    wrapper.Body.Variables.Add(new VariableDefinition(wrapper.ReturnType));

                    var generatedVariables = EmitParameters(cilProcessor, wrapper, native);
                    cilProcessor.Emit(OpCodes.Ldloca, wrapper.Body.Variables.Count - 1);
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
                wrapper.Body.Variables.Add(new VariableDefinition(wrapper.ReturnType));
                cilProcessor.Emit(OpCodes.Ldc_I4, 1); // const int n = 1
                cilProcessor.Emit(OpCodes.Ldloca, wrapper.Body.Variables.Count - 1); // &buffers
            }
            else
            {
                Console.Error.WriteLine($"Unknown wrapper type for {native.Name}.");
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

            if (attribute is null)
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
