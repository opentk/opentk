using GeneratorV2.Data;
using GeneratorV2.Parsing;
using GeneratorV2.Writing;
using GeneratorV2.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GeneratorV2.Process
{
    public static class Processor
    {
        // /!\ IMPORTANT /!\:
        // All return type overloaders need to run before any of the other overloaders.
        // This is to ensure that correct scoping for the new return variables.
        // FIXME: Maybe we dont want classes for these?
        static readonly IOverloader[] Overloaders = new IOverloader[]
        {
            new TrimNameOverloader(),

            new StringReturnOverloader(),

            new BoolOverloader(),
            new MathTypeOverloader(),
            new FunctionPtrToDelegateOverloader(),
            new PointerToOffsetOverloader(),
            new VoidPtrToIntPtrOverloader(),
            new GenCreateAndDeleteOverloader(),
            new StringOverloader(),
            new SpanAndArrayOverloader(),
            new RefInsteadOfPointerOverloader(),
            new OutToReturnOverloader(),
        };

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
            List<RemoveEntry> removeEntries, ProcessedGLInformation glInformation)
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
                parameters.Add(new Parameter(t, NameMangler.MangleParameterName(p.Name), p.Handle, p.Length ?? length));
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
                        PrimitiveType.Bool8 => new CSBool8(bt.Constant),
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
                        PrimitiveType.Nint => new CSType("nint", bt.Constant),

                        PrimitiveType.VoidPtr => new CSPointer(new CSVoid(false), bt.Constant),

                        // FIXME: Should this be treated special?
                        PrimitiveType.Enum => new CSType(group ?? "All", bt.Constant),

                        // FIXME: Are these just normal CSType? probably...
                        PrimitiveType.GLHandleARB => new CSType("GLHandleARB", bt.Constant),
                        PrimitiveType.GLSync => new CSType("GLSync", bt.Constant),

                        PrimitiveType.CLContext => new CSType("CLContext", bt.Constant),
                        PrimitiveType.CLEvent => new CSType("CLEvent", bt.Constant),

                        PrimitiveType.GLDEBUGPROC => new CSFunctionPointer("GLDebugProc", bt.Constant),
                        PrimitiveType.GLDEBUGPROCARB => new CSFunctionPointer("GLDebugProcARB", bt.Constant),
                        PrimitiveType.GLDEBUGPROCKHR => new CSFunctionPointer("GLDebugProcKHR", bt.Constant),
                        PrimitiveType.GLDEBUGPROCAMD => new CSFunctionPointer("GLDebugProcAMD", bt.Constant),
                        PrimitiveType.GLDEBUGPROCNV => new CSFunctionPointer("GLDebugProcNV", bt.Constant),

                        PrimitiveType.Invalid => throw new Exception(),
                        _ => throw new Exception(),
                    };
                default:
                    throw new Exception();
            }
        }

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
                new Overload(null, null, function.Parameters.ToArray(), function, function.ReturnType,
                    new NameTable(), "returnValue", Array.Empty<string>(), function.FunctionName),
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
    }
}
