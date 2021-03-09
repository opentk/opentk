using GeneratorV2.Data;
using GeneratorV2.Parsing;
using GeneratorV2.Writing;
using GeneratorV2.Extensions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorV2.Process
{
    public static class Processor
    {
        // This is only used to pass data from ProcessSpec to GetOutputApiFromRequireTags
        private record ProcessedGLInformation(
            Dictionary<string, OverloadedFunction> AllFunctions,
            Dictionary<NativeFunction, string[]> FunctionToEnumGroupsUsed,
            Dictionary<OutputApi, Dictionary<string, EnumMemberData>> AllEnumsPerAPI,
            Dictionary<string, bool> AllEnumGroupsToIsBitmask);

        public static OutputData ProcessSpec(Specification spec)
        {
            // FIXME: Check if GLSC 2 contains unique functions that could be filtered out.
            // FIXME: See if we can filter out enums and functions that are from GLSC 2 so that
            // we do not process them that would be great.

            // The first thing we do is process all of the functions defined into a dictionary of NativeFunctions
            Dictionary<string, OverloadedFunction> allFunctions = new Dictionary<string, OverloadedFunction>(spec.Commands.Count);
            Dictionary<NativeFunction, string[]> functionToEnumGroupsUsed = new Dictionary<NativeFunction, string[]>();
            foreach (var command in spec.Commands)
            {
                var nativeFunction = MakeNativeFunction(command, out string[] usedEnumGroups);
                var overloads = GenerateOverloads(nativeFunction, out bool changeNativeName);

                functionToEnumGroupsUsed.Add(nativeFunction, usedEnumGroups);
                allFunctions.Add(nativeFunction.EntryPoint, new OverloadedFunction(nativeFunction, overloads, changeNativeName));
            }

            Dictionary<OutputApi, Dictionary<string, EnumMemberData>> allEnumsPerAPI = new Dictionary<OutputApi, Dictionary<string, EnumMemberData>>();
            Dictionary<string, bool> allEnumGroupsToIsBitmask = new Dictionary<string, bool>();
            foreach (var enumsEntry in spec.Enums)
            {
                // FIXME: Cleanup.
                // FIXME: Fix specification so we don't need to apply the <enums> groups to the enums here.
                bool isFlag = enumsEntry.Type == EnumType.Bitmask;
                HashSet<string> entryGroups = new HashSet<string>();
                if (enumsEntry.Groups != null)
                {
                    entryGroups.UnionWith(enumsEntry.Groups);
                    foreach (var group in enumsEntry.Groups)
                    {
                        allEnumGroupsToIsBitmask.TryAdd(group, isFlag);
                    }
                }

                foreach (var @enum in enumsEntry.Enums)
                {
                    HashSet<string> groups = new HashSet<string>(entryGroups);

                    if (@enum.Groups != null)
                    {
                        groups.UnionWith(@enum.Groups);
                        foreach (var group in @enum.Groups)
                        {
                            allEnumGroupsToIsBitmask.TryAdd(group, isFlag);
                        }
                    }

                    var data = new EnumMemberData(NameMangler.MangleEnumName(@enum.Name), @enum.Value, groups.ToArray(), isFlag);
                    if (@enum.Api == GLAPI.None)
                    {
                        allEnumsPerAPI.AddToNestedDict(OutputApi.GL, @enum.Name, data);
                        allEnumsPerAPI.AddToNestedDict(OutputApi.GLCompat, @enum.Name, data);
                        allEnumsPerAPI.AddToNestedDict(OutputApi.GLES1, @enum.Name, data);
                        allEnumsPerAPI.AddToNestedDict(OutputApi.GLES3, @enum.Name, data);
                    }
                    else if (@enum.Api == GLAPI.GLES1)
                    {
                        allEnumsPerAPI.AddToNestedDict(OutputApi.GLES1, @enum.Name, data);
                    }
                    else if (@enum.Api == GLAPI.GLES2)
                    {
                        allEnumsPerAPI.AddToNestedDict(OutputApi.GLES3, @enum.Name, data);
                    }
                    else if (@enum.Api == GLAPI.GL)
                    {
                        allEnumsPerAPI.AddToNestedDict(OutputApi.GL, @enum.Name, data);
                        allEnumsPerAPI.AddToNestedDict(OutputApi.GLCompat, @enum.Name, data);
                    }
                }
            }

            // Now that we have all of the functions and enums ready in dictionaries
            // we can start building all of the API versions.

            // Filter the features we actually want to emit
            List<Feature> features = spec.Features.FindAll(feature => feature.Api switch
            {
                GLAPI.GL or GLAPI.GLES1 or GLAPI.GLES2 => true,
                GLAPI.GLSC2 or GLAPI.GLCore => false,
                _ or GLAPI.Invalid or GLAPI.None => throw new Exception($"Feature '{feature.Name}' doesn't have a proper api tag."),
            });
            List<Extension> extensions = spec.Extensions.FindAll(extension => extension.SupportedApis.Any(api => api switch
            {
                GLAPI.GL or GLAPI.GLES1 or GLAPI.GLES2 => true,
                GLAPI.GLSC2 or GLAPI.GLCore or GLAPI.None => false,
                _ => throw new Exception($"Extension '{extension.Name}' doesn't have a proper api tag."),
            }));

            var glRequires = GetRequireEntries(features, extensions, GLAPI.GL);
            var gles1Requires = GetRequireEntries(features, extensions, GLAPI.GLES1);
            var gles3Requires = GetRequireEntries(features, extensions, GLAPI.GLES2);
            var glRemoves = GetRemoveEntries(features, GLAPI.GL);
            // OpenGL ES doesn't have any remove tags as of yet, we are just doing this in case it gets added later. // 2021-03-04
            var gles3Removes = GetRemoveEntries(features, GLAPI.GLES2);

            var info = new ProcessedGLInformation(allFunctions, functionToEnumGroupsUsed, allEnumsPerAPI, allEnumGroupsToIsBitmask);

            var gl = GetOutputApiFromRequireTags(OutputApi.GL, glRequires, glRemoves, info);
            var glCompat = GetOutputApiFromRequireTags(OutputApi.GLCompat, glRequires, new List<RemoveEntry>(), info);
            var gles1 = GetOutputApiFromRequireTags(OutputApi.GLES1, gles1Requires, new List<RemoveEntry>(), info);
            var gles3 = GetOutputApiFromRequireTags(OutputApi.GLES3, gles3Requires, gles3Removes, info);

            return new OutputData(new List<GLOutputApi>()
            {
                gl, glCompat, gles1, gles3
            });
        }

        private static List<(string, RequireEntry entry)> GetRequireEntries(List<Feature> features, List<Extension> extensions, GLAPI api)
        {
            List<(string Vendor, RequireEntry entry)> requireEntries = new List<(string Vendor, RequireEntry entry)>();

            foreach (var feature in features)
            {
                if (feature.Api == api)
                {
                    AddAllRequires("", feature.Requires);
                }
            }

            foreach (var extension in extensions)
            {
                if (extension.SupportedApis.Contains(api))
                {
                    AddAllRequires(extension.Vendor, extension.Requires);
                }
            }

            return requireEntries;

            void AddAllRequires(string vendor, List<RequireEntry> requires)
            {
                foreach (var require in requires)
                {
                    requireEntries.Add((vendor, require));
                }
            }
        }

        private static List<RemoveEntry> GetRemoveEntries(List<Feature> features, GLAPI api)
        {
            List<RemoveEntry> removeEntries = new List<RemoveEntry>();

            foreach (var feature in features)
            {
                if (feature.Api == api)
                {
                    foreach (var remove in feature.Removes)
                    {
                        removeEntries.Add(remove);
                    }
                }
            }

            return removeEntries;
        }

        private static GLOutputApi GetOutputApiFromRequireTags(
            OutputApi api,
            List<(string vendor, RequireEntry requireEntry)> requireEntries,
            List<RemoveEntry> removeEntries,
            ProcessedGLInformation glInformation)
        {
            HashSet<string> groupsReferencedByFunctions = new HashSet<string>();
            // A list of functions contained in this version.
            Dictionary<string, HashSet<OverloadedFunction>> functionsByVendor = new Dictionary<string, HashSet<OverloadedFunction>>();
            HashSet<EnumMemberData> enums = new HashSet<EnumMemberData>();

            // Deconstruct glInformation for easier access
            var (allFunctions, functionToEnumGroupsUsed, allEnumsPerAPI, allEnumGroupsToIsBitmask) = glInformation;

            // Go through all the functions that are required for this version and add them here.
            foreach (var (vendor, requireEntry) in requireEntries)
            {
                foreach (var command in requireEntry.Commands)
                {
                    if (allFunctions.TryGetValue(command, out var function))
                    {
                        functionsByVendor.AddToNestedHashSet(vendor, function);

                        var functionGroups = functionToEnumGroupsUsed[function.NativeFunction];
                        groupsReferencedByFunctions.UnionWith(functionGroups);
                    }
                    else
                    {
                        throw new Exception($"Could not find any function called '{command}'.");
                    }
                }

                foreach (var enumName in requireEntry.Enums)
                {
                    var enumsDict = allEnumsPerAPI[api];
                    if (enumsDict.TryGetValue(enumName, out var @enum))
                    {
                        enums.Add(@enum);
                    }
                    else
                    {
                        throw new Exception($"Could not find any enum called '{enumName}'.");
                    }
                }
            }

            foreach (var remove in removeEntries)
            {
                foreach (var command in remove.Commands)
                {
                    foreach (var functions in functionsByVendor.Values)
                    {
                        functions.RemoveWhere(f => f.NativeFunction.EntryPoint == command);
                    }
                }
            }

            // Go through all of the enums and put them into their groups
            Dictionary<string, List<EnumMemberData>> enumGroups = new Dictionary<string, List<EnumMemberData>>();

            // Add keys + lists for all enum names
            foreach (var groupName in allEnumGroupsToIsBitmask.Keys)
            {
                enumGroups.Add(groupName, new List<EnumMemberData>());
            }

            foreach (var @enum in enums)
            {
                // This enum doesn't have a group, so we skip it.
                // It will still appear in the All enum.
                if (@enum.Groups == null) continue;

                foreach (var groupName in @enum.Groups)
                {
                    enumGroups.AddToNestedList(groupName, @enum);
                }
            }

            List<EnumGroup> finalGroups = new List<EnumGroup>();
            foreach (var (groupName, members) in enumGroups)
            {
                // SpecialNumbers is not an enum group that we want to output.
                // We handle these entries differently as some of the entries are longer than an int.
                if (groupName == "SpecialNumbers")
                    continue;

                // Remove all empty enum groups, except the empty groups referenced by included functions.
                // In GL 4.1 to 4.5 there are functions that use the group "ShaderBinaryFormat"
                // while not including any members for that enum group.
                // This is needed to solve that case.
                if (members.Count <= 0 && groupsReferencedByFunctions.Contains(groupName) == false)
                    continue;

                bool isFlags = allEnumGroupsToIsBitmask[groupName];
                finalGroups.Add(new EnumGroup(groupName, isFlags, members));
            }
;
            var vendors = new Dictionary<string, GLOutputApiGroup>();
            foreach (var (vendor, overloadedFunctions) in functionsByVendor)
            {
                foreach (var overloadedFunction in overloadedFunctions)
                {
                    if (!vendors.TryGetValue(vendor, out var group))
                    {
                        group = new GLOutputApiGroup(
                            new List<OverloaderNativeFunction>(), new List<OverloaderFunctionOverloads>());
                        vendors.Add(vendor, group);
                    }
                    group.Functions.Add(new OverloaderNativeFunction(overloadedFunction.NativeFunction,
                        overloadedFunction.ChangeNativeName));
                    group.Overloads.Add(new OverloaderFunctionOverloads(overloadedFunction.Overloads,
                        overloadedFunction.ChangeNativeName));
                }
            }

            return new GLOutputApi(api, vendors, enums.ToList(), finalGroups);
        }

        public static NativeFunction MakeNativeFunction(Command command, out string[] enumGroupsUsed)
        {
            string functionName = NameMangler.MangleFunctionName(command.EntryPoint);

            HashSet<string> enumGroups = new HashSet<string>();

            List<Parameter> parameters = new List<Parameter>();
            foreach (var p in command.Parameters)
            {
                BaseCSType t = MakeCSType(p.Type.Type, p.Type.Group, out var length);
                parameters.Add(new Parameter(t, NameMangler.MangleParameterName(p.Name), p.Length ?? length));
                if (p.Type.Group != null)
                    enumGroups.Add(p.Type.Group);
            }

            BaseCSType returnType = MakeCSType(command.ReturnType.Type, command.ReturnType.Group, out _);
            if (command.ReturnType.Group != null)
                enumGroups.Add(command.ReturnType.Group);

            enumGroupsUsed = enumGroups.ToArray();

            return new NativeFunction(command.EntryPoint, functionName, parameters, returnType);
        }

        public static BaseCSType MakeCSType(GLType type, string? group, out Expression? length)
        {
            length = default;
            switch (type)
            {
                case GLArrayType at:
                    length = new Constant(at.Length);
                    return new CSPointer(MakeCSType(at.BaseType, group, out _), at.Constant);
                case GLPointerType pt:
                    return new CSPointer(MakeCSType(pt.BaseType, group, out length), pt.Constant);
                case GLBaseType bt:
                    return bt.Type switch
                    {
                        PrimitiveType.Void => new CSVoid(bt.Constant),
                        PrimitiveType.Bool => new CSType("bool", bt.Constant),
                        PrimitiveType.Byte => new CSType("byte", bt.Constant),
                        PrimitiveType.Char8 => new CSChar8(bt.Constant),
                        PrimitiveType.Sbyte => new CSType("sbyte", bt.Constant),
                        PrimitiveType.Short => new CSType("short", bt.Constant),
                        PrimitiveType.Ushort => new CSType("ushort", bt.Constant),
                        PrimitiveType.Int => new CSType("int", bt.Constant),
                        PrimitiveType.Uint => new CSType("uint", bt.Constant),
                        PrimitiveType.Long => new CSType("long", bt.Constant),
                        PrimitiveType.Ulong => new CSType("ulong", bt.Constant),
                        // This might need an include, but the spec doesn't use this type
                        // so we don't really need to do anything...
                        PrimitiveType.Half => new CSType("Half", bt.Constant),
                        PrimitiveType.Float => new CSType("float", bt.Constant),
                        PrimitiveType.Double => new CSType("double", bt.Constant),
                        PrimitiveType.IntPtr => new CSType("IntPtr", bt.Constant),

                        PrimitiveType.VoidPtr => new CSPointer(new CSVoid(false), bt.Constant),

                        // FIXME: Should this be treated special?
                        PrimitiveType.Enum => new CSType(group ?? "All", bt.Constant),

                        // FIXME: Are these just normal CSType? probably...
                        PrimitiveType.GLHandleARB => new CSType("GLHandleARB", bt.Constant),
                        PrimitiveType.GLSync => new CSType("GLSync", bt.Constant),

                        PrimitiveType.CLContext => new CSType("CLContext", bt.Constant),
                        PrimitiveType.CLEvent => new CSType("CLEvent", bt.Constant),

                        PrimitiveType.GLDEBUGPROC => new CSType("GLDebugProc", bt.Constant),
                        PrimitiveType.GLDEBUGPROCARB => new CSType("GLDebugProcARB", bt.Constant),
                        PrimitiveType.GLDEBUGPROCKHR => new CSType("GLDebugProcKHR", bt.Constant),
                        PrimitiveType.GLDEBUGPROCAMD => new CSType("GLDebugProcAMD", bt.Constant),
                        PrimitiveType.GLDEBUGPROCNV => new CSType("GLDebugProcNV", bt.Constant),

                        PrimitiveType.Invalid => throw new Exception(),
                        _ => throw new Exception(),
                    };
                default:
                    throw new Exception();
            }
        }

        // /!\ IMPORTANT /!\:
        // All return type overloaders need to run before any of the other overloaders.
        // This is to ensure that correct scoping for the new return variables.
        static readonly IOverloader[] Overloaders = new IOverloader[]
        {
            new StringReturnOverloader(),

            new GenCreateAndDeleteOverloader(),
            new StringOverloader(),
            new SpanAndArrayOverloader(),
            new RefInsteadOfPointerOverloader(),
            new OutToReturnOverloader(),
        };

        // FIXME: The return variable might go out of scope, declare the variables the first thing we do.
        // FIXME: Figure out how to cast ref/out/in to pointers.
        // FIXME: Figure out how we do return type overloading? Do we rename the raw function to something else?
        // FIXME: Should we only be able to have one return type overload?
        // Maybe we can do the return type overloading in a post processing step?
        public static Overload[] GenerateOverloads(NativeFunction function, out bool changeNativeName)
        {
            List<Overload> overloads = new List<Overload>
            {
                // Make a "base" overload
                new Overload(null,null, function.Parameters.ToArray(), function, function.ReturnType, "returnValue",
                    Array.Empty<string>(), function.FunctionName),
            };

            bool overloadedOnce = false;
            foreach (var overloader in Overloaders)
            {
                List<Overload> newOverloads = new List<Overload>();
                foreach (var overload in overloads)
                {
                    if (overloader.TryGenerateOverloads(overload, out var overloaderOverloads))
                    {
                        overloadedOnce = true;

                        newOverloads.AddRange(overloaderOverloads);
                    }
                    else
                    {
                        newOverloads.Add(overload);
                    }
                }
                // Replace the old overloads with the new overloads
                overloads = newOverloads;
            }

            if (overloadedOnce)
            {
                changeNativeName = true;
                foreach (var overload in overloads)
                {
                    if (function.Parameters.Count != overload.InputParameters.Length)
                        continue;

                    for (int i = 0; i < function.Parameters.Count; i++)
                    {
                        if (!function.Parameters[i].Type.Equals(overload.InputParameters[i].Type))
                        {
                            changeNativeName = false;
                            break;
                        }
                    }

                    if (changeNativeName == true)
                    {
                        break;
                    }
                }
                return overloads.ToArray();
            }
            else
            {
                changeNativeName = false;
                return Array.Empty<Overload>();
            }
        }

        // FIXME: Make this nicer.
        // These being classes actually don't acomplish much
        // they are just so that we can put them in a
        // IOverloader[].
        class StringReturnOverloader : IOverloader
        {
            public bool TryGenerateOverloads(Overload overload, [NotNullWhen(true)] out List<Overload>? newOverloads)
            {
                // See: https://github.com/KhronosGroup/OpenGL-Registry/issues/363
                // These are the only two functions that return strings 2020-12-29
                if (overload.NativeFunction.EntryPoint == "glGetString" ||
                    overload.NativeFunction.EntryPoint == "glGetStringi")
                {
                    var newReturnName = $"{overload.ReturnVariableName}_str";
                    var layer = new StringReturnLayer(newReturnName);
                    var returnType = new CSString(Nullable: true);
                    newOverloads = new List<Overload>()
                    {
                        overload with{NestedOverload =  overload, MarshalLayerToNested = layer, ReturnType = returnType, ReturnVariableName = newReturnName},
                        // new Overload(overload, layer, overload.InputParameters, overload.NativeFunction, returnType, newReturnName, overload.GenericTypes)
                    };
                    return true;
                }
                else
                {
                    newOverloads = default;
                    return false;
                }
            }

            class StringReturnLayer : IOverloadLayer
            {
                readonly string NewReturnName;

                public StringReturnLayer(string newReturnName)
                {
                    NewReturnName = newReturnName;
                }

                public void WritePrologue(IndentedTextWriter writer, NameTable nameTable)
                {
                    writer.WriteLine($"string? {NewReturnName};");
                }

                public string WriteEpilogue(IndentedTextWriter writer, NameTable nameTable, string? returnName)
                {
                    writer.WriteLine($"{NewReturnName} = Marshal.PtrToStringAnsi((IntPtr){returnName});");
                    return NewReturnName;
                }
            }
        }

        class StringOverloader : IOverloader
        {
            public bool TryGenerateOverloads(Overload overload, [NotNullWhen(true)] out List<Overload>? newOverloads)
            {
                List<Parameter> newParams = new List<Parameter>(overload.InputParameters);
                Overload newOverload = overload;
                for (int i = newParams.Count - 1; i >= 0; i--)
                {
                    // FIXME: We want to handle sized strings different!!!
                    var param = newParams[i];
                    if (param.Type is CSPointer pt && pt.BaseType is CSChar8 bt)
                    {
                        var pointerParam = newParams[i];
                        var nameTable = newOverload.NameTable.New();
                        nameTable.Rename(pointerParam, $"{pointerParam.Name}_ptr");

                        if (bt.Constant)
                        {
                            // FIXME: Can we know if the string is nullable or not?
                            newParams[i] = newParams[i] with { Type = new CSString(Nullable: false), Length = null };
                            var stringParams = newParams.ToArray();
                            var stringLayer = new StringLayer(pointerParam, newParams[i]);

                            newOverload = newOverload with { NestedOverload = newOverload, MarshalLayerToNested = stringLayer, InputParameters = stringParams, NameTable = nameTable };
                        }
                        else
                        {
                            int stringParamIndex = i;
                            Parameter? lenParam = null;
                            if (param.Length != null)
                            {
                                string? paramName = IOverloadLayer.GetParameterExpression(param.Length, out var expr);
                                if (paramName == null)
                                {
                                    Logger.Info($"{overload.NativeFunction.EntryPoint} has a COMPSIZE string length for parameter '{param.Name}'!");
                                    continue;
                                }
                                int index = newParams.FindIndex(p => p.Name == paramName);
                                lenParam = newParams[index];
                            }

                            if (lenParam == null)
                            {
                                Logger.Info($"{overload.NativeFunction.EntryPoint} is missing a len attribute for parameter '{param.Name}'");
                                continue;
                            }

                            // FIXME: Can we know if the string is nullable or not?
                            var stringParam = newParams[stringParamIndex] with { Type = new CSRef(CSRef.Type.Out, new CSString(Nullable: false)), Length = null };
                            newParams[stringParamIndex] = stringParam;

                            var stringParams = newParams.ToArray();
                            var stringLayer = new OutStringLayer(pointerParam, lenParam, stringParam);

                            newOverload = newOverload with { NestedOverload = newOverload, MarshalLayerToNested = stringLayer, InputParameters = stringParams, NameTable = nameTable };
                        }
                    }
                }

                if (newOverload == overload)
                {
                    // We didn't do any overloading
                    newOverloads = default;
                    return false;
                }
                else
                {
                    newOverloads = new List<Overload>()
                    {
                        newOverload,
                    };
                    return true;
                }
            }

            class StringLayer : IOverloadLayer
            {
                public readonly Parameter PointerParameter;
                public readonly Parameter StringParameter;

                public StringLayer(Parameter pointerParameter, Parameter stringParameter)
                {
                    PointerParameter = pointerParameter;
                    StringParameter = stringParameter;
                }

                public void WritePrologue(IndentedTextWriter writer, NameTable nameTable)
                {
                    writer.WriteLine($"byte* {nameTable[PointerParameter]} = (byte*)Marshal.StringToCoTaskMemUTF8({nameTable[StringParameter]});");
                }

                public string? WriteEpilogue(IndentedTextWriter writer, NameTable nameTable, string? returnName)
                {
                    writer.WriteLine($"Marshal.FreeCoTaskMem((IntPtr){nameTable[PointerParameter]});");
                    return returnName;
                }
            }

            class OutStringLayer : IOverloadLayer
            {
                public readonly Parameter PointerParameter;
                public readonly Parameter StringParameter;
                public readonly Parameter StringLengthParameter;

                public OutStringLayer(Parameter pointerParameter, Parameter stringLengthParameter, Parameter stringParameter)
                {
                    PointerParameter = pointerParameter;
                    StringParameter = stringParameter;
                    StringLengthParameter = stringLengthParameter;
                }

                public void WritePrologue(IndentedTextWriter writer, NameTable nameTable)
                {
                    writer.WriteLine($"var {nameTable[PointerParameter]} = (byte*)Marshal.AllocCoTaskMem({nameTable[StringLengthParameter]});");
                }

                public string? WriteEpilogue(IndentedTextWriter writer, NameTable nameTable, string? returnName)
                {
                    writer.WriteLine($"{nameTable[StringParameter]} = Marshal.PtrToStringUTF8((IntPtr){nameTable[PointerParameter]})!;");
                    writer.WriteLine($"Marshal.FreeCoTaskMem((IntPtr){nameTable[PointerParameter]});");
                    return returnName;
                }
            }
        }

        class SpanAndArrayOverloader : IOverloader
        {
            public bool TryGenerateOverloads(Overload overload, [NotNullWhen(true)] out List<Overload>? newOverloads)
            {
                if (overload.NativeFunction.EntryPoint == "glShaderSource")
                {
                    newOverloads = default;
                    return false;
                }

                if (overload.NativeFunction.EntryPoint == "glTransformFeedbackVaryings"||
                    overload.NativeFunction.EntryPoint == "glCreateShaderProgramv")
                {
                    Debug.Print($"Fix proper overloads for: {overload.NativeFunction.EntryPoint}");
                    ;

                    newOverloads = default;
                    return false;
                }

                if (overload.NativeFunction.EntryPoint == "glDrawElementsInstancedBaseInstance")
                {
                    ;
                }

                // FIXME: We want to be able to handle more than just one Span and Array overload
                // functions like "glShaderSource" can take more than one array.
                //
                List<Parameter> newParams = new List<Parameter>(overload.InputParameters);
                var genericTypes = overload.GenericTypes;
                Overload arrayOverload = overload;
                Overload spanOverload = overload;
                for (int i = newParams.Count - 1; i >= 0; i--)
                {
                    var param = newParams[i];

                    if (param.Type is CSPointer pt)
                    {
                        if (pt.BaseType is CSChar8)
                        {
                            Logger.Warning($"Char pointer leaked from earlier overloaders: \"{overload.NativeFunction.EntryPoint}\" ({param})");
                            continue;
                        }
                        else if (pt.BaseType is CSPointer)
                        {
                            Logger.Warning($"Pointer leaked from earlier overloaders: \"{overload.NativeFunction.EntryPoint}\" ({param})");
                            continue;
                        }
                    }

                    if (param.Length != null)
                    {
                        string? lengthParamName = IOverloadLayer.GetParameterExpression(param.Length, out var expr);
                        if (lengthParamName != null)
                        {
                            var pointerParam = newParams[i];
                            if (pointerParam.Type is not CSPointer pointer)
                                throw new Exception("A parameter with a 'len' attribute must be a pointer type!");

                            int lengthParamIndex = Array.FindIndex(overload.InputParameters, p => p.Name == lengthParamName);
                            var oldLength = overload.InputParameters[lengthParamIndex];
                            int spanArrayParameterIndex = i;
                            Parameter? paramToBeRemoved = null;
                            bool shouldCalculateLength = overload.InputParameters.Count(p => p.Length == param.Length) <= 1;
                            // If this is the only len attribute that refernces this parameter,
                            // we can remove that parameter as we can calculate it from the length of this parameter (array/span).
                            // FIXME: This check is going to fail if the two 'len' attributes have different "forms" e.g. "n" == "n*4" == "COMPSIZE(n)" etc.
                            if (shouldCalculateLength)
                            {
                                paramToBeRemoved = oldLength;
                                newParams.Remove(oldLength);

                                if (lengthParamIndex < i)
                                {
                                    spanArrayParameterIndex--;
                                    i--;
                                }
                            }

                            BaseCSType baseType;
                            if (pointer.BaseType is CSVoid)
                            {
                                genericTypes = genericTypes.MakeCopyAndGrow(1);
                                genericTypes[^1] = $"T{genericTypes.Length}";
                                baseType = new CSGenericType(genericTypes[^1]);
                            }
                            else
                            {
                                baseType = pointer.BaseType;
                            }

                            var spanNameTable = overload.NameTable.New();
                            var arrayNameTable = overload.NameTable.New();

                            spanNameTable.Rename(pointerParam, $"{pointerParam.Name}_ptr");
                            arrayNameTable.Rename(pointerParam, $"{pointerParam.Name}_ptr");

                            var newSpanParams = spanOverload.InputParameters.Where(p => p != paramToBeRemoved).ToArray();
                            var newArrayParams = arrayOverload.InputParameters.Where(p => p != paramToBeRemoved).ToArray();

                            newSpanParams[spanArrayParameterIndex]  = newSpanParams[spanArrayParameterIndex]  with { Type = new CSSpan(baseType, pointer.Constant) };
                            newArrayParams[spanArrayParameterIndex] = newArrayParams[spanArrayParameterIndex] with { Type = new CSArray(baseType, pointer.Constant) };
                            
                            var spanLayer  = new SpanOrArrayLayer(pointerParam, newSpanParams[spanArrayParameterIndex], oldLength, expr, shouldCalculateLength, baseType);
                            var arrayLayer = new SpanOrArrayLayer(pointerParam, newArrayParams[spanArrayParameterIndex], oldLength, expr, shouldCalculateLength, baseType);

                            spanOverload  = spanOverload with { NestedOverload = spanOverload, MarshalLayerToNested = spanLayer,
                                InputParameters = newSpanParams, NameTable = spanNameTable, GenericTypes = genericTypes };
                            arrayOverload = arrayOverload with { NestedOverload = arrayOverload, MarshalLayerToNested = arrayLayer,
                                InputParameters = newArrayParams, NameTable = arrayNameTable, GenericTypes = genericTypes };
                        }
                    }
                }

                if (arrayOverload == spanOverload)
                {
                    newOverloads = default;
                    return false;
                }
                else
                {
                    newOverloads = new List<Overload>()
                    {
                        spanOverload,
                        arrayOverload,
                        overload,
                    };
                    return true;
                }
            }

            record SpanOrArrayLayer(
                Parameter PointerParameter,
                Parameter SpanOrArrayParameter,
                Parameter LengthParameter,
                Func<string, string> ParameterExpression,
                bool ShouldCalculateLength,
                BaseCSType BaseType) : IOverloadLayer
            {
                private Writer.CsScope Scope;
                public void WritePrologue(IndentedTextWriter writer, NameTable nameTable)
                {
                    // NOTE: We are casting the length field to the target type because some of
                    // the functions don't take `int` types directly, instead they take an `IntPtr`.
                    // But that is fine because we can cast `int`s to `IntPtr`.
                    // This is slightly fragile but it's fine for now.
                    // - Noggin_bops 2021-01-22
                    if (ShouldCalculateLength)
                    {
                        var byteSize = BaseType is CSGenericType ? $" * sizeof({BaseType.ToCSString()})" : "";
                        var lengthExpression = ParameterExpression(nameTable[SpanOrArrayParameter]);
                        writer.WriteLine($"{LengthParameter.Type.ToCSString()} {nameTable[LengthParameter]} = ({LengthParameter.Type.ToCSString()})({lengthExpression}{byteSize});");
                    }

                    writer.WriteLine($"fixed ({PointerParameter.Type.ToCSString()} {nameTable[PointerParameter]} = {nameTable[SpanOrArrayParameter]})");
                    Scope = Writer.Scope(writer);
                }

                public string? WriteEpilogue(IndentedTextWriter writer, NameTable nameTable, string? returnName)
                {
                    Scope.Dispose();
                    return returnName;
                }
            }
        }

        class RefInsteadOfPointerOverloader : IOverloader
        {
            public bool TryGenerateOverloads(Overload overload, [NotNullWhen(true)] out List<Overload>? newOverloads)
            {
                if (overload.NativeFunction.EntryPoint == "glShaderSource")
                {

                }
                Parameter[] parameters = new Parameter[overload.InputParameters.Length];
                List<Parameter> original = new List<Parameter>();
                List<Parameter> changed = new List<Parameter>();
                for (int i = 0; i < overload.InputParameters.Length; i++)
                {
                    Parameter parameter = overload.InputParameters[i];
                    parameters[i] = parameter;

                    if (parameter.Type is CSPointer pt)
                    {
                        bool constant = false;
                        BaseCSType baseType;
                        if (pt.BaseType is CSVoid btVoid)
                        {
                            genericTypes = genericTypes.MakeCopyAndGrow(1);
                            genericTypes[^1] = $"T{genericTypes.Length}";
                            baseType = new CSGenericType(genericTypes[^1]);
                            constant = btVoid.Constant;
                        }
                        else if (pt.BaseType is CSType bt)
                        {
                            baseType = pt.BaseType;
                            constant = bt.Constant;
                        }
                        else
                        {
                            continue;
                        }
                        // FIXME: When do we know it's an out ref type?
                        CSRef.Type refType = CSRef.Type.Ref;
                        string postfix = "_ref";
                        if (constant || pt.Constant)
                        {
                            refType = CSRef.Type.In;
                            postfix = "_in";
                        }

                        original.Add(parameters[i]);

                        parameters[i] = new Parameter(new CSRef(refType, pt.BaseType), parameter.Name + postfix, parameter.Length);

                        changed.Add(parameters[i]);
                    }
                }

                if (changed.Count > 0)
                {
                    var layer = new RefInsteadOfPointerLayer(changed, original);
                    newOverloads = new List<Overload>()
                    {
                        overload with{NestedOverload = overload, MarshalLayerToNested = layer, InputParameters = parameters, GenericTypes = genericTypes},
                        // new Overload(overload, layer, parameters, overload.NativeFunction, overload.ReturnType, overload.ReturnVariableName, genericTypes)
                    };
                    return true;
                }
                else
                {
                    newOverloads = default;
                    return false;
                }
            }

            class RefInsteadOfPointerLayer : IOverloadLayer
            {
                public readonly List<Parameter> RefParameters;
                public readonly List<Parameter> PointerParameters;

                public RefInsteadOfPointerLayer(List<Parameter> refParameters, List<Parameter> pointerParameters)
                {
                    RefParameters = refParameters;
                    PointerParameters = pointerParameters;
                }

                private IndentedTextWriter.Scope Scope;
                public void WritePrologue(IndentedTextWriter writer, NameTable nameTable)
                {
                    for (int i = 0; i < RefParameters.Count; i++)
                    {
                        string type = PointerParameters[i].Type.ToCSString();
                        writer.WriteLine($"fixed ({type} {nameTable[PointerParameters[i]]} = &{nameTable[RefParameters[i]]})");
                    }

                    writer.WriteLine("{");
                    Scope = writer.Indentation();
                }

                public string? WriteEpilogue(IndentedTextWriter writer, NameTable nameTable, string? returnName)
                {
                    Scope.Dispose();
                    writer.WriteLine("}");
                    return returnName;
                }
            }
        }

        public class GenCreateAndDeleteOverloader : IOverloader
        {
            public bool TryGenerateOverloads(Overload overload, [NotNullWhen(true)] out List<Overload>? newOverloads)
            {
                var nativeName = overload.NativeFunction.FunctionName;
                if (!nativeName.StartsWith("Create") && !nativeName.StartsWith("Gen") || !nativeName.EndsWith("s"))
                {
                    newOverloads = default;
                    return false;
                }

                // Here we assume that the last parameter is the pointer parameter.
                var pointerParameter = overload.InputParameters.LastOrDefault();
                var nativeName = overload.NativeFunction.FunctionName;
                if ((!nativeName.StartsWith("Create") && !nativeName.StartsWith("Gen") && !nativeName.StartsWith("Delete")) ||
                    !nativeName.EndsWith("s") || pointerParameter == null ||
                    pointerParameter.Type is not CSPointer pointerParameterType ||
                    pointerParameter.Length == null || pointerParameter.Length is not ParameterReference handleLength)
                {
                    newOverloads = default;
                    return false;
                }
                var newName = nativeName[..^1];

                int lengthParameterIndex = -1;
                Parameter[] parameters = new Parameter[overload.InputParameters.Length - 1];
                for (var i = 0; i < overload.InputParameters.Length - 1; i++)
                {
                    var parameter = overload.InputParameters[i];
                    if (parameter.Name.Equals(handleLength.ParameterName))
                    {
                        lengthParameterIndex = i;
                    }
                    else
                    {
                        parameters[lengthParameterIndex != -1 ? i + 1 : i] = parameter;
                    }
                }

                if (lengthParameterIndex == -1)
                    throw new Exception($"Couldnt find len {handleLength.ParameterName} on method {nativeName}");

                var nameTable = overload.NameTable.New();
                nameTable.Rename(pointerParameter, $"{pointerParameter.Name}_handle");

                parameters[^1] = pointerParameter with { Type = new CSRef(CSRef.Type.Out, pointerParameterType.BaseType), Length = null };

                newOverloads = new List<Overload>()
                {
                    overload with { InputParameters = parameters, NestedOverload = overload, OverloadName = newName,
                        MarshalLayerToNested = new GenAndCreateOverloadLayer(overload.InputParameters[lengthParameterIndex], parameters[^1], pointerParameter)},
                    overload,
                };
                return true;
            }

            private class GenAndCreateOverloadLayer : IOverloadLayer
            {
                public readonly Parameter LengthParameter;
                public readonly Parameter OutParameter;
                public readonly Parameter PointerParameter;

                public GenAndCreateOverloadLayer(Parameter lengthParameter, Parameter outParameter, Parameter pointerParameter)
                {
                    LengthParameter = lengthParameter;
                    OutParameter = outParameter;
                    PointerParameter = pointerParameter;
                }

                public void WritePrologue(IndentedTextWriter writer, NameTable nameTable)
                {
                    writer.WriteLine($"{LengthParameter.Type.ToCSString()} {nameTable[LengthParameter]} = 1;");
                    writer.WriteLine($"Unsafe.SkipInit(out {nameTable[OutParameter]});");
                    writer.WriteLine($"{PointerParameter.Type.ToCSString()} {nameTable[PointerParameter]} = ({PointerParameter.Type.ToCSString()})Unsafe.AsPointer(ref {nameTable[OutParameter]});");
                }

                public string? WriteEpilogue(IndentedTextWriter writer, NameTable nameTable, string? returnName)
                {
                    return returnName;
                }
            }
        }

        public class OutToReturnOverloader : IOverloader
        {
            public bool TryGenerateOverloads(Overload overload, [NotNullWhen(true)] out List<Overload>? newOverloads)
            {
                var oldParameters = overload.InputParameters;
                if (overload.ReturnType is not CSVoid || oldParameters.Length == 0)
                {
                    newOverloads = null;
                    return false;
                }

                // Find the one and only out param, if there are more we do an early return.
                Parameter[] newParameters = new Parameter[oldParameters.Length - 1];
                Parameter? outParameter = null;
                CSRef? outType = null;
                for (int i = 0; i < oldParameters.Length; i++)
                {
                    var parameter = oldParameters[i];
                    if (parameter.Type is CSRef pRef && pRef.RefType == CSRef.Type.Out)
                    {
                        if (outParameter != null)
                        {
                            newOverloads = null;
                            return false;
                        }

                        outType = pRef;
                        outParameter = parameter;
                    }
                    else if (i != oldParameters.Length - 1)
                    {
                        newParameters[outParameter != null ? i + 1 : i] = parameter;
                    }
                }

                if (outType == null || outParameter == null)
                {
                    newOverloads = null;
                    return false;
                }

                newOverloads = new List<Overload>()
                {
                    overload with { NestedOverload = overload, InputParameters = newParameters,
                        ReturnType = outType!.ReferencedType, MarshalLayerToNested = new OutToReturnOverloadLayer(outParameter, outType)},
                    overload,
                };
                return true;
            }

            private class OutToReturnOverloadLayer : IOverloadLayer
            {
                public readonly Parameter OutParameter;
                public readonly CSRef OutType;

                public OutToReturnOverloadLayer(Parameter outParameter, CSRef outType)
                {
                    OutParameter = outParameter;
                    OutType = outType;
                }

                public void WritePrologue(IndentedTextWriter writer, NameTable nameTable)
                {
                    writer.WriteLine($"{OutType.ReferencedType.ToCSString()} {nameTable[OutParameter]};");
                }

                public string? WriteEpilogue(IndentedTextWriter writer, NameTable nameTable, string? returnName)
                {
                    return OutParameter.Name;
                }
            }
        }
    }
}
