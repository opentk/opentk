using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace OpenALGenerator
{
    class EntryPointAttribute : Attribute
    {
        public string EntryPoint;
        public string OverloadName;
        public bool OutParams;
        public bool GenerateArrayOverload = true;
        public bool PrivateRefOverload = false;

        public EntryPointAttribute(string entryPoint, bool outParams)
        {
            EntryPoint = entryPoint;
            OverloadName = null;
            OutParams = outParams;
        }

        public EntryPointAttribute(string entryPoint, string overloadName = null, bool outParams = false)
        {
            EntryPoint = entryPoint;
            OverloadName = overloadName;
            OutParams = outParams;
        }
    }

    class EFXExtension
    {
        [EntryPoint("alGenAuxiliaryEffectSlots")]
        unsafe delegate void GenAuxiliaryEffectSlots(int count, int* slots);

        [EntryPoint("alDeleteAuxiliaryEffectSlots")]
        unsafe delegate void DeleteAuxiliaryEffectSlots(int count, int* slots);

        [EntryPoint("alIsAuxiliaryEffectSlot")]
        delegate bool IsAuxiliaryEffectSlot(int slot);

        enum EffectSlotInteger { }

        [EntryPoint("alAuxiliaryEffectSloti", "AuxiliaryEffectSlot")]
        delegate void AuxiliaryEffectSloti(int slot, EffectSlotInteger param, int value);

        enum EffectSlotFloat { }

        [EntryPoint("alAuxiliaryEffectSlotf", "AuxiliaryEffectSlot")]
        delegate void AuxiliaryEffectSlotf(int slot, EffectSlotFloat param, float value);

        // FIXME!!!!!!! Out variables!!!
        // This should also make
        [EntryPoint("alGetAuxiliaryEffectSloti", "GetAuxiliaryEffectSlot", true)]
        unsafe delegate void GetAuxiliaryEffectSloti(int slot, EffectSlotInteger param, int* value);

        [EntryPoint("alGetAuxiliaryEffectSlotf", "GetAuxiliaryEffectSlot", true)]
        unsafe delegate void GetAuxiliaryEffectSlotf(int slot, EffectSlotFloat param, float* value);

        [EntryPoint("alGenEffects")]
        unsafe delegate void GenEffects(int count, int* effects);

        [EntryPoint("alDeleteEffects")]
        unsafe delegate void DeleteEffects(int count, int* effects);

        [EntryPoint("alIsEffect")]
        delegate bool IsEffect(int effect);

        enum EffectInteger { };

        [EntryPoint("alEffecti", "Effect")]
        delegate void Effecti(int effect, EffectInteger param, int value);

        enum EffectFloat { };

        [EntryPoint("alEffectf", "Effect")]
        delegate void Effectf(int effect, EffectFloat param, float value);

        enum EffectVector3 { };

        [EntryPoint("alEffectfv", "Effect")]
        unsafe delegate void Effectfv(int effect, EffectVector3 param, float* value);

        [EntryPoint("alGetEffecti", "GetEffect", true)]
        unsafe delegate void GetEffecti(int effect, EffectInteger param, int* value);

        [EntryPoint("alGetEffectf", "GetEffect", true)]
        unsafe delegate void GetEffectf(int effect, EffectFloat param, float* value);

        // We don't do out here because we want to out a Vector3 and not a float.
        // Ideally we would like a "float*" and "Vector3*" version.
        // But that can be done manually...
        [EntryPoint("alGetEffectfv", "GetEffect")]
        unsafe delegate void GetEffectfv(int effect, EffectVector3 param, float* value);

        [EntryPoint("alGenFilters")]
        unsafe delegate void GenFilters(int count, int* filters);

        [EntryPoint("alDeleteFilters")]
        unsafe delegate void DeleteFilters(int count, int* filters);

        [EntryPoint("alIsFilter")]
        delegate bool IsFilter(int filter);

        enum FilterInteger { };

        [EntryPoint("alFilteri", "Filter")]
        delegate void Filteri(int filter, FilterInteger param, int value);

        enum FilterFloat { };

        [EntryPoint("alFilterf", "Filter")]
        delegate void Filterf(int filter, FilterFloat param, float value);

        [EntryPoint("alGetFilteri", "GetFilter", true)]
        unsafe delegate void GetFilteri(int filter, FilterInteger param, int* value);

        [EntryPoint("alGetFilterf", "GetFilter", true)]
        unsafe delegate void GetFilterf(int filter, FilterFloat param, float* value);

        enum EFXSourceInteger { };

        [EntryPoint("alSourcei", "Source")]
        delegate void Sourcei(int source, EFXSourceInteger param, int value);

        enum EFXSourceFloat { };

        [EntryPoint("alSourcei", "Source")]
        delegate void Source(int source, EFXSourceFloat param, float value);

        enum EFXSourceBoolean { };

        [EntryPoint("alSourcei", "Source")]
        delegate void Sourceb(int source, EFXSourceBoolean param, bool value);

        enum EFXSourceInteger3 { };

        [EntryPoint("alSourceiv", "Source")]
        unsafe delegate void Sourceiv(int source, EFXSourceInteger3 param, int* value);

        [EntryPoint("alSource3i", "Source")]
        delegate void Source3i(int source, EFXSourceInteger3 param, int value1, int value2, int value3);

        [EntryPoint("alGetSourcei", "GetSource", true)]
        unsafe delegate void GetSourcei(int source, EFXSourceInteger param, int* value);

        [EntryPoint("alGetSourcef", "GetSource", true)]
        unsafe delegate void GetSourcef(int source, EFXSourceFloat param, float* value);

        [EntryPoint("alGetSourcei", "GetSource", true)]
        unsafe delegate void GetSourceb(int source, EFXSourceBoolean param, bool* value);

        [EntryPoint("alGetSourceiv", "GetSource")]
        unsafe delegate void GetSourceiv(int source, EFXSourceInteger3 param, int* value);

        [EntryPoint("alGetSource3i", "GetSource", true)]
        unsafe delegate void GetSource3i(int source, EFXSourceInteger3 param, int* value1, int* value2, int* value3);

        enum EFXListenerFloat { };

        [EntryPoint("alListenerf", "Listener")]
        delegate void Listenerf(int listener, EFXListenerFloat param, float value);

        [EntryPoint("alGetListenerf", "GetListener", true)]
        unsafe delegate void GetListenerf(int listener, EFXListenerFloat param, float* value);
    }

    class SOFT_source_latency
    {
        enum SourceLatencyInteger
        {
            //AL_SAMPLE_OFFSET_LATENCY_SOFT = 0x1200,
            SampleOffsetLatency = 0x1200,
        }

        enum SourceLatencyLong
        {
            //AL_SAMPLE_OFFSET_LATENCY_SOFT = 0x1200,
            SampleOffsetLatency = 0x1200,
        }

        enum SourceLatencyFloat
        {
            //AL_SEC_OFFSET_LATENCY_SOFT = 0x1201
            SecOffsetLatency = 0x1201,
        }

        enum SourceLatencyVector2i
        {
            //AL_SEC_OFFSET_LATENCY_SOFT = 0x1201
            SecOffsetLatency = 0x1201,
        }

        enum SourceLatencyVector2d
        {

        }

        [EntryPoint("alGetSourcei64vSOFT", "GetSource", true, PrivateRefOverload = true)]
        unsafe delegate void GetSourcei64v(int source, SourceLatencyVector2i param, long* values);

        // void alGetSourcedvSOFT(ALuint source, ALenum param, ALdouble *values);
        [EntryPoint("alGetSourcedvSOFT", "GetSource", true, PrivateRefOverload = true)]
        unsafe delegate void GetSourcedv(int source, SourceLatencyVector2d param, double* values);
    }

    class SOFT_device_clock
    {
        enum GetInteger64 { }

        enum SourceInteger64 { }
        enum SourceDouble { }

        //[EntryPoint("alGetSourcei64vSOFT", "GetSource", true)]
        //unsafe delegate void GetSourcei64v(int source, SourceLatencyVector2i param, long* values);

        struct ALDevice { }

        // void alcGetInteger64vSOFT(ALCdevice *device, ALCenum pname, ALsizei size, ALCint64SOFT* values);
        [EntryPoint("alcGetInteger64vSOFT", "GetInteger", true, PrivateRefOverload = true)]
        unsafe delegate void GetInteger(ALDevice device, GetInteger64 param, int size, long* values);

        //void alGetSourcei64vSOFT(ALuint source, ALenum param, ALint64SOFT* values);
        [EntryPoint("alGetSourcei64vSOFT", "GetSource", true, PrivateRefOverload = true)]
        unsafe delegate void GetSourcei64v(int source, SourceInteger64 param, long* values);

        //void alGetSourcedvSOFT(ALuint source, ALenum param, ALdouble *values);
        [EntryPoint("alGetSourcedvSOFT", "GetSource", true, PrivateRefOverload = true)]
        unsafe delegate void GetSourcedv(int source, SourceDouble param, double* values);

        // void alGetSourcedvSOFT(ALuint source, ALenum param, ALdouble *values);
        //[EntryPoint("alGetSourcedvSOFT", "GetSource", true)]
        //unsafe delegate void GetSourcedv(int source, SourceLatencyVector2d param, double* values);
    }

    class Program
    {
        public struct Parameter
        {
            public string Name;
            public Type Type;
        }

        public struct ALSignature
        {
            public string EntryPoint;
            public string DelegateName;
            public string OverloadName;
            public Type ReturnType;
            public Parameter[] Params;
            public bool OutOverloads;
            public bool GenerateArrayOverload;
            public bool PrivateRefOverload;

            public bool ContainsPointer()
            {
                foreach (var @param in Params)
                {
                    if (param.Type.IsPointer)
                        return true;
                }

                // FIXME: Is this something we even support?
                return ReturnType.IsPointer;
            }
        }

        static ALSignature GetSignature(Type type)
        {
            MethodInfo info = type.GetMethod("Invoke");
            var attr = type.GetCustomAttribute<EntryPointAttribute>();
            return new ALSignature
            {
                EntryPoint = attr?.EntryPoint ?? type.Name,
                DelegateName = type.Name,
                OverloadName = attr?.OverloadName ?? type.Name,
                ReturnType = info.ReturnType,
                Params = info.GetParameters().Select(p => new Parameter() { Name = p.Name, Type = p.ParameterType }).ToArray(),
                OutOverloads = attr?.OutParams ?? false,
                GenerateArrayOverload = attr?.GenerateArrayOverload ?? true,
                PrivateRefOverload = attr?.PrivateRefOverload ?? false,
            };
        }

        static Dictionary<Type, string> TypeNames = new Dictionary<Type, string>()
        {
            { typeof(void), "void" },
            { typeof(bool), "bool" },

            { typeof(float), "float" },
            { typeof(double), "double" },

            { typeof(byte), "byte" },
            { typeof(sbyte), "sbyte" },
            { typeof(short), "short" },
            { typeof(ushort), "ushort" },
            { typeof(int), "int" },
            { typeof(uint), "uint" },
            { typeof(long), "long" },
            { typeof(ulong), "ulong" },
        };

        static string GetTypeName(Type type, bool outParam)
        {
            if (TypeNames.TryGetValue(type, out var name))
                return name;
            else if (type.IsPointer)
                return $"{GetTypeName(type.GetElementType(), false)}*";
            else if (type.IsByRef)
                return $"{(outParam ? "out" : "ref")} {GetTypeName(type.GetElementType(), false)}";
            else if (type.IsArray)
                return $"{GetTypeName(type.GetElementType(), false)}[]";
            else if (type.IsGenericType)
                // Print the generic type not as "Span`1" but as "Span<T>"
                return $"{type.Name.Split('`')[0]}<{string.Join(", ", type.GenericTypeArguments.Select(t => GetTypeName(t, false)))}>";
            else return type.Name;
        }

        public enum OverloadType
        {
            Default,
            Pointer,
            Array,
            ByRef,
            //Span,
        }

        public static Type GetOverloadType(Type elementType, OverloadType overload)
        {
            switch (overload)
            {
                case OverloadType.Pointer:
                    return elementType.MakePointerType();
                case OverloadType.Array:
                    return elementType.MakeArrayType();
                case OverloadType.ByRef:
                    return elementType.MakeByRefType();
                //case OverloadType.Span:
                //    return typeof(Span<>).MakeGenericType(elementType);
                default:
                    throw new Exception();
            }
        }

        public static bool HasPointerTypes(Type returnType, Parameter[] parameters)
        {
            for (int i = 0; i < parameters.Length; i++)
            {
                if (parameters[i].Type.IsPointer)
                    return true;
            }

            return returnType.IsPointer;
        }

        public static Parameter[] ChangePointerTypes(Parameter[] Params, OverloadType overload)
        {
            Parameter[] changedParams = new Parameter[Params.Length];
            for (int i = 0; i < Params.Length; i++)
            {
                if (Params[i].Type.IsPointer)
                {
                    var elemType = Params[i].Type.GetElementType();
                    changedParams[i] = new Parameter() { Name = Params[i].Name, Type = GetOverloadType(elemType, overload) };
                }
                else
                {
                    changedParams[i] = Params[i];
                }
            }
            return changedParams;
        }

        public static string GenerateParamString(Parameter[] Params, bool outParams)
        {
            StringBuilder sb = new StringBuilder();
            string[] paramStrs = new string[Params.Length];
            for (int i = 0; i < Params.Length; i++)
            {
                paramStrs[i] = $"{GetTypeName(Params[i].Type, outParams)} {Params[i].Name}";
            }
            sb.Append(string.Join(", ", paramStrs));
            return sb.ToString();
        }

        public static string GenerateCallParamString(Parameter[] Params, bool outParams)
        {
            return string.Join(", ", Params.Select(p => p.Type.IsByRef ? $"{(outParams ? "out" : "ref")} {p.Name}" : p.Name));
        }

        public static string GenerateDelegateDeclaration(string name, string callingConv, string returnType, string paramsString, bool @unsafe)
        {
            return $"[UnmanagedFunctionPointer({callingConv})]\nprivate {(@unsafe ? "unsafe " : "")}delegate {returnType} {name}Delegate({paramsString});";
        }

        public static string GenerateDelegateField(string name, string loadFunction, string entryPoint)
        {
            return $"private static readonly {name}Delegate _{name} = {loadFunction}<{name}Delegate>(\"{entryPoint}\");";
        }

        public static string GenerateStaticFunction(string name, bool @private, string delegateName, string returnType, string paramsString, string callParams, bool @unsafe)
        {

            return $"{(@private ? "private" : "public")} static {(@unsafe ? "unsafe " : "")}{returnType} {name}({paramsString}) => _{delegateName}({callParams});";
        }

        public static string GetOverloadSuffix(OverloadType overload)
        {
            switch (overload)
            {
                case OverloadType.Default:
                    return "";
                case OverloadType.Pointer:
                    return "Ptr";
                case OverloadType.Array:
                    return "Array";
                case OverloadType.ByRef:
                    return "Ref";
                //case OverloadType.Span:
                //    return "Span";
                default:
                    throw new Exception();
            }
        }

        public static void GenerateOverload(StringBuilder builder, ALSignature signature, OverloadType overload)
        {
            Parameter[] Params = ChangePointerTypes(signature.Params, overload);
            string delegateName = signature.DelegateName + GetOverloadSuffix(overload);
            string paramsString = GenerateParamString(Params, signature.OutOverloads);
            string returnType = GetTypeName(signature.ReturnType, signature.OutOverloads);
            string callString = GenerateCallParamString(Params, signature.OutOverloads);
            bool @unsafe = overload == OverloadType.Pointer;
            bool @private = overload == OverloadType.ByRef && signature.PrivateRefOverload;
            builder.AppendLine(GenerateStaticFunction(signature.OverloadName, @private, delegateName, returnType, paramsString, callString, @unsafe));
            builder.AppendLine(GenerateDelegateDeclaration(delegateName, "AL.ALCallingConvention", returnType, paramsString, @unsafe));
            // FIXME: Entrypoint should be done better!!!
            builder.AppendLine(GenerateDelegateField(delegateName, "LoadDelegate", signature.EntryPoint));
        }

        public static ALSignature[] GetSignaturesFromType(Type type)
        {
            var types = type.GetNestedTypes(BindingFlags.Public | BindingFlags.NonPublic);
            List<ALSignature> Signatures = new List<ALSignature>();
            foreach (var t in types)
            {
                if (t.IsEnum) continue;
                if (t.IsClass == false) continue;
                else Signatures.Add(GetSignature(t));
            }
            return Signatures.ToArray();
        }

        public static string GenerateProcs (Type containgType)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var sig in GetSignaturesFromType(containgType))
            {
                //if (sig.OutOverloads == false) continue;
                if (HasPointerTypes(sig.ReturnType, sig.Params))
                {
                    GenerateOverload(sb, sig, OverloadType.Pointer);
                    sb.AppendLine();
                    //GenerateOverload(sb, sig, OverloadType.Span);
                    //sb.AppendLine();
                    GenerateOverload(sb, sig, OverloadType.ByRef);
                    sb.AppendLine();

                    // We don't want array overloads for out parameters
                    if (sig.GenerateArrayOverload)
                    {
                        GenerateOverload(sb, sig, OverloadType.Array);
                        sb.AppendLine();
                    }
                }
                else
                {
                    GenerateOverload(sb, sig, OverloadType.Default);
                    sb.AppendLine();
                }
            }
            return sb.ToString();
        }

        static void Main(string[] args)
        {
            //Console.WriteLine(GenerateProcs(typeof(EFXExtension)));

            //Console.WriteLine();

            //Console.WriteLine(GenerateProcs(typeof(SOFT_source_latency)));
            Console.WriteLine(GenerateProcs(typeof(SOFT_device_clock)));
        }
    }
}
